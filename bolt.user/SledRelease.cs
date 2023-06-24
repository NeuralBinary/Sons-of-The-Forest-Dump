using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200011A RID: 282
[Token(Token = "0x200011A")]
public class SledRelease : Event
{
	// Token: 0x06000CFB RID: 3323 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CFB")]
	[Address(RVA = "0x8606D0", Offset = "0x85ECD0", VA = "0x1808606D0")]
	public SledRelease()
	{
	}

	// Token: 0x1700054B RID: 1355
	// (get) Token: 0x06000CFC RID: 3324 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000CFD RID: 3325 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700054B")]
	public BoltEntity Player
	{
		[Token(Token = "0x6000CFC")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000CFD")]
		[Address(RVA = "0x860730", Offset = "0x85ED30", VA = "0x180860730")]
		set
		{
		}
	}

	// Token: 0x1700054C RID: 1356
	// (get) Token: 0x06000CFE RID: 3326 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000CFF RID: 3327 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700054C")]
	public BoltEntity Sled
	{
		[Token(Token = "0x6000CFE")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000CFF")]
		[Address(RVA = "0x860940", Offset = "0x85EF40", VA = "0x180860940")]
		set
		{
		}
	}

	// Token: 0x1700054D RID: 1357
	// (get) Token: 0x06000D00 RID: 3328 RVA: 0x00005E50 File Offset: 0x00004050
	// (set) Token: 0x06000D01 RID: 3329 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700054D")]
	public Vector3 Position
	{
		[Token(Token = "0x6000D00")]
		[Address(RVA = "0x7B55E0", Offset = "0x7B3BE0", VA = "0x1807B55E0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000D01")]
		[Address(RVA = "0x843CF0", Offset = "0x8422F0", VA = "0x180843CF0")]
		set
		{
		}
	}

	// Token: 0x1700054E RID: 1358
	// (get) Token: 0x06000D02 RID: 3330 RVA: 0x00005E68 File Offset: 0x00004068
	// (set) Token: 0x06000D03 RID: 3331 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700054E")]
	public Quaternion Rotation
	{
		[Token(Token = "0x6000D02")]
		[Address(RVA = "0x7DD6C0", Offset = "0x7DBCC0", VA = "0x1807DD6C0")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000D03")]
		[Address(RVA = "0x7DD730", Offset = "0x7DBD30", VA = "0x1807DD730")]
		set
		{
		}
	}

	// Token: 0x06000D04 RID: 3332 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D04")]
	[Address(RVA = "0x860B50", Offset = "0x85F150", VA = "0x180860B50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000D05 RID: 3333 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D05")]
	[Address(RVA = "0x860DC0", Offset = "0x85F3C0", VA = "0x180860DC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SledRelease Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000D06 RID: 3334 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D06")]
	[Address(RVA = "0x860DD0", Offset = "0x85F3D0", VA = "0x180860DD0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SledRelease Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000D07 RID: 3335 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D07")]
	[Address(RVA = "0x860FD0", Offset = "0x85F5D0", VA = "0x180860FD0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static SledRelease Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D08 RID: 3336 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D08")]
	[Address(RVA = "0x8610F0", Offset = "0x85F6F0", VA = "0x1808610F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SledRelease Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000D09 RID: 3337 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D09")]
	[Address(RVA = "0x861100", Offset = "0x85F700", VA = "0x180861100")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SledRelease Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D0A RID: 3338 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D0A")]
	[Address(RVA = "0x861110", Offset = "0x85F710", VA = "0x180861110")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SledRelease Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000D0B RID: 3339 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D0B")]
	[Address(RVA = "0x861120", Offset = "0x85F720", VA = "0x180861120")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SledRelease Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D0C RID: 3340 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D0C")]
	[Address(RVA = "0x861140", Offset = "0x85F740", VA = "0x180861140")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SledRelease Raise()
	{
		return null;
	}

	// Token: 0x06000D0D RID: 3341 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D0D")]
	[Address(RVA = "0x861160", Offset = "0x85F760", VA = "0x180861160")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SledRelease Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D0E RID: 3342 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D0E")]
	[Address(RVA = "0x860DC0", Offset = "0x85F3C0", VA = "0x180860DC0")]
	public static SledRelease Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000D0F RID: 3343 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D0F")]
	[Address(RVA = "0x861170", Offset = "0x85F770", VA = "0x180861170")]
	public static SledRelease Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000D10 RID: 3344 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D10")]
	[Address(RVA = "0x861370", Offset = "0x85F970", VA = "0x180861370")]
	private static SledRelease Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D11 RID: 3345 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D11")]
	[Address(RVA = "0x8610F0", Offset = "0x85F6F0", VA = "0x1808610F0")]
	public static SledRelease Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000D12 RID: 3346 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D12")]
	[Address(RVA = "0x861100", Offset = "0x85F700", VA = "0x180861100")]
	public static SledRelease Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D13 RID: 3347 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D13")]
	[Address(RVA = "0x861110", Offset = "0x85F710", VA = "0x180861110")]
	public static SledRelease Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000D14 RID: 3348 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D14")]
	[Address(RVA = "0x861120", Offset = "0x85F720", VA = "0x180861120")]
	public static SledRelease Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000D15 RID: 3349 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D15")]
	[Address(RVA = "0x861140", Offset = "0x85F740", VA = "0x180861140")]
	public static SledRelease Create()
	{
		return null;
	}

	// Token: 0x06000D16 RID: 3350 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D16")]
	[Address(RVA = "0x861160", Offset = "0x85F760", VA = "0x180861160")]
	public static SledRelease Create(ReliabilityModes reliability)
	{
		return null;
	}
}
