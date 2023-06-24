using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000079 RID: 121
[Token(Token = "0x2000079")]
internal class WoodPlanksProxy : NetworkState, IWoodPlanksProxy, IState, IDisposable
{
	// Token: 0x060003FF RID: 1023 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x80B2B0", Offset = "0x8098B0", VA = "0x18080B2B0")]
	public WoodPlanksProxy()
	{
	}

	// Token: 0x17000207 RID: 519
	// (get) Token: 0x06000400 RID: 1024 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000207")]
	public NetworkArray_Integer Destroyed
	{
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x80B310", Offset = "0x809910", VA = "0x18080B310", Slot = "31")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000208 RID: 520
	// (get) Token: 0x06000401 RID: 1025 RVA: 0x000035E8 File Offset: 0x000017E8
	// (set) Token: 0x06000402 RID: 1026 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000208")]
	public int PlanksIndex
	{
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x80B3D0", Offset = "0x8099D0", VA = "0x18080B3D0", Slot = "32")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x80B430", Offset = "0x809A30", VA = "0x18080B430", Slot = "33")]
		set
		{
		}
	}
}
