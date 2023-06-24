using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000015 RID: 21
[Token(Token = "0x2000015")]
internal class HeldItemSlotTransfer_Meta : NetworkObj_Meta, IFactory
{
	// Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000073")]
	[Address(RVA = "0x7B9A70", Offset = "0x7B8070", VA = "0x1807B9A70")]
	public HeldItemSlotTransfer_Meta()
	{
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x06000074 RID: 116 RVA: 0x00002388 File Offset: 0x00000588
	[Token(Token = "0x1700002D")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x06000075 RID: 117 RVA: 0x000023A0 File Offset: 0x000005A0
	[Token(Token = "0x1700002E")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x7B9AC0", Offset = "0x7B80C0", VA = "0x1807B9AC0", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x06000076 RID: 118 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700002F")]
	private Type TypeObject
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x7B9AE0", Offset = "0x7B80E0", VA = "0x1807B9AE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000077")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000078")]
	[Address(RVA = "0x7B9B80", Offset = "0x7B8180", VA = "0x1807B9B80", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000079")]
	[Address(RVA = "0x7B9FA0", Offset = "0x7B85A0", VA = "0x1807B9FA0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000229 RID: 553
	[Token(Token = "0x4000229")]
	[FieldOffset(Offset = "0x0")]
	internal static HeldItemSlotTransfer_Meta Instance;
}
