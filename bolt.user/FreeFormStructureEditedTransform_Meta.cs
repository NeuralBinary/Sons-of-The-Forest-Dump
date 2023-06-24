using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001CC RID: 460
[Token(Token = "0x20001CC")]
internal class FreeFormStructureEditedTransform_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001504 RID: 5380 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001504")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public FreeFormStructureEditedTransform_Meta()
	{
	}

	// Token: 0x1700068B RID: 1675
	// (get) Token: 0x06001505 RID: 5381 RVA: 0x000070F8 File Offset: 0x000052F8
	[Token(Token = "0x1700068B")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001505")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700068C RID: 1676
	// (get) Token: 0x06001506 RID: 5382 RVA: 0x00007110 File Offset: 0x00005310
	[Token(Token = "0x1700068C")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001506")]
		[Address(RVA = "0x8A2770", Offset = "0x8A0D70", VA = "0x1808A2770", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700068D RID: 1677
	// (get) Token: 0x06001507 RID: 5383 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700068D")]
	private Type TypeObject
	{
		[Token(Token = "0x6001507")]
		[Address(RVA = "0x8A2790", Offset = "0x8A0D90", VA = "0x1808A2790", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001508 RID: 5384 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001508")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001509 RID: 5385 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001509")]
	[Address(RVA = "0x8A2830", Offset = "0x8A0E30", VA = "0x1808A2830", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600150A RID: 5386 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600150A")]
	[Address(RVA = "0x8A2F70", Offset = "0x8A1570", VA = "0x1808A2F70", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0600150B RID: 5387 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600150B")]
	[Address(RVA = "0x8A3000", Offset = "0x8A1600", VA = "0x1808A3000", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002BC RID: 700
	[Token(Token = "0x40002BC")]
	[FieldOffset(Offset = "0x0")]
	internal static FreeFormStructureEditedTransform_Meta Instance;
}
