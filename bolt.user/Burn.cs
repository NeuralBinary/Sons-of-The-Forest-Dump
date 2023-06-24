using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000135 RID: 309
[Token(Token = "0x2000135")]
public class Burn : Event
{
	// Token: 0x06000E3D RID: 3645 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E3D")]
	[Address(RVA = "0x86BAA0", Offset = "0x86A0A0", VA = "0x18086BAA0")]
	public Burn()
	{
	}

	// Token: 0x17000580 RID: 1408
	// (get) Token: 0x06000E3E RID: 3646 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000E3F RID: 3647 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000580")]
	public BoltEntity Entity
	{
		[Token(Token = "0x6000E3E")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E3F")]
		[Address(RVA = "0x86BB00", Offset = "0x86A100", VA = "0x18086BB00")]
		set
		{
		}
	}

	// Token: 0x06000E40 RID: 3648 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E40")]
	[Address(RVA = "0x86BD10", Offset = "0x86A310", VA = "0x18086BD10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000E41 RID: 3649 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E41")]
	[Address(RVA = "0x86BD60", Offset = "0x86A360", VA = "0x18086BD60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Burn Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000E42 RID: 3650 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E42")]
	[Address(RVA = "0x86BD70", Offset = "0x86A370", VA = "0x18086BD70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Burn Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000E43 RID: 3651 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E43")]
	[Address(RVA = "0x86BF70", Offset = "0x86A570", VA = "0x18086BF70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static Burn Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E44 RID: 3652 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E44")]
	[Address(RVA = "0x86C090", Offset = "0x86A690", VA = "0x18086C090")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Burn Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000E45 RID: 3653 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E45")]
	[Address(RVA = "0x86C0A0", Offset = "0x86A6A0", VA = "0x18086C0A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Burn Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E46 RID: 3654 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E46")]
	[Address(RVA = "0x86C0B0", Offset = "0x86A6B0", VA = "0x18086C0B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Burn Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000E47 RID: 3655 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E47")]
	[Address(RVA = "0x86C0C0", Offset = "0x86A6C0", VA = "0x18086C0C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Burn Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E48 RID: 3656 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E48")]
	[Address(RVA = "0x86C0E0", Offset = "0x86A6E0", VA = "0x18086C0E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Burn Raise()
	{
		return null;
	}

	// Token: 0x06000E49 RID: 3657 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E49")]
	[Address(RVA = "0x86C100", Offset = "0x86A700", VA = "0x18086C100")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Burn Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E4A RID: 3658 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E4A")]
	[Address(RVA = "0x86BD60", Offset = "0x86A360", VA = "0x18086BD60")]
	public static Burn Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000E4B RID: 3659 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E4B")]
	[Address(RVA = "0x86C110", Offset = "0x86A710", VA = "0x18086C110")]
	public static Burn Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000E4C RID: 3660 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E4C")]
	[Address(RVA = "0x86C310", Offset = "0x86A910", VA = "0x18086C310")]
	private static Burn Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E4D RID: 3661 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E4D")]
	[Address(RVA = "0x86C090", Offset = "0x86A690", VA = "0x18086C090")]
	public static Burn Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000E4E RID: 3662 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E4E")]
	[Address(RVA = "0x86C0A0", Offset = "0x86A6A0", VA = "0x18086C0A0")]
	public static Burn Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E4F RID: 3663 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E4F")]
	[Address(RVA = "0x86C0B0", Offset = "0x86A6B0", VA = "0x18086C0B0")]
	public static Burn Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000E50 RID: 3664 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E50")]
	[Address(RVA = "0x86C0C0", Offset = "0x86A6C0", VA = "0x18086C0C0")]
	public static Burn Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E51 RID: 3665 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E51")]
	[Address(RVA = "0x86C0E0", Offset = "0x86A6E0", VA = "0x18086C0E0")]
	public static Burn Create()
	{
		return null;
	}

	// Token: 0x06000E52 RID: 3666 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E52")]
	[Address(RVA = "0x86C100", Offset = "0x86A700", VA = "0x18086C100")]
	public static Burn Create(ReliabilityModes reliability)
	{
		return null;
	}
}
