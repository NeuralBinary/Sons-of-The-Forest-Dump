using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000059 RID: 89
[Token(Token = "0x2000059")]
internal class FreeFormManagerState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x06000317 RID: 791 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000317")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public FreeFormManagerState_Meta()
	{
	}

	// Token: 0x17000196 RID: 406
	// (get) Token: 0x06000318 RID: 792 RVA: 0x000031E0 File Offset: 0x000013E0
	[Token(Token = "0x17000196")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000197 RID: 407
	// (get) Token: 0x06000319 RID: 793 RVA: 0x000031F8 File Offset: 0x000013F8
	[Token(Token = "0x17000197")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x7D5C30", Offset = "0x7D4230", VA = "0x1807D5C30", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000198 RID: 408
	// (get) Token: 0x0600031A RID: 794 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000198")]
	private Type TypeObject
	{
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x7D5C50", Offset = "0x7D4250", VA = "0x1807D5C50", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600031B RID: 795 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600031B")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600031C RID: 796 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600031C")]
	[Address(RVA = "0x7D5CF0", Offset = "0x7D42F0", VA = "0x1807D5CF0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600031D RID: 797 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600031D")]
	[Address(RVA = "0x7D5DC0", Offset = "0x7D43C0", VA = "0x1807D5DC0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000240 RID: 576
	[Token(Token = "0x4000240")]
	[FieldOffset(Offset = "0x0")]
	internal static FreeFormManagerState_Meta Instance;
}
