using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000A1 RID: 161
[Token(Token = "0x20000A1")]
internal class TrapStructureState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x060006D9 RID: 1753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006D9")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public TrapStructureState_Meta()
	{
	}

	// Token: 0x170003CF RID: 975
	// (get) Token: 0x060006DA RID: 1754 RVA: 0x000048C0 File Offset: 0x00002AC0
	[Token(Token = "0x170003CF")]
	private TypeId TypeId
	{
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170003D0 RID: 976
	// (get) Token: 0x060006DB RID: 1755 RVA: 0x000048D8 File Offset: 0x00002AD8
	[Token(Token = "0x170003D0")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x827CD0", Offset = "0x8262D0", VA = "0x180827CD0", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170003D1 RID: 977
	// (get) Token: 0x060006DC RID: 1756 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170003D1")]
	private Type TypeObject
	{
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x827CF0", Offset = "0x8262F0", VA = "0x180827CF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060006DD RID: 1757 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006DD")]
	[Address(RVA = "0x827D90", Offset = "0x826390", VA = "0x180827D90", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060006DE RID: 1758 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006DE")]
	[Address(RVA = "0x828120", Offset = "0x826720", VA = "0x180828120", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060006DF RID: 1759 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60006DF")]
	[Address(RVA = "0x828A70", Offset = "0x827070", VA = "0x180828A70", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000258 RID: 600
	[Token(Token = "0x4000258")]
	[FieldOffset(Offset = "0x0")]
	internal static TrapStructureState_Meta Instance;
}
