using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A3 RID: 163
[Token(Token = "0x20000A3")]
internal class RobbyActorState : NetworkState, IRobbyActorState, IMecanimVailActorState, IWorldCharacter, IState, IDisposable
{
	// Token: 0x060006E7 RID: 1767 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006E7")]
	[Address(RVA = "0x828B00", Offset = "0x827100", VA = "0x180828B00")]
	public RobbyActorState()
	{
	}

	// Token: 0x170003D6 RID: 982
	// (get) Token: 0x060006E8 RID: 1768 RVA: 0x000048F0 File Offset: 0x00002AF0
	// (set) Token: 0x060006E9 RID: 1769 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003D6")]
	public float CharacterScale
	{
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x7C3C70", Offset = "0x7C2270", VA = "0x1807C3C70", Slot = "85")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x7C3CD0", Offset = "0x7C22D0", VA = "0x1807C3CD0", Slot = "86")]
		set
		{
		}
	}

	// Token: 0x170003D7 RID: 983
	// (get) Token: 0x060006EA RID: 1770 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170003D7")]
	public NetworkArray_Integer MecanimLayerHashes
	{
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x828B60", Offset = "0x827160", VA = "0x180828B60", Slot = "87")]
		get
		{
			return null;
		}
	}

	// Token: 0x170003D8 RID: 984
	// (get) Token: 0x060006EB RID: 1771 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170003D8")]
	public NetworkArray_Float MecanimLayerWeights
	{
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x828C20", Offset = "0x827220", VA = "0x180828C20", Slot = "88")]
		get
		{
			return null;
		}
	}

	// Token: 0x170003D9 RID: 985
	// (get) Token: 0x060006EC RID: 1772 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170003D9")]
	public NetworkArray_Float MecanimLayerTimes
	{
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x828CE0", Offset = "0x8272E0", VA = "0x180828CE0", Slot = "89")]
		get
		{
			return null;
		}
	}

	// Token: 0x170003DA RID: 986
	// (get) Token: 0x060006ED RID: 1773 RVA: 0x00004908 File Offset: 0x00002B08
	// (set) Token: 0x060006EE RID: 1774 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003DA")]
	public float MecanimSpeed
	{
		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x7C3FF0", Offset = "0x7C25F0", VA = "0x1807C3FF0", Slot = "90")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x7C4050", Offset = "0x7C2650", VA = "0x1807C4050", Slot = "91")]
		set
		{
		}
	}

	// Token: 0x170003DB RID: 987
	// (get) Token: 0x060006EF RID: 1775 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170003DB")]
	public NetworkTransform Transform
	{
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x810030", Offset = "0x80E630", VA = "0x180810030", Slot = "38")]
		get
		{
			return null;
		}
	}

	// Token: 0x170003DC RID: 988
	// (get) Token: 0x060006F0 RID: 1776 RVA: 0x00004920 File Offset: 0x00002B20
	// (set) Token: 0x060006F1 RID: 1777 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003DC")]
	public int BloodMask
	{
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x810090", Offset = "0x80E690", VA = "0x180810090", Slot = "39")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x8100F0", Offset = "0x80E6F0", VA = "0x1808100F0", Slot = "40")]
		set
		{
		}
	}

	// Token: 0x170003DD RID: 989
	// (get) Token: 0x060006F2 RID: 1778 RVA: 0x00004938 File Offset: 0x00002B38
	// (set) Token: 0x060006F3 RID: 1779 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003DD")]
	public int VailState
	{
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x8101F0", Offset = "0x80E7F0", VA = "0x1808101F0", Slot = "41")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x810250", Offset = "0x80E850", VA = "0x180810250", Slot = "42")]
		set
		{
		}
	}

	// Token: 0x170003DE RID: 990
	// (get) Token: 0x060006F4 RID: 1780 RVA: 0x00004950 File Offset: 0x00002B50
	// (set) Token: 0x060006F5 RID: 1781 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003DE")]
	public int VariationSeed
	{
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x810350", Offset = "0x80E950", VA = "0x180810350", Slot = "43")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x8103B0", Offset = "0x80E9B0", VA = "0x1808103B0", Slot = "44")]
		set
		{
		}
	}

	// Token: 0x170003DF RID: 991
	// (get) Token: 0x060006F6 RID: 1782 RVA: 0x00004968 File Offset: 0x00002B68
	// (set) Token: 0x060006F7 RID: 1783 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003DF")]
	public int Ragdoll
	{
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x8104A0", Offset = "0x80EAA0", VA = "0x1808104A0", Slot = "45")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x810500", Offset = "0x80EB00", VA = "0x180810500", Slot = "46")]
		set
		{
		}
	}

	// Token: 0x170003E0 RID: 992
	// (get) Token: 0x060006F8 RID: 1784 RVA: 0x00004980 File Offset: 0x00002B80
	// (set) Token: 0x060006F9 RID: 1785 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003E0")]
	public float Direction
	{
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x810600", Offset = "0x80EC00", VA = "0x180810600", Slot = "47")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x810660", Offset = "0x80EC60", VA = "0x180810660", Slot = "48")]
		set
		{
		}
	}

	// Token: 0x170003E1 RID: 993
	// (get) Token: 0x060006FA RID: 1786 RVA: 0x00004998 File Offset: 0x00002B98
	// (set) Token: 0x060006FB RID: 1787 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003E1")]
	public float DirectionX
	{
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x810770", Offset = "0x80ED70", VA = "0x180810770", Slot = "49")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x8107D0", Offset = "0x80EDD0", VA = "0x1808107D0", Slot = "50")]
		set
		{
		}
	}

	// Token: 0x170003E2 RID: 994
	// (get) Token: 0x060006FC RID: 1788 RVA: 0x000049B0 File Offset: 0x00002BB0
	// (set) Token: 0x060006FD RID: 1789 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003E2")]
	public float DirectionZ
	{
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x7D6420", Offset = "0x7D4A20", VA = "0x1807D6420", Slot = "51")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x8108E0", Offset = "0x80EEE0", VA = "0x1808108E0", Slot = "52")]
		set
		{
		}
	}

	// Token: 0x170003E3 RID: 995
	// (get) Token: 0x060006FE RID: 1790 RVA: 0x000049C8 File Offset: 0x00002BC8
	// (set) Token: 0x060006FF RID: 1791 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003E3")]
	public int OutfitId
	{
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x8109F0", Offset = "0x80EFF0", VA = "0x1808109F0", Slot = "53")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x810A50", Offset = "0x80F050", VA = "0x180810A50", Slot = "54")]
		set
		{
		}
	}

	// Token: 0x170003E4 RID: 996
	// (get) Token: 0x06000700 RID: 1792 RVA: 0x000049E0 File Offset: 0x00002BE0
	// (set) Token: 0x06000701 RID: 1793 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003E4")]
	public int DismemberMask
	{
		[Token(Token = "0x6000700")]
		[Address(RVA = "0x810B50", Offset = "0x80F150", VA = "0x180810B50", Slot = "55")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000701")]
		[Address(RVA = "0x810BB0", Offset = "0x80F1B0", VA = "0x180810BB0", Slot = "56")]
		set
		{
		}
	}

	// Token: 0x170003E5 RID: 997
	// (get) Token: 0x06000702 RID: 1794 RVA: 0x000049F8 File Offset: 0x00002BF8
	// (set) Token: 0x06000703 RID: 1795 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003E5")]
	public float ArmorLevel
	{
		[Token(Token = "0x6000702")]
		[Address(RVA = "0x810CB0", Offset = "0x80F2B0", VA = "0x180810CB0", Slot = "57")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000703")]
		[Address(RVA = "0x810D10", Offset = "0x80F310", VA = "0x180810D10", Slot = "58")]
		set
		{
		}
	}

	// Token: 0x170003E6 RID: 998
	// (get) Token: 0x06000704 RID: 1796 RVA: 0x00004A10 File Offset: 0x00002C10
	// (set) Token: 0x06000705 RID: 1797 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003E6")]
	public bool Burning
	{
		[Token(Token = "0x6000704")]
		[Address(RVA = "0x810E20", Offset = "0x80F420", VA = "0x180810E20", Slot = "59")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000705")]
		[Address(RVA = "0x810E80", Offset = "0x80F480", VA = "0x180810E80", Slot = "60")]
		set
		{
		}
	}

	// Token: 0x170003E7 RID: 999
	// (get) Token: 0x06000706 RID: 1798 RVA: 0x00004A28 File Offset: 0x00002C28
	// (set) Token: 0x06000707 RID: 1799 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003E7")]
	public bool InCave
	{
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x810F70", Offset = "0x80F570", VA = "0x180810F70", Slot = "61")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x810FD0", Offset = "0x80F5D0", VA = "0x180810FD0", Slot = "62")]
		set
		{
		}
	}

	// Token: 0x170003E8 RID: 1000
	// (get) Token: 0x06000708 RID: 1800 RVA: 0x00004A40 File Offset: 0x00002C40
	// (set) Token: 0x06000709 RID: 1801 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003E8")]
	public Vector3 RagdollPosition
	{
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x8110C0", Offset = "0x80F6C0", VA = "0x1808110C0", Slot = "63")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x811140", Offset = "0x80F740", VA = "0x180811140", Slot = "64")]
		set
		{
		}
	}

	// Token: 0x170003E9 RID: 1001
	// (get) Token: 0x0600070A RID: 1802 RVA: 0x00004A58 File Offset: 0x00002C58
	// (set) Token: 0x0600070B RID: 1803 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003E9")]
	public int VariationSubSet
	{
		[Token(Token = "0x600070A")]
		[Address(RVA = "0x8112F0", Offset = "0x80F8F0", VA = "0x1808112F0", Slot = "65")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x811350", Offset = "0x80F950", VA = "0x180811350", Slot = "66")]
		set
		{
		}
	}

	// Token: 0x170003EA RID: 1002
	// (get) Token: 0x0600070C RID: 1804 RVA: 0x00004A70 File Offset: 0x00002C70
	// (set) Token: 0x0600070D RID: 1805 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003EA")]
	public bool Skinned
	{
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x811450", Offset = "0x80FA50", VA = "0x180811450", Slot = "67")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600070D")]
		[Address(RVA = "0x8114B0", Offset = "0x80FAB0", VA = "0x1808114B0", Slot = "68")]
		set
		{
		}
	}

	// Token: 0x170003EB RID: 1003
	// (get) Token: 0x0600070E RID: 1806 RVA: 0x00004A88 File Offset: 0x00002C88
	// (set) Token: 0x0600070F RID: 1807 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003EB")]
	public int Expression
	{
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x8115A0", Offset = "0x80FBA0", VA = "0x1808115A0", Slot = "69")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x811600", Offset = "0x80FC00", VA = "0x180811600", Slot = "70")]
		set
		{
		}
	}

	// Token: 0x170003EC RID: 1004
	// (get) Token: 0x06000710 RID: 1808 RVA: 0x00004AA0 File Offset: 0x00002CA0
	// (set) Token: 0x06000711 RID: 1809 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003EC")]
	public int EquippedMask
	{
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x811700", Offset = "0x80FD00", VA = "0x180811700", Slot = "71")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x811760", Offset = "0x80FD60", VA = "0x180811760", Slot = "72")]
		set
		{
		}
	}

	// Token: 0x170003ED RID: 1005
	// (get) Token: 0x06000712 RID: 1810 RVA: 0x00004AB8 File Offset: 0x00002CB8
	// (set) Token: 0x06000713 RID: 1811 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003ED")]
	public int ItemCarryTypeCount
	{
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x811850", Offset = "0x80FE50", VA = "0x180811850", Slot = "73")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x8118B0", Offset = "0x80FEB0", VA = "0x1808118B0", Slot = "74")]
		set
		{
		}
	}

	// Token: 0x170003EE RID: 1006
	// (get) Token: 0x06000714 RID: 1812 RVA: 0x00004AD0 File Offset: 0x00002CD0
	// (set) Token: 0x06000715 RID: 1813 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003EE")]
	public int PlayerSentimentLevel
	{
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x8119A0", Offset = "0x80FFA0", VA = "0x1808119A0", Slot = "75")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x811A00", Offset = "0x810000", VA = "0x180811A00", Slot = "76")]
		set
		{
		}
	}

	// Token: 0x170003EF RID: 1007
	// (get) Token: 0x06000716 RID: 1814 RVA: 0x00004AE8 File Offset: 0x00002CE8
	// (set) Token: 0x06000717 RID: 1815 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003EF")]
	public bool BodyBurning
	{
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x811B00", Offset = "0x810100", VA = "0x180811B00", Slot = "77")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x811B60", Offset = "0x810160", VA = "0x180811B60", Slot = "78")]
		set
		{
		}
	}

	// Token: 0x170003F0 RID: 1008
	// (get) Token: 0x06000718 RID: 1816 RVA: 0x00004B00 File Offset: 0x00002D00
	// (set) Token: 0x06000719 RID: 1817 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003F0")]
	public int GpsLocatorId
	{
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x811C50", Offset = "0x810250", VA = "0x180811C50", Slot = "79")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x811CB0", Offset = "0x8102B0", VA = "0x180811CB0", Slot = "80")]
		set
		{
		}
	}

	// Token: 0x170003F1 RID: 1009
	// (get) Token: 0x0600071A RID: 1818 RVA: 0x00004B18 File Offset: 0x00002D18
	// (set) Token: 0x0600071B RID: 1819 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003F1")]
	public float Wetness
	{
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x811DB0", Offset = "0x8103B0", VA = "0x180811DB0", Slot = "81")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x811E10", Offset = "0x810410", VA = "0x180811E10", Slot = "82")]
		set
		{
		}
	}

	// Token: 0x170003F2 RID: 1010
	// (get) Token: 0x0600071C RID: 1820 RVA: 0x00004B30 File Offset: 0x00002D30
	// (set) Token: 0x0600071D RID: 1821 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003F2")]
	public bool HelicopterHeld
	{
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x811F20", Offset = "0x810520", VA = "0x180811F20", Slot = "83")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x811F80", Offset = "0x810580", VA = "0x180811F80", Slot = "84")]
		set
		{
		}
	}

	// Token: 0x170003F3 RID: 1011
	// (get) Token: 0x0600071E RID: 1822 RVA: 0x00004B48 File Offset: 0x00002D48
	// (set) Token: 0x0600071F RID: 1823 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003F3")]
	public int Injured
	{
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x828DA0", Offset = "0x8273A0", VA = "0x180828DA0", Slot = "31")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x828E00", Offset = "0x827400", VA = "0x180828E00", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x170003F4 RID: 1012
	// (get) Token: 0x06000720 RID: 1824 RVA: 0x00004B60 File Offset: 0x00002D60
	// (set) Token: 0x06000721 RID: 1825 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003F4")]
	public bool ShowAxe
	{
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x816B40", Offset = "0x815140", VA = "0x180816B40", Slot = "33")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x828F00", Offset = "0x827500", VA = "0x180828F00", Slot = "34")]
		set
		{
		}
	}

	// Token: 0x170003F5 RID: 1013
	// (get) Token: 0x06000722 RID: 1826 RVA: 0x00004B78 File Offset: 0x00002D78
	// (set) Token: 0x06000723 RID: 1827 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003F5")]
	public int Race
	{
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x828FF0", Offset = "0x8275F0", VA = "0x180828FF0", Slot = "35")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x829050", Offset = "0x827650", VA = "0x180829050", Slot = "36")]
		set
		{
		}
	}

	// Token: 0x170003F6 RID: 1014
	// (get) Token: 0x06000724 RID: 1828 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170003F6")]
	public NetworkArray_Integer ClothingIds
	{
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x829150", Offset = "0x827750", VA = "0x180829150", Slot = "37")]
		get
		{
			return null;
		}
	}
}
