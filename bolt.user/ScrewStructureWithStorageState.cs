using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000031 RID: 49
[Token(Token = "0x2000031")]
internal class ScrewStructureWithStorageState : NetworkState, IScrewStructureWithStorageState, IScrewStructureState, IState, IDisposable
{
	// Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000100")]
	[Address(RVA = "0x7BEA20", Offset = "0x7BD020", VA = "0x1807BEA20")]
	public ScrewStructureWithStorageState()
	{
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x06000101 RID: 257 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000069")]
	public NetworkTransform Transform
	{
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x7BACE0", Offset = "0x7B92E0", VA = "0x1807BACE0", Slot = "33")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x06000102 RID: 258 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700006A")]
	public BoltEntity TranslationController
	{
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x7BEA80", Offset = "0x7BD080", VA = "0x1807BEA80", Slot = "34")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x7BEB20", Offset = "0x7BD120", VA = "0x1807BEB20", Slot = "35")]
		set
		{
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x06000104 RID: 260 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700006B")]
	public NetworkArray_Objects<StoredItemsData> StorageSlots
	{
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x7BED80", Offset = "0x7BD380", VA = "0x1807BED80", Slot = "31")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x06000105 RID: 261 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700006C")]
	public NetworkArray_Integer SlotAvailability
	{
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x7BEE40", Offset = "0x7BD440", VA = "0x1807BEE40", Slot = "32")]
		get
		{
			return null;
		}
	}
}
