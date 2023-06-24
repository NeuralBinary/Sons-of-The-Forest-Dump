using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001AA RID: 426
[Token(Token = "0x20001AA")]
public class ServerStatusInfo : Event
{
	// Token: 0x06001373 RID: 4979 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001373")]
	[Address(RVA = "0x896100", Offset = "0x894700", VA = "0x180896100")]
	public ServerStatusInfo()
	{
	}

	// Token: 0x17000649 RID: 1609
	// (get) Token: 0x06001374 RID: 4980 RVA: 0x00006CD8 File Offset: 0x00004ED8
	// (set) Token: 0x06001375 RID: 4981 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000649")]
	public int Status
	{
		[Token(Token = "0x6001374")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001375")]
		[Address(RVA = "0x7FDC20", Offset = "0x7FC220", VA = "0x1807FDC20")]
		set
		{
		}
	}

	// Token: 0x06001376 RID: 4982 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001376")]
	[Address(RVA = "0x896160", Offset = "0x894760", VA = "0x180896160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001377 RID: 4983 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001377")]
	[Address(RVA = "0x896210", Offset = "0x894810", VA = "0x180896210")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ServerStatusInfo Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001378 RID: 4984 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001378")]
	[Address(RVA = "0x896220", Offset = "0x894820", VA = "0x180896220")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ServerStatusInfo Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001379 RID: 4985 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001379")]
	[Address(RVA = "0x896420", Offset = "0x894A20", VA = "0x180896420")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static ServerStatusInfo Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600137A RID: 4986 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600137A")]
	[Address(RVA = "0x896540", Offset = "0x894B40", VA = "0x180896540")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ServerStatusInfo Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600137B RID: 4987 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600137B")]
	[Address(RVA = "0x896550", Offset = "0x894B50", VA = "0x180896550")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ServerStatusInfo Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600137C RID: 4988 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600137C")]
	[Address(RVA = "0x896560", Offset = "0x894B60", VA = "0x180896560")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ServerStatusInfo Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600137D RID: 4989 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600137D")]
	[Address(RVA = "0x896570", Offset = "0x894B70", VA = "0x180896570")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ServerStatusInfo Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600137E RID: 4990 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600137E")]
	[Address(RVA = "0x896590", Offset = "0x894B90", VA = "0x180896590")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ServerStatusInfo Raise()
	{
		return null;
	}

	// Token: 0x0600137F RID: 4991 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600137F")]
	[Address(RVA = "0x8965B0", Offset = "0x894BB0", VA = "0x1808965B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ServerStatusInfo Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001380 RID: 4992 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001380")]
	[Address(RVA = "0x896210", Offset = "0x894810", VA = "0x180896210")]
	public static ServerStatusInfo Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001381 RID: 4993 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001381")]
	[Address(RVA = "0x8965C0", Offset = "0x894BC0", VA = "0x1808965C0")]
	public static ServerStatusInfo Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001382 RID: 4994 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001382")]
	[Address(RVA = "0x8967C0", Offset = "0x894DC0", VA = "0x1808967C0")]
	private static ServerStatusInfo Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001383 RID: 4995 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001383")]
	[Address(RVA = "0x896540", Offset = "0x894B40", VA = "0x180896540")]
	public static ServerStatusInfo Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001384 RID: 4996 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001384")]
	[Address(RVA = "0x896550", Offset = "0x894B50", VA = "0x180896550")]
	public static ServerStatusInfo Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001385 RID: 4997 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001385")]
	[Address(RVA = "0x896560", Offset = "0x894B60", VA = "0x180896560")]
	public static ServerStatusInfo Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001386 RID: 4998 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001386")]
	[Address(RVA = "0x896570", Offset = "0x894B70", VA = "0x180896570")]
	public static ServerStatusInfo Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001387 RID: 4999 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001387")]
	[Address(RVA = "0x896590", Offset = "0x894B90", VA = "0x180896590")]
	public static ServerStatusInfo Create()
	{
		return null;
	}

	// Token: 0x06001388 RID: 5000 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001388")]
	[Address(RVA = "0x8965B0", Offset = "0x894BB0", VA = "0x1808965B0")]
	public static ServerStatusInfo Create(ReliabilityModes reliability)
	{
		return null;
	}
}
