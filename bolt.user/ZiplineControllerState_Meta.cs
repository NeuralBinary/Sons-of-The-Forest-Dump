using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200004D RID: 77
[Token(Token = "0x200004D")]
internal class ZiplineControllerState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x060002EA RID: 746 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public ZiplineControllerState_Meta()
	{
	}

	// Token: 0x17000183 RID: 387
	// (get) Token: 0x060002EB RID: 747 RVA: 0x00003108 File Offset: 0x00001308
	[Token(Token = "0x17000183")]
	private TypeId TypeId
	{
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000184 RID: 388
	// (get) Token: 0x060002EC RID: 748 RVA: 0x00003120 File Offset: 0x00001320
	[Token(Token = "0x17000184")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x7D3F80", Offset = "0x7D2580", VA = "0x1807D3F80", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000185 RID: 389
	// (get) Token: 0x060002ED RID: 749 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000185")]
	private Type TypeObject
	{
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x7D3FA0", Offset = "0x7D25A0", VA = "0x1807D3FA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060002EE RID: 750 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060002EF RID: 751 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x7D4040", Offset = "0x7D2640", VA = "0x1807D4040", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x7D4560", Offset = "0x7D2B60", VA = "0x1807D4560", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0400023C RID: 572
	[Token(Token = "0x400023C")]
	[FieldOffset(Offset = "0x0")]
	internal static ZiplineControllerState_Meta Instance;
}
