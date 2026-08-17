// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;

namespace SDL
{
    [Typedef]
    public enum SDL_Time : Int64;

    public partial class SDL3
    {
        [Macro]
        public static uint SDL_FOURCC(byte A, byte B, byte C, byte D) => (uint)((A << 0) | (B << 8) | (C << 16) | (D << 24));

        [Obsolete("Do not use.")] // used internally
        public interface ISDLInterface
        {
            internal uint version { set; }
        }

        [Macro]
        public static unsafe void SDL_INIT_INTERFACE<T>(out T iface)
#pragma warning disable CS0618 // Type or member is obsolete
            where T : unmanaged, ISDLInterface
#pragma warning restore CS0618 // Type or member is obsolete
        {
            iface = default;
            iface.version = (uint)sizeof(T);
        }

        public static unsafe void SDL_free(void* mem) => SDL_free((IntPtr)mem);
    }
}
