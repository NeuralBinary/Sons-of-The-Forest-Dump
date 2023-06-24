using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200021D RID: 541
[Token(Token = "0x200021D")]
internal class DwGateOpenEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060018EE RID: 6382 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018EE")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public DwGateOpenEvent_Meta()
	{
	}

	// Token: 0x1700074C RID: 1868
	// (get) Token: 0x060018EF RID: 6383 RVA: 0x00007E60 File Offset: 0x00006060
	[Token(Token = "0x1700074C")]
	private TypeId TypeId
	{
		[Token(Token = "0x60018EF")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700074D RID: 1869
	// (get) Token: 0x060018F0 RID: 6384 RVA: 0x00007E78 File Offset: 0x00006078
	[Token(Token = "0x1700074D")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60018F0")]
		[Address(RVA = "0x8C50F0", Offset = "0x8C36F0", VA = "0x1808C50F0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700074E RID: 1870
	// (get) Token: 0x060018F1 RID: 6385 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700074E")]
	private Type TypeObject
	{
		[Token(Token = "0x60018F1")]
		[Address(RVA = "0x8C5110", Offset = "0x8C3710", VA = "0x1808C5110", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060018F2 RID: 6386 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018F2")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060018F3 RID: 6387 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018F3")]
	[Address(RVA = "0x8C51B0", Offset = "0x8C37B0", VA = "0x1808C51B0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060018F4 RID: 6388 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018F4")]
	[Address(RVA = "0x8C54C0", Offset = "0x8C3AC0", VA = "0x1808C54C0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060018F5 RID: 6389 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018F5")]
	[Address(RVA = "0x8C5550", Offset = "0x8C3B50", VA = "0x1808C5550", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002D7 RID: 727
	[Token(Token = "0x40002D7")]
	[FieldOffset(Offset = "0x0")]
	internal static DwGateOpenEvent_Meta Instance;
}
