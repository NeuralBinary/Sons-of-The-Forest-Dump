using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000205 RID: 517
[Token(Token = "0x2000205")]
internal class DismemberHitEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x0600178C RID: 6028 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600178C")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public DismemberHitEvent_Meta()
	{
	}

	// Token: 0x170006F9 RID: 1785
	// (get) Token: 0x0600178D RID: 6029 RVA: 0x00007818 File Offset: 0x00005A18
	[Token(Token = "0x170006F9")]
	private TypeId TypeId
	{
		[Token(Token = "0x600178D")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170006FA RID: 1786
	// (get) Token: 0x0600178E RID: 6030 RVA: 0x00007830 File Offset: 0x00005A30
	[Token(Token = "0x170006FA")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600178E")]
		[Address(RVA = "0x8B6E00", Offset = "0x8B5400", VA = "0x1808B6E00", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170006FB RID: 1787
	// (get) Token: 0x0600178F RID: 6031 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170006FB")]
	private Type TypeObject
	{
		[Token(Token = "0x600178F")]
		[Address(RVA = "0x8B6E20", Offset = "0x8B5420", VA = "0x1808B6E20", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001790 RID: 6032 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001790")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001791 RID: 6033 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001791")]
	[Address(RVA = "0x8B6EC0", Offset = "0x8B54C0", VA = "0x1808B6EC0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001792 RID: 6034 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001792")]
	[Address(RVA = "0x8B7320", Offset = "0x8B5920", VA = "0x1808B7320", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001793 RID: 6035 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001793")]
	[Address(RVA = "0x8B73B0", Offset = "0x8B59B0", VA = "0x1808B73B0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002CF RID: 719
	[Token(Token = "0x40002CF")]
	[FieldOffset(Offset = "0x0")]
	internal static DismemberHitEvent_Meta Instance;
}
