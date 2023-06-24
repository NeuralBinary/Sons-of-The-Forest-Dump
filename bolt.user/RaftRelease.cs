using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200012C RID: 300
[Token(Token = "0x200012C")]
public class RaftRelease : Event
{
	// Token: 0x06000DCD RID: 3533 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DCD")]
	[Address(RVA = "0x8678C0", Offset = "0x865EC0", VA = "0x1808678C0")]
	public RaftRelease()
	{
	}

	// Token: 0x1700056C RID: 1388
	// (get) Token: 0x06000DCE RID: 3534 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000DCF RID: 3535 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700056C")]
	public BoltEntity Player
	{
		[Token(Token = "0x6000DCE")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000DCF")]
		[Address(RVA = "0x867920", Offset = "0x865F20", VA = "0x180867920")]
		set
		{
		}
	}

	// Token: 0x1700056D RID: 1389
	// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000DD1 RID: 3537 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700056D")]
	public BoltEntity Raft
	{
		[Token(Token = "0x6000DD0")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000DD1")]
		[Address(RVA = "0x867B30", Offset = "0x866130", VA = "0x180867B30")]
		set
		{
		}
	}

	// Token: 0x1700056E RID: 1390
	// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x00006018 File Offset: 0x00004218
	// (set) Token: 0x06000DD3 RID: 3539 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700056E")]
	public Vector3 Position
	{
		[Token(Token = "0x6000DD2")]
		[Address(RVA = "0x7B55E0", Offset = "0x7B3BE0", VA = "0x1807B55E0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000DD3")]
		[Address(RVA = "0x843CF0", Offset = "0x8422F0", VA = "0x180843CF0")]
		set
		{
		}
	}

	// Token: 0x1700056F RID: 1391
	// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x00006030 File Offset: 0x00004230
	// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700056F")]
	public Quaternion Rotation
	{
		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0x7DD6C0", Offset = "0x7DBCC0", VA = "0x1807DD6C0")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000DD5")]
		[Address(RVA = "0x7DD730", Offset = "0x7DBD30", VA = "0x1807DD730")]
		set
		{
		}
	}

	// Token: 0x17000570 RID: 1392
	// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x00006048 File Offset: 0x00004248
	// (set) Token: 0x06000DD7 RID: 3543 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000570")]
	public int OarId
	{
		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0x7BB500", Offset = "0x7B9B00", VA = "0x1807BB500")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000DD7")]
		[Address(RVA = "0x867D40", Offset = "0x866340", VA = "0x180867D40")]
		set
		{
		}
	}

	// Token: 0x06000DD8 RID: 3544 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DD8")]
	[Address(RVA = "0x867DF0", Offset = "0x8663F0", VA = "0x180867DF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000DD9 RID: 3545 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DD9")]
	[Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RaftRelease Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000DDA RID: 3546 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DDA")]
	[Address(RVA = "0x868210", Offset = "0x866810", VA = "0x180868210")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RaftRelease Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000DDB RID: 3547 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DDB")]
	[Address(RVA = "0x868410", Offset = "0x866A10", VA = "0x180868410")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static RaftRelease Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000DDC RID: 3548 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DDC")]
	[Address(RVA = "0x868530", Offset = "0x866B30", VA = "0x180868530")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RaftRelease Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000DDD RID: 3549 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DDD")]
	[Address(RVA = "0x868540", Offset = "0x866B40", VA = "0x180868540")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RaftRelease Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000DDE RID: 3550 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DDE")]
	[Address(RVA = "0x868550", Offset = "0x866B50", VA = "0x180868550")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RaftRelease Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000DDF RID: 3551 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DDF")]
	[Address(RVA = "0x868560", Offset = "0x866B60", VA = "0x180868560")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RaftRelease Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000DE0 RID: 3552 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DE0")]
	[Address(RVA = "0x868580", Offset = "0x866B80", VA = "0x180868580")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RaftRelease Raise()
	{
		return null;
	}

	// Token: 0x06000DE1 RID: 3553 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DE1")]
	[Address(RVA = "0x8685A0", Offset = "0x866BA0", VA = "0x1808685A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RaftRelease Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000DE2 RID: 3554 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DE2")]
	[Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200")]
	public static RaftRelease Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000DE3 RID: 3555 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DE3")]
	[Address(RVA = "0x8685B0", Offset = "0x866BB0", VA = "0x1808685B0")]
	public static RaftRelease Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000DE4 RID: 3556 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DE4")]
	[Address(RVA = "0x8687B0", Offset = "0x866DB0", VA = "0x1808687B0")]
	private static RaftRelease Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000DE5 RID: 3557 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DE5")]
	[Address(RVA = "0x868530", Offset = "0x866B30", VA = "0x180868530")]
	public static RaftRelease Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000DE6 RID: 3558 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DE6")]
	[Address(RVA = "0x868540", Offset = "0x866B40", VA = "0x180868540")]
	public static RaftRelease Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000DE7 RID: 3559 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DE7")]
	[Address(RVA = "0x868550", Offset = "0x866B50", VA = "0x180868550")]
	public static RaftRelease Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000DE8 RID: 3560 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DE8")]
	[Address(RVA = "0x868560", Offset = "0x866B60", VA = "0x180868560")]
	public static RaftRelease Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000DE9 RID: 3561 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DE9")]
	[Address(RVA = "0x868580", Offset = "0x866B80", VA = "0x180868580")]
	public static RaftRelease Create()
	{
		return null;
	}

	// Token: 0x06000DEA RID: 3562 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DEA")]
	[Address(RVA = "0x8685A0", Offset = "0x866BA0", VA = "0x1808685A0")]
	public static RaftRelease Create(ReliabilityModes reliability)
	{
		return null;
	}
}
