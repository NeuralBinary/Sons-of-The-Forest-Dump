using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001D5 RID: 469
[Token(Token = "0x20001D5")]
internal class FreeFormStructureEditedElements_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x0600155E RID: 5470 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600155E")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public FreeFormStructureEditedElements_Meta()
	{
	}

	// Token: 0x1700069A RID: 1690
	// (get) Token: 0x0600155F RID: 5471 RVA: 0x000071E8 File Offset: 0x000053E8
	[Token(Token = "0x1700069A")]
	private TypeId TypeId
	{
		[Token(Token = "0x600155F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700069B RID: 1691
	// (get) Token: 0x06001560 RID: 5472 RVA: 0x00007200 File Offset: 0x00005400
	[Token(Token = "0x1700069B")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001560")]
		[Address(RVA = "0x8A4EB0", Offset = "0x8A34B0", VA = "0x1808A4EB0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700069C RID: 1692
	// (get) Token: 0x06001561 RID: 5473 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700069C")]
	private Type TypeObject
	{
		[Token(Token = "0x6001561")]
		[Address(RVA = "0x8A4ED0", Offset = "0x8A34D0", VA = "0x1808A4ED0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001562 RID: 5474 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001562")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001563 RID: 5475 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001563")]
	[Address(RVA = "0x8A4F70", Offset = "0x8A3570", VA = "0x1808A4F70", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001564 RID: 5476 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001564")]
	[Address(RVA = "0x8A54C0", Offset = "0x8A3AC0", VA = "0x1808A54C0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001565 RID: 5477 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001565")]
	[Address(RVA = "0x8A5550", Offset = "0x8A3B50", VA = "0x1808A5550", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002BF RID: 703
	[Token(Token = "0x40002BF")]
	[FieldOffset(Offset = "0x0")]
	internal static FreeFormStructureEditedElements_Meta Instance;
}
