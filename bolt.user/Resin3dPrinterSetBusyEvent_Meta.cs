using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200026B RID: 619
[Token(Token = "0x200026B")]
internal class Resin3dPrinterSetBusyEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001C86 RID: 7302 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C86")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public Resin3dPrinterSetBusyEvent_Meta()
	{
	}

	// Token: 0x170007E2 RID: 2018
	// (get) Token: 0x06001C87 RID: 7303 RVA: 0x000087D8 File Offset: 0x000069D8
	[Token(Token = "0x170007E2")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001C87")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170007E3 RID: 2019
	// (get) Token: 0x06001C88 RID: 7304 RVA: 0x000087F0 File Offset: 0x000069F0
	[Token(Token = "0x170007E3")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001C88")]
		[Address(RVA = "0x7E8C20", Offset = "0x7E7220", VA = "0x1807E8C20", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170007E4 RID: 2020
	// (get) Token: 0x06001C89 RID: 7305 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170007E4")]
	private Type TypeObject
	{
		[Token(Token = "0x6001C89")]
		[Address(RVA = "0x7E8C40", Offset = "0x7E7240", VA = "0x1807E8C40", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001C8A RID: 7306 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C8A")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001C8B RID: 7307 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C8B")]
	[Address(RVA = "0x7E8CE0", Offset = "0x7E72E0", VA = "0x1807E8CE0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001C8C RID: 7308 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C8C")]
	[Address(RVA = "0x7E8FD0", Offset = "0x7E75D0", VA = "0x1807E8FD0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001C8D RID: 7309 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C8D")]
	[Address(RVA = "0x7E9060", Offset = "0x7E7660", VA = "0x1807E9060", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002F1 RID: 753
	[Token(Token = "0x40002F1")]
	[FieldOffset(Offset = "0x0")]
	internal static Resin3dPrinterSetBusyEvent_Meta Instance;
}
