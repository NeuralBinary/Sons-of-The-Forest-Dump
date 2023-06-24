using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001BA RID: 442
[Token(Token = "0x20001BA")]
internal class arrowFireSync_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001432 RID: 5170 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001432")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public arrowFireSync_Meta()
	{
	}

	// Token: 0x17000662 RID: 1634
	// (get) Token: 0x06001433 RID: 5171 RVA: 0x00006E10 File Offset: 0x00005010
	[Token(Token = "0x17000662")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001433")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000663 RID: 1635
	// (get) Token: 0x06001434 RID: 5172 RVA: 0x00006E28 File Offset: 0x00005028
	[Token(Token = "0x17000663")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001434")]
		[Address(RVA = "0x89BD80", Offset = "0x89A380", VA = "0x18089BD80", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000664 RID: 1636
	// (get) Token: 0x06001435 RID: 5173 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000664")]
	private Type TypeObject
	{
		[Token(Token = "0x6001435")]
		[Address(RVA = "0x89BDA0", Offset = "0x89A3A0", VA = "0x18089BDA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001436 RID: 5174 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001436")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001437 RID: 5175 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001437")]
	[Address(RVA = "0x89BE40", Offset = "0x89A440", VA = "0x18089BE40", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001438 RID: 5176 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001438")]
	[Address(RVA = "0x89C030", Offset = "0x89A630", VA = "0x18089C030", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001439 RID: 5177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001439")]
	[Address(RVA = "0x89C0C0", Offset = "0x89A6C0", VA = "0x18089C0C0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002B6 RID: 694
	[Token(Token = "0x40002B6")]
	[FieldOffset(Offset = "0x0")]
	internal static arrowFireSync_Meta Instance;
}
