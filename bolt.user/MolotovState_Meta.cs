using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000023 RID: 35
[Token(Token = "0x2000023")]
internal class MolotovState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public MolotovState_Meta()
	{
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x060000BB RID: 187 RVA: 0x00002508 File Offset: 0x00000708
	[Token(Token = "0x1700004B")]
	private TypeId TypeId
	{
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x060000BC RID: 188 RVA: 0x00002520 File Offset: 0x00000720
	[Token(Token = "0x1700004C")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x7BC170", Offset = "0x7BA770", VA = "0x1807BC170", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x060000BD RID: 189 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700004D")]
	private Type TypeObject
	{
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x7BC190", Offset = "0x7BA790", VA = "0x1807BC190", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x7BC230", Offset = "0x7BA830", VA = "0x1807BC230", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x7BC800", Offset = "0x7BAE00", VA = "0x1807BC800", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0400022E RID: 558
	[Token(Token = "0x400022E")]
	[FieldOffset(Offset = "0x0")]
	internal static MolotovState_Meta Instance;
}
