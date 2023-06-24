using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001CF RID: 463
[Token(Token = "0x20001CF")]
internal class FreeFormRequestAllData_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x0600151E RID: 5406 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600151E")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public FreeFormRequestAllData_Meta()
	{
	}

	// Token: 0x1700068E RID: 1678
	// (get) Token: 0x0600151F RID: 5407 RVA: 0x00007128 File Offset: 0x00005328
	[Token(Token = "0x1700068E")]
	private TypeId TypeId
	{
		[Token(Token = "0x600151F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700068F RID: 1679
	// (get) Token: 0x06001520 RID: 5408 RVA: 0x00007140 File Offset: 0x00005340
	[Token(Token = "0x1700068F")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001520")]
		[Address(RVA = "0x8A3680", Offset = "0x8A1C80", VA = "0x1808A3680", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000690 RID: 1680
	// (get) Token: 0x06001521 RID: 5409 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000690")]
	private Type TypeObject
	{
		[Token(Token = "0x6001521")]
		[Address(RVA = "0x8A36A0", Offset = "0x8A1CA0", VA = "0x1808A36A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001522 RID: 5410 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001522")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001523 RID: 5411 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001523")]
	[Address(RVA = "0x8A3740", Offset = "0x8A1D40", VA = "0x1808A3740", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001524 RID: 5412 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001524")]
	[Address(RVA = "0x8A37F0", Offset = "0x8A1DF0", VA = "0x1808A37F0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001525 RID: 5413 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001525")]
	[Address(RVA = "0x8A3880", Offset = "0x8A1E80", VA = "0x1808A3880", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002BD RID: 701
	[Token(Token = "0x40002BD")]
	[FieldOffset(Offset = "0x0")]
	internal static FreeFormRequestAllData_Meta Instance;
}
