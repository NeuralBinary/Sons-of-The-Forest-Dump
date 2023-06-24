using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000D6 RID: 214
[Token(Token = "0x20000D6")]
internal class FireCookEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060009FE RID: 2558 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009FE")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public FireCookEvent_Meta()
	{
	}

	// Token: 0x170004D6 RID: 1238
	// (get) Token: 0x060009FF RID: 2559 RVA: 0x00005730 File Offset: 0x00003930
	[Token(Token = "0x170004D6")]
	private TypeId TypeId
	{
		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170004D7 RID: 1239
	// (get) Token: 0x06000A00 RID: 2560 RVA: 0x00005748 File Offset: 0x00003948
	[Token(Token = "0x170004D7")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x847BC0", Offset = "0x8461C0", VA = "0x180847BC0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170004D8 RID: 1240
	// (get) Token: 0x06000A01 RID: 2561 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170004D8")]
	private Type TypeObject
	{
		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x847BE0", Offset = "0x8461E0", VA = "0x180847BE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A02")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000A03 RID: 2563 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A03")]
	[Address(RVA = "0x847C80", Offset = "0x846280", VA = "0x180847C80", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000A04 RID: 2564 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A04")]
	[Address(RVA = "0x8480A0", Offset = "0x8466A0", VA = "0x1808480A0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A05")]
	[Address(RVA = "0x848130", Offset = "0x846730", VA = "0x180848130", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400026A RID: 618
	[Token(Token = "0x400026A")]
	[FieldOffset(Offset = "0x0")]
	internal static FireCookEvent_Meta Instance;
}
