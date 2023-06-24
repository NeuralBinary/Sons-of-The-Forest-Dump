using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200009C RID: 156
[Token(Token = "0x200009C")]
public interface IRadioState : IRigidbodyState, IState, IDisposable
{
	// Token: 0x170003BB RID: 955
	// (get) Token: 0x060006B0 RID: 1712
	// (set) Token: 0x060006B1 RID: 1713
	[Token(Token = "0x170003BB")]
	bool OnOff { [Token(Token = "0x60006B0")] get; [Token(Token = "0x60006B1")] set; }

	// Token: 0x170003BC RID: 956
	// (get) Token: 0x060006B2 RID: 1714
	// (set) Token: 0x060006B3 RID: 1715
	[Token(Token = "0x170003BC")]
	int RandomHash { [Token(Token = "0x60006B2")] get; [Token(Token = "0x60006B3")] set; }

	// Token: 0x170003BD RID: 957
	// (get) Token: 0x060006B4 RID: 1716
	// (set) Token: 0x060006B5 RID: 1717
	[Token(Token = "0x170003BD")]
	bool Broken { [Token(Token = "0x60006B4")] get; [Token(Token = "0x60006B5")] set; }

	// Token: 0x170003BE RID: 958
	// (get) Token: 0x060006B6 RID: 1718
	// (set) Token: 0x060006B7 RID: 1719
	[Token(Token = "0x170003BE")]
	int TrackHash { [Token(Token = "0x60006B6")] get; [Token(Token = "0x60006B7")] set; }
}
