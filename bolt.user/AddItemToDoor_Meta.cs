using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000157 RID: 343
[Token(Token = "0x2000157")]
internal class AddItemToDoor_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000FC2 RID: 4034 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FC2")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public AddItemToDoor_Meta()
	{
	}

	// Token: 0x170005B4 RID: 1460
	// (get) Token: 0x06000FC3 RID: 4035 RVA: 0x00006438 File Offset: 0x00004638
	[Token(Token = "0x170005B4")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000FC3")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170005B5 RID: 1461
	// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x00006450 File Offset: 0x00004650
	[Token(Token = "0x170005B5")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000FC4")]
		[Address(RVA = "0x877530", Offset = "0x875B30", VA = "0x180877530", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170005B6 RID: 1462
	// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170005B6")]
	private Type TypeObject
	{
		[Token(Token = "0x6000FC5")]
		[Address(RVA = "0x877550", Offset = "0x875B50", VA = "0x180877550", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000FC6 RID: 4038 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FC6")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000FC7 RID: 4039 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FC7")]
	[Address(RVA = "0x8775F0", Offset = "0x875BF0", VA = "0x1808775F0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000FC8 RID: 4040 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FC8")]
	[Address(RVA = "0x877A30", Offset = "0x876030", VA = "0x180877A30", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000FC9 RID: 4041 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FC9")]
	[Address(RVA = "0x877AC0", Offset = "0x8760C0", VA = "0x180877AC0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000295 RID: 661
	[Token(Token = "0x4000295")]
	[FieldOffset(Offset = "0x0")]
	internal static AddItemToDoor_Meta Instance;
}
