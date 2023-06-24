using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000123 RID: 291
[Token(Token = "0x2000123")]
public class TripWire : Event
{
	// Token: 0x06000D67 RID: 3431 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D67")]
	[Address(RVA = "0x8641C0", Offset = "0x8627C0", VA = "0x1808641C0")]
	public TripWire()
	{
	}

	// Token: 0x1700055D RID: 1373
	// (get) Token: 0x06000D68 RID: 3432 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000D69 RID: 3433 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700055D")]
	public BoltEntity WireEntity
	{
		[Token(Token = "0x6000D68")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D69")]
		[Address(RVA = "0x864220", Offset = "0x862820", VA = "0x180864220")]
		set
		{
		}
	}

	// Token: 0x06000D6A RID: 3434 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D6A")]
	[Address(RVA = "0x864430", Offset = "0x862A30", VA = "0x180864430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000D6B RID: 3435 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D6B")]
	[Address(RVA = "0x8644F0", Offset = "0x862AF0", VA = "0x1808644F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TripWire Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000D6C RID: 3436 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D6C")]
	[Address(RVA = "0x864500", Offset = "0x862B00", VA = "0x180864500")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TripWire Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000D6D RID: 3437 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D6D")]
	[Address(RVA = "0x864700", Offset = "0x862D00", VA = "0x180864700")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static TripWire Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D6E RID: 3438 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D6E")]
	[Address(RVA = "0x864820", Offset = "0x862E20", VA = "0x180864820")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TripWire Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000D6F RID: 3439 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D6F")]
	[Address(RVA = "0x864830", Offset = "0x862E30", VA = "0x180864830")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TripWire Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D70 RID: 3440 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D70")]
	[Address(RVA = "0x864840", Offset = "0x862E40", VA = "0x180864840")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TripWire Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000D71 RID: 3441 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D71")]
	[Address(RVA = "0x864850", Offset = "0x862E50", VA = "0x180864850")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TripWire Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D72 RID: 3442 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D72")]
	[Address(RVA = "0x864870", Offset = "0x862E70", VA = "0x180864870")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TripWire Raise()
	{
		return null;
	}

	// Token: 0x06000D73 RID: 3443 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D73")]
	[Address(RVA = "0x864890", Offset = "0x862E90", VA = "0x180864890")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TripWire Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D74 RID: 3444 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D74")]
	[Address(RVA = "0x8644F0", Offset = "0x862AF0", VA = "0x1808644F0")]
	public static TripWire Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000D75 RID: 3445 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D75")]
	[Address(RVA = "0x8648A0", Offset = "0x862EA0", VA = "0x1808648A0")]
	public static TripWire Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000D76 RID: 3446 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D76")]
	[Address(RVA = "0x864AA0", Offset = "0x8630A0", VA = "0x180864AA0")]
	private static TripWire Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D77 RID: 3447 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D77")]
	[Address(RVA = "0x864820", Offset = "0x862E20", VA = "0x180864820")]
	public static TripWire Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000D78 RID: 3448 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D78")]
	[Address(RVA = "0x864830", Offset = "0x862E30", VA = "0x180864830")]
	public static TripWire Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D79 RID: 3449 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D79")]
	[Address(RVA = "0x864840", Offset = "0x862E40", VA = "0x180864840")]
	public static TripWire Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000D7A RID: 3450 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D7A")]
	[Address(RVA = "0x864850", Offset = "0x862E50", VA = "0x180864850")]
	public static TripWire Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D7B RID: 3451 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D7B")]
	[Address(RVA = "0x864870", Offset = "0x862E70", VA = "0x180864870")]
	public static TripWire Create()
	{
		return null;
	}

	// Token: 0x06000D7C RID: 3452 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D7C")]
	[Address(RVA = "0x864890", Offset = "0x862E90", VA = "0x180864890")]
	public static TripWire Create(ReliabilityModes reliability)
	{
		return null;
	}
}
