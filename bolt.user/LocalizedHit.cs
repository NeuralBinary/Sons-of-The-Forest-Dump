using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200011D RID: 285
[Token(Token = "0x200011D")]
public class LocalizedHit : Event
{
	// Token: 0x06000D21 RID: 3361 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D21")]
	[Address(RVA = "0x861E10", Offset = "0x860410", VA = "0x180861E10")]
	public LocalizedHit()
	{
	}

	// Token: 0x17000552 RID: 1362
	// (get) Token: 0x06000D22 RID: 3362 RVA: 0x00005EB0 File Offset: 0x000040B0
	// (set) Token: 0x06000D23 RID: 3363 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000552")]
	public Vector3 Position
	{
		[Token(Token = "0x6000D22")]
		[Address(RVA = "0x7D3CB0", Offset = "0x7D22B0", VA = "0x1807D3CB0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000D23")]
		[Address(RVA = "0x83CAC0", Offset = "0x83B0C0", VA = "0x18083CAC0")]
		set
		{
		}
	}

	// Token: 0x17000553 RID: 1363
	// (get) Token: 0x06000D24 RID: 3364 RVA: 0x00005EC8 File Offset: 0x000040C8
	// (set) Token: 0x06000D25 RID: 3365 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000553")]
	public float Damage
	{
		[Token(Token = "0x6000D24")]
		[Address(RVA = "0x7B78E0", Offset = "0x7B5EE0", VA = "0x1807B78E0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000D25")]
		[Address(RVA = "0x861E70", Offset = "0x860470", VA = "0x180861E70")]
		set
		{
		}
	}

	// Token: 0x17000554 RID: 1364
	// (get) Token: 0x06000D26 RID: 3366 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000D27 RID: 3367 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000554")]
	public BoltEntity Building
	{
		[Token(Token = "0x6000D26")]
		[Address(RVA = "0x80A6A0", Offset = "0x808CA0", VA = "0x18080A6A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D27")]
		[Address(RVA = "0x861F10", Offset = "0x860510", VA = "0x180861F10")]
		set
		{
		}
	}

	// Token: 0x17000555 RID: 1365
	// (get) Token: 0x06000D28 RID: 3368 RVA: 0x00005EE0 File Offset: 0x000040E0
	// (set) Token: 0x06000D29 RID: 3369 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000555")]
	public int Chunk
	{
		[Token(Token = "0x6000D28")]
		[Address(RVA = "0x7B6B40", Offset = "0x7B5140", VA = "0x1807B6B40")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000D29")]
		[Address(RVA = "0x7E1CC0", Offset = "0x7E02C0", VA = "0x1807E1CC0")]
		set
		{
		}
	}

	// Token: 0x06000D2A RID: 3370 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D2A")]
	[Address(RVA = "0x862130", Offset = "0x860730", VA = "0x180862130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000D2B RID: 3371 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D2B")]
	[Address(RVA = "0x862400", Offset = "0x860A00", VA = "0x180862400")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static LocalizedHit Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000D2C RID: 3372 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D2C")]
	[Address(RVA = "0x862410", Offset = "0x860A10", VA = "0x180862410")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static LocalizedHit Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000D2D RID: 3373 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D2D")]
	[Address(RVA = "0x862610", Offset = "0x860C10", VA = "0x180862610")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static LocalizedHit Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D2E RID: 3374 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D2E")]
	[Address(RVA = "0x862730", Offset = "0x860D30", VA = "0x180862730")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static LocalizedHit Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000D2F RID: 3375 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D2F")]
	[Address(RVA = "0x862740", Offset = "0x860D40", VA = "0x180862740")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static LocalizedHit Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D30 RID: 3376 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D30")]
	[Address(RVA = "0x862750", Offset = "0x860D50", VA = "0x180862750")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static LocalizedHit Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000D31 RID: 3377 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D31")]
	[Address(RVA = "0x862760", Offset = "0x860D60", VA = "0x180862760")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static LocalizedHit Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D32 RID: 3378 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D32")]
	[Address(RVA = "0x862780", Offset = "0x860D80", VA = "0x180862780")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static LocalizedHit Raise()
	{
		return null;
	}

	// Token: 0x06000D33 RID: 3379 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D33")]
	[Address(RVA = "0x8627A0", Offset = "0x860DA0", VA = "0x1808627A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static LocalizedHit Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D34 RID: 3380 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D34")]
	[Address(RVA = "0x862400", Offset = "0x860A00", VA = "0x180862400")]
	public static LocalizedHit Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000D35 RID: 3381 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D35")]
	[Address(RVA = "0x8627B0", Offset = "0x860DB0", VA = "0x1808627B0")]
	public static LocalizedHit Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000D36 RID: 3382 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D36")]
	[Address(RVA = "0x8629B0", Offset = "0x860FB0", VA = "0x1808629B0")]
	private static LocalizedHit Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D37 RID: 3383 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D37")]
	[Address(RVA = "0x862730", Offset = "0x860D30", VA = "0x180862730")]
	public static LocalizedHit Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000D38 RID: 3384 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D38")]
	[Address(RVA = "0x862740", Offset = "0x860D40", VA = "0x180862740")]
	public static LocalizedHit Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D39 RID: 3385 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D39")]
	[Address(RVA = "0x862750", Offset = "0x860D50", VA = "0x180862750")]
	public static LocalizedHit Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000D3A RID: 3386 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D3A")]
	[Address(RVA = "0x862760", Offset = "0x860D60", VA = "0x180862760")]
	public static LocalizedHit Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D3B RID: 3387 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D3B")]
	[Address(RVA = "0x862780", Offset = "0x860D80", VA = "0x180862780")]
	public static LocalizedHit Create()
	{
		return null;
	}

	// Token: 0x06000D3C RID: 3388 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D3C")]
	[Address(RVA = "0x8627A0", Offset = "0x860DA0", VA = "0x1808627A0")]
	public static LocalizedHit Create(ReliabilityModes reliability)
	{
		return null;
	}
}
