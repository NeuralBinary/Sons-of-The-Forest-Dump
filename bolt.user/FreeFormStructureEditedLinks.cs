using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001D7 RID: 471
[Token(Token = "0x20001D7")]
public class FreeFormStructureEditedLinks : Event
{
	// Token: 0x06001567 RID: 5479 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001567")]
	[Address(RVA = "0x8A5670", Offset = "0x8A3C70", VA = "0x1808A5670")]
	public FreeFormStructureEditedLinks()
	{
	}

	// Token: 0x1700069D RID: 1693
	// (get) Token: 0x06001568 RID: 5480 RVA: 0x00007218 File Offset: 0x00005418
	// (set) Token: 0x06001569 RID: 5481 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700069D")]
	public int DBVersion
	{
		[Token(Token = "0x6001568")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001569")]
		[Address(RVA = "0x7EB470", Offset = "0x7E9A70", VA = "0x1807EB470")]
		set
		{
		}
	}

	// Token: 0x1700069E RID: 1694
	// (get) Token: 0x0600156A RID: 5482 RVA: 0x00007230 File Offset: 0x00005430
	// (set) Token: 0x0600156B RID: 5483 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700069E")]
	public int TypeID
	{
		[Token(Token = "0x600156A")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600156B")]
		[Address(RVA = "0x7EB500", Offset = "0x7E9B00", VA = "0x1807EB500")]
		set
		{
		}
	}

	// Token: 0x1700069F RID: 1695
	// (get) Token: 0x0600156C RID: 5484 RVA: 0x00007248 File Offset: 0x00005448
	// (set) Token: 0x0600156D RID: 5485 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700069F")]
	public int InstanceID
	{
		[Token(Token = "0x600156C")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600156D")]
		[Address(RVA = "0x7D6E60", Offset = "0x7D5460", VA = "0x1807D6E60")]
		set
		{
		}
	}

	// Token: 0x170006A0 RID: 1696
	// (get) Token: 0x0600156E RID: 5486 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600156F RID: 5487 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006A0")]
	public IProtocolToken Links
	{
		[Token(Token = "0x600156E")]
		[Address(RVA = "0x7BDAB0", Offset = "0x7BC0B0", VA = "0x1807BDAB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600156F")]
		[Address(RVA = "0x7D6F00", Offset = "0x7D5500", VA = "0x1807D6F00")]
		set
		{
		}
	}

	// Token: 0x06001570 RID: 5488 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001570")]
	[Address(RVA = "0x8A56D0", Offset = "0x8A3CD0", VA = "0x1808A56D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001571 RID: 5489 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001571")]
	[Address(RVA = "0x8A5980", Offset = "0x8A3F80", VA = "0x1808A5980")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static FreeFormStructureEditedLinks Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001572 RID: 5490 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001572")]
	[Address(RVA = "0x8A5B10", Offset = "0x8A4110", VA = "0x1808A5B10")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureEditedLinks Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001573 RID: 5491 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001573")]
	[Address(RVA = "0x8A5B20", Offset = "0x8A4120", VA = "0x1808A5B20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureEditedLinks Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001574 RID: 5492 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001574")]
	[Address(RVA = "0x8A5B30", Offset = "0x8A4130", VA = "0x1808A5B30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureEditedLinks Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001575 RID: 5493 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001575")]
	[Address(RVA = "0x8A5B40", Offset = "0x8A4140", VA = "0x1808A5B40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureEditedLinks Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001576 RID: 5494 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001576")]
	[Address(RVA = "0x8A5B60", Offset = "0x8A4160", VA = "0x1808A5B60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureEditedLinks Raise()
	{
		return null;
	}

	// Token: 0x06001577 RID: 5495 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001577")]
	[Address(RVA = "0x8A5B80", Offset = "0x8A4180", VA = "0x1808A5B80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureEditedLinks Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001578 RID: 5496 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001578")]
	[Address(RVA = "0x8A5B90", Offset = "0x8A4190", VA = "0x1808A5B90")]
	private static FreeFormStructureEditedLinks Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001579 RID: 5497 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001579")]
	[Address(RVA = "0x8A5B10", Offset = "0x8A4110", VA = "0x1808A5B10")]
	public static FreeFormStructureEditedLinks Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600157A RID: 5498 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600157A")]
	[Address(RVA = "0x8A5B20", Offset = "0x8A4120", VA = "0x1808A5B20")]
	public static FreeFormStructureEditedLinks Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600157B RID: 5499 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600157B")]
	[Address(RVA = "0x8A5B30", Offset = "0x8A4130", VA = "0x1808A5B30")]
	public static FreeFormStructureEditedLinks Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600157C RID: 5500 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600157C")]
	[Address(RVA = "0x8A5B40", Offset = "0x8A4140", VA = "0x1808A5B40")]
	public static FreeFormStructureEditedLinks Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600157D RID: 5501 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600157D")]
	[Address(RVA = "0x8A5B60", Offset = "0x8A4160", VA = "0x1808A5B60")]
	public static FreeFormStructureEditedLinks Create()
	{
		return null;
	}

	// Token: 0x0600157E RID: 5502 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600157E")]
	[Address(RVA = "0x8A5B80", Offset = "0x8A4180", VA = "0x1808A5B80")]
	public static FreeFormStructureEditedLinks Create(ReliabilityModes reliability)
	{
		return null;
	}
}
