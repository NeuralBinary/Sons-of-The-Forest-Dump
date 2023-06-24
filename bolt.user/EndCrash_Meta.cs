using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000190 RID: 400
[Token(Token = "0x2000190")]
internal class EndCrash_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001250 RID: 4688 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001250")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public EndCrash_Meta()
	{
	}

	// Token: 0x17000617 RID: 1559
	// (get) Token: 0x06001251 RID: 4689 RVA: 0x000069F0 File Offset: 0x00004BF0
	[Token(Token = "0x17000617")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001251")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000618 RID: 1560
	// (get) Token: 0x06001252 RID: 4690 RVA: 0x00006A08 File Offset: 0x00004C08
	[Token(Token = "0x17000618")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001252")]
		[Address(RVA = "0x88C720", Offset = "0x88AD20", VA = "0x18088C720", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000619 RID: 1561
	// (get) Token: 0x06001253 RID: 4691 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000619")]
	private Type TypeObject
	{
		[Token(Token = "0x6001253")]
		[Address(RVA = "0x88C740", Offset = "0x88AD40", VA = "0x18088C740", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001254 RID: 4692 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001254")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001255 RID: 4693 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001255")]
	[Address(RVA = "0x88C7E0", Offset = "0x88ADE0", VA = "0x18088C7E0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001256 RID: 4694 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001256")]
	[Address(RVA = "0x88C9D0", Offset = "0x88AFD0", VA = "0x18088C9D0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001257 RID: 4695 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001257")]
	[Address(RVA = "0x88CA60", Offset = "0x88B060", VA = "0x18088CA60", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002A8 RID: 680
	[Token(Token = "0x40002A8")]
	[FieldOffset(Offset = "0x0")]
	internal static EndCrash_Meta Instance;
}
