using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200004A RID: 74
[Token(Token = "0x200004A")]
internal class CaveBoardsState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x060002D5 RID: 725 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public CaveBoardsState_Meta()
	{
	}

	// Token: 0x1700017A RID: 378
	// (get) Token: 0x060002D6 RID: 726 RVA: 0x00003090 File Offset: 0x00001290
	[Token(Token = "0x1700017A")]
	private TypeId TypeId
	{
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700017B RID: 379
	// (get) Token: 0x060002D7 RID: 727 RVA: 0x000030A8 File Offset: 0x000012A8
	[Token(Token = "0x1700017B")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x7D37C0", Offset = "0x7D1DC0", VA = "0x1807D37C0", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700017C RID: 380
	// (get) Token: 0x060002D8 RID: 728 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700017C")]
	private Type TypeObject
	{
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x7D37E0", Offset = "0x7D1DE0", VA = "0x1807D37E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060002DA RID: 730 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x7D3880", Offset = "0x7D1E80", VA = "0x1807D3880", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060002DB RID: 731 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x7D3BC0", Offset = "0x7D21C0", VA = "0x1807D3BC0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0400023B RID: 571
	[Token(Token = "0x400023B")]
	[FieldOffset(Offset = "0x0")]
	internal static CaveBoardsState_Meta Instance;
}
