using System;
using Il2CppDummyDll;

namespace TheForest.Utils.Settings
{
	// Token: 0x020003DE RID: 990
	[Token(Token = "0x20003DE")]
	public static class GameSettings
	{
		// Token: 0x06001A8A RID: 6794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8A")]
		[Address(RVA = "0x2CE1110", Offset = "0x2CE0110", VA = "0x182CE1110")]
		public static void Init()
		{
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8B")]
		[Address(RVA = "0x2CE12B0", Offset = "0x2CE02B0", VA = "0x182CE12B0")]
		private static void OnDifficultySet(object param)
		{
		}

		// Token: 0x040019B1 RID: 6577
		[Token(Token = "0x40019B1")]
		[FieldOffset(Offset = "0x0")]
		private static bool InitDone;

		// Token: 0x040019B2 RID: 6578
		[Token(Token = "0x40019B2")]
		[FieldOffset(Offset = "0x8")]
		public static SurvivalSettings Survival;
	}
}
