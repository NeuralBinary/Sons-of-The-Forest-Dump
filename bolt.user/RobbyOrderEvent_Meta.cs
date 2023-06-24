using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001E7 RID: 487
[Token(Token = "0x20001E7")]
internal class RobbyOrderEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x0600164C RID: 5708 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600164C")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public RobbyOrderEvent_Meta()
	{
	}

	// Token: 0x170006CB RID: 1739
	// (get) Token: 0x0600164D RID: 5709 RVA: 0x00007578 File Offset: 0x00005778
	[Token(Token = "0x170006CB")]
	private TypeId TypeId
	{
		[Token(Token = "0x600164D")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170006CC RID: 1740
	// (get) Token: 0x0600164E RID: 5710 RVA: 0x00007590 File Offset: 0x00005790
	[Token(Token = "0x170006CC")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600164E")]
		[Address(RVA = "0x8AD800", Offset = "0x8ABE00", VA = "0x1808AD800", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170006CD RID: 1741
	// (get) Token: 0x0600164F RID: 5711 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170006CD")]
	private Type TypeObject
	{
		[Token(Token = "0x600164F")]
		[Address(RVA = "0x8AD820", Offset = "0x8ABE20", VA = "0x1808AD820", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001650 RID: 5712 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001650")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001651 RID: 5713 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001651")]
	[Address(RVA = "0x8AD8C0", Offset = "0x8ABEC0", VA = "0x1808AD8C0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001652 RID: 5714 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001652")]
	[Address(RVA = "0x8AE020", Offset = "0x8AC620", VA = "0x1808AE020", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001653 RID: 5715 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001653")]
	[Address(RVA = "0x8AE0B0", Offset = "0x8AC6B0", VA = "0x1808AE0B0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002C5 RID: 709
	[Token(Token = "0x40002C5")]
	[FieldOffset(Offset = "0x0")]
	internal static RobbyOrderEvent_Meta Instance;
}
