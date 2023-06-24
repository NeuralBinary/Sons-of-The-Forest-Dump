using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000129 RID: 297
[Token(Token = "0x2000129")]
public class RaftGrab : Event
{
	// Token: 0x06000DA9 RID: 3497 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DA9")]
	[Address(RVA = "0x866350", Offset = "0x864950", VA = "0x180866350")]
	public RaftGrab()
	{
	}

	// Token: 0x17000566 RID: 1382
	// (get) Token: 0x06000DAA RID: 3498 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000DAB RID: 3499 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000566")]
	public BoltEntity Player
	{
		[Token(Token = "0x6000DAA")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000DAB")]
		[Address(RVA = "0x8663B0", Offset = "0x8649B0", VA = "0x1808663B0")]
		set
		{
		}
	}

	// Token: 0x17000567 RID: 1383
	// (get) Token: 0x06000DAC RID: 3500 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000DAD RID: 3501 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000567")]
	public BoltEntity Raft
	{
		[Token(Token = "0x6000DAC")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000DAD")]
		[Address(RVA = "0x8665C0", Offset = "0x864BC0", VA = "0x1808665C0")]
		set
		{
		}
	}

	// Token: 0x17000568 RID: 1384
	// (get) Token: 0x06000DAE RID: 3502 RVA: 0x00005FD0 File Offset: 0x000041D0
	// (set) Token: 0x06000DAF RID: 3503 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000568")]
	public int OarId
	{
		[Token(Token = "0x6000DAE")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000DAF")]
		[Address(RVA = "0x8667D0", Offset = "0x864DD0", VA = "0x1808667D0")]
		set
		{
		}
	}

	// Token: 0x06000DB0 RID: 3504 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DB0")]
	[Address(RVA = "0x866880", Offset = "0x864E80", VA = "0x180866880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000DB1 RID: 3505 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DB1")]
	[Address(RVA = "0x866A60", Offset = "0x865060", VA = "0x180866A60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RaftGrab Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000DB2 RID: 3506 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DB2")]
	[Address(RVA = "0x866A70", Offset = "0x865070", VA = "0x180866A70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RaftGrab Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000DB3 RID: 3507 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DB3")]
	[Address(RVA = "0x866C70", Offset = "0x865270", VA = "0x180866C70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static RaftGrab Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000DB4 RID: 3508 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DB4")]
	[Address(RVA = "0x866D90", Offset = "0x865390", VA = "0x180866D90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RaftGrab Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000DB5 RID: 3509 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DB5")]
	[Address(RVA = "0x866DA0", Offset = "0x8653A0", VA = "0x180866DA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RaftGrab Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000DB6 RID: 3510 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DB6")]
	[Address(RVA = "0x866DB0", Offset = "0x8653B0", VA = "0x180866DB0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RaftGrab Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000DB7 RID: 3511 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DB7")]
	[Address(RVA = "0x866DC0", Offset = "0x8653C0", VA = "0x180866DC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RaftGrab Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000DB8 RID: 3512 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DB8")]
	[Address(RVA = "0x866DE0", Offset = "0x8653E0", VA = "0x180866DE0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RaftGrab Raise()
	{
		return null;
	}

	// Token: 0x06000DB9 RID: 3513 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DB9")]
	[Address(RVA = "0x866E00", Offset = "0x865400", VA = "0x180866E00")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RaftGrab Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000DBA RID: 3514 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DBA")]
	[Address(RVA = "0x866A60", Offset = "0x865060", VA = "0x180866A60")]
	public static RaftGrab Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000DBB RID: 3515 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DBB")]
	[Address(RVA = "0x866E10", Offset = "0x865410", VA = "0x180866E10")]
	public static RaftGrab Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000DBC RID: 3516 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DBC")]
	[Address(RVA = "0x867010", Offset = "0x865610", VA = "0x180867010")]
	private static RaftGrab Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000DBD RID: 3517 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DBD")]
	[Address(RVA = "0x866D90", Offset = "0x865390", VA = "0x180866D90")]
	public static RaftGrab Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000DBE RID: 3518 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DBE")]
	[Address(RVA = "0x866DA0", Offset = "0x8653A0", VA = "0x180866DA0")]
	public static RaftGrab Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000DBF RID: 3519 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DBF")]
	[Address(RVA = "0x866DB0", Offset = "0x8653B0", VA = "0x180866DB0")]
	public static RaftGrab Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000DC0 RID: 3520 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DC0")]
	[Address(RVA = "0x866DC0", Offset = "0x8653C0", VA = "0x180866DC0")]
	public static RaftGrab Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000DC1 RID: 3521 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DC1")]
	[Address(RVA = "0x866DE0", Offset = "0x8653E0", VA = "0x180866DE0")]
	public static RaftGrab Create()
	{
		return null;
	}

	// Token: 0x06000DC2 RID: 3522 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DC2")]
	[Address(RVA = "0x866E00", Offset = "0x865400", VA = "0x180866E00")]
	public static RaftGrab Create(ReliabilityModes reliability)
	{
		return null;
	}
}
