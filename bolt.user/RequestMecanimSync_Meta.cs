using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200018A RID: 394
[Token(Token = "0x200018A")]
internal class RequestMecanimSync_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001208 RID: 4616 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001208")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public RequestMecanimSync_Meta()
	{
	}

	// Token: 0x1700060B RID: 1547
	// (get) Token: 0x06001209 RID: 4617 RVA: 0x00006918 File Offset: 0x00004B18
	[Token(Token = "0x1700060B")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001209")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700060C RID: 1548
	// (get) Token: 0x0600120A RID: 4618 RVA: 0x00006930 File Offset: 0x00004B30
	[Token(Token = "0x1700060C")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600120A")]
		[Address(RVA = "0x88A290", Offset = "0x888890", VA = "0x18088A290", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700060D RID: 1549
	// (get) Token: 0x0600120B RID: 4619 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700060D")]
	private Type TypeObject
	{
		[Token(Token = "0x600120B")]
		[Address(RVA = "0x88A2B0", Offset = "0x8888B0", VA = "0x18088A2B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600120C RID: 4620 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600120C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600120D RID: 4621 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600120D")]
	[Address(RVA = "0x88A350", Offset = "0x888950", VA = "0x18088A350", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600120E RID: 4622 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600120E")]
	[Address(RVA = "0x88A540", Offset = "0x888B40", VA = "0x18088A540", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0600120F RID: 4623 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600120F")]
	[Address(RVA = "0x88A5D0", Offset = "0x888BD0", VA = "0x18088A5D0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002A6 RID: 678
	[Token(Token = "0x40002A6")]
	[FieldOffset(Offset = "0x0")]
	internal static RequestMecanimSync_Meta Instance;
}
