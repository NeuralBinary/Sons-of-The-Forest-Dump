using System;
using Il2CppDummyDll;

namespace TheForest.Utils.Settings
{
	// Token: 0x020003D0 RID: 976
	[Token(Token = "0x20003D0")]
	public static class GameSettings
	{
		// Token: 0x06001AC8 RID: 6856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC8")]
		[Address(RVA = "0x32A8350", Offset = "0x32A6950", VA = "0x1832A8350")]
		public static void Init()
		{
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC9")]
		[Address(RVA = "0x32A8530", Offset = "0x32A6B30", VA = "0x1832A8530")]
		private static void OnDifficultySet(object param)
		{
		}

		// Token: 0x040019D5 RID: 6613
		[Token(Token = "0x40019D5")]
		[FieldOffset(Offset = "0x0")]
		private static bool InitDone;

		// Token: 0x040019D6 RID: 6614
		[Token(Token = "0x40019D6")]
		[FieldOffset(Offset = "0x8")]
		public static SurvivalSettings Survival;
	}
}
