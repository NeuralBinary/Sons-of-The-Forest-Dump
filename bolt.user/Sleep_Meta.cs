using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000181 RID: 385
[Token(Token = "0x2000181")]
internal class Sleep_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x0600119E RID: 4510 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600119E")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public Sleep_Meta()
	{
	}

	// Token: 0x170005FA RID: 1530
	// (get) Token: 0x0600119F RID: 4511 RVA: 0x00006810 File Offset: 0x00004A10
	[Token(Token = "0x170005FA")]
	private TypeId TypeId
	{
		[Token(Token = "0x600119F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170005FB RID: 1531
	// (get) Token: 0x060011A0 RID: 4512 RVA: 0x00006828 File Offset: 0x00004A28
	[Token(Token = "0x170005FB")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60011A0")]
		[Address(RVA = "0x886880", Offset = "0x884E80", VA = "0x180886880", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170005FC RID: 1532
	// (get) Token: 0x060011A1 RID: 4513 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170005FC")]
	private Type TypeObject
	{
		[Token(Token = "0x60011A1")]
		[Address(RVA = "0x8868A0", Offset = "0x884EA0", VA = "0x1808868A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060011A2 RID: 4514 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011A2")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060011A3 RID: 4515 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011A3")]
	[Address(RVA = "0x886940", Offset = "0x884F40", VA = "0x180886940", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060011A4 RID: 4516 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011A4")]
	[Address(RVA = "0x886B30", Offset = "0x885130", VA = "0x180886B30", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060011A5 RID: 4517 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011A5")]
	[Address(RVA = "0x886BC0", Offset = "0x8851C0", VA = "0x180886BC0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002A3 RID: 675
	[Token(Token = "0x40002A3")]
	[FieldOffset(Offset = "0x0")]
	internal static Sleep_Meta Instance;
}
