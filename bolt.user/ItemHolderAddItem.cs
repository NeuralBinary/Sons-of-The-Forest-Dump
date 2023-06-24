using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000DB RID: 219
[Token(Token = "0x20000DB")]
public class ItemHolderAddItem : Event
{
	// Token: 0x06000A29 RID: 2601 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A29")]
	[Address(RVA = "0x849140", Offset = "0x847740", VA = "0x180849140")]
	public ItemHolderAddItem()
	{
	}

	// Token: 0x170004DE RID: 1246
	// (get) Token: 0x06000A2A RID: 2602 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000A2B RID: 2603 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004DE")]
	public BoltEntity Target
	{
		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x8491A0", Offset = "0x8477A0", VA = "0x1808491A0")]
		set
		{
		}
	}

	// Token: 0x170004DF RID: 1247
	// (get) Token: 0x06000A2C RID: 2604 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000A2D RID: 2605 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004DF")]
	public BoltEntity Player
	{
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x8493B0", Offset = "0x8479B0", VA = "0x1808493B0")]
		set
		{
		}
	}

	// Token: 0x170004E0 RID: 1248
	// (get) Token: 0x06000A2E RID: 2606 RVA: 0x000057C0 File Offset: 0x000039C0
	// (set) Token: 0x06000A2F RID: 2607 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004E0")]
	public int ContentType
	{
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x7D6E60", Offset = "0x7D5460", VA = "0x1807D6E60")]
		set
		{
		}
	}

	// Token: 0x170004E1 RID: 1249
	// (get) Token: 0x06000A30 RID: 2608 RVA: 0x000057D8 File Offset: 0x000039D8
	// (set) Token: 0x06000A31 RID: 2609 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004E1")]
	public int ContentInfo
	{
		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x7B6B40", Offset = "0x7B5140", VA = "0x1807B6B40")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x7E1CC0", Offset = "0x7E02C0", VA = "0x1807E1CC0")]
		set
		{
		}
	}

	// Token: 0x06000A32 RID: 2610 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A32")]
	[Address(RVA = "0x8495C0", Offset = "0x847BC0", VA = "0x1808495C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000A33 RID: 2611 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A33")]
	[Address(RVA = "0x849910", Offset = "0x847F10", VA = "0x180849910")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemHolderAddItem Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000A34 RID: 2612 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A34")]
	[Address(RVA = "0x849920", Offset = "0x847F20", VA = "0x180849920")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemHolderAddItem Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000A35 RID: 2613 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A35")]
	[Address(RVA = "0x849B20", Offset = "0x848120", VA = "0x180849B20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static ItemHolderAddItem Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A36 RID: 2614 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A36")]
	[Address(RVA = "0x849C40", Offset = "0x848240", VA = "0x180849C40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemHolderAddItem Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000A37 RID: 2615 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A37")]
	[Address(RVA = "0x849C50", Offset = "0x848250", VA = "0x180849C50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemHolderAddItem Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A38 RID: 2616 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A38")]
	[Address(RVA = "0x849C60", Offset = "0x848260", VA = "0x180849C60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemHolderAddItem Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000A39 RID: 2617 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A39")]
	[Address(RVA = "0x849C70", Offset = "0x848270", VA = "0x180849C70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemHolderAddItem Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A3A RID: 2618 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A3A")]
	[Address(RVA = "0x849C90", Offset = "0x848290", VA = "0x180849C90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemHolderAddItem Raise()
	{
		return null;
	}

	// Token: 0x06000A3B RID: 2619 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A3B")]
	[Address(RVA = "0x849CB0", Offset = "0x8482B0", VA = "0x180849CB0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemHolderAddItem Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A3C RID: 2620 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A3C")]
	[Address(RVA = "0x849910", Offset = "0x847F10", VA = "0x180849910")]
	public static ItemHolderAddItem Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000A3D RID: 2621 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A3D")]
	[Address(RVA = "0x849CC0", Offset = "0x8482C0", VA = "0x180849CC0")]
	public static ItemHolderAddItem Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000A3E RID: 2622 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A3E")]
	[Address(RVA = "0x849EC0", Offset = "0x8484C0", VA = "0x180849EC0")]
	private static ItemHolderAddItem Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A3F RID: 2623 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A3F")]
	[Address(RVA = "0x849C40", Offset = "0x848240", VA = "0x180849C40")]
	public static ItemHolderAddItem Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000A40 RID: 2624 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A40")]
	[Address(RVA = "0x849C50", Offset = "0x848250", VA = "0x180849C50")]
	public static ItemHolderAddItem Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A41 RID: 2625 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A41")]
	[Address(RVA = "0x849C60", Offset = "0x848260", VA = "0x180849C60")]
	public static ItemHolderAddItem Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000A42 RID: 2626 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A42")]
	[Address(RVA = "0x849C70", Offset = "0x848270", VA = "0x180849C70")]
	public static ItemHolderAddItem Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A43 RID: 2627 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A43")]
	[Address(RVA = "0x849C90", Offset = "0x848290", VA = "0x180849C90")]
	public static ItemHolderAddItem Create()
	{
		return null;
	}

	// Token: 0x06000A44 RID: 2628 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A44")]
	[Address(RVA = "0x849CB0", Offset = "0x8482B0", VA = "0x180849CB0")]
	public static ItemHolderAddItem Create(ReliabilityModes reliability)
	{
		return null;
	}
}
