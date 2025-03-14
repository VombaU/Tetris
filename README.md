# 🕹️ Teturisu
Reimplementation of the arcade era Tetris game; made with Winforms.

![image](https://github.com/user-attachments/assets/30efb6eb-d92b-4e68-b8b0-b2bc117bd676)


# 🖥️ How to playtest
I've included the built game in this repo as well, but if you don't fully trust me yet and want to play it safe, make sure you have the time to go through the arduous building process described below.

# ⚙️ How to build it yourself
1. Make sure you've got Visual Studio installed with .NET Framework 4.7.2 and Winforms
2. Create a new Winforms App project
3. Remove the auto-generated .cs files
4. Copy & paste the files and folders from the 'Base Game' folder into your project
5. Right click the solution in 'Solution Explorer' -> Add -> New Project...
6. Create a Winforms Control project
7. Remove the auto-generated .cs files
8. Copy & paste the files from a component (i.e. LineCounter) that you've not yet included in your solution (AssemblyInfo.cs may be omitted) into the control project
9. Build the control project
10. Right click the 'References' tab under the 'Base Game' project -> Add Reference... -> Browse...
11. Locate and select the DLL file resulted from the previous build
12. Repeat steps 5-11 for every component
13. Build the 'Base Game' project

N.B. Make sure the build type (release / debug) is consistent across all projects; otherwise it's irrelevant
