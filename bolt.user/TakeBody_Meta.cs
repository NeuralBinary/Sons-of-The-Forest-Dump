using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000151 RID: 337
[Token(Token = "0x2000151")]
internal class TakeBody_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000F7E RID: 3966 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F7E")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public TakeBody_Meta()
	{
	}

	// Token: 0x170005AA RID: 1450
	// (get) Token: 0x06000F7F RID: 3967 RVA: 0x00006390 File Offset: 0x00004590
	[Token(Token = "0x170005AA")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000F7F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170005AB RID: 1451
	// (get) Token: 0x06000F80 RID: 3968 RVA: 0x000063A8 File Offset: 0x000045A8
	[Token(Token = "0x170005AB")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000F80")]
		[Address(RVA = "0x875700", Offset = "0x873D00", VA = "0x180875700", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170005AC RID: 1452
	// (get) Token: 0x06000F81 RID: 3969 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170005AC")]
	private Type TypeObject
	{
		[Token(Token = "0x6000F81")]
		[Address(RVA = "0x875720", Offset = "0x873D20", VA = "0x180875720", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000F82 RID: 3970 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F82")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000F83 RID: 3971 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F83")]
	[Address(RVA = "0x8757C0", Offset = "0x873DC0", VA = "0x1808757C0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000F84 RID: 3972 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F84")]
	[Address(RVA = "0x875AB0", Offset = "0x8740B0", VA = "0x180875AB0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000F85 RID: 3973 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F85")]
	[Address(RVA = "0x875B40", Offset = "0x874140", VA = "0x180875B40", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000293 RID: 659
	[Token(Token = "0x4000293")]
	[FieldOffset(Offset = "0x0")]
	internal static TakeBody_Meta Instance;
}
