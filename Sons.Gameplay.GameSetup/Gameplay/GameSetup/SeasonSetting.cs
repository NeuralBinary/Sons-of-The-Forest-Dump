using System;
using Il2CppDummyDll;

namespace Sons.Gameplay.GameSetup
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	public struct SeasonSetting
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xF9C9A0", Offset = "0xF9AFA0", VA = "0x180F9C9A0")]
		private SeasonSetting(int intValue, string stringValue)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000266C File Offset: 0x0000086C
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050")]
		public static implicit operator int(SeasonSetting setting)
		{
			return 0;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x9C2AC0", Offset = "0x9C10C0", VA = "0x1809C2AC0")]
		public static implicit operator string(SeasonSetting setting)
		{
			return null;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x9C2AC0", Offset = "0x9C10C0", VA = "0x1809C2AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002684 File Offset: 0x00000884
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2FF5650", Offset = "0x2FF3C50", VA = "0x182FF5650")]
		public static implicit operator SeasonSetting(int value)
		{
			return default(SeasonSetting);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000269C File Offset: 0x0000089C
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2FF5810", Offset = "0x2FF3E10", VA = "0x182FF5810")]
		public static implicit operator SeasonSetting(string value)
		{
			return default(SeasonSetting);
		}

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		public const string SpringString = "Spring";

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		public const string SummerString = "Summer";

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		public const string AutumnString = "Autumn";

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		public const string WinterString = "Winter";

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		public const int SpringInt = 0;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		public const int SummerInt = 1;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		public const int AutumnInt = 2;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		public const int WinterInt = 3;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SeasonSetting Spring;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x10")]
		public static readonly SeasonSetting Summer;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x20")]
		public static readonly SeasonSetting Autumn;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x30")]
		public static readonly SeasonSetting Winter;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x0")]
		private readonly int _intValue;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x8")]
		private readonly string _stringValue;
	}
}
