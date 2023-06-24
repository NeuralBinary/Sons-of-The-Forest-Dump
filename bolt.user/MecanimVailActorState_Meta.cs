using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000089 RID: 137
[Token(Token = "0x2000089")]
internal class MecanimVailActorState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x060004E7 RID: 1255 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public MecanimVailActorState_Meta()
	{
	}

	// Token: 0x17000278 RID: 632
	// (get) Token: 0x060004E8 RID: 1256 RVA: 0x00003AE0 File Offset: 0x00001CE0
	[Token(Token = "0x17000278")]
	private TypeId TypeId
	{
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000279 RID: 633
	// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00003AF8 File Offset: 0x00001CF8
	[Token(Token = "0x17000279")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x812180", Offset = "0x810780", VA = "0x180812180", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700027A RID: 634
	// (get) Token: 0x060004EA RID: 1258 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700027A")]
	private Type TypeObject
	{
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x8121A0", Offset = "0x8107A0", VA = "0x1808121A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004EB")]
	[Address(RVA = "0x812240", Offset = "0x810840", VA = "0x180812240", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004EC")]
	[Address(RVA = "0x812570", Offset = "0x810B70", VA = "0x180812570", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060004ED RID: 1261 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60004ED")]
	[Address(RVA = "0x814AA0", Offset = "0x8130A0", VA = "0x180814AA0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000250 RID: 592
	[Token(Token = "0x4000250")]
	[FieldOffset(Offset = "0x0")]
	internal static MecanimVailActorState_Meta Instance;
}
