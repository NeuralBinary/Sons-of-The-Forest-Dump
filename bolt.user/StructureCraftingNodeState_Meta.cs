using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200001A RID: 26
[Token(Token = "0x200001A")]
internal class StructureCraftingNodeState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x0600008B RID: 139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008B")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public StructureCraftingNodeState_Meta()
	{
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x0600008C RID: 140 RVA: 0x00002418 File Offset: 0x00000618
	[Token(Token = "0x17000036")]
	private TypeId TypeId
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x0600008D RID: 141 RVA: 0x00002430 File Offset: 0x00000630
	[Token(Token = "0x17000037")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x7BA910", Offset = "0x7B8F10", VA = "0x1807BA910", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x0600008E RID: 142 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000038")]
	private Type TypeObject
	{
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x7BA930", Offset = "0x7B8F30", VA = "0x1807BA930", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008F")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000090")]
	[Address(RVA = "0x7BA9D0", Offset = "0x7B8FD0", VA = "0x1807BA9D0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000091")]
	[Address(RVA = "0x7BABF0", Offset = "0x7B91F0", VA = "0x1807BABF0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0400022B RID: 555
	[Token(Token = "0x400022B")]
	[FieldOffset(Offset = "0x0")]
	internal static StructureCraftingNodeState_Meta Instance;
}
