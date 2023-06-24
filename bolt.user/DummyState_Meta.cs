using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000029 RID: 41
[Token(Token = "0x2000029")]
internal class DummyState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public DummyState_Meta()
	{
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x060000D9 RID: 217 RVA: 0x00002598 File Offset: 0x00000798
	[Token(Token = "0x17000057")]
	private TypeId TypeId
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x060000DA RID: 218 RVA: 0x000025B0 File Offset: 0x000007B0
	[Token(Token = "0x17000058")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x7BD830", Offset = "0x7BBE30", VA = "0x1807BD830", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x060000DB RID: 219 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000059")]
	private Type TypeObject
	{
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x7BD850", Offset = "0x7BBE50", VA = "0x1807BD850", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x7BD8F0", Offset = "0x7BBEF0", VA = "0x1807BD8F0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060000DE RID: 222 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x7BD9C0", Offset = "0x7BBFC0", VA = "0x1807BD9C0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000230 RID: 560
	[Token(Token = "0x4000230")]
	[FieldOffset(Offset = "0x0")]
	internal static DummyState_Meta Instance;
}
