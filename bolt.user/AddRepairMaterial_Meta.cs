using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000130 RID: 304
[Token(Token = "0x2000130")]
internal class AddRepairMaterial_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000E0E RID: 3598 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E0E")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public AddRepairMaterial_Meta()
	{
	}

	// Token: 0x17000576 RID: 1398
	// (get) Token: 0x06000E0F RID: 3599 RVA: 0x000060A8 File Offset: 0x000042A8
	[Token(Token = "0x17000576")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000E0F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000577 RID: 1399
	// (get) Token: 0x06000E10 RID: 3600 RVA: 0x000060C0 File Offset: 0x000042C0
	[Token(Token = "0x17000577")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000E10")]
		[Address(RVA = "0x869F10", Offset = "0x868510", VA = "0x180869F10", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000578 RID: 1400
	// (get) Token: 0x06000E11 RID: 3601 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000578")]
	private Type TypeObject
	{
		[Token(Token = "0x6000E11")]
		[Address(RVA = "0x869F30", Offset = "0x868530", VA = "0x180869F30", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E12 RID: 3602 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E12")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000E13 RID: 3603 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E13")]
	[Address(RVA = "0x869FD0", Offset = "0x8685D0", VA = "0x180869FD0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000E14 RID: 3604 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E14")]
	[Address(RVA = "0x86A2C0", Offset = "0x8688C0", VA = "0x18086A2C0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000E15 RID: 3605 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E15")]
	[Address(RVA = "0x86A350", Offset = "0x868950", VA = "0x18086A350", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000288 RID: 648
	[Token(Token = "0x4000288")]
	[FieldOffset(Offset = "0x0")]
	internal static AddRepairMaterial_Meta Instance;
}
