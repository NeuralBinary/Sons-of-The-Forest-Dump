using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000223 RID: 547
[Token(Token = "0x2000223")]
internal class ActivateVailActor_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001932 RID: 6450 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001932")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public ActivateVailActor_Meta()
	{
	}

	// Token: 0x17000756 RID: 1878
	// (get) Token: 0x06001933 RID: 6451 RVA: 0x00007EF0 File Offset: 0x000060F0
	[Token(Token = "0x17000756")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001933")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000757 RID: 1879
	// (get) Token: 0x06001934 RID: 6452 RVA: 0x00007F08 File Offset: 0x00006108
	[Token(Token = "0x17000757")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001934")]
		[Address(RVA = "0x8C7290", Offset = "0x8C5890", VA = "0x1808C7290", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000758 RID: 1880
	// (get) Token: 0x06001935 RID: 6453 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000758")]
	private Type TypeObject
	{
		[Token(Token = "0x6001935")]
		[Address(RVA = "0x8C72B0", Offset = "0x8C58B0", VA = "0x1808C72B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001936 RID: 6454 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001936")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001937 RID: 6455 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001937")]
	[Address(RVA = "0x8C7350", Offset = "0x8C5950", VA = "0x1808C7350", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001938 RID: 6456 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001938")]
	[Address(RVA = "0x8C7640", Offset = "0x8C5C40", VA = "0x1808C7640", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001939 RID: 6457 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001939")]
	[Address(RVA = "0x8C76D0", Offset = "0x8C5CD0", VA = "0x1808C76D0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002D9 RID: 729
	[Token(Token = "0x40002D9")]
	[FieldOffset(Offset = "0x0")]
	internal static ActivateVailActor_Meta Instance;
}
