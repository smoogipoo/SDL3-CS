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
    public unsafe partial struct SDL_StorageInterface
    {
        [NativeTypeName("Uint32")]
        public uint version;

        [NativeTypeName("bool (*)(void *)")]
        public delegate* unmanaged[Cdecl]<IntPtr, SDLBool> close;

        [NativeTypeName("bool (*)(void *)")]
        public delegate* unmanaged[Cdecl]<IntPtr, SDLBool> ready;

        [NativeTypeName("bool (*)(void *, const char *, SDL_EnumerateDirectoryCallback, void *)")]
        public delegate* unmanaged[Cdecl]<IntPtr, byte*, delegate* unmanaged[Cdecl]<IntPtr, byte*, byte*, int>, IntPtr, SDLBool> enumerate;

        [NativeTypeName("bool (*)(void *, const char *, SDL_PathInfo *)")]
        public delegate* unmanaged[Cdecl]<IntPtr, byte*, SDL_PathInfo*, SDLBool> info;

        [NativeTypeName("bool (*)(void *, const char *, void *, Uint64)")]
        public delegate* unmanaged[Cdecl]<IntPtr, byte*, IntPtr, ulong, SDLBool> read_file;

        [NativeTypeName("bool (*)(void *, const char *, const void *, Uint64)")]
        public delegate* unmanaged[Cdecl]<IntPtr, byte*, IntPtr, ulong, SDLBool> write_file;

        [NativeTypeName("bool (*)(void *, const char *)")]
        public delegate* unmanaged[Cdecl]<IntPtr, byte*, SDLBool> mkdir;

        [NativeTypeName("bool (*)(void *, const char *)")]
        public delegate* unmanaged[Cdecl]<IntPtr, byte*, SDLBool> remove;

        [NativeTypeName("bool (*)(void *, const char *, const char *)")]
        public delegate* unmanaged[Cdecl]<IntPtr, byte*, byte*, SDLBool> rename;

        [NativeTypeName("bool (*)(void *, const char *, const char *)")]
        public delegate* unmanaged[Cdecl]<IntPtr, byte*, byte*, SDLBool> copy;

        [NativeTypeName("Uint64 (*)(void *)")]
        public delegate* unmanaged[Cdecl]<IntPtr, ulong> space_remaining;
    }

    public partial struct SDL_Storage
    {
    }

    public static unsafe partial class SDL3
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Storage* SDL_OpenTitleStorage([NativeTypeName("const char *")] byte* @override, SDL_PropertiesID props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Storage* SDL_OpenUserStorage([NativeTypeName("const char *")] byte* org, [NativeTypeName("const char *")] byte* app, SDL_PropertiesID props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Storage* SDL_OpenFileStorage([NativeTypeName("const char *")] byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Storage* SDL_OpenStorage([NativeTypeName("const SDL_StorageInterface *")] SDL_StorageInterface* iface, [NativeTypeName("void*")] IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_CloseStorage(SDL_Storage* storage);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_StorageReady(SDL_Storage* storage);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_GetStorageFileSize(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, [NativeTypeName("Uint64 *")] ulong* length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_ReadStorageFile(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, [NativeTypeName("void*")] IntPtr destination, [NativeTypeName("Uint64")] ulong length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_WriteStorageFile(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, [NativeTypeName("const void *")] IntPtr source, [NativeTypeName("Uint64")] ulong length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_CreateStorageDirectory(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_EnumerateStorageDirectory(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, [NativeTypeName("SDL_EnumerateDirectoryCallback")] delegate* unmanaged[Cdecl]<IntPtr, byte*, byte*, int> callback, [NativeTypeName("void*")] IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_RemoveStoragePath(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_RenameStoragePath(SDL_Storage* storage, [NativeTypeName("const char *")] byte* oldpath, [NativeTypeName("const char *")] byte* newpath);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_CopyStorageFile(SDL_Storage* storage, [NativeTypeName("const char *")] byte* oldpath, [NativeTypeName("const char *")] byte* newpath);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_GetStoragePathInfo(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, SDL_PathInfo* info);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        public static extern ulong SDL_GetStorageSpaceRemaining(SDL_Storage* storage);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        public static extern byte** SDL_GlobStorageDirectory(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, [NativeTypeName("const char *")] byte* pattern, SDL_GlobFlags flags, int* count);
    }
}
