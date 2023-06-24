using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001D1 RID: 465
[Token(Token = "0x20001D1")]
public class FreeFormStructureCascadeRepositionSupported : Event
{
	// Token: 0x06001527 RID: 5415 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001527")]
	[Address(RVA = "0x8A39A0", Offset = "0x8A1FA0", VA = "0x1808A39A0")]
	public FreeFormStructureCascadeRepositionSupported()
	{
	}

	// Token: 0x17000691 RID: 1681
	// (get) Token: 0x06001528 RID: 5416 RVA: 0x00007158 File Offset: 0x00005358
	// (set) Token: 0x06001529 RID: 5417 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000691")]
	public int DBVersion
	{
		[Token(Token = "0x6001528")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001529")]
		[Address(RVA = "0x7EB470", Offset = "0x7E9A70", VA = "0x1807EB470")]
		set
		{
		}
	}

	// Token: 0x17000692 RID: 1682
	// (get) Token: 0x0600152A RID: 5418 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600152B RID: 5419 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000692")]
	public IProtocolToken Structures
	{
		[Token(Token = "0x600152A")]
		[Address(RVA = "0x8A3A00", Offset = "0x8A2000", VA = "0x1808A3A00")]
		get
		{
			return null;
		}
		[Token(Token = "0x600152B")]
		[Address(RVA = "0x8A3AB0", Offset = "0x8A20B0", VA = "0x1808A3AB0")]
		set
		{
		}
	}

	// Token: 0x0600152C RID: 5420 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600152C")]
	[Address(RVA = "0x8A3C00", Offset = "0x8A2200", VA = "0x1808A3C00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0600152D RID: 5421 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600152D")]
	[Address(RVA = "0x8A3CC0", Offset = "0x8A22C0", VA = "0x1808A3CC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static FreeFormStructureCascadeRepositionSupported Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600152E RID: 5422 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600152E")]
	[Address(RVA = "0x8A3E50", Offset = "0x8A2450", VA = "0x1808A3E50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureCascadeRepositionSupported Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600152F RID: 5423 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600152F")]
	[Address(RVA = "0x8A3E60", Offset = "0x8A2460", VA = "0x1808A3E60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureCascadeRepositionSupported Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001530 RID: 5424 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001530")]
	[Address(RVA = "0x8A3E70", Offset = "0x8A2470", VA = "0x1808A3E70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureCascadeRepositionSupported Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001531 RID: 5425 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001531")]
	[Address(RVA = "0x8A3E80", Offset = "0x8A2480", VA = "0x1808A3E80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureCascadeRepositionSupported Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001532 RID: 5426 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001532")]
	[Address(RVA = "0x8A3EA0", Offset = "0x8A24A0", VA = "0x1808A3EA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureCascadeRepositionSupported Raise()
	{
		return null;
	}

	// Token: 0x06001533 RID: 5427 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001533")]
	[Address(RVA = "0x8A3EC0", Offset = "0x8A24C0", VA = "0x1808A3EC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureCascadeRepositionSupported Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001534 RID: 5428 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001534")]
	[Address(RVA = "0x8A3ED0", Offset = "0x8A24D0", VA = "0x1808A3ED0")]
	private static FreeFormStructureCascadeRepositionSupported Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001535 RID: 5429 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001535")]
	[Address(RVA = "0x8A3E50", Offset = "0x8A2450", VA = "0x1808A3E50")]
	public static FreeFormStructureCascadeRepositionSupported Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001536 RID: 5430 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001536")]
	[Address(RVA = "0x8A3E60", Offset = "0x8A2460", VA = "0x1808A3E60")]
	public static FreeFormStructureCascadeRepositionSupported Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001537 RID: 5431 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001537")]
	[Address(RVA = "0x8A3E70", Offset = "0x8A2470", VA = "0x1808A3E70")]
	public static FreeFormStructureCascadeRepositionSupported Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001538 RID: 5432 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001538")]
	[Address(RVA = "0x8A3E80", Offset = "0x8A2480", VA = "0x1808A3E80")]
	public static FreeFormStructureCascadeRepositionSupported Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001539 RID: 5433 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001539")]
	[Address(RVA = "0x8A3EA0", Offset = "0x8A24A0", VA = "0x1808A3EA0")]
	public static FreeFormStructureCascadeRepositionSupported Create()
	{
		return null;
	}

	// Token: 0x0600153A RID: 5434 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600153A")]
	[Address(RVA = "0x8A3EC0", Offset = "0x8A24C0", VA = "0x1808A3EC0")]
	public static FreeFormStructureCascadeRepositionSupported Create(ReliabilityModes reliability)
	{
		return null;
	}
}
