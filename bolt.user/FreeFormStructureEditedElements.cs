using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001D4 RID: 468
[Token(Token = "0x20001D4")]
public class FreeFormStructureEditedElements : Event
{
	// Token: 0x06001545 RID: 5445 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001545")]
	[Address(RVA = "0x8A46F0", Offset = "0x8A2CF0", VA = "0x1808A46F0")]
	public FreeFormStructureEditedElements()
	{
	}

	// Token: 0x17000696 RID: 1686
	// (get) Token: 0x06001546 RID: 5446 RVA: 0x000071A0 File Offset: 0x000053A0
	// (set) Token: 0x06001547 RID: 5447 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000696")]
	public int DBVersion
	{
		[Token(Token = "0x6001546")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001547")]
		[Address(RVA = "0x7EB470", Offset = "0x7E9A70", VA = "0x1807EB470")]
		set
		{
		}
	}

	// Token: 0x17000697 RID: 1687
	// (get) Token: 0x06001548 RID: 5448 RVA: 0x000071B8 File Offset: 0x000053B8
	// (set) Token: 0x06001549 RID: 5449 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000697")]
	public int TypeID
	{
		[Token(Token = "0x6001548")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001549")]
		[Address(RVA = "0x7EB500", Offset = "0x7E9B00", VA = "0x1807EB500")]
		set
		{
		}
	}

	// Token: 0x17000698 RID: 1688
	// (get) Token: 0x0600154A RID: 5450 RVA: 0x000071D0 File Offset: 0x000053D0
	// (set) Token: 0x0600154B RID: 5451 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000698")]
	public int InstanceID
	{
		[Token(Token = "0x600154A")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600154B")]
		[Address(RVA = "0x7D6E60", Offset = "0x7D5460", VA = "0x1807D6E60")]
		set
		{
		}
	}

	// Token: 0x17000699 RID: 1689
	// (get) Token: 0x0600154C RID: 5452 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600154D RID: 5453 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000699")]
	public IProtocolToken Elements
	{
		[Token(Token = "0x600154C")]
		[Address(RVA = "0x7BDAB0", Offset = "0x7BC0B0", VA = "0x1807BDAB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600154D")]
		[Address(RVA = "0x7D6F00", Offset = "0x7D5500", VA = "0x1807D6F00")]
		set
		{
		}
	}

	// Token: 0x0600154E RID: 5454 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600154E")]
	[Address(RVA = "0x8A4750", Offset = "0x8A2D50", VA = "0x1808A4750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0600154F RID: 5455 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600154F")]
	[Address(RVA = "0x8A4A00", Offset = "0x8A3000", VA = "0x1808A4A00")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static FreeFormStructureEditedElements Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001550 RID: 5456 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001550")]
	[Address(RVA = "0x8A4B90", Offset = "0x8A3190", VA = "0x1808A4B90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureEditedElements Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001551 RID: 5457 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001551")]
	[Address(RVA = "0x8A4BA0", Offset = "0x8A31A0", VA = "0x1808A4BA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureEditedElements Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001552 RID: 5458 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001552")]
	[Address(RVA = "0x8A4BB0", Offset = "0x8A31B0", VA = "0x1808A4BB0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureEditedElements Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001553 RID: 5459 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001553")]
	[Address(RVA = "0x8A4BC0", Offset = "0x8A31C0", VA = "0x1808A4BC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureEditedElements Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001554 RID: 5460 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001554")]
	[Address(RVA = "0x8A4BE0", Offset = "0x8A31E0", VA = "0x1808A4BE0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureEditedElements Raise()
	{
		return null;
	}

	// Token: 0x06001555 RID: 5461 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001555")]
	[Address(RVA = "0x8A4C00", Offset = "0x8A3200", VA = "0x1808A4C00")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureEditedElements Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001556 RID: 5462 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001556")]
	[Address(RVA = "0x8A4C10", Offset = "0x8A3210", VA = "0x1808A4C10")]
	private static FreeFormStructureEditedElements Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001557 RID: 5463 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001557")]
	[Address(RVA = "0x8A4B90", Offset = "0x8A3190", VA = "0x1808A4B90")]
	public static FreeFormStructureEditedElements Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001558 RID: 5464 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001558")]
	[Address(RVA = "0x8A4BA0", Offset = "0x8A31A0", VA = "0x1808A4BA0")]
	public static FreeFormStructureEditedElements Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001559 RID: 5465 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001559")]
	[Address(RVA = "0x8A4BB0", Offset = "0x8A31B0", VA = "0x1808A4BB0")]
	public static FreeFormStructureEditedElements Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600155A RID: 5466 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600155A")]
	[Address(RVA = "0x8A4BC0", Offset = "0x8A31C0", VA = "0x1808A4BC0")]
	public static FreeFormStructureEditedElements Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600155B RID: 5467 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600155B")]
	[Address(RVA = "0x8A4BE0", Offset = "0x8A31E0", VA = "0x1808A4BE0")]
	public static FreeFormStructureEditedElements Create()
	{
		return null;
	}

	// Token: 0x0600155C RID: 5468 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600155C")]
	[Address(RVA = "0x8A4C00", Offset = "0x8A3200", VA = "0x1808A4C00")]
	public static FreeFormStructureEditedElements Create(ReliabilityModes reliability)
	{
		return null;
	}
}
