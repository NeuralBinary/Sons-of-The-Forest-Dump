using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200005D RID: 93
[Token(Token = "0x200005D")]
public interface IStaticPickup : IState, IDisposable
{
	// Token: 0x170001B6 RID: 438
	// (get) Token: 0x0600034F RID: 847
	// (set) Token: 0x06000350 RID: 848
	[Token(Token = "0x170001B6")]
	bool burning { [Token(Token = "0x600034F")] get; [Token(Token = "0x6000350")] set; }
}
