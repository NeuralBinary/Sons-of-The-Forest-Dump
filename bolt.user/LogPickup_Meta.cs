using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000056 RID: 86
[Token(Token = "0x2000056")]
internal class LogPickup_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x0600030E RID: 782 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600030E")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public LogPickup_Meta()
	{
	}

	// Token: 0x17000193 RID: 403
	// (get) Token: 0x0600030F RID: 783 RVA: 0x000031B0 File Offset: 0x000013B0
	[Token(Token = "0x17000193")]
	private TypeId TypeId
	{
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000194 RID: 404
	// (get) Token: 0x06000310 RID: 784 RVA: 0x000031C8 File Offset: 0x000013C8
	[Token(Token = "0x17000194")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x7D55B0", Offset = "0x7D3BB0", VA = "0x1807D55B0", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000195 RID: 405
	// (get) Token: 0x06000311 RID: 785 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000195")]
	private Type TypeObject
	{
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x7D55D0", Offset = "0x7D3BD0", VA = "0x1807D55D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000312 RID: 786 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000312")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000313 RID: 787 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000313")]
	[Address(RVA = "0x7D5670", Offset = "0x7D3C70", VA = "0x1807D5670", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000314 RID: 788 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000314")]
	[Address(RVA = "0x7D5A30", Offset = "0x7D4030", VA = "0x1807D5A30", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0400023F RID: 575
	[Token(Token = "0x400023F")]
	[FieldOffset(Offset = "0x0")]
	internal static LogPickup_Meta Instance;
}
