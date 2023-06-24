using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000AA RID: 170
[Token(Token = "0x20000AA")]
internal class CoopServerInfo_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x060007B2 RID: 1970 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007B2")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public CoopServerInfo_Meta()
	{
	}

	// Token: 0x1700043F RID: 1087
	// (get) Token: 0x060007B3 RID: 1971 RVA: 0x00004E78 File Offset: 0x00003078
	[Token(Token = "0x1700043F")]
	private TypeId TypeId
	{
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000440 RID: 1088
	// (get) Token: 0x060007B4 RID: 1972 RVA: 0x00004E90 File Offset: 0x00003090
	[Token(Token = "0x17000440")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x82EBD0", Offset = "0x82D1D0", VA = "0x18082EBD0", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000441 RID: 1089
	// (get) Token: 0x060007B5 RID: 1973 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000441")]
	private Type TypeObject
	{
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x82EBF0", Offset = "0x82D1F0", VA = "0x18082EBF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007B6")]
	[Address(RVA = "0x82EC90", Offset = "0x82D290", VA = "0x18082EC90", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007B7")]
	[Address(RVA = "0x82F1A0", Offset = "0x82D7A0", VA = "0x18082F1A0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60007B8")]
	[Address(RVA = "0x8313D0", Offset = "0x82F9D0", VA = "0x1808313D0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0400025B RID: 603
	[Token(Token = "0x400025B")]
	[FieldOffset(Offset = "0x0")]
	internal static CoopServerInfo_Meta Instance;
}
