using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000D8 RID: 216
[Token(Token = "0x20000D8")]
public class PlaneCrashIndex : Event
{
	// Token: 0x06000A07 RID: 2567 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A07")]
	[Address(RVA = "0x848250", Offset = "0x846850", VA = "0x180848250")]
	public PlaneCrashIndex()
	{
	}

	// Token: 0x170004D9 RID: 1241
	// (get) Token: 0x06000A08 RID: 2568 RVA: 0x00005760 File Offset: 0x00003960
	// (set) Token: 0x06000A09 RID: 2569 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004D9")]
	public int Index
	{
		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x7EB470", Offset = "0x7E9A70", VA = "0x1807EB470")]
		set
		{
		}
	}

	// Token: 0x170004DA RID: 1242
	// (get) Token: 0x06000A0A RID: 2570 RVA: 0x00005778 File Offset: 0x00003978
	// (set) Token: 0x06000A0B RID: 2571 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004DA")]
	public int YachtIndex
	{
		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x7D6DC0", Offset = "0x7D53C0", VA = "0x1807D6DC0")]
		set
		{
		}
	}

	// Token: 0x06000A0C RID: 2572 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A0C")]
	[Address(RVA = "0x8482B0", Offset = "0x8468B0", VA = "0x1808482B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000A0D RID: 2573 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A0D")]
	[Address(RVA = "0x8483C0", Offset = "0x8469C0", VA = "0x1808483C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaneCrashIndex Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000A0E RID: 2574 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A0E")]
	[Address(RVA = "0x8483D0", Offset = "0x8469D0", VA = "0x1808483D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaneCrashIndex Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A0F")]
	[Address(RVA = "0x8485D0", Offset = "0x846BD0", VA = "0x1808485D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static PlaneCrashIndex Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A10 RID: 2576 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A10")]
	[Address(RVA = "0x8486F0", Offset = "0x846CF0", VA = "0x1808486F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaneCrashIndex Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000A11 RID: 2577 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A11")]
	[Address(RVA = "0x848700", Offset = "0x846D00", VA = "0x180848700")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaneCrashIndex Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A12 RID: 2578 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A12")]
	[Address(RVA = "0x848710", Offset = "0x846D10", VA = "0x180848710")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaneCrashIndex Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A13")]
	[Address(RVA = "0x848720", Offset = "0x846D20", VA = "0x180848720")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaneCrashIndex Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A14 RID: 2580 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A14")]
	[Address(RVA = "0x848740", Offset = "0x846D40", VA = "0x180848740")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaneCrashIndex Raise()
	{
		return null;
	}

	// Token: 0x06000A15 RID: 2581 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A15")]
	[Address(RVA = "0x848760", Offset = "0x846D60", VA = "0x180848760")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaneCrashIndex Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A16 RID: 2582 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A16")]
	[Address(RVA = "0x8483C0", Offset = "0x8469C0", VA = "0x1808483C0")]
	public static PlaneCrashIndex Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000A17 RID: 2583 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A17")]
	[Address(RVA = "0x848770", Offset = "0x846D70", VA = "0x180848770")]
	public static PlaneCrashIndex Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000A18 RID: 2584 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A18")]
	[Address(RVA = "0x848970", Offset = "0x846F70", VA = "0x180848970")]
	private static PlaneCrashIndex Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A19 RID: 2585 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A19")]
	[Address(RVA = "0x8486F0", Offset = "0x846CF0", VA = "0x1808486F0")]
	public static PlaneCrashIndex Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000A1A RID: 2586 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A1A")]
	[Address(RVA = "0x848700", Offset = "0x846D00", VA = "0x180848700")]
	public static PlaneCrashIndex Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A1B RID: 2587 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A1B")]
	[Address(RVA = "0x848710", Offset = "0x846D10", VA = "0x180848710")]
	public static PlaneCrashIndex Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000A1C RID: 2588 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A1C")]
	[Address(RVA = "0x848720", Offset = "0x846D20", VA = "0x180848720")]
	public static PlaneCrashIndex Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A1D RID: 2589 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A1D")]
	[Address(RVA = "0x848740", Offset = "0x846D40", VA = "0x180848740")]
	public static PlaneCrashIndex Create()
	{
		return null;
	}

	// Token: 0x06000A1E RID: 2590 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A1E")]
	[Address(RVA = "0x848760", Offset = "0x846D60", VA = "0x180848760")]
	public static PlaneCrashIndex Create(ReliabilityModes reliability)
	{
		return null;
	}
}
