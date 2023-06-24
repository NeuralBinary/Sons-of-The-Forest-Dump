using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000132 RID: 306
[Token(Token = "0x2000132")]
public class PlaceRope : Event
{
	// Token: 0x06000E17 RID: 3607 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E17")]
	[Address(RVA = "0x86A470", Offset = "0x868A70", VA = "0x18086A470")]
	public PlaceRope()
	{
	}

	// Token: 0x17000579 RID: 1401
	// (get) Token: 0x06000E18 RID: 3608 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000E19 RID: 3609 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000579")]
	public BoltEntity AnchorEntity
	{
		[Token(Token = "0x6000E18")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E19")]
		[Address(RVA = "0x86A4D0", Offset = "0x868AD0", VA = "0x18086A4D0")]
		set
		{
		}
	}

	// Token: 0x1700057A RID: 1402
	// (get) Token: 0x06000E1A RID: 3610 RVA: 0x000060D8 File Offset: 0x000042D8
	// (set) Token: 0x06000E1B RID: 3611 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700057A")]
	public int AnchorIndex
	{
		[Token(Token = "0x6000E1A")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000E1B")]
		[Address(RVA = "0x7D6DC0", Offset = "0x7D53C0", VA = "0x1807D6DC0")]
		set
		{
		}
	}

	// Token: 0x1700057B RID: 1403
	// (get) Token: 0x06000E1C RID: 3612 RVA: 0x000060F0 File Offset: 0x000042F0
	// (set) Token: 0x06000E1D RID: 3613 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700057B")]
	public Vector3 Position
	{
		[Token(Token = "0x6000E1C")]
		[Address(RVA = "0x7B55E0", Offset = "0x7B3BE0", VA = "0x1807B55E0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000E1D")]
		[Address(RVA = "0x843CF0", Offset = "0x8422F0", VA = "0x180843CF0")]
		set
		{
		}
	}

	// Token: 0x1700057C RID: 1404
	// (get) Token: 0x06000E1E RID: 3614 RVA: 0x00006108 File Offset: 0x00004308
	// (set) Token: 0x06000E1F RID: 3615 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700057C")]
	public Quaternion Rotation
	{
		[Token(Token = "0x6000E1E")]
		[Address(RVA = "0x7DD6C0", Offset = "0x7DBCC0", VA = "0x1807DD6C0")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000E1F")]
		[Address(RVA = "0x7DD730", Offset = "0x7DBD30", VA = "0x1807DD730")]
		set
		{
		}
	}

	// Token: 0x06000E20 RID: 3616 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E20")]
	[Address(RVA = "0x86A6E0", Offset = "0x868CE0", VA = "0x18086A6E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000E21 RID: 3617 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E21")]
	[Address(RVA = "0x86AA30", Offset = "0x869030", VA = "0x18086AA30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceRope Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000E22 RID: 3618 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E22")]
	[Address(RVA = "0x86AA40", Offset = "0x869040", VA = "0x18086AA40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceRope Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000E23 RID: 3619 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E23")]
	[Address(RVA = "0x86AC40", Offset = "0x869240", VA = "0x18086AC40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static PlaceRope Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E24 RID: 3620 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E24")]
	[Address(RVA = "0x86AD60", Offset = "0x869360", VA = "0x18086AD60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceRope Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000E25 RID: 3621 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E25")]
	[Address(RVA = "0x86AD70", Offset = "0x869370", VA = "0x18086AD70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceRope Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E26 RID: 3622 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E26")]
	[Address(RVA = "0x86AD80", Offset = "0x869380", VA = "0x18086AD80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceRope Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000E27 RID: 3623 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E27")]
	[Address(RVA = "0x86AD90", Offset = "0x869390", VA = "0x18086AD90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceRope Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E28 RID: 3624 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E28")]
	[Address(RVA = "0x86ADB0", Offset = "0x8693B0", VA = "0x18086ADB0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceRope Raise()
	{
		return null;
	}

	// Token: 0x06000E29 RID: 3625 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E29")]
	[Address(RVA = "0x86ADD0", Offset = "0x8693D0", VA = "0x18086ADD0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceRope Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E2A RID: 3626 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E2A")]
	[Address(RVA = "0x86AA30", Offset = "0x869030", VA = "0x18086AA30")]
	public static PlaceRope Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000E2B RID: 3627 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E2B")]
	[Address(RVA = "0x86ADE0", Offset = "0x8693E0", VA = "0x18086ADE0")]
	public static PlaceRope Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000E2C RID: 3628 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E2C")]
	[Address(RVA = "0x86AFE0", Offset = "0x8695E0", VA = "0x18086AFE0")]
	private static PlaceRope Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E2D RID: 3629 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E2D")]
	[Address(RVA = "0x86AD60", Offset = "0x869360", VA = "0x18086AD60")]
	public static PlaceRope Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000E2E RID: 3630 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E2E")]
	[Address(RVA = "0x86AD70", Offset = "0x869370", VA = "0x18086AD70")]
	public static PlaceRope Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E2F RID: 3631 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E2F")]
	[Address(RVA = "0x86AD80", Offset = "0x869380", VA = "0x18086AD80")]
	public static PlaceRope Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000E30 RID: 3632 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E30")]
	[Address(RVA = "0x86AD90", Offset = "0x869390", VA = "0x18086AD90")]
	public static PlaceRope Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E31 RID: 3633 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E31")]
	[Address(RVA = "0x86ADB0", Offset = "0x8693B0", VA = "0x18086ADB0")]
	public static PlaceRope Create()
	{
		return null;
	}

	// Token: 0x06000E32 RID: 3634 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E32")]
	[Address(RVA = "0x86ADD0", Offset = "0x8693D0", VA = "0x18086ADD0")]
	public static PlaceRope Create(ReliabilityModes reliability)
	{
		return null;
	}
}
