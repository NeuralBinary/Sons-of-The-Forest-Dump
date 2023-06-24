using System;
using System.Collections;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

namespace Sons.Input
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[AddComponentMenu("Sons/Input/InputManager")]
	public class InputManager : SingletonBehaviour<InputManager>
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x3067E90", Offset = "0x3066490", VA = "0x183067E90")]
		public static bool IsKeyboard()
		{
			return default(bool);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2D23520", Offset = "0x2D21B20", VA = "0x182D23520")]
		private bool IsKeyboardActiveInternal()
		{
			return default(bool);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x3067EF0", Offset = "0x30664F0", VA = "0x183067EF0")]
		public static bool IsGamePad()
		{
			return default(bool);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x6000050")]
		[Address(RVA = "0xAFE1F0", Offset = "0xAFC7F0", VA = "0x180AFE1F0")]
		private bool IsGamePadInternal()
		{
			return default(bool);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x3067F50", Offset = "0x3066550", VA = "0x183067F50")]
		public static bool IsDualShockActive()
		{
			return default(bool);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x3067FB0", Offset = "0x30665B0", VA = "0x183067FB0")]
		public static bool IsXboxGamepadActive()
		{
			return default(bool);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x3068020", Offset = "0x3066620", VA = "0x183068020")]
		private void OnEnable()
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x30680B0", Offset = "0x30666B0", VA = "0x1830680B0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x3068140", Offset = "0x3066740", VA = "0x183068140")]
		private void InputSystemOnDeviceChange(InputDevice device, InputDeviceChange change)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x30681D0", Offset = "0x30667D0", VA = "0x1830681D0")]
		private void Update()
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x3068230", Offset = "0x3066830", VA = "0x183068230")]
		private void RefreshGamePadActive()
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x3068780", Offset = "0x3066D80", VA = "0x183068780")]
		private bool IsDualShockGamepad(InputDevice currentActive)
		{
			return default(bool);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x3068800", Offset = "0x3066E00", VA = "0x183068800")]
		private bool IsNonNoiseUpdate(Gamepad eachDevice, float gamepadStickThreshold)
		{
			return default(bool);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x3068B80", Offset = "0x3067180", VA = "0x183068B80")]
		private bool IsBoolValueEqualDefault(InputControl eachControl)
		{
			return default(bool);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x3068D10", Offset = "0x3067310", VA = "0x183068D10")]
		private bool IsFloatValueEqualDefault(InputControl eachControl)
		{
			return default(bool);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x3068EA0", Offset = "0x30674A0", VA = "0x183068EA0")]
		private bool IsVector2ValueEqualDefault(InputControl eachControl, float gamepadStickThreshold)
		{
			return default(bool);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x3069060", Offset = "0x3067660", VA = "0x183069060")]
		private static bool IsKeyboardOrMouseActive(out InputDevice activeDevice, float mouseDeltaThreshold)
		{
			return default(bool);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x30692D0", Offset = "0x30678D0", VA = "0x1830692D0")]
		private static bool IsKeyboardActive()
		{
			return default(bool);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x3069350", Offset = "0x3067950", VA = "0x183069350")]
		private static bool IsMouseActive(float mouseDeltaThreshold)
		{
			return default(bool);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x30695A0", Offset = "0x3067BA0", VA = "0x1830695A0")]
		private static bool MouseControlActive(InputControl eachControl, float mouseDeltaThreshold)
		{
			return default(bool);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x3069960", Offset = "0x3067F60", VA = "0x183069960")]
		public static void RegisterActiveKeyboard(Action action, bool checkNow = true)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x3069B10", Offset = "0x3068110", VA = "0x183069B10")]
		public static void UnregisterActiveKeyboard(Action action)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x3069C40", Offset = "0x3068240", VA = "0x183069C40")]
		public static void RegisterActiveGamepad(Action action, bool checkNow = true)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x3069DF0", Offset = "0x30683F0", VA = "0x183069DF0")]
		public static void RegisterOnActiveDeviceRemoved(Action action)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x3069F20", Offset = "0x3068520", VA = "0x183069F20")]
		public static void UnregisterOnActiveDeviceRemoved(Action action)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x306A050", Offset = "0x3068650", VA = "0x18306A050")]
		public static void UnregisterActiveGamepad(Action action)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x306A180", Offset = "0x3068780", VA = "0x18306A180")]
		public static bool AnyInput()
		{
			return default(bool);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x306A1E0", Offset = "0x30687E0", VA = "0x18306A1E0")]
		public static bool AnyInput(out InputControl control, bool ignoreAnyKey = true)
		{
			return default(bool);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x306A3F0", Offset = "0x30689F0", VA = "0x18306A3F0")]
		public static bool AnyKeyboardInput(out KeyControl control, string localizedIgnores)
		{
			return default(bool);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x306A5C0", Offset = "0x3068BC0", VA = "0x18306A5C0")]
		public static bool AnyMouseAndKeyboardInput(out InputControl control)
		{
			return default(bool);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x306A700", Offset = "0x3068D00", VA = "0x18306A700")]
		public static bool AnyGamepadInput(out InputControl control)
		{
			return default(bool);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x600006C")]
		private bool AnyInput<T>(out InputControl control, params string[] localizedIgnores) where T : InputDevice
		{
			return default(bool);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x306A7F0", Offset = "0x3068DF0", VA = "0x18306A7F0")]
		private static bool IgnorePaths(InputControl eachControl, string[] ignorePathsArray)
		{
			return default(bool);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x306A8A0", Offset = "0x3068EA0", VA = "0x18306A8A0")]
		private static bool MatchesPrefix(InputControl eachControl, string ignorePath)
		{
			return default(bool);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600006F RID: 111 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x17000001")]
		private static bool RumbleEnabled
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x306A8C0", Offset = "0x3068EC0", VA = "0x18306A8C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x306A950", Offset = "0x3068F50", VA = "0x18306A950")]
		public void Rumble(string rumbleProfileId, bool skipGamePadCheck = false)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x306AB70", Offset = "0x3069170", VA = "0x18306AB70")]
		private bool TryGetRumbleProfile(string rumbleProfileId, out RumbleProfile rumbleProfile)
		{
			return default(bool);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x306AB90", Offset = "0x3069190", VA = "0x18306AB90")]
		public void Rumble(float lowFrequency, float highFrequency, float time)
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x306AD70", Offset = "0x3069370", VA = "0x18306AD70")]
		private IEnumerator RumbleWorker(RumbleProfile profile, bool skipGamePadCheck)
		{
			return null;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x306AE80", Offset = "0x3069480", VA = "0x18306AE80")]
		private IEnumerator RumbleWorker(float lowFrequency, float highFrequency, float time)
		{
			return null;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x306AF50", Offset = "0x3069550", VA = "0x18306AF50")]
		private void ResetRumble()
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x306B000", Offset = "0x3069600", VA = "0x18306B000")]
		public InputManager()
		{
		}

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		public const string AnyKeyPath = "/Keyboard/anyKey";

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] IgnorePathsArray;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _mouseDeltaDetectThreshold;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _gamepadStickDetectThreshold;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x30")]
		private InputDevice _lastActiveDevice;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _forceGamePadActive;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool _forceKeyboardActive;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x3A")]
		private bool _isGamepadActive;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x3B")]
		private bool _isKeyboardActive;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x3C")]
		private bool _isDualShockGamepadActive;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x8")]
		private static Action _onKeyboardActive;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x10")]
		private static Action _onGamepadActive;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x18")]
		private static Action _onActiveDeviceRemoved;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine _rumbleWorker;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RumbleProfiles _rumbleProfiles;
	}
}
