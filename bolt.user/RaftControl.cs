using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000159 RID: 345
[Token(Token = "0x2000159")]
public class RaftControl : Event
{
	// Token: 0x06000FCB RID: 4043 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FCB")]
	[Address(RVA = "0x877BE0", Offset = "0x8761E0", VA = "0x180877BE0")]
	public RaftControl()
	{
	}

	// Token: 0x170005B7 RID: 1463
	// (get) Token: 0x06000FCC RID: 4044 RVA: 0x00006468 File Offset: 0x00004668
	// (set) Token: 0x06000FCD RID: 4045 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005B7")]
	public int Movement
	{
		[Token(Token = "0x6000FCC")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000FCD")]
		[Address(RVA = "0x877C40", Offset = "0x876240", VA = "0x180877C40")]
		set
		{
		}
	}

	// Token: 0x170005B8 RID: 1464
	// (get) Token: 0x06000FCE RID: 4046 RVA: 0x00006480 File Offset: 0x00004680
	// (set) Token: 0x06000FCF RID: 4047 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005B8")]
	public float Rotation
	{
		[Token(Token = "0x6000FCE")]
		[Address(RVA = "0x7B78E0", Offset = "0x7B5EE0", VA = "0x1807B78E0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000FCF")]
		[Address(RVA = "0x861E70", Offset = "0x860470", VA = "0x180861E70")]
		set
		{
		}
	}

	// Token: 0x170005B9 RID: 1465
	// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005B9")]
	public BoltEntity Raft
	{
		[Token(Token = "0x6000FD0")]
		[Address(RVA = "0x80A6A0", Offset = "0x808CA0", VA = "0x18080A6A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000FD1")]
		[Address(RVA = "0x877CE0", Offset = "0x8762E0", VA = "0x180877CE0")]
		set
		{
		}
	}

	// Token: 0x170005BA RID: 1466
	// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x00006498 File Offset: 0x00004698
	// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005BA")]
	public int OarId
	{
		[Token(Token = "0x6000FD2")]
		[Address(RVA = "0x7B6B40", Offset = "0x7B5140", VA = "0x1807B6B40")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000FD3")]
		[Address(RVA = "0x877F00", Offset = "0x876500", VA = "0x180877F00")]
		set
		{
		}
	}

	// Token: 0x06000FD4 RID: 4052 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FD4")]
	[Address(RVA = "0x877FB0", Offset = "0x8765B0", VA = "0x180877FB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000FD5 RID: 4053 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FD5")]
	[Address(RVA = "0x8782F0", Offset = "0x8768F0", VA = "0x1808782F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RaftControl Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000FD6 RID: 4054 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FD6")]
	[Address(RVA = "0x878300", Offset = "0x876900", VA = "0x180878300")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RaftControl Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000FD7 RID: 4055 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FD7")]
	[Address(RVA = "0x878500", Offset = "0x876B00", VA = "0x180878500")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static RaftControl Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000FD8 RID: 4056 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FD8")]
	[Address(RVA = "0x878620", Offset = "0x876C20", VA = "0x180878620")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RaftControl Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000FD9 RID: 4057 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FD9")]
	[Address(RVA = "0x878630", Offset = "0x876C30", VA = "0x180878630")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RaftControl Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000FDA RID: 4058 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FDA")]
	[Address(RVA = "0x878640", Offset = "0x876C40", VA = "0x180878640")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RaftControl Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000FDB RID: 4059 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FDB")]
	[Address(RVA = "0x878650", Offset = "0x876C50", VA = "0x180878650")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RaftControl Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000FDC RID: 4060 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FDC")]
	[Address(RVA = "0x878670", Offset = "0x876C70", VA = "0x180878670")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RaftControl Raise()
	{
		return null;
	}

	// Token: 0x06000FDD RID: 4061 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FDD")]
	[Address(RVA = "0x878690", Offset = "0x876C90", VA = "0x180878690")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RaftControl Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000FDE RID: 4062 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FDE")]
	[Address(RVA = "0x8782F0", Offset = "0x8768F0", VA = "0x1808782F0")]
	public static RaftControl Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000FDF RID: 4063 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FDF")]
	[Address(RVA = "0x8786A0", Offset = "0x876CA0", VA = "0x1808786A0")]
	public static RaftControl Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000FE0 RID: 4064 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FE0")]
	[Address(RVA = "0x8788A0", Offset = "0x876EA0", VA = "0x1808788A0")]
	private static RaftControl Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000FE1 RID: 4065 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FE1")]
	[Address(RVA = "0x878620", Offset = "0x876C20", VA = "0x180878620")]
	public static RaftControl Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000FE2 RID: 4066 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FE2")]
	[Address(RVA = "0x878630", Offset = "0x876C30", VA = "0x180878630")]
	public static RaftControl Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000FE3 RID: 4067 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FE3")]
	[Address(RVA = "0x878640", Offset = "0x876C40", VA = "0x180878640")]
	public static RaftControl Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000FE4 RID: 4068 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FE4")]
	[Address(RVA = "0x878650", Offset = "0x876C50", VA = "0x180878650")]
	public static RaftControl Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000FE5 RID: 4069 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FE5")]
	[Address(RVA = "0x878670", Offset = "0x876C70", VA = "0x180878670")]
	public static RaftControl Create()
	{
		return null;
	}

	// Token: 0x06000FE6 RID: 4070 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FE6")]
	[Address(RVA = "0x878690", Offset = "0x876C90", VA = "0x180878690")]
	public static RaftControl Create(ReliabilityModes reliability)
	{
		return null;
	}
}
