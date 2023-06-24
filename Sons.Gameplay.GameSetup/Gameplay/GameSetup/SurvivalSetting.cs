using System;
using Il2CppDummyDll;

namespace Sons.Gameplay.GameSetup
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public struct SurvivalSetting
	{
		// Token: 0x060000D3 RID: 211 RVA: 0x000026FC File Offset: 0x000008FC
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x60E0F0", Offset = "0x60C6F0", VA = "0x18060E0F0")]
		private bool Equals(SurvivalSetting other)
		{
			return default(bool);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002714 File Offset: 0x00000914
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2FF68D0", Offset = "0x2FF4ED0", VA = "0x182FF68D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000272C File Offset: 0x0000092C
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002744 File Offset: 0x00000944
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x60E0F0", Offset = "0x60C6F0", VA = "0x18060E0F0")]
		public static bool operator ==(SurvivalSetting left, SurvivalSetting right)
		{
			return default(bool);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000275C File Offset: 0x0000095C
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2FF6950", Offset = "0x2FF4F50", VA = "0x182FF6950")]
		public static bool operator !=(SurvivalSetting left, SurvivalSetting right)
		{
			return default(bool);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xF9C9A0", Offset = "0xF9AFA0", VA = "0x180F9C9A0")]
		private SurvivalSetting(int intValue, string stringValue)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002774 File Offset: 0x00000974
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050")]
		public static implicit operator int(SurvivalSetting setting)
		{
			return 0;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x9C2AC0", Offset = "0x9C10C0", VA = "0x1809C2AC0")]
		public static implicit operator string(SurvivalSetting setting)
		{
			return null;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x9C2AC0", Offset = "0x9C10C0", VA = "0x1809C2AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000278C File Offset: 0x0000098C
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2FF69B0", Offset = "0x2FF4FB0", VA = "0x182FF69B0")]
		public static implicit operator SurvivalSetting(int value)
		{
			return default(SurvivalSetting);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000027A4 File Offset: 0x000009A4
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2FF6B20", Offset = "0x2FF5120", VA = "0x182FF6B20")]
		public static implicit operator SurvivalSetting(string value)
		{
			return default(SurvivalSetting);
		}

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		public const string OffString = "Off";

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		public const string NormalString = "Normal";

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		public const string HardString = "Hard";

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		public const int OffInt = 0;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		public const int NormalInt = 1;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		public const int HardInt = 2;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SurvivalSetting Off;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x10")]
		public static readonly SurvivalSetting Normal;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x20")]
		public static readonly SurvivalSetting Hard;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x0")]
		private readonly int _intValue;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x8")]
		private readonly string _stringValue;
	}
}
