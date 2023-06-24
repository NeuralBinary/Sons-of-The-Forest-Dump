using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200001B RID: 27
[Token(Token = "0x200001B")]
public interface IRigidbodyState : IState, IDisposable
{
	// Token: 0x17000039 RID: 57
	// (get) Token: 0x06000092 RID: 146
	[Token(Token = "0x17000039")]
	NetworkTransform Transform { [Token(Token = "0x6000092")] get; }
}
