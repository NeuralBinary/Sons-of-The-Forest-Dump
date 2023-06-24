using System;
using Il2CppDummyDll;

namespace Sons.Gameplay.GameSetup
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public struct LowDefaultHighSetting
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xF9C9A0", Offset = "0xF9AFA0", VA = "0x180F9C9A0")]
		private LowDefaultHighSetting(int intValue, string stringValue)
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000025DC File Offset: 0x000007DC
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050")]
		public static implicit operator int(LowDefaultHighSetting setting)
		{
			return 0;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x9C2AC0", Offset = "0x9C10C0", VA = "0x1809C2AC0")]
		public static implicit operator string(LowDefaultHighSetting setting)
		{
			return null;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x9C2AC0", Offset = "0x9C10C0", VA = "0x1809C2AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000025F4 File Offset: 0x000007F4
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2FF46A0", Offset = "0x2FF2CA0", VA = "0x182FF46A0")]
		public static implicit operator LowDefaultHighSetting(int value)
		{
			return default(LowDefaultHighSetting);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000260C File Offset: 0x0000080C
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2FF4820", Offset = "0x2FF2E20", VA = "0x182FF4820")]
		public static implicit operator LowDefaultHighSetting(string value)
		{
			return default(LowDefaultHighSetting);
		}

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		public const string LowString = "Low";

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		public const string DefaultString = "Default";

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		public const string HighString = "High";

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		public const int LowInt = -1;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		public const int DefaultInt = 0;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		public const int HighInt = 1;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x0")]
		public static readonly LowDefaultHighSetting Low;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x10")]
		public static readonly LowDefaultHighSetting Default;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x20")]
		public static readonly LowDefaultHighSetting High;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x0")]
		private readonly int _intValue;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x8")]
		private readonly string _stringValue;
	}
}
