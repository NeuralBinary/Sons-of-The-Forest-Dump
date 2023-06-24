using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200016F RID: 367
[Token(Token = "0x200016F")]
internal class AdminAuthed_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060010D2 RID: 4306 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010D2")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public AdminAuthed_Meta()
	{
	}

	// Token: 0x170005DC RID: 1500
	// (get) Token: 0x060010D3 RID: 4307 RVA: 0x00006648 File Offset: 0x00004848
	[Token(Token = "0x170005DC")]
	private TypeId TypeId
	{
		[Token(Token = "0x60010D3")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170005DD RID: 1501
	// (get) Token: 0x060010D4 RID: 4308 RVA: 0x00006660 File Offset: 0x00004860
	[Token(Token = "0x170005DD")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60010D4")]
		[Address(RVA = "0x880230", Offset = "0x87E830", VA = "0x180880230", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170005DE RID: 1502
	// (get) Token: 0x060010D5 RID: 4309 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170005DE")]
	private Type TypeObject
	{
		[Token(Token = "0x60010D5")]
		[Address(RVA = "0x880250", Offset = "0x87E850", VA = "0x180880250", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060010D6 RID: 4310 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010D6")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060010D7 RID: 4311 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010D7")]
	[Address(RVA = "0x8802F0", Offset = "0x87E8F0", VA = "0x1808802F0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060010D8 RID: 4312 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010D8")]
	[Address(RVA = "0x8804E0", Offset = "0x87EAE0", VA = "0x1808804E0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060010D9 RID: 4313 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010D9")]
	[Address(RVA = "0x880570", Offset = "0x87EB70", VA = "0x180880570", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400029D RID: 669
	[Token(Token = "0x400029D")]
	[FieldOffset(Offset = "0x0")]
	internal static AdminAuthed_Meta Instance;
}
