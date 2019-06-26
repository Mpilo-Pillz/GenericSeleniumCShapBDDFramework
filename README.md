# GenericSeleniumCShapBDDFramework
# Getting Started
***For picures, a word document will be attached***
Download Visual Studio IDE (Community, Professionalor or Ultimate not Visual Studio Code) from the link https://visualstudio.microsoft.com/
/...Steps missing..to add later../
1. Open Visual Studio and create a new Project of type C# Class library with the .NET version 4.5.
2. On File Menu Bar, click on "Tools => Extensions and Updates"
3. On the Left Pane, click on "Online"
4. Press ctrl + E on the keyboard to search or click on the Search text box on the top right corner then type "SpecFlow for Visual Studio [currentYear]"
5. Click to  Install "SpecFlow For Visual Studio 2019"
6. Restart Visual Studio and Click on Modify on the prompt

# Creating a Spec Flow Project - Installing Dependencies
Create a New Project  
  *C# Class Library 
  *Project name >> Next 
Dependencies (Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution ) 
1. **Dependency                    Version 
2. Selenium.Webdriver            v3.9.0 
3. Selenium.Chrome.Webdriver     v2.46.0 
4. Selenium.Support              v3.0.1 
5. NUnit                         v3.11.0 
6. Appium.Webdriver              latest 
7. Castle.Core                   v3.3.3 
8. Newtonsoft.json               v10.0.1 
9. SpecFlow                      v2.3.2 
10. SpecRun.Runner                v1.8.5 
11. SpecRun.SpecFlow.2-3-0        v1.8.5 
12. Sytem.ValueTuple              v4.3.0 
13. Clean Solution  
14. Build Solution 

# Creating the WorkSpace - Folder Structure
Create Folders 
 1. Folder one = Feature. This is where '.feature' files will be stored 
 2.  Folder 2 = *Step . this is where .cs step definition files will be stored
