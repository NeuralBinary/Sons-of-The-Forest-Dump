using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000065 RID: 101
[Token(Token = "0x2000065")]
internal class TreeFallState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x0600037C RID: 892 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600037C")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public TreeFallState_Meta()
	{
	}

	// Token: 0x170001CD RID: 461
	// (get) Token: 0x0600037D RID: 893 RVA: 0x00003390 File Offset: 0x00001590
	[Token(Token = "0x170001CD")]
	private TypeId TypeId
	{
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170001CE RID: 462
	// (get) Token: 0x0600037E RID: 894 RVA: 0x000033A8 File Offset: 0x000015A8
	[Token(Token = "0x170001CE")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x806370", Offset = "0x804970", VA = "0x180806370", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170001CF RID: 463
	// (get) Token: 0x0600037F RID: 895 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170001CF")]
	private Type TypeObject
	{
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x806390", Offset = "0x804990", VA = "0x180806390", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000380 RID: 896 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000380")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000381 RID: 897 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000381")]
	[Address(RVA = "0x806430", Offset = "0x804A30", VA = "0x180806430", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000382 RID: 898 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000382")]
	[Address(RVA = "0x807250", Offset = "0x805850", VA = "0x180807250", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000244 RID: 580
	[Token(Token = "0x4000244")]
	[FieldOffset(Offset = "0x0")]
	internal static TreeFallState_Meta Instance;
}
