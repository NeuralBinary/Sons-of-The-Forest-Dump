using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000CC RID: 204
[Token(Token = "0x20000CC")]
public class HitPlayer : Event
{
	// Token: 0x0600097F RID: 2431 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600097F")]
	[Address(RVA = "0x8439D0", Offset = "0x841FD0", VA = "0x1808439D0")]
	public HitPlayer()
	{
	}

	// Token: 0x170004C3 RID: 1219
	// (get) Token: 0x06000980 RID: 2432 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000981 RID: 2433 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004C3")]
	public BoltEntity Target
	{
		[Token(Token = "0x6000980")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000981")]
		[Address(RVA = "0x843A30", Offset = "0x842030", VA = "0x180843A30")]
		set
		{
		}
	}

	// Token: 0x170004C4 RID: 1220
	// (get) Token: 0x06000982 RID: 2434 RVA: 0x00005628 File Offset: 0x00003828
	// (set) Token: 0x06000983 RID: 2435 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004C4")]
	public int Damage
	{
		[Token(Token = "0x6000982")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000983")]
		[Address(RVA = "0x843C40", Offset = "0x842240", VA = "0x180843C40")]
		set
		{
		}
	}

	// Token: 0x170004C5 RID: 1221
	// (get) Token: 0x06000984 RID: 2436 RVA: 0x00005640 File Offset: 0x00003840
	// (set) Token: 0x06000985 RID: 2437 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004C5")]
	public Vector3 AttackerPos
	{
		[Token(Token = "0x6000984")]
		[Address(RVA = "0x7B55E0", Offset = "0x7B3BE0", VA = "0x1807B55E0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000985")]
		[Address(RVA = "0x843CF0", Offset = "0x8422F0", VA = "0x180843CF0")]
		set
		{
		}
	}

	// Token: 0x170004C6 RID: 1222
	// (get) Token: 0x06000986 RID: 2438 RVA: 0x00005658 File Offset: 0x00003858
	// (set) Token: 0x06000987 RID: 2439 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004C6")]
	public int ImpactType
	{
		[Token(Token = "0x6000986")]
		[Address(RVA = "0x7B6B40", Offset = "0x7B5140", VA = "0x1807B6B40")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000987")]
		[Address(RVA = "0x843DA0", Offset = "0x8423A0", VA = "0x180843DA0")]
		set
		{
		}
	}

	// Token: 0x170004C7 RID: 1223
	// (get) Token: 0x06000988 RID: 2440 RVA: 0x00005670 File Offset: 0x00003870
	// (set) Token: 0x06000989 RID: 2441 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004C7")]
	public float Weight
	{
		[Token(Token = "0x6000988")]
		[Address(RVA = "0x7B6CA0", Offset = "0x7B52A0", VA = "0x1807B6CA0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000989")]
		[Address(RVA = "0x843E50", Offset = "0x842450", VA = "0x180843E50")]
		set
		{
		}
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600098A")]
	[Address(RVA = "0x843F10", Offset = "0x842510", VA = "0x180843F10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0600098B RID: 2443 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600098B")]
	[Address(RVA = "0x844300", Offset = "0x842900", VA = "0x180844300")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static HitPlayer Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600098C RID: 2444 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600098C")]
	[Address(RVA = "0x844310", Offset = "0x842910", VA = "0x180844310")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static HitPlayer Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600098D RID: 2445 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600098D")]
	[Address(RVA = "0x844510", Offset = "0x842B10", VA = "0x180844510")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static HitPlayer Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600098E RID: 2446 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600098E")]
	[Address(RVA = "0x844630", Offset = "0x842C30", VA = "0x180844630")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static HitPlayer Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600098F")]
	[Address(RVA = "0x844640", Offset = "0x842C40", VA = "0x180844640")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static HitPlayer Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000990 RID: 2448 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000990")]
	[Address(RVA = "0x844650", Offset = "0x842C50", VA = "0x180844650")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static HitPlayer Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000991")]
	[Address(RVA = "0x844660", Offset = "0x842C60", VA = "0x180844660")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static HitPlayer Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000992 RID: 2450 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000992")]
	[Address(RVA = "0x844680", Offset = "0x842C80", VA = "0x180844680")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static HitPlayer Raise()
	{
		return null;
	}

	// Token: 0x06000993 RID: 2451 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000993")]
	[Address(RVA = "0x8446A0", Offset = "0x842CA0", VA = "0x1808446A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static HitPlayer Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000994 RID: 2452 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000994")]
	[Address(RVA = "0x844300", Offset = "0x842900", VA = "0x180844300")]
	public static HitPlayer Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000995 RID: 2453 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000995")]
	[Address(RVA = "0x8446B0", Offset = "0x842CB0", VA = "0x1808446B0")]
	public static HitPlayer Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000996")]
	[Address(RVA = "0x8448B0", Offset = "0x842EB0", VA = "0x1808448B0")]
	private static HitPlayer Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000997 RID: 2455 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000997")]
	[Address(RVA = "0x844630", Offset = "0x842C30", VA = "0x180844630")]
	public static HitPlayer Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000998 RID: 2456 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000998")]
	[Address(RVA = "0x844640", Offset = "0x842C40", VA = "0x180844640")]
	public static HitPlayer Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000999 RID: 2457 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000999")]
	[Address(RVA = "0x844650", Offset = "0x842C50", VA = "0x180844650")]
	public static HitPlayer Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600099A RID: 2458 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600099A")]
	[Address(RVA = "0x844660", Offset = "0x842C60", VA = "0x180844660")]
	public static HitPlayer Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600099B RID: 2459 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600099B")]
	[Address(RVA = "0x844680", Offset = "0x842C80", VA = "0x180844680")]
	public static HitPlayer Create()
	{
		return null;
	}

	// Token: 0x0600099C RID: 2460 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600099C")]
	[Address(RVA = "0x8446A0", Offset = "0x842CA0", VA = "0x1808446A0")]
	public static HitPlayer Create(ReliabilityModes reliability)
	{
		return null;
	}
}
