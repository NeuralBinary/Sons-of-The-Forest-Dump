using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000237 RID: 567
[Token(Token = "0x2000237")]
public class StructureCraftingNodeCreate : Event
{
	// Token: 0x06001A13 RID: 6675 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A13")]
	[Address(RVA = "0x8CEDE0", Offset = "0x8CD3E0", VA = "0x1808CEDE0")]
	public StructureCraftingNodeCreate()
	{
	}

	// Token: 0x1700077D RID: 1917
	// (get) Token: 0x06001A14 RID: 6676 RVA: 0x00008178 File Offset: 0x00006378
	// (set) Token: 0x06001A15 RID: 6677 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700077D")]
	public Vector3 Position
	{
		[Token(Token = "0x6001A14")]
		[Address(RVA = "0x7D3CB0", Offset = "0x7D22B0", VA = "0x1807D3CB0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001A15")]
		[Address(RVA = "0x7DD4E0", Offset = "0x7DBAE0", VA = "0x1807DD4E0")]
		set
		{
		}
	}

	// Token: 0x1700077E RID: 1918
	// (get) Token: 0x06001A16 RID: 6678 RVA: 0x00008190 File Offset: 0x00006390
	// (set) Token: 0x06001A17 RID: 6679 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700077E")]
	public Quaternion Rotation
	{
		[Token(Token = "0x6001A16")]
		[Address(RVA = "0x7FBD60", Offset = "0x7FA360", VA = "0x1807FBD60")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6001A17")]
		[Address(RVA = "0x7FBDD0", Offset = "0x7FA3D0", VA = "0x1807FBDD0")]
		set
		{
		}
	}

	// Token: 0x1700077F RID: 1919
	// (get) Token: 0x06001A18 RID: 6680 RVA: 0x000081A8 File Offset: 0x000063A8
	// (set) Token: 0x06001A19 RID: 6681 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700077F")]
	public PrefabId PrefabId
	{
		[Token(Token = "0x6001A18")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return default(PrefabId);
		}
		[Token(Token = "0x6001A19")]
		[Address(RVA = "0x835B10", Offset = "0x834110", VA = "0x180835B10")]
		set
		{
		}
	}

	// Token: 0x17000780 RID: 1920
	// (get) Token: 0x06001A1A RID: 6682 RVA: 0x000081C0 File Offset: 0x000063C0
	// (set) Token: 0x06001A1B RID: 6683 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000780")]
	public Guid TreeId
	{
		[Token(Token = "0x6001A1A")]
		[Address(RVA = "0x7DD6C0", Offset = "0x7DBCC0", VA = "0x1807DD6C0")]
		get
		{
			return default(Guid);
		}
		[Token(Token = "0x6001A1B")]
		[Address(RVA = "0x7DD730", Offset = "0x7DBD30", VA = "0x1807DD730")]
		set
		{
		}
	}

	// Token: 0x17000781 RID: 1921
	// (get) Token: 0x06001A1C RID: 6684 RVA: 0x000081D8 File Offset: 0x000063D8
	// (set) Token: 0x06001A1D RID: 6685 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000781")]
	public bool PlaceBuilt
	{
		[Token(Token = "0x6001A1C")]
		[Address(RVA = "0x7BBF10", Offset = "0x7BA510", VA = "0x1807BBF10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001A1D")]
		[Address(RVA = "0x835BB0", Offset = "0x8341B0", VA = "0x180835BB0")]
		set
		{
		}
	}

	// Token: 0x06001A1E RID: 6686 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A1E")]
	[Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001A1F RID: 6687 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A1F")]
	[Address(RVA = "0x8CF220", Offset = "0x8CD820", VA = "0x1808CF220")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StructureCraftingNodeCreate Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001A20 RID: 6688 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A20")]
	[Address(RVA = "0x8CF230", Offset = "0x8CD830", VA = "0x1808CF230")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StructureCraftingNodeCreate Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001A21 RID: 6689 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A21")]
	[Address(RVA = "0x8CF430", Offset = "0x8CDA30", VA = "0x1808CF430")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static StructureCraftingNodeCreate Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A22 RID: 6690 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A22")]
	[Address(RVA = "0x8CF550", Offset = "0x8CDB50", VA = "0x1808CF550")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StructureCraftingNodeCreate Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001A23 RID: 6691 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A23")]
	[Address(RVA = "0x8CF560", Offset = "0x8CDB60", VA = "0x1808CF560")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StructureCraftingNodeCreate Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A24 RID: 6692 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A24")]
	[Address(RVA = "0x8CF570", Offset = "0x8CDB70", VA = "0x1808CF570")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StructureCraftingNodeCreate Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001A25 RID: 6693 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A25")]
	[Address(RVA = "0x8CF580", Offset = "0x8CDB80", VA = "0x1808CF580")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StructureCraftingNodeCreate Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A26 RID: 6694 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A26")]
	[Address(RVA = "0x8CF5A0", Offset = "0x8CDBA0", VA = "0x1808CF5A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StructureCraftingNodeCreate Raise()
	{
		return null;
	}

	// Token: 0x06001A27 RID: 6695 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A27")]
	[Address(RVA = "0x8CF5C0", Offset = "0x8CDBC0", VA = "0x1808CF5C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StructureCraftingNodeCreate Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A28 RID: 6696 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A28")]
	[Address(RVA = "0x8CF220", Offset = "0x8CD820", VA = "0x1808CF220")]
	public static StructureCraftingNodeCreate Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001A29 RID: 6697 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A29")]
	[Address(RVA = "0x8CF5D0", Offset = "0x8CDBD0", VA = "0x1808CF5D0")]
	public static StructureCraftingNodeCreate Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001A2A RID: 6698 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A2A")]
	[Address(RVA = "0x8CF7D0", Offset = "0x8CDDD0", VA = "0x1808CF7D0")]
	private static StructureCraftingNodeCreate Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A2B RID: 6699 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A2B")]
	[Address(RVA = "0x8CF550", Offset = "0x8CDB50", VA = "0x1808CF550")]
	public static StructureCraftingNodeCreate Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001A2C RID: 6700 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A2C")]
	[Address(RVA = "0x8CF560", Offset = "0x8CDB60", VA = "0x1808CF560")]
	public static StructureCraftingNodeCreate Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A2D RID: 6701 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A2D")]
	[Address(RVA = "0x8CF570", Offset = "0x8CDB70", VA = "0x1808CF570")]
	public static StructureCraftingNodeCreate Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001A2E RID: 6702 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A2E")]
	[Address(RVA = "0x8CF580", Offset = "0x8CDB80", VA = "0x1808CF580")]
	public static StructureCraftingNodeCreate Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A2F RID: 6703 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A2F")]
	[Address(RVA = "0x8CF5A0", Offset = "0x8CDBA0", VA = "0x1808CF5A0")]
	public static StructureCraftingNodeCreate Create()
	{
		return null;
	}

	// Token: 0x06001A30 RID: 6704 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A30")]
	[Address(RVA = "0x8CF5C0", Offset = "0x8CDBC0", VA = "0x1808CF5C0")]
	public static StructureCraftingNodeCreate Create(ReliabilityModes reliability)
	{
		return null;
	}
}
