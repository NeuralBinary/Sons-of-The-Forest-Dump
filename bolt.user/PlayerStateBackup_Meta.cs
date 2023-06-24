using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000092 RID: 146
[Token(Token = "0x2000092")]
internal class PlayerStateBackup_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x0600066F RID: 1647 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600066F")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public PlayerStateBackup_Meta()
	{
	}

	// Token: 0x1700039D RID: 925
	// (get) Token: 0x06000670 RID: 1648 RVA: 0x000046F8 File Offset: 0x000028F8
	[Token(Token = "0x1700039D")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000670")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700039E RID: 926
	// (get) Token: 0x06000671 RID: 1649 RVA: 0x00004710 File Offset: 0x00002910
	[Token(Token = "0x1700039E")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000671")]
		[Address(RVA = "0x81B650", Offset = "0x819C50", VA = "0x18081B650", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700039F RID: 927
	// (get) Token: 0x06000672 RID: 1650 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700039F")]
	private Type TypeObject
	{
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x81B670", Offset = "0x819C70", VA = "0x18081B670", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000673")]
	[Address(RVA = "0x81B710", Offset = "0x819D10", VA = "0x18081B710", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000674")]
	[Address(RVA = "0x81BDC0", Offset = "0x81A3C0", VA = "0x18081BDC0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000675")]
	[Address(RVA = "0x823BF0", Offset = "0x8221F0", VA = "0x180823BF0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000253 RID: 595
	[Token(Token = "0x4000253")]
	[FieldOffset(Offset = "0x0")]
	internal static PlayerStateBackup_Meta Instance;
}
