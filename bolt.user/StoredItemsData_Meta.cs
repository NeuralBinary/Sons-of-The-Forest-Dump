using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000013 RID: 19
[Token(Token = "0x2000013")]
internal class StoredItemsData_Meta : NetworkObj_Meta, IFactory
{
	// Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000064")]
	[Address(RVA = "0x7B8E40", Offset = "0x7B7440", VA = "0x1807B8E40")]
	public StoredItemsData_Meta()
	{
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x06000065 RID: 101 RVA: 0x00002310 File Offset: 0x00000510
	[Token(Token = "0x17000027")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x06000066 RID: 102 RVA: 0x00002328 File Offset: 0x00000528
	[Token(Token = "0x17000028")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x7B8E90", Offset = "0x7B7490", VA = "0x1807B8E90", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x06000067 RID: 103 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000029")]
	private Type TypeObject
	{
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x7B8EB0", Offset = "0x7B74B0", VA = "0x1807B8EB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x7B8F50", Offset = "0x7B7550", VA = "0x1807B8F50", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000069")]
	[Address(RVA = "0x7B90A0", Offset = "0x7B76A0", VA = "0x1807B90A0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600006A")]
	[Address(RVA = "0x7B95F0", Offset = "0x7B7BF0", VA = "0x1807B95F0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000228 RID: 552
	[Token(Token = "0x4000228")]
	[FieldOffset(Offset = "0x0")]
	internal static StoredItemsData_Meta Instance;
}
