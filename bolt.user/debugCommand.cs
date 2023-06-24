using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001A1 RID: 417
[Token(Token = "0x20001A1")]
public class debugCommand : Event
{
	// Token: 0x0600130B RID: 4875 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600130B")]
	[Address(RVA = "0x892DA0", Offset = "0x8913A0", VA = "0x180892DA0")]
	public debugCommand()
	{
	}

	// Token: 0x17000637 RID: 1591
	// (get) Token: 0x0600130C RID: 4876 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600130D RID: 4877 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000637")]
	public string input
	{
		[Token(Token = "0x600130C")]
		[Address(RVA = "0x7D27A0", Offset = "0x7D0DA0", VA = "0x1807D27A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600130D")]
		[Address(RVA = "0x84C060", Offset = "0x84A660", VA = "0x18084C060")]
		set
		{
		}
	}

	// Token: 0x17000638 RID: 1592
	// (get) Token: 0x0600130E RID: 4878 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600130F RID: 4879 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000638")]
	public BoltEntity target
	{
		[Token(Token = "0x600130E")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600130F")]
		[Address(RVA = "0x892E00", Offset = "0x891400", VA = "0x180892E00")]
		set
		{
		}
	}

	// Token: 0x17000639 RID: 1593
	// (get) Token: 0x06001310 RID: 4880 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001311 RID: 4881 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000639")]
	public string input2
	{
		[Token(Token = "0x6001310")]
		[Address(RVA = "0x82C9C0", Offset = "0x82AFC0", VA = "0x18082C9C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001311")]
		[Address(RVA = "0x893010", Offset = "0x891610", VA = "0x180893010")]
		set
		{
		}
	}

	// Token: 0x06001312 RID: 4882 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001312")]
	[Address(RVA = "0x893150", Offset = "0x891750", VA = "0x180893150", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001313 RID: 4883 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001313")]
	[Address(RVA = "0x8931D0", Offset = "0x8917D0", VA = "0x1808931D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static debugCommand Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001314 RID: 4884 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001314")]
	[Address(RVA = "0x8931E0", Offset = "0x8917E0", VA = "0x1808931E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static debugCommand Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001315 RID: 4885 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001315")]
	[Address(RVA = "0x8933E0", Offset = "0x8919E0", VA = "0x1808933E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static debugCommand Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001316 RID: 4886 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001316")]
	[Address(RVA = "0x893500", Offset = "0x891B00", VA = "0x180893500")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static debugCommand Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001317 RID: 4887 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001317")]
	[Address(RVA = "0x893510", Offset = "0x891B10", VA = "0x180893510")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static debugCommand Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001318 RID: 4888 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001318")]
	[Address(RVA = "0x893520", Offset = "0x891B20", VA = "0x180893520")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static debugCommand Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001319 RID: 4889 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001319")]
	[Address(RVA = "0x893530", Offset = "0x891B30", VA = "0x180893530")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static debugCommand Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600131A RID: 4890 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600131A")]
	[Address(RVA = "0x893550", Offset = "0x891B50", VA = "0x180893550")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static debugCommand Raise()
	{
		return null;
	}

	// Token: 0x0600131B RID: 4891 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600131B")]
	[Address(RVA = "0x893570", Offset = "0x891B70", VA = "0x180893570")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static debugCommand Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600131C RID: 4892 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600131C")]
	[Address(RVA = "0x8931D0", Offset = "0x8917D0", VA = "0x1808931D0")]
	public static debugCommand Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600131D RID: 4893 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600131D")]
	[Address(RVA = "0x893580", Offset = "0x891B80", VA = "0x180893580")]
	public static debugCommand Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600131E RID: 4894 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600131E")]
	[Address(RVA = "0x893780", Offset = "0x891D80", VA = "0x180893780")]
	private static debugCommand Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600131F RID: 4895 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600131F")]
	[Address(RVA = "0x893500", Offset = "0x891B00", VA = "0x180893500")]
	public static debugCommand Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001320 RID: 4896 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001320")]
	[Address(RVA = "0x893510", Offset = "0x891B10", VA = "0x180893510")]
	public static debugCommand Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001321 RID: 4897 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001321")]
	[Address(RVA = "0x893520", Offset = "0x891B20", VA = "0x180893520")]
	public static debugCommand Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001322 RID: 4898 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001322")]
	[Address(RVA = "0x893530", Offset = "0x891B30", VA = "0x180893530")]
	public static debugCommand Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001323 RID: 4899 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001323")]
	[Address(RVA = "0x893550", Offset = "0x891B50", VA = "0x180893550")]
	public static debugCommand Create()
	{
		return null;
	}

	// Token: 0x06001324 RID: 4900 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001324")]
	[Address(RVA = "0x893570", Offset = "0x891B70", VA = "0x180893570")]
	public static debugCommand Create(ReliabilityModes reliability)
	{
		return null;
	}
}
