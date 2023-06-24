using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000124 RID: 292
[Token(Token = "0x2000124")]
internal class TripWire_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000D7E RID: 3454 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D7E")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public TripWire_Meta()
	{
	}

	// Token: 0x1700055E RID: 1374
	// (get) Token: 0x06000D7F RID: 3455 RVA: 0x00005F70 File Offset: 0x00004170
	[Token(Token = "0x1700055E")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000D7F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700055F RID: 1375
	// (get) Token: 0x06000D80 RID: 3456 RVA: 0x00005F88 File Offset: 0x00004188
	[Token(Token = "0x1700055F")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000D80")]
		[Address(RVA = "0x864CD0", Offset = "0x8632D0", VA = "0x180864CD0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000560 RID: 1376
	// (get) Token: 0x06000D81 RID: 3457 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000560")]
	private Type TypeObject
	{
		[Token(Token = "0x6000D81")]
		[Address(RVA = "0x864CF0", Offset = "0x8632F0", VA = "0x180864CF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000D82 RID: 3458 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D82")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000D83 RID: 3459 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D83")]
	[Address(RVA = "0x864D90", Offset = "0x863390", VA = "0x180864D90", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000D84 RID: 3460 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D84")]
	[Address(RVA = "0x864F80", Offset = "0x863580", VA = "0x180864F80", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000D85 RID: 3461 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D85")]
	[Address(RVA = "0x865010", Offset = "0x863610", VA = "0x180865010", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000284 RID: 644
	[Token(Token = "0x4000284")]
	[FieldOffset(Offset = "0x0")]
	internal static TripWire_Meta Instance;
}
