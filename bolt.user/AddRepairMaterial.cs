using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200012F RID: 303
[Token(Token = "0x200012F")]
public class AddRepairMaterial : Event
{
	// Token: 0x06000DF5 RID: 3573 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DF5")]
	[Address(RVA = "0x869380", Offset = "0x867980", VA = "0x180869380")]
	public AddRepairMaterial()
	{
	}

	// Token: 0x17000574 RID: 1396
	// (get) Token: 0x06000DF6 RID: 3574 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000DF7 RID: 3575 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000574")]
	public BoltEntity Building
	{
		[Token(Token = "0x6000DF6")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000DF7")]
		[Address(RVA = "0x8693E0", Offset = "0x8679E0", VA = "0x1808693E0")]
		set
		{
		}
	}

	// Token: 0x17000575 RID: 1397
	// (get) Token: 0x06000DF8 RID: 3576 RVA: 0x00006090 File Offset: 0x00004290
	// (set) Token: 0x06000DF9 RID: 3577 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000575")]
	public bool IsLog
	{
		[Token(Token = "0x6000DF8")]
		[Address(RVA = "0x7B5490", Offset = "0x7B3A90", VA = "0x1807B5490")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000DF9")]
		[Address(RVA = "0x7E82E0", Offset = "0x7E68E0", VA = "0x1807E82E0")]
		set
		{
		}
	}

	// Token: 0x06000DFA RID: 3578 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DFA")]
	[Address(RVA = "0x8695F0", Offset = "0x867BF0", VA = "0x1808695F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000DFB RID: 3579 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DFB")]
	[Address(RVA = "0x869730", Offset = "0x867D30", VA = "0x180869730")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AddRepairMaterial Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000DFC RID: 3580 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DFC")]
	[Address(RVA = "0x869740", Offset = "0x867D40", VA = "0x180869740")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AddRepairMaterial Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000DFD RID: 3581 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DFD")]
	[Address(RVA = "0x869940", Offset = "0x867F40", VA = "0x180869940")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static AddRepairMaterial Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000DFE RID: 3582 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DFE")]
	[Address(RVA = "0x869A60", Offset = "0x868060", VA = "0x180869A60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AddRepairMaterial Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000DFF RID: 3583 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DFF")]
	[Address(RVA = "0x869A70", Offset = "0x868070", VA = "0x180869A70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AddRepairMaterial Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E00 RID: 3584 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E00")]
	[Address(RVA = "0x869A80", Offset = "0x868080", VA = "0x180869A80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AddRepairMaterial Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000E01 RID: 3585 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E01")]
	[Address(RVA = "0x869A90", Offset = "0x868090", VA = "0x180869A90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AddRepairMaterial Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E02 RID: 3586 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E02")]
	[Address(RVA = "0x869AB0", Offset = "0x8680B0", VA = "0x180869AB0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AddRepairMaterial Raise()
	{
		return null;
	}

	// Token: 0x06000E03 RID: 3587 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E03")]
	[Address(RVA = "0x869AD0", Offset = "0x8680D0", VA = "0x180869AD0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AddRepairMaterial Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E04 RID: 3588 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E04")]
	[Address(RVA = "0x869730", Offset = "0x867D30", VA = "0x180869730")]
	public static AddRepairMaterial Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000E05 RID: 3589 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E05")]
	[Address(RVA = "0x869AE0", Offset = "0x8680E0", VA = "0x180869AE0")]
	public static AddRepairMaterial Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000E06 RID: 3590 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E06")]
	[Address(RVA = "0x869CE0", Offset = "0x8682E0", VA = "0x180869CE0")]
	private static AddRepairMaterial Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E07 RID: 3591 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E07")]
	[Address(RVA = "0x869A60", Offset = "0x868060", VA = "0x180869A60")]
	public static AddRepairMaterial Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000E08 RID: 3592 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E08")]
	[Address(RVA = "0x869A70", Offset = "0x868070", VA = "0x180869A70")]
	public static AddRepairMaterial Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E09 RID: 3593 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E09")]
	[Address(RVA = "0x869A80", Offset = "0x868080", VA = "0x180869A80")]
	public static AddRepairMaterial Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000E0A RID: 3594 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E0A")]
	[Address(RVA = "0x869A90", Offset = "0x868090", VA = "0x180869A90")]
	public static AddRepairMaterial Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E0B RID: 3595 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E0B")]
	[Address(RVA = "0x869AB0", Offset = "0x8680B0", VA = "0x180869AB0")]
	public static AddRepairMaterial Create()
	{
		return null;
	}

	// Token: 0x06000E0C RID: 3596 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E0C")]
	[Address(RVA = "0x869AD0", Offset = "0x8680D0", VA = "0x180869AD0")]
	public static AddRepairMaterial Create(ReliabilityModes reliability)
	{
		return null;
	}
}
