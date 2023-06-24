using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000216 RID: 534
[Token(Token = "0x2000216")]
public class CaveBoardBroken : Event
{
	// Token: 0x0600188D RID: 6285 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600188D")]
	[Address(RVA = "0x8C2110", Offset = "0x8C0710", VA = "0x1808C2110")]
	public CaveBoardBroken()
	{
	}

	// Token: 0x1700073E RID: 1854
	// (get) Token: 0x0600188E RID: 6286 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600188F RID: 6287 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700073E")]
	public BoltEntity Target
	{
		[Token(Token = "0x600188E")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600188F")]
		[Address(RVA = "0x8C2170", Offset = "0x8C0770", VA = "0x1808C2170")]
		set
		{
		}
	}

	// Token: 0x1700073F RID: 1855
	// (get) Token: 0x06001890 RID: 6288 RVA: 0x00007D70 File Offset: 0x00005F70
	// (set) Token: 0x06001891 RID: 6289 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700073F")]
	public int BoardMask
	{
		[Token(Token = "0x6001890")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001891")]
		[Address(RVA = "0x7D6DC0", Offset = "0x7D53C0", VA = "0x1807D6DC0")]
		set
		{
		}
	}

	// Token: 0x06001892 RID: 6290 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001892")]
	[Address(RVA = "0x8C2380", Offset = "0x8C0980", VA = "0x1808C2380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001893 RID: 6291 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001893")]
	[Address(RVA = "0x8C2440", Offset = "0x8C0A40", VA = "0x1808C2440")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CaveBoardBroken Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001894 RID: 6292 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001894")]
	[Address(RVA = "0x8C2450", Offset = "0x8C0A50", VA = "0x1808C2450")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CaveBoardBroken Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001895 RID: 6293 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001895")]
	[Address(RVA = "0x8C2650", Offset = "0x8C0C50", VA = "0x1808C2650")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static CaveBoardBroken Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001896 RID: 6294 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001896")]
	[Address(RVA = "0x8C2770", Offset = "0x8C0D70", VA = "0x1808C2770")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CaveBoardBroken Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001897 RID: 6295 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001897")]
	[Address(RVA = "0x8C2780", Offset = "0x8C0D80", VA = "0x1808C2780")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CaveBoardBroken Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001898 RID: 6296 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001898")]
	[Address(RVA = "0x8C2790", Offset = "0x8C0D90", VA = "0x1808C2790")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CaveBoardBroken Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001899 RID: 6297 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001899")]
	[Address(RVA = "0x8C27A0", Offset = "0x8C0DA0", VA = "0x1808C27A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CaveBoardBroken Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600189A RID: 6298 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600189A")]
	[Address(RVA = "0x8C27C0", Offset = "0x8C0DC0", VA = "0x1808C27C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CaveBoardBroken Raise()
	{
		return null;
	}

	// Token: 0x0600189B RID: 6299 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600189B")]
	[Address(RVA = "0x8C27E0", Offset = "0x8C0DE0", VA = "0x1808C27E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CaveBoardBroken Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600189C RID: 6300 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600189C")]
	[Address(RVA = "0x8C2440", Offset = "0x8C0A40", VA = "0x1808C2440")]
	public static CaveBoardBroken Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600189D RID: 6301 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600189D")]
	[Address(RVA = "0x8C27F0", Offset = "0x8C0DF0", VA = "0x1808C27F0")]
	public static CaveBoardBroken Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600189E RID: 6302 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600189E")]
	[Address(RVA = "0x8C29F0", Offset = "0x8C0FF0", VA = "0x1808C29F0")]
	private static CaveBoardBroken Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600189F RID: 6303 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600189F")]
	[Address(RVA = "0x8C2770", Offset = "0x8C0D70", VA = "0x1808C2770")]
	public static CaveBoardBroken Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060018A0 RID: 6304 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018A0")]
	[Address(RVA = "0x8C2780", Offset = "0x8C0D80", VA = "0x1808C2780")]
	public static CaveBoardBroken Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060018A1 RID: 6305 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018A1")]
	[Address(RVA = "0x8C2790", Offset = "0x8C0D90", VA = "0x1808C2790")]
	public static CaveBoardBroken Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060018A2 RID: 6306 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018A2")]
	[Address(RVA = "0x8C27A0", Offset = "0x8C0DA0", VA = "0x1808C27A0")]
	public static CaveBoardBroken Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060018A3 RID: 6307 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018A3")]
	[Address(RVA = "0x8C27C0", Offset = "0x8C0DC0", VA = "0x1808C27C0")]
	public static CaveBoardBroken Create()
	{
		return null;
	}

	// Token: 0x060018A4 RID: 6308 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018A4")]
	[Address(RVA = "0x8C27E0", Offset = "0x8C0DE0", VA = "0x1808C27E0")]
	public static CaveBoardBroken Create(ReliabilityModes reliability)
	{
		return null;
	}
}
