using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001E1 RID: 481
[Token(Token = "0x20001E1")]
internal class PlayerFireWeaponEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001600 RID: 5632 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001600")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public PlayerFireWeaponEvent_Meta()
	{
	}

	// Token: 0x170006BD RID: 1725
	// (get) Token: 0x06001601 RID: 5633 RVA: 0x00007488 File Offset: 0x00005688
	[Token(Token = "0x170006BD")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001601")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170006BE RID: 1726
	// (get) Token: 0x06001602 RID: 5634 RVA: 0x000074A0 File Offset: 0x000056A0
	[Token(Token = "0x170006BE")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001602")]
		[Address(RVA = "0x8AB4B0", Offset = "0x8A9AB0", VA = "0x1808AB4B0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170006BF RID: 1727
	// (get) Token: 0x06001603 RID: 5635 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170006BF")]
	private Type TypeObject
	{
		[Token(Token = "0x6001603")]
		[Address(RVA = "0x8AB4D0", Offset = "0x8A9AD0", VA = "0x1808AB4D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001604 RID: 5636 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001604")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001605 RID: 5637 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001605")]
	[Address(RVA = "0x8AB570", Offset = "0x8A9B70", VA = "0x1808AB570", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001606 RID: 5638 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001606")]
	[Address(RVA = "0x8AB760", Offset = "0x8A9D60", VA = "0x1808AB760", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001607 RID: 5639 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001607")]
	[Address(RVA = "0x8AB7F0", Offset = "0x8A9DF0", VA = "0x1808AB7F0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002C3 RID: 707
	[Token(Token = "0x40002C3")]
	[FieldOffset(Offset = "0x0")]
	internal static PlayerFireWeaponEvent_Meta Instance;
}
