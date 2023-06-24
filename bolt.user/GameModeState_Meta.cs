using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000A7 RID: 167
[Token(Token = "0x20000A7")]
internal class GameModeState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x0600073F RID: 1855 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600073F")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public GameModeState_Meta()
	{
	}

	// Token: 0x17000402 RID: 1026
	// (get) Token: 0x06000740 RID: 1856 RVA: 0x00004C20 File Offset: 0x00002E20
	[Token(Token = "0x17000402")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000403 RID: 1027
	// (get) Token: 0x06000741 RID: 1857 RVA: 0x00004C38 File Offset: 0x00002E38
	[Token(Token = "0x17000403")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x82C160", Offset = "0x82A760", VA = "0x18082C160", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000404 RID: 1028
	// (get) Token: 0x06000742 RID: 1858 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000404")]
	private Type TypeObject
	{
		[Token(Token = "0x6000742")]
		[Address(RVA = "0x82C180", Offset = "0x82A780", VA = "0x18082C180", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000743 RID: 1859 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000743")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000744 RID: 1860 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000744")]
	[Address(RVA = "0x82C220", Offset = "0x82A820", VA = "0x18082C220", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000745 RID: 1861 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000745")]
	[Address(RVA = "0x82C7D0", Offset = "0x82ADD0", VA = "0x18082C7D0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0400025A RID: 602
	[Token(Token = "0x400025A")]
	[FieldOffset(Offset = "0x0")]
	internal static GameModeState_Meta Instance;
}
