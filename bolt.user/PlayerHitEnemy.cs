using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000C9 RID: 201
[Token(Token = "0x20000C9")]
public class PlayerHitEnemy : Event
{
	// Token: 0x06000945 RID: 2373 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000945")]
	[Address(RVA = "0x840C00", Offset = "0x83F200", VA = "0x180840C00")]
	public PlayerHitEnemy()
	{
	}

	// Token: 0x170004B2 RID: 1202
	// (get) Token: 0x06000946 RID: 2374 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000947 RID: 2375 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004B2")]
	public BoltEntity Target
	{
		[Token(Token = "0x6000946")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000947")]
		[Address(RVA = "0x840C60", Offset = "0x83F260", VA = "0x180840C60")]
		set
		{
		}
	}

	// Token: 0x170004B3 RID: 1203
	// (get) Token: 0x06000948 RID: 2376 RVA: 0x000054D8 File Offset: 0x000036D8
	// (set) Token: 0x06000949 RID: 2377 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004B3")]
	public int getAttacker
	{
		[Token(Token = "0x6000948")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000949")]
		[Address(RVA = "0x7D6DC0", Offset = "0x7D53C0", VA = "0x1807D6DC0")]
		set
		{
		}
	}

	// Token: 0x170004B4 RID: 1204
	// (get) Token: 0x0600094A RID: 2378 RVA: 0x000054F0 File Offset: 0x000036F0
	// (set) Token: 0x0600094B RID: 2379 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004B4")]
	public int getAttackerType
	{
		[Token(Token = "0x600094A")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600094B")]
		[Address(RVA = "0x7D6E60", Offset = "0x7D5460", VA = "0x1807D6E60")]
		set
		{
		}
	}

	// Token: 0x170004B5 RID: 1205
	// (get) Token: 0x0600094C RID: 2380 RVA: 0x00005508 File Offset: 0x00003708
	// (set) Token: 0x0600094D RID: 2381 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004B5")]
	public int takeDamage
	{
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x7B6B40", Offset = "0x7B5140", VA = "0x1807B6B40")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600094D")]
		[Address(RVA = "0x7E1CC0", Offset = "0x7E02C0", VA = "0x1807E1CC0")]
		set
		{
		}
	}

	// Token: 0x170004B6 RID: 1206
	// (get) Token: 0x0600094E RID: 2382 RVA: 0x00005520 File Offset: 0x00003720
	// (set) Token: 0x0600094F RID: 2383 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004B6")]
	public int getAttackDirection
	{
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x7BB500", Offset = "0x7B9B00", VA = "0x1807BB500")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600094F")]
		[Address(RVA = "0x7E1D60", Offset = "0x7E0360", VA = "0x1807E1D60")]
		set
		{
		}
	}

	// Token: 0x170004B7 RID: 1207
	// (get) Token: 0x06000950 RID: 2384 RVA: 0x00005538 File Offset: 0x00003738
	// (set) Token: 0x06000951 RID: 2385 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004B7")]
	public bool getStealthAttack
	{
		[Token(Token = "0x6000950")]
		[Address(RVA = "0x826750", Offset = "0x824D50", VA = "0x180826750")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000951")]
		[Address(RVA = "0x840E70", Offset = "0x83F470", VA = "0x180840E70")]
		set
		{
		}
	}

	// Token: 0x170004B8 RID: 1208
	// (get) Token: 0x06000952 RID: 2386 RVA: 0x00005550 File Offset: 0x00003750
	// (set) Token: 0x06000953 RID: 2387 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004B8")]
	public int getCombo
	{
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x8268A0", Offset = "0x824EA0", VA = "0x1808268A0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x840F10", Offset = "0x83F510", VA = "0x180840F10")]
		set
		{
		}
	}

	// Token: 0x170004B9 RID: 1209
	// (get) Token: 0x06000954 RID: 2388 RVA: 0x00005568 File Offset: 0x00003768
	// (set) Token: 0x06000955 RID: 2389 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004B9")]
	public int Hit
	{
		[Token(Token = "0x6000954")]
		[Address(RVA = "0x840FB0", Offset = "0x83F5B0", VA = "0x180840FB0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000955")]
		[Address(RVA = "0x841010", Offset = "0x83F610", VA = "0x180841010")]
		set
		{
		}
	}

	// Token: 0x170004BA RID: 1210
	// (get) Token: 0x06000956 RID: 2390 RVA: 0x00005580 File Offset: 0x00003780
	// (set) Token: 0x06000957 RID: 2391 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004BA")]
	public bool Burn
	{
		[Token(Token = "0x6000956")]
		[Address(RVA = "0x82D170", Offset = "0x82B770", VA = "0x18082D170")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000957")]
		[Address(RVA = "0x83AAA0", Offset = "0x8390A0", VA = "0x18083AAA0")]
		set
		{
		}
	}

	// Token: 0x170004BB RID: 1211
	// (get) Token: 0x06000958 RID: 2392 RVA: 0x00005598 File Offset: 0x00003798
	// (set) Token: 0x06000959 RID: 2393 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004BB")]
	public bool HitAxe
	{
		[Token(Token = "0x6000958")]
		[Address(RVA = "0x82D2C0", Offset = "0x82B8C0", VA = "0x18082D2C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000959")]
		[Address(RVA = "0x83AB40", Offset = "0x839140", VA = "0x18083AB40")]
		set
		{
		}
	}

	// Token: 0x170004BC RID: 1212
	// (get) Token: 0x0600095A RID: 2394 RVA: 0x000055B0 File Offset: 0x000037B0
	// (set) Token: 0x0600095B RID: 2395 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004BC")]
	public bool HitHead
	{
		[Token(Token = "0x600095A")]
		[Address(RVA = "0x8410B0", Offset = "0x83F6B0", VA = "0x1808410B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600095B")]
		[Address(RVA = "0x841110", Offset = "0x83F710", VA = "0x180841110")]
		set
		{
		}
	}

	// Token: 0x170004BD RID: 1213
	// (get) Token: 0x0600095C RID: 2396 RVA: 0x000055C8 File Offset: 0x000037C8
	// (set) Token: 0x0600095D RID: 2397 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004BD")]
	public bool hitFallDown
	{
		[Token(Token = "0x600095C")]
		[Address(RVA = "0x8411B0", Offset = "0x83F7B0", VA = "0x1808411B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600095D")]
		[Address(RVA = "0x841210", Offset = "0x83F810", VA = "0x180841210")]
		set
		{
		}
	}

	// Token: 0x170004BE RID: 1214
	// (get) Token: 0x0600095E RID: 2398 RVA: 0x000055E0 File Offset: 0x000037E0
	// (set) Token: 0x0600095F RID: 2399 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004BE")]
	public bool explosion
	{
		[Token(Token = "0x600095E")]
		[Address(RVA = "0x80C6B0", Offset = "0x80ACB0", VA = "0x18080C6B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600095F")]
		[Address(RVA = "0x8412B0", Offset = "0x83F8B0", VA = "0x1808412B0")]
		set
		{
		}
	}

	// Token: 0x170004BF RID: 1215
	// (get) Token: 0x06000960 RID: 2400 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000961 RID: 2401 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004BF")]
	public BoltEntity Weapon
	{
		[Token(Token = "0x6000960")]
		[Address(RVA = "0x841350", Offset = "0x83F950", VA = "0x180841350")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000961")]
		[Address(RVA = "0x8413F0", Offset = "0x83F9F0", VA = "0x1808413F0")]
		set
		{
		}
	}

	// Token: 0x06000962 RID: 2402 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000962")]
	[Address(RVA = "0x841610", Offset = "0x83FC10", VA = "0x180841610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000963 RID: 2403 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000963")]
	[Address(RVA = "0x841F90", Offset = "0x840590", VA = "0x180841F90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerHitEnemy Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000964 RID: 2404 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000964")]
	[Address(RVA = "0x841FA0", Offset = "0x8405A0", VA = "0x180841FA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerHitEnemy Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000965 RID: 2405 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000965")]
	[Address(RVA = "0x8421A0", Offset = "0x8407A0", VA = "0x1808421A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static PlayerHitEnemy Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000966 RID: 2406 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000966")]
	[Address(RVA = "0x8422C0", Offset = "0x8408C0", VA = "0x1808422C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerHitEnemy Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000967 RID: 2407 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000967")]
	[Address(RVA = "0x8422D0", Offset = "0x8408D0", VA = "0x1808422D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerHitEnemy Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000968 RID: 2408 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000968")]
	[Address(RVA = "0x8422E0", Offset = "0x8408E0", VA = "0x1808422E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerHitEnemy Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000969 RID: 2409 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000969")]
	[Address(RVA = "0x8422F0", Offset = "0x8408F0", VA = "0x1808422F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerHitEnemy Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600096A RID: 2410 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600096A")]
	[Address(RVA = "0x842310", Offset = "0x840910", VA = "0x180842310")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerHitEnemy Raise()
	{
		return null;
	}

	// Token: 0x0600096B RID: 2411 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600096B")]
	[Address(RVA = "0x842330", Offset = "0x840930", VA = "0x180842330")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerHitEnemy Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600096C RID: 2412 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600096C")]
	[Address(RVA = "0x841F90", Offset = "0x840590", VA = "0x180841F90")]
	public static PlayerHitEnemy Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600096D RID: 2413 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600096D")]
	[Address(RVA = "0x842340", Offset = "0x840940", VA = "0x180842340")]
	public static PlayerHitEnemy Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600096E RID: 2414 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600096E")]
	[Address(RVA = "0x842540", Offset = "0x840B40", VA = "0x180842540")]
	private static PlayerHitEnemy Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600096F RID: 2415 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600096F")]
	[Address(RVA = "0x8422C0", Offset = "0x8408C0", VA = "0x1808422C0")]
	public static PlayerHitEnemy Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000970 RID: 2416 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000970")]
	[Address(RVA = "0x8422D0", Offset = "0x8408D0", VA = "0x1808422D0")]
	public static PlayerHitEnemy Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000971 RID: 2417 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000971")]
	[Address(RVA = "0x8422E0", Offset = "0x8408E0", VA = "0x1808422E0")]
	public static PlayerHitEnemy Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000972 RID: 2418 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000972")]
	[Address(RVA = "0x8422F0", Offset = "0x8408F0", VA = "0x1808422F0")]
	public static PlayerHitEnemy Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000973 RID: 2419 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000973")]
	[Address(RVA = "0x842310", Offset = "0x840910", VA = "0x180842310")]
	public static PlayerHitEnemy Create()
	{
		return null;
	}

	// Token: 0x06000974 RID: 2420 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000974")]
	[Address(RVA = "0x842330", Offset = "0x840930", VA = "0x180842330")]
	public static PlayerHitEnemy Create(ReliabilityModes reliability)
	{
		return null;
	}
}
