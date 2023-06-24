using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001FC RID: 508
[Token(Token = "0x20001FC")]
internal class FreeFormStructureRejected_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001728 RID: 5928 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001728")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public FreeFormStructureRejected_Meta()
	{
	}

	// Token: 0x170006EB RID: 1771
	// (get) Token: 0x06001729 RID: 5929 RVA: 0x00007758 File Offset: 0x00005958
	[Token(Token = "0x170006EB")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001729")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170006EC RID: 1772
	// (get) Token: 0x0600172A RID: 5930 RVA: 0x00007770 File Offset: 0x00005970
	[Token(Token = "0x170006EC")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600172A")]
		[Address(RVA = "0x8B3E70", Offset = "0x8B2470", VA = "0x1808B3E70", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170006ED RID: 1773
	// (get) Token: 0x0600172B RID: 5931 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170006ED")]
	private Type TypeObject
	{
		[Token(Token = "0x600172B")]
		[Address(RVA = "0x8B3E90", Offset = "0x8B2490", VA = "0x1808B3E90", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600172C RID: 5932 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600172C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600172D RID: 5933 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600172D")]
	[Address(RVA = "0x8B3F30", Offset = "0x8B2530", VA = "0x1808B3F30", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600172E RID: 5934 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600172E")]
	[Address(RVA = "0x8B4130", Offset = "0x8B2730", VA = "0x1808B4130", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0600172F RID: 5935 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600172F")]
	[Address(RVA = "0x8B41C0", Offset = "0x8B27C0", VA = "0x1808B41C0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002CC RID: 716
	[Token(Token = "0x40002CC")]
	[FieldOffset(Offset = "0x0")]
	internal static FreeFormStructureRejected_Meta Instance;
}
