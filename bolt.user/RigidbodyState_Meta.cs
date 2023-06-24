using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200001D RID: 29
[Token(Token = "0x200001D")]
internal class RigidbodyState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000096")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public RigidbodyState_Meta()
	{
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x06000097 RID: 151 RVA: 0x00002448 File Offset: 0x00000648
	[Token(Token = "0x1700003B")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x06000098 RID: 152 RVA: 0x00002460 File Offset: 0x00000660
	[Token(Token = "0x1700003C")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x7BAE50", Offset = "0x7B9450", VA = "0x1807BAE50", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x06000099 RID: 153 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700003D")]
	private Type TypeObject
	{
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x7BAE70", Offset = "0x7B9470", VA = "0x1807BAE70", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009A")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009B")]
	[Address(RVA = "0x7BAF10", Offset = "0x7B9510", VA = "0x1807BAF10", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600009C")]
	[Address(RVA = "0x7BB2C0", Offset = "0x7B98C0", VA = "0x1807BB2C0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0400022C RID: 556
	[Token(Token = "0x400022C")]
	[FieldOffset(Offset = "0x0")]
	internal static RigidbodyState_Meta Instance;
}
