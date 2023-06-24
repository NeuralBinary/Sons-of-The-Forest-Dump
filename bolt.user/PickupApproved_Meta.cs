using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000163 RID: 355
[Token(Token = "0x2000163")]
internal class PickupApproved_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x0600104E RID: 4174 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600104E")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public PickupApproved_Meta()
	{
	}

	// Token: 0x170005CA RID: 1482
	// (get) Token: 0x0600104F RID: 4175 RVA: 0x00006558 File Offset: 0x00004758
	[Token(Token = "0x170005CA")]
	private TypeId TypeId
	{
		[Token(Token = "0x600104F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170005CB RID: 1483
	// (get) Token: 0x06001050 RID: 4176 RVA: 0x00006570 File Offset: 0x00004770
	[Token(Token = "0x170005CB")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001050")]
		[Address(RVA = "0x87C550", Offset = "0x87AB50", VA = "0x18087C550", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170005CC RID: 1484
	// (get) Token: 0x06001051 RID: 4177 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170005CC")]
	private Type TypeObject
	{
		[Token(Token = "0x6001051")]
		[Address(RVA = "0x87C570", Offset = "0x87AB70", VA = "0x18087C570", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001052 RID: 4178 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001052")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001053 RID: 4179 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001053")]
	[Address(RVA = "0x87C610", Offset = "0x87AC10", VA = "0x18087C610", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001054 RID: 4180 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001054")]
	[Address(RVA = "0x87C900", Offset = "0x87AF00", VA = "0x18087C900", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001055 RID: 4181 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001055")]
	[Address(RVA = "0x87C990", Offset = "0x87AF90", VA = "0x18087C990", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000299 RID: 665
	[Token(Token = "0x4000299")]
	[FieldOffset(Offset = "0x0")]
	internal static PickupApproved_Meta Instance;
}
