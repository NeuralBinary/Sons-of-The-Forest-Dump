using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000289 RID: 649
[Token(Token = "0x2000289")]
internal class RainCatcherIsBusy_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001DC4 RID: 7620 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DC4")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public RainCatcherIsBusy_Meta()
	{
	}

	// Token: 0x17000815 RID: 2069
	// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x00008B20 File Offset: 0x00006D20
	[Token(Token = "0x17000815")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001DC5")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000816 RID: 2070
	// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x00008B38 File Offset: 0x00006D38
	[Token(Token = "0x17000816")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001DC6")]
		[Address(RVA = "0x7F1C00", Offset = "0x7F0200", VA = "0x1807F1C00", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000817 RID: 2071
	// (get) Token: 0x06001DC7 RID: 7623 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000817")]
	private Type TypeObject
	{
		[Token(Token = "0x6001DC7")]
		[Address(RVA = "0x7F1C20", Offset = "0x7F0220", VA = "0x1807F1C20", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001DC8 RID: 7624 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DC8")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001DC9 RID: 7625 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DC9")]
	[Address(RVA = "0x7F1CC0", Offset = "0x7F02C0", VA = "0x1807F1CC0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001DCA RID: 7626 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DCA")]
	[Address(RVA = "0x7F1FB0", Offset = "0x7F05B0", VA = "0x1807F1FB0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001DCB RID: 7627 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DCB")]
	[Address(RVA = "0x7F2040", Offset = "0x7F0640", VA = "0x1807F2040", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002FB RID: 763
	[Token(Token = "0x40002FB")]
	[FieldOffset(Offset = "0x0")]
	internal static RainCatcherIsBusy_Meta Instance;
}
