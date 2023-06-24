using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000044 RID: 68
[Token(Token = "0x2000044")]
internal class DynamicPickup_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x060002AD RID: 685 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public DynamicPickup_Meta()
	{
	}

	// Token: 0x17000168 RID: 360
	// (get) Token: 0x060002AE RID: 686 RVA: 0x00002FD0 File Offset: 0x000011D0
	[Token(Token = "0x17000168")]
	private TypeId TypeId
	{
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000169 RID: 361
	// (get) Token: 0x060002AF RID: 687 RVA: 0x00002FE8 File Offset: 0x000011E8
	[Token(Token = "0x17000169")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x7D2250", Offset = "0x7D0850", VA = "0x1807D2250", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700016A RID: 362
	// (get) Token: 0x060002B0 RID: 688 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700016A")]
	private Type TypeObject
	{
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x7D2270", Offset = "0x7D0870", VA = "0x1807D2270", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x7D2310", Offset = "0x7D0910", VA = "0x1807D2310", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x7D26B0", Offset = "0x7D0CB0", VA = "0x1807D26B0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000239 RID: 569
	[Token(Token = "0x4000239")]
	[FieldOffset(Offset = "0x0")]
	internal static DynamicPickup_Meta Instance;
}
