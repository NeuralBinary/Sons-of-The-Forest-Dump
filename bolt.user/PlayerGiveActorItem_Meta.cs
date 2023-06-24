using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200023E RID: 574
[Token(Token = "0x200023E")]
internal class PlayerGiveActorItem_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001A7E RID: 6782 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A7E")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public PlayerGiveActorItem_Meta()
	{
	}

	// Token: 0x17000790 RID: 1936
	// (get) Token: 0x06001A7F RID: 6783 RVA: 0x000082E0 File Offset: 0x000064E0
	[Token(Token = "0x17000790")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001A7F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000791 RID: 1937
	// (get) Token: 0x06001A80 RID: 6784 RVA: 0x000082F8 File Offset: 0x000064F8
	[Token(Token = "0x17000791")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001A80")]
		[Address(RVA = "0x7D7AE0", Offset = "0x7D60E0", VA = "0x1807D7AE0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000792 RID: 1938
	// (get) Token: 0x06001A81 RID: 6785 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000792")]
	private Type TypeObject
	{
		[Token(Token = "0x6001A81")]
		[Address(RVA = "0x7D7B00", Offset = "0x7D6100", VA = "0x1807D7B00", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001A82 RID: 6786 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A82")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001A83 RID: 6787 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A83")]
	[Address(RVA = "0x7D7BA0", Offset = "0x7D61A0", VA = "0x1807D7BA0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001A84 RID: 6788 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A84")]
	[Address(RVA = "0x7D80E0", Offset = "0x7D66E0", VA = "0x1807D80E0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001A85 RID: 6789 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A85")]
	[Address(RVA = "0x7D8170", Offset = "0x7D6770", VA = "0x1807D8170", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002E2 RID: 738
	[Token(Token = "0x40002E2")]
	[FieldOffset(Offset = "0x0")]
	internal static PlayerGiveActorItem_Meta Instance;
}
