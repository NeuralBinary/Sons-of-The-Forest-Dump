using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000255 RID: 597
[Token(Token = "0x2000255")]
public class VailReviveEvent : Event
{
	// Token: 0x06001B83 RID: 7043 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B83")]
	[Address(RVA = "0x7E0BB0", Offset = "0x7DF1B0", VA = "0x1807E0BB0")]
	public VailReviveEvent()
	{
	}

	// Token: 0x170007BD RID: 1981
	// (get) Token: 0x06001B84 RID: 7044 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001B85 RID: 7045 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007BD")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001B84")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B85")]
		[Address(RVA = "0x7E0C10", Offset = "0x7DF210", VA = "0x1807E0C10")]
		set
		{
		}
	}

	// Token: 0x06001B86 RID: 7046 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B86")]
	[Address(RVA = "0x7E0E20", Offset = "0x7DF420", VA = "0x1807E0E20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001B87 RID: 7047 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B87")]
	[Address(RVA = "0x7E0E70", Offset = "0x7DF470", VA = "0x1807E0E70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailReviveEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001B88 RID: 7048 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B88")]
	[Address(RVA = "0x7E0E80", Offset = "0x7DF480", VA = "0x1807E0E80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailReviveEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001B89 RID: 7049 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B89")]
	[Address(RVA = "0x7E1080", Offset = "0x7DF680", VA = "0x1807E1080")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static VailReviveEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B8A RID: 7050 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B8A")]
	[Address(RVA = "0x7E11A0", Offset = "0x7DF7A0", VA = "0x1807E11A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailReviveEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001B8B RID: 7051 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B8B")]
	[Address(RVA = "0x7E11B0", Offset = "0x7DF7B0", VA = "0x1807E11B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailReviveEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B8C RID: 7052 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B8C")]
	[Address(RVA = "0x7E11C0", Offset = "0x7DF7C0", VA = "0x1807E11C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailReviveEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001B8D RID: 7053 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B8D")]
	[Address(RVA = "0x7E11D0", Offset = "0x7DF7D0", VA = "0x1807E11D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailReviveEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B8E RID: 7054 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B8E")]
	[Address(RVA = "0x7E11F0", Offset = "0x7DF7F0", VA = "0x1807E11F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailReviveEvent Raise()
	{
		return null;
	}

	// Token: 0x06001B8F RID: 7055 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B8F")]
	[Address(RVA = "0x7E1210", Offset = "0x7DF810", VA = "0x1807E1210")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailReviveEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B90 RID: 7056 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B90")]
	[Address(RVA = "0x7E0E70", Offset = "0x7DF470", VA = "0x1807E0E70")]
	public static VailReviveEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001B91 RID: 7057 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B91")]
	[Address(RVA = "0x7E1220", Offset = "0x7DF820", VA = "0x1807E1220")]
	public static VailReviveEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001B92 RID: 7058 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B92")]
	[Address(RVA = "0x7E1420", Offset = "0x7DFA20", VA = "0x1807E1420")]
	private static VailReviveEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B93 RID: 7059 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B93")]
	[Address(RVA = "0x7E11A0", Offset = "0x7DF7A0", VA = "0x1807E11A0")]
	public static VailReviveEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001B94 RID: 7060 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B94")]
	[Address(RVA = "0x7E11B0", Offset = "0x7DF7B0", VA = "0x1807E11B0")]
	public static VailReviveEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B95 RID: 7061 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B95")]
	[Address(RVA = "0x7E11C0", Offset = "0x7DF7C0", VA = "0x1807E11C0")]
	public static VailReviveEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001B96 RID: 7062 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B96")]
	[Address(RVA = "0x7E11D0", Offset = "0x7DF7D0", VA = "0x1807E11D0")]
	public static VailReviveEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B97 RID: 7063 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B97")]
	[Address(RVA = "0x7E11F0", Offset = "0x7DF7F0", VA = "0x1807E11F0")]
	public static VailReviveEvent Create()
	{
		return null;
	}

	// Token: 0x06001B98 RID: 7064 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B98")]
	[Address(RVA = "0x7E1210", Offset = "0x7DF810", VA = "0x1807E1210")]
	public static VailReviveEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
