using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020002AD RID: 685
[Token(Token = "0x20002AD")]
internal class GolfCartConnectSlotEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001F42 RID: 8002 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F42")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public GolfCartConnectSlotEvent_Meta()
	{
	}

	// Token: 0x17000856 RID: 2134
	// (get) Token: 0x06001F43 RID: 8003 RVA: 0x00008F40 File Offset: 0x00007140
	[Token(Token = "0x17000856")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001F43")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000857 RID: 2135
	// (get) Token: 0x06001F44 RID: 8004 RVA: 0x00008F58 File Offset: 0x00007158
	[Token(Token = "0x17000857")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001F44")]
		[Address(RVA = "0x7FE530", Offset = "0x7FCB30", VA = "0x1807FE530", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000858 RID: 2136
	// (get) Token: 0x06001F45 RID: 8005 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000858")]
	private Type TypeObject
	{
		[Token(Token = "0x6001F45")]
		[Address(RVA = "0x7FE550", Offset = "0x7FCB50", VA = "0x1807FE550", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001F46 RID: 8006 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F46")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001F47 RID: 8007 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F47")]
	[Address(RVA = "0x7FE5F0", Offset = "0x7FCBF0", VA = "0x1807FE5F0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001F48 RID: 8008 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F48")]
	[Address(RVA = "0x7FEA10", Offset = "0x7FD010", VA = "0x1807FEA10", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001F49 RID: 8009 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F49")]
	[Address(RVA = "0x7FEAA0", Offset = "0x7FD0A0", VA = "0x1807FEAA0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000307 RID: 775
	[Token(Token = "0x4000307")]
	[FieldOffset(Offset = "0x0")]
	internal static GolfCartConnectSlotEvent_Meta Instance;
}
