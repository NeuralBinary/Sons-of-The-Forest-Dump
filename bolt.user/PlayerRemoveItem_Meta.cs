using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000178 RID: 376
[Token(Token = "0x2000178")]
internal class PlayerRemoveItem_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001136 RID: 4406 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001136")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public PlayerRemoveItem_Meta()
	{
	}

	// Token: 0x170005EA RID: 1514
	// (get) Token: 0x06001137 RID: 4407 RVA: 0x00006708 File Offset: 0x00004908
	[Token(Token = "0x170005EA")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001137")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170005EB RID: 1515
	// (get) Token: 0x06001138 RID: 4408 RVA: 0x00006720 File Offset: 0x00004920
	[Token(Token = "0x170005EB")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001138")]
		[Address(RVA = "0x8831A0", Offset = "0x8817A0", VA = "0x1808831A0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170005EC RID: 1516
	// (get) Token: 0x06001139 RID: 4409 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170005EC")]
	private Type TypeObject
	{
		[Token(Token = "0x6001139")]
		[Address(RVA = "0x8831C0", Offset = "0x8817C0", VA = "0x1808831C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600113A RID: 4410 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600113A")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600113B RID: 4411 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600113B")]
	[Address(RVA = "0x883260", Offset = "0x881860", VA = "0x180883260", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600113C RID: 4412 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600113C")]
	[Address(RVA = "0x883570", Offset = "0x881B70", VA = "0x180883570", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0600113D RID: 4413 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600113D")]
	[Address(RVA = "0x883600", Offset = "0x881C00", VA = "0x180883600", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002A0 RID: 672
	[Token(Token = "0x40002A0")]
	[FieldOffset(Offset = "0x0")]
	internal static PlayerRemoveItem_Meta Instance;
}
