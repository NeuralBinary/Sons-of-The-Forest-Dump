using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200009A RID: 154
[Token(Token = "0x200009A")]
internal class RainCatcherStructureState : NetworkState, IRainCatcherStructureState, IScrewStructureWithStorageState, IScrewStructureState, IState, IDisposable
{
	// Token: 0x0600069E RID: 1694 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600069E")]
	[Address(RVA = "0x8251A0", Offset = "0x8237A0", VA = "0x1808251A0")]
	public RainCatcherStructureState()
	{
	}

	// Token: 0x170003B2 RID: 946
	// (get) Token: 0x0600069F RID: 1695 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170003B2")]
	public NetworkTransform Transform
	{
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x7BACE0", Offset = "0x7B92E0", VA = "0x1807BACE0", Slot = "37")]
		get
		{
			return null;
		}
	}

	// Token: 0x170003B3 RID: 947
	// (get) Token: 0x060006A0 RID: 1696 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060006A1 RID: 1697 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003B3")]
	public BoltEntity TranslationController
	{
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x7BEA80", Offset = "0x7BD080", VA = "0x1807BEA80", Slot = "38")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x825200", Offset = "0x823800", VA = "0x180825200", Slot = "39")]
		set
		{
		}
	}

	// Token: 0x170003B4 RID: 948
	// (get) Token: 0x060006A2 RID: 1698 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170003B4")]
	public NetworkArray_Objects<StoredItemsData> StorageSlots
	{
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x825460", Offset = "0x823A60", VA = "0x180825460", Slot = "35")]
		get
		{
			return null;
		}
	}

	// Token: 0x170003B5 RID: 949
	// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170003B5")]
	public NetworkArray_Integer SlotAvailability
	{
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x825520", Offset = "0x823B20", VA = "0x180825520", Slot = "36")]
		get
		{
			return null;
		}
	}

	// Token: 0x170003B6 RID: 950
	// (get) Token: 0x060006A4 RID: 1700 RVA: 0x000047B8 File Offset: 0x000029B8
	// (set) Token: 0x060006A5 RID: 1701 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003B6")]
	public float CurrentVolume
	{
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x8255E0", Offset = "0x823BE0", VA = "0x1808255E0", Slot = "31")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x825640", Offset = "0x823C40", VA = "0x180825640", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x170003B7 RID: 951
	// (get) Token: 0x060006A6 RID: 1702 RVA: 0x000047D0 File Offset: 0x000029D0
	// (set) Token: 0x060006A7 RID: 1703 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003B7")]
	public bool IsFrozen
	{
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x7C01B0", Offset = "0x7BE7B0", VA = "0x1807C01B0", Slot = "33")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x7C0210", Offset = "0x7BE810", VA = "0x1807C0210", Slot = "34")]
		set
		{
		}
	}
}
