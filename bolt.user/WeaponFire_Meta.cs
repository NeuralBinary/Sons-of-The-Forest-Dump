using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000026 RID: 38
[Token(Token = "0x2000026")]
internal class WeaponFire_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public WeaponFire_Meta()
	{
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x060000D0 RID: 208 RVA: 0x00002568 File Offset: 0x00000768
	[Token(Token = "0x17000054")]
	private TypeId TypeId
	{
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x060000D1 RID: 209 RVA: 0x00002580 File Offset: 0x00000780
	[Token(Token = "0x17000055")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x7BD050", Offset = "0x7BB650", VA = "0x1807BD050", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x060000D2 RID: 210 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000056")]
	private Type TypeObject
	{
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x7BD070", Offset = "0x7BB670", VA = "0x1807BD070", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x7BD110", Offset = "0x7BB710", VA = "0x1807BD110", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x7BD630", Offset = "0x7BBC30", VA = "0x1807BD630", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0400022F RID: 559
	[Token(Token = "0x400022F")]
	[FieldOffset(Offset = "0x0")]
	internal static WeaponFire_Meta Instance;
}
