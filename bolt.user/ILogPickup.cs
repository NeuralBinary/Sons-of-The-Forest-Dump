using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000054 RID: 84
[Token(Token = "0x2000054")]
public interface ILogPickup : IState, IDisposable
{
	// Token: 0x17000191 RID: 401
	// (get) Token: 0x0600030A RID: 778
	[Token(Token = "0x17000191")]
	NetworkTransform Transform { [Token(Token = "0x600030A")] get; }
}
