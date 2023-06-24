using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200009E RID: 158
[Token(Token = "0x200009E")]
internal class RadioState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x060006C3 RID: 1731 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006C3")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public RadioState_Meta()
	{
	}

	// Token: 0x170003C4 RID: 964
	// (get) Token: 0x060006C4 RID: 1732 RVA: 0x00004878 File Offset: 0x00002A78
	[Token(Token = "0x170003C4")]
	private TypeId TypeId
	{
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170003C5 RID: 965
	// (get) Token: 0x060006C5 RID: 1733 RVA: 0x00004890 File Offset: 0x00002A90
	[Token(Token = "0x170003C5")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x826B00", Offset = "0x825100", VA = "0x180826B00", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170003C6 RID: 966
	// (get) Token: 0x060006C6 RID: 1734 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170003C6")]
	private Type TypeObject
	{
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x826B20", Offset = "0x825120", VA = "0x180826B20", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060006C7 RID: 1735 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006C7")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060006C8 RID: 1736 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006C8")]
	[Address(RVA = "0x826BC0", Offset = "0x8251C0", VA = "0x180826BC0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60006C9")]
	[Address(RVA = "0x8273F0", Offset = "0x8259F0", VA = "0x1808273F0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000257 RID: 599
	[Token(Token = "0x4000257")]
	[FieldOffset(Offset = "0x0")]
	internal static RadioState_Meta Instance;
}
