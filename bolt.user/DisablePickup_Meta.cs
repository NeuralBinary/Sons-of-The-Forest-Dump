using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000175 RID: 373
[Token(Token = "0x2000175")]
internal class DisablePickup_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001114 RID: 4372 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001114")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public DisablePickup_Meta()
	{
	}

	// Token: 0x170005E5 RID: 1509
	// (get) Token: 0x06001115 RID: 4373 RVA: 0x000066C0 File Offset: 0x000048C0
	[Token(Token = "0x170005E5")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001115")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170005E6 RID: 1510
	// (get) Token: 0x06001116 RID: 4374 RVA: 0x000066D8 File Offset: 0x000048D8
	[Token(Token = "0x170005E6")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001116")]
		[Address(RVA = "0x8820A0", Offset = "0x8806A0", VA = "0x1808820A0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170005E7 RID: 1511
	// (get) Token: 0x06001117 RID: 4375 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170005E7")]
	private Type TypeObject
	{
		[Token(Token = "0x6001117")]
		[Address(RVA = "0x8820C0", Offset = "0x8806C0", VA = "0x1808820C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001118 RID: 4376 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001118")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001119 RID: 4377 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001119")]
	[Address(RVA = "0x882160", Offset = "0x880760", VA = "0x180882160", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600111A RID: 4378 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600111A")]
	[Address(RVA = "0x882460", Offset = "0x880A60", VA = "0x180882460", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0600111B RID: 4379 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600111B")]
	[Address(RVA = "0x8824F0", Offset = "0x880AF0", VA = "0x1808824F0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400029F RID: 671
	[Token(Token = "0x400029F")]
	[FieldOffset(Offset = "0x0")]
	internal static DisablePickup_Meta Instance;
}
