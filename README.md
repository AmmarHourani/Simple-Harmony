<meta name="google-site-verification" content="97IHobvosg-M5pa6drdiruUJsmOiYvb1A-fFN-n3KAw" />

# Simple-Harmony

How to Patch / Detour / Hook .NET managed code using DLL injection

Following the Amazing work of https://github.com/pardeike/Harmony , yet the examples are bit complex for new comers . here is a more simple one

this code includes CLR wrapper in order to be able to inject Harmony .NET DLL into other managed/unmanaged process using common Injectors Like Extreme Injector 3

Just build and place TestCLR.DLL and Test.DLL and 0Harmony.DLL in the same folder , Lunch Extreme Injector 3 , type in the name of the process , add TestCLR.DLL and inject it .

Trick is to include the file that includes the original Types/Classes as a "Resource" in your managed DLL file you intend to inject

Please star this repository if you found it useful

Enjoy


