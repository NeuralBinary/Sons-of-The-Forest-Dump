using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001DE RID: 478
[Token(Token = "0x20001DE")]
internal class VailNoiseEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060015E0 RID: 5600 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015E0")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public VailNoiseEvent_Meta()
	{
	}

	// Token: 0x170006B9 RID: 1721
	// (get) Token: 0x060015E1 RID: 5601 RVA: 0x00007458 File Offset: 0x00005658
	[Token(Token = "0x170006B9")]
	private TypeId TypeId
	{
		[Token(Token = "0x60015E1")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170006BA RID: 1722
	// (get) Token: 0x060015E2 RID: 5602 RVA: 0x00007470 File Offset: 0x00005670
	[Token(Token = "0x170006BA")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60015E2")]
		[Address(RVA = "0x8AA3E0", Offset = "0x8A89E0", VA = "0x1808AA3E0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170006BB RID: 1723
	// (get) Token: 0x060015E3 RID: 5603 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170006BB")]
	private Type TypeObject
	{
		[Token(Token = "0x60015E3")]
		[Address(RVA = "0x8AA400", Offset = "0x8A8A00", VA = "0x1808AA400", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060015E4 RID: 5604 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015E4")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060015E5 RID: 5605 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015E5")]
	[Address(RVA = "0x8AA4A0", Offset = "0x8A8AA0", VA = "0x1808AA4A0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060015E6 RID: 5606 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015E6")]
	[Address(RVA = "0x8AA860", Offset = "0x8A8E60", VA = "0x1808AA860", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060015E7 RID: 5607 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015E7")]
	[Address(RVA = "0x8AA8F0", Offset = "0x8A8EF0", VA = "0x1808AA8F0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002C2 RID: 706
	[Token(Token = "0x40002C2")]
	[FieldOffset(Offset = "0x0")]
	internal static VailNoiseEvent_Meta Instance;
}
