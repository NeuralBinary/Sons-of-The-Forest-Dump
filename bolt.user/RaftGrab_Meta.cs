using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200012A RID: 298
[Token(Token = "0x200012A")]
internal class RaftGrab_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000DC4 RID: 3524 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DC4")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public RaftGrab_Meta()
	{
	}

	// Token: 0x17000569 RID: 1385
	// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x00005FE8 File Offset: 0x000041E8
	[Token(Token = "0x17000569")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000DC5")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700056A RID: 1386
	// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x00006000 File Offset: 0x00004200
	[Token(Token = "0x1700056A")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000DC6")]
		[Address(RVA = "0x867240", Offset = "0x865840", VA = "0x180867240", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700056B RID: 1387
	// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700056B")]
	private Type TypeObject
	{
		[Token(Token = "0x6000DC7")]
		[Address(RVA = "0x867260", Offset = "0x865860", VA = "0x180867260", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000DC8 RID: 3528 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DC8")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000DC9 RID: 3529 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DC9")]
	[Address(RVA = "0x867300", Offset = "0x865900", VA = "0x180867300", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000DCA RID: 3530 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DCA")]
	[Address(RVA = "0x867710", Offset = "0x865D10", VA = "0x180867710", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000DCB RID: 3531 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DCB")]
	[Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000286 RID: 646
	[Token(Token = "0x4000286")]
	[FieldOffset(Offset = "0x0")]
	internal static RaftGrab_Meta Instance;
}
