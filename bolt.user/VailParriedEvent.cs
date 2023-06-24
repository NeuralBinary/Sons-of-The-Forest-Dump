using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200022E RID: 558
[Token(Token = "0x200022E")]
public class VailParriedEvent : Event
{
	// Token: 0x060019AD RID: 6573 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019AD")]
	[Address(RVA = "0x8CB9D0", Offset = "0x8C9FD0", VA = "0x1808CB9D0")]
	public VailParriedEvent()
	{
	}

	// Token: 0x1700076E RID: 1902
	// (get) Token: 0x060019AE RID: 6574 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060019AF RID: 6575 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700076E")]
	public BoltEntity Target
	{
		[Token(Token = "0x60019AE")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60019AF")]
		[Address(RVA = "0x8CBA30", Offset = "0x8CA030", VA = "0x1808CBA30")]
		set
		{
		}
	}

	// Token: 0x1700076F RID: 1903
	// (get) Token: 0x060019B0 RID: 6576 RVA: 0x00008088 File Offset: 0x00006288
	// (set) Token: 0x060019B1 RID: 6577 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700076F")]
	public int Type
	{
		[Token(Token = "0x60019B0")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60019B1")]
		[Address(RVA = "0x7D6DC0", Offset = "0x7D53C0", VA = "0x1807D6DC0")]
		set
		{
		}
	}

	// Token: 0x060019B2 RID: 6578 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019B2")]
	[Address(RVA = "0x8CBC40", Offset = "0x8CA240", VA = "0x1808CBC40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060019B3 RID: 6579 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019B3")]
	[Address(RVA = "0x8CBD00", Offset = "0x8CA300", VA = "0x1808CBD00")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailParriedEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060019B4 RID: 6580 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019B4")]
	[Address(RVA = "0x8CBD10", Offset = "0x8CA310", VA = "0x1808CBD10")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailParriedEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060019B5 RID: 6581 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019B5")]
	[Address(RVA = "0x8CBF10", Offset = "0x8CA510", VA = "0x1808CBF10")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static VailParriedEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060019B6 RID: 6582 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019B6")]
	[Address(RVA = "0x8CC030", Offset = "0x8CA630", VA = "0x1808CC030")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailParriedEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060019B7 RID: 6583 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019B7")]
	[Address(RVA = "0x8CC040", Offset = "0x8CA640", VA = "0x1808CC040")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailParriedEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060019B8 RID: 6584 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019B8")]
	[Address(RVA = "0x8CC050", Offset = "0x8CA650", VA = "0x1808CC050")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailParriedEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060019B9 RID: 6585 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019B9")]
	[Address(RVA = "0x8CC060", Offset = "0x8CA660", VA = "0x1808CC060")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailParriedEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060019BA RID: 6586 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019BA")]
	[Address(RVA = "0x8CC080", Offset = "0x8CA680", VA = "0x1808CC080")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailParriedEvent Raise()
	{
		return null;
	}

	// Token: 0x060019BB RID: 6587 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019BB")]
	[Address(RVA = "0x8CC0A0", Offset = "0x8CA6A0", VA = "0x1808CC0A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailParriedEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060019BC RID: 6588 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019BC")]
	[Address(RVA = "0x8CBD00", Offset = "0x8CA300", VA = "0x1808CBD00")]
	public static VailParriedEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060019BD RID: 6589 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019BD")]
	[Address(RVA = "0x8CC0B0", Offset = "0x8CA6B0", VA = "0x1808CC0B0")]
	public static VailParriedEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060019BE RID: 6590 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019BE")]
	[Address(RVA = "0x8CC2B0", Offset = "0x8CA8B0", VA = "0x1808CC2B0")]
	private static VailParriedEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060019BF RID: 6591 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019BF")]
	[Address(RVA = "0x8CC030", Offset = "0x8CA630", VA = "0x1808CC030")]
	public static VailParriedEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060019C0 RID: 6592 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019C0")]
	[Address(RVA = "0x8CC040", Offset = "0x8CA640", VA = "0x1808CC040")]
	public static VailParriedEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060019C1 RID: 6593 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019C1")]
	[Address(RVA = "0x8CC050", Offset = "0x8CA650", VA = "0x1808CC050")]
	public static VailParriedEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060019C2 RID: 6594 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019C2")]
	[Address(RVA = "0x8CC060", Offset = "0x8CA660", VA = "0x1808CC060")]
	public static VailParriedEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060019C3 RID: 6595 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019C3")]
	[Address(RVA = "0x8CC080", Offset = "0x8CA680", VA = "0x1808CC080")]
	public static VailParriedEvent Create()
	{
		return null;
	}

	// Token: 0x060019C4 RID: 6596 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019C4")]
	[Address(RVA = "0x8CC0A0", Offset = "0x8CA6A0", VA = "0x1808CC0A0")]
	public static VailParriedEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
