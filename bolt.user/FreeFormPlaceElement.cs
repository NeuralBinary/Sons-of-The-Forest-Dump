using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200020A RID: 522
[Token(Token = "0x200020A")]
public class FreeFormPlaceElement : Event
{
	// Token: 0x060017C3 RID: 6083 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017C3")]
	[Address(RVA = "0x8B9230", Offset = "0x8B7830", VA = "0x1808B9230")]
	public FreeFormPlaceElement()
	{
	}

	// Token: 0x17000707 RID: 1799
	// (get) Token: 0x060017C4 RID: 6084 RVA: 0x00007908 File Offset: 0x00005B08
	// (set) Token: 0x060017C5 RID: 6085 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000707")]
	public int DBVersion
	{
		[Token(Token = "0x60017C4")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017C5")]
		[Address(RVA = "0x7EB470", Offset = "0x7E9A70", VA = "0x1807EB470")]
		set
		{
		}
	}

	// Token: 0x17000708 RID: 1800
	// (get) Token: 0x060017C6 RID: 6086 RVA: 0x00007920 File Offset: 0x00005B20
	// (set) Token: 0x060017C7 RID: 6087 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000708")]
	public int ModuleID
	{
		[Token(Token = "0x60017C6")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017C7")]
		[Address(RVA = "0x7F3530", Offset = "0x7F1B30", VA = "0x1807F3530")]
		set
		{
		}
	}

	// Token: 0x17000709 RID: 1801
	// (get) Token: 0x060017C8 RID: 6088 RVA: 0x00007938 File Offset: 0x00005B38
	// (set) Token: 0x060017C9 RID: 6089 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000709")]
	public int ItemID
	{
		[Token(Token = "0x60017C8")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017C9")]
		[Address(RVA = "0x8B9290", Offset = "0x8B7890", VA = "0x1808B9290")]
		set
		{
		}
	}

	// Token: 0x1700070A RID: 1802
	// (get) Token: 0x060017CA RID: 6090 RVA: 0x00007950 File Offset: 0x00005B50
	// (set) Token: 0x060017CB RID: 6091 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700070A")]
	public int TargetElementTransformIndex
	{
		[Token(Token = "0x60017CA")]
		[Address(RVA = "0x7B6B40", Offset = "0x7B5140", VA = "0x1807B6B40")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017CB")]
		[Address(RVA = "0x8B9340", Offset = "0x8B7940", VA = "0x1808B9340")]
		set
		{
		}
	}

	// Token: 0x1700070B RID: 1803
	// (get) Token: 0x060017CC RID: 6092 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060017CD RID: 6093 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700070B")]
	public BoltEntity PickupEntity
	{
		[Token(Token = "0x60017CC")]
		[Address(RVA = "0x8314C0", Offset = "0x82FAC0", VA = "0x1808314C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60017CD")]
		[Address(RVA = "0x8B93F0", Offset = "0x8B79F0", VA = "0x1808B93F0")]
		set
		{
		}
	}

	// Token: 0x1700070C RID: 1804
	// (get) Token: 0x060017CE RID: 6094 RVA: 0x00007968 File Offset: 0x00005B68
	// (set) Token: 0x060017CF RID: 6095 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700070C")]
	public int PlacementMode
	{
		[Token(Token = "0x60017CE")]
		[Address(RVA = "0x7E1E00", Offset = "0x7E0400", VA = "0x1807E1E00")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017CF")]
		[Address(RVA = "0x8B9610", Offset = "0x8B7C10", VA = "0x1808B9610")]
		set
		{
		}
	}

	// Token: 0x1700070D RID: 1805
	// (get) Token: 0x060017D0 RID: 6096 RVA: 0x00007980 File Offset: 0x00005B80
	// (set) Token: 0x060017D1 RID: 6097 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700070D")]
	public Vector3 PlacePosition
	{
		[Token(Token = "0x60017D0")]
		[Address(RVA = "0x83A710", Offset = "0x838D10", VA = "0x18083A710")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60017D1")]
		[Address(RVA = "0x8B96C0", Offset = "0x8B7CC0", VA = "0x1808B96C0")]
		set
		{
		}
	}

	// Token: 0x1700070E RID: 1806
	// (get) Token: 0x060017D2 RID: 6098 RVA: 0x00007998 File Offset: 0x00005B98
	// (set) Token: 0x060017D3 RID: 6099 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700070E")]
	public Vector3 PlaceAxis
	{
		[Token(Token = "0x60017D2")]
		[Address(RVA = "0x8A6BF0", Offset = "0x8A51F0", VA = "0x1808A6BF0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60017D3")]
		[Address(RVA = "0x8B9770", Offset = "0x8B7D70", VA = "0x1808B9770")]
		set
		{
		}
	}

	// Token: 0x1700070F RID: 1807
	// (get) Token: 0x060017D4 RID: 6100 RVA: 0x000079B0 File Offset: 0x00005BB0
	// (set) Token: 0x060017D5 RID: 6101 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700070F")]
	public Vector3 HitNormal
	{
		[Token(Token = "0x60017D4")]
		[Address(RVA = "0x8A6D80", Offset = "0x8A5380", VA = "0x1808A6D80")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60017D5")]
		[Address(RVA = "0x8B9880", Offset = "0x8B7E80", VA = "0x1808B9880")]
		set
		{
		}
	}

	// Token: 0x17000710 RID: 1808
	// (get) Token: 0x060017D6 RID: 6102 RVA: 0x000079C8 File Offset: 0x00005BC8
	// (set) Token: 0x060017D7 RID: 6103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000710")]
	public Vector3 LookAtPos
	{
		[Token(Token = "0x60017D6")]
		[Address(RVA = "0x8B9990", Offset = "0x8B7F90", VA = "0x1808B9990")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60017D7")]
		[Address(RVA = "0x8B9A10", Offset = "0x8B8010", VA = "0x1808B9A10")]
		set
		{
		}
	}

	// Token: 0x17000711 RID: 1809
	// (get) Token: 0x060017D8 RID: 6104 RVA: 0x000079E0 File Offset: 0x00005BE0
	// (set) Token: 0x060017D9 RID: 6105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000711")]
	public int TargetTypeID
	{
		[Token(Token = "0x60017D8")]
		[Address(RVA = "0x82D410", Offset = "0x82BA10", VA = "0x18082D410")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017D9")]
		[Address(RVA = "0x8B9B20", Offset = "0x8B8120", VA = "0x1808B9B20")]
		set
		{
		}
	}

	// Token: 0x17000712 RID: 1810
	// (get) Token: 0x060017DA RID: 6106 RVA: 0x000079F8 File Offset: 0x00005BF8
	// (set) Token: 0x060017DB RID: 6107 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000712")]
	public int TargetInstanceID
	{
		[Token(Token = "0x60017DA")]
		[Address(RVA = "0x82D570", Offset = "0x82BB70", VA = "0x18082D570")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017DB")]
		[Address(RVA = "0x8B9BD0", Offset = "0x8B81D0", VA = "0x1808B9BD0")]
		set
		{
		}
	}

	// Token: 0x17000713 RID: 1811
	// (get) Token: 0x060017DC RID: 6108 RVA: 0x00007A10 File Offset: 0x00005C10
	// (set) Token: 0x060017DD RID: 6109 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000713")]
	public int TargetDir
	{
		[Token(Token = "0x60017DC")]
		[Address(RVA = "0x82D6C0", Offset = "0x82BCC0", VA = "0x18082D6C0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017DD")]
		[Address(RVA = "0x8B9C70", Offset = "0x8B8270", VA = "0x1808B9C70")]
		set
		{
		}
	}

	// Token: 0x17000714 RID: 1812
	// (get) Token: 0x060017DE RID: 6110 RVA: 0x00007A28 File Offset: 0x00005C28
	// (set) Token: 0x060017DF RID: 6111 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000714")]
	public int EditingTypeID
	{
		[Token(Token = "0x60017DE")]
		[Address(RVA = "0x8A6F10", Offset = "0x8A5510", VA = "0x1808A6F10")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017DF")]
		[Address(RVA = "0x8B9D20", Offset = "0x8B8320", VA = "0x1808B9D20")]
		set
		{
		}
	}

	// Token: 0x17000715 RID: 1813
	// (get) Token: 0x060017E0 RID: 6112 RVA: 0x00007A40 File Offset: 0x00005C40
	// (set) Token: 0x060017E1 RID: 6113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000715")]
	public int EditingInstanceID
	{
		[Token(Token = "0x60017E0")]
		[Address(RVA = "0x8B9DD0", Offset = "0x8B83D0", VA = "0x1808B9DD0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017E1")]
		[Address(RVA = "0x8B9E30", Offset = "0x8B8430", VA = "0x1808B9E30")]
		set
		{
		}
	}

	// Token: 0x17000716 RID: 1814
	// (get) Token: 0x060017E2 RID: 6114 RVA: 0x00007A58 File Offset: 0x00005C58
	// (set) Token: 0x060017E3 RID: 6115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000716")]
	public int EditingDir
	{
		[Token(Token = "0x60017E2")]
		[Address(RVA = "0x8B9ED0", Offset = "0x8B84D0", VA = "0x1808B9ED0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017E3")]
		[Address(RVA = "0x8B9F30", Offset = "0x8B8530", VA = "0x1808B9F30")]
		set
		{
		}
	}

	// Token: 0x17000717 RID: 1815
	// (get) Token: 0x060017E4 RID: 6116 RVA: 0x00007A70 File Offset: 0x00005C70
	// (set) Token: 0x060017E5 RID: 6117 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000717")]
	public int Support1TypeID
	{
		[Token(Token = "0x60017E4")]
		[Address(RVA = "0x80B3D0", Offset = "0x8099D0", VA = "0x18080B3D0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017E5")]
		[Address(RVA = "0x8B9FE0", Offset = "0x8B85E0", VA = "0x1808B9FE0")]
		set
		{
		}
	}

	// Token: 0x17000718 RID: 1816
	// (get) Token: 0x060017E6 RID: 6118 RVA: 0x00007A88 File Offset: 0x00005C88
	// (set) Token: 0x060017E7 RID: 6119 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000718")]
	public int Support1InstanceID
	{
		[Token(Token = "0x60017E6")]
		[Address(RVA = "0x7C5080", Offset = "0x7C3680", VA = "0x1807C5080")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017E7")]
		[Address(RVA = "0x8BA090", Offset = "0x8B8690", VA = "0x1808BA090")]
		set
		{
		}
	}

	// Token: 0x17000719 RID: 1817
	// (get) Token: 0x060017E8 RID: 6120 RVA: 0x00007AA0 File Offset: 0x00005CA0
	// (set) Token: 0x060017E9 RID: 6121 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000719")]
	public int Support1Dir
	{
		[Token(Token = "0x60017E8")]
		[Address(RVA = "0x8BA130", Offset = "0x8B8730", VA = "0x1808BA130")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017E9")]
		[Address(RVA = "0x8BA190", Offset = "0x8B8790", VA = "0x1808BA190")]
		set
		{
		}
	}

	// Token: 0x1700071A RID: 1818
	// (get) Token: 0x060017EA RID: 6122 RVA: 0x00007AB8 File Offset: 0x00005CB8
	// (set) Token: 0x060017EB RID: 6123 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700071A")]
	public int Support2TypeID
	{
		[Token(Token = "0x60017EA")]
		[Address(RVA = "0x8BA240", Offset = "0x8B8840", VA = "0x1808BA240")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017EB")]
		[Address(RVA = "0x8BA2A0", Offset = "0x8B88A0", VA = "0x1808BA2A0")]
		set
		{
		}
	}

	// Token: 0x1700071B RID: 1819
	// (get) Token: 0x060017EC RID: 6124 RVA: 0x00007AD0 File Offset: 0x00005CD0
	// (set) Token: 0x060017ED RID: 6125 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700071B")]
	public int Support2InstanceID
	{
		[Token(Token = "0x60017EC")]
		[Address(RVA = "0x810090", Offset = "0x80E690", VA = "0x180810090")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017ED")]
		[Address(RVA = "0x8BA350", Offset = "0x8B8950", VA = "0x1808BA350")]
		set
		{
		}
	}

	// Token: 0x1700071C RID: 1820
	// (get) Token: 0x060017EE RID: 6126 RVA: 0x00007AE8 File Offset: 0x00005CE8
	// (set) Token: 0x060017EF RID: 6127 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700071C")]
	public int Support2Dir
	{
		[Token(Token = "0x60017EE")]
		[Address(RVA = "0x8101F0", Offset = "0x80E7F0", VA = "0x1808101F0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017EF")]
		[Address(RVA = "0x8BA3F0", Offset = "0x8B89F0", VA = "0x1808BA3F0")]
		set
		{
		}
	}

	// Token: 0x1700071D RID: 1821
	// (get) Token: 0x060017F0 RID: 6128 RVA: 0x00007B00 File Offset: 0x00005D00
	// (set) Token: 0x060017F1 RID: 6129 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700071D")]
	public int Support3TypeID
	{
		[Token(Token = "0x60017F0")]
		[Address(RVA = "0x810350", Offset = "0x80E950", VA = "0x180810350")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017F1")]
		[Address(RVA = "0x8BA4A0", Offset = "0x8B8AA0", VA = "0x1808BA4A0")]
		set
		{
		}
	}

	// Token: 0x1700071E RID: 1822
	// (get) Token: 0x060017F2 RID: 6130 RVA: 0x00007B18 File Offset: 0x00005D18
	// (set) Token: 0x060017F3 RID: 6131 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700071E")]
	public int Support3InstanceID
	{
		[Token(Token = "0x60017F2")]
		[Address(RVA = "0x8104A0", Offset = "0x80EAA0", VA = "0x1808104A0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017F3")]
		[Address(RVA = "0x8BA550", Offset = "0x8B8B50", VA = "0x1808BA550")]
		set
		{
		}
	}

	// Token: 0x1700071F RID: 1823
	// (get) Token: 0x060017F4 RID: 6132 RVA: 0x00007B30 File Offset: 0x00005D30
	// (set) Token: 0x060017F5 RID: 6133 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700071F")]
	public int Support3Dir
	{
		[Token(Token = "0x60017F4")]
		[Address(RVA = "0x8BA5F0", Offset = "0x8B8BF0", VA = "0x1808BA5F0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017F5")]
		[Address(RVA = "0x8BA650", Offset = "0x8B8C50", VA = "0x1808BA650")]
		set
		{
		}
	}

	// Token: 0x17000720 RID: 1824
	// (get) Token: 0x060017F6 RID: 6134 RVA: 0x00007B48 File Offset: 0x00005D48
	// (set) Token: 0x060017F7 RID: 6135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000720")]
	public int Support4TypeID
	{
		[Token(Token = "0x60017F6")]
		[Address(RVA = "0x8BA700", Offset = "0x8B8D00", VA = "0x1808BA700")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017F7")]
		[Address(RVA = "0x8BA760", Offset = "0x8B8D60", VA = "0x1808BA760")]
		set
		{
		}
	}

	// Token: 0x17000721 RID: 1825
	// (get) Token: 0x060017F8 RID: 6136 RVA: 0x00007B60 File Offset: 0x00005D60
	// (set) Token: 0x060017F9 RID: 6137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000721")]
	public int Support4InstanceID
	{
		[Token(Token = "0x60017F8")]
		[Address(RVA = "0x816720", Offset = "0x814D20", VA = "0x180816720")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017F9")]
		[Address(RVA = "0x8BA810", Offset = "0x8B8E10", VA = "0x1808BA810")]
		set
		{
		}
	}

	// Token: 0x17000722 RID: 1826
	// (get) Token: 0x060017FA RID: 6138 RVA: 0x00007B78 File Offset: 0x00005D78
	// (set) Token: 0x060017FB RID: 6139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000722")]
	public int Support4Dir
	{
		[Token(Token = "0x60017FA")]
		[Address(RVA = "0x8109F0", Offset = "0x80EFF0", VA = "0x1808109F0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017FB")]
		[Address(RVA = "0x8BA8B0", Offset = "0x8B8EB0", VA = "0x1808BA8B0")]
		set
		{
		}
	}

	// Token: 0x17000723 RID: 1827
	// (get) Token: 0x060017FC RID: 6140 RVA: 0x00007B90 File Offset: 0x00005D90
	// (set) Token: 0x060017FD RID: 6141 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000723")]
	public bool IsInvalid
	{
		[Token(Token = "0x60017FC")]
		[Address(RVA = "0x834090", Offset = "0x832690", VA = "0x180834090")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60017FD")]
		[Address(RVA = "0x8BA960", Offset = "0x8B8F60", VA = "0x1808BA960")]
		set
		{
		}
	}

	// Token: 0x17000724 RID: 1828
	// (get) Token: 0x060017FE RID: 6142 RVA: 0x00007BA8 File Offset: 0x00005DA8
	// (set) Token: 0x060017FF RID: 6143 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000724")]
	public int PlaceActionNum
	{
		[Token(Token = "0x60017FE")]
		[Address(RVA = "0x8BAA00", Offset = "0x8B9000", VA = "0x1808BAA00")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017FF")]
		[Address(RVA = "0x8BAA60", Offset = "0x8B9060", VA = "0x1808BAA60")]
		set
		{
		}
	}

	// Token: 0x17000725 RID: 1829
	// (get) Token: 0x06001800 RID: 6144 RVA: 0x00007BC0 File Offset: 0x00005DC0
	// (set) Token: 0x06001801 RID: 6145 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000725")]
	public bool IsPlacing
	{
		[Token(Token = "0x6001800")]
		[Address(RVA = "0x810E20", Offset = "0x80F420", VA = "0x180810E20")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001801")]
		[Address(RVA = "0x8BAB00", Offset = "0x8B9100", VA = "0x1808BAB00")]
		set
		{
		}
	}

	// Token: 0x17000726 RID: 1830
	// (get) Token: 0x06001802 RID: 6146 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001803 RID: 6147 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000726")]
	public BoltEntity SendingPlayerEntity
	{
		[Token(Token = "0x6001802")]
		[Address(RVA = "0x8BABA0", Offset = "0x8B91A0", VA = "0x1808BABA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001803")]
		[Address(RVA = "0x8BAC40", Offset = "0x8B9240", VA = "0x1808BAC40")]
		set
		{
		}
	}

	// Token: 0x17000727 RID: 1831
	// (get) Token: 0x06001804 RID: 6148 RVA: 0x00007BD8 File Offset: 0x00005DD8
	// (set) Token: 0x06001805 RID: 6149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000727")]
	public int AnticipatedStructuresFlags
	{
		[Token(Token = "0x6001804")]
		[Address(RVA = "0x8BAE60", Offset = "0x8B9460", VA = "0x1808BAE60")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001805")]
		[Address(RVA = "0x8BAEC0", Offset = "0x8B94C0", VA = "0x1808BAEC0")]
		set
		{
		}
	}

	// Token: 0x17000728 RID: 1832
	// (get) Token: 0x06001806 RID: 6150 RVA: 0x00007BF0 File Offset: 0x00005DF0
	// (set) Token: 0x06001807 RID: 6151 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000728")]
	public Guid TreeID
	{
		[Token(Token = "0x6001806")]
		[Address(RVA = "0x8BAF70", Offset = "0x8B9570", VA = "0x1808BAF70")]
		get
		{
			return default(Guid);
		}
		[Token(Token = "0x6001807")]
		[Address(RVA = "0x8BAFE0", Offset = "0x8B95E0", VA = "0x1808BAFE0")]
		set
		{
		}
	}

	// Token: 0x06001808 RID: 6152 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001808")]
	[Address(RVA = "0x8BB080", Offset = "0x8B9680", VA = "0x1808BB080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001809 RID: 6153 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001809")]
	[Address(RVA = "0x8BC560", Offset = "0x8BAB60", VA = "0x1808BC560")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static FreeFormPlaceElement Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600180A RID: 6154 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600180A")]
	[Address(RVA = "0x8BC680", Offset = "0x8BAC80", VA = "0x1808BC680")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormPlaceElement Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600180B RID: 6155 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600180B")]
	[Address(RVA = "0x8BC690", Offset = "0x8BAC90", VA = "0x1808BC690")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormPlaceElement Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600180C RID: 6156 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600180C")]
	[Address(RVA = "0x8BC6A0", Offset = "0x8BACA0", VA = "0x1808BC6A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormPlaceElement Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600180D RID: 6157 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600180D")]
	[Address(RVA = "0x8BC6B0", Offset = "0x8BACB0", VA = "0x1808BC6B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormPlaceElement Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600180E RID: 6158 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600180E")]
	[Address(RVA = "0x8BC6D0", Offset = "0x8BACD0", VA = "0x1808BC6D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormPlaceElement Raise()
	{
		return null;
	}

	// Token: 0x0600180F RID: 6159 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600180F")]
	[Address(RVA = "0x8BC6F0", Offset = "0x8BACF0", VA = "0x1808BC6F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormPlaceElement Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001810 RID: 6160 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001810")]
	[Address(RVA = "0x8BC700", Offset = "0x8BAD00", VA = "0x1808BC700")]
	private static FreeFormPlaceElement Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001811 RID: 6161 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001811")]
	[Address(RVA = "0x8BC680", Offset = "0x8BAC80", VA = "0x1808BC680")]
	public static FreeFormPlaceElement Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001812 RID: 6162 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001812")]
	[Address(RVA = "0x8BC690", Offset = "0x8BAC90", VA = "0x1808BC690")]
	public static FreeFormPlaceElement Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001813 RID: 6163 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001813")]
	[Address(RVA = "0x8BC6A0", Offset = "0x8BACA0", VA = "0x1808BC6A0")]
	public static FreeFormPlaceElement Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001814 RID: 6164 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001814")]
	[Address(RVA = "0x8BC6B0", Offset = "0x8BACB0", VA = "0x1808BC6B0")]
	public static FreeFormPlaceElement Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001815 RID: 6165 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001815")]
	[Address(RVA = "0x8BC6D0", Offset = "0x8BACD0", VA = "0x1808BC6D0")]
	public static FreeFormPlaceElement Create()
	{
		return null;
	}

	// Token: 0x06001816 RID: 6166 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001816")]
	[Address(RVA = "0x8BC6F0", Offset = "0x8BACF0", VA = "0x1808BC6F0")]
	public static FreeFormPlaceElement Create(ReliabilityModes reliability)
	{
		return null;
	}
}
