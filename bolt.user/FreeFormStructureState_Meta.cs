using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000071 RID: 113
[Token(Token = "0x2000071")]
internal class FreeFormStructureState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x060003BB RID: 955 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public FreeFormStructureState_Meta()
	{
	}

	// Token: 0x170001E8 RID: 488
	// (get) Token: 0x060003BC RID: 956 RVA: 0x00003498 File Offset: 0x00001698
	[Token(Token = "0x170001E8")]
	private TypeId TypeId
	{
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170001E9 RID: 489
	// (get) Token: 0x060003BD RID: 957 RVA: 0x000034B0 File Offset: 0x000016B0
	[Token(Token = "0x170001E9")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x8091F0", Offset = "0x8077F0", VA = "0x1808091F0", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170001EA RID: 490
	// (get) Token: 0x060003BE RID: 958 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170001EA")]
	private Type TypeObject
	{
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x809210", Offset = "0x807810", VA = "0x180809210", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060003BF RID: 959 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x8092B0", Offset = "0x8078B0", VA = "0x1808092B0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x8095F0", Offset = "0x807BF0", VA = "0x1808095F0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000248 RID: 584
	[Token(Token = "0x4000248")]
	[FieldOffset(Offset = "0x0")]
	internal static FreeFormStructureState_Meta Instance;
}
