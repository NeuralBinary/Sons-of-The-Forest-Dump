using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Localization;

namespace Sons.GameApplication
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public static class Releases
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2FE67A0", Offset = "0x2FE4DA0", VA = "0x182FE67A0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void Initialize()
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2FE6A30", Offset = "0x2FE5030", VA = "0x182FE6A30")]
		private static void LoadReleasesData(out DateTime nextUpdateUtc)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2FE6B60", Offset = "0x2FE5160", VA = "0x182FE6B60")]
		public static string GetNextUpdateString()
		{
			return null;
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		private const string LoadFilename = "ReleaseInfo";

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		private const string MenusTableReference = "Menus";

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		private const string ComingSoonKey = "COMING_SOON";

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x0")]
		private static DateTime _nextUpdateUtc;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x8")]
		private static readonly LocalizedString ComingSoonString;
	}
}
