using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SDL;
using static SDL.SDL3;

public class Program
{
    public static unsafe void Main(string[] args)
    {
        NativeLibrary.SetDllImportResolver(typeof(SDL3).Assembly, (_, assembly, path) => NativeLibrary.Load("@rpath/SDL3.framework/SDL3", assembly, path));
        SDL_RunApp(0, null, &main, IntPtr.Zero);
    }

    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
    private static unsafe int main(int argc, byte** argv)
    {
        // Required to enable calls to GetDisplays() and SetGamepadEventsEnabled().
        SDL_InitSubSystem(SDL_InitFlags.SDL_INIT_VIDEO | SDL_InitFlags.SDL_INIT_GAMEPAD);

        // I don't know why this is relevant, but:
        // 1. It must be an interpolation (e.g. "abc" doesn't work).
        // 2. It must have a decent size (e.g. $"X: {argc}" is too short).
        Console.WriteLine($"Dummy value: {argc}");

        // I don't think it's particularly important what SDL does internally here.
        int count;
        Console.WriteLine((IntPtr)SDL_GetDisplays(&count));

        // Segfault occurs on the following pinvoke.
        SDL_SetGamepadEventsEnabled(true);

        return 0;
    }
}
