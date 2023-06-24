using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001EF RID: 495
[Token(Token = "0x20001EF")]
public class PlayerConnectivityAction : Event
{
	// Token: 0x06001691 RID: 5777 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001691")]
	[Address(RVA = "0x8AFAE0", Offset = "0x8AE0E0", VA = "0x1808AFAE0")]
	public PlayerConnectivityAction()
	{
	}

	// Token: 0x170006D6 RID: 1750
	// (get) Token: 0x06001692 RID: 5778 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001693 RID: 5779 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006D6")]
	public string PlayerName
	{
		[Token(Token = "0x6001692")]
		[Address(RVA = "0x7D27A0", Offset = "0x7D0DA0", VA = "0x1807D27A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001693")]
		[Address(RVA = "0x84C060", Offset = "0x84A660", VA = "0x18084C060")]
		set
		{
		}
	}

	// Token: 0x170006D7 RID: 1751
	// (get) Token: 0x06001694 RID: 5780 RVA: 0x00007620 File Offset: 0x00005820
	// (set) Token: 0x06001695 RID: 5781 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006D7")]
	public Color PlayerColor
	{
		[Token(Token = "0x6001694")]
		[Address(RVA = "0x7FBD60", Offset = "0x7FA360", VA = "0x1807FBD60")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6001695")]
		[Address(RVA = "0x7FBDD0", Offset = "0x7FA3D0", VA = "0x1807FBDD0")]
		set
		{
		}
	}

	// Token: 0x170006D8 RID: 1752
	// (get) Token: 0x06001696 RID: 5782 RVA: 0x00007638 File Offset: 0x00005838
	// (set) Token: 0x06001697 RID: 5783 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006D8")]
	public int ConnectionStateEnum
	{
		[Token(Token = "0x6001696")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001697")]
		[Address(RVA = "0x7D6E60", Offset = "0x7D5460", VA = "0x1807D6E60")]
		set
		{
		}
	}

	// Token: 0x06001698 RID: 5784 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001698")]
	[Address(RVA = "0x8AFB40", Offset = "0x8AE140", VA = "0x1808AFB40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001699 RID: 5785 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001699")]
	[Address(RVA = "0x8AFC90", Offset = "0x8AE290", VA = "0x1808AFC90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static PlayerConnectivityAction Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600169A RID: 5786 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600169A")]
	[Address(RVA = "0x8AFE20", Offset = "0x8AE420", VA = "0x1808AFE20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerConnectivityAction Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600169B RID: 5787 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600169B")]
	[Address(RVA = "0x8AFE30", Offset = "0x8AE430", VA = "0x1808AFE30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerConnectivityAction Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600169C RID: 5788 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600169C")]
	[Address(RVA = "0x8AFE40", Offset = "0x8AE440", VA = "0x1808AFE40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerConnectivityAction Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600169D RID: 5789 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600169D")]
	[Address(RVA = "0x8AFE50", Offset = "0x8AE450", VA = "0x1808AFE50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerConnectivityAction Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600169E RID: 5790 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600169E")]
	[Address(RVA = "0x8AFE70", Offset = "0x8AE470", VA = "0x1808AFE70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerConnectivityAction Raise()
	{
		return null;
	}

	// Token: 0x0600169F RID: 5791 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600169F")]
	[Address(RVA = "0x8AFE90", Offset = "0x8AE490", VA = "0x1808AFE90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerConnectivityAction Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060016A0 RID: 5792 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016A0")]
	[Address(RVA = "0x8AFEA0", Offset = "0x8AE4A0", VA = "0x1808AFEA0")]
	private static PlayerConnectivityAction Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060016A1 RID: 5793 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016A1")]
	[Address(RVA = "0x8AFE20", Offset = "0x8AE420", VA = "0x1808AFE20")]
	public static PlayerConnectivityAction Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060016A2 RID: 5794 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016A2")]
	[Address(RVA = "0x8AFE30", Offset = "0x8AE430", VA = "0x1808AFE30")]
	public static PlayerConnectivityAction Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060016A3 RID: 5795 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016A3")]
	[Address(RVA = "0x8AFE40", Offset = "0x8AE440", VA = "0x1808AFE40")]
	public static PlayerConnectivityAction Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060016A4 RID: 5796 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016A4")]
	[Address(RVA = "0x8AFE50", Offset = "0x8AE450", VA = "0x1808AFE50")]
	public static PlayerConnectivityAction Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060016A5 RID: 5797 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016A5")]
	[Address(RVA = "0x8AFE70", Offset = "0x8AE470", VA = "0x1808AFE70")]
	public static PlayerConnectivityAction Create()
	{
		return null;
	}

	// Token: 0x060016A6 RID: 5798 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016A6")]
	[Address(RVA = "0x8AFE90", Offset = "0x8AE490", VA = "0x1808AFE90")]
	public static PlayerConnectivityAction Create(ReliabilityModes reliability)
	{
		return null;
	}
}
