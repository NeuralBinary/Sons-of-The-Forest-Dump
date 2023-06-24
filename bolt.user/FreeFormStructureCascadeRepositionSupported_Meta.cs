using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001D2 RID: 466
[Token(Token = "0x20001D2")]
internal class FreeFormStructureCascadeRepositionSupported_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x0600153C RID: 5436 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600153C")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public FreeFormStructureCascadeRepositionSupported_Meta()
	{
	}

	// Token: 0x17000693 RID: 1683
	// (get) Token: 0x0600153D RID: 5437 RVA: 0x00007170 File Offset: 0x00005370
	[Token(Token = "0x17000693")]
	private TypeId TypeId
	{
		[Token(Token = "0x600153D")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000694 RID: 1684
	// (get) Token: 0x0600153E RID: 5438 RVA: 0x00007188 File Offset: 0x00005388
	[Token(Token = "0x17000694")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600153E")]
		[Address(RVA = "0x8A4170", Offset = "0x8A2770", VA = "0x1808A4170", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000695 RID: 1685
	// (get) Token: 0x0600153F RID: 5439 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000695")]
	private Type TypeObject
	{
		[Token(Token = "0x600153F")]
		[Address(RVA = "0x8A4190", Offset = "0x8A2790", VA = "0x1808A4190", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001540 RID: 5440 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001540")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001541 RID: 5441 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001541")]
	[Address(RVA = "0x8A4230", Offset = "0x8A2830", VA = "0x1808A4230", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001542 RID: 5442 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001542")]
	[Address(RVA = "0x8A4540", Offset = "0x8A2B40", VA = "0x1808A4540", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001543 RID: 5443 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001543")]
	[Address(RVA = "0x8A45D0", Offset = "0x8A2BD0", VA = "0x1808A45D0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002BE RID: 702
	[Token(Token = "0x40002BE")]
	[FieldOffset(Offset = "0x0")]
	internal static FreeFormStructureCascadeRepositionSupported_Meta Instance;
}
