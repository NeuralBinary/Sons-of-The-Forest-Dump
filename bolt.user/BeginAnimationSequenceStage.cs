using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000195 RID: 405
[Token(Token = "0x2000195")]
public class BeginAnimationSequenceStage : Event
{
	// Token: 0x06001279 RID: 4729 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001279")]
	[Address(RVA = "0x88D950", Offset = "0x88BF50", VA = "0x18088D950")]
	public BeginAnimationSequenceStage()
	{
	}

	// Token: 0x1700061E RID: 1566
	// (get) Token: 0x0600127A RID: 4730 RVA: 0x00006A68 File Offset: 0x00004C68
	// (set) Token: 0x0600127B RID: 4731 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700061E")]
	public int Stage
	{
		[Token(Token = "0x600127A")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600127B")]
		[Address(RVA = "0x7FDC20", Offset = "0x7FC220", VA = "0x1807FDC20")]
		set
		{
		}
	}

	// Token: 0x1700061F RID: 1567
	// (get) Token: 0x0600127C RID: 4732 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600127D RID: 4733 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700061F")]
	public BoltEntity Proxy
	{
		[Token(Token = "0x600127C")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600127D")]
		[Address(RVA = "0x88D9B0", Offset = "0x88BFB0", VA = "0x18088D9B0")]
		set
		{
		}
	}

	// Token: 0x17000620 RID: 1568
	// (get) Token: 0x0600127E RID: 4734 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600127F RID: 4735 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000620")]
	public BoltEntity Actor
	{
		[Token(Token = "0x600127E")]
		[Address(RVA = "0x80A6A0", Offset = "0x808CA0", VA = "0x18080A6A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600127F")]
		[Address(RVA = "0x88DBC0", Offset = "0x88C1C0", VA = "0x18088DBC0")]
		set
		{
		}
	}

	// Token: 0x06001280 RID: 4736 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001280")]
	[Address(RVA = "0x88DDE0", Offset = "0x88C3E0", VA = "0x18088DDE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001281 RID: 4737 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001281")]
	[Address(RVA = "0x88DFD0", Offset = "0x88C5D0", VA = "0x18088DFD0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static BeginAnimationSequenceStage Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001282 RID: 4738 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001282")]
	[Address(RVA = "0x88DFE0", Offset = "0x88C5E0", VA = "0x18088DFE0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static BeginAnimationSequenceStage Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001283 RID: 4739 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001283")]
	[Address(RVA = "0x88E1E0", Offset = "0x88C7E0", VA = "0x18088E1E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static BeginAnimationSequenceStage Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001284 RID: 4740 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001284")]
	[Address(RVA = "0x88E300", Offset = "0x88C900", VA = "0x18088E300")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static BeginAnimationSequenceStage Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001285 RID: 4741 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001285")]
	[Address(RVA = "0x88E310", Offset = "0x88C910", VA = "0x18088E310")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static BeginAnimationSequenceStage Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001286 RID: 4742 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001286")]
	[Address(RVA = "0x88E320", Offset = "0x88C920", VA = "0x18088E320")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static BeginAnimationSequenceStage Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001287 RID: 4743 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001287")]
	[Address(RVA = "0x88E330", Offset = "0x88C930", VA = "0x18088E330")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static BeginAnimationSequenceStage Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001288 RID: 4744 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001288")]
	[Address(RVA = "0x88E350", Offset = "0x88C950", VA = "0x18088E350")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static BeginAnimationSequenceStage Raise()
	{
		return null;
	}

	// Token: 0x06001289 RID: 4745 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001289")]
	[Address(RVA = "0x88E370", Offset = "0x88C970", VA = "0x18088E370")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static BeginAnimationSequenceStage Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600128A RID: 4746 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600128A")]
	[Address(RVA = "0x88DFD0", Offset = "0x88C5D0", VA = "0x18088DFD0")]
	public static BeginAnimationSequenceStage Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600128B RID: 4747 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600128B")]
	[Address(RVA = "0x88E380", Offset = "0x88C980", VA = "0x18088E380")]
	public static BeginAnimationSequenceStage Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600128C RID: 4748 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600128C")]
	[Address(RVA = "0x88E580", Offset = "0x88CB80", VA = "0x18088E580")]
	private static BeginAnimationSequenceStage Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600128D RID: 4749 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600128D")]
	[Address(RVA = "0x88E300", Offset = "0x88C900", VA = "0x18088E300")]
	public static BeginAnimationSequenceStage Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600128E RID: 4750 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600128E")]
	[Address(RVA = "0x88E310", Offset = "0x88C910", VA = "0x18088E310")]
	public static BeginAnimationSequenceStage Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600128F RID: 4751 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600128F")]
	[Address(RVA = "0x88E320", Offset = "0x88C920", VA = "0x18088E320")]
	public static BeginAnimationSequenceStage Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001290 RID: 4752 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001290")]
	[Address(RVA = "0x88E330", Offset = "0x88C930", VA = "0x18088E330")]
	public static BeginAnimationSequenceStage Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001291 RID: 4753 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001291")]
	[Address(RVA = "0x88E350", Offset = "0x88C950", VA = "0x18088E350")]
	public static BeginAnimationSequenceStage Create()
	{
		return null;
	}

	// Token: 0x06001292 RID: 4754 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001292")]
	[Address(RVA = "0x88E370", Offset = "0x88C970", VA = "0x18088E370")]
	public static BeginAnimationSequenceStage Create(ReliabilityModes reliability)
	{
		return null;
	}
}
