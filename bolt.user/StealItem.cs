using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000126 RID: 294
[Token(Token = "0x2000126")]
public class StealItem : Event
{
	// Token: 0x06000D87 RID: 3463 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D87")]
	[Address(RVA = "0x865130", Offset = "0x863730", VA = "0x180865130")]
	public StealItem()
	{
	}

	// Token: 0x17000561 RID: 1377
	// (get) Token: 0x06000D88 RID: 3464 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000D89 RID: 3465 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000561")]
	public BoltEntity thief
	{
		[Token(Token = "0x6000D88")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D89")]
		[Address(RVA = "0x865190", Offset = "0x863790", VA = "0x180865190")]
		set
		{
		}
	}

	// Token: 0x17000562 RID: 1378
	// (get) Token: 0x06000D8A RID: 3466 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000D8B RID: 3467 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000562")]
	public BoltEntity robbed
	{
		[Token(Token = "0x6000D8A")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D8B")]
		[Address(RVA = "0x8653A0", Offset = "0x8639A0", VA = "0x1808653A0")]
		set
		{
		}
	}

	// Token: 0x06000D8C RID: 3468 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D8C")]
	[Address(RVA = "0x8655B0", Offset = "0x863BB0", VA = "0x1808655B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000D8D RID: 3469 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D8D")]
	[Address(RVA = "0x865610", Offset = "0x863C10", VA = "0x180865610")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StealItem Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000D8E RID: 3470 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D8E")]
	[Address(RVA = "0x865620", Offset = "0x863C20", VA = "0x180865620")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StealItem Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000D8F RID: 3471 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D8F")]
	[Address(RVA = "0x865820", Offset = "0x863E20", VA = "0x180865820")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static StealItem Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D90 RID: 3472 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D90")]
	[Address(RVA = "0x865940", Offset = "0x863F40", VA = "0x180865940")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StealItem Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000D91 RID: 3473 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D91")]
	[Address(RVA = "0x865950", Offset = "0x863F50", VA = "0x180865950")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StealItem Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D92 RID: 3474 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D92")]
	[Address(RVA = "0x865960", Offset = "0x863F60", VA = "0x180865960")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StealItem Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000D93 RID: 3475 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D93")]
	[Address(RVA = "0x865970", Offset = "0x863F70", VA = "0x180865970")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StealItem Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D94 RID: 3476 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D94")]
	[Address(RVA = "0x865990", Offset = "0x863F90", VA = "0x180865990")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StealItem Raise()
	{
		return null;
	}

	// Token: 0x06000D95 RID: 3477 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D95")]
	[Address(RVA = "0x8659B0", Offset = "0x863FB0", VA = "0x1808659B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StealItem Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D96 RID: 3478 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D96")]
	[Address(RVA = "0x865610", Offset = "0x863C10", VA = "0x180865610")]
	public static StealItem Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000D97 RID: 3479 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D97")]
	[Address(RVA = "0x8659C0", Offset = "0x863FC0", VA = "0x1808659C0")]
	public static StealItem Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000D98 RID: 3480 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D98")]
	[Address(RVA = "0x865BC0", Offset = "0x8641C0", VA = "0x180865BC0")]
	private static StealItem Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D99 RID: 3481 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D99")]
	[Address(RVA = "0x865940", Offset = "0x863F40", VA = "0x180865940")]
	public static StealItem Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000D9A RID: 3482 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D9A")]
	[Address(RVA = "0x865950", Offset = "0x863F50", VA = "0x180865950")]
	public static StealItem Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D9B RID: 3483 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D9B")]
	[Address(RVA = "0x865960", Offset = "0x863F60", VA = "0x180865960")]
	public static StealItem Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000D9C RID: 3484 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D9C")]
	[Address(RVA = "0x865970", Offset = "0x863F70", VA = "0x180865970")]
	public static StealItem Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D9D RID: 3485 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D9D")]
	[Address(RVA = "0x865990", Offset = "0x863F90", VA = "0x180865990")]
	public static StealItem Create()
	{
		return null;
	}

	// Token: 0x06000D9E RID: 3486 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D9E")]
	[Address(RVA = "0x8659B0", Offset = "0x863FB0", VA = "0x1808659B0")]
	public static StealItem Create(ReliabilityModes reliability)
	{
		return null;
	}
}
