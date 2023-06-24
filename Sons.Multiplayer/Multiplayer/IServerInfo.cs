using System;
using Il2CppDummyDll;
using Steamworks;

namespace Sons.Multiplayer
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	public interface IServerInfo
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000155 RID: 341
		[Token(Token = "0x17000039")]
		string Guid { [Token(Token = "0x6000155")] get; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000156 RID: 342
		[Token(Token = "0x1700003A")]
		string Name { [Token(Token = "0x6000156")] get; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000157 RID: 343
		[Token(Token = "0x1700003B")]
		CSteamID ServerId { [Token(Token = "0x6000157")] get; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000158 RID: 344
		[Token(Token = "0x1700003C")]
		string GameMode { [Token(Token = "0x6000158")] get; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000159 RID: 345
		[Token(Token = "0x1700003D")]
		bool VersionMatch { [Token(Token = "0x6000159")] get; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600015A RID: 346
		[Token(Token = "0x1700003E")]
		int CurrentMembers { [Token(Token = "0x600015A")] get; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600015B RID: 347
		[Token(Token = "0x1700003F")]
		int MemberLimit { [Token(Token = "0x600015B")] get; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600015C RID: 348
		[Token(Token = "0x17000040")]
		bool IsValid { [Token(Token = "0x600015C")] get; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600015D RID: 349
		[Token(Token = "0x17000041")]
		int Ping { [Token(Token = "0x600015D")] get; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600015E RID: 350
		[Token(Token = "0x17000042")]
		bool IsPasswordProtected { [Token(Token = "0x600015E")] get; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600015F RID: 351
		[Token(Token = "0x17000043")]
		int WeakPasswordHash { [Token(Token = "0x600015F")] get; }
	}
}
