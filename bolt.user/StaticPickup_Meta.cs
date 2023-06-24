using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200005F RID: 95
[Token(Token = "0x200005F")]
internal class StaticPickup_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x06000355 RID: 853 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000355")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public StaticPickup_Meta()
	{
	}

	// Token: 0x170001B8 RID: 440
	// (get) Token: 0x06000356 RID: 854 RVA: 0x00003300 File Offset: 0x00001500
	[Token(Token = "0x170001B8")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170001B9 RID: 441
	// (get) Token: 0x06000357 RID: 855 RVA: 0x00003318 File Offset: 0x00001518
	[Token(Token = "0x170001B9")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x805090", Offset = "0x803690", VA = "0x180805090", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170001BA RID: 442
	// (get) Token: 0x06000358 RID: 856 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170001BA")]
	private Type TypeObject
	{
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x8050B0", Offset = "0x8036B0", VA = "0x1808050B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000359 RID: 857 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000359")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600035A RID: 858 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600035A")]
	[Address(RVA = "0x805150", Offset = "0x803750", VA = "0x180805150", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600035B RID: 859 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600035B")]
	[Address(RVA = "0x805360", Offset = "0x803960", VA = "0x180805360", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000242 RID: 578
	[Token(Token = "0x4000242")]
	[FieldOffset(Offset = "0x0")]
	internal static StaticPickup_Meta Instance;
}
