using System;
using Il2CppDummyDll;

namespace Sons.Gameplay.GameSetup
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	public struct ShortDefaultLongRealisticSetting
	{
		// Token: 0x060000CC RID: 204 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xF9C9A0", Offset = "0xF9AFA0", VA = "0x180F9C9A0")]
		private ShortDefaultLongRealisticSetting(int intValue, string stringValue)
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000026B4 File Offset: 0x000008B4
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050")]
		public static implicit operator int(ShortDefaultLongRealisticSetting setting)
		{
			return 0;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x9C2AC0", Offset = "0x9C10C0", VA = "0x1809C2AC0")]
		public static implicit operator string(ShortDefaultLongRealisticSetting setting)
		{
			return null;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x9C2AC0", Offset = "0x9C10C0", VA = "0x1809C2AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000026CC File Offset: 0x000008CC
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2FF5F90", Offset = "0x2FF4590", VA = "0x182FF5F90")]
		public static implicit operator ShortDefaultLongRealisticSetting(int value)
		{
			return default(ShortDefaultLongRealisticSetting);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000026E4 File Offset: 0x000008E4
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2FF6150", Offset = "0x2FF4750", VA = "0x182FF6150")]
		public static implicit operator ShortDefaultLongRealisticSetting(string value)
		{
			return default(ShortDefaultLongRealisticSetting);
		}

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		public const string ShortString = "Short";

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		public const string DefaultString = "Default";

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		public const string LongString = "Long";

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		public const string RealisticString = "Realistic";

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		public const int ShortInt = -1;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		public const int DefaultInt = 0;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		public const int LongInt = 1;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		public const int RealisticInt = 2;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ShortDefaultLongRealisticSetting Short;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ShortDefaultLongRealisticSetting Default;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ShortDefaultLongRealisticSetting Long;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ShortDefaultLongRealisticSetting Realistic;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x0")]
		private readonly int _intValue;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x8")]
		private readonly string _stringValue;
	}
}
