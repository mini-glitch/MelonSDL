using System.Collections.Generic;
using SDL2;

namespace Melon
{
	public enum Keyboard
	{
		Unknown = SDL.SDL_Scancode.SDL_SCANCODE_UNKNOWN,
		A = SDL.SDL_Scancode.SDL_SCANCODE_A,
		B = SDL.SDL_Scancode.SDL_SCANCODE_B,
		C = SDL.SDL_Scancode.SDL_SCANCODE_C,
		D = SDL.SDL_Scancode.SDL_SCANCODE_D,
		E = SDL.SDL_Scancode.SDL_SCANCODE_E,
		F = SDL.SDL_Scancode.SDL_SCANCODE_F,
		G = SDL.SDL_Scancode.SDL_SCANCODE_G,
		H = SDL.SDL_Scancode.SDL_SCANCODE_H,
		I = SDL.SDL_Scancode.SDL_SCANCODE_I,
		J = SDL.SDL_Scancode.SDL_SCANCODE_J,
		K = SDL.SDL_Scancode.SDL_SCANCODE_K,
		L = SDL.SDL_Scancode.SDL_SCANCODE_L,
		M = SDL.SDL_Scancode.SDL_SCANCODE_M,
		N = SDL.SDL_Scancode.SDL_SCANCODE_N,
		O = SDL.SDL_Scancode.SDL_SCANCODE_O,
		P = SDL.SDL_Scancode.SDL_SCANCODE_P,
		Q = SDL.SDL_Scancode.SDL_SCANCODE_Q,
		R = SDL.SDL_Scancode.SDL_SCANCODE_R,
		S = SDL.SDL_Scancode.SDL_SCANCODE_S,
		T = SDL.SDL_Scancode.SDL_SCANCODE_T,
		U = SDL.SDL_Scancode.SDL_SCANCODE_U,
		V = SDL.SDL_Scancode.SDL_SCANCODE_V,
		W = SDL.SDL_Scancode.SDL_SCANCODE_W,
		X = SDL.SDL_Scancode.SDL_SCANCODE_X,
		Y = SDL.SDL_Scancode.SDL_SCANCODE_Y,
		Z = SDL.SDL_Scancode.SDL_SCANCODE_Z,
		Num_1 = SDL.SDL_Scancode.SDL_SCANCODE_1,
		Num_2 = SDL.SDL_Scancode.SDL_SCANCODE_2,
		Num_3 = SDL.SDL_Scancode.SDL_SCANCODE_3,
		Num_4 = SDL.SDL_Scancode.SDL_SCANCODE_4,
		Num_5 = SDL.SDL_Scancode.SDL_SCANCODE_5,
		Num_6 = SDL.SDL_Scancode.SDL_SCANCODE_6,
		Num_7 = SDL.SDL_Scancode.SDL_SCANCODE_7,
		Num_8 = SDL.SDL_Scancode.SDL_SCANCODE_8,
		Num_9 = SDL.SDL_Scancode.SDL_SCANCODE_9,
		Num_0 = SDL.SDL_Scancode.SDL_SCANCODE_0,
		Return = SDL.SDL_Scancode.SDL_SCANCODE_RETURN,
		Escape = SDL.SDL_Scancode.SDL_SCANCODE_ESCAPE,
		Backspace = SDL.SDL_Scancode.SDL_SCANCODE_BACKSPACE,
		Tab = SDL.SDL_Scancode.SDL_SCANCODE_TAB,
		Space = SDL.SDL_Scancode.SDL_SCANCODE_SPACE,
		Minus = SDL.SDL_Scancode.SDL_SCANCODE_MINUS,
		Equals = SDL.SDL_Scancode.SDL_SCANCODE_EQUALS,
		LeftBracket = SDL.SDL_Scancode.SDL_SCANCODE_LEFTBRACKET,
		RightBracket = SDL.SDL_Scancode.SDL_SCANCODE_RIGHTBRACKET,
		Backslash = SDL.SDL_Scancode.SDL_SCANCODE_BACKSLASH,
		Nonushash = SDL.SDL_Scancode.SDL_SCANCODE_NONUSHASH,
		Semicolon = SDL.SDL_Scancode.SDL_SCANCODE_SEMICOLON,
		Apostrophe = SDL.SDL_Scancode.SDL_SCANCODE_APOSTROPHE,
		Grave = SDL.SDL_Scancode.SDL_SCANCODE_GRAVE,
		Comma = SDL.SDL_Scancode.SDL_SCANCODE_COMMA,
		Period = SDL.SDL_Scancode.SDL_SCANCODE_PERIOD,
		Slash = SDL.SDL_Scancode.SDL_SCANCODE_SLASH,
		Capslock = SDL.SDL_Scancode.SDL_SCANCODE_CAPSLOCK,
		F1 = SDL.SDL_Scancode.SDL_SCANCODE_F1,
		F2 = SDL.SDL_Scancode.SDL_SCANCODE_F2,
		F3 = SDL.SDL_Scancode.SDL_SCANCODE_F3,
		F4 = SDL.SDL_Scancode.SDL_SCANCODE_F4,
		F5 = SDL.SDL_Scancode.SDL_SCANCODE_F5,
		F6 = SDL.SDL_Scancode.SDL_SCANCODE_F6,
		F7 = SDL.SDL_Scancode.SDL_SCANCODE_F7,
		F8 = SDL.SDL_Scancode.SDL_SCANCODE_F8,
		F9 = SDL.SDL_Scancode.SDL_SCANCODE_F9,
		F10 = SDL.SDL_Scancode.SDL_SCANCODE_F10,
		F11 = SDL.SDL_Scancode.SDL_SCANCODE_F11,
		F12 = SDL.SDL_Scancode.SDL_SCANCODE_F12,
		Printscreen = SDL.SDL_Scancode.SDL_SCANCODE_PRINTSCREEN,
		ScrollLock = SDL.SDL_Scancode.SDL_SCANCODE_SCROLLLOCK,
		Pause = SDL.SDL_Scancode.SDL_SCANCODE_PAUSE,
		Insert = SDL.SDL_Scancode.SDL_SCANCODE_INSERT,
		Home = SDL.SDL_Scancode.SDL_SCANCODE_HOME,
		PageUp = SDL.SDL_Scancode.SDL_SCANCODE_PAGEUP,
		Delete = SDL.SDL_Scancode.SDL_SCANCODE_DELETE,
		End = SDL.SDL_Scancode.SDL_SCANCODE_END,
		PageDown = SDL.SDL_Scancode.SDL_SCANCODE_PAGEDOWN,
		Right = SDL.SDL_Scancode.SDL_SCANCODE_RIGHT,
		Left = SDL.SDL_Scancode.SDL_SCANCODE_LEFT,
		Down = SDL.SDL_Scancode.SDL_SCANCODE_DOWN,
		Up = SDL.SDL_Scancode.SDL_SCANCODE_UP,
		NumLockClear = SDL.SDL_Scancode.SDL_SCANCODE_NUMLOCKCLEAR,
		Keypad_Divide = SDL.SDL_Scancode.SDL_SCANCODE_KP_DIVIDE,
		Keypad_Multiply = SDL.SDL_Scancode.SDL_SCANCODE_KP_MULTIPLY,
		Keypad_Minus = SDL.SDL_Scancode.SDL_SCANCODE_KP_MINUS,
		Keypad_Plus = SDL.SDL_Scancode.SDL_SCANCODE_KP_PLUS,
		Keypad_Enter = SDL.SDL_Scancode.SDL_SCANCODE_KP_ENTER,
		Keypad_1 = SDL.SDL_Scancode.SDL_SCANCODE_KP_1,
		Keypad_2 = SDL.SDL_Scancode.SDL_SCANCODE_KP_2,
		Keypad_3 = SDL.SDL_Scancode.SDL_SCANCODE_KP_3,
		Keypad_4 = SDL.SDL_Scancode.SDL_SCANCODE_KP_4,
		Keypad_5 = SDL.SDL_Scancode.SDL_SCANCODE_KP_5,
		Keypad_6 = SDL.SDL_Scancode.SDL_SCANCODE_KP_6,
		Keypad_7 = SDL.SDL_Scancode.SDL_SCANCODE_KP_7,
		Keypad_8 = SDL.SDL_Scancode.SDL_SCANCODE_KP_8,
		Keypad_9 = SDL.SDL_Scancode.SDL_SCANCODE_KP_9,
		Keypad_0 = SDL.SDL_Scancode.SDL_SCANCODE_KP_0,
		Keypad_Period = SDL.SDL_Scancode.SDL_SCANCODE_KP_PERIOD,
		NonusBlackslash = SDL.SDL_Scancode.SDL_SCANCODE_NONUSBACKSLASH,
		Application = SDL.SDL_Scancode.SDL_SCANCODE_APPLICATION,
		Power = SDL.SDL_Scancode.SDL_SCANCODE_POWER,
		Keypad_Equals = SDL.SDL_Scancode.SDL_SCANCODE_KP_EQUALS,
		F13 = SDL.SDL_Scancode.SDL_SCANCODE_F13,
		F14 = SDL.SDL_Scancode.SDL_SCANCODE_F14,
		F15 = SDL.SDL_Scancode.SDL_SCANCODE_F15,
		F16 = SDL.SDL_Scancode.SDL_SCANCODE_F16,
		F17 = SDL.SDL_Scancode.SDL_SCANCODE_F17,
		F18 = SDL.SDL_Scancode.SDL_SCANCODE_F18,
		F19 = SDL.SDL_Scancode.SDL_SCANCODE_F19,
		F20 = SDL.SDL_Scancode.SDL_SCANCODE_F20,
		F21 = SDL.SDL_Scancode.SDL_SCANCODE_F21,
		F22 = SDL.SDL_Scancode.SDL_SCANCODE_F22,
		F23 = SDL.SDL_Scancode.SDL_SCANCODE_F23,
		F24 = SDL.SDL_Scancode.SDL_SCANCODE_F24,
		Execute = SDL.SDL_Scancode.SDL_SCANCODE_EXECUTE,
		Help = SDL.SDL_Scancode.SDL_SCANCODE_HELP,
		Menu = SDL.SDL_Scancode.SDL_SCANCODE_MENU,
		Select = SDL.SDL_Scancode.SDL_SCANCODE_SELECT,
		Stop = SDL.SDL_Scancode.SDL_SCANCODE_STOP,
		Again = SDL.SDL_Scancode.SDL_SCANCODE_AGAIN,
		Undo = SDL.SDL_Scancode.SDL_SCANCODE_UNDO,
		Cut = SDL.SDL_Scancode.SDL_SCANCODE_CUT,
		Copy = SDL.SDL_Scancode.SDL_SCANCODE_COPY,
		Paste = SDL.SDL_Scancode.SDL_SCANCODE_PASTE,
		Find = SDL.SDL_Scancode.SDL_SCANCODE_FIND,
		Mute = SDL.SDL_Scancode.SDL_SCANCODE_MUTE,
		VolumeUp = SDL.SDL_Scancode.SDL_SCANCODE_VOLUMEUP,
		VolumeDown = SDL.SDL_Scancode.SDL_SCANCODE_VOLUMEDOWN,

		//EY_LOCKINGCAPSLOCK       = SDL.SDL_Scancode.SDL_SCANCODE_LOCKINGCAPSLOCK,
		//EY_LOCKINGNUMLOCK        = SDL.SDL_Scancode.SDL_SCANCODE_LOCKINGNUMLOCK,
		//EY_LOCKINGSCROLLLOCK     = SDL.SDL_Scancode.SDL_SCANCODE_LOCKINGSCROLLLOCK,

		Keypad_Comman = SDL.SDL_Scancode.SDL_SCANCODE_KP_COMMA,
		Keypad_EqualsAS400 = SDL.SDL_Scancode.SDL_SCANCODE_KP_EQUALSAS400,
		International1 = SDL.SDL_Scancode.SDL_SCANCODE_INTERNATIONAL1,
		International2 = SDL.SDL_Scancode.SDL_SCANCODE_INTERNATIONAL2,
		International3 = SDL.SDL_Scancode.SDL_SCANCODE_INTERNATIONAL3,
		International4 = SDL.SDL_Scancode.SDL_SCANCODE_INTERNATIONAL4,
		International5 = SDL.SDL_Scancode.SDL_SCANCODE_INTERNATIONAL5,
		International6 = SDL.SDL_Scancode.SDL_SCANCODE_INTERNATIONAL6,
		International7 = SDL.SDL_Scancode.SDL_SCANCODE_INTERNATIONAL7,
		International8 = SDL.SDL_Scancode.SDL_SCANCODE_INTERNATIONAL8,
		International9 = SDL.SDL_Scancode.SDL_SCANCODE_INTERNATIONAL9,
		Lang1 = SDL.SDL_Scancode.SDL_SCANCODE_LANG1,
		Lang2 = SDL.SDL_Scancode.SDL_SCANCODE_LANG2,
		Lang3 = SDL.SDL_Scancode.SDL_SCANCODE_LANG3,
		Lang4 = SDL.SDL_Scancode.SDL_SCANCODE_LANG4,
		Lang5 = SDL.SDL_Scancode.SDL_SCANCODE_LANG5,
		Lang6 = SDL.SDL_Scancode.SDL_SCANCODE_LANG6,
		Lang7 = SDL.SDL_Scancode.SDL_SCANCODE_LANG7,
		Lang8 = SDL.SDL_Scancode.SDL_SCANCODE_LANG8,
		Lang9 = SDL.SDL_Scancode.SDL_SCANCODE_LANG9,
		AltErase = SDL.SDL_Scancode.SDL_SCANCODE_ALTERASE,
		Sysreq = SDL.SDL_Scancode.SDL_SCANCODE_SYSREQ,
		Cancel = SDL.SDL_Scancode.SDL_SCANCODE_CANCEL,
		Clear = SDL.SDL_Scancode.SDL_SCANCODE_CLEAR,
		Prior = SDL.SDL_Scancode.SDL_SCANCODE_PRIOR,
		Return2 = SDL.SDL_Scancode.SDL_SCANCODE_RETURN2,
		Separator = SDL.SDL_Scancode.SDL_SCANCODE_SEPARATOR,
		Out = SDL.SDL_Scancode.SDL_SCANCODE_OUT,
		Oper = SDL.SDL_Scancode.SDL_SCANCODE_OPER,
		ClearAgain = SDL.SDL_Scancode.SDL_SCANCODE_CLEARAGAIN,
		Crsel = SDL.SDL_Scancode.SDL_SCANCODE_CRSEL,
		Exsel = SDL.SDL_Scancode.SDL_SCANCODE_EXSEL,
		Keypad_00 = SDL.SDL_Scancode.SDL_SCANCODE_KP_00,
		Keypad_000 = SDL.SDL_Scancode.SDL_SCANCODE_KP_000,
		ThousandsSeparator = SDL.SDL_Scancode.SDL_SCANCODE_THOUSANDSSEPARATOR,
		DecimalSeparator = SDL.SDL_Scancode.SDL_SCANCODE_DECIMALSEPARATOR,
		CurrencyUnit = SDL.SDL_Scancode.SDL_SCANCODE_CURRENCYUNIT,
		CurrencySubUnit = SDL.SDL_Scancode.SDL_SCANCODE_CURRENCYSUBUNIT,
		Keypad_LeftParen = SDL.SDL_Scancode.SDL_SCANCODE_KP_LEFTPAREN,
		Keypad_RightParen = SDL.SDL_Scancode.SDL_SCANCODE_KP_RIGHTPAREN,
		Keypad_LeftBrace = SDL.SDL_Scancode.SDL_SCANCODE_KP_LEFTBRACE,
		Keypad_RrightBrace = SDL.SDL_Scancode.SDL_SCANCODE_KP_RIGHTBRACE,
		Keypad_Tab = SDL.SDL_Scancode.SDL_SCANCODE_KP_TAB,
		Keypad_Backspace = SDL.SDL_Scancode.SDL_SCANCODE_KP_BACKSPACE,
		Keypad_A = SDL.SDL_Scancode.SDL_SCANCODE_KP_A,
		Keypad_B = SDL.SDL_Scancode.SDL_SCANCODE_KP_B,
		Keypad_C = SDL.SDL_Scancode.SDL_SCANCODE_KP_C,
		Keypad_D = SDL.SDL_Scancode.SDL_SCANCODE_KP_D,
		Keypad_E = SDL.SDL_Scancode.SDL_SCANCODE_KP_E,
		Keypad_F = SDL.SDL_Scancode.SDL_SCANCODE_KP_F,
		Keypad_Xor = SDL.SDL_Scancode.SDL_SCANCODE_KP_XOR,
		Keypad_Power = SDL.SDL_Scancode.SDL_SCANCODE_KP_POWER,
		Keypad_Percent = SDL.SDL_Scancode.SDL_SCANCODE_KP_PERCENT,
		Keypad_Less = SDL.SDL_Scancode.SDL_SCANCODE_KP_LESS,
		Keypad_Greater = SDL.SDL_Scancode.SDL_SCANCODE_KP_GREATER,
		Keypad_Ampersand = SDL.SDL_Scancode.SDL_SCANCODE_KP_AMPERSAND,
		Keypad_DblAmpersand = SDL.SDL_Scancode.SDL_SCANCODE_KP_DBLAMPERSAND,
		Keypad_VerticalBar = SDL.SDL_Scancode.SDL_SCANCODE_KP_VERTICALBAR,
		Keypad_DblVerticalBar = SDL.SDL_Scancode.SDL_SCANCODE_KP_DBLVERTICALBAR,
		Keypad_Colon = SDL.SDL_Scancode.SDL_SCANCODE_KP_COLON,
		Keypad_Hash = SDL.SDL_Scancode.SDL_SCANCODE_KP_HASH,
		Keypad_Space = SDL.SDL_Scancode.SDL_SCANCODE_KP_SPACE,
		Keypad_At = SDL.SDL_Scancode.SDL_SCANCODE_KP_AT,
		Keypad_Exclam = SDL.SDL_Scancode.SDL_SCANCODE_KP_EXCLAM,
		Keypad_MemStore = SDL.SDL_Scancode.SDL_SCANCODE_KP_MEMSTORE,
		Keypad_MemRecall = SDL.SDL_Scancode.SDL_SCANCODE_KP_MEMRECALL,
		Keypad_MemClear = SDL.SDL_Scancode.SDL_SCANCODE_KP_MEMCLEAR,
		Keypad_MemAdd = SDL.SDL_Scancode.SDL_SCANCODE_KP_MEMADD,
		Keypad_MemSubtract = SDL.SDL_Scancode.SDL_SCANCODE_KP_MEMSUBTRACT,
		Keypad_MemMultiply = SDL.SDL_Scancode.SDL_SCANCODE_KP_MEMMULTIPLY,
		Keypad_MemDivide = SDL.SDL_Scancode.SDL_SCANCODE_KP_MEMDIVIDE,
		Keypad_PlusMinus = SDL.SDL_Scancode.SDL_SCANCODE_KP_PLUSMINUS,
		Keypad_Clear = SDL.SDL_Scancode.SDL_SCANCODE_KP_CLEAR,
		Keypad_ClearEntry = SDL.SDL_Scancode.SDL_SCANCODE_KP_CLEARENTRY,
		Keypad_Binary = SDL.SDL_Scancode.SDL_SCANCODE_KP_BINARY,
		Keypad_Octal = SDL.SDL_Scancode.SDL_SCANCODE_KP_OCTAL,
		Keypad_Decimal = SDL.SDL_Scancode.SDL_SCANCODE_KP_DECIMAL,
		Keypad_Hexadecimal = SDL.SDL_Scancode.SDL_SCANCODE_KP_HEXADECIMAL,
		Left_Ctrl = SDL.SDL_Scancode.SDL_SCANCODE_LCTRL,
		Left_Shift = SDL.SDL_Scancode.SDL_SCANCODE_LSHIFT,
		Left_Alt = SDL.SDL_Scancode.SDL_SCANCODE_LALT,
		Left_Gui = SDL.SDL_Scancode.SDL_SCANCODE_LGUI,
		Right_Ctrl = SDL.SDL_Scancode.SDL_SCANCODE_RCTRL,
		Right_Shift = SDL.SDL_Scancode.SDL_SCANCODE_RSHIFT,
		Right_Alt = SDL.SDL_Scancode.SDL_SCANCODE_RALT,
		Right_Gui = SDL.SDL_Scancode.SDL_SCANCODE_RGUI,
		MODE = SDL.SDL_Scancode.SDL_SCANCODE_MODE,
		AudioNext = SDL.SDL_Scancode.SDL_SCANCODE_AUDIONEXT,
		AudioPrev = SDL.SDL_Scancode.SDL_SCANCODE_AUDIOPREV,
		AudioStop = SDL.SDL_Scancode.SDL_SCANCODE_AUDIOSTOP,
		AudioPlay = SDL.SDL_Scancode.SDL_SCANCODE_AUDIOPLAY,
		AudioMute = SDL.SDL_Scancode.SDL_SCANCODE_AUDIOMUTE,
		MediaSelect = SDL.SDL_Scancode.SDL_SCANCODE_MEDIASELECT,
		WWW = SDL.SDL_Scancode.SDL_SCANCODE_WWW,
		Mail = SDL.SDL_Scancode.SDL_SCANCODE_MAIL,
		Calculator = SDL.SDL_Scancode.SDL_SCANCODE_CALCULATOR,
		Computer = SDL.SDL_Scancode.SDL_SCANCODE_COMPUTER,
		AC_Search = SDL.SDL_Scancode.SDL_SCANCODE_AC_SEARCH,
		AC_Home = SDL.SDL_Scancode.SDL_SCANCODE_AC_HOME,
		AC_Back = SDL.SDL_Scancode.SDL_SCANCODE_AC_BACK,
		AC_Forward = SDL.SDL_Scancode.SDL_SCANCODE_AC_FORWARD,
		AC_Stop = SDL.SDL_Scancode.SDL_SCANCODE_AC_STOP,
		AC_Refresh = SDL.SDL_Scancode.SDL_SCANCODE_AC_REFRESH,
		AC_Bookmarks = SDL.SDL_Scancode.SDL_SCANCODE_AC_BOOKMARKS,
		BrightnessDown = SDL.SDL_Scancode.SDL_SCANCODE_BRIGHTNESSDOWN,
		BrightnessUp = SDL.SDL_Scancode.SDL_SCANCODE_BRIGHTNESSUP,
		DisplaySwitch = SDL.SDL_Scancode.SDL_SCANCODE_DISPLAYSWITCH,
		KBDillumToggle = SDL.SDL_Scancode.SDL_SCANCODE_KBDILLUMTOGGLE,
		KBDillumDown = SDL.SDL_Scancode.SDL_SCANCODE_KBDILLUMDOWN,
		KBDillumUp = SDL.SDL_Scancode.SDL_SCANCODE_KBDILLUMUP,
		Eject = SDL.SDL_Scancode.SDL_SCANCODE_EJECT,
		Sleep = SDL.SDL_Scancode.SDL_SCANCODE_SLEEP
	}

	public enum Mouse
	{
		Left,
		Right,

		COUNT // For array purposes
	}


	public class Input
	{
		private static Input _instance = null;

		private bool[] _keyboardPressed;
		private bool[] _keyboardReleased;
		private bool[] _keyboardDown;

		private bool[] _mousePressed;
		private bool[] _mouseReleased;
		private bool[] _mouseDown;
		private int _mouseX, _mouseY;

		internal Input()
		{
			int len = (int)SDL2.SDL.SDL_Scancode.SDL_NUM_SCANCODES;
			_keyboardPressed = new bool[len];
			_keyboardReleased = new bool[len];
			_keyboardDown = new bool[len];

			_mousePressed = new bool[(int)Mouse.COUNT];
			_mouseReleased = new bool[(int)Mouse.COUNT];
			_mouseDown = new bool[(int)Mouse.COUNT];
		}

		internal static void Initialize()
		{
			_instance = new Input();			
		}

		internal static void ProcessEvent(SDL.SDL_Event ev)
		{
			// Don't handle repeat keys
			if (ev.key.repeat != 0)
				return;

			switch (ev.type)
			{
				case SDL.SDL_EventType.SDL_KEYDOWN:
					_instance._keyboardPressed[(int)ev.key.keysym.scancode] = true;
					break;
				case SDL.SDL_EventType.SDL_KEYUP:
					_instance._keyboardReleased[(int)ev.key.keysym.scancode] = true;
					_instance._keyboardDown[(int)ev.key.keysym.scancode] = false;
					break;
				case SDL.SDL_EventType.SDL_MOUSEMOTION:
					_instance._mouseX = ev.motion.x;
					_instance._mouseY = ev.motion.y;
					break;
				case SDL.SDL_EventType.SDL_MOUSEBUTTONDOWN:
					if (ev.button.button == SDL.SDL_BUTTON_LEFT)
						_instance._mousePressed[(int)Mouse.Left] = true;
					if (ev.button.button == SDL.SDL_BUTTON_RIGHT)
						_instance._mousePressed[(int)Mouse.Right] = true;
					break;
				case SDL.SDL_EventType.SDL_MOUSEBUTTONUP:
					if (ev.button.button == SDL.SDL_BUTTON_LEFT)
					{
						_instance._mouseReleased[(int)Mouse.Left] = true;
						_instance._mouseDown[(int)Mouse.Left] = false;
					}
					if (ev.button.button == SDL.SDL_BUTTON_RIGHT)
					{
						_instance._mouseReleased[(int)Mouse.Right] = true;
						_instance._mouseDown[(int)Mouse.Right] = false;
					}
					break;
			}
		}

		internal static void Update()
		{
			for (int i = 0; i < (int)SDL.SDL_Scancode.SDL_NUM_SCANCODES; i++)
			{
				_instance._keyboardDown[i] = _instance._keyboardPressed[i] || _instance._keyboardDown[i];
				_instance._keyboardReleased[i] = false;
				_instance._keyboardPressed[i] = false;
			}

			for (int i = 0; i < (int)Mouse.COUNT; i++)
			{
				_instance._mouseDown[i] = _instance._mousePressed[i] || _instance._mouseDown[i];
				_instance._mousePressed[i] = false;
				_instance._mouseReleased[i] = false;
			}
		}

		#region Checks
		public static bool IsKeyPressed(Keyboard key) => _instance._keyboardPressed[(int)key];
		public static bool IsKeyReleased(Keyboard key) => _instance._keyboardReleased[(int)key];
		public static bool IsKeyDown(Keyboard key) => _instance._keyboardDown[(int)key];
		public static bool IsMousePressed(Mouse mouse) => _instance._mousePressed[(int)mouse];
		public static bool IsMouseReleased(Mouse mouse) => _instance._mouseReleased[(int)mouse];
		public static bool IsMouseDown(Mouse mouse) => _instance._mouseDown[(int)mouse];
		public static (int x, int y) MousePosition => (_instance._mouseX, _instance._mouseY);
		#endregion
	}
}
