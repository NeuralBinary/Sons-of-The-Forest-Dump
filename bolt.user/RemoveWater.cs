using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200013E RID: 318
[Token(Token = "0x200013E")]
public class RemoveWater : Event
{
	// Token: 0x06000E9D RID: 3741 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E9D")]
	[Address(RVA = "0x86E5D0", Offset = "0x86CBD0", VA = "0x18086E5D0")]
	public RemoveWater()
	{
	}

	// Token: 0x1700058C RID: 1420
	// (get) Token: 0x06000E9E RID: 3742 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000E9F RID: 3743 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700058C")]
	public BoltEntity Entity
	{
		[Token(Token = "0x6000E9E")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E9F")]
		[Address(RVA = "0x86E630", Offset = "0x86CC30", VA = "0x18086E630")]
		set
		{
		}
	}

	// Token: 0x1700058D RID: 1421
	// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x000061F8 File Offset: 0x000043F8
	// (set) Token: 0x06000EA1 RID: 3745 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700058D")]
	public float Amount
	{
		[Token(Token = "0x6000EA0")]
		[Address(RVA = "0x7B78E0", Offset = "0x7B5EE0", VA = "0x1807B78E0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000EA1")]
		[Address(RVA = "0x861E70", Offset = "0x860470", VA = "0x180861E70")]
		set
		{
		}
	}

	// Token: 0x06000EA2 RID: 3746 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EA2")]
	[Address(RVA = "0x86E840", Offset = "0x86CE40", VA = "0x18086E840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000EA3 RID: 3747 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EA3")]
	[Address(RVA = "0x86E990", Offset = "0x86CF90", VA = "0x18086E990")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RemoveWater Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000EA4 RID: 3748 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EA4")]
	[Address(RVA = "0x86E9A0", Offset = "0x86CFA0", VA = "0x18086E9A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RemoveWater Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000EA5 RID: 3749 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EA5")]
	[Address(RVA = "0x86EBA0", Offset = "0x86D1A0", VA = "0x18086EBA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static RemoveWater Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000EA6 RID: 3750 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EA6")]
	[Address(RVA = "0x86ECC0", Offset = "0x86D2C0", VA = "0x18086ECC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RemoveWater Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000EA7 RID: 3751 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EA7")]
	[Address(RVA = "0x86ECD0", Offset = "0x86D2D0", VA = "0x18086ECD0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RemoveWater Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000EA8 RID: 3752 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EA8")]
	[Address(RVA = "0x86ECE0", Offset = "0x86D2E0", VA = "0x18086ECE0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RemoveWater Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000EA9 RID: 3753 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EA9")]
	[Address(RVA = "0x86ECF0", Offset = "0x86D2F0", VA = "0x18086ECF0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RemoveWater Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000EAA RID: 3754 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EAA")]
	[Address(RVA = "0x86ED10", Offset = "0x86D310", VA = "0x18086ED10")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RemoveWater Raise()
	{
		return null;
	}

	// Token: 0x06000EAB RID: 3755 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EAB")]
	[Address(RVA = "0x86ED30", Offset = "0x86D330", VA = "0x18086ED30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RemoveWater Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000EAC RID: 3756 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EAC")]
	[Address(RVA = "0x86E990", Offset = "0x86CF90", VA = "0x18086E990")]
	public static RemoveWater Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000EAD RID: 3757 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EAD")]
	[Address(RVA = "0x86ED40", Offset = "0x86D340", VA = "0x18086ED40")]
	public static RemoveWater Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000EAE RID: 3758 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EAE")]
	[Address(RVA = "0x86EF40", Offset = "0x86D540", VA = "0x18086EF40")]
	private static RemoveWater Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000EAF RID: 3759 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EAF")]
	[Address(RVA = "0x86ECC0", Offset = "0x86D2C0", VA = "0x18086ECC0")]
	public static RemoveWater Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000EB0 RID: 3760 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EB0")]
	[Address(RVA = "0x86ECD0", Offset = "0x86D2D0", VA = "0x18086ECD0")]
	public static RemoveWater Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000EB1 RID: 3761 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EB1")]
	[Address(RVA = "0x86ECE0", Offset = "0x86D2E0", VA = "0x18086ECE0")]
	public static RemoveWater Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000EB2 RID: 3762 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EB2")]
	[Address(RVA = "0x86ECF0", Offset = "0x86D2F0", VA = "0x18086ECF0")]
	public static RemoveWater Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000EB3 RID: 3763 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EB3")]
	[Address(RVA = "0x86ED10", Offset = "0x86D310", VA = "0x18086ED10")]
	public static RemoveWater Create()
	{
		return null;
	}

	// Token: 0x06000EB4 RID: 3764 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EB4")]
	[Address(RVA = "0x86ED30", Offset = "0x86D330", VA = "0x18086ED30")]
	public static RemoveWater Create(ReliabilityModes reliability)
	{
		return null;
	}
}
