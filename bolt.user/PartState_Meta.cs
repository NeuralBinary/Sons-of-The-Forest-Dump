using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000068 RID: 104
[Token(Token = "0x2000068")]
internal class PartState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x0600038B RID: 907 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600038B")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public PartState_Meta()
	{
	}

	// Token: 0x170001D4 RID: 468
	// (get) Token: 0x0600038C RID: 908 RVA: 0x000033C0 File Offset: 0x000015C0
	[Token(Token = "0x170001D4")]
	private TypeId TypeId
	{
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170001D5 RID: 469
	// (get) Token: 0x0600038D RID: 909 RVA: 0x000033D8 File Offset: 0x000015D8
	[Token(Token = "0x170001D5")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x8076B0", Offset = "0x805CB0", VA = "0x1808076B0", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170001D6 RID: 470
	// (get) Token: 0x0600038E RID: 910 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170001D6")]
	private Type TypeObject
	{
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x8076D0", Offset = "0x805CD0", VA = "0x1808076D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600038F RID: 911 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600038F")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000390 RID: 912 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000390")]
	[Address(RVA = "0x807770", Offset = "0x805D70", VA = "0x180807770", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000391 RID: 913 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000391")]
	[Address(RVA = "0x807BD0", Offset = "0x8061D0", VA = "0x180807BD0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000245 RID: 581
	[Token(Token = "0x4000245")]
	[FieldOffset(Offset = "0x0")]
	internal static PartState_Meta Instance;
}
