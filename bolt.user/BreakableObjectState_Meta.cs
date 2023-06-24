using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200007D RID: 125
[Token(Token = "0x200007D")]
internal class BreakableObjectState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x06000412 RID: 1042 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000412")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public BreakableObjectState_Meta()
	{
	}

	// Token: 0x1700020F RID: 527
	// (get) Token: 0x06000413 RID: 1043 RVA: 0x00003648 File Offset: 0x00001848
	[Token(Token = "0x1700020F")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000210 RID: 528
	// (get) Token: 0x06000414 RID: 1044 RVA: 0x00003660 File Offset: 0x00001860
	[Token(Token = "0x17000210")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x80BD80", Offset = "0x80A380", VA = "0x18080BD80", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000211 RID: 529
	// (get) Token: 0x06000415 RID: 1045 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000211")]
	private Type TypeObject
	{
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x80BDA0", Offset = "0x80A3A0", VA = "0x18080BDA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000416 RID: 1046 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000416")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000417 RID: 1047 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000417")]
	[Address(RVA = "0x80BE40", Offset = "0x80A440", VA = "0x18080BE40", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000418 RID: 1048 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000418")]
	[Address(RVA = "0x80C300", Offset = "0x80A900", VA = "0x18080C300", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0400024C RID: 588
	[Token(Token = "0x400024C")]
	[FieldOffset(Offset = "0x0")]
	internal static BreakableObjectState_Meta Instance;
}
