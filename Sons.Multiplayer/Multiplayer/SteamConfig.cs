using System;
using Il2CppDummyDll;
using Steamworks;

namespace Sons.Multiplayer
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	public static class SteamConfig
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00002D90 File Offset: 0x00000F90
		[Token(Token = "0x1700004A")]
		public static AppId_t SonsOfTheForestAppId
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x30EF420", Offset = "0x30EDA20", VA = "0x1830EF420")]
			get
			{
				return default(AppId_t);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[Token(Token = "0x1700004B")]
		public static AppId_t SonsOfTheForestDedicatedAppId
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x30EF430", Offset = "0x30EDA30", VA = "0x1830EF430")]
			get
			{
				return default(AppId_t);
			}
		}

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		private const string _steamAppidFilePath = "Sons/Settings/steam_appid.txt";

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x0")]
		public static int BuildId;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x8")]
		public static string BetaName;
	}
}
