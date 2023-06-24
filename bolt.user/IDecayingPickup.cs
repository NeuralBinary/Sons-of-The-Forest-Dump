using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000060 RID: 96
[Token(Token = "0x2000060")]
public interface IDecayingPickup : IDynamicPickup, IState, IDisposable
{
	// Token: 0x170001BB RID: 443
	// (get) Token: 0x0600035C RID: 860
	// (set) Token: 0x0600035D RID: 861
	[Token(Token = "0x170001BB")]
	int State { [Token(Token = "0x600035C")] get; [Token(Token = "0x600035D")] set; }
}
