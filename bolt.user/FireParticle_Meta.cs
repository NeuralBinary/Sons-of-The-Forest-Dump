using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000053 RID: 83
[Token(Token = "0x2000053")]
internal class FireParticle_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x06000303 RID: 771 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000303")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public FireParticle_Meta()
	{
	}

	// Token: 0x1700018E RID: 398
	// (get) Token: 0x06000304 RID: 772 RVA: 0x00003180 File Offset: 0x00001380
	[Token(Token = "0x1700018E")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700018F RID: 399
	// (get) Token: 0x06000305 RID: 773 RVA: 0x00003198 File Offset: 0x00001398
	[Token(Token = "0x1700018F")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x7D4FD0", Offset = "0x7D35D0", VA = "0x1807D4FD0", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000190 RID: 400
	// (get) Token: 0x06000306 RID: 774 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000190")]
	private Type TypeObject
	{
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x7D4FF0", Offset = "0x7D35F0", VA = "0x1807D4FF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000307 RID: 775 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000307")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000308 RID: 776 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000308")]
	[Address(RVA = "0x7D5090", Offset = "0x7D3690", VA = "0x1807D5090", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000309 RID: 777 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000309")]
	[Address(RVA = "0x7D53B0", Offset = "0x7D39B0", VA = "0x1807D53B0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0400023E RID: 574
	[Token(Token = "0x400023E")]
	[FieldOffset(Offset = "0x0")]
	internal static FireParticle_Meta Instance;
}
