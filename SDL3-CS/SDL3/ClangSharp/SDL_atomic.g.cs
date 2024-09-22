/*
  <auto-generated/>
  C# bindings for Simple DirectMedia Layer.
  Original copyright notice of input files:

  Simple DirectMedia Layer
  Copyright (C) 1997-2024 Sam Lantinga <slouken@libsdl.org>

  This software is provided 'as-is', without any express or implied
  warranty.  In no event will the authors be held liable for any damages
  arising from the use of this software.

  Permission is granted to anyone to use this software for any purpose,
  including commercial applications, and to alter it and redistribute it
  freely, subject to the following restrictions:

  1. The origin of this software must not be misrepresented; you must not
     claim that you wrote the original software. If you use this software
     in a product, an acknowledgment in the product documentation would be
     appreciated but is not required.
  2. Altered source versions must be plainly marked as such, and must not be
     misrepresented as being the original software.
  3. This notice may not be removed or altered from any source distribution.
*/

using System;
using System.Runtime.InteropServices;

namespace SDL
{
    public partial struct SDL_AtomicInt
    {
        public int value;
    }

    public partial struct SDL_AtomicU32
    {
        [NativeTypeName("Uint32")]
        public uint value;
    }

    public static unsafe partial class SDL3
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_TryLockSpinlock([NativeTypeName("SDL_SpinLock *")] int* @lock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LockSpinlock([NativeTypeName("SDL_SpinLock *")] int* @lock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnlockSpinlock([NativeTypeName("SDL_SpinLock *")] int* @lock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_MemoryBarrierReleaseFunction();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_MemoryBarrierAcquireFunction();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_CompareAndSwapAtomicInt(SDL_AtomicInt* a, int oldval, int newval);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetAtomicInt(SDL_AtomicInt* a, int v);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetAtomicInt(SDL_AtomicInt* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_AddAtomicInt(SDL_AtomicInt* a, int v);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_CompareAndSwapAtomicU32(SDL_AtomicU32* a, [NativeTypeName("Uint32")] uint oldval, [NativeTypeName("Uint32")] uint newval);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_SetAtomicU32(SDL_AtomicU32* a, [NativeTypeName("Uint32")] uint v);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_GetAtomicU32(SDL_AtomicU32* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_CompareAndSwapAtomicPointer([NativeTypeName("void **")] IntPtr* a, [NativeTypeName("void*")] IntPtr oldval, [NativeTypeName("void*")] IntPtr newval);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("void*")]
        public static extern IntPtr SDL_SetAtomicPointer([NativeTypeName("void **")] IntPtr* a, [NativeTypeName("void*")] IntPtr v);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("void*")]
        public static extern IntPtr SDL_GetAtomicPointer([NativeTypeName("void **")] IntPtr* a);
    }
}
