using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200025E RID: 606
[Token(Token = "0x200025E")]
public class FreeFormPlayerFinishedAnim : Event
{
	// Token: 0x06001BED RID: 7149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BED")]
	[Address(RVA = "0x7E44D0", Offset = "0x7E2AD0", VA = "0x1807E44D0")]
	public FreeFormPlayerFinishedAnim()
	{
	}

	// Token: 0x170007CE RID: 1998
	// (get) Token: 0x06001BEE RID: 7150 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001BEF RID: 7151 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007CE")]
	public BoltEntity TargetPlayer
	{
		[Token(Token = "0x6001BEE")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001BEF")]
		[Address(RVA = "0x7E4530", Offset = "0x7E2B30", VA = "0x1807E4530")]
		set
		{
		}
	}

	// Token: 0x170007CF RID: 1999
	// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x000086D0 File Offset: 0x000068D0
	// (set) Token: 0x06001BF1 RID: 7153 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007CF")]
	public int Status
	{
		[Token(Token = "0x6001BF0")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001BF1")]
		[Address(RVA = "0x7E4740", Offset = "0x7E2D40", VA = "0x1807E4740")]
		set
		{
		}
	}

	// Token: 0x06001BF2 RID: 7154 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BF2")]
	[Address(RVA = "0x7E47F0", Offset = "0x7E2DF0", VA = "0x1807E47F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001BF3 RID: 7155 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BF3")]
	[Address(RVA = "0x7E48B0", Offset = "0x7E2EB0", VA = "0x1807E48B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static FreeFormPlayerFinishedAnim Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001BF4 RID: 7156 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BF4")]
	[Address(RVA = "0x7E49D0", Offset = "0x7E2FD0", VA = "0x1807E49D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormPlayerFinishedAnim Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001BF5 RID: 7157 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BF5")]
	[Address(RVA = "0x7E49E0", Offset = "0x7E2FE0", VA = "0x1807E49E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormPlayerFinishedAnim Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001BF6 RID: 7158 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BF6")]
	[Address(RVA = "0x7E49F0", Offset = "0x7E2FF0", VA = "0x1807E49F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormPlayerFinishedAnim Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001BF7 RID: 7159 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BF7")]
	[Address(RVA = "0x7E4A00", Offset = "0x7E3000", VA = "0x1807E4A00")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormPlayerFinishedAnim Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001BF8 RID: 7160 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BF8")]
	[Address(RVA = "0x7E4A20", Offset = "0x7E3020", VA = "0x1807E4A20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormPlayerFinishedAnim Raise()
	{
		return null;
	}

	// Token: 0x06001BF9 RID: 7161 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BF9")]
	[Address(RVA = "0x7E4A40", Offset = "0x7E3040", VA = "0x1807E4A40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormPlayerFinishedAnim Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001BFA RID: 7162 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BFA")]
	[Address(RVA = "0x7E4A50", Offset = "0x7E3050", VA = "0x1807E4A50")]
	private static FreeFormPlayerFinishedAnim Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001BFB RID: 7163 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BFB")]
	[Address(RVA = "0x7E49D0", Offset = "0x7E2FD0", VA = "0x1807E49D0")]
	public static FreeFormPlayerFinishedAnim Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001BFC RID: 7164 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BFC")]
	[Address(RVA = "0x7E49E0", Offset = "0x7E2FE0", VA = "0x1807E49E0")]
	public static FreeFormPlayerFinishedAnim Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001BFD RID: 7165 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BFD")]
	[Address(RVA = "0x7E49F0", Offset = "0x7E2FF0", VA = "0x1807E49F0")]
	public static FreeFormPlayerFinishedAnim Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001BFE RID: 7166 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BFE")]
	[Address(RVA = "0x7E4A00", Offset = "0x7E3000", VA = "0x1807E4A00")]
	public static FreeFormPlayerFinishedAnim Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001BFF RID: 7167 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BFF")]
	[Address(RVA = "0x7E4A20", Offset = "0x7E3020", VA = "0x1807E4A20")]
	public static FreeFormPlayerFinishedAnim Create()
	{
		return null;
	}

	// Token: 0x06001C00 RID: 7168 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C00")]
	[Address(RVA = "0x7E4A40", Offset = "0x7E3040", VA = "0x1807E4A40")]
	public static FreeFormPlayerFinishedAnim Create(ReliabilityModes reliability)
	{
		return null;
	}
}
