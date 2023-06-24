using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000034 RID: 52
[Token(Token = "0x2000034")]
internal class GardenPlotStructureState : NetworkState, IGardenPlotStructureState, IScrewStructureWithStorageState, IScrewStructureState, IState, IDisposable
{
	// Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600011B")]
	[Address(RVA = "0x7BFC20", Offset = "0x7BE220", VA = "0x1807BFC20")]
	public GardenPlotStructureState()
	{
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x0600011C RID: 284 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000077")]
	public NetworkTransform Transform
	{
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x7BACE0", Offset = "0x7B92E0", VA = "0x1807BACE0", Slot = "46")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x0600011D RID: 285 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000078")]
	public BoltEntity TranslationController
	{
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x7BEA80", Offset = "0x7BD080", VA = "0x1807BEA80", Slot = "47")]
		get
		{
			return null;
		}
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x7BFC80", Offset = "0x7BE280", VA = "0x1807BFC80", Slot = "48")]
		set
		{
		}
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x0600011F RID: 287 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000079")]
	public NetworkArray_Objects<StoredItemsData> StorageSlots
	{
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x7BFEE0", Offset = "0x7BE4E0", VA = "0x1807BFEE0", Slot = "44")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x06000120 RID: 288 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700007A")]
	public NetworkArray_Integer SlotAvailability
	{
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x7BFFA0", Offset = "0x7BE5A0", VA = "0x1807BFFA0", Slot = "45")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700007B RID: 123
	// (get) Token: 0x06000121 RID: 289 RVA: 0x00002688 File Offset: 0x00000888
	// (set) Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700007B")]
	public bool IsBusy
	{
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x7C0060", Offset = "0x7BE660", VA = "0x1807C0060", Slot = "31")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x7C00C0", Offset = "0x7BE6C0", VA = "0x1807C00C0", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x06000123 RID: 291 RVA: 0x000026A0 File Offset: 0x000008A0
	// (set) Token: 0x06000124 RID: 292 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700007C")]
	public bool HasPlant
	{
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x7C01B0", Offset = "0x7BE7B0", VA = "0x1807C01B0", Slot = "33")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x7C0210", Offset = "0x7BE810", VA = "0x1807C0210", Slot = "34")]
		set
		{
		}
	}

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x06000125 RID: 293 RVA: 0x000026B8 File Offset: 0x000008B8
	// (set) Token: 0x06000126 RID: 294 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700007D")]
	public bool IsGrowing
	{
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x7C0300", Offset = "0x7BE900", VA = "0x1807C0300", Slot = "35")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x7C0360", Offset = "0x7BE960", VA = "0x1807C0360", Slot = "36")]
		set
		{
		}
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x06000127 RID: 295 RVA: 0x000026D0 File Offset: 0x000008D0
	// (set) Token: 0x06000128 RID: 296 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700007E")]
	public int SeedId
	{
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x7C0450", Offset = "0x7BEA50", VA = "0x1807C0450", Slot = "37")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x7C04B0", Offset = "0x7BEAB0", VA = "0x1807C04B0", Slot = "38")]
		set
		{
		}
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x06000129 RID: 297 RVA: 0x000026E8 File Offset: 0x000008E8
	// (set) Token: 0x0600012A RID: 298 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700007F")]
	public int HarvestType
	{
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x7C05B0", Offset = "0x7BEBB0", VA = "0x1807C05B0", Slot = "39")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x7C0610", Offset = "0x7BEC10", VA = "0x1807C0610", Slot = "40")]
		set
		{
		}
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x0600012B RID: 299 RVA: 0x00002700 File Offset: 0x00000900
	// (set) Token: 0x0600012C RID: 300 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000080")]
	public float PlantGrowTimeRemaining
	{
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x7C0710", Offset = "0x7BED10", VA = "0x1807C0710", Slot = "41")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x7C0770", Offset = "0x7BED70", VA = "0x1807C0770", Slot = "42")]
		set
		{
		}
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x0600012D RID: 301 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000081")]
	public NetworkArray_Float ProduceGrowTimeRemaining
	{
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x7C0870", Offset = "0x7BEE70", VA = "0x1807C0870", Slot = "43")]
		get
		{
			return null;
		}
	}
}
