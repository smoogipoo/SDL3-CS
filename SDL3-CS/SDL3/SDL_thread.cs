// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;

namespace SDL
{
    [Typedef]
    public enum SDL_TLSID : UInt32;

    [Typedef]
    public enum SDL_ThreadID : UInt64;

    public static partial class SDL3
    {
        [Constant]
        public const int SDL_BeginThreadFunction = 0;

        [Constant]
        public const int SDL_EndThreadFunction = 0;
    }
}
