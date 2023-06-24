using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001AB RID: 427
[Token(Token = "0x20001AB")]
internal class ServerStatusInfo_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x0600138A RID: 5002 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600138A")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public ServerStatusInfo_Meta()
	{
	}

	// Token: 0x1700064A RID: 1610
	// (get) Token: 0x0600138B RID: 5003 RVA: 0x00006CF0 File Offset: 0x00004EF0
	[Token(Token = "0x1700064A")]
	private TypeId TypeId
	{
		[Token(Token = "0x600138B")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700064B RID: 1611
	// (get) Token: 0x0600138C RID: 5004 RVA: 0x00006D08 File Offset: 0x00004F08
	[Token(Token = "0x1700064B")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600138C")]
		[Address(RVA = "0x8969F0", Offset = "0x894FF0", VA = "0x1808969F0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700064C RID: 1612
	// (get) Token: 0x0600138D RID: 5005 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700064C")]
	private Type TypeObject
	{
		[Token(Token = "0x600138D")]
		[Address(RVA = "0x896A10", Offset = "0x895010", VA = "0x180896A10", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600138E RID: 5006 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600138E")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600138F RID: 5007 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600138F")]
	[Address(RVA = "0x896AB0", Offset = "0x8950B0", VA = "0x180896AB0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001390 RID: 5008 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001390")]
	[Address(RVA = "0x896CB0", Offset = "0x8952B0", VA = "0x180896CB0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001391 RID: 5009 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001391")]
	[Address(RVA = "0x896D40", Offset = "0x895340", VA = "0x180896D40", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002B1 RID: 689
	[Token(Token = "0x40002B1")]
	[FieldOffset(Offset = "0x0")]
	internal static ServerStatusInfo_Meta Instance;
}
