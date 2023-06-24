using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000007 RID: 7
[Token(Token = "0x2000007")]
internal class MutantProp_Meta : NetworkObj_Meta, IFactory
{
	// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x7B4DC0", Offset = "0x7B33C0", VA = "0x1807B4DC0")]
	public MutantProp_Meta()
	{
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000010 RID: 16 RVA: 0x000020A0 File Offset: 0x000002A0
	[Token(Token = "0x17000004")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000011 RID: 17 RVA: 0x000020B8 File Offset: 0x000002B8
	[Token(Token = "0x17000005")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x7B4E10", Offset = "0x7B3410", VA = "0x1807B4E10", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000012 RID: 18 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000006")]
	private Type TypeObject
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x7B4E30", Offset = "0x7B3430", VA = "0x1807B4E30", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x7B4ED0", Offset = "0x7B34D0", VA = "0x1807B4ED0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x7B51E0", Offset = "0x7B37E0", VA = "0x1807B51E0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000222 RID: 546
	[Token(Token = "0x4000222")]
	[FieldOffset(Offset = "0x0")]
	internal static MutantProp_Meta Instance;
}
