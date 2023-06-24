using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Settings
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[AddComponentMenu("Sons/Settings/InputBindingSettings")]
	public class InputBindingSettings : MonoBehaviour
	{
		// Token: 0x060000A9 RID: 169 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x31409E0", Offset = "0x313EFE0", VA = "0x1831409E0")]
		public static string CreateSettingKey(string action, string group)
		{
			return null;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public InputBindingSettings()
		{
		}

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		private const string KeyboardPrefix = "Keyboard.";

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		private const string MousePrefix = "Mouse.";

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		private const string GamepadPrefix = "Gamepad.";

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		private const string KeyboardE = "Keyboard.E";

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		private const string KeyboardSpace = "Keyboard.Space";

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		private const string MouseButton1 = "Mouse.1";

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		private const string GamepadSouth = "Gamepad.South";

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		private const string GamepadNorth = "Gamepad.North";

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		public const string TakeAndUseSettingKey = "Binding.InvertY";

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		public const string TakeAndUseDefault = "Keyboard.E, Gamepad.South";

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		public const string JumpSettingKey = "Binding.InvertY";

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		public const string JumpDefault = "Keyboard.Space, Gamepad.North";
	}
}
