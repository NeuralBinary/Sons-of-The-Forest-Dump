using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000160 RID: 352
[Token(Token = "0x2000160")]
internal class PickupRequest_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x0600102C RID: 4140 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600102C")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public PickupRequest_Meta()
	{
	}

	// Token: 0x170005C5 RID: 1477
	// (get) Token: 0x0600102D RID: 4141 RVA: 0x00006528 File Offset: 0x00004728
	[Token(Token = "0x170005C5")]
	private TypeId TypeId
	{
		[Token(Token = "0x600102D")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170005C6 RID: 1478
	// (get) Token: 0x0600102E RID: 4142 RVA: 0x00006540 File Offset: 0x00004740
	[Token(Token = "0x170005C6")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600102E")]
		[Address(RVA = "0x87B220", Offset = "0x879820", VA = "0x18087B220", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170005C7 RID: 1479
	// (get) Token: 0x0600102F RID: 4143 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170005C7")]
	private Type TypeObject
	{
		[Token(Token = "0x600102F")]
		[Address(RVA = "0x87B240", Offset = "0x879840", VA = "0x18087B240", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001030 RID: 4144 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001030")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001031 RID: 4145 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001031")]
	[Address(RVA = "0x87B2E0", Offset = "0x8798E0", VA = "0x18087B2E0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001032 RID: 4146 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001032")]
	[Address(RVA = "0x87B5D0", Offset = "0x879BD0", VA = "0x18087B5D0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001033 RID: 4147 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001033")]
	[Address(RVA = "0x87B660", Offset = "0x879C60", VA = "0x18087B660", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000298 RID: 664
	[Token(Token = "0x4000298")]
	[FieldOffset(Offset = "0x0")]
	internal static PickupRequest_Meta Instance;
}
