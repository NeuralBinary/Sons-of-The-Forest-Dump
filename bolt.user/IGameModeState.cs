using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000A5 RID: 165
[Token(Token = "0x20000A5")]
public interface IGameModeState : IState, IDisposable
{
	// Token: 0x170003FA RID: 1018
	// (get) Token: 0x0600072D RID: 1837
	// (set) Token: 0x0600072E RID: 1838
	[Token(Token = "0x170003FA")]
	int Game { [Token(Token = "0x600072D")] get; [Token(Token = "0x600072E")] set; }

	// Token: 0x170003FB RID: 1019
	// (get) Token: 0x0600072F RID: 1839
	// (set) Token: 0x06000730 RID: 1840
	[Token(Token = "0x170003FB")]
	float Timer { [Token(Token = "0x600072F")] get; [Token(Token = "0x6000730")] set; }

	// Token: 0x170003FC RID: 1020
	// (get) Token: 0x06000731 RID: 1841
	// (set) Token: 0x06000732 RID: 1842
	[Token(Token = "0x170003FC")]
	int Phase { [Token(Token = "0x6000731")] get; [Token(Token = "0x6000732")] set; }

	// Token: 0x170003FD RID: 1021
	// (get) Token: 0x06000733 RID: 1843
	// (set) Token: 0x06000734 RID: 1844
	[Token(Token = "0x170003FD")]
	float NewProperty { [Token(Token = "0x6000733")] get; [Token(Token = "0x6000734")] set; }
}
