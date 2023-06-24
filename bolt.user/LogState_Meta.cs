using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200006E RID: 110
[Token(Token = "0x200006E")]
internal class LogState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x060003AA RID: 938 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public LogState_Meta()
	{
	}

	// Token: 0x170001E1 RID: 481
	// (get) Token: 0x060003AB RID: 939 RVA: 0x00003438 File Offset: 0x00001638
	[Token(Token = "0x170001E1")]
	private TypeId TypeId
	{
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170001E2 RID: 482
	// (get) Token: 0x060003AC RID: 940 RVA: 0x00003450 File Offset: 0x00001650
	[Token(Token = "0x170001E2")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x808970", Offset = "0x806F70", VA = "0x180808970", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170001E3 RID: 483
	// (get) Token: 0x060003AD RID: 941 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170001E3")]
	private Type TypeObject
	{
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x808990", Offset = "0x806F90", VA = "0x180808990", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060003AE RID: 942 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060003AF RID: 943 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x808A30", Offset = "0x807030", VA = "0x180808A30", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x808F00", Offset = "0x807500", VA = "0x180808F00", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000247 RID: 583
	[Token(Token = "0x4000247")]
	[FieldOffset(Offset = "0x0")]
	internal static LogState_Meta Instance;
}
