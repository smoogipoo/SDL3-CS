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
    public enum SDL_AppResult
    {
        SDL_APP_CONTINUE,
        SDL_APP_SUCCESS,
        SDL_APP_FAILURE,
    }

    public static unsafe partial class SDL3
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_Init(SDL_InitFlags flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_InitSubSystem(SDL_InitFlags flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_QuitSubSystem(SDL_InitFlags flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_InitFlags SDL_WasInit(SDL_InitFlags flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_Quit();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetAppMetadata([NativeTypeName("const char *")] byte* appname, [NativeTypeName("const char *")] byte* appversion, [NativeTypeName("const char *")] byte* appidentifier);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetAppMetadataProperty([NativeTypeName("const char *")] byte* name, [NativeTypeName("const char *")] byte* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAppMetadataProperty", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetAppMetadataProperty([NativeTypeName("const char *")] byte* name);

        [NativeTypeName("#define SDL_INIT_TIMER 0x00000001u")]
        public const uint SDL_INIT_TIMER = 0x00000001U;

        [NativeTypeName("#define SDL_INIT_AUDIO 0x00000010u")]
        public const uint SDL_INIT_AUDIO = 0x00000010U;

        [NativeTypeName("#define SDL_INIT_VIDEO 0x00000020u")]
        public const uint SDL_INIT_VIDEO = 0x00000020U;

        [NativeTypeName("#define SDL_INIT_JOYSTICK 0x00000200u")]
        public const uint SDL_INIT_JOYSTICK = 0x00000200U;

        [NativeTypeName("#define SDL_INIT_HAPTIC 0x00001000u")]
        public const uint SDL_INIT_HAPTIC = 0x00001000U;

        [NativeTypeName("#define SDL_INIT_GAMEPAD 0x00002000u")]
        public const uint SDL_INIT_GAMEPAD = 0x00002000U;

        [NativeTypeName("#define SDL_INIT_EVENTS 0x00004000u")]
        public const uint SDL_INIT_EVENTS = 0x00004000U;

        [NativeTypeName("#define SDL_INIT_SENSOR 0x00008000u")]
        public const uint SDL_INIT_SENSOR = 0x00008000U;

        [NativeTypeName("#define SDL_INIT_CAMERA 0x00010000u")]
        public const uint SDL_INIT_CAMERA = 0x00010000U;

        [NativeTypeName("#define SDL_PROP_APP_METADATA_NAME_STRING \"SDL.app.metadata.name\"")]
        public static ReadOnlySpan<byte> SDL_PROP_APP_METADATA_NAME_STRING => "SDL.app.metadata.name"u8;

        [NativeTypeName("#define SDL_PROP_APP_METADATA_VERSION_STRING \"SDL.app.metadata.version\"")]
        public static ReadOnlySpan<byte> SDL_PROP_APP_METADATA_VERSION_STRING => "SDL.app.metadata.version"u8;

        [NativeTypeName("#define SDL_PROP_APP_METADATA_IDENTIFIER_STRING \"SDL.app.metadata.identifier\"")]
        public static ReadOnlySpan<byte> SDL_PROP_APP_METADATA_IDENTIFIER_STRING => "SDL.app.metadata.identifier"u8;

        [NativeTypeName("#define SDL_PROP_APP_METADATA_CREATOR_STRING \"SDL.app.metadata.creator\"")]
        public static ReadOnlySpan<byte> SDL_PROP_APP_METADATA_CREATOR_STRING => "SDL.app.metadata.creator"u8;

        [NativeTypeName("#define SDL_PROP_APP_METADATA_COPYRIGHT_STRING \"SDL.app.metadata.copyright\"")]
        public static ReadOnlySpan<byte> SDL_PROP_APP_METADATA_COPYRIGHT_STRING => "SDL.app.metadata.copyright"u8;

        [NativeTypeName("#define SDL_PROP_APP_METADATA_URL_STRING \"SDL.app.metadata.url\"")]
        public static ReadOnlySpan<byte> SDL_PROP_APP_METADATA_URL_STRING => "SDL.app.metadata.url"u8;

        [NativeTypeName("#define SDL_PROP_APP_METADATA_TYPE_STRING \"SDL.app.metadata.type\"")]
        public static ReadOnlySpan<byte> SDL_PROP_APP_METADATA_TYPE_STRING => "SDL.app.metadata.type"u8;
    }
}
