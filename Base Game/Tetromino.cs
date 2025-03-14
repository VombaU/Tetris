using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using System.IO;
using System.Drawing;
using System.Linq;

namespace Tetris
{
    public partial class TetrisGame
    {
        public class Tetromino
        {
            public static class Type
            {
                public const int Other = 1;
                public const int OShape = 2;
                public const int IShape = 4;
            }
            private static readonly Random rand = new Random();

            public static event Action UnableToCreate;
            public static event Action<Point[], int> Locked;

            public static Point[][] SHAPES;
            public static Dictionary<int, Point[][]> WALL_KICK_TESTS;

            public static void Init()
            {
                var serializer = new DeserializerBuilder().WithNamingConvention(PascalCaseNamingConvention.Instance).Build();

                SHAPES = serializer.Deserialize<Point[][]>(File.ReadAllText(Directory.GetCurrentDirectory() + @"\Tetromino Data\Shape Data.yml"));
                WALL_KICK_TESTS = serializer.Deserialize<Dictionary<int, Point[][]>>(File.ReadAllText(Directory.GetCurrentDirectory() + @"\Tetromino Data\Wall Kick Tests.yml"));
            }

            public Point Center;
            public Point[] Blocks = new Point[4];
            private int Rotation = 0;
            private int ShapeType;
            public int ShapeIndex;
            public int Color;

            public Tetromino(Point spawnLocation, int color)
            {
                Center = spawnLocation;
                Color = color;
                ShapeIndex = rand.Next(SHAPES.Length);

                switch (ShapeIndex)
                {
                    case Type.IShape:
                        ShapeType = Type.IShape;
                        break;
                    case Type.OShape:
                        ShapeType = Type.OShape;
                        break;
                    default:
                        ShapeType = Type.Other;
                        break;
                }

                for (int i = 0; i < 4; ++i)
                {
                    Blocks[i].X = Center.X + SHAPES[ShapeIndex][i].X;
                    Blocks[i].Y = Center.Y + SHAPES[ShapeIndex][i].Y;


                    if (!IsOnValidSpace(Blocks[i]))
                    {
                        Blocks = null;
                        UnableToCreate.Invoke();
                        break;
                    }
                }
            }

            public bool Translate(int dx, int dy, Point[] imaginaryBlocks = null)
            {
                Point[] updatedBlocks = new Point[4];
                Point[] blocksToTranslate = imaginaryBlocks == null ? Blocks : imaginaryBlocks;

                for (int i = 0; i < 4; ++i)
                {
                    updatedBlocks[i] = blocksToTranslate[i];
                    updatedBlocks[i].X += dx;
                    updatedBlocks[i].Y += dy;

                    if (!IsOnValidSpace(updatedBlocks[i]))
                        return false;
                }

                Blocks = updatedBlocks;
                Center.X += dx;
                Center.Y += dy;
                return true;
            }

            private bool IsOnValidSpace(Point block)
            {
                return (block.X >= 0 && block.X < PlayArea.ColumnCount && block.Y >= 0 && block.Y < PlayArea.RowCount) // Pătrat în afara zonei de joc?
                        && (PlayArea.Matrix[block.Y][block.X] == 0); // Pătrat ocupat?
            }

            public void Rotate()
            {
                if (ShapeType == Type.OShape)
                    return;

                Point[] updatedBlocks = new Point[4];
                bool invalidRotation = false;

                for (int i = 0; i < 4; ++i)
                {
                    updatedBlocks[i].X = Center.Y + Center.X - Blocks[i].Y;
                    updatedBlocks[i].Y = Center.Y - Center.X + Blocks[i].X;

                    if (!IsOnValidSpace(updatedBlocks[i]))
                        invalidRotation = true;
                }

                if (invalidRotation)
                {
                    for (int test = 0; test < 4 && invalidRotation; ++test)
                    {
                        Point offset = WALL_KICK_TESTS[ShapeType][Rotation][test];
                        invalidRotation = (Translate(offset.X, offset.Y, updatedBlocks) == false);
                    }
                    if (invalidRotation)
                        return;
                }
                else
                    Blocks = updatedBlocks;

                if (ShapeType == Type.IShape)
                {
                    if (Rotation == 1)
                        Translate(-1, -1);
                    if (Rotation == 3)
                        Translate(1, 1);
                }

                Rotation = (Rotation + 1) % 4;
            }

            public void Lock()
            {
                foreach (Point block in Blocks)
                {
                    PlayArea.Matrix[block.Y][block.X] = Color + 1;
                }
                Locked.Invoke(Blocks, ShapeIndex);
            }
        }
    }
}
