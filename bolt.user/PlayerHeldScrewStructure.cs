using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200006A RID: 106
[Token(Token = "0x200006A")]
internal class PlayerHeldScrewStructure : NetworkState, IPlayerHeldScrewStructure, IState, IDisposable
{
	// Token: 0x06000396 RID: 918 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000396")]
	[Address(RVA = "0x807C60", Offset = "0x806260", VA = "0x180807C60")]
	public PlayerHeldScrewStructure()
	{
	}

	// Token: 0x170001D9 RID: 473
	// (get) Token: 0x06000397 RID: 919 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000398 RID: 920 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001D9")]
	public BoltEntity Player
	{
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0", Slot = "31")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x807CC0", Offset = "0x8062C0", VA = "0x180807CC0", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x170001DA RID: 474
	// (get) Token: 0x06000399 RID: 921 RVA: 0x000033F0 File Offset: 0x000015F0
	// (set) Token: 0x0600039A RID: 922 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001DA")]
	public int StructureRecipeID
	{
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50", Slot = "33")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x807F10", Offset = "0x806510", VA = "0x180807F10", Slot = "34")]
		set
		{
		}
	}
}
