using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200019E RID: 414
[Token(Token = "0x200019E")]
public class stuckArrowsSync : Event
{
	// Token: 0x060012DF RID: 4831 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012DF")]
	[Address(RVA = "0x890EA0", Offset = "0x88F4A0", VA = "0x180890EA0")]
	public stuckArrowsSync()
	{
	}

	// Token: 0x1700062D RID: 1581
	// (get) Token: 0x060012E0 RID: 4832 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060012E1 RID: 4833 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700062D")]
	public BoltEntity target
	{
		[Token(Token = "0x60012E0")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60012E1")]
		[Address(RVA = "0x890F00", Offset = "0x88F500", VA = "0x180890F00")]
		set
		{
		}
	}

	// Token: 0x1700062E RID: 1582
	// (get) Token: 0x060012E2 RID: 4834 RVA: 0x00006B28 File Offset: 0x00004D28
	// (set) Token: 0x060012E3 RID: 4835 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700062E")]
	public Vector3 pos
	{
		[Token(Token = "0x60012E2")]
		[Address(RVA = "0x7BCBD0", Offset = "0x7BB1D0", VA = "0x1807BCBD0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60012E3")]
		[Address(RVA = "0x7DD580", Offset = "0x7DBB80", VA = "0x1807DD580")]
		set
		{
		}
	}

	// Token: 0x1700062F RID: 1583
	// (get) Token: 0x060012E4 RID: 4836 RVA: 0x00006B40 File Offset: 0x00004D40
	// (set) Token: 0x060012E5 RID: 4837 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700062F")]
	public Quaternion rot
	{
		[Token(Token = "0x60012E4")]
		[Address(RVA = "0x7BCDA0", Offset = "0x7BB3A0", VA = "0x1807BCDA0")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x60012E5")]
		[Address(RVA = "0x83A2C0", Offset = "0x8388C0", VA = "0x18083A2C0")]
		set
		{
		}
	}

	// Token: 0x17000630 RID: 1584
	// (get) Token: 0x060012E6 RID: 4838 RVA: 0x00006B58 File Offset: 0x00004D58
	// (set) Token: 0x060012E7 RID: 4839 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000630")]
	public int index
	{
		[Token(Token = "0x60012E6")]
		[Address(RVA = "0x7B6B40", Offset = "0x7B5140", VA = "0x1807B6B40")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60012E7")]
		[Address(RVA = "0x891110", Offset = "0x88F710", VA = "0x180891110")]
		set
		{
		}
	}

	// Token: 0x17000631 RID: 1585
	// (get) Token: 0x060012E8 RID: 4840 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060012E9 RID: 4841 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000631")]
	public BoltEntity arrow
	{
		[Token(Token = "0x60012E8")]
		[Address(RVA = "0x8314C0", Offset = "0x82FAC0", VA = "0x1808314C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60012E9")]
		[Address(RVA = "0x8911C0", Offset = "0x88F7C0", VA = "0x1808911C0")]
		set
		{
		}
	}

	// Token: 0x17000632 RID: 1586
	// (get) Token: 0x060012EA RID: 4842 RVA: 0x00006B70 File Offset: 0x00004D70
	// (set) Token: 0x060012EB RID: 4843 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000632")]
	public int type
	{
		[Token(Token = "0x60012EA")]
		[Address(RVA = "0x7E1E00", Offset = "0x7E0400", VA = "0x1807E1E00")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60012EB")]
		[Address(RVA = "0x8913E0", Offset = "0x88F9E0", VA = "0x1808913E0")]
		set
		{
		}
	}

	// Token: 0x17000633 RID: 1587
	// (get) Token: 0x060012EC RID: 4844 RVA: 0x00006B88 File Offset: 0x00004D88
	// (set) Token: 0x060012ED RID: 4845 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000633")]
	public bool removeArrow
	{
		[Token(Token = "0x60012EC")]
		[Address(RVA = "0x835F10", Offset = "0x834510", VA = "0x180835F10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60012ED")]
		[Address(RVA = "0x835F70", Offset = "0x834570", VA = "0x180835F70")]
		set
		{
		}
	}

	// Token: 0x060012EE RID: 4846 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012EE")]
	[Address(RVA = "0x891490", Offset = "0x88FA90", VA = "0x180891490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060012EF RID: 4847 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012EF")]
	[Address(RVA = "0x8919F0", Offset = "0x88FFF0", VA = "0x1808919F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static stuckArrowsSync Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060012F0 RID: 4848 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012F0")]
	[Address(RVA = "0x891A00", Offset = "0x890000", VA = "0x180891A00")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static stuckArrowsSync Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060012F1 RID: 4849 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012F1")]
	[Address(RVA = "0x891C00", Offset = "0x890200", VA = "0x180891C00")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static stuckArrowsSync Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060012F2 RID: 4850 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012F2")]
	[Address(RVA = "0x891D20", Offset = "0x890320", VA = "0x180891D20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static stuckArrowsSync Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060012F3 RID: 4851 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012F3")]
	[Address(RVA = "0x891D30", Offset = "0x890330", VA = "0x180891D30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static stuckArrowsSync Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060012F4 RID: 4852 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012F4")]
	[Address(RVA = "0x891D40", Offset = "0x890340", VA = "0x180891D40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static stuckArrowsSync Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060012F5 RID: 4853 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012F5")]
	[Address(RVA = "0x891D50", Offset = "0x890350", VA = "0x180891D50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static stuckArrowsSync Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060012F6 RID: 4854 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012F6")]
	[Address(RVA = "0x891D70", Offset = "0x890370", VA = "0x180891D70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static stuckArrowsSync Raise()
	{
		return null;
	}

	// Token: 0x060012F7 RID: 4855 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012F7")]
	[Address(RVA = "0x891D90", Offset = "0x890390", VA = "0x180891D90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static stuckArrowsSync Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060012F8 RID: 4856 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012F8")]
	[Address(RVA = "0x8919F0", Offset = "0x88FFF0", VA = "0x1808919F0")]
	public static stuckArrowsSync Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060012F9 RID: 4857 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012F9")]
	[Address(RVA = "0x891DA0", Offset = "0x8903A0", VA = "0x180891DA0")]
	public static stuckArrowsSync Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060012FA RID: 4858 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012FA")]
	[Address(RVA = "0x891FA0", Offset = "0x8905A0", VA = "0x180891FA0")]
	private static stuckArrowsSync Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060012FB RID: 4859 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012FB")]
	[Address(RVA = "0x891D20", Offset = "0x890320", VA = "0x180891D20")]
	public static stuckArrowsSync Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060012FC RID: 4860 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012FC")]
	[Address(RVA = "0x891D30", Offset = "0x890330", VA = "0x180891D30")]
	public static stuckArrowsSync Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060012FD RID: 4861 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012FD")]
	[Address(RVA = "0x891D40", Offset = "0x890340", VA = "0x180891D40")]
	public static stuckArrowsSync Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060012FE RID: 4862 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012FE")]
	[Address(RVA = "0x891D50", Offset = "0x890350", VA = "0x180891D50")]
	public static stuckArrowsSync Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060012FF RID: 4863 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012FF")]
	[Address(RVA = "0x891D70", Offset = "0x890370", VA = "0x180891D70")]
	public static stuckArrowsSync Create()
	{
		return null;
	}

	// Token: 0x06001300 RID: 4864 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001300")]
	[Address(RVA = "0x891D90", Offset = "0x890390", VA = "0x180891D90")]
	public static stuckArrowsSync Create(ReliabilityModes reliability)
	{
		return null;
	}
}
