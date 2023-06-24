using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000277 RID: 631
[Token(Token = "0x2000277")]
internal class PlayerRequestActorItem_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001D0E RID: 7438 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D0E")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public PlayerRequestActorItem_Meta()
	{
	}

	// Token: 0x170007F8 RID: 2040
	// (get) Token: 0x06001D0F RID: 7439 RVA: 0x00008940 File Offset: 0x00006B40
	[Token(Token = "0x170007F8")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001D0F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170007F9 RID: 2041
	// (get) Token: 0x06001D10 RID: 7440 RVA: 0x00008958 File Offset: 0x00006B58
	[Token(Token = "0x170007F9")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001D10")]
		[Address(RVA = "0x7ECE30", Offset = "0x7EB430", VA = "0x1807ECE30", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170007FA RID: 2042
	// (get) Token: 0x06001D11 RID: 7441 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170007FA")]
	private Type TypeObject
	{
		[Token(Token = "0x6001D11")]
		[Address(RVA = "0x7ECE50", Offset = "0x7EB450", VA = "0x1807ECE50", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001D12 RID: 7442 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D12")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001D13 RID: 7443 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D13")]
	[Address(RVA = "0x7ECEF0", Offset = "0x7EB4F0", VA = "0x1807ECEF0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001D14 RID: 7444 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D14")]
	[Address(RVA = "0x7ED320", Offset = "0x7EB920", VA = "0x1807ED320", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001D15 RID: 7445 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D15")]
	[Address(RVA = "0x7ED3B0", Offset = "0x7EB9B0", VA = "0x1807ED3B0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002F5 RID: 757
	[Token(Token = "0x40002F5")]
	[FieldOffset(Offset = "0x0")]
	internal static PlayerRequestActorItem_Meta Instance;
}
