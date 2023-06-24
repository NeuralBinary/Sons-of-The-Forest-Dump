using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000154 RID: 340
[Token(Token = "0x2000154")]
internal class TakeBodyApprove_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000F9E RID: 3998 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F9E")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public TakeBodyApprove_Meta()
	{
	}

	// Token: 0x170005AE RID: 1454
	// (get) Token: 0x06000F9F RID: 3999 RVA: 0x000063C0 File Offset: 0x000045C0
	[Token(Token = "0x170005AE")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000F9F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170005AF RID: 1455
	// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x000063D8 File Offset: 0x000045D8
	[Token(Token = "0x170005AF")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000FA0")]
		[Address(RVA = "0x876700", Offset = "0x874D00", VA = "0x180876700", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170005B0 RID: 1456
	// (get) Token: 0x06000FA1 RID: 4001 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170005B0")]
	private Type TypeObject
	{
		[Token(Token = "0x6000FA1")]
		[Address(RVA = "0x876720", Offset = "0x874D20", VA = "0x180876720", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000FA2 RID: 4002 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FA2")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000FA3 RID: 4003 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FA3")]
	[Address(RVA = "0x8767C0", Offset = "0x874DC0", VA = "0x1808767C0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000FA4 RID: 4004 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FA4")]
	[Address(RVA = "0x8769B0", Offset = "0x874FB0", VA = "0x1808769B0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000FA5 RID: 4005 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FA5")]
	[Address(RVA = "0x876A40", Offset = "0x875040", VA = "0x180876A40", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000294 RID: 660
	[Token(Token = "0x4000294")]
	[FieldOffset(Offset = "0x0")]
	internal static TakeBodyApprove_Meta Instance;
}
