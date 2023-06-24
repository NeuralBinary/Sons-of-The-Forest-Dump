using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000086 RID: 134
[Token(Token = "0x2000086")]
internal class WeaponUpgradeProxyState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x06000479 RID: 1145 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000479")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public WeaponUpgradeProxyState_Meta()
	{
	}

	// Token: 0x17000240 RID: 576
	// (get) Token: 0x0600047A RID: 1146 RVA: 0x00003858 File Offset: 0x00001A58
	[Token(Token = "0x17000240")]
	private TypeId TypeId
	{
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000241 RID: 577
	// (get) Token: 0x0600047B RID: 1147 RVA: 0x00003870 File Offset: 0x00001A70
	[Token(Token = "0x17000241")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x80F490", Offset = "0x80DA90", VA = "0x18080F490", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000242 RID: 578
	// (get) Token: 0x0600047C RID: 1148 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000242")]
	private Type TypeObject
	{
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x80F4B0", Offset = "0x80DAB0", VA = "0x18080F4B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600047D RID: 1149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600047D")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600047E")]
	[Address(RVA = "0x80F550", Offset = "0x80DB50", VA = "0x18080F550", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600047F")]
	[Address(RVA = "0x80FD00", Offset = "0x80E300", VA = "0x18080FD00", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0400024F RID: 591
	[Token(Token = "0x400024F")]
	[FieldOffset(Offset = "0x0")]
	internal static WeaponUpgradeProxyState_Meta Instance;
}
