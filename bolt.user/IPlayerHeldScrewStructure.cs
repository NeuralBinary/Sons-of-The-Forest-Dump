using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000069 RID: 105
[Token(Token = "0x2000069")]
public interface IPlayerHeldScrewStructure : IState, IDisposable
{
	// Token: 0x170001D7 RID: 471
	// (get) Token: 0x06000392 RID: 914
	// (set) Token: 0x06000393 RID: 915
	[Token(Token = "0x170001D7")]
	BoltEntity Player { [Token(Token = "0x6000392")] get; [Token(Token = "0x6000393")] set; }

	// Token: 0x170001D8 RID: 472
	// (get) Token: 0x06000394 RID: 916
	// (set) Token: 0x06000395 RID: 917
	[Token(Token = "0x170001D8")]
	int StructureRecipeID { [Token(Token = "0x6000394")] get; [Token(Token = "0x6000395")] set; }
}
