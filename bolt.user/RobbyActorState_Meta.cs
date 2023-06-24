using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000A4 RID: 164
[Token(Token = "0x20000A4")]
internal class RobbyActorState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x06000726 RID: 1830 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000726")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public RobbyActorState_Meta()
	{
	}

	// Token: 0x170003F7 RID: 1015
	// (get) Token: 0x06000727 RID: 1831 RVA: 0x00004B90 File Offset: 0x00002D90
	[Token(Token = "0x170003F7")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170003F8 RID: 1016
	// (get) Token: 0x06000728 RID: 1832 RVA: 0x00004BA8 File Offset: 0x00002DA8
	[Token(Token = "0x170003F8")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x829320", Offset = "0x827920", VA = "0x180829320", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170003F9 RID: 1017
	// (get) Token: 0x06000729 RID: 1833 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170003F9")]
	private Type TypeObject
	{
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x829340", Offset = "0x827940", VA = "0x180829340", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600072A RID: 1834 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600072A")]
	[Address(RVA = "0x8293E0", Offset = "0x8279E0", VA = "0x1808293E0", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600072B RID: 1835 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600072B")]
	[Address(RVA = "0x829800", Offset = "0x827E00", VA = "0x180829800", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600072C RID: 1836 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600072C")]
	[Address(RVA = "0x82BF60", Offset = "0x82A560", VA = "0x18082BF60", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000259 RID: 601
	[Token(Token = "0x4000259")]
	[FieldOffset(Offset = "0x0")]
	internal static RobbyActorState_Meta Instance;
}
