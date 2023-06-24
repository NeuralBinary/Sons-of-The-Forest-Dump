using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000228 RID: 552
[Token(Token = "0x2000228")]
public class JumpTimeEvent : Event
{
	// Token: 0x06001961 RID: 6497 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001961")]
	[Address(RVA = "0x8C9020", Offset = "0x8C7620", VA = "0x1808C9020")]
	public JumpTimeEvent()
	{
	}

	// Token: 0x17000760 RID: 1888
	// (get) Token: 0x06001962 RID: 6498 RVA: 0x00007F80 File Offset: 0x00006180
	// (set) Token: 0x06001963 RID: 6499 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000760")]
	public int DeltaSeconds
	{
		[Token(Token = "0x6001962")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001963")]
		[Address(RVA = "0x7EB470", Offset = "0x7E9A70", VA = "0x1807EB470")]
		set
		{
		}
	}

	// Token: 0x17000761 RID: 1889
	// (get) Token: 0x06001964 RID: 6500 RVA: 0x00007F98 File Offset: 0x00006198
	// (set) Token: 0x06001965 RID: 6501 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000761")]
	public int Days
	{
		[Token(Token = "0x6001964")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001965")]
		[Address(RVA = "0x7D8500", Offset = "0x7D6B00", VA = "0x1807D8500")]
		set
		{
		}
	}

	// Token: 0x17000762 RID: 1890
	// (get) Token: 0x06001966 RID: 6502 RVA: 0x00007FB0 File Offset: 0x000061B0
	// (set) Token: 0x06001967 RID: 6503 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000762")]
	public int Hours
	{
		[Token(Token = "0x6001966")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001967")]
		[Address(RVA = "0x8C9080", Offset = "0x8C7680", VA = "0x1808C9080")]
		set
		{
		}
	}

	// Token: 0x17000763 RID: 1891
	// (get) Token: 0x06001968 RID: 6504 RVA: 0x00007FC8 File Offset: 0x000061C8
	// (set) Token: 0x06001969 RID: 6505 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000763")]
	public int Minutes
	{
		[Token(Token = "0x6001968")]
		[Address(RVA = "0x7B6B40", Offset = "0x7B5140", VA = "0x1807B6B40")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001969")]
		[Address(RVA = "0x8C9130", Offset = "0x8C7730", VA = "0x1808C9130")]
		set
		{
		}
	}

	// Token: 0x17000764 RID: 1892
	// (get) Token: 0x0600196A RID: 6506 RVA: 0x00007FE0 File Offset: 0x000061E0
	// (set) Token: 0x0600196B RID: 6507 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000764")]
	public int Seconds
	{
		[Token(Token = "0x600196A")]
		[Address(RVA = "0x7BB500", Offset = "0x7B9B00", VA = "0x1807BB500")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600196B")]
		[Address(RVA = "0x8C91E0", Offset = "0x8C77E0", VA = "0x1808C91E0")]
		set
		{
		}
	}

	// Token: 0x17000765 RID: 1893
	// (get) Token: 0x0600196C RID: 6508 RVA: 0x00007FF8 File Offset: 0x000061F8
	// (set) Token: 0x0600196D RID: 6509 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000765")]
	public int Milliseconds
	{
		[Token(Token = "0x600196C")]
		[Address(RVA = "0x7E1E00", Offset = "0x7E0400", VA = "0x1807E1E00")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600196D")]
		[Address(RVA = "0x8C9290", Offset = "0x8C7890", VA = "0x1808C9290")]
		set
		{
		}
	}

	// Token: 0x0600196E RID: 6510 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600196E")]
	[Address(RVA = "0x8C9340", Offset = "0x8C7940", VA = "0x1808C9340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0600196F RID: 6511 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600196F")]
	[Address(RVA = "0x8C9780", Offset = "0x8C7D80", VA = "0x1808C9780")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static JumpTimeEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001970 RID: 6512 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001970")]
	[Address(RVA = "0x8C9790", Offset = "0x8C7D90", VA = "0x1808C9790")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static JumpTimeEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001971 RID: 6513 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001971")]
	[Address(RVA = "0x8C9990", Offset = "0x8C7F90", VA = "0x1808C9990")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static JumpTimeEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001972 RID: 6514 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001972")]
	[Address(RVA = "0x8C9AB0", Offset = "0x8C80B0", VA = "0x1808C9AB0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static JumpTimeEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001973 RID: 6515 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001973")]
	[Address(RVA = "0x8C9AC0", Offset = "0x8C80C0", VA = "0x1808C9AC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static JumpTimeEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001974 RID: 6516 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001974")]
	[Address(RVA = "0x8C9AD0", Offset = "0x8C80D0", VA = "0x1808C9AD0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static JumpTimeEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001975 RID: 6517 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001975")]
	[Address(RVA = "0x8C9AE0", Offset = "0x8C80E0", VA = "0x1808C9AE0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static JumpTimeEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001976 RID: 6518 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001976")]
	[Address(RVA = "0x8C9B00", Offset = "0x8C8100", VA = "0x1808C9B00")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static JumpTimeEvent Raise()
	{
		return null;
	}

	// Token: 0x06001977 RID: 6519 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001977")]
	[Address(RVA = "0x8C9B20", Offset = "0x8C8120", VA = "0x1808C9B20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static JumpTimeEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001978 RID: 6520 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001978")]
	[Address(RVA = "0x8C9780", Offset = "0x8C7D80", VA = "0x1808C9780")]
	public static JumpTimeEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001979 RID: 6521 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001979")]
	[Address(RVA = "0x8C9B30", Offset = "0x8C8130", VA = "0x1808C9B30")]
	public static JumpTimeEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600197A RID: 6522 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600197A")]
	[Address(RVA = "0x8C9D30", Offset = "0x8C8330", VA = "0x1808C9D30")]
	private static JumpTimeEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600197B RID: 6523 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600197B")]
	[Address(RVA = "0x8C9AB0", Offset = "0x8C80B0", VA = "0x1808C9AB0")]
	public static JumpTimeEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600197C RID: 6524 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600197C")]
	[Address(RVA = "0x8C9AC0", Offset = "0x8C80C0", VA = "0x1808C9AC0")]
	public static JumpTimeEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600197D RID: 6525 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600197D")]
	[Address(RVA = "0x8C9AD0", Offset = "0x8C80D0", VA = "0x1808C9AD0")]
	public static JumpTimeEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600197E RID: 6526 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600197E")]
	[Address(RVA = "0x8C9AE0", Offset = "0x8C80E0", VA = "0x1808C9AE0")]
	public static JumpTimeEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600197F RID: 6527 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600197F")]
	[Address(RVA = "0x8C9B00", Offset = "0x8C8100", VA = "0x1808C9B00")]
	public static JumpTimeEvent Create()
	{
		return null;
	}

	// Token: 0x06001980 RID: 6528 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001980")]
	[Address(RVA = "0x8C9B20", Offset = "0x8C8120", VA = "0x1808C9B20")]
	public static JumpTimeEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
