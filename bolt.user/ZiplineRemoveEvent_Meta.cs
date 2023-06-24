using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000250 RID: 592
[Token(Token = "0x2000250")]
internal class ZiplineRemoveEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001B5A RID: 7002 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B5A")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public ZiplineRemoveEvent_Meta()
	{
	}

	// Token: 0x170007B6 RID: 1974
	// (get) Token: 0x06001B5B RID: 7003 RVA: 0x00008550 File Offset: 0x00006750
	[Token(Token = "0x170007B6")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001B5B")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170007B7 RID: 1975
	// (get) Token: 0x06001B5C RID: 7004 RVA: 0x00008568 File Offset: 0x00006768
	[Token(Token = "0x170007B7")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001B5C")]
		[Address(RVA = "0x7DF850", Offset = "0x7DDE50", VA = "0x1807DF850", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170007B8 RID: 1976
	// (get) Token: 0x06001B5D RID: 7005 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170007B8")]
	private Type TypeObject
	{
		[Token(Token = "0x6001B5D")]
		[Address(RVA = "0x7DF870", Offset = "0x7DDE70", VA = "0x1807DF870", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001B5E RID: 7006 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B5E")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001B5F RID: 7007 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B5F")]
	[Address(RVA = "0x7DF910", Offset = "0x7DDF10", VA = "0x1807DF910", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001B60 RID: 7008 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B60")]
	[Address(RVA = "0x7DFB00", Offset = "0x7DE100", VA = "0x1807DFB00", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001B61 RID: 7009 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B61")]
	[Address(RVA = "0x7DFB90", Offset = "0x7DE190", VA = "0x1807DFB90", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002E8 RID: 744
	[Token(Token = "0x40002E8")]
	[FieldOffset(Offset = "0x0")]
	internal static ZiplineRemoveEvent_Meta Instance;
}
