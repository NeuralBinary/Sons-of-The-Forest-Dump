using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000292 RID: 658
[Token(Token = "0x2000292")]
internal class FreeFormSwitchState_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001E2E RID: 7726 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E2E")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public FreeFormSwitchState_Meta()
	{
	}

	// Token: 0x17000828 RID: 2088
	// (get) Token: 0x06001E2F RID: 7727 RVA: 0x00008C70 File Offset: 0x00006E70
	[Token(Token = "0x17000828")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001E2F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000829 RID: 2089
	// (get) Token: 0x06001E30 RID: 7728 RVA: 0x00008C88 File Offset: 0x00006E88
	[Token(Token = "0x17000829")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001E30")]
		[Address(RVA = "0x7F53C0", Offset = "0x7F39C0", VA = "0x1807F53C0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700082A RID: 2090
	// (get) Token: 0x06001E31 RID: 7729 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700082A")]
	private Type TypeObject
	{
		[Token(Token = "0x6001E31")]
		[Address(RVA = "0x7F53E0", Offset = "0x7F39E0", VA = "0x1807F53E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001E32 RID: 7730 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E32")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001E33 RID: 7731 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E33")]
	[Address(RVA = "0x7F5480", Offset = "0x7F3A80", VA = "0x1807F5480", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001E34 RID: 7732 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E34")]
	[Address(RVA = "0x7F59D0", Offset = "0x7F3FD0", VA = "0x1807F59D0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001E35 RID: 7733 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E35")]
	[Address(RVA = "0x7F5A60", Offset = "0x7F4060", VA = "0x1807F5A60", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002FE RID: 766
	[Token(Token = "0x40002FE")]
	[FieldOffset(Offset = "0x0")]
	internal static FreeFormSwitchState_Meta Instance;
}
