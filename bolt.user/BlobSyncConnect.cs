using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000294 RID: 660
[Token(Token = "0x2000294")]
public class BlobSyncConnect : Event
{
	// Token: 0x06001E37 RID: 7735 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E37")]
	[Address(RVA = "0x7F5B80", Offset = "0x7F4180", VA = "0x1807F5B80")]
	public BlobSyncConnect()
	{
	}

	// Token: 0x1700082B RID: 2091
	// (get) Token: 0x06001E38 RID: 7736 RVA: 0x00008CA0 File Offset: 0x00006EA0
	// (set) Token: 0x06001E39 RID: 7737 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700082B")]
	public NetworkId AccessToken
	{
		[Token(Token = "0x6001E38")]
		[Address(RVA = "0x7BA0A0", Offset = "0x7B86A0", VA = "0x1807BA0A0")]
		get
		{
			return default(NetworkId);
		}
		[Token(Token = "0x6001E39")]
		[Address(RVA = "0x7F5BE0", Offset = "0x7F41E0", VA = "0x1807F5BE0")]
		set
		{
		}
	}

	// Token: 0x1700082C RID: 2092
	// (get) Token: 0x06001E3A RID: 7738 RVA: 0x00008CB8 File Offset: 0x00006EB8
	// (set) Token: 0x06001E3B RID: 7739 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700082C")]
	public int BlobSyncPort
	{
		[Token(Token = "0x6001E3A")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001E3B")]
		[Address(RVA = "0x7D6DC0", Offset = "0x7D53C0", VA = "0x1807D6DC0")]
		set
		{
		}
	}

	// Token: 0x06001E3C RID: 7740 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E3C")]
	[Address(RVA = "0x7F5C70", Offset = "0x7F4270", VA = "0x1807F5C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001E3D RID: 7741 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E3D")]
	[Address(RVA = "0x7F5D90", Offset = "0x7F4390", VA = "0x1807F5D90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static BlobSyncConnect Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E3E RID: 7742 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E3E")]
	[Address(RVA = "0x7F5F20", Offset = "0x7F4520", VA = "0x1807F5F20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static BlobSyncConnect Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001E3F RID: 7743 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E3F")]
	[Address(RVA = "0x7F5F30", Offset = "0x7F4530", VA = "0x1807F5F30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static BlobSyncConnect Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E40 RID: 7744 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E40")]
	[Address(RVA = "0x7F5F40", Offset = "0x7F4540", VA = "0x1807F5F40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static BlobSyncConnect Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001E41 RID: 7745 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E41")]
	[Address(RVA = "0x7F5F50", Offset = "0x7F4550", VA = "0x1807F5F50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static BlobSyncConnect Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E42 RID: 7746 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E42")]
	[Address(RVA = "0x7F5F70", Offset = "0x7F4570", VA = "0x1807F5F70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static BlobSyncConnect Raise()
	{
		return null;
	}

	// Token: 0x06001E43 RID: 7747 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E43")]
	[Address(RVA = "0x7F5F90", Offset = "0x7F4590", VA = "0x1807F5F90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static BlobSyncConnect Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E44 RID: 7748 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E44")]
	[Address(RVA = "0x7F5FA0", Offset = "0x7F45A0", VA = "0x1807F5FA0")]
	private static BlobSyncConnect Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E45 RID: 7749 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E45")]
	[Address(RVA = "0x7F5F20", Offset = "0x7F4520", VA = "0x1807F5F20")]
	public static BlobSyncConnect Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001E46 RID: 7750 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E46")]
	[Address(RVA = "0x7F5F30", Offset = "0x7F4530", VA = "0x1807F5F30")]
	public static BlobSyncConnect Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E47 RID: 7751 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E47")]
	[Address(RVA = "0x7F5F40", Offset = "0x7F4540", VA = "0x1807F5F40")]
	public static BlobSyncConnect Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001E48 RID: 7752 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E48")]
	[Address(RVA = "0x7F5F50", Offset = "0x7F4550", VA = "0x1807F5F50")]
	public static BlobSyncConnect Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E49 RID: 7753 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E49")]
	[Address(RVA = "0x7F5F70", Offset = "0x7F4570", VA = "0x1807F5F70")]
	public static BlobSyncConnect Create()
	{
		return null;
	}

	// Token: 0x06001E4A RID: 7754 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E4A")]
	[Address(RVA = "0x7F5F90", Offset = "0x7F4590", VA = "0x1807F5F90")]
	public static BlobSyncConnect Create(ReliabilityModes reliability)
	{
		return null;
	}
}
