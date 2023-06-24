using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000074 RID: 116
[Token(Token = "0x2000074")]
internal class Resin3dPrinterState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x060003D8 RID: 984 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public Resin3dPrinterState_Meta()
	{
	}

	// Token: 0x170001F5 RID: 501
	// (get) Token: 0x060003D9 RID: 985 RVA: 0x00003528 File Offset: 0x00001728
	[Token(Token = "0x170001F5")]
	private TypeId TypeId
	{
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170001F6 RID: 502
	// (get) Token: 0x060003DA RID: 986 RVA: 0x00003540 File Offset: 0x00001740
	[Token(Token = "0x170001F6")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x809E40", Offset = "0x808440", VA = "0x180809E40", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170001F7 RID: 503
	// (get) Token: 0x060003DB RID: 987 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170001F7")]
	private Type TypeObject
	{
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x809E60", Offset = "0x808460", VA = "0x180809E60", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060003DC RID: 988 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060003DD RID: 989 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x809F00", Offset = "0x808500", VA = "0x180809F00", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060003DE RID: 990 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x80A5B0", Offset = "0x808BB0", VA = "0x18080A5B0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000249 RID: 585
	[Token(Token = "0x4000249")]
	[FieldOffset(Offset = "0x0")]
	internal static Resin3dPrinterState_Meta Instance;
}
