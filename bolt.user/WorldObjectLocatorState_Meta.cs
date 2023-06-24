using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001E4 RID: 484
[Token(Token = "0x20001E4")]
internal class WorldObjectLocatorState_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001622 RID: 5666 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001622")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public WorldObjectLocatorState_Meta()
	{
	}

	// Token: 0x170006C2 RID: 1730
	// (get) Token: 0x06001623 RID: 5667 RVA: 0x000074E8 File Offset: 0x000056E8
	[Token(Token = "0x170006C2")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001623")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170006C3 RID: 1731
	// (get) Token: 0x06001624 RID: 5668 RVA: 0x00007500 File Offset: 0x00005700
	[Token(Token = "0x170006C3")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001624")]
		[Address(RVA = "0x8AC270", Offset = "0x8AA870", VA = "0x1808AC270", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170006C4 RID: 1732
	// (get) Token: 0x06001625 RID: 5669 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170006C4")]
	private Type TypeObject
	{
		[Token(Token = "0x6001625")]
		[Address(RVA = "0x8AC290", Offset = "0x8AA890", VA = "0x1808AC290", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001626 RID: 5670 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001626")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001627 RID: 5671 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001627")]
	[Address(RVA = "0x8AC330", Offset = "0x8AA930", VA = "0x1808AC330", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001628 RID: 5672 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001628")]
	[Address(RVA = "0x8AC640", Offset = "0x8AAC40", VA = "0x1808AC640", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001629 RID: 5673 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001629")]
	[Address(RVA = "0x8AC6D0", Offset = "0x8AACD0", VA = "0x1808AC6D0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002C4 RID: 708
	[Token(Token = "0x40002C4")]
	[FieldOffset(Offset = "0x0")]
	internal static WorldObjectLocatorState_Meta Instance;
}
