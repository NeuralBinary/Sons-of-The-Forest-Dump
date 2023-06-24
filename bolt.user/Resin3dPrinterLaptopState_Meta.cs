using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000B0 RID: 176
[Token(Token = "0x20000B0")]
internal class Resin3dPrinterLaptopState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x060007EF RID: 2031 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007EF")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public Resin3dPrinterLaptopState_Meta()
	{
	}

	// Token: 0x1700045C RID: 1116
	// (get) Token: 0x060007F0 RID: 2032 RVA: 0x00004F98 File Offset: 0x00003198
	[Token(Token = "0x1700045C")]
	private TypeId TypeId
	{
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700045D RID: 1117
	// (get) Token: 0x060007F1 RID: 2033 RVA: 0x00004FB0 File Offset: 0x000031B0
	[Token(Token = "0x1700045D")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x8330A0", Offset = "0x8316A0", VA = "0x1808330A0", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700045E RID: 1118
	// (get) Token: 0x060007F2 RID: 2034 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700045E")]
	private Type TypeObject
	{
		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x8330C0", Offset = "0x8316C0", VA = "0x1808330C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060007F3 RID: 2035 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F3")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060007F4 RID: 2036 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007F4")]
	[Address(RVA = "0x833160", Offset = "0x831760", VA = "0x180833160", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060007F5 RID: 2037 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60007F5")]
	[Address(RVA = "0x833920", Offset = "0x831F20", VA = "0x180833920", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0400025D RID: 605
	[Token(Token = "0x400025D")]
	[FieldOffset(Offset = "0x0")]
	internal static Resin3dPrinterLaptopState_Meta Instance;
}
