using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000066 RID: 102
[Token(Token = "0x2000066")]
public interface IPartState : IState, IDisposable
{
	// Token: 0x170001D0 RID: 464
	// (get) Token: 0x06000383 RID: 899
	[Token(Token = "0x170001D0")]
	NetworkTransform Transform { [Token(Token = "0x6000383")] get; }

	// Token: 0x170001D1 RID: 465
	// (get) Token: 0x06000384 RID: 900
	// (set) Token: 0x06000385 RID: 901
	[Token(Token = "0x170001D1")]
	BoltEntity Effigy { [Token(Token = "0x6000384")] get; [Token(Token = "0x6000385")] set; }
}
