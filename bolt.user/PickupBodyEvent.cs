using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000207 RID: 519
[Token(Token = "0x2000207")]
public class PickupBodyEvent : Event
{
	// Token: 0x06001795 RID: 6037 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001795")]
	[Address(RVA = "0x8B74D0", Offset = "0x8B5AD0", VA = "0x1808B74D0")]
	public PickupBodyEvent()
	{
	}

	// Token: 0x170006FC RID: 1788
	// (get) Token: 0x06001796 RID: 6038 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001797 RID: 6039 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006FC")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001796")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001797")]
		[Address(RVA = "0x8B7530", Offset = "0x8B5B30", VA = "0x1808B7530")]
		set
		{
		}
	}

	// Token: 0x170006FD RID: 1789
	// (get) Token: 0x06001798 RID: 6040 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001799 RID: 6041 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006FD")]
	public BoltEntity Body
	{
		[Token(Token = "0x6001798")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001799")]
		[Address(RVA = "0x8B7740", Offset = "0x8B5D40", VA = "0x1808B7740")]
		set
		{
		}
	}

	// Token: 0x170006FE RID: 1790
	// (get) Token: 0x0600179A RID: 6042 RVA: 0x00007848 File Offset: 0x00005A48
	// (set) Token: 0x0600179B RID: 6043 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006FE")]
	public bool ClientRequest
	{
		[Token(Token = "0x600179A")]
		[Address(RVA = "0x7B8B00", Offset = "0x7B7100", VA = "0x1807B8B00")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600179B")]
		[Address(RVA = "0x7DD620", Offset = "0x7DBC20", VA = "0x1807DD620")]
		set
		{
		}
	}

	// Token: 0x170006FF RID: 1791
	// (get) Token: 0x0600179C RID: 6044 RVA: 0x00007860 File Offset: 0x00005A60
	// (set) Token: 0x0600179D RID: 6045 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006FF")]
	public int TypeId
	{
		[Token(Token = "0x600179C")]
		[Address(RVA = "0x7B6B40", Offset = "0x7B5140", VA = "0x1807B6B40")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600179D")]
		[Address(RVA = "0x7E1CC0", Offset = "0x7E02C0", VA = "0x1807E1CC0")]
		set
		{
		}
	}

	// Token: 0x17000700 RID: 1792
	// (get) Token: 0x0600179E RID: 6046 RVA: 0x00007878 File Offset: 0x00005A78
	// (set) Token: 0x0600179F RID: 6047 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000700")]
	public int ActorSeed
	{
		[Token(Token = "0x600179E")]
		[Address(RVA = "0x7BB500", Offset = "0x7B9B00", VA = "0x1807BB500")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600179F")]
		[Address(RVA = "0x7E1D60", Offset = "0x7E0360", VA = "0x1807E1D60")]
		set
		{
		}
	}

	// Token: 0x17000701 RID: 1793
	// (get) Token: 0x060017A0 RID: 6048 RVA: 0x00007890 File Offset: 0x00005A90
	// (set) Token: 0x060017A1 RID: 6049 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000701")]
	public int VariationSubSet
	{
		[Token(Token = "0x60017A0")]
		[Address(RVA = "0x7E1E00", Offset = "0x7E0400", VA = "0x1807E1E00")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017A1")]
		[Address(RVA = "0x7E1E60", Offset = "0x7E0460", VA = "0x1807E1E60")]
		set
		{
		}
	}

	// Token: 0x17000702 RID: 1794
	// (get) Token: 0x060017A2 RID: 6050 RVA: 0x000078A8 File Offset: 0x00005AA8
	// (set) Token: 0x060017A3 RID: 6051 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000702")]
	public int DismemberMask
	{
		[Token(Token = "0x60017A2")]
		[Address(RVA = "0x8268A0", Offset = "0x824EA0", VA = "0x1808268A0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017A3")]
		[Address(RVA = "0x840F10", Offset = "0x83F510", VA = "0x180840F10")]
		set
		{
		}
	}

	// Token: 0x17000703 RID: 1795
	// (get) Token: 0x060017A4 RID: 6052 RVA: 0x000078C0 File Offset: 0x00005AC0
	// (set) Token: 0x060017A5 RID: 6053 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000703")]
	public int BloodMask
	{
		[Token(Token = "0x60017A4")]
		[Address(RVA = "0x840FB0", Offset = "0x83F5B0", VA = "0x180840FB0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60017A5")]
		[Address(RVA = "0x841010", Offset = "0x83F610", VA = "0x180841010")]
		set
		{
		}
	}

	// Token: 0x060017A6 RID: 6054 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017A6")]
	[Address(RVA = "0x8B7950", Offset = "0x8B5F50", VA = "0x1808B7950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060017A7 RID: 6055 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017A7")]
	[Address(RVA = "0x8B7E30", Offset = "0x8B6430", VA = "0x1808B7E30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupBodyEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060017A8 RID: 6056 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017A8")]
	[Address(RVA = "0x8B7E40", Offset = "0x8B6440", VA = "0x1808B7E40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupBodyEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060017A9 RID: 6057 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017A9")]
	[Address(RVA = "0x8B8040", Offset = "0x8B6640", VA = "0x1808B8040")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static PickupBodyEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060017AA RID: 6058 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017AA")]
	[Address(RVA = "0x8B8160", Offset = "0x8B6760", VA = "0x1808B8160")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupBodyEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060017AB RID: 6059 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017AB")]
	[Address(RVA = "0x8B8170", Offset = "0x8B6770", VA = "0x1808B8170")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupBodyEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060017AC RID: 6060 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017AC")]
	[Address(RVA = "0x8B8180", Offset = "0x8B6780", VA = "0x1808B8180")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupBodyEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060017AD RID: 6061 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017AD")]
	[Address(RVA = "0x8B8190", Offset = "0x8B6790", VA = "0x1808B8190")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupBodyEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060017AE RID: 6062 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017AE")]
	[Address(RVA = "0x8B81B0", Offset = "0x8B67B0", VA = "0x1808B81B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupBodyEvent Raise()
	{
		return null;
	}

	// Token: 0x060017AF RID: 6063 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017AF")]
	[Address(RVA = "0x8B81D0", Offset = "0x8B67D0", VA = "0x1808B81D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupBodyEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060017B0 RID: 6064 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017B0")]
	[Address(RVA = "0x8B7E30", Offset = "0x8B6430", VA = "0x1808B7E30")]
	public static PickupBodyEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060017B1 RID: 6065 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017B1")]
	[Address(RVA = "0x8B81E0", Offset = "0x8B67E0", VA = "0x1808B81E0")]
	public static PickupBodyEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060017B2 RID: 6066 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017B2")]
	[Address(RVA = "0x8B83E0", Offset = "0x8B69E0", VA = "0x1808B83E0")]
	private static PickupBodyEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060017B3 RID: 6067 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017B3")]
	[Address(RVA = "0x8B8160", Offset = "0x8B6760", VA = "0x1808B8160")]
	public static PickupBodyEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060017B4 RID: 6068 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017B4")]
	[Address(RVA = "0x8B8170", Offset = "0x8B6770", VA = "0x1808B8170")]
	public static PickupBodyEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060017B5 RID: 6069 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017B5")]
	[Address(RVA = "0x8B8180", Offset = "0x8B6780", VA = "0x1808B8180")]
	public static PickupBodyEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060017B6 RID: 6070 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017B6")]
	[Address(RVA = "0x8B8190", Offset = "0x8B6790", VA = "0x1808B8190")]
	public static PickupBodyEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060017B7 RID: 6071 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017B7")]
	[Address(RVA = "0x8B81B0", Offset = "0x8B67B0", VA = "0x1808B81B0")]
	public static PickupBodyEvent Create()
	{
		return null;
	}

	// Token: 0x060017B8 RID: 6072 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017B8")]
	[Address(RVA = "0x8B81D0", Offset = "0x8B67D0", VA = "0x1808B81D0")]
	public static PickupBodyEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
