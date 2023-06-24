using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001F2 RID: 498
[Token(Token = "0x20001F2")]
public class StructureCraftingNodeCancel : Event
{
	// Token: 0x060016B1 RID: 5809 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016B1")]
	[Address(RVA = "0x8B07E0", Offset = "0x8AEDE0", VA = "0x1808B07E0")]
	public StructureCraftingNodeCancel()
	{
	}

	// Token: 0x170006DC RID: 1756
	// (get) Token: 0x060016B2 RID: 5810 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060016B3 RID: 5811 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006DC")]
	public BoltEntity Target
	{
		[Token(Token = "0x60016B2")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60016B3")]
		[Address(RVA = "0x8B0840", Offset = "0x8AEE40", VA = "0x1808B0840")]
		set
		{
		}
	}

	// Token: 0x060016B4 RID: 5812 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016B4")]
	[Address(RVA = "0x8B0A50", Offset = "0x8AF050", VA = "0x1808B0A50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060016B5 RID: 5813 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016B5")]
	[Address(RVA = "0x8B0AA0", Offset = "0x8AF0A0", VA = "0x1808B0AA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StructureCraftingNodeCancel Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060016B6 RID: 5814 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016B6")]
	[Address(RVA = "0x8B0AB0", Offset = "0x8AF0B0", VA = "0x1808B0AB0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StructureCraftingNodeCancel Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060016B7 RID: 5815 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016B7")]
	[Address(RVA = "0x8B0CB0", Offset = "0x8AF2B0", VA = "0x1808B0CB0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static StructureCraftingNodeCancel Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060016B8 RID: 5816 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016B8")]
	[Address(RVA = "0x8B0DD0", Offset = "0x8AF3D0", VA = "0x1808B0DD0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StructureCraftingNodeCancel Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060016B9 RID: 5817 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016B9")]
	[Address(RVA = "0x8B0DE0", Offset = "0x8AF3E0", VA = "0x1808B0DE0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StructureCraftingNodeCancel Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060016BA RID: 5818 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016BA")]
	[Address(RVA = "0x8B0DF0", Offset = "0x8AF3F0", VA = "0x1808B0DF0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StructureCraftingNodeCancel Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060016BB RID: 5819 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016BB")]
	[Address(RVA = "0x8B0E00", Offset = "0x8AF400", VA = "0x1808B0E00")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StructureCraftingNodeCancel Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060016BC RID: 5820 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016BC")]
	[Address(RVA = "0x8B0E20", Offset = "0x8AF420", VA = "0x1808B0E20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StructureCraftingNodeCancel Raise()
	{
		return null;
	}

	// Token: 0x060016BD RID: 5821 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016BD")]
	[Address(RVA = "0x8B0E40", Offset = "0x8AF440", VA = "0x1808B0E40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StructureCraftingNodeCancel Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060016BE RID: 5822 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016BE")]
	[Address(RVA = "0x8B0AA0", Offset = "0x8AF0A0", VA = "0x1808B0AA0")]
	public static StructureCraftingNodeCancel Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060016BF RID: 5823 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016BF")]
	[Address(RVA = "0x8B0E50", Offset = "0x8AF450", VA = "0x1808B0E50")]
	public static StructureCraftingNodeCancel Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060016C0 RID: 5824 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016C0")]
	[Address(RVA = "0x8B1050", Offset = "0x8AF650", VA = "0x1808B1050")]
	private static StructureCraftingNodeCancel Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060016C1 RID: 5825 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016C1")]
	[Address(RVA = "0x8B0DD0", Offset = "0x8AF3D0", VA = "0x1808B0DD0")]
	public static StructureCraftingNodeCancel Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060016C2 RID: 5826 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016C2")]
	[Address(RVA = "0x8B0DE0", Offset = "0x8AF3E0", VA = "0x1808B0DE0")]
	public static StructureCraftingNodeCancel Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060016C3 RID: 5827 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016C3")]
	[Address(RVA = "0x8B0DF0", Offset = "0x8AF3F0", VA = "0x1808B0DF0")]
	public static StructureCraftingNodeCancel Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060016C4 RID: 5828 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016C4")]
	[Address(RVA = "0x8B0E00", Offset = "0x8AF400", VA = "0x1808B0E00")]
	public static StructureCraftingNodeCancel Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060016C5 RID: 5829 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016C5")]
	[Address(RVA = "0x8B0E20", Offset = "0x8AF420", VA = "0x1808B0E20")]
	public static StructureCraftingNodeCancel Create()
	{
		return null;
	}

	// Token: 0x060016C6 RID: 5830 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016C6")]
	[Address(RVA = "0x8B0E40", Offset = "0x8AF440", VA = "0x1808B0E40")]
	public static StructureCraftingNodeCancel Create(ReliabilityModes reliability)
	{
		return null;
	}
}
