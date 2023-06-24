using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000077 RID: 119
[Token(Token = "0x2000077")]
internal class AnimationSequenceState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x060003F5 RID: 1013 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public AnimationSequenceState_Meta()
	{
	}

	// Token: 0x17000202 RID: 514
	// (get) Token: 0x060003F6 RID: 1014 RVA: 0x000035B8 File Offset: 0x000017B8
	[Token(Token = "0x17000202")]
	private TypeId TypeId
	{
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000203 RID: 515
	// (get) Token: 0x060003F7 RID: 1015 RVA: 0x000035D0 File Offset: 0x000017D0
	[Token(Token = "0x17000203")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x80AAB0", Offset = "0x8090B0", VA = "0x18080AAB0", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000204 RID: 516
	// (get) Token: 0x060003F8 RID: 1016 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000204")]
	private Type TypeObject
	{
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x80AAD0", Offset = "0x8090D0", VA = "0x18080AAD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060003F9 RID: 1017 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060003FA RID: 1018 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x80AB70", Offset = "0x809170", VA = "0x18080AB70", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060003FB RID: 1019 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x80B220", Offset = "0x809820", VA = "0x18080B220", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0400024A RID: 586
	[Token(Token = "0x400024A")]
	[FieldOffset(Offset = "0x0")]
	internal static AnimationSequenceState_Meta Instance;
}
