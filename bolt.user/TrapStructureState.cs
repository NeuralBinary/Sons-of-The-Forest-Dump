using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000A0 RID: 160
[Token(Token = "0x20000A0")]
internal class TrapStructureState : NetworkState, ITrapStructureState, IScrewStructureWithStorageState, IScrewStructureState, IState, IDisposable
{
	// Token: 0x060006CE RID: 1742 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006CE")]
	[Address(RVA = "0x827480", Offset = "0x825A80", VA = "0x180827480")]
	public TrapStructureState()
	{
	}

	// Token: 0x170003C9 RID: 969
	// (get) Token: 0x060006CF RID: 1743 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170003C9")]
	public NetworkTransform Transform
	{
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x7BACE0", Offset = "0x7B92E0", VA = "0x1807BACE0", Slot = "37")]
		get
		{
			return null;
		}
	}

	// Token: 0x170003CA RID: 970
	// (get) Token: 0x060006D0 RID: 1744 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060006D1 RID: 1745 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003CA")]
	public BoltEntity TranslationController
	{
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x7BEA80", Offset = "0x7BD080", VA = "0x1807BEA80", Slot = "38")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x8274E0", Offset = "0x825AE0", VA = "0x1808274E0", Slot = "39")]
		set
		{
		}
	}

	// Token: 0x170003CB RID: 971
	// (get) Token: 0x060006D2 RID: 1746 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170003CB")]
	public NetworkArray_Objects<StoredItemsData> StorageSlots
	{
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x827740", Offset = "0x825D40", VA = "0x180827740", Slot = "35")]
		get
		{
			return null;
		}
	}

	// Token: 0x170003CC RID: 972
	// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170003CC")]
	public NetworkArray_Integer SlotAvailability
	{
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x827800", Offset = "0x825E00", VA = "0x180827800", Slot = "36")]
		get
		{
			return null;
		}
	}

	// Token: 0x170003CD RID: 973
	// (get) Token: 0x060006D4 RID: 1748 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060006D5 RID: 1749 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003CD")]
	public BoltEntity Target
	{
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x8278C0", Offset = "0x825EC0", VA = "0x1808278C0", Slot = "31")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x827960", Offset = "0x825F60", VA = "0x180827960", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x170003CE RID: 974
	// (get) Token: 0x060006D6 RID: 1750 RVA: 0x000048A8 File Offset: 0x00002AA8
	// (set) Token: 0x060006D7 RID: 1751 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003CE")]
	public bool IsDisarmed
	{
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x7C01B0", Offset = "0x7BE7B0", VA = "0x1807C01B0", Slot = "33")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x7C0210", Offset = "0x7BE810", VA = "0x1807C0210", Slot = "34")]
		set
		{
		}
	}
}
