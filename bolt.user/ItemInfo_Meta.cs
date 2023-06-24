using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200000D RID: 13
[Token(Token = "0x200000D")]
internal class ItemInfo_Meta : NetworkObj_Meta, IFactory
{
	// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x7B6F40", Offset = "0x7B5540", VA = "0x1807B6F40")]
	public ItemInfo_Meta()
	{
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x0600003C RID: 60 RVA: 0x000021F0 File Offset: 0x000003F0
	[Token(Token = "0x17000016")]
	private TypeId TypeId
	{
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x0600003D RID: 61 RVA: 0x00002208 File Offset: 0x00000408
	[Token(Token = "0x17000017")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x7B6F90", Offset = "0x7B5590", VA = "0x1807B6F90", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x0600003E RID: 62 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000018")]
	private Type TypeObject
	{
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x7B6FB0", Offset = "0x7B55B0", VA = "0x1807B6FB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000040")]
	[Address(RVA = "0x7B7050", Offset = "0x7B5650", VA = "0x1807B7050", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x7B76F0", Offset = "0x7B5CF0", VA = "0x1807B76F0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000225 RID: 549
	[Token(Token = "0x4000225")]
	[FieldOffset(Offset = "0x0")]
	internal static ItemInfo_Meta Instance;
}
