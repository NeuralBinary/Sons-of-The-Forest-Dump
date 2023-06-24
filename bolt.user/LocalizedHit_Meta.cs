using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200011E RID: 286
[Token(Token = "0x200011E")]
internal class LocalizedHit_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000D3E RID: 3390 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D3E")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public LocalizedHit_Meta()
	{
	}

	// Token: 0x17000556 RID: 1366
	// (get) Token: 0x06000D3F RID: 3391 RVA: 0x00005EF8 File Offset: 0x000040F8
	[Token(Token = "0x17000556")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000D3F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000557 RID: 1367
	// (get) Token: 0x06000D40 RID: 3392 RVA: 0x00005F10 File Offset: 0x00004110
	[Token(Token = "0x17000557")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000D40")]
		[Address(RVA = "0x862BE0", Offset = "0x8611E0", VA = "0x180862BE0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000558 RID: 1368
	// (get) Token: 0x06000D41 RID: 3393 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000558")]
	private Type TypeObject
	{
		[Token(Token = "0x6000D41")]
		[Address(RVA = "0x862C00", Offset = "0x861200", VA = "0x180862C00", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000D42 RID: 3394 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D42")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000D43 RID: 3395 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D43")]
	[Address(RVA = "0x862CA0", Offset = "0x8612A0", VA = "0x180862CA0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000D44 RID: 3396 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D44")]
	[Address(RVA = "0x8632B0", Offset = "0x8618B0", VA = "0x1808632B0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000D45 RID: 3397 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D45")]
	[Address(RVA = "0x863340", Offset = "0x861940", VA = "0x180863340", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000282 RID: 642
	[Token(Token = "0x4000282")]
	[FieldOffset(Offset = "0x0")]
	internal static LocalizedHit_Meta Instance;
}
