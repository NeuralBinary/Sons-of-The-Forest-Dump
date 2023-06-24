using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000184 RID: 388
[Token(Token = "0x2000184")]
internal class SetGuiTextureColor_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060011C0 RID: 4544 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011C0")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public SetGuiTextureColor_Meta()
	{
	}

	// Token: 0x170005FF RID: 1535
	// (get) Token: 0x060011C1 RID: 4545 RVA: 0x00006858 File Offset: 0x00004A58
	[Token(Token = "0x170005FF")]
	private TypeId TypeId
	{
		[Token(Token = "0x60011C1")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000600 RID: 1536
	// (get) Token: 0x060011C2 RID: 4546 RVA: 0x00006870 File Offset: 0x00004A70
	[Token(Token = "0x17000600")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60011C2")]
		[Address(RVA = "0x887970", Offset = "0x885F70", VA = "0x180887970", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000601 RID: 1537
	// (get) Token: 0x060011C3 RID: 4547 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000601")]
	private Type TypeObject
	{
		[Token(Token = "0x60011C3")]
		[Address(RVA = "0x887990", Offset = "0x885F90", VA = "0x180887990", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060011C4 RID: 4548 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011C4")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060011C5 RID: 4549 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011C5")]
	[Address(RVA = "0x887A30", Offset = "0x886030", VA = "0x180887A30", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060011C6 RID: 4550 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011C6")]
	[Address(RVA = "0x887D20", Offset = "0x886320", VA = "0x180887D20", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060011C7 RID: 4551 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011C7")]
	[Address(RVA = "0x887DB0", Offset = "0x8863B0", VA = "0x180887DB0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002A4 RID: 676
	[Token(Token = "0x40002A4")]
	[FieldOffset(Offset = "0x0")]
	internal static SetGuiTextureColor_Meta Instance;
}
