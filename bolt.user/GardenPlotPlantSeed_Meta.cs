using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200013C RID: 316
[Token(Token = "0x200013C")]
internal class GardenPlotPlantSeed_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000E94 RID: 3732 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E94")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public GardenPlotPlantSeed_Meta()
	{
	}

	// Token: 0x17000589 RID: 1417
	// (get) Token: 0x06000E95 RID: 3733 RVA: 0x000061C8 File Offset: 0x000043C8
	[Token(Token = "0x17000589")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000E95")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700058A RID: 1418
	// (get) Token: 0x06000E96 RID: 3734 RVA: 0x000061E0 File Offset: 0x000043E0
	[Token(Token = "0x1700058A")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000E96")]
		[Address(RVA = "0x86E060", Offset = "0x86C660", VA = "0x18086E060", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700058B RID: 1419
	// (get) Token: 0x06000E97 RID: 3735 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700058B")]
	private Type TypeObject
	{
		[Token(Token = "0x6000E97")]
		[Address(RVA = "0x86E080", Offset = "0x86C680", VA = "0x18086E080", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E98 RID: 3736 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E98")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000E99 RID: 3737 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E99")]
	[Address(RVA = "0x86E120", Offset = "0x86C720", VA = "0x18086E120", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000E9A RID: 3738 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E9A")]
	[Address(RVA = "0x86E420", Offset = "0x86CA20", VA = "0x18086E420", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000E9B RID: 3739 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E9B")]
	[Address(RVA = "0x86E4B0", Offset = "0x86CAB0", VA = "0x18086E4B0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400028C RID: 652
	[Token(Token = "0x400028C")]
	[FieldOffset(Offset = "0x0")]
	internal static GardenPlotPlantSeed_Meta Instance;
}
