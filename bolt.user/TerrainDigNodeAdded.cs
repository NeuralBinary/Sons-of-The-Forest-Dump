using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200023A RID: 570
[Token(Token = "0x200023A")]
public class TerrainDigNodeAdded : Event
{
	// Token: 0x06001A3B RID: 6715 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A3B")]
	[Address(RVA = "0x8D03A0", Offset = "0x8CE9A0", VA = "0x1808D03A0")]
	public TerrainDigNodeAdded()
	{
	}

	// Token: 0x17000785 RID: 1925
	// (get) Token: 0x06001A3C RID: 6716 RVA: 0x00008220 File Offset: 0x00006420
	// (set) Token: 0x06001A3D RID: 6717 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000785")]
	public Vector3 Position
	{
		[Token(Token = "0x6001A3C")]
		[Address(RVA = "0x7D3CB0", Offset = "0x7D22B0", VA = "0x1807D3CB0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001A3D")]
		[Address(RVA = "0x8D0400", Offset = "0x8CEA00", VA = "0x1808D0400")]
		set
		{
		}
	}

	// Token: 0x17000786 RID: 1926
	// (get) Token: 0x06001A3E RID: 6718 RVA: 0x00008238 File Offset: 0x00006438
	// (set) Token: 0x06001A3F RID: 6719 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000786")]
	public Vector3 Normal
	{
		[Token(Token = "0x6001A3E")]
		[Address(RVA = "0x7BCBD0", Offset = "0x7BB1D0", VA = "0x1807BCBD0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001A3F")]
		[Address(RVA = "0x8D0510", Offset = "0x8CEB10", VA = "0x1808D0510")]
		set
		{
		}
	}

	// Token: 0x17000787 RID: 1927
	// (get) Token: 0x06001A40 RID: 6720 RVA: 0x00008250 File Offset: 0x00006450
	// (set) Token: 0x06001A41 RID: 6721 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000787")]
	public int ProminentTerrainLayer
	{
		[Token(Token = "0x6001A40")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001A41")]
		[Address(RVA = "0x8D0620", Offset = "0x8CEC20", VA = "0x1808D0620")]
		set
		{
		}
	}

	// Token: 0x17000788 RID: 1928
	// (get) Token: 0x06001A42 RID: 6722 RVA: 0x00008268 File Offset: 0x00006468
	// (set) Token: 0x06001A43 RID: 6723 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000788")]
	public int NodeType
	{
		[Token(Token = "0x6001A42")]
		[Address(RVA = "0x7B6B40", Offset = "0x7B5140", VA = "0x1807B6B40")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001A43")]
		[Address(RVA = "0x843DA0", Offset = "0x8423A0", VA = "0x180843DA0")]
		set
		{
		}
	}

	// Token: 0x06001A44 RID: 6724 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A44")]
	[Address(RVA = "0x8D06D0", Offset = "0x8CECD0", VA = "0x1808D06D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001A45 RID: 6725 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A45")]
	[Address(RVA = "0x8D09F0", Offset = "0x8CEFF0", VA = "0x1808D09F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TerrainDigNodeAdded Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001A46 RID: 6726 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A46")]
	[Address(RVA = "0x8D0A00", Offset = "0x8CF000", VA = "0x1808D0A00")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TerrainDigNodeAdded Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001A47 RID: 6727 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A47")]
	[Address(RVA = "0x8D0C00", Offset = "0x8CF200", VA = "0x1808D0C00")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static TerrainDigNodeAdded Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A48 RID: 6728 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A48")]
	[Address(RVA = "0x8D0D20", Offset = "0x8CF320", VA = "0x1808D0D20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TerrainDigNodeAdded Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001A49 RID: 6729 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A49")]
	[Address(RVA = "0x8D0D30", Offset = "0x8CF330", VA = "0x1808D0D30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TerrainDigNodeAdded Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A4A RID: 6730 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A4A")]
	[Address(RVA = "0x8D0D40", Offset = "0x8CF340", VA = "0x1808D0D40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TerrainDigNodeAdded Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001A4B RID: 6731 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A4B")]
	[Address(RVA = "0x8D0D50", Offset = "0x8CF350", VA = "0x1808D0D50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TerrainDigNodeAdded Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A4C RID: 6732 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A4C")]
	[Address(RVA = "0x8D0D70", Offset = "0x8CF370", VA = "0x1808D0D70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TerrainDigNodeAdded Raise()
	{
		return null;
	}

	// Token: 0x06001A4D RID: 6733 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A4D")]
	[Address(RVA = "0x8D0D90", Offset = "0x8CF390", VA = "0x1808D0D90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TerrainDigNodeAdded Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A4E RID: 6734 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A4E")]
	[Address(RVA = "0x8D09F0", Offset = "0x8CEFF0", VA = "0x1808D09F0")]
	public static TerrainDigNodeAdded Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001A4F RID: 6735 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A4F")]
	[Address(RVA = "0x8D0DA0", Offset = "0x8CF3A0", VA = "0x1808D0DA0")]
	public static TerrainDigNodeAdded Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001A50 RID: 6736 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A50")]
	[Address(RVA = "0x8D0FA0", Offset = "0x8CF5A0", VA = "0x1808D0FA0")]
	private static TerrainDigNodeAdded Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A51 RID: 6737 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A51")]
	[Address(RVA = "0x8D0D20", Offset = "0x8CF320", VA = "0x1808D0D20")]
	public static TerrainDigNodeAdded Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001A52 RID: 6738 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A52")]
	[Address(RVA = "0x8D0D30", Offset = "0x8CF330", VA = "0x1808D0D30")]
	public static TerrainDigNodeAdded Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A53 RID: 6739 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A53")]
	[Address(RVA = "0x8D0D40", Offset = "0x8CF340", VA = "0x1808D0D40")]
	public static TerrainDigNodeAdded Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001A54 RID: 6740 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A54")]
	[Address(RVA = "0x8D0D50", Offset = "0x8CF350", VA = "0x1808D0D50")]
	public static TerrainDigNodeAdded Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A55 RID: 6741 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A55")]
	[Address(RVA = "0x8D0D70", Offset = "0x8CF370", VA = "0x1808D0D70")]
	public static TerrainDigNodeAdded Create()
	{
		return null;
	}

	// Token: 0x06001A56 RID: 6742 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A56")]
	[Address(RVA = "0x8D0D90", Offset = "0x8CF390", VA = "0x1808D0D90")]
	public static TerrainDigNodeAdded Create(ReliabilityModes reliability)
	{
		return null;
	}
}
