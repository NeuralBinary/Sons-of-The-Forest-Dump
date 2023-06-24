using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000AD RID: 173
[Token(Token = "0x20000AD")]
internal class ProjectileState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x060007CE RID: 1998 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007CE")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public ProjectileState_Meta()
	{
	}

	// Token: 0x1700044D RID: 1101
	// (get) Token: 0x060007CF RID: 1999 RVA: 0x00004EF0 File Offset: 0x000030F0
	[Token(Token = "0x1700044D")]
	private TypeId TypeId
	{
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700044E RID: 1102
	// (get) Token: 0x060007D0 RID: 2000 RVA: 0x00004F08 File Offset: 0x00003108
	[Token(Token = "0x1700044E")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x831D60", Offset = "0x830360", VA = "0x180831D60", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700044F RID: 1103
	// (get) Token: 0x060007D1 RID: 2001 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700044F")]
	private Type TypeObject
	{
		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x831D80", Offset = "0x830380", VA = "0x180831D80", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060007D2 RID: 2002 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007D2")]
	[Address(RVA = "0x831E20", Offset = "0x830420", VA = "0x180831E20", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007D3")]
	[Address(RVA = "0x831F50", Offset = "0x830550", VA = "0x180831F50", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060007D4 RID: 2004 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60007D4")]
	[Address(RVA = "0x8329E0", Offset = "0x830FE0", VA = "0x1808329E0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0400025C RID: 604
	[Token(Token = "0x400025C")]
	[FieldOffset(Offset = "0x0")]
	internal static ProjectileState_Meta Instance;
}
