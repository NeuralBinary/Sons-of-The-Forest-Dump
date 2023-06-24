using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200000B RID: 11
[Token(Token = "0x200000B")]
internal class HellDoor_Meta : NetworkObj_Meta, IFactory
{
	// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x7B6210", Offset = "0x7B4810", VA = "0x1807B6210")]
	public HellDoor_Meta()
	{
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000029 RID: 41 RVA: 0x00002148 File Offset: 0x00000348
	[Token(Token = "0x1700000E")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x0600002A RID: 42 RVA: 0x00002160 File Offset: 0x00000360
	[Token(Token = "0x1700000F")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x7B6260", Offset = "0x7B4860", VA = "0x1807B6260", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x0600002B RID: 43 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000010")]
	private Type TypeObject
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x7B6280", Offset = "0x7B4880", VA = "0x1807B6280", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x7B6320", Offset = "0x7B4920", VA = "0x1807B6320", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x7B6450", Offset = "0x7B4A50", VA = "0x1807B6450", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x7B6680", Offset = "0x7B4C80", VA = "0x1807B6680", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000224 RID: 548
	[Token(Token = "0x4000224")]
	[FieldOffset(Offset = "0x0")]
	internal static HellDoor_Meta Instance;
}
