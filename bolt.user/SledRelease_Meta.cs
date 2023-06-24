using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200011B RID: 283
[Token(Token = "0x200011B")]
internal class SledRelease_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000D18 RID: 3352 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D18")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public SledRelease_Meta()
	{
	}

	// Token: 0x1700054F RID: 1359
	// (get) Token: 0x06000D19 RID: 3353 RVA: 0x00005E80 File Offset: 0x00004080
	[Token(Token = "0x1700054F")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000D19")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000550 RID: 1360
	// (get) Token: 0x06000D1A RID: 3354 RVA: 0x00005E98 File Offset: 0x00004098
	[Token(Token = "0x17000550")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000D1A")]
		[Address(RVA = "0x8615A0", Offset = "0x85FBA0", VA = "0x1808615A0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000551 RID: 1361
	// (get) Token: 0x06000D1B RID: 3355 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000551")]
	private Type TypeObject
	{
		[Token(Token = "0x6000D1B")]
		[Address(RVA = "0x8615C0", Offset = "0x85FBC0", VA = "0x1808615C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000D1C RID: 3356 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D1C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000D1D RID: 3357 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D1D")]
	[Address(RVA = "0x861660", Offset = "0x85FC60", VA = "0x180861660", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000D1E RID: 3358 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D1E")]
	[Address(RVA = "0x861C60", Offset = "0x860260", VA = "0x180861C60", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000D1F RID: 3359 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D1F")]
	[Address(RVA = "0x861CF0", Offset = "0x8602F0", VA = "0x180861CF0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000281 RID: 641
	[Token(Token = "0x4000281")]
	[FieldOffset(Offset = "0x0")]
	internal static SledRelease_Meta Instance;
}
