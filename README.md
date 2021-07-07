# UT2004-DevTool
Development tool to more easily work with Unreal Tournament 2004 and it's internal Unrealscript language.  
  
There is not much error checking right now but as long as you fill out all the fields via the handy buttons everything should be fine!  

Launch UT2004 button is disabled. I don't remember if this is caused by steam integration or something else, but UDEbugger is what you want to use anyway.  

# Visual Studio
Created in C# using Visual Studio 2019 with WinForms

# Creating A Local Dev Environment
Select your UT2004 install folder with "Choose UT2004"  

Select where you want your dev environment for UT2004 with "Choose Dev Env"  

The text boxes will fill out with respective selections  

Click "Create Local Dev Env" to automatically copy all of your UT2004 install files and folders to the dev env  

This will also automatically extract the debug unreal packages and overwrite the release ones inside the dev evironment folder while your install folder stays nice and ready to play.  

This will also automatically extract all of the classes from the compiled files so that you can also see those inside UDEbugger. Not every class can be extracted so there will still be some things you might try to click on and it will give an error about loading the file, don't worry about those.  

# Manual File Edit
To see your projects classes and having the ability to break on your own code is acheived by adding:  

[Editor.EditorEngine]  
EditPackages=3SPNCv42102  

into your UT2004.ini in your local dev system folder.  

# Compiling
Select your project folder with "Choose Project Folder" (eg 3SPNCv42102)  

Select your project's .ini file "Choose Project .ini" (eg 3SPNCv42102\make.ini)  

Select your local dev environment UT2004 System folder with "Choose UT2004 System Folder". This is to give access to UCC and required files to compile and place into proper directory.  

Hit compile! If you want to actually debug simply check the debug check box. This will compile your project in debug mode and place the files in your system folder similar to UMake.  

If you did indeed compile as debug you can then hit "Launch UDEbugger" and it will launch the UDEbugger application from the System folder.  

If you launch in full screen it won't really let you use the debugger for some reason, so I recommend launching with -windowed checked and setting your preferred windowed resolution for debug.  

Make sure you click apply launch options and the text will turn green and say on, then you are good to launch UDEbugger with those launch options (this does NOT modify your .ini)  


