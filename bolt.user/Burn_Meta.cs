using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000136 RID: 310
[Token(Token = "0x2000136")]
internal class Burn_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000E54 RID: 3668 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E54")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public Burn_Meta()
	{
	}

	// Token: 0x17000581 RID: 1409
	// (get) Token: 0x06000E55 RID: 3669 RVA: 0x00006150 File Offset: 0x00004350
	[Token(Token = "0x17000581")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000E55")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000582 RID: 1410
	// (get) Token: 0x06000E56 RID: 3670 RVA: 0x00006168 File Offset: 0x00004368
	[Token(Token = "0x17000582")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000E56")]
		[Address(RVA = "0x86C540", Offset = "0x86AB40", VA = "0x18086C540", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000583 RID: 1411
	// (get) Token: 0x06000E57 RID: 3671 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000583")]
	private Type TypeObject
	{
		[Token(Token = "0x6000E57")]
		[Address(RVA = "0x86C560", Offset = "0x86AB60", VA = "0x18086C560", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E58 RID: 3672 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E58")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000E59 RID: 3673 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E59")]
	[Address(RVA = "0x86C600", Offset = "0x86AC00", VA = "0x18086C600", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000E5A RID: 3674 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E5A")]
	[Address(RVA = "0x86C7F0", Offset = "0x86ADF0", VA = "0x18086C7F0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000E5B RID: 3675 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E5B")]
	[Address(RVA = "0x86C880", Offset = "0x86AE80", VA = "0x18086C880", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400028A RID: 650
	[Token(Token = "0x400028A")]
	[FieldOffset(Offset = "0x0")]
	internal static Burn_Meta Instance;
}
