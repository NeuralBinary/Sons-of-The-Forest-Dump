using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000117 RID: 279
[Token(Token = "0x2000117")]
public class SledGrab : Event
{
	// Token: 0x06000CD9 RID: 3289 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CD9")]
	[Address(RVA = "0x85F4B0", Offset = "0x85DAB0", VA = "0x18085F4B0")]
	public SledGrab()
	{
	}

	// Token: 0x17000546 RID: 1350
	// (get) Token: 0x06000CDA RID: 3290 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000CDB RID: 3291 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000546")]
	public BoltEntity Player
	{
		[Token(Token = "0x6000CDA")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000CDB")]
		[Address(RVA = "0x85F510", Offset = "0x85DB10", VA = "0x18085F510")]
		set
		{
		}
	}

	// Token: 0x17000547 RID: 1351
	// (get) Token: 0x06000CDC RID: 3292 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000CDD RID: 3293 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000547")]
	public BoltEntity Sled
	{
		[Token(Token = "0x6000CDC")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000CDD")]
		[Address(RVA = "0x85F720", Offset = "0x85DD20", VA = "0x18085F720")]
		set
		{
		}
	}

	// Token: 0x06000CDE RID: 3294 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CDE")]
	[Address(RVA = "0x85F930", Offset = "0x85DF30", VA = "0x18085F930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000CDF RID: 3295 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CDF")]
	[Address(RVA = "0x85F990", Offset = "0x85DF90", VA = "0x18085F990")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SledGrab Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000CE0 RID: 3296 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CE0")]
	[Address(RVA = "0x85F9A0", Offset = "0x85DFA0", VA = "0x18085F9A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SledGrab Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000CE1 RID: 3297 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CE1")]
	[Address(RVA = "0x85FBA0", Offset = "0x85E1A0", VA = "0x18085FBA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static SledGrab Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000CE2 RID: 3298 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CE2")]
	[Address(RVA = "0x85FCC0", Offset = "0x85E2C0", VA = "0x18085FCC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SledGrab Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000CE3 RID: 3299 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CE3")]
	[Address(RVA = "0x85FCD0", Offset = "0x85E2D0", VA = "0x18085FCD0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SledGrab Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000CE4 RID: 3300 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CE4")]
	[Address(RVA = "0x85FCE0", Offset = "0x85E2E0", VA = "0x18085FCE0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SledGrab Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000CE5 RID: 3301 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CE5")]
	[Address(RVA = "0x85FCF0", Offset = "0x85E2F0", VA = "0x18085FCF0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SledGrab Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000CE6 RID: 3302 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CE6")]
	[Address(RVA = "0x85FD10", Offset = "0x85E310", VA = "0x18085FD10")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SledGrab Raise()
	{
		return null;
	}

	// Token: 0x06000CE7 RID: 3303 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CE7")]
	[Address(RVA = "0x85FD30", Offset = "0x85E330", VA = "0x18085FD30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SledGrab Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000CE8 RID: 3304 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CE8")]
	[Address(RVA = "0x85F990", Offset = "0x85DF90", VA = "0x18085F990")]
	public static SledGrab Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000CE9 RID: 3305 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CE9")]
	[Address(RVA = "0x85FD40", Offset = "0x85E340", VA = "0x18085FD40")]
	public static SledGrab Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000CEA RID: 3306 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CEA")]
	[Address(RVA = "0x85FF40", Offset = "0x85E540", VA = "0x18085FF40")]
	private static SledGrab Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000CEB RID: 3307 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CEB")]
	[Address(RVA = "0x85FCC0", Offset = "0x85E2C0", VA = "0x18085FCC0")]
	public static SledGrab Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000CEC RID: 3308 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CEC")]
	[Address(RVA = "0x85FCD0", Offset = "0x85E2D0", VA = "0x18085FCD0")]
	public static SledGrab Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000CED RID: 3309 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CED")]
	[Address(RVA = "0x85FCE0", Offset = "0x85E2E0", VA = "0x18085FCE0")]
	public static SledGrab Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000CEE RID: 3310 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CEE")]
	[Address(RVA = "0x85FCF0", Offset = "0x85E2F0", VA = "0x18085FCF0")]
	public static SledGrab Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000CEF RID: 3311 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CEF")]
	[Address(RVA = "0x85FD10", Offset = "0x85E310", VA = "0x18085FD10")]
	public static SledGrab Create()
	{
		return null;
	}

	// Token: 0x06000CF0 RID: 3312 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CF0")]
	[Address(RVA = "0x85FD30", Offset = "0x85E330", VA = "0x18085FD30")]
	public static SledGrab Create(ReliabilityModes reliability)
	{
		return null;
	}
}
