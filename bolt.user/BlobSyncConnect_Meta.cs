using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000295 RID: 661
[Token(Token = "0x2000295")]
internal class BlobSyncConnect_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001E4C RID: 7756 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E4C")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public BlobSyncConnect_Meta()
	{
	}

	// Token: 0x1700082D RID: 2093
	// (get) Token: 0x06001E4D RID: 7757 RVA: 0x00008CD0 File Offset: 0x00006ED0
	[Token(Token = "0x1700082D")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001E4D")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700082E RID: 2094
	// (get) Token: 0x06001E4E RID: 7758 RVA: 0x00008CE8 File Offset: 0x00006EE8
	[Token(Token = "0x1700082E")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001E4E")]
		[Address(RVA = "0x7F6240", Offset = "0x7F4840", VA = "0x1807F6240", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700082F RID: 2095
	// (get) Token: 0x06001E4F RID: 7759 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700082F")]
	private Type TypeObject
	{
		[Token(Token = "0x6001E4F")]
		[Address(RVA = "0x7F6260", Offset = "0x7F4860", VA = "0x1807F6260", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001E50 RID: 7760 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E50")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001E51 RID: 7761 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E51")]
	[Address(RVA = "0x7F6300", Offset = "0x7F4900", VA = "0x1807F6300", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001E52 RID: 7762 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E52")]
	[Address(RVA = "0x7F6610", Offset = "0x7F4C10", VA = "0x1807F6610", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001E53 RID: 7763 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E53")]
	[Address(RVA = "0x7F66A0", Offset = "0x7F4CA0", VA = "0x1807F66A0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002FF RID: 767
	[Token(Token = "0x40002FF")]
	[FieldOffset(Offset = "0x0")]
	internal static BlobSyncConnect_Meta Instance;
}
