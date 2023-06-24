using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000B4 RID: 180
[Token(Token = "0x20000B4")]
public class PlaceConstruction : Event
{
	// Token: 0x0600082D RID: 2093 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600082D")]
	[Address(RVA = "0x835AB0", Offset = "0x8340B0", VA = "0x180835AB0")]
	public PlaceConstruction()
	{
	}

	// Token: 0x1700047A RID: 1146
	// (get) Token: 0x0600082E RID: 2094 RVA: 0x000050E8 File Offset: 0x000032E8
	// (set) Token: 0x0600082F RID: 2095 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700047A")]
	public Vector3 Position
	{
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x7D3CB0", Offset = "0x7D22B0", VA = "0x1807D3CB0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600082F")]
		[Address(RVA = "0x7DD4E0", Offset = "0x7DBAE0", VA = "0x1807DD4E0")]
		set
		{
		}
	}

	// Token: 0x1700047B RID: 1147
	// (get) Token: 0x06000830 RID: 2096 RVA: 0x00005100 File Offset: 0x00003300
	// (set) Token: 0x06000831 RID: 2097 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700047B")]
	public Quaternion Rotation
	{
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x7FBD60", Offset = "0x7FA360", VA = "0x1807FBD60")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x7FBDD0", Offset = "0x7FA3D0", VA = "0x1807FBDD0")]
		set
		{
		}
	}

	// Token: 0x1700047C RID: 1148
	// (get) Token: 0x06000832 RID: 2098 RVA: 0x00005118 File Offset: 0x00003318
	// (set) Token: 0x06000833 RID: 2099 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700047C")]
	public PrefabId PrefabId
	{
		[Token(Token = "0x6000832")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return default(PrefabId);
		}
		[Token(Token = "0x6000833")]
		[Address(RVA = "0x835B10", Offset = "0x834110", VA = "0x180835B10")]
		set
		{
		}
	}

	// Token: 0x1700047D RID: 1149
	// (get) Token: 0x06000834 RID: 2100 RVA: 0x00005130 File Offset: 0x00003330
	// (set) Token: 0x06000835 RID: 2101 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700047D")]
	public int TreeIndex
	{
		[Token(Token = "0x6000834")]
		[Address(RVA = "0x7B6B40", Offset = "0x7B5140", VA = "0x1807B6B40")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x7E1CC0", Offset = "0x7E02C0", VA = "0x1807E1CC0")]
		set
		{
		}
	}

	// Token: 0x1700047E RID: 1150
	// (get) Token: 0x06000836 RID: 2102 RVA: 0x00005148 File Offset: 0x00003348
	// (set) Token: 0x06000837 RID: 2103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700047E")]
	public bool TreeBuilding
	{
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x7BBF10", Offset = "0x7BA510", VA = "0x1807BBF10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x835BB0", Offset = "0x8341B0", VA = "0x180835BB0")]
		set
		{
		}
	}

	// Token: 0x1700047F RID: 1151
	// (get) Token: 0x06000838 RID: 2104 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000839 RID: 2105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700047F")]
	public BoltEntity Parent
	{
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x835C50", Offset = "0x834250", VA = "0x180835C50")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x835CF0", Offset = "0x8342F0", VA = "0x180835CF0")]
		set
		{
		}
	}

	// Token: 0x17000480 RID: 1152
	// (get) Token: 0x0600083A RID: 2106 RVA: 0x00005160 File Offset: 0x00003360
	// (set) Token: 0x0600083B RID: 2107 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000480")]
	public bool AboveGround
	{
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x835F10", Offset = "0x834510", VA = "0x180835F10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600083B")]
		[Address(RVA = "0x835F70", Offset = "0x834570", VA = "0x180835F70")]
		set
		{
		}
	}

	// Token: 0x0600083C RID: 2108 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600083C")]
	[Address(RVA = "0x836010", Offset = "0x834610", VA = "0x180836010", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0600083D RID: 2109 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600083D")]
	[Address(RVA = "0x836550", Offset = "0x834B50", VA = "0x180836550")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceConstruction Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600083E RID: 2110 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600083E")]
	[Address(RVA = "0x836560", Offset = "0x834B60", VA = "0x180836560")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceConstruction Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600083F RID: 2111 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600083F")]
	[Address(RVA = "0x836760", Offset = "0x834D60", VA = "0x180836760")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static PlaceConstruction Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000840")]
	[Address(RVA = "0x836880", Offset = "0x834E80", VA = "0x180836880")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceConstruction Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000841 RID: 2113 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000841")]
	[Address(RVA = "0x836890", Offset = "0x834E90", VA = "0x180836890")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceConstruction Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000842 RID: 2114 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000842")]
	[Address(RVA = "0x8368A0", Offset = "0x834EA0", VA = "0x1808368A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceConstruction Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000843")]
	[Address(RVA = "0x8368B0", Offset = "0x834EB0", VA = "0x1808368B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceConstruction Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000844 RID: 2116 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000844")]
	[Address(RVA = "0x8368D0", Offset = "0x834ED0", VA = "0x1808368D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceConstruction Raise()
	{
		return null;
	}

	// Token: 0x06000845 RID: 2117 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000845")]
	[Address(RVA = "0x8368F0", Offset = "0x834EF0", VA = "0x1808368F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceConstruction Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000846 RID: 2118 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000846")]
	[Address(RVA = "0x836550", Offset = "0x834B50", VA = "0x180836550")]
	public static PlaceConstruction Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000847")]
	[Address(RVA = "0x836900", Offset = "0x834F00", VA = "0x180836900")]
	public static PlaceConstruction Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000848 RID: 2120 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000848")]
	[Address(RVA = "0x836B00", Offset = "0x835100", VA = "0x180836B00")]
	private static PlaceConstruction Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000849 RID: 2121 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000849")]
	[Address(RVA = "0x836880", Offset = "0x834E80", VA = "0x180836880")]
	public static PlaceConstruction Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600084A RID: 2122 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600084A")]
	[Address(RVA = "0x836890", Offset = "0x834E90", VA = "0x180836890")]
	public static PlaceConstruction Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600084B RID: 2123 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600084B")]
	[Address(RVA = "0x8368A0", Offset = "0x834EA0", VA = "0x1808368A0")]
	public static PlaceConstruction Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600084C RID: 2124 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600084C")]
	[Address(RVA = "0x8368B0", Offset = "0x834EB0", VA = "0x1808368B0")]
	public static PlaceConstruction Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600084D RID: 2125 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600084D")]
	[Address(RVA = "0x8368D0", Offset = "0x834ED0", VA = "0x1808368D0")]
	public static PlaceConstruction Create()
	{
		return null;
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600084E")]
	[Address(RVA = "0x8368F0", Offset = "0x834EF0", VA = "0x1808368F0")]
	public static PlaceConstruction Create(ReliabilityModes reliability)
	{
		return null;
	}
}
