using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000020 RID: 32
[Token(Token = "0x2000020")]
internal class StorageContainerState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public StorageContainerState_Meta()
	{
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x060000A9 RID: 169 RVA: 0x000024A8 File Offset: 0x000006A8
	[Token(Token = "0x17000043")]
	private TypeId TypeId
	{
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x060000AA RID: 170 RVA: 0x000024C0 File Offset: 0x000006C0
	[Token(Token = "0x17000044")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x7BB760", Offset = "0x7B9D60", VA = "0x1807BB760", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x060000AB RID: 171 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000045")]
	private Type TypeObject
	{
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x7BB780", Offset = "0x7B9D80", VA = "0x1807BB780", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x7BB820", Offset = "0x7B9E20", VA = "0x1807BB820", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x7BBE20", Offset = "0x7BA420", VA = "0x1807BBE20", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0400022D RID: 557
	[Token(Token = "0x400022D")]
	[FieldOffset(Offset = "0x0")]
	internal static StorageContainerState_Meta Instance;
}
