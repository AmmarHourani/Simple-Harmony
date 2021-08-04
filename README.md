# Simple-Harmony-1

How to Patch / Detour / Hook .NET managed code using DLL injection

Type 1 where the target method/function is defined in the target process EXE not external DLL

Following the Amazing work of https://github.com/pardeike/Harmony , yet the examples are bit complex for new comers . here is a more simple one

this code includes CLR wrapper in order to be able to inject Harmony .NET DLL into other managed/unmanaged process using common Injectors Like Extreme Injector 3

Just build and place TestCLR.DLL and Test.DLL and 0Harmony.DLL in the same folder , Lunch Extreme Injector 3 , type in the name of the process , add TestCLR.DLL and inject it .

Trick is to include the file that includes the original Types/Classes as a "Resource" in your managed DLL file you intend to inject

Please star this repository if you found it useful

HOOKMYBYHARMONY.EXE is the target process in which the target method/function "Add" is defined

TestCLR.DLL is the DLL we use to attack the target process through injection , i.e. load it into Extreme Injector

TestDLL.DLL is the assembly in which we define our modified method/function

Enjoy


