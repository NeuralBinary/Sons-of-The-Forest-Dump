using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000262 RID: 610
[Token(Token = "0x2000262")]
internal class TrapActivateEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001C22 RID: 7202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C22")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public TrapActivateEvent_Meta()
	{
	}

	// Token: 0x170007D4 RID: 2004
	// (get) Token: 0x06001C23 RID: 7203 RVA: 0x00008718 File Offset: 0x00006918
	[Token(Token = "0x170007D4")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001C23")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170007D5 RID: 2005
	// (get) Token: 0x06001C24 RID: 7204 RVA: 0x00008730 File Offset: 0x00006930
	[Token(Token = "0x170007D5")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001C24")]
		[Address(RVA = "0x7E5C90", Offset = "0x7E4290", VA = "0x1807E5C90", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170007D6 RID: 2006
	// (get) Token: 0x06001C25 RID: 7205 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170007D6")]
	private Type TypeObject
	{
		[Token(Token = "0x6001C25")]
		[Address(RVA = "0x7E5CB0", Offset = "0x7E42B0", VA = "0x1807E5CB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001C26 RID: 7206 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C26")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001C27 RID: 7207 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C27")]
	[Address(RVA = "0x7E5D50", Offset = "0x7E4350", VA = "0x1807E5D50", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001C28 RID: 7208 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C28")]
	[Address(RVA = "0x7E5F40", Offset = "0x7E4540", VA = "0x1807E5F40", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001C29 RID: 7209 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C29")]
	[Address(RVA = "0x7E5FD0", Offset = "0x7E45D0", VA = "0x1807E5FD0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002EE RID: 750
	[Token(Token = "0x40002EE")]
	[FieldOffset(Offset = "0x0")]
	internal static TrapActivateEvent_Meta Instance;
}
