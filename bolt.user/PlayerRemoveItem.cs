using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000177 RID: 375
[Token(Token = "0x2000177")]
public class PlayerRemoveItem : Event
{
	// Token: 0x0600111D RID: 4381 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600111D")]
	[Address(RVA = "0x882610", Offset = "0x880C10", VA = "0x180882610")]
	public PlayerRemoveItem()
	{
	}

	// Token: 0x170005E8 RID: 1512
	// (get) Token: 0x0600111E RID: 4382 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600111F RID: 4383 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005E8")]
	public BoltEntity Player
	{
		[Token(Token = "0x600111E")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600111F")]
		[Address(RVA = "0x882670", Offset = "0x880C70", VA = "0x180882670")]
		set
		{
		}
	}

	// Token: 0x170005E9 RID: 1513
	// (get) Token: 0x06001120 RID: 4384 RVA: 0x000066F0 File Offset: 0x000048F0
	// (set) Token: 0x06001121 RID: 4385 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005E9")]
	public int ItemId
	{
		[Token(Token = "0x6001120")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001121")]
		[Address(RVA = "0x7D6DC0", Offset = "0x7D53C0", VA = "0x1807D6DC0")]
		set
		{
		}
	}

	// Token: 0x06001122 RID: 4386 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001122")]
	[Address(RVA = "0x882880", Offset = "0x880E80", VA = "0x180882880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001123 RID: 4387 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001123")]
	[Address(RVA = "0x8829C0", Offset = "0x880FC0", VA = "0x1808829C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerRemoveItem Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001124 RID: 4388 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001124")]
	[Address(RVA = "0x8829D0", Offset = "0x880FD0", VA = "0x1808829D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerRemoveItem Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001125 RID: 4389 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001125")]
	[Address(RVA = "0x882BD0", Offset = "0x8811D0", VA = "0x180882BD0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static PlayerRemoveItem Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001126 RID: 4390 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001126")]
	[Address(RVA = "0x882CF0", Offset = "0x8812F0", VA = "0x180882CF0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerRemoveItem Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001127 RID: 4391 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001127")]
	[Address(RVA = "0x882D00", Offset = "0x881300", VA = "0x180882D00")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerRemoveItem Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001128 RID: 4392 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001128")]
	[Address(RVA = "0x882D10", Offset = "0x881310", VA = "0x180882D10")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerRemoveItem Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001129 RID: 4393 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001129")]
	[Address(RVA = "0x882D20", Offset = "0x881320", VA = "0x180882D20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerRemoveItem Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600112A RID: 4394 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600112A")]
	[Address(RVA = "0x882D40", Offset = "0x881340", VA = "0x180882D40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerRemoveItem Raise()
	{
		return null;
	}

	// Token: 0x0600112B RID: 4395 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600112B")]
	[Address(RVA = "0x882D60", Offset = "0x881360", VA = "0x180882D60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerRemoveItem Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600112C RID: 4396 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600112C")]
	[Address(RVA = "0x8829C0", Offset = "0x880FC0", VA = "0x1808829C0")]
	public static PlayerRemoveItem Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600112D RID: 4397 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600112D")]
	[Address(RVA = "0x882D70", Offset = "0x881370", VA = "0x180882D70")]
	public static PlayerRemoveItem Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600112E RID: 4398 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600112E")]
	[Address(RVA = "0x882F70", Offset = "0x881570", VA = "0x180882F70")]
	private static PlayerRemoveItem Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600112F RID: 4399 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600112F")]
	[Address(RVA = "0x882CF0", Offset = "0x8812F0", VA = "0x180882CF0")]
	public static PlayerRemoveItem Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001130 RID: 4400 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001130")]
	[Address(RVA = "0x882D00", Offset = "0x881300", VA = "0x180882D00")]
	public static PlayerRemoveItem Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001131 RID: 4401 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001131")]
	[Address(RVA = "0x882D10", Offset = "0x881310", VA = "0x180882D10")]
	public static PlayerRemoveItem Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001132 RID: 4402 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001132")]
	[Address(RVA = "0x882D20", Offset = "0x881320", VA = "0x180882D20")]
	public static PlayerRemoveItem Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001133 RID: 4403 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001133")]
	[Address(RVA = "0x882D40", Offset = "0x881340", VA = "0x180882D40")]
	public static PlayerRemoveItem Create()
	{
		return null;
	}

	// Token: 0x06001134 RID: 4404 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001134")]
	[Address(RVA = "0x882D60", Offset = "0x881360", VA = "0x180882D60")]
	public static PlayerRemoveItem Create(ReliabilityModes reliability)
	{
		return null;
	}
}
