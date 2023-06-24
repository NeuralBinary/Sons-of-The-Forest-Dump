using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000208 RID: 520
[Token(Token = "0x2000208")]
internal class PickupBodyEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060017BA RID: 6074 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017BA")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public PickupBodyEvent_Meta()
	{
	}

	// Token: 0x17000704 RID: 1796
	// (get) Token: 0x060017BB RID: 6075 RVA: 0x000078D8 File Offset: 0x00005AD8
	[Token(Token = "0x17000704")]
	private TypeId TypeId
	{
		[Token(Token = "0x60017BB")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000705 RID: 1797
	// (get) Token: 0x060017BC RID: 6076 RVA: 0x000078F0 File Offset: 0x00005AF0
	[Token(Token = "0x17000705")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60017BC")]
		[Address(RVA = "0x8B8610", Offset = "0x8B6C10", VA = "0x1808B8610", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000706 RID: 1798
	// (get) Token: 0x060017BD RID: 6077 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000706")]
	private Type TypeObject
	{
		[Token(Token = "0x60017BD")]
		[Address(RVA = "0x8B8630", Offset = "0x8B6C30", VA = "0x1808B8630", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060017BE RID: 6078 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017BE")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060017BF RID: 6079 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017BF")]
	[Address(RVA = "0x8B86D0", Offset = "0x8B6CD0", VA = "0x1808B86D0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060017C0 RID: 6080 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017C0")]
	[Address(RVA = "0x8B9080", Offset = "0x8B7680", VA = "0x1808B9080", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060017C1 RID: 6081 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017C1")]
	[Address(RVA = "0x8B9110", Offset = "0x8B7710", VA = "0x1808B9110", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002D0 RID: 720
	[Token(Token = "0x40002D0")]
	[FieldOffset(Offset = "0x0")]
	internal static PickupBodyEvent_Meta Instance;
}
