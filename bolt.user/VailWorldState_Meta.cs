using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200002F RID: 47
[Token(Token = "0x200002F")]
internal class VailWorldState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public VailWorldState_Meta()
	{
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x060000F8 RID: 248 RVA: 0x00002628 File Offset: 0x00000828
	[Token(Token = "0x17000064")]
	private TypeId TypeId
	{
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x060000F9 RID: 249 RVA: 0x00002640 File Offset: 0x00000840
	[Token(Token = "0x17000065")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x7BE590", Offset = "0x7BCB90", VA = "0x1807BE590", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x060000FA RID: 250 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000066")]
	private Type TypeObject
	{
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x7BE5B0", Offset = "0x7BCBB0", VA = "0x1807BE5B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x7BE650", Offset = "0x7BCC50", VA = "0x1807BE650", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060000FD RID: 253 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x7BE990", Offset = "0x7BCF90", VA = "0x1807BE990", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000232 RID: 562
	[Token(Token = "0x4000232")]
	[FieldOffset(Offset = "0x0")]
	internal static VailWorldState_Meta Instance;
}
