using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000DC RID: 220
[Token(Token = "0x20000DC")]
internal class ItemHolderAddItem_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000A46 RID: 2630 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A46")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public ItemHolderAddItem_Meta()
	{
	}

	// Token: 0x170004E2 RID: 1250
	// (get) Token: 0x06000A47 RID: 2631 RVA: 0x000057F0 File Offset: 0x000039F0
	[Token(Token = "0x170004E2")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170004E3 RID: 1251
	// (get) Token: 0x06000A48 RID: 2632 RVA: 0x00005808 File Offset: 0x00003A08
	[Token(Token = "0x170004E3")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x84A0F0", Offset = "0x8486F0", VA = "0x18084A0F0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170004E4 RID: 1252
	// (get) Token: 0x06000A49 RID: 2633 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170004E4")]
	private Type TypeObject
	{
		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x84A110", Offset = "0x848710", VA = "0x18084A110", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000A4A RID: 2634 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A4A")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000A4B RID: 2635 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A4B")]
	[Address(RVA = "0x84A1B0", Offset = "0x8487B0", VA = "0x18084A1B0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000A4C RID: 2636 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A4C")]
	[Address(RVA = "0x84A6F0", Offset = "0x848CF0", VA = "0x18084A6F0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000A4D RID: 2637 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A4D")]
	[Address(RVA = "0x84A780", Offset = "0x848D80", VA = "0x18084A780", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400026C RID: 620
	[Token(Token = "0x400026C")]
	[FieldOffset(Offset = "0x0")]
	internal static ItemHolderAddItem_Meta Instance;
}
