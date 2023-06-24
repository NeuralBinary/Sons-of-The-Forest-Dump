using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000256 RID: 598
[Token(Token = "0x2000256")]
internal class VailReviveEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001B9A RID: 7066 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B9A")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public VailReviveEvent_Meta()
	{
	}

	// Token: 0x170007BE RID: 1982
	// (get) Token: 0x06001B9B RID: 7067 RVA: 0x000085B0 File Offset: 0x000067B0
	[Token(Token = "0x170007BE")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001B9B")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170007BF RID: 1983
	// (get) Token: 0x06001B9C RID: 7068 RVA: 0x000085C8 File Offset: 0x000067C8
	[Token(Token = "0x170007BF")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001B9C")]
		[Address(RVA = "0x7E1650", Offset = "0x7DFC50", VA = "0x1807E1650", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170007C0 RID: 1984
	// (get) Token: 0x06001B9D RID: 7069 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170007C0")]
	private Type TypeObject
	{
		[Token(Token = "0x6001B9D")]
		[Address(RVA = "0x7E1670", Offset = "0x7DFC70", VA = "0x1807E1670", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001B9E RID: 7070 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B9E")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001B9F RID: 7071 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B9F")]
	[Address(RVA = "0x7E1710", Offset = "0x7DFD10", VA = "0x1807E1710", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001BA0 RID: 7072 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BA0")]
	[Address(RVA = "0x7E1900", Offset = "0x7DFF00", VA = "0x1807E1900", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001BA1 RID: 7073 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BA1")]
	[Address(RVA = "0x7E1990", Offset = "0x7DFF90", VA = "0x1807E1990", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002EA RID: 746
	[Token(Token = "0x40002EA")]
	[FieldOffset(Offset = "0x0")]
	internal static VailReviveEvent_Meta Instance;
}
