using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000BE RID: 190
[Token(Token = "0x20000BE")]
internal class DropItem_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060008CC RID: 2252 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008CC")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public DropItem_Meta()
	{
	}

	// Token: 0x1700049B RID: 1179
	// (get) Token: 0x060008CD RID: 2253 RVA: 0x00005340 File Offset: 0x00003540
	[Token(Token = "0x1700049B")]
	private TypeId TypeId
	{
		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700049C RID: 1180
	// (get) Token: 0x060008CE RID: 2254 RVA: 0x00005358 File Offset: 0x00003558
	[Token(Token = "0x1700049C")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x83BA20", Offset = "0x83A020", VA = "0x18083BA20", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700049D RID: 1181
	// (get) Token: 0x060008CF RID: 2255 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700049D")]
	private Type TypeObject
	{
		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x83BA40", Offset = "0x83A040", VA = "0x18083BA40", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060008D0 RID: 2256 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008D0")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060008D1 RID: 2257 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008D1")]
	[Address(RVA = "0x83BAE0", Offset = "0x83A0E0", VA = "0x18083BAE0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060008D2 RID: 2258 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008D2")]
	[Address(RVA = "0x83C8B0", Offset = "0x83AEB0", VA = "0x18083C8B0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060008D3 RID: 2259 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008D3")]
	[Address(RVA = "0x83C940", Offset = "0x83AF40", VA = "0x18083C940", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000262 RID: 610
	[Token(Token = "0x4000262")]
	[FieldOffset(Offset = "0x0")]
	internal static DropItem_Meta Instance;
}
