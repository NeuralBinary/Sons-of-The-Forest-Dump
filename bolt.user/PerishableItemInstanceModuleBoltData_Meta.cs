using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200000F RID: 15
[Token(Token = "0x200000F")]
internal class PerishableItemInstanceModuleBoltData_Meta : NetworkObj_Meta, IFactory
{
	// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x7B7B60", Offset = "0x7B6160", VA = "0x1807B7B60")]
	public PerishableItemInstanceModuleBoltData_Meta()
	{
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000049 RID: 73 RVA: 0x00002250 File Offset: 0x00000450
	[Token(Token = "0x1700001B")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x0600004A RID: 74 RVA: 0x00002268 File Offset: 0x00000468
	[Token(Token = "0x1700001C")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x7B7BB0", Offset = "0x7B61B0", VA = "0x1807B7BB0", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x0600004B RID: 75 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700001D")]
	private Type TypeObject
	{
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x7B7BD0", Offset = "0x7B61D0", VA = "0x1807B7BD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004D")]
	[Address(RVA = "0x7B7C70", Offset = "0x7B6270", VA = "0x1807B7C70", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x7B7F90", Offset = "0x7B6590", VA = "0x1807B7F90", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000226 RID: 550
	[Token(Token = "0x4000226")]
	[FieldOffset(Offset = "0x0")]
	internal static PerishableItemInstanceModuleBoltData_Meta Instance;
}
