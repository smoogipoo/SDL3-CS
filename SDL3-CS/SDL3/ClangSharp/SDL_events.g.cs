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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL
{
    public enum SDL_EventType
    {
        SDL_EVENT_FIRST = 0,
        SDL_EVENT_QUIT = 0x100,
        SDL_EVENT_TERMINATING,
        SDL_EVENT_LOW_MEMORY,
        SDL_EVENT_WILL_ENTER_BACKGROUND,
        SDL_EVENT_DID_ENTER_BACKGROUND,
        SDL_EVENT_WILL_ENTER_FOREGROUND,
        SDL_EVENT_DID_ENTER_FOREGROUND,
        SDL_EVENT_LOCALE_CHANGED,
        SDL_EVENT_SYSTEM_THEME_CHANGED,
        SDL_EVENT_DISPLAY_ORIENTATION = 0x151,
        SDL_EVENT_DISPLAY_ADDED,
        SDL_EVENT_DISPLAY_REMOVED,
        SDL_EVENT_DISPLAY_MOVED,
        SDL_EVENT_DISPLAY_CONTENT_SCALE_CHANGED,
        SDL_EVENT_DISPLAY_HDR_STATE_CHANGED,
        SDL_EVENT_DISPLAY_FIRST = SDL_EVENT_DISPLAY_ORIENTATION,
        SDL_EVENT_DISPLAY_LAST = SDL_EVENT_DISPLAY_HDR_STATE_CHANGED,
        SDL_EVENT_WINDOW_SHOWN = 0x202,
        SDL_EVENT_WINDOW_HIDDEN,
        SDL_EVENT_WINDOW_EXPOSED,
        SDL_EVENT_WINDOW_MOVED,
        SDL_EVENT_WINDOW_RESIZED,
        SDL_EVENT_WINDOW_PIXEL_SIZE_CHANGED,
        SDL_EVENT_WINDOW_MINIMIZED,
        SDL_EVENT_WINDOW_MAXIMIZED,
        SDL_EVENT_WINDOW_RESTORED,
        SDL_EVENT_WINDOW_MOUSE_ENTER,
        SDL_EVENT_WINDOW_MOUSE_LEAVE,
        SDL_EVENT_WINDOW_FOCUS_GAINED,
        SDL_EVENT_WINDOW_FOCUS_LOST,
        SDL_EVENT_WINDOW_CLOSE_REQUESTED,
        SDL_EVENT_WINDOW_TAKE_FOCUS,
        SDL_EVENT_WINDOW_HIT_TEST,
        SDL_EVENT_WINDOW_ICCPROF_CHANGED,
        SDL_EVENT_WINDOW_DISPLAY_CHANGED,
        SDL_EVENT_WINDOW_DISPLAY_SCALE_CHANGED,
        SDL_EVENT_WINDOW_OCCLUDED,
        SDL_EVENT_WINDOW_ENTER_FULLSCREEN,
        SDL_EVENT_WINDOW_LEAVE_FULLSCREEN,
        SDL_EVENT_WINDOW_DESTROYED,
        SDL_EVENT_WINDOW_PEN_ENTER,
        SDL_EVENT_WINDOW_PEN_LEAVE,
        SDL_EVENT_WINDOW_FIRST = SDL_EVENT_WINDOW_SHOWN,
        SDL_EVENT_WINDOW_LAST = SDL_EVENT_WINDOW_PEN_LEAVE,
        SDL_EVENT_KEY_DOWN = 0x300,
        SDL_EVENT_KEY_UP,
        SDL_EVENT_TEXT_EDITING,
        SDL_EVENT_TEXT_INPUT,
        SDL_EVENT_KEYMAP_CHANGED,
        SDL_EVENT_KEYBOARD_ADDED,
        SDL_EVENT_KEYBOARD_REMOVED,
        SDL_EVENT_MOUSE_MOTION = 0x400,
        SDL_EVENT_MOUSE_BUTTON_DOWN,
        SDL_EVENT_MOUSE_BUTTON_UP,
        SDL_EVENT_MOUSE_WHEEL,
        SDL_EVENT_MOUSE_ADDED,
        SDL_EVENT_MOUSE_REMOVED,
        SDL_EVENT_JOYSTICK_AXIS_MOTION = 0x600,
        SDL_EVENT_JOYSTICK_BALL_MOTION,
        SDL_EVENT_JOYSTICK_HAT_MOTION,
        SDL_EVENT_JOYSTICK_BUTTON_DOWN,
        SDL_EVENT_JOYSTICK_BUTTON_UP,
        SDL_EVENT_JOYSTICK_ADDED,
        SDL_EVENT_JOYSTICK_REMOVED,
        SDL_EVENT_JOYSTICK_BATTERY_UPDATED,
        SDL_EVENT_JOYSTICK_UPDATE_COMPLETE,
        SDL_EVENT_GAMEPAD_AXIS_MOTION = 0x650,
        SDL_EVENT_GAMEPAD_BUTTON_DOWN,
        SDL_EVENT_GAMEPAD_BUTTON_UP,
        SDL_EVENT_GAMEPAD_ADDED,
        SDL_EVENT_GAMEPAD_REMOVED,
        SDL_EVENT_GAMEPAD_REMAPPED,
        SDL_EVENT_GAMEPAD_TOUCHPAD_DOWN,
        SDL_EVENT_GAMEPAD_TOUCHPAD_MOTION,
        SDL_EVENT_GAMEPAD_TOUCHPAD_UP,
        SDL_EVENT_GAMEPAD_SENSOR_UPDATE,
        SDL_EVENT_GAMEPAD_UPDATE_COMPLETE,
        SDL_EVENT_GAMEPAD_STEAM_HANDLE_UPDATED,
        SDL_EVENT_FINGER_DOWN = 0x700,
        SDL_EVENT_FINGER_UP,
        SDL_EVENT_FINGER_MOTION,
        SDL_EVENT_CLIPBOARD_UPDATE = 0x900,
        SDL_EVENT_DROP_FILE = 0x1000,
        SDL_EVENT_DROP_TEXT,
        SDL_EVENT_DROP_BEGIN,
        SDL_EVENT_DROP_COMPLETE,
        SDL_EVENT_DROP_POSITION,
        SDL_EVENT_AUDIO_DEVICE_ADDED = 0x1100,
        SDL_EVENT_AUDIO_DEVICE_REMOVED,
        SDL_EVENT_AUDIO_DEVICE_FORMAT_CHANGED,
        SDL_EVENT_SENSOR_UPDATE = 0x1200,
        SDL_EVENT_PEN_DOWN = 0x1300,
        SDL_EVENT_PEN_UP,
        SDL_EVENT_PEN_MOTION,
        SDL_EVENT_PEN_BUTTON_DOWN,
        SDL_EVENT_PEN_BUTTON_UP,
        SDL_EVENT_CAMERA_DEVICE_ADDED = 0x1400,
        SDL_EVENT_CAMERA_DEVICE_REMOVED,
        SDL_EVENT_CAMERA_DEVICE_APPROVED,
        SDL_EVENT_CAMERA_DEVICE_DENIED,
        SDL_EVENT_RENDER_TARGETS_RESET = 0x2000,
        SDL_EVENT_RENDER_DEVICE_RESET,
        SDL_EVENT_POLL_SENTINEL = 0x7F00,
        SDL_EVENT_USER = 0x8000,
        SDL_EVENT_LAST = 0xFFFF,
        SDL_EVENT_ENUM_PADDING = 0x7FFFFFFF,
    }

    public partial struct SDL_CommonEvent
    {
        [NativeTypeName("Uint32")]
        public uint type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;
    }

    public partial struct SDL_DisplayEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_DisplayID displayID;

        [NativeTypeName("Sint32")]
        public int data1;
    }

    public partial struct SDL_WindowEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_WindowID windowID;

        [NativeTypeName("Sint32")]
        public int data1;

        [NativeTypeName("Sint32")]
        public int data2;
    }

    public partial struct SDL_KeyboardDeviceEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_KeyboardID which;
    }

    public partial struct SDL_KeyboardEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_WindowID windowID;

        public SDL_KeyboardID which;

        [NativeTypeName("Uint8")]
        public byte state;

        [NativeTypeName("Uint8")]
        public byte repeat;

        [NativeTypeName("Uint8")]
        public byte padding2;

        [NativeTypeName("Uint8")]
        public byte padding3;

        public SDL_Keysym keysym;
    }

    public unsafe partial struct SDL_TextEditingEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_WindowID windowID;

        [NativeTypeName("char *")]
        public byte* text;

        [NativeTypeName("Sint32")]
        public int start;

        [NativeTypeName("Sint32")]
        public int length;
    }

    public unsafe partial struct SDL_TextInputEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_WindowID windowID;

        [NativeTypeName("char *")]
        public byte* text;
    }

    public partial struct SDL_MouseDeviceEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_MouseID which;
    }

    public partial struct SDL_MouseMotionEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_WindowID windowID;

        public SDL_MouseID which;

        [NativeTypeName("Uint32")]
        public uint state;

        public float x;

        public float y;

        public float xrel;

        public float yrel;
    }

    public partial struct SDL_MouseButtonEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_WindowID windowID;

        public SDL_MouseID which;

        [NativeTypeName("Uint8")]
        public byte button;

        [NativeTypeName("Uint8")]
        public byte state;

        [NativeTypeName("Uint8")]
        public byte clicks;

        [NativeTypeName("Uint8")]
        public byte padding;

        public float x;

        public float y;
    }

    public partial struct SDL_MouseWheelEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_WindowID windowID;

        public SDL_MouseID which;

        public float x;

        public float y;

        public SDL_MouseWheelDirection direction;

        public float mouse_x;

        public float mouse_y;
    }

    public partial struct SDL_JoyAxisEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_JoystickID which;

        [NativeTypeName("Uint8")]
        public byte axis;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;

        [NativeTypeName("Uint8")]
        public byte padding3;

        [NativeTypeName("Sint16")]
        public short value;

        [NativeTypeName("Uint16")]
        public ushort padding4;
    }

    public partial struct SDL_JoyBallEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_JoystickID which;

        [NativeTypeName("Uint8")]
        public byte ball;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;

        [NativeTypeName("Uint8")]
        public byte padding3;

        [NativeTypeName("Sint16")]
        public short xrel;

        [NativeTypeName("Sint16")]
        public short yrel;
    }

    public partial struct SDL_JoyHatEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_JoystickID which;

        [NativeTypeName("Uint8")]
        public byte hat;

        [NativeTypeName("Uint8")]
        public byte value;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;
    }

    public partial struct SDL_JoyButtonEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_JoystickID which;

        [NativeTypeName("Uint8")]
        public byte button;

        [NativeTypeName("Uint8")]
        public byte state;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;
    }

    public partial struct SDL_JoyDeviceEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_JoystickID which;
    }

    public partial struct SDL_JoyBatteryEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_JoystickID which;

        public SDL_PowerState state;

        public int percent;
    }

    public partial struct SDL_GamepadAxisEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_JoystickID which;

        [NativeTypeName("Uint8")]
        public byte axis;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;

        [NativeTypeName("Uint8")]
        public byte padding3;

        [NativeTypeName("Sint16")]
        public short value;

        [NativeTypeName("Uint16")]
        public ushort padding4;
    }

    public partial struct SDL_GamepadButtonEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_JoystickID which;

        [NativeTypeName("Uint8")]
        public byte button;

        [NativeTypeName("Uint8")]
        public byte state;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;
    }

    public partial struct SDL_GamepadDeviceEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_JoystickID which;
    }

    public partial struct SDL_GamepadTouchpadEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_JoystickID which;

        [NativeTypeName("Sint32")]
        public int touchpad;

        [NativeTypeName("Sint32")]
        public int finger;

        public float x;

        public float y;

        public float pressure;
    }

    public partial struct SDL_GamepadSensorEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_JoystickID which;

        [NativeTypeName("Sint32")]
        public int sensor;

        [NativeTypeName("float[3]")]
        public _data_e__FixedBuffer data;

        [NativeTypeName("Uint64")]
        public ulong sensor_timestamp;

        [InlineArray(3)]
        public partial struct _data_e__FixedBuffer
        {
            public float e0;
        }
    }

    public partial struct SDL_AudioDeviceEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_AudioDeviceID which;

        [NativeTypeName("Uint8")]
        public byte iscapture;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;

        [NativeTypeName("Uint8")]
        public byte padding3;
    }

    public partial struct SDL_CameraDeviceEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_CameraDeviceID which;
    }

    public partial struct SDL_TouchFingerEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_TouchID touchID;

        public SDL_FingerID fingerID;

        public float x;

        public float y;

        public float dx;

        public float dy;

        public float pressure;

        public SDL_WindowID windowID;
    }

    public partial struct SDL_PenTipEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_WindowID windowID;

        public SDL_PenID which;

        [NativeTypeName("Uint8")]
        public byte tip;

        [NativeTypeName("Uint8")]
        public byte state;

        [NativeTypeName("Uint16")]
        public ushort pen_state;

        public float x;

        public float y;

        [NativeTypeName("float[6]")]
        public _axes_e__FixedBuffer axes;

        [InlineArray(6)]
        public partial struct _axes_e__FixedBuffer
        {
            public float e0;
        }
    }

    public partial struct SDL_PenMotionEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_WindowID windowID;

        public SDL_PenID which;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;

        [NativeTypeName("Uint16")]
        public ushort pen_state;

        public float x;

        public float y;

        [NativeTypeName("float[6]")]
        public _axes_e__FixedBuffer axes;

        [InlineArray(6)]
        public partial struct _axes_e__FixedBuffer
        {
            public float e0;
        }
    }

    public partial struct SDL_PenButtonEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_WindowID windowID;

        public SDL_PenID which;

        [NativeTypeName("Uint8")]
        public byte button;

        [NativeTypeName("Uint8")]
        public byte state;

        [NativeTypeName("Uint16")]
        public ushort pen_state;

        public float x;

        public float y;

        [NativeTypeName("float[6]")]
        public _axes_e__FixedBuffer axes;

        [InlineArray(6)]
        public partial struct _axes_e__FixedBuffer
        {
            public float e0;
        }
    }

    public unsafe partial struct SDL_DropEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_WindowID windowID;

        public float x;

        public float y;

        [NativeTypeName("char *")]
        public byte* source;

        [NativeTypeName("char *")]
        public byte* data;
    }

    public partial struct SDL_ClipboardEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;
    }

    public partial struct SDL_SensorEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_SensorID which;

        [NativeTypeName("float[6]")]
        public _data_e__FixedBuffer data;

        [NativeTypeName("Uint64")]
        public ulong sensor_timestamp;

        [InlineArray(6)]
        public partial struct _data_e__FixedBuffer
        {
            public float e0;
        }
    }

    public partial struct SDL_QuitEvent
    {
        public SDL_EventType type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;
    }

    public partial struct SDL_UserEvent
    {
        [NativeTypeName("Uint32")]
        public uint type;

        [NativeTypeName("Uint32")]
        public uint reserved;

        [NativeTypeName("Uint64")]
        public ulong timestamp;

        public SDL_WindowID windowID;

        [NativeTypeName("Sint32")]
        public int code;

        [NativeTypeName("void*")]
        public IntPtr data1;

        [NativeTypeName("void*")]
        public IntPtr data2;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct SDL_Event
    {
        [FieldOffset(0)]
        [NativeTypeName("Uint32")]
        public uint type;

        [FieldOffset(0)]
        public SDL_CommonEvent common;

        [FieldOffset(0)]
        public SDL_DisplayEvent display;

        [FieldOffset(0)]
        public SDL_WindowEvent window;

        [FieldOffset(0)]
        public SDL_KeyboardDeviceEvent kdevice;

        [FieldOffset(0)]
        public SDL_KeyboardEvent key;

        [FieldOffset(0)]
        public SDL_TextEditingEvent edit;

        [FieldOffset(0)]
        public SDL_TextInputEvent text;

        [FieldOffset(0)]
        public SDL_MouseDeviceEvent mdevice;

        [FieldOffset(0)]
        public SDL_MouseMotionEvent motion;

        [FieldOffset(0)]
        public SDL_MouseButtonEvent button;

        [FieldOffset(0)]
        public SDL_MouseWheelEvent wheel;

        [FieldOffset(0)]
        public SDL_JoyDeviceEvent jdevice;

        [FieldOffset(0)]
        public SDL_JoyAxisEvent jaxis;

        [FieldOffset(0)]
        public SDL_JoyBallEvent jball;

        [FieldOffset(0)]
        public SDL_JoyHatEvent jhat;

        [FieldOffset(0)]
        public SDL_JoyButtonEvent jbutton;

        [FieldOffset(0)]
        public SDL_JoyBatteryEvent jbattery;

        [FieldOffset(0)]
        public SDL_GamepadDeviceEvent gdevice;

        [FieldOffset(0)]
        public SDL_GamepadAxisEvent gaxis;

        [FieldOffset(0)]
        public SDL_GamepadButtonEvent gbutton;

        [FieldOffset(0)]
        public SDL_GamepadTouchpadEvent gtouchpad;

        [FieldOffset(0)]
        public SDL_GamepadSensorEvent gsensor;

        [FieldOffset(0)]
        public SDL_AudioDeviceEvent adevice;

        [FieldOffset(0)]
        public SDL_CameraDeviceEvent cdevice;

        [FieldOffset(0)]
        public SDL_SensorEvent sensor;

        [FieldOffset(0)]
        public SDL_QuitEvent quit;

        [FieldOffset(0)]
        public SDL_UserEvent user;

        [FieldOffset(0)]
        public SDL_TouchFingerEvent tfinger;

        [FieldOffset(0)]
        public SDL_PenTipEvent ptip;

        [FieldOffset(0)]
        public SDL_PenMotionEvent pmotion;

        [FieldOffset(0)]
        public SDL_PenButtonEvent pbutton;

        [FieldOffset(0)]
        public SDL_DropEvent drop;

        [FieldOffset(0)]
        public SDL_ClipboardEvent clipboard;

        [FieldOffset(0)]
        [NativeTypeName("Uint8[128]")]
        public _padding_e__FixedBuffer padding;

        [InlineArray(128)]
        public partial struct _padding_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public enum SDL_eventaction
    {
        SDL_ADDEVENT,
        SDL_PEEKEVENT,
        SDL_GETEVENT,
    }

    public static unsafe partial class SDL3
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_PumpEvents();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_PeepEvents(SDL_Event* events, int numevents, SDL_eventaction action, [NativeTypeName("Uint32")] uint minType, [NativeTypeName("Uint32")] uint maxType);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasEvent([NativeTypeName("Uint32")] uint type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasEvents([NativeTypeName("Uint32")] uint minType, [NativeTypeName("Uint32")] uint maxType);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_FlushEvent([NativeTypeName("Uint32")] uint type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_FlushEvents([NativeTypeName("Uint32")] uint minType, [NativeTypeName("Uint32")] uint maxType);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_PollEvent(SDL_Event* @event);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_WaitEvent(SDL_Event* @event);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_WaitEventTimeout(SDL_Event* @event, [NativeTypeName("Sint32")] int timeoutMS);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_PushEvent(SDL_Event* @event);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetEventFilter([NativeTypeName("SDL_EventFilter")] delegate* unmanaged[Cdecl]<IntPtr, SDL_Event*, int> filter, [NativeTypeName("void*")] IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GetEventFilter([NativeTypeName("SDL_EventFilter *")] delegate* unmanaged[Cdecl]<IntPtr, SDL_Event*, int>* filter, [NativeTypeName("void **")] IntPtr* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_AddEventWatch([NativeTypeName("SDL_EventFilter")] delegate* unmanaged[Cdecl]<IntPtr, SDL_Event*, int> filter, [NativeTypeName("void*")] IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DelEventWatch([NativeTypeName("SDL_EventFilter")] delegate* unmanaged[Cdecl]<IntPtr, SDL_Event*, int> filter, [NativeTypeName("void*")] IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_FilterEvents([NativeTypeName("SDL_EventFilter")] delegate* unmanaged[Cdecl]<IntPtr, SDL_Event*, int> filter, [NativeTypeName("void*")] IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetEventEnabled([NativeTypeName("Uint32")] uint type, SDL_bool enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_EventEnabled([NativeTypeName("Uint32")] uint type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_RegisterEvents(int numevents);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("void*")]
        public static extern IntPtr SDL_AllocateEventMemory([NativeTypeName("size_t")] nuint size);

        [NativeTypeName("#define SDL_RELEASED 0")]
        public const int SDL_RELEASED = 0;

        [NativeTypeName("#define SDL_PRESSED 1")]
        public const int SDL_PRESSED = 1;

        [NativeTypeName("#define SDL_TEXTEDITINGEVENT_TEXT_SIZE 64")]
        public const int SDL_TEXTEDITINGEVENT_TEXT_SIZE = 64;

        [NativeTypeName("#define SDL_DROPEVENT_DATA_SIZE 64")]
        public const int SDL_DROPEVENT_DATA_SIZE = 64;
    }
}
