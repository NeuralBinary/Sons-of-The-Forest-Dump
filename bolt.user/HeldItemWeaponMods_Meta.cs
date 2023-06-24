using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000011 RID: 17
[Token(Token = "0x2000011")]
internal class HeldItemWeaponMods_Meta : NetworkObj_Meta, IFactory
{
	// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x7B8370", Offset = "0x7B6970", VA = "0x1807B8370")]
	public HeldItemWeaponMods_Meta()
	{
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x06000055 RID: 85 RVA: 0x00002298 File Offset: 0x00000498
	[Token(Token = "0x17000020")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x06000056 RID: 86 RVA: 0x000022B0 File Offset: 0x000004B0
	[Token(Token = "0x17000021")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x7B83C0", Offset = "0x7B69C0", VA = "0x1807B83C0", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x06000057 RID: 87 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000022")]
	private Type TypeObject
	{
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000058")]
	[Address(RVA = "0x7B8480", Offset = "0x7B6A80", VA = "0x1807B8480", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000059")]
	[Address(RVA = "0x7B85B0", Offset = "0x7B6BB0", VA = "0x1807B85B0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x7B8900", Offset = "0x7B6F00", VA = "0x1807B8900", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000227 RID: 551
	[Token(Token = "0x4000227")]
	[FieldOffset(Offset = "0x0")]
	internal static HeldItemWeaponMods_Meta Instance;
}
