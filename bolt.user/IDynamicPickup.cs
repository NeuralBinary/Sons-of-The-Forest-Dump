using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000042 RID: 66
[Token(Token = "0x2000042")]
public interface IDynamicPickup : IState, IDisposable
{
	// Token: 0x17000166 RID: 358
	// (get) Token: 0x060002A9 RID: 681
	[Token(Token = "0x17000166")]
	NetworkTransform Transform { [Token(Token = "0x60002A9")] get; }
}
