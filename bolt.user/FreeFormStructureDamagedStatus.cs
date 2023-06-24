using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200027C RID: 636
[Token(Token = "0x200027C")]
public class FreeFormStructureDamagedStatus : Event
{
	// Token: 0x06001D33 RID: 7475 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D33")]
	[Address(RVA = "0x7EE0A0", Offset = "0x7EC6A0", VA = "0x1807EE0A0")]
	public FreeFormStructureDamagedStatus()
	{
	}

	// Token: 0x170007FF RID: 2047
	// (get) Token: 0x06001D34 RID: 7476 RVA: 0x000089A0 File Offset: 0x00006BA0
	// (set) Token: 0x06001D35 RID: 7477 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007FF")]
	public int DBVersion
	{
		[Token(Token = "0x6001D34")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001D35")]
		[Address(RVA = "0x7EB470", Offset = "0x7E9A70", VA = "0x1807EB470")]
		set
		{
		}
	}

	// Token: 0x17000800 RID: 2048
	// (get) Token: 0x06001D36 RID: 7478 RVA: 0x000089B8 File Offset: 0x00006BB8
	// (set) Token: 0x06001D37 RID: 7479 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000800")]
	public int TypeID
	{
		[Token(Token = "0x6001D36")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001D37")]
		[Address(RVA = "0x7EB500", Offset = "0x7E9B00", VA = "0x1807EB500")]
		set
		{
		}
	}

	// Token: 0x17000801 RID: 2049
	// (get) Token: 0x06001D38 RID: 7480 RVA: 0x000089D0 File Offset: 0x00006BD0
	// (set) Token: 0x06001D39 RID: 7481 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000801")]
	public int InstanceID
	{
		[Token(Token = "0x6001D38")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001D39")]
		[Address(RVA = "0x7D6E60", Offset = "0x7D5460", VA = "0x1807D6E60")]
		set
		{
		}
	}

	// Token: 0x17000802 RID: 2050
	// (get) Token: 0x06001D3A RID: 7482 RVA: 0x000089E8 File Offset: 0x00006BE8
	// (set) Token: 0x06001D3B RID: 7483 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000802")]
	public bool IsDamaged
	{
		[Token(Token = "0x6001D3A")]
		[Address(RVA = "0x7BB3B0", Offset = "0x7B99B0", VA = "0x1807BB3B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001D3B")]
		[Address(RVA = "0x7EE100", Offset = "0x7EC700", VA = "0x1807EE100")]
		set
		{
		}
	}

	// Token: 0x06001D3C RID: 7484 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D3C")]
	[Address(RVA = "0x7EE1A0", Offset = "0x7EC7A0", VA = "0x1807EE1A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001D3D RID: 7485 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D3D")]
	[Address(RVA = "0x7EE4B0", Offset = "0x7ECAB0", VA = "0x1807EE4B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static FreeFormStructureDamagedStatus Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001D3E RID: 7486 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D3E")]
	[Address(RVA = "0x7EE640", Offset = "0x7ECC40", VA = "0x1807EE640")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureDamagedStatus Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001D3F RID: 7487 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D3F")]
	[Address(RVA = "0x7EE650", Offset = "0x7ECC50", VA = "0x1807EE650")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureDamagedStatus Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001D40 RID: 7488 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D40")]
	[Address(RVA = "0x7EE660", Offset = "0x7ECC60", VA = "0x1807EE660")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureDamagedStatus Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001D41 RID: 7489 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D41")]
	[Address(RVA = "0x7EE670", Offset = "0x7ECC70", VA = "0x1807EE670")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureDamagedStatus Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001D42 RID: 7490 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D42")]
	[Address(RVA = "0x7EE690", Offset = "0x7ECC90", VA = "0x1807EE690")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureDamagedStatus Raise()
	{
		return null;
	}

	// Token: 0x06001D43 RID: 7491 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D43")]
	[Address(RVA = "0x7EE6B0", Offset = "0x7ECCB0", VA = "0x1807EE6B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureDamagedStatus Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001D44 RID: 7492 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D44")]
	[Address(RVA = "0x7EE6C0", Offset = "0x7ECCC0", VA = "0x1807EE6C0")]
	private static FreeFormStructureDamagedStatus Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001D45 RID: 7493 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D45")]
	[Address(RVA = "0x7EE640", Offset = "0x7ECC40", VA = "0x1807EE640")]
	public static FreeFormStructureDamagedStatus Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001D46 RID: 7494 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D46")]
	[Address(RVA = "0x7EE650", Offset = "0x7ECC50", VA = "0x1807EE650")]
	public static FreeFormStructureDamagedStatus Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001D47 RID: 7495 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D47")]
	[Address(RVA = "0x7EE660", Offset = "0x7ECC60", VA = "0x1807EE660")]
	public static FreeFormStructureDamagedStatus Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001D48 RID: 7496 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D48")]
	[Address(RVA = "0x7EE670", Offset = "0x7ECC70", VA = "0x1807EE670")]
	public static FreeFormStructureDamagedStatus Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001D49 RID: 7497 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D49")]
	[Address(RVA = "0x7EE690", Offset = "0x7ECC90", VA = "0x1807EE690")]
	public static FreeFormStructureDamagedStatus Create()
	{
		return null;
	}

	// Token: 0x06001D4A RID: 7498 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D4A")]
	[Address(RVA = "0x7EE6B0", Offset = "0x7ECCB0", VA = "0x1807EE6B0")]
	public static FreeFormStructureDamagedStatus Create(ReliabilityModes reliability)
	{
		return null;
	}
}
