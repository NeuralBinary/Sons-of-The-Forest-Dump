using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000144 RID: 324
[Token(Token = "0x2000144")]
public class AddBody : Event
{
	// Token: 0x06000EE5 RID: 3813 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EE5")]
	[Address(RVA = "0x870B70", Offset = "0x86F170", VA = "0x180870B70")]
	public AddBody()
	{
	}

	// Token: 0x17000598 RID: 1432
	// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000EE7 RID: 3815 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000598")]
	public BoltEntity Body
	{
		[Token(Token = "0x6000EE6")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000EE7")]
		[Address(RVA = "0x870BD0", Offset = "0x86F1D0", VA = "0x180870BD0")]
		set
		{
		}
	}

	// Token: 0x17000599 RID: 1433
	// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000EE9 RID: 3817 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000599")]
	public BoltEntity Sled
	{
		[Token(Token = "0x6000EE8")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000EE9")]
		[Address(RVA = "0x870DE0", Offset = "0x86F3E0", VA = "0x180870DE0")]
		set
		{
		}
	}

	// Token: 0x06000EEA RID: 3818 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EEA")]
	[Address(RVA = "0x870FF0", Offset = "0x86F5F0", VA = "0x180870FF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000EEB RID: 3819 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EEB")]
	[Address(RVA = "0x871160", Offset = "0x86F760", VA = "0x180871160")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AddBody Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000EEC RID: 3820 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EEC")]
	[Address(RVA = "0x871170", Offset = "0x86F770", VA = "0x180871170")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AddBody Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000EED RID: 3821 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EED")]
	[Address(RVA = "0x871370", Offset = "0x86F970", VA = "0x180871370")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static AddBody Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000EEE RID: 3822 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EEE")]
	[Address(RVA = "0x871490", Offset = "0x86FA90", VA = "0x180871490")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AddBody Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000EEF RID: 3823 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EEF")]
	[Address(RVA = "0x8714A0", Offset = "0x86FAA0", VA = "0x1808714A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AddBody Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000EF0 RID: 3824 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EF0")]
	[Address(RVA = "0x8714B0", Offset = "0x86FAB0", VA = "0x1808714B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AddBody Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000EF1 RID: 3825 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EF1")]
	[Address(RVA = "0x8714C0", Offset = "0x86FAC0", VA = "0x1808714C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AddBody Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000EF2 RID: 3826 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EF2")]
	[Address(RVA = "0x8714E0", Offset = "0x86FAE0", VA = "0x1808714E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AddBody Raise()
	{
		return null;
	}

	// Token: 0x06000EF3 RID: 3827 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EF3")]
	[Address(RVA = "0x871500", Offset = "0x86FB00", VA = "0x180871500")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AddBody Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000EF4 RID: 3828 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EF4")]
	[Address(RVA = "0x871160", Offset = "0x86F760", VA = "0x180871160")]
	public static AddBody Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000EF5 RID: 3829 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EF5")]
	[Address(RVA = "0x871510", Offset = "0x86FB10", VA = "0x180871510")]
	public static AddBody Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000EF6 RID: 3830 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EF6")]
	[Address(RVA = "0x871710", Offset = "0x86FD10", VA = "0x180871710")]
	private static AddBody Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000EF7 RID: 3831 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EF7")]
	[Address(RVA = "0x871490", Offset = "0x86FA90", VA = "0x180871490")]
	public static AddBody Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000EF8 RID: 3832 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EF8")]
	[Address(RVA = "0x8714A0", Offset = "0x86FAA0", VA = "0x1808714A0")]
	public static AddBody Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000EF9 RID: 3833 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EF9")]
	[Address(RVA = "0x8714B0", Offset = "0x86FAB0", VA = "0x1808714B0")]
	public static AddBody Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000EFA RID: 3834 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EFA")]
	[Address(RVA = "0x8714C0", Offset = "0x86FAC0", VA = "0x1808714C0")]
	public static AddBody Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000EFB RID: 3835 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EFB")]
	[Address(RVA = "0x8714E0", Offset = "0x86FAE0", VA = "0x1808714E0")]
	public static AddBody Create()
	{
		return null;
	}

	// Token: 0x06000EFC RID: 3836 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EFC")]
	[Address(RVA = "0x871500", Offset = "0x86FB00", VA = "0x180871500")]
	public static AddBody Create(ReliabilityModes reliability)
	{
		return null;
	}
}
