using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200007B RID: 123
[Token(Token = "0x200007B")]
public interface IBreakableObjectState : IRigidbodyState, IState, IDisposable
{
	// Token: 0x1700020C RID: 524
	// (get) Token: 0x0600040B RID: 1035
	// (set) Token: 0x0600040C RID: 1036
	[Token(Token = "0x1700020C")]
	bool IsBroken { [Token(Token = "0x600040B")] get; [Token(Token = "0x600040C")] set; }
}
