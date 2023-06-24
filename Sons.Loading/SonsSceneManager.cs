using System;
using Il2CppDummyDll;

namespace Sons.Loading
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public static class SonsSceneManager
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000045 RID: 69 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x17000008")]
		public static bool UsedLoadingScreen
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x30B8420", Offset = "0x30B6A20", VA = "0x1830B8420")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x30B8460", Offset = "0x30B6A60", VA = "0x1830B8460")]
		public static void SetUsedLoadingScreen(bool value)
		{
		}

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x0")]
		private static bool _usedLoadingScreen;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		public const string TitleSceneName = "SonsTitleScene";

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		public const string MainLoadingSceneName = "SonsMainLoading";

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		public const string ClientMultiplayerMenuSceneName = "MultiplayerMenu";

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		public const string OptionsMenuSceneName = "SonsOptionsMenu";

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		public const string SonsMainSceneName = "SonsMain";
	}
}
