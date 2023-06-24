using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000187 RID: 391
[Token(Token = "0x2000187")]
internal class PlaceDryingFood_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060011E8 RID: 4584 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011E8")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public PlaceDryingFood_Meta()
	{
	}

	// Token: 0x17000607 RID: 1543
	// (get) Token: 0x060011E9 RID: 4585 RVA: 0x000068E8 File Offset: 0x00004AE8
	[Token(Token = "0x17000607")]
	private TypeId TypeId
	{
		[Token(Token = "0x60011E9")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000608 RID: 1544
	// (get) Token: 0x060011EA RID: 4586 RVA: 0x00006900 File Offset: 0x00004B00
	[Token(Token = "0x17000608")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60011EA")]
		[Address(RVA = "0x888DD0", Offset = "0x8873D0", VA = "0x180888DD0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000609 RID: 1545
	// (get) Token: 0x060011EB RID: 4587 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000609")]
	private Type TypeObject
	{
		[Token(Token = "0x60011EB")]
		[Address(RVA = "0x888DF0", Offset = "0x8873F0", VA = "0x180888DF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060011EC RID: 4588 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011EC")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060011ED RID: 4589 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011ED")]
	[Address(RVA = "0x888E90", Offset = "0x887490", VA = "0x180888E90", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060011EE RID: 4590 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011EE")]
	[Address(RVA = "0x8895D0", Offset = "0x887BD0", VA = "0x1808895D0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060011EF RID: 4591 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011EF")]
	[Address(RVA = "0x889660", Offset = "0x887C60", VA = "0x180889660", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002A5 RID: 677
	[Token(Token = "0x40002A5")]
	[FieldOffset(Offset = "0x0")]
	internal static PlaceDryingFood_Meta Instance;
}
