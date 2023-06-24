using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001F5 RID: 501
[Token(Token = "0x20001F5")]
public class StructureCraftingNodeAddIngredient : Event
{
	// Token: 0x060016D1 RID: 5841 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016D1")]
	[Address(RVA = "0x8B16E0", Offset = "0x8AFCE0", VA = "0x1808B16E0")]
	public StructureCraftingNodeAddIngredient()
	{
	}

	// Token: 0x170006E0 RID: 1760
	// (get) Token: 0x060016D2 RID: 5842 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060016D3 RID: 5843 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006E0")]
	public BoltEntity Target
	{
		[Token(Token = "0x60016D2")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60016D3")]
		[Address(RVA = "0x8B1740", Offset = "0x8AFD40", VA = "0x1808B1740")]
		set
		{
		}
	}

	// Token: 0x170006E1 RID: 1761
	// (get) Token: 0x060016D4 RID: 5844 RVA: 0x000076B0 File Offset: 0x000058B0
	// (set) Token: 0x060016D5 RID: 5845 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006E1")]
	public int IngredientId
	{
		[Token(Token = "0x60016D4")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60016D5")]
		[Address(RVA = "0x7D8500", Offset = "0x7D6B00", VA = "0x1807D8500")]
		set
		{
		}
	}

	// Token: 0x170006E2 RID: 1762
	// (get) Token: 0x060016D6 RID: 5846 RVA: 0x000076C8 File Offset: 0x000058C8
	// (set) Token: 0x060016D7 RID: 5847 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006E2")]
	public int Amount
	{
		[Token(Token = "0x60016D6")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60016D7")]
		[Address(RVA = "0x8B1950", Offset = "0x8AFF50", VA = "0x1808B1950")]
		set
		{
		}
	}

	// Token: 0x060016D8 RID: 5848 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016D8")]
	[Address(RVA = "0x8B1A00", Offset = "0x8B0000", VA = "0x1808B1A00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060016D9 RID: 5849 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016D9")]
	[Address(RVA = "0x8B1B40", Offset = "0x8B0140", VA = "0x1808B1B40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StructureCraftingNodeAddIngredient Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060016DA RID: 5850 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016DA")]
	[Address(RVA = "0x8B1B50", Offset = "0x8B0150", VA = "0x1808B1B50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StructureCraftingNodeAddIngredient Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060016DB RID: 5851 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016DB")]
	[Address(RVA = "0x8B1D50", Offset = "0x8B0350", VA = "0x1808B1D50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static StructureCraftingNodeAddIngredient Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060016DC RID: 5852 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016DC")]
	[Address(RVA = "0x8B1E70", Offset = "0x8B0470", VA = "0x1808B1E70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StructureCraftingNodeAddIngredient Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060016DD RID: 5853 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016DD")]
	[Address(RVA = "0x8B1E80", Offset = "0x8B0480", VA = "0x1808B1E80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StructureCraftingNodeAddIngredient Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060016DE RID: 5854 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016DE")]
	[Address(RVA = "0x8B1E90", Offset = "0x8B0490", VA = "0x1808B1E90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StructureCraftingNodeAddIngredient Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060016DF RID: 5855 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016DF")]
	[Address(RVA = "0x8B1EA0", Offset = "0x8B04A0", VA = "0x1808B1EA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StructureCraftingNodeAddIngredient Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060016E0 RID: 5856 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016E0")]
	[Address(RVA = "0x8B1EC0", Offset = "0x8B04C0", VA = "0x1808B1EC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StructureCraftingNodeAddIngredient Raise()
	{
		return null;
	}

	// Token: 0x060016E1 RID: 5857 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016E1")]
	[Address(RVA = "0x8B1EE0", Offset = "0x8B04E0", VA = "0x1808B1EE0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StructureCraftingNodeAddIngredient Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060016E2 RID: 5858 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016E2")]
	[Address(RVA = "0x8B1B40", Offset = "0x8B0140", VA = "0x1808B1B40")]
	public static StructureCraftingNodeAddIngredient Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060016E3 RID: 5859 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016E3")]
	[Address(RVA = "0x8B1EF0", Offset = "0x8B04F0", VA = "0x1808B1EF0")]
	public static StructureCraftingNodeAddIngredient Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060016E4 RID: 5860 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016E4")]
	[Address(RVA = "0x8B20F0", Offset = "0x8B06F0", VA = "0x1808B20F0")]
	private static StructureCraftingNodeAddIngredient Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060016E5 RID: 5861 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016E5")]
	[Address(RVA = "0x8B1E70", Offset = "0x8B0470", VA = "0x1808B1E70")]
	public static StructureCraftingNodeAddIngredient Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060016E6 RID: 5862 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016E6")]
	[Address(RVA = "0x8B1E80", Offset = "0x8B0480", VA = "0x1808B1E80")]
	public static StructureCraftingNodeAddIngredient Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060016E7 RID: 5863 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016E7")]
	[Address(RVA = "0x8B1E90", Offset = "0x8B0490", VA = "0x1808B1E90")]
	public static StructureCraftingNodeAddIngredient Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060016E8 RID: 5864 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016E8")]
	[Address(RVA = "0x8B1EA0", Offset = "0x8B04A0", VA = "0x1808B1EA0")]
	public static StructureCraftingNodeAddIngredient Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060016E9 RID: 5865 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016E9")]
	[Address(RVA = "0x8B1EC0", Offset = "0x8B04C0", VA = "0x1808B1EC0")]
	public static StructureCraftingNodeAddIngredient Create()
	{
		return null;
	}

	// Token: 0x060016EA RID: 5866 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016EA")]
	[Address(RVA = "0x8B1EE0", Offset = "0x8B04E0", VA = "0x1808B1EE0")]
	public static StructureCraftingNodeAddIngredient Create(ReliabilityModes reliability)
	{
		return null;
	}
}
