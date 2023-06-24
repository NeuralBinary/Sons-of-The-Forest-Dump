using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000078 RID: 120
[Token(Token = "0x2000078")]
public interface IWoodPlanksProxy : IState, IDisposable
{
	// Token: 0x17000205 RID: 517
	// (get) Token: 0x060003FC RID: 1020
	[Token(Token = "0x17000205")]
	NetworkArray_Integer Destroyed { [Token(Token = "0x60003FC")] get; }

	// Token: 0x17000206 RID: 518
	// (get) Token: 0x060003FD RID: 1021
	// (set) Token: 0x060003FE RID: 1022
	[Token(Token = "0x17000206")]
	int PlanksIndex { [Token(Token = "0x60003FD")] get; [Token(Token = "0x60003FE")] set; }
}
