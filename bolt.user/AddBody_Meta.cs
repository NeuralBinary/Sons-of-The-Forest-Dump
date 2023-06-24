using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000145 RID: 325
[Token(Token = "0x2000145")]
internal class AddBody_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000EFE RID: 3838 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EFE")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public AddBody_Meta()
	{
	}

	// Token: 0x1700059A RID: 1434
	// (get) Token: 0x06000EFF RID: 3839 RVA: 0x000062D0 File Offset: 0x000044D0
	[Token(Token = "0x1700059A")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000EFF")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700059B RID: 1435
	// (get) Token: 0x06000F00 RID: 3840 RVA: 0x000062E8 File Offset: 0x000044E8
	[Token(Token = "0x1700059B")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000F00")]
		[Address(RVA = "0x871940", Offset = "0x86FF40", VA = "0x180871940", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700059C RID: 1436
	// (get) Token: 0x06000F01 RID: 3841 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700059C")]
	private Type TypeObject
	{
		[Token(Token = "0x6000F01")]
		[Address(RVA = "0x871960", Offset = "0x86FF60", VA = "0x180871960", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000F02 RID: 3842 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F02")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000F03 RID: 3843 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F03")]
	[Address(RVA = "0x871A00", Offset = "0x870000", VA = "0x180871A00", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000F04 RID: 3844 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F04")]
	[Address(RVA = "0x871CF0", Offset = "0x8702F0", VA = "0x180871CF0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000F05 RID: 3845 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F05")]
	[Address(RVA = "0x871D80", Offset = "0x870380", VA = "0x180871D80", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400028F RID: 655
	[Token(Token = "0x400028F")]
	[FieldOffset(Offset = "0x0")]
	internal static AddBody_Meta Instance;
}
