using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000047 RID: 71
[Token(Token = "0x2000047")]
internal class MultiplayerInteractionState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x060002C4 RID: 708 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public MultiplayerInteractionState_Meta()
	{
	}

	// Token: 0x17000173 RID: 371
	// (get) Token: 0x060002C5 RID: 709 RVA: 0x00003030 File Offset: 0x00001230
	[Token(Token = "0x17000173")]
	private TypeId TypeId
	{
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000174 RID: 372
	// (get) Token: 0x060002C6 RID: 710 RVA: 0x00003048 File Offset: 0x00001248
	[Token(Token = "0x17000174")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x7D2CD0", Offset = "0x7D12D0", VA = "0x1807D2CD0", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000175 RID: 373
	// (get) Token: 0x060002C7 RID: 711 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000175")]
	private Type TypeObject
	{
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x7D2CF0", Offset = "0x7D12F0", VA = "0x1807D2CF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x7D2D90", Offset = "0x7D1390", VA = "0x1807D2D90", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x7D3030", Offset = "0x7D1630", VA = "0x1807D3030", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060002CA RID: 714 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x7D35C0", Offset = "0x7D1BC0", VA = "0x1807D35C0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0400023A RID: 570
	[Token(Token = "0x400023A")]
	[FieldOffset(Offset = "0x0")]
	internal static MultiplayerInteractionState_Meta Instance;
}
