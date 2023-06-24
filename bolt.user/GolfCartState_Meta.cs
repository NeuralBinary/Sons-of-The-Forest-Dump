using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200005C RID: 92
[Token(Token = "0x200005C")]
internal class GolfCartState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x06000348 RID: 840 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000348")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public GolfCartState_Meta()
	{
	}

	// Token: 0x170001B3 RID: 435
	// (get) Token: 0x06000349 RID: 841 RVA: 0x000032B8 File Offset: 0x000014B8
	[Token(Token = "0x170001B3")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170001B4 RID: 436
	// (get) Token: 0x0600034A RID: 842 RVA: 0x000032D0 File Offset: 0x000014D0
	[Token(Token = "0x170001B4")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x803280", Offset = "0x801880", VA = "0x180803280", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170001B5 RID: 437
	// (get) Token: 0x0600034B RID: 843 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170001B5")]
	private Type TypeObject
	{
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x8032A0", Offset = "0x8018A0", VA = "0x1808032A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600034C RID: 844 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600034C")]
	[Address(RVA = "0x803340", Offset = "0x801940", VA = "0x180803340", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600034D RID: 845 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600034D")]
	[Address(RVA = "0x803490", Offset = "0x801A90", VA = "0x180803490", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600034E RID: 846 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600034E")]
	[Address(RVA = "0x804E90", Offset = "0x803490", VA = "0x180804E90", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000241 RID: 577
	[Token(Token = "0x4000241")]
	[FieldOffset(Offset = "0x0")]
	internal static GolfCartState_Meta Instance;
}
