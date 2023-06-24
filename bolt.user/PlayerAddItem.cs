using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000111 RID: 273
[Token(Token = "0x2000111")]
public class PlayerAddItem : Event
{
	// Token: 0x06000C8B RID: 3211 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C8B")]
	[Address(RVA = "0x85C4D0", Offset = "0x85AAD0", VA = "0x18085C4D0")]
	public PlayerAddItem()
	{
	}

	// Token: 0x17000537 RID: 1335
	// (get) Token: 0x06000C8C RID: 3212 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000C8D RID: 3213 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000537")]
	public BoltEntity Player
	{
		[Token(Token = "0x6000C8C")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C8D")]
		[Address(RVA = "0x85C530", Offset = "0x85AB30", VA = "0x18085C530")]
		set
		{
		}
	}

	// Token: 0x17000538 RID: 1336
	// (get) Token: 0x06000C8E RID: 3214 RVA: 0x00005D48 File Offset: 0x00003F48
	// (set) Token: 0x06000C8F RID: 3215 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000538")]
	public int ItemId
	{
		[Token(Token = "0x6000C8E")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000C8F")]
		[Address(RVA = "0x85C740", Offset = "0x85AD40", VA = "0x18085C740")]
		set
		{
		}
	}

	// Token: 0x17000539 RID: 1337
	// (get) Token: 0x06000C90 RID: 3216 RVA: 0x00005D60 File Offset: 0x00003F60
	// (set) Token: 0x06000C91 RID: 3217 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000539")]
	public int Amount
	{
		[Token(Token = "0x6000C90")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000C91")]
		[Address(RVA = "0x7D6E60", Offset = "0x7D5460", VA = "0x1807D6E60")]
		set
		{
		}
	}

	// Token: 0x1700053A RID: 1338
	// (get) Token: 0x06000C92 RID: 3218 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000C93 RID: 3219 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700053A")]
	public IProtocolToken ItemInstance
	{
		[Token(Token = "0x6000C92")]
		[Address(RVA = "0x7BDAB0", Offset = "0x7BC0B0", VA = "0x1807BDAB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C93")]
		[Address(RVA = "0x7D6F00", Offset = "0x7D5500", VA = "0x1807D6F00")]
		set
		{
		}
	}

	// Token: 0x06000C94 RID: 3220 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C94")]
	[Address(RVA = "0x85C7F0", Offset = "0x85ADF0", VA = "0x18085C7F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000C95 RID: 3221 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C95")]
	[Address(RVA = "0x85CA50", Offset = "0x85B050", VA = "0x18085CA50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerAddItem Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000C96 RID: 3222 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C96")]
	[Address(RVA = "0x85CA60", Offset = "0x85B060", VA = "0x18085CA60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerAddItem Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000C97 RID: 3223 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C97")]
	[Address(RVA = "0x85CC60", Offset = "0x85B260", VA = "0x18085CC60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static PlayerAddItem Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C98 RID: 3224 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C98")]
	[Address(RVA = "0x85CD80", Offset = "0x85B380", VA = "0x18085CD80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerAddItem Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000C99 RID: 3225 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C99")]
	[Address(RVA = "0x85CD90", Offset = "0x85B390", VA = "0x18085CD90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerAddItem Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C9A RID: 3226 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C9A")]
	[Address(RVA = "0x85CDA0", Offset = "0x85B3A0", VA = "0x18085CDA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerAddItem Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000C9B RID: 3227 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C9B")]
	[Address(RVA = "0x85CDB0", Offset = "0x85B3B0", VA = "0x18085CDB0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerAddItem Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C9C RID: 3228 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C9C")]
	[Address(RVA = "0x85CDD0", Offset = "0x85B3D0", VA = "0x18085CDD0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerAddItem Raise()
	{
		return null;
	}

	// Token: 0x06000C9D RID: 3229 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C9D")]
	[Address(RVA = "0x85CDF0", Offset = "0x85B3F0", VA = "0x18085CDF0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerAddItem Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C9E RID: 3230 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C9E")]
	[Address(RVA = "0x85CA50", Offset = "0x85B050", VA = "0x18085CA50")]
	public static PlayerAddItem Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000C9F RID: 3231 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C9F")]
	[Address(RVA = "0x85CE00", Offset = "0x85B400", VA = "0x18085CE00")]
	public static PlayerAddItem Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000CA0 RID: 3232 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CA0")]
	[Address(RVA = "0x85D000", Offset = "0x85B600", VA = "0x18085D000")]
	private static PlayerAddItem Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000CA1 RID: 3233 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CA1")]
	[Address(RVA = "0x85CD80", Offset = "0x85B380", VA = "0x18085CD80")]
	public static PlayerAddItem Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000CA2 RID: 3234 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CA2")]
	[Address(RVA = "0x85CD90", Offset = "0x85B390", VA = "0x18085CD90")]
	public static PlayerAddItem Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000CA3 RID: 3235 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CA3")]
	[Address(RVA = "0x85CDA0", Offset = "0x85B3A0", VA = "0x18085CDA0")]
	public static PlayerAddItem Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000CA4 RID: 3236 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CA4")]
	[Address(RVA = "0x85CDB0", Offset = "0x85B3B0", VA = "0x18085CDB0")]
	public static PlayerAddItem Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000CA5 RID: 3237 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CA5")]
	[Address(RVA = "0x85CDD0", Offset = "0x85B3D0", VA = "0x18085CDD0")]
	public static PlayerAddItem Create()
	{
		return null;
	}

	// Token: 0x06000CA6 RID: 3238 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CA6")]
	[Address(RVA = "0x85CDF0", Offset = "0x85B3F0", VA = "0x18085CDF0")]
	public static PlayerAddItem Create(ReliabilityModes reliability)
	{
		return null;
	}
}
