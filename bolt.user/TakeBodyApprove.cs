using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000153 RID: 339
[Token(Token = "0x2000153")]
public class TakeBodyApprove : Event
{
	// Token: 0x06000F87 RID: 3975 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F87")]
	[Address(RVA = "0x875C60", Offset = "0x874260", VA = "0x180875C60")]
	public TakeBodyApprove()
	{
	}

	// Token: 0x170005AD RID: 1453
	// (get) Token: 0x06000F88 RID: 3976 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000F89 RID: 3977 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005AD")]
	public BoltEntity Body
	{
		[Token(Token = "0x6000F88")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000F89")]
		[Address(RVA = "0x875CC0", Offset = "0x8742C0", VA = "0x180875CC0")]
		set
		{
		}
	}

	// Token: 0x06000F8A RID: 3978 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F8A")]
	[Address(RVA = "0x875ED0", Offset = "0x8744D0", VA = "0x180875ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000F8B RID: 3979 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F8B")]
	[Address(RVA = "0x875F20", Offset = "0x874520", VA = "0x180875F20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TakeBodyApprove Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000F8C RID: 3980 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F8C")]
	[Address(RVA = "0x875F30", Offset = "0x874530", VA = "0x180875F30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TakeBodyApprove Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000F8D RID: 3981 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F8D")]
	[Address(RVA = "0x876130", Offset = "0x874730", VA = "0x180876130")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static TakeBodyApprove Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000F8E RID: 3982 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F8E")]
	[Address(RVA = "0x876250", Offset = "0x874850", VA = "0x180876250")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TakeBodyApprove Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000F8F RID: 3983 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F8F")]
	[Address(RVA = "0x876260", Offset = "0x874860", VA = "0x180876260")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TakeBodyApprove Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000F90 RID: 3984 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F90")]
	[Address(RVA = "0x876270", Offset = "0x874870", VA = "0x180876270")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TakeBodyApprove Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000F91 RID: 3985 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F91")]
	[Address(RVA = "0x876280", Offset = "0x874880", VA = "0x180876280")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TakeBodyApprove Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000F92 RID: 3986 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F92")]
	[Address(RVA = "0x8762A0", Offset = "0x8748A0", VA = "0x1808762A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TakeBodyApprove Raise()
	{
		return null;
	}

	// Token: 0x06000F93 RID: 3987 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F93")]
	[Address(RVA = "0x8762C0", Offset = "0x8748C0", VA = "0x1808762C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TakeBodyApprove Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000F94 RID: 3988 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F94")]
	[Address(RVA = "0x875F20", Offset = "0x874520", VA = "0x180875F20")]
	public static TakeBodyApprove Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000F95 RID: 3989 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F95")]
	[Address(RVA = "0x8762D0", Offset = "0x8748D0", VA = "0x1808762D0")]
	public static TakeBodyApprove Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000F96 RID: 3990 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F96")]
	[Address(RVA = "0x8764D0", Offset = "0x874AD0", VA = "0x1808764D0")]
	private static TakeBodyApprove Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000F97 RID: 3991 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F97")]
	[Address(RVA = "0x876250", Offset = "0x874850", VA = "0x180876250")]
	public static TakeBodyApprove Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000F98 RID: 3992 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F98")]
	[Address(RVA = "0x876260", Offset = "0x874860", VA = "0x180876260")]
	public static TakeBodyApprove Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000F99 RID: 3993 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F99")]
	[Address(RVA = "0x876270", Offset = "0x874870", VA = "0x180876270")]
	public static TakeBodyApprove Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000F9A RID: 3994 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F9A")]
	[Address(RVA = "0x876280", Offset = "0x874880", VA = "0x180876280")]
	public static TakeBodyApprove Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000F9B RID: 3995 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F9B")]
	[Address(RVA = "0x8762A0", Offset = "0x8748A0", VA = "0x1808762A0")]
	public static TakeBodyApprove Create()
	{
		return null;
	}

	// Token: 0x06000F9C RID: 3996 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F9C")]
	[Address(RVA = "0x8762C0", Offset = "0x8748C0", VA = "0x1808762C0")]
	public static TakeBodyApprove Create(ReliabilityModes reliability)
	{
		return null;
	}
}
