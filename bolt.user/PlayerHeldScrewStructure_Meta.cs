using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200006B RID: 107
[Token(Token = "0x200006B")]
internal class PlayerHeldScrewStructure_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x0600039C RID: 924 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600039C")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public PlayerHeldScrewStructure_Meta()
	{
	}

	// Token: 0x170001DB RID: 475
	// (get) Token: 0x0600039D RID: 925 RVA: 0x00003408 File Offset: 0x00001608
	[Token(Token = "0x170001DB")]
	private TypeId TypeId
	{
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170001DC RID: 476
	// (get) Token: 0x0600039E RID: 926 RVA: 0x00003420 File Offset: 0x00001620
	[Token(Token = "0x170001DC")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x808120", Offset = "0x806720", VA = "0x180808120", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170001DD RID: 477
	// (get) Token: 0x0600039F RID: 927 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170001DD")]
	private Type TypeObject
	{
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x808140", Offset = "0x806740", VA = "0x180808140", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x8081E0", Offset = "0x8067E0", VA = "0x1808081E0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x808510", Offset = "0x806B10", VA = "0x180808510", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000246 RID: 582
	[Token(Token = "0x4000246")]
	[FieldOffset(Offset = "0x0")]
	internal static PlayerHeldScrewStructure_Meta Instance;
}
