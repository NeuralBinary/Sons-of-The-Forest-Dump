using System;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Sons.Multiplayer
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	public interface IServerBrowser
	{
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600014D RID: 333
		// (remove) Token: 0x0600014E RID: 334
		[Token(Token = "0x14000007")]
		event Action OnServersRefreshed;

		// Token: 0x0600014F RID: 335
		[Token(Token = "0x600014F")]
		Task RefreshLobbiesListAsync(ServerBrowserRefreshType refreshType);

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000150 RID: 336
		[Token(Token = "0x17000036")]
		bool ReadyToDisplay { [Token(Token = "0x6000150")] get; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000151 RID: 337
		[Token(Token = "0x17000037")]
		bool RefreshInProgress { [Token(Token = "0x6000151")] get; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000152 RID: 338
		[Token(Token = "0x17000038")]
		IServerInfo[] Entries { [Token(Token = "0x6000152")] get; }

		// Token: 0x06000153 RID: 339
		[Token(Token = "0x6000153")]
		void CancelRefresh();

		// Token: 0x06000154 RID: 340
		[Token(Token = "0x6000154")]
		void GetServerCount(out int refreshedServerCount, out int totalServerCount);
	}
}
