using System;
using Il2CppDummyDll;

namespace Sons.Gameplay.GameSetup
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public struct LowNormalHighSetting
	{
		// Token: 0x060000BC RID: 188 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xF9C9A0", Offset = "0xF9AFA0", VA = "0x180F9C9A0")]
		private LowNormalHighSetting(int intValue, string stringValue)
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002624 File Offset: 0x00000824
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050")]
		public static implicit operator int(LowNormalHighSetting setting)
		{
			return 0;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x9C2AC0", Offset = "0x9C10C0", VA = "0x1809C2AC0")]
		public static implicit operator string(LowNormalHighSetting setting)
		{
			return null;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x9C2AC0", Offset = "0x9C10C0", VA = "0x1809C2AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000263C File Offset: 0x0000083C
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2FF4E00", Offset = "0x2FF3400", VA = "0x182FF4E00")]
		public static implicit operator LowNormalHighSetting(int value)
		{
			return default(LowNormalHighSetting);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002654 File Offset: 0x00000854
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2FF4F80", Offset = "0x2FF3580", VA = "0x182FF4F80")]
		public static implicit operator LowNormalHighSetting(string value)
		{
			return default(LowNormalHighSetting);
		}

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		public const string LowString = "LOW";

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		public const string NormalString = "NORMAL";

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		public const string HighString = "High";

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		public const int LowInt = -1;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		public const int NormalInt = 0;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		public const int HighInt = 1;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x0")]
		public static readonly LowNormalHighSetting Low;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x10")]
		public static readonly LowNormalHighSetting Normal;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x20")]
		public static readonly LowNormalHighSetting High;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x0")]
		private readonly int _intValue;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x8")]
		private readonly string _stringValue;
	}
}
