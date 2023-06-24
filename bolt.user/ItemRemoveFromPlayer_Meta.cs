using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000121 RID: 289
[Token(Token = "0x2000121")]
internal class ItemRemoveFromPlayer_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000D5E RID: 3422 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D5E")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public ItemRemoveFromPlayer_Meta()
	{
	}

	// Token: 0x1700055A RID: 1370
	// (get) Token: 0x06000D5F RID: 3423 RVA: 0x00005F40 File Offset: 0x00004140
	[Token(Token = "0x1700055A")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000D5F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700055B RID: 1371
	// (get) Token: 0x06000D60 RID: 3424 RVA: 0x00005F58 File Offset: 0x00004158
	[Token(Token = "0x1700055B")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000D60")]
		[Address(RVA = "0x863D50", Offset = "0x862350", VA = "0x180863D50", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700055C RID: 1372
	// (get) Token: 0x06000D61 RID: 3425 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700055C")]
	private Type TypeObject
	{
		[Token(Token = "0x6000D61")]
		[Address(RVA = "0x863D70", Offset = "0x862370", VA = "0x180863D70", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000D62 RID: 3426 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D62")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000D63 RID: 3427 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D63")]
	[Address(RVA = "0x863E10", Offset = "0x862410", VA = "0x180863E10", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000D64 RID: 3428 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D64")]
	[Address(RVA = "0x864010", Offset = "0x862610", VA = "0x180864010", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000D65 RID: 3429 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D65")]
	[Address(RVA = "0x8640A0", Offset = "0x8626A0", VA = "0x1808640A0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000283 RID: 643
	[Token(Token = "0x4000283")]
	[FieldOffset(Offset = "0x0")]
	internal static ItemRemoveFromPlayer_Meta Instance;
}
