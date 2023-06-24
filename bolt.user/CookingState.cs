using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200008E RID: 142
[Token(Token = "0x200008E")]
internal class CookingState : NetworkState, ICookingState, IHierarchyObjectState, IState, IDisposable
{
	// Token: 0x06000500 RID: 1280 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000500")]
	[Address(RVA = "0x815250", Offset = "0x813850", VA = "0x180815250")]
	public CookingState()
	{
	}

	// Token: 0x17000283 RID: 643
	// (get) Token: 0x06000501 RID: 1281 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000502 RID: 1282 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000283")]
	public BoltEntity ParentHack
	{
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0", Slot = "36")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x8152B0", Offset = "0x8138B0", VA = "0x1808152B0", Slot = "37")]
		set
		{
		}
	}

	// Token: 0x17000284 RID: 644
	// (get) Token: 0x06000503 RID: 1283 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000284")]
	public NetworkTransform Transform
	{
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x815500", Offset = "0x813B00", VA = "0x180815500", Slot = "31")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000285 RID: 645
	// (get) Token: 0x06000504 RID: 1284 RVA: 0x00003B40 File Offset: 0x00001D40
	// (set) Token: 0x06000505 RID: 1285 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000285")]
	public int Status
	{
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x7BB500", Offset = "0x7B9B00", VA = "0x1807BB500", Slot = "32")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x815560", Offset = "0x813B60", VA = "0x180815560", Slot = "33")]
		set
		{
		}
	}

	// Token: 0x17000286 RID: 646
	// (get) Token: 0x06000506 RID: 1286 RVA: 0x00003B58 File Offset: 0x00001D58
	// (set) Token: 0x06000507 RID: 1287 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000286")]
	public int DecayState
	{
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x7E1E00", Offset = "0x7E0400", VA = "0x1807E1E00", Slot = "34")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x815660", Offset = "0x813C60", VA = "0x180815660", Slot = "35")]
		set
		{
		}
	}
}
