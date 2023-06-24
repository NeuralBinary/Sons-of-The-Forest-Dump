using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200012D RID: 301
[Token(Token = "0x200012D")]
internal class RaftRelease_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000DEC RID: 3564 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DEC")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public RaftRelease_Meta()
	{
	}

	// Token: 0x17000571 RID: 1393
	// (get) Token: 0x06000DED RID: 3565 RVA: 0x00006060 File Offset: 0x00004260
	[Token(Token = "0x17000571")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000DED")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000572 RID: 1394
	// (get) Token: 0x06000DEE RID: 3566 RVA: 0x00006078 File Offset: 0x00004278
	[Token(Token = "0x17000572")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000DEE")]
		[Address(RVA = "0x8689E0", Offset = "0x866FE0", VA = "0x1808689E0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000573 RID: 1395
	// (get) Token: 0x06000DEF RID: 3567 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000573")]
	private Type TypeObject
	{
		[Token(Token = "0x6000DEF")]
		[Address(RVA = "0x868A00", Offset = "0x867000", VA = "0x180868A00", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000DF0 RID: 3568 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DF0")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000DF1 RID: 3569 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DF1")]
	[Address(RVA = "0x868AA0", Offset = "0x8670A0", VA = "0x180868AA0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000DF2 RID: 3570 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DF2")]
	[Address(RVA = "0x8691D0", Offset = "0x8677D0", VA = "0x1808691D0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000DF3 RID: 3571 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DF3")]
	[Address(RVA = "0x869260", Offset = "0x867860", VA = "0x180869260", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000287 RID: 647
	[Token(Token = "0x4000287")]
	[FieldOffset(Offset = "0x0")]
	internal static RaftRelease_Meta Instance;
}
