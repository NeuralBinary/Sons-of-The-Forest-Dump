using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000062 RID: 98
[Token(Token = "0x2000062")]
internal class DecayingPickup_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x06000363 RID: 867 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000363")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public DecayingPickup_Meta()
	{
	}

	// Token: 0x170001BE RID: 446
	// (get) Token: 0x06000364 RID: 868 RVA: 0x00003348 File Offset: 0x00001548
	[Token(Token = "0x170001BE")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170001BF RID: 447
	// (get) Token: 0x06000365 RID: 869 RVA: 0x00003360 File Offset: 0x00001560
	[Token(Token = "0x170001BF")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x805660", Offset = "0x803C60", VA = "0x180805660", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170001C0 RID: 448
	// (get) Token: 0x06000366 RID: 870 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170001C0")]
	private Type TypeObject
	{
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x805680", Offset = "0x803C80", VA = "0x180805680", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000367 RID: 871 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000367")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000368 RID: 872 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000368")]
	[Address(RVA = "0x805720", Offset = "0x803D20", VA = "0x180805720", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000369 RID: 873 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000369")]
	[Address(RVA = "0x805BE0", Offset = "0x8041E0", VA = "0x180805BE0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000243 RID: 579
	[Token(Token = "0x4000243")]
	[FieldOffset(Offset = "0x0")]
	internal static DecayingPickup_Meta Instance;
}
