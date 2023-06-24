using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000222 RID: 546
[Token(Token = "0x2000222")]
public class ActivateVailActor : Event
{
	// Token: 0x06001919 RID: 6425 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001919")]
	[Address(RVA = "0x8C6780", Offset = "0x8C4D80", VA = "0x1808C6780")]
	public ActivateVailActor()
	{
	}

	// Token: 0x17000754 RID: 1876
	// (get) Token: 0x0600191A RID: 6426 RVA: 0x00007ED8 File Offset: 0x000060D8
	// (set) Token: 0x0600191B RID: 6427 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000754")]
	public bool Active
	{
		[Token(Token = "0x600191A")]
		[Address(RVA = "0x7B4A10", Offset = "0x7B3010", VA = "0x1807B4A10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600191B")]
		[Address(RVA = "0x7DB320", Offset = "0x7D9920", VA = "0x1807DB320")]
		set
		{
		}
	}

	// Token: 0x17000755 RID: 1877
	// (get) Token: 0x0600191C RID: 6428 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600191D RID: 6429 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000755")]
	public BoltEntity Target
	{
		[Token(Token = "0x600191C")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600191D")]
		[Address(RVA = "0x8C67E0", Offset = "0x8C4DE0", VA = "0x1808C67E0")]
		set
		{
		}
	}

	// Token: 0x0600191E RID: 6430 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600191E")]
	[Address(RVA = "0x8C69F0", Offset = "0x8C4FF0", VA = "0x1808C69F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0600191F RID: 6431 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600191F")]
	[Address(RVA = "0x8C6AB0", Offset = "0x8C50B0", VA = "0x1808C6AB0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ActivateVailActor Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001920 RID: 6432 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001920")]
	[Address(RVA = "0x8C6AC0", Offset = "0x8C50C0", VA = "0x1808C6AC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ActivateVailActor Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001921 RID: 6433 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001921")]
	[Address(RVA = "0x8C6CC0", Offset = "0x8C52C0", VA = "0x1808C6CC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static ActivateVailActor Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001922 RID: 6434 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001922")]
	[Address(RVA = "0x8C6DE0", Offset = "0x8C53E0", VA = "0x1808C6DE0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ActivateVailActor Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001923 RID: 6435 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001923")]
	[Address(RVA = "0x8C6DF0", Offset = "0x8C53F0", VA = "0x1808C6DF0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ActivateVailActor Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001924 RID: 6436 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001924")]
	[Address(RVA = "0x8C6E00", Offset = "0x8C5400", VA = "0x1808C6E00")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ActivateVailActor Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001925 RID: 6437 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001925")]
	[Address(RVA = "0x8C6E10", Offset = "0x8C5410", VA = "0x1808C6E10")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ActivateVailActor Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001926 RID: 6438 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001926")]
	[Address(RVA = "0x8C6E30", Offset = "0x8C5430", VA = "0x1808C6E30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ActivateVailActor Raise()
	{
		return null;
	}

	// Token: 0x06001927 RID: 6439 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001927")]
	[Address(RVA = "0x8C6E50", Offset = "0x8C5450", VA = "0x1808C6E50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ActivateVailActor Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001928 RID: 6440 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001928")]
	[Address(RVA = "0x8C6AB0", Offset = "0x8C50B0", VA = "0x1808C6AB0")]
	public static ActivateVailActor Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001929 RID: 6441 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001929")]
	[Address(RVA = "0x8C6E60", Offset = "0x8C5460", VA = "0x1808C6E60")]
	public static ActivateVailActor Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600192A RID: 6442 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600192A")]
	[Address(RVA = "0x8C7060", Offset = "0x8C5660", VA = "0x1808C7060")]
	private static ActivateVailActor Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600192B RID: 6443 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600192B")]
	[Address(RVA = "0x8C6DE0", Offset = "0x8C53E0", VA = "0x1808C6DE0")]
	public static ActivateVailActor Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600192C RID: 6444 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600192C")]
	[Address(RVA = "0x8C6DF0", Offset = "0x8C53F0", VA = "0x1808C6DF0")]
	public static ActivateVailActor Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600192D RID: 6445 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600192D")]
	[Address(RVA = "0x8C6E00", Offset = "0x8C5400", VA = "0x1808C6E00")]
	public static ActivateVailActor Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600192E RID: 6446 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600192E")]
	[Address(RVA = "0x8C6E10", Offset = "0x8C5410", VA = "0x1808C6E10")]
	public static ActivateVailActor Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600192F RID: 6447 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600192F")]
	[Address(RVA = "0x8C6E30", Offset = "0x8C5430", VA = "0x1808C6E30")]
	public static ActivateVailActor Create()
	{
		return null;
	}

	// Token: 0x06001930 RID: 6448 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001930")]
	[Address(RVA = "0x8C6E50", Offset = "0x8C5450", VA = "0x1808C6E50")]
	public static ActivateVailActor Create(ReliabilityModes reliability)
	{
		return null;
	}
}
