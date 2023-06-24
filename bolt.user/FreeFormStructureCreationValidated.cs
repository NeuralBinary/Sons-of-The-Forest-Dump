using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000273 RID: 627
[Token(Token = "0x2000273")]
public class FreeFormStructureCreationValidated : Event
{
	// Token: 0x06001CD3 RID: 7379 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CD3")]
	[Address(RVA = "0x7EB410", Offset = "0x7E9A10", VA = "0x1807EB410")]
	public FreeFormStructureCreationValidated()
	{
	}

	// Token: 0x170007EF RID: 2031
	// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x00008898 File Offset: 0x00006A98
	// (set) Token: 0x06001CD5 RID: 7381 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007EF")]
	public int ActionNum
	{
		[Token(Token = "0x6001CD4")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001CD5")]
		[Address(RVA = "0x7EB470", Offset = "0x7E9A70", VA = "0x1807EB470")]
		set
		{
		}
	}

	// Token: 0x170007F0 RID: 2032
	// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x000088B0 File Offset: 0x00006AB0
	// (set) Token: 0x06001CD7 RID: 7383 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007F0")]
	public int TypeID
	{
		[Token(Token = "0x6001CD6")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001CD7")]
		[Address(RVA = "0x7EB500", Offset = "0x7E9B00", VA = "0x1807EB500")]
		set
		{
		}
	}

	// Token: 0x170007F1 RID: 2033
	// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x000088C8 File Offset: 0x00006AC8
	// (set) Token: 0x06001CD9 RID: 7385 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007F1")]
	public int InstanceID
	{
		[Token(Token = "0x6001CD8")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001CD9")]
		[Address(RVA = "0x7D6E60", Offset = "0x7D5460", VA = "0x1807D6E60")]
		set
		{
		}
	}

	// Token: 0x06001CDA RID: 7386 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CDA")]
	[Address(RVA = "0x7EB5B0", Offset = "0x7E9BB0", VA = "0x1807EB5B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001CDB RID: 7387 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CDB")]
	[Address(RVA = "0x7EB740", Offset = "0x7E9D40", VA = "0x1807EB740")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static FreeFormStructureCreationValidated Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001CDC RID: 7388 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CDC")]
	[Address(RVA = "0x7EB8D0", Offset = "0x7E9ED0", VA = "0x1807EB8D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureCreationValidated Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001CDD RID: 7389 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CDD")]
	[Address(RVA = "0x7EB8E0", Offset = "0x7E9EE0", VA = "0x1807EB8E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureCreationValidated Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001CDE RID: 7390 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CDE")]
	[Address(RVA = "0x7EB8F0", Offset = "0x7E9EF0", VA = "0x1807EB8F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureCreationValidated Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001CDF RID: 7391 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CDF")]
	[Address(RVA = "0x7EB900", Offset = "0x7E9F00", VA = "0x1807EB900")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureCreationValidated Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001CE0 RID: 7392 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CE0")]
	[Address(RVA = "0x7EB920", Offset = "0x7E9F20", VA = "0x1807EB920")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureCreationValidated Raise()
	{
		return null;
	}

	// Token: 0x06001CE1 RID: 7393 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CE1")]
	[Address(RVA = "0x7EB940", Offset = "0x7E9F40", VA = "0x1807EB940")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureCreationValidated Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001CE2 RID: 7394 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CE2")]
	[Address(RVA = "0x7EB950", Offset = "0x7E9F50", VA = "0x1807EB950")]
	private static FreeFormStructureCreationValidated Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001CE3 RID: 7395 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CE3")]
	[Address(RVA = "0x7EB8D0", Offset = "0x7E9ED0", VA = "0x1807EB8D0")]
	public static FreeFormStructureCreationValidated Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001CE4 RID: 7396 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CE4")]
	[Address(RVA = "0x7EB8E0", Offset = "0x7E9EE0", VA = "0x1807EB8E0")]
	public static FreeFormStructureCreationValidated Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001CE5 RID: 7397 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CE5")]
	[Address(RVA = "0x7EB8F0", Offset = "0x7E9EF0", VA = "0x1807EB8F0")]
	public static FreeFormStructureCreationValidated Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001CE6 RID: 7398 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CE6")]
	[Address(RVA = "0x7EB900", Offset = "0x7E9F00", VA = "0x1807EB900")]
	public static FreeFormStructureCreationValidated Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001CE7 RID: 7399 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CE7")]
	[Address(RVA = "0x7EB920", Offset = "0x7E9F20", VA = "0x1807EB920")]
	public static FreeFormStructureCreationValidated Create()
	{
		return null;
	}

	// Token: 0x06001CE8 RID: 7400 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CE8")]
	[Address(RVA = "0x7EB940", Offset = "0x7E9F40", VA = "0x1807EB940")]
	public static FreeFormStructureCreationValidated Create(ReliabilityModes reliability)
	{
		return null;
	}
}
