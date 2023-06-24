using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000213 RID: 531
[Token(Token = "0x2000213")]
public class HitEngineEvent : Event
{
	// Token: 0x06001869 RID: 6249 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001869")]
	[Address(RVA = "0x8C0ED0", Offset = "0x8BF4D0", VA = "0x1808C0ED0")]
	public HitEngineEvent()
	{
	}

	// Token: 0x17000738 RID: 1848
	// (get) Token: 0x0600186A RID: 6250 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600186B RID: 6251 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000738")]
	public BoltEntity Target
	{
		[Token(Token = "0x600186A")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600186B")]
		[Address(RVA = "0x8C0F30", Offset = "0x8BF530", VA = "0x1808C0F30")]
		set
		{
		}
	}

	// Token: 0x17000739 RID: 1849
	// (get) Token: 0x0600186C RID: 6252 RVA: 0x00007D10 File Offset: 0x00005F10
	// (set) Token: 0x0600186D RID: 6253 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000739")]
	public float Damage
	{
		[Token(Token = "0x600186C")]
		[Address(RVA = "0x7B78E0", Offset = "0x7B5EE0", VA = "0x1807B78E0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600186D")]
		[Address(RVA = "0x861E70", Offset = "0x860470", VA = "0x180861E70")]
		set
		{
		}
	}

	// Token: 0x1700073A RID: 1850
	// (get) Token: 0x0600186E RID: 6254 RVA: 0x00007D28 File Offset: 0x00005F28
	// (set) Token: 0x0600186F RID: 6255 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700073A")]
	public bool Explode
	{
		[Token(Token = "0x600186E")]
		[Address(RVA = "0x7B8B00", Offset = "0x7B7100", VA = "0x1807B8B00")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600186F")]
		[Address(RVA = "0x7DD620", Offset = "0x7DBC20", VA = "0x1807DD620")]
		set
		{
		}
	}

	// Token: 0x06001870 RID: 6256 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001870")]
	[Address(RVA = "0x8C1140", Offset = "0x8BF740", VA = "0x1808C1140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001871 RID: 6257 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001871")]
	[Address(RVA = "0x8C1290", Offset = "0x8BF890", VA = "0x1808C1290")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static HitEngineEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001872 RID: 6258 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001872")]
	[Address(RVA = "0x8C12A0", Offset = "0x8BF8A0", VA = "0x1808C12A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static HitEngineEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001873 RID: 6259 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001873")]
	[Address(RVA = "0x8C14A0", Offset = "0x8BFAA0", VA = "0x1808C14A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static HitEngineEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001874 RID: 6260 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001874")]
	[Address(RVA = "0x8C15C0", Offset = "0x8BFBC0", VA = "0x1808C15C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static HitEngineEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001875 RID: 6261 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001875")]
	[Address(RVA = "0x8C15D0", Offset = "0x8BFBD0", VA = "0x1808C15D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static HitEngineEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001876 RID: 6262 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001876")]
	[Address(RVA = "0x8C15E0", Offset = "0x8BFBE0", VA = "0x1808C15E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static HitEngineEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001877 RID: 6263 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001877")]
	[Address(RVA = "0x8C15F0", Offset = "0x8BFBF0", VA = "0x1808C15F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static HitEngineEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001878 RID: 6264 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001878")]
	[Address(RVA = "0x8C1610", Offset = "0x8BFC10", VA = "0x1808C1610")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static HitEngineEvent Raise()
	{
		return null;
	}

	// Token: 0x06001879 RID: 6265 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001879")]
	[Address(RVA = "0x8C1630", Offset = "0x8BFC30", VA = "0x1808C1630")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static HitEngineEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600187A RID: 6266 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600187A")]
	[Address(RVA = "0x8C1290", Offset = "0x8BF890", VA = "0x1808C1290")]
	public static HitEngineEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600187B RID: 6267 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600187B")]
	[Address(RVA = "0x8C1640", Offset = "0x8BFC40", VA = "0x1808C1640")]
	public static HitEngineEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600187C RID: 6268 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600187C")]
	[Address(RVA = "0x8C1840", Offset = "0x8BFE40", VA = "0x1808C1840")]
	private static HitEngineEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600187D RID: 6269 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600187D")]
	[Address(RVA = "0x8C15C0", Offset = "0x8BFBC0", VA = "0x1808C15C0")]
	public static HitEngineEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600187E RID: 6270 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600187E")]
	[Address(RVA = "0x8C15D0", Offset = "0x8BFBD0", VA = "0x1808C15D0")]
	public static HitEngineEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600187F RID: 6271 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600187F")]
	[Address(RVA = "0x8C15E0", Offset = "0x8BFBE0", VA = "0x1808C15E0")]
	public static HitEngineEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001880 RID: 6272 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001880")]
	[Address(RVA = "0x8C15F0", Offset = "0x8BFBF0", VA = "0x1808C15F0")]
	public static HitEngineEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001881 RID: 6273 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001881")]
	[Address(RVA = "0x8C1610", Offset = "0x8BFC10", VA = "0x1808C1610")]
	public static HitEngineEvent Create()
	{
		return null;
	}

	// Token: 0x06001882 RID: 6274 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001882")]
	[Address(RVA = "0x8C1630", Offset = "0x8BFC30", VA = "0x1808C1630")]
	public static HitEngineEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
