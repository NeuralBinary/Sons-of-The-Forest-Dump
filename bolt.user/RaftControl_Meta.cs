using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200015A RID: 346
[Token(Token = "0x200015A")]
internal class RaftControl_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000FE8 RID: 4072 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FE8")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public RaftControl_Meta()
	{
	}

	// Token: 0x170005BB RID: 1467
	// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x000064B0 File Offset: 0x000046B0
	[Token(Token = "0x170005BB")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000FE9")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170005BC RID: 1468
	// (get) Token: 0x06000FEA RID: 4074 RVA: 0x000064C8 File Offset: 0x000046C8
	[Token(Token = "0x170005BC")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000FEA")]
		[Address(RVA = "0x878AD0", Offset = "0x8770D0", VA = "0x180878AD0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170005BD RID: 1469
	// (get) Token: 0x06000FEB RID: 4075 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170005BD")]
	private Type TypeObject
	{
		[Token(Token = "0x6000FEB")]
		[Address(RVA = "0x878AF0", Offset = "0x8770F0", VA = "0x180878AF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000FEC RID: 4076 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FEC")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000FED RID: 4077 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FED")]
	[Address(RVA = "0x878B90", Offset = "0x877190", VA = "0x180878B90", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000FEE RID: 4078 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FEE")]
	[Address(RVA = "0x8790F0", Offset = "0x8776F0", VA = "0x1808790F0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000FEF RID: 4079 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FEF")]
	[Address(RVA = "0x879180", Offset = "0x877780", VA = "0x180879180", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000296 RID: 662
	[Token(Token = "0x4000296")]
	[FieldOffset(Offset = "0x0")]
	internal static RaftControl_Meta Instance;
}
