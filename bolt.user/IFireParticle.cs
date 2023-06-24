using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000051 RID: 81
[Token(Token = "0x2000051")]
public interface IFireParticle : IState, IDisposable
{
	// Token: 0x1700018C RID: 396
	// (get) Token: 0x060002FF RID: 767
	[Token(Token = "0x1700018C")]
	NetworkTransform Transform { [Token(Token = "0x60002FF")] get; }
}
