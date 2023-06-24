using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000B2 RID: 178
[Token(Token = "0x20000B2")]
internal class FireState : NetworkState, IFireState, IFreeFormStructureState, IState, IDisposable
{
	// Token: 0x0600080B RID: 2059 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600080B")]
	[Address(RVA = "0x8339B0", Offset = "0x831FB0", VA = "0x1808339B0")]
	public FireState()
	{
	}

	// Token: 0x1700046A RID: 1130
	// (get) Token: 0x0600080C RID: 2060 RVA: 0x00004FC8 File Offset: 0x000031C8
	// (set) Token: 0x0600080D RID: 2061 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700046A")]
	public int TypeID
	{
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360", Slot = "52")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600080D")]
		[Address(RVA = "0x808FF0", Offset = "0x8075F0", VA = "0x180808FF0", Slot = "53")]
		set
		{
		}
	}

	// Token: 0x1700046B RID: 1131
	// (get) Token: 0x0600080E RID: 2062 RVA: 0x00004FE0 File Offset: 0x000031E0
	// (set) Token: 0x0600080F RID: 2063 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700046B")]
	public int InstanceID
	{
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50", Slot = "54")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x7B4BB0", Offset = "0x7B31B0", VA = "0x1807B4BB0", Slot = "55")]
		set
		{
		}
	}

	// Token: 0x1700046C RID: 1132
	// (get) Token: 0x06000810 RID: 2064 RVA: 0x00004FF8 File Offset: 0x000031F8
	// (set) Token: 0x06000811 RID: 2065 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700046C")]
	public bool Lit
	{
		[Token(Token = "0x6000810")]
		[Address(RVA = "0x7B8B00", Offset = "0x7B7100", VA = "0x1807B8B00", Slot = "31")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000811")]
		[Address(RVA = "0x7B8B60", Offset = "0x7B7160", VA = "0x1807B8B60", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x1700046D RID: 1133
	// (get) Token: 0x06000812 RID: 2066 RVA: 0x00005010 File Offset: 0x00003210
	// (set) Token: 0x06000813 RID: 2067 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700046D")]
	public float Fuel
	{
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x7C2150", Offset = "0x7C0750", VA = "0x1807C2150", Slot = "33")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x833A10", Offset = "0x832010", VA = "0x180833A10", Slot = "34")]
		set
		{
		}
	}

	// Token: 0x1700046E RID: 1134
	// (get) Token: 0x06000814 RID: 2068 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000815 RID: 2069 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700046E")]
	public Action OnFuelAdded
	{
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x833B20", Offset = "0x832120", VA = "0x180833B20", Slot = "35")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x833BC0", Offset = "0x8321C0", VA = "0x180833BC0", Slot = "36")]
		set
		{
		}
	}

	// Token: 0x1700046F RID: 1135
	// (get) Token: 0x06000816 RID: 2070 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700046F")]
	public StoredItemsData CookingStorage
	{
		[Token(Token = "0x6000816")]
		[Address(RVA = "0x833C70", Offset = "0x832270", VA = "0x180833C70", Slot = "37")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000470 RID: 1136
	// (get) Token: 0x06000817 RID: 2071 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000470")]
	public NetworkArray_Integer SlotAvailability
	{
		[Token(Token = "0x6000817")]
		[Address(RVA = "0x833D30", Offset = "0x832330", VA = "0x180833D30", Slot = "38")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000471 RID: 1137
	// (get) Token: 0x06000818 RID: 2072 RVA: 0x00005028 File Offset: 0x00003228
	// (set) Token: 0x06000819 RID: 2073 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000471")]
	public bool HasCookingPot
	{
		[Token(Token = "0x6000818")]
		[Address(RVA = "0x833DF0", Offset = "0x8323F0", VA = "0x180833DF0", Slot = "39")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000819")]
		[Address(RVA = "0x833E50", Offset = "0x832450", VA = "0x180833E50", Slot = "40")]
		set
		{
		}
	}

	// Token: 0x17000472 RID: 1138
	// (get) Token: 0x0600081A RID: 2074 RVA: 0x00005040 File Offset: 0x00003240
	// (set) Token: 0x0600081B RID: 2075 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000472")]
	public bool IsCooking
	{
		[Token(Token = "0x600081A")]
		[Address(RVA = "0x833F40", Offset = "0x832540", VA = "0x180833F40", Slot = "41")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600081B")]
		[Address(RVA = "0x833FA0", Offset = "0x8325A0", VA = "0x180833FA0", Slot = "42")]
		set
		{
		}
	}

	// Token: 0x17000473 RID: 1139
	// (get) Token: 0x0600081C RID: 2076 RVA: 0x00005058 File Offset: 0x00003258
	// (set) Token: 0x0600081D RID: 2077 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000473")]
	public bool IsDoneCooking
	{
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x834090", Offset = "0x832690", VA = "0x180834090", Slot = "43")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x8340F0", Offset = "0x8326F0", VA = "0x1808340F0", Slot = "44")]
		set
		{
		}
	}

	// Token: 0x17000474 RID: 1140
	// (get) Token: 0x0600081E RID: 2078 RVA: 0x00005070 File Offset: 0x00003270
	// (set) Token: 0x0600081F RID: 2079 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000474")]
	public bool IsBusy
	{
		[Token(Token = "0x600081E")]
		[Address(RVA = "0x8341E0", Offset = "0x8327E0", VA = "0x1808341E0", Slot = "45")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600081F")]
		[Address(RVA = "0x834240", Offset = "0x832840", VA = "0x180834240", Slot = "46")]
		set
		{
		}
	}

	// Token: 0x17000475 RID: 1141
	// (get) Token: 0x06000820 RID: 2080 RVA: 0x00005088 File Offset: 0x00003288
	// (set) Token: 0x06000821 RID: 2081 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000475")]
	public int RecipeId
	{
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x834330", Offset = "0x832930", VA = "0x180834330", Slot = "47")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x834390", Offset = "0x832990", VA = "0x180834390", Slot = "48")]
		set
		{
		}
	}

	// Token: 0x17000476 RID: 1142
	// (get) Token: 0x06000822 RID: 2082 RVA: 0x000050A0 File Offset: 0x000032A0
	// (set) Token: 0x06000823 RID: 2083 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000476")]
	public float CurrentLiquidVolume
	{
		[Token(Token = "0x6000822")]
		[Address(RVA = "0x8167E0", Offset = "0x814DE0", VA = "0x1808167E0", Slot = "49")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x834480", Offset = "0x832A80", VA = "0x180834480", Slot = "50")]
		set
		{
		}
	}

	// Token: 0x06000824 RID: 2084 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000824")]
	[Address(RVA = "0x834590", Offset = "0x832B90", VA = "0x180834590", Slot = "51")]
	public void FuelAdded()
	{
	}
}
