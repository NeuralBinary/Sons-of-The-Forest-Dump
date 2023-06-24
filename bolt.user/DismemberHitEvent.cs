using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000204 RID: 516
[Token(Token = "0x2000204")]
public class DismemberHitEvent : Event
{
	// Token: 0x06001771 RID: 6001 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001771")]
	[Address(RVA = "0x8B61C0", Offset = "0x8B47C0", VA = "0x1808B61C0")]
	public DismemberHitEvent()
	{
	}

	// Token: 0x170006F6 RID: 1782
	// (get) Token: 0x06001772 RID: 6002 RVA: 0x000077E8 File Offset: 0x000059E8
	// (set) Token: 0x06001773 RID: 6003 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006F6")]
	public float Damage
	{
		[Token(Token = "0x6001772")]
		[Address(RVA = "0x7C3C70", Offset = "0x7C2270", VA = "0x1807C3C70")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001773")]
		[Address(RVA = "0x8B6220", Offset = "0x8B4820", VA = "0x1808B6220")]
		set
		{
		}
	}

	// Token: 0x170006F7 RID: 1783
	// (get) Token: 0x06001774 RID: 6004 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001775 RID: 6005 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006F7")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001774")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001775")]
		[Address(RVA = "0x8B62D0", Offset = "0x8B48D0", VA = "0x1808B62D0")]
		set
		{
		}
	}

	// Token: 0x170006F8 RID: 1784
	// (get) Token: 0x06001776 RID: 6006 RVA: 0x00007800 File Offset: 0x00005A00
	// (set) Token: 0x06001777 RID: 6007 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006F8")]
	public int PartId
	{
		[Token(Token = "0x6001776")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001777")]
		[Address(RVA = "0x83CBD0", Offset = "0x83B1D0", VA = "0x18083CBD0")]
		set
		{
		}
	}

	// Token: 0x06001778 RID: 6008 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001778")]
	[Address(RVA = "0x8B64E0", Offset = "0x8B4AE0", VA = "0x1808B64E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001779 RID: 6009 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001779")]
	[Address(RVA = "0x8B6620", Offset = "0x8B4C20", VA = "0x1808B6620")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DismemberHitEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600177A RID: 6010 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600177A")]
	[Address(RVA = "0x8B6630", Offset = "0x8B4C30", VA = "0x1808B6630")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DismemberHitEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600177B RID: 6011 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600177B")]
	[Address(RVA = "0x8B6830", Offset = "0x8B4E30", VA = "0x1808B6830")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static DismemberHitEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600177C RID: 6012 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600177C")]
	[Address(RVA = "0x8B6950", Offset = "0x8B4F50", VA = "0x1808B6950")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DismemberHitEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600177D RID: 6013 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600177D")]
	[Address(RVA = "0x8B6960", Offset = "0x8B4F60", VA = "0x1808B6960")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DismemberHitEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600177E RID: 6014 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600177E")]
	[Address(RVA = "0x8B6970", Offset = "0x8B4F70", VA = "0x1808B6970")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DismemberHitEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600177F RID: 6015 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600177F")]
	[Address(RVA = "0x8B6980", Offset = "0x8B4F80", VA = "0x1808B6980")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DismemberHitEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001780 RID: 6016 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001780")]
	[Address(RVA = "0x8B69A0", Offset = "0x8B4FA0", VA = "0x1808B69A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DismemberHitEvent Raise()
	{
		return null;
	}

	// Token: 0x06001781 RID: 6017 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001781")]
	[Address(RVA = "0x8B69C0", Offset = "0x8B4FC0", VA = "0x1808B69C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DismemberHitEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001782 RID: 6018 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001782")]
	[Address(RVA = "0x8B6620", Offset = "0x8B4C20", VA = "0x1808B6620")]
	public static DismemberHitEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001783 RID: 6019 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001783")]
	[Address(RVA = "0x8B69D0", Offset = "0x8B4FD0", VA = "0x1808B69D0")]
	public static DismemberHitEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001784 RID: 6020 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001784")]
	[Address(RVA = "0x8B6BD0", Offset = "0x8B51D0", VA = "0x1808B6BD0")]
	private static DismemberHitEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001785 RID: 6021 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001785")]
	[Address(RVA = "0x8B6950", Offset = "0x8B4F50", VA = "0x1808B6950")]
	public static DismemberHitEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001786 RID: 6022 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001786")]
	[Address(RVA = "0x8B6960", Offset = "0x8B4F60", VA = "0x1808B6960")]
	public static DismemberHitEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001787 RID: 6023 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001787")]
	[Address(RVA = "0x8B6970", Offset = "0x8B4F70", VA = "0x1808B6970")]
	public static DismemberHitEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001788 RID: 6024 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001788")]
	[Address(RVA = "0x8B6980", Offset = "0x8B4F80", VA = "0x1808B6980")]
	public static DismemberHitEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001789 RID: 6025 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001789")]
	[Address(RVA = "0x8B69A0", Offset = "0x8B4FA0", VA = "0x1808B69A0")]
	public static DismemberHitEvent Create()
	{
		return null;
	}

	// Token: 0x0600178A RID: 6026 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600178A")]
	[Address(RVA = "0x8B69C0", Offset = "0x8B4FC0", VA = "0x1808B69C0")]
	public static DismemberHitEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
