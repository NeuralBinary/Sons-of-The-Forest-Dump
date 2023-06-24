using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000244 RID: 580
[Token(Token = "0x2000244")]
internal class ItemStorageRemoveItemEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001ACE RID: 6862 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ACE")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public ItemStorageRemoveItemEvent_Meta()
	{
	}

	// Token: 0x170007A0 RID: 1952
	// (get) Token: 0x06001ACF RID: 6863 RVA: 0x000083D0 File Offset: 0x000065D0
	[Token(Token = "0x170007A0")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001ACF")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170007A1 RID: 1953
	// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x000083E8 File Offset: 0x000065E8
	[Token(Token = "0x170007A1")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001AD0")]
		[Address(RVA = "0x7DAA00", Offset = "0x7D9000", VA = "0x1807DAA00", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170007A2 RID: 1954
	// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170007A2")]
	private Type TypeObject
	{
		[Token(Token = "0x6001AD1")]
		[Address(RVA = "0x7DAA20", Offset = "0x7D9020", VA = "0x1807DAA20", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001AD2 RID: 6866 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AD2")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001AD3 RID: 6867 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AD3")]
	[Address(RVA = "0x7DAAC0", Offset = "0x7D90C0", VA = "0x1807DAAC0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001AD4 RID: 6868 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AD4")]
	[Address(RVA = "0x7DB110", Offset = "0x7D9710", VA = "0x1807DB110", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001AD5 RID: 6869 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AD5")]
	[Address(RVA = "0x7DB1A0", Offset = "0x7D97A0", VA = "0x1807DB1A0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002E4 RID: 740
	[Token(Token = "0x40002E4")]
	[FieldOffset(Offset = "0x0")]
	internal static ItemStorageRemoveItemEvent_Meta Instance;
}
