using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000B3 RID: 179
[Token(Token = "0x20000B3")]
internal class FireState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x06000826 RID: 2086 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000826")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public FireState_Meta()
	{
	}

	// Token: 0x17000477 RID: 1143
	// (get) Token: 0x06000827 RID: 2087 RVA: 0x000050B8 File Offset: 0x000032B8
	[Token(Token = "0x17000477")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000827")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000478 RID: 1144
	// (get) Token: 0x06000828 RID: 2088 RVA: 0x000050D0 File Offset: 0x000032D0
	[Token(Token = "0x17000478")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x8347E0", Offset = "0x832DE0", VA = "0x1808347E0", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000479 RID: 1145
	// (get) Token: 0x06000829 RID: 2089 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000479")]
	private Type TypeObject
	{
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x834800", Offset = "0x832E00", VA = "0x180834800", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600082A RID: 2090 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600082A")]
	[Address(RVA = "0x8348A0", Offset = "0x832EA0", VA = "0x1808348A0", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600082B RID: 2091 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600082B")]
	[Address(RVA = "0x834B00", Offset = "0x833100", VA = "0x180834B00", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600082C RID: 2092 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600082C")]
	[Address(RVA = "0x835A20", Offset = "0x834020", VA = "0x180835A20", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0400025E RID: 606
	[Token(Token = "0x400025E")]
	[FieldOffset(Offset = "0x0")]
	internal static FireState_Meta Instance;
}
