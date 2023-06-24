using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001B4 RID: 436
[Token(Token = "0x20001B4")]
internal class TriggerFishTrap_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060013F2 RID: 5106 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013F2")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public TriggerFishTrap_Meta()
	{
	}

	// Token: 0x1700065A RID: 1626
	// (get) Token: 0x060013F3 RID: 5107 RVA: 0x00006D98 File Offset: 0x00004F98
	[Token(Token = "0x1700065A")]
	private TypeId TypeId
	{
		[Token(Token = "0x60013F3")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700065B RID: 1627
	// (get) Token: 0x060013F4 RID: 5108 RVA: 0x00006DB0 File Offset: 0x00004FB0
	[Token(Token = "0x1700065B")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60013F4")]
		[Address(RVA = "0x899C60", Offset = "0x898260", VA = "0x180899C60", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700065C RID: 1628
	// (get) Token: 0x060013F5 RID: 5109 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700065C")]
	private Type TypeObject
	{
		[Token(Token = "0x60013F5")]
		[Address(RVA = "0x899C80", Offset = "0x898280", VA = "0x180899C80", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060013F6 RID: 5110 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013F6")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060013F7 RID: 5111 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013F7")]
	[Address(RVA = "0x899D20", Offset = "0x898320", VA = "0x180899D20", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060013F8 RID: 5112 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013F8")]
	[Address(RVA = "0x89A2D0", Offset = "0x8988D0", VA = "0x18089A2D0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060013F9 RID: 5113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013F9")]
	[Address(RVA = "0x89A360", Offset = "0x898960", VA = "0x18089A360", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002B4 RID: 692
	[Token(Token = "0x40002B4")]
	[FieldOffset(Offset = "0x0")]
	internal static TriggerFishTrap_Meta Instance;
}
