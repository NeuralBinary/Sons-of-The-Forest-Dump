using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001DB RID: 475
[Token(Token = "0x20001DB")]
internal class VailHitEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060015BE RID: 5566 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015BE")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public VailHitEvent_Meta()
	{
	}

	// Token: 0x170006B4 RID: 1716
	// (get) Token: 0x060015BF RID: 5567 RVA: 0x000073F8 File Offset: 0x000055F8
	[Token(Token = "0x170006B4")]
	private TypeId TypeId
	{
		[Token(Token = "0x60015BF")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170006B5 RID: 1717
	// (get) Token: 0x060015C0 RID: 5568 RVA: 0x00007410 File Offset: 0x00005610
	[Token(Token = "0x170006B5")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60015C0")]
		[Address(RVA = "0x8A8410", Offset = "0x8A6A10", VA = "0x1808A8410", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170006B6 RID: 1718
	// (get) Token: 0x060015C1 RID: 5569 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170006B6")]
	private Type TypeObject
	{
		[Token(Token = "0x60015C1")]
		[Address(RVA = "0x8A8430", Offset = "0x8A6A30", VA = "0x1808A8430", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060015C2 RID: 5570 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015C2")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060015C3 RID: 5571 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015C3")]
	[Address(RVA = "0x8A84D0", Offset = "0x8A6AD0", VA = "0x1808A84D0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060015C4 RID: 5572 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015C4")]
	[Address(RVA = "0x8A98C0", Offset = "0x8A7EC0", VA = "0x1808A98C0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060015C5 RID: 5573 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015C5")]
	[Address(RVA = "0x8A9950", Offset = "0x8A7F50", VA = "0x1808A9950", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002C1 RID: 705
	[Token(Token = "0x40002C1")]
	[FieldOffset(Offset = "0x0")]
	internal static VailHitEvent_Meta Instance;
}
