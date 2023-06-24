using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200006C RID: 108
[Token(Token = "0x200006C")]
public interface ILogState : ILogPickup, IState, IDisposable
{
	// Token: 0x170001DE RID: 478
	// (get) Token: 0x060003A3 RID: 931
	// (set) Token: 0x060003A4 RID: 932
	[Token(Token = "0x170001DE")]
	BoltEntity FromTree { [Token(Token = "0x60003A3")] get; [Token(Token = "0x60003A4")] set; }
}
