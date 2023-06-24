using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200014B RID: 331
[Token(Token = "0x200014B")]
internal class DefaultClothPickedUp_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000F3E RID: 3902 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F3E")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public DefaultClothPickedUp_Meta()
	{
	}

	// Token: 0x170005A2 RID: 1442
	// (get) Token: 0x06000F3F RID: 3903 RVA: 0x00006330 File Offset: 0x00004530
	[Token(Token = "0x170005A2")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000F3F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170005A3 RID: 1443
	// (get) Token: 0x06000F40 RID: 3904 RVA: 0x00006348 File Offset: 0x00004548
	[Token(Token = "0x170005A3")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000F40")]
		[Address(RVA = "0x873920", Offset = "0x871F20", VA = "0x180873920", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170005A4 RID: 1444
	// (get) Token: 0x06000F41 RID: 3905 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170005A4")]
	private Type TypeObject
	{
		[Token(Token = "0x6000F41")]
		[Address(RVA = "0x873940", Offset = "0x871F40", VA = "0x180873940", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000F42 RID: 3906 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F42")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000F43 RID: 3907 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F43")]
	[Address(RVA = "0x8739E0", Offset = "0x871FE0", VA = "0x1808739E0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000F44 RID: 3908 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F44")]
	[Address(RVA = "0x873BD0", Offset = "0x8721D0", VA = "0x180873BD0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000F45 RID: 3909 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F45")]
	[Address(RVA = "0x873C60", Offset = "0x872260", VA = "0x180873C60", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000291 RID: 657
	[Token(Token = "0x4000291")]
	[FieldOffset(Offset = "0x0")]
	internal static DefaultClothPickedUp_Meta Instance;
}
