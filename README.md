# NetLoader

![Preview](https://i.ibb.co/PGn2k6D/icons8-loading-sign-64.png)

## Introduction
Load Your .NET DLLs by Injecting them in the Process as in c ++ .

- Have you ever wondered how to inject a DLL made in .net like those of c ++?

Unfortunately there is a lot of difference between native libraries (native code), not with .NET assemblies (IL code) .
Well I have tried an infinity of things, such as CLR Hosting from a c ++ dll to load a .Net Dll. [Failure, Very Unstable.]

Anyway, a vague solution to this matter was NetLoader. 

## How does it work?

The Native DLL [ASIExNet.dll] is injected which executes the .Net Assembly with command lines [NetLoader.exe] which is in charge of Executing As a Plugin your .net DLL [Your Code]

You : Come on, this is not injecting my DLL In the process I want, you are only executing my code!!

I : Well. It is basically the objective you want to achieve by injecting your dll. You want to run your code!!!

You can download the compiled project here: [Download Realse](https://github.com/DestroyerDarkNess/NetLoader/releases/download/v0.1/NetLoaderc0.1.zip)

## Instructions

1) Download The Compiled Project. 
2) Create Your .Net Dll based on the Example that you leave in the Project.
3) Put your Compiled DLL Inside the [NetPlugins] Folder.
4) Inject The Native DLL [ASIExNet.dll] into The process you want your DLL to load.
5) Done! The Loader will take care of Executing The Code of your DLL.

![Preview](https://i.ibb.co/8bJDWL2/1.png)

![Preview](https://i.ibb.co/ckKzVPH/1-5.png)

 ## Contributors
- Destroyer : Creator and Developer.  / Discord : Destroyer#8328 
- IdiotForever : Developer. / Discord : --------



