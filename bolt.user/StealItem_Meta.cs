using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000127 RID: 295
[Token(Token = "0x2000127")]
internal class StealItem_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000DA0 RID: 3488 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DA0")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public StealItem_Meta()
	{
	}

	// Token: 0x17000563 RID: 1379
	// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x00005FA0 File Offset: 0x000041A0
	[Token(Token = "0x17000563")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000DA1")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000564 RID: 1380
	// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x00005FB8 File Offset: 0x000041B8
	[Token(Token = "0x17000564")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0x865DF0", Offset = "0x8643F0", VA = "0x180865DF0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000565 RID: 1381
	// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000565")]
	private Type TypeObject
	{
		[Token(Token = "0x6000DA3")]
		[Address(RVA = "0x865E10", Offset = "0x864410", VA = "0x180865E10", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000DA4 RID: 3492 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DA4")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000DA5 RID: 3493 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DA5")]
	[Address(RVA = "0x865EB0", Offset = "0x8644B0", VA = "0x180865EB0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000DA6 RID: 3494 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DA6")]
	[Address(RVA = "0x8661A0", Offset = "0x8647A0", VA = "0x1808661A0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000DA7 RID: 3495 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DA7")]
	[Address(RVA = "0x866230", Offset = "0x864830", VA = "0x180866230", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000285 RID: 645
	[Token(Token = "0x4000285")]
	[FieldOffset(Offset = "0x0")]
	internal static StealItem_Meta Instance;
}
