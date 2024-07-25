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

using System.Runtime.InteropServices;

namespace SDL
{
    public partial struct SDL_Mutex
    {
    }

    public partial struct SDL_RWLock
    {
    }

    public partial struct SDL_Semaphore
    {
    }

    public partial struct SDL_Condition
    {
    }

    public static unsafe partial class SDL3
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Mutex* SDL_CreateMutex();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LockMutex(SDL_Mutex* mutex);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_TryLockMutex(SDL_Mutex* mutex);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnlockMutex(SDL_Mutex* mutex);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyMutex(SDL_Mutex* mutex);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_RWLock* SDL_CreateRWLock();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LockRWLockForReading(SDL_RWLock* rwlock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LockRWLockForWriting(SDL_RWLock* rwlock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_TryLockRWLockForReading(SDL_RWLock* rwlock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_TryLockRWLockForWriting(SDL_RWLock* rwlock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnlockRWLock(SDL_RWLock* rwlock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyRWLock(SDL_RWLock* rwlock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Semaphore* SDL_CreateSemaphore([NativeTypeName("Uint32")] uint initial_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroySemaphore(SDL_Semaphore* sem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_WaitSemaphore(SDL_Semaphore* sem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_TryWaitSemaphore(SDL_Semaphore* sem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_WaitSemaphoreTimeout(SDL_Semaphore* sem, [NativeTypeName("Sint32")] int timeoutMS);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SignalSemaphore(SDL_Semaphore* sem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_GetSemaphoreValue(SDL_Semaphore* sem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Condition* SDL_CreateCondition();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyCondition(SDL_Condition* cond);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SignalCondition(SDL_Condition* cond);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_BroadcastCondition(SDL_Condition* cond);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_WaitCondition(SDL_Condition* cond, SDL_Mutex* mutex);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_WaitConditionTimeout(SDL_Condition* cond, SDL_Mutex* mutex, [NativeTypeName("Sint32")] int timeoutMS);

        [NativeTypeName("#define SDL_MUTEX_TIMEDOUT 1")]
        public const int SDL_MUTEX_TIMEDOUT = 1;

        [NativeTypeName("#define SDL_RWLOCK_TIMEDOUT SDL_MUTEX_TIMEDOUT")]
        public const int SDL_RWLOCK_TIMEDOUT = 1;
    }
}
