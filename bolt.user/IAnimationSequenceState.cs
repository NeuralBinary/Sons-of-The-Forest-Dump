using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000075 RID: 117
[Token(Token = "0x2000075")]
public interface IAnimationSequenceState : IState, IDisposable
{
	// Token: 0x170001F8 RID: 504
	// (get) Token: 0x060003DF RID: 991
	// (set) Token: 0x060003E0 RID: 992
	[Token(Token = "0x170001F8")]
	int Stage { [Token(Token = "0x60003DF")] get; [Token(Token = "0x60003E0")] set; }

	// Token: 0x170001F9 RID: 505
	// (get) Token: 0x060003E1 RID: 993
	// (set) Token: 0x060003E2 RID: 994
	[Token(Token = "0x170001F9")]
	float StartTime { [Token(Token = "0x60003E1")] get; [Token(Token = "0x60003E2")] set; }

	// Token: 0x170001FA RID: 506
	// (get) Token: 0x060003E3 RID: 995
	// (set) Token: 0x060003E4 RID: 996
	[Token(Token = "0x170001FA")]
	BoltEntity Actor { [Token(Token = "0x60003E3")] get; [Token(Token = "0x60003E4")] set; }

	// Token: 0x170001FB RID: 507
	// (get) Token: 0x060003E5 RID: 997
	// (set) Token: 0x060003E6 RID: 998
	[Token(Token = "0x170001FB")]
	int Progress { [Token(Token = "0x60003E5")] get; [Token(Token = "0x60003E6")] set; }

	// Token: 0x170001FC RID: 508
	// (get) Token: 0x060003E7 RID: 999
	// (set) Token: 0x060003E8 RID: 1000
	[Token(Token = "0x170001FC")]
	bool Completed { [Token(Token = "0x60003E7")] get; [Token(Token = "0x60003E8")] set; }
}
