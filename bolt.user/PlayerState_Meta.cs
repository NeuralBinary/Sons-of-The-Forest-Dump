using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000041 RID: 65
[Token(Token = "0x2000041")]
internal class PlayerState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x060002A2 RID: 674 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public PlayerState_Meta()
	{
	}

	// Token: 0x17000163 RID: 355
	// (get) Token: 0x060002A3 RID: 675 RVA: 0x00002FA0 File Offset: 0x000011A0
	[Token(Token = "0x17000163")]
	private TypeId TypeId
	{
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000164 RID: 356
	// (get) Token: 0x060002A4 RID: 676 RVA: 0x00002FB8 File Offset: 0x000011B8
	[Token(Token = "0x17000164")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x7CACC0", Offset = "0x7C92C0", VA = "0x1807CACC0", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000165 RID: 357
	// (get) Token: 0x060002A5 RID: 677 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000165")]
	private Type TypeObject
	{
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x7CACE0", Offset = "0x7C92E0", VA = "0x1807CACE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x7CAD80", Offset = "0x7C9380", VA = "0x1807CAD80", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x7CBDD0", Offset = "0x7CA3D0", VA = "0x1807CBDD0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x7D2050", Offset = "0x7D0650", VA = "0x1807D2050", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000238 RID: 568
	[Token(Token = "0x4000238")]
	[FieldOffset(Offset = "0x0")]
	internal static PlayerState_Meta Instance;
}
