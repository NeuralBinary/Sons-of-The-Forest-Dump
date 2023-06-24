using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000093 RID: 147
[Token(Token = "0x2000093")]
public interface IFreeFormPlayerAnimationState : IState, IDisposable
{
	// Token: 0x170003A0 RID: 928
	// (get) Token: 0x06000676 RID: 1654
	// (set) Token: 0x06000677 RID: 1655
	[Token(Token = "0x170003A0")]
	BoltEntity TargetPlayer { [Token(Token = "0x6000676")] get; [Token(Token = "0x6000677")] set; }

	// Token: 0x170003A1 RID: 929
	// (get) Token: 0x06000678 RID: 1656
	// (set) Token: 0x06000679 RID: 1657
	[Token(Token = "0x170003A1")]
	int LeftHandAccessory { [Token(Token = "0x6000678")] get; [Token(Token = "0x6000679")] set; }

	// Token: 0x170003A2 RID: 930
	// (get) Token: 0x0600067A RID: 1658
	// (set) Token: 0x0600067B RID: 1659
	[Token(Token = "0x170003A2")]
	int RightHandAccessory { [Token(Token = "0x600067A")] get; [Token(Token = "0x600067B")] set; }
}
