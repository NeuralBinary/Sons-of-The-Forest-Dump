using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000DE RID: 222
[Token(Token = "0x20000DE")]
public class ItemHolderTakeItem : Event
{
	// Token: 0x06000A4F RID: 2639 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A4F")]
	[Address(RVA = "0x84A8A0", Offset = "0x848EA0", VA = "0x18084A8A0")]
	public ItemHolderTakeItem()
	{
	}

	// Token: 0x170004E5 RID: 1253
	// (get) Token: 0x06000A50 RID: 2640 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000A51 RID: 2641 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004E5")]
	public BoltEntity Target
	{
		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x84A900", Offset = "0x848F00", VA = "0x18084A900")]
		set
		{
		}
	}

	// Token: 0x170004E6 RID: 1254
	// (get) Token: 0x06000A52 RID: 2642 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000A53 RID: 2643 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004E6")]
	public BoltEntity Player
	{
		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x84AB10", Offset = "0x849110", VA = "0x18084AB10")]
		set
		{
		}
	}

	// Token: 0x170004E7 RID: 1255
	// (get) Token: 0x06000A54 RID: 2644 RVA: 0x00005820 File Offset: 0x00003A20
	// (set) Token: 0x06000A55 RID: 2645 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004E7")]
	public int ContentType
	{
		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x7D6E60", Offset = "0x7D5460", VA = "0x1807D6E60")]
		set
		{
		}
	}

	// Token: 0x170004E8 RID: 1256
	// (get) Token: 0x06000A56 RID: 2646 RVA: 0x00005838 File Offset: 0x00003A38
	// (set) Token: 0x06000A57 RID: 2647 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004E8")]
	public int ContentValue
	{
		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x7B6B40", Offset = "0x7B5140", VA = "0x1807B6B40")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x7E1CC0", Offset = "0x7E02C0", VA = "0x1807E1CC0")]
		set
		{
		}
	}

	// Token: 0x06000A58 RID: 2648 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A58")]
	[Address(RVA = "0x84AD20", Offset = "0x849320", VA = "0x18084AD20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000A59 RID: 2649 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A59")]
	[Address(RVA = "0x84B070", Offset = "0x849670", VA = "0x18084B070")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemHolderTakeItem Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000A5A RID: 2650 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A5A")]
	[Address(RVA = "0x84B080", Offset = "0x849680", VA = "0x18084B080")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemHolderTakeItem Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000A5B RID: 2651 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A5B")]
	[Address(RVA = "0x84B280", Offset = "0x849880", VA = "0x18084B280")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static ItemHolderTakeItem Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A5C RID: 2652 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A5C")]
	[Address(RVA = "0x84B3A0", Offset = "0x8499A0", VA = "0x18084B3A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemHolderTakeItem Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000A5D RID: 2653 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A5D")]
	[Address(RVA = "0x84B3B0", Offset = "0x8499B0", VA = "0x18084B3B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemHolderTakeItem Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A5E RID: 2654 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A5E")]
	[Address(RVA = "0x84B3C0", Offset = "0x8499C0", VA = "0x18084B3C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemHolderTakeItem Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000A5F RID: 2655 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A5F")]
	[Address(RVA = "0x84B3D0", Offset = "0x8499D0", VA = "0x18084B3D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemHolderTakeItem Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A60 RID: 2656 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A60")]
	[Address(RVA = "0x84B3F0", Offset = "0x8499F0", VA = "0x18084B3F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemHolderTakeItem Raise()
	{
		return null;
	}

	// Token: 0x06000A61 RID: 2657 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A61")]
	[Address(RVA = "0x84B410", Offset = "0x849A10", VA = "0x18084B410")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemHolderTakeItem Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A62 RID: 2658 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A62")]
	[Address(RVA = "0x84B070", Offset = "0x849670", VA = "0x18084B070")]
	public static ItemHolderTakeItem Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000A63 RID: 2659 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A63")]
	[Address(RVA = "0x84B420", Offset = "0x849A20", VA = "0x18084B420")]
	public static ItemHolderTakeItem Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000A64 RID: 2660 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A64")]
	[Address(RVA = "0x84B620", Offset = "0x849C20", VA = "0x18084B620")]
	private static ItemHolderTakeItem Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A65 RID: 2661 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A65")]
	[Address(RVA = "0x84B3A0", Offset = "0x8499A0", VA = "0x18084B3A0")]
	public static ItemHolderTakeItem Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000A66 RID: 2662 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A66")]
	[Address(RVA = "0x84B3B0", Offset = "0x8499B0", VA = "0x18084B3B0")]
	public static ItemHolderTakeItem Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A67 RID: 2663 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A67")]
	[Address(RVA = "0x84B3C0", Offset = "0x8499C0", VA = "0x18084B3C0")]
	public static ItemHolderTakeItem Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000A68 RID: 2664 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A68")]
	[Address(RVA = "0x84B3D0", Offset = "0x8499D0", VA = "0x18084B3D0")]
	public static ItemHolderTakeItem Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A69 RID: 2665 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A69")]
	[Address(RVA = "0x84B3F0", Offset = "0x8499F0", VA = "0x18084B3F0")]
	public static ItemHolderTakeItem Create()
	{
		return null;
	}

	// Token: 0x06000A6A RID: 2666 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A6A")]
	[Address(RVA = "0x84B410", Offset = "0x849A10", VA = "0x18084B410")]
	public static ItemHolderTakeItem Create(ReliabilityModes reliability)
	{
		return null;
	}
}
