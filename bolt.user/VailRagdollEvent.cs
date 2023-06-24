using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200028E RID: 654
[Token(Token = "0x200028E")]
public class VailRagdollEvent : Event
{
	// Token: 0x06001DEF RID: 7663 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DEF")]
	[Address(RVA = "0x7F32C0", Offset = "0x7F18C0", VA = "0x1807F32C0")]
	public VailRagdollEvent()
	{
	}

	// Token: 0x1700081D RID: 2077
	// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001DF1 RID: 7665 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700081D")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001DF0")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001DF1")]
		[Address(RVA = "0x7F3320", Offset = "0x7F1920", VA = "0x1807F3320")]
		set
		{
		}
	}

	// Token: 0x1700081E RID: 2078
	// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x00008B98 File Offset: 0x00006D98
	// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700081E")]
	public int Type
	{
		[Token(Token = "0x6001DF2")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001DF3")]
		[Address(RVA = "0x7F3530", Offset = "0x7F1B30", VA = "0x1807F3530")]
		set
		{
		}
	}

	// Token: 0x1700081F RID: 2079
	// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x00008BB0 File Offset: 0x00006DB0
	// (set) Token: 0x06001DF5 RID: 7669 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700081F")]
	public Vector3 Velocity
	{
		[Token(Token = "0x6001DF4")]
		[Address(RVA = "0x7B55E0", Offset = "0x7B3BE0", VA = "0x1807B55E0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001DF5")]
		[Address(RVA = "0x7F35E0", Offset = "0x7F1BE0", VA = "0x1807F35E0")]
		set
		{
		}
	}

	// Token: 0x17000820 RID: 2080
	// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x00008BC8 File Offset: 0x00006DC8
	// (set) Token: 0x06001DF7 RID: 7671 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000820")]
	public Vector3 Position
	{
		[Token(Token = "0x6001DF6")]
		[Address(RVA = "0x7D5EB0", Offset = "0x7D44B0", VA = "0x1807D5EB0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001DF7")]
		[Address(RVA = "0x7F36F0", Offset = "0x7F1CF0", VA = "0x1807F36F0")]
		set
		{
		}
	}

	// Token: 0x06001DF8 RID: 7672 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DF8")]
	[Address(RVA = "0x7F3800", Offset = "0x7F1E00", VA = "0x1807F3800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001DF9 RID: 7673 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DF9")]
	[Address(RVA = "0x7F3AD0", Offset = "0x7F20D0", VA = "0x1807F3AD0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailRagdollEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001DFA RID: 7674 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DFA")]
	[Address(RVA = "0x7F3AE0", Offset = "0x7F20E0", VA = "0x1807F3AE0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailRagdollEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001DFB RID: 7675 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DFB")]
	[Address(RVA = "0x7F3CE0", Offset = "0x7F22E0", VA = "0x1807F3CE0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static VailRagdollEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001DFC RID: 7676 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DFC")]
	[Address(RVA = "0x7F3E00", Offset = "0x7F2400", VA = "0x1807F3E00")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailRagdollEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001DFD RID: 7677 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DFD")]
	[Address(RVA = "0x7F3E10", Offset = "0x7F2410", VA = "0x1807F3E10")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailRagdollEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001DFE RID: 7678 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DFE")]
	[Address(RVA = "0x7F3E20", Offset = "0x7F2420", VA = "0x1807F3E20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailRagdollEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001DFF RID: 7679 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DFF")]
	[Address(RVA = "0x7F3E30", Offset = "0x7F2430", VA = "0x1807F3E30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailRagdollEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E00 RID: 7680 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E00")]
	[Address(RVA = "0x7F3E50", Offset = "0x7F2450", VA = "0x1807F3E50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailRagdollEvent Raise()
	{
		return null;
	}

	// Token: 0x06001E01 RID: 7681 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E01")]
	[Address(RVA = "0x7F3E70", Offset = "0x7F2470", VA = "0x1807F3E70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailRagdollEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E02 RID: 7682 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E02")]
	[Address(RVA = "0x7F3AD0", Offset = "0x7F20D0", VA = "0x1807F3AD0")]
	public static VailRagdollEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001E03 RID: 7683 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E03")]
	[Address(RVA = "0x7F3E80", Offset = "0x7F2480", VA = "0x1807F3E80")]
	public static VailRagdollEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001E04 RID: 7684 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E04")]
	[Address(RVA = "0x7F4080", Offset = "0x7F2680", VA = "0x1807F4080")]
	private static VailRagdollEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E05 RID: 7685 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E05")]
	[Address(RVA = "0x7F3E00", Offset = "0x7F2400", VA = "0x1807F3E00")]
	public static VailRagdollEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001E06 RID: 7686 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E06")]
	[Address(RVA = "0x7F3E10", Offset = "0x7F2410", VA = "0x1807F3E10")]
	public static VailRagdollEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E07 RID: 7687 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E07")]
	[Address(RVA = "0x7F3E20", Offset = "0x7F2420", VA = "0x1807F3E20")]
	public static VailRagdollEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001E08 RID: 7688 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E08")]
	[Address(RVA = "0x7F3E30", Offset = "0x7F2430", VA = "0x1807F3E30")]
	public static VailRagdollEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E09 RID: 7689 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E09")]
	[Address(RVA = "0x7F3E50", Offset = "0x7F2450", VA = "0x1807F3E50")]
	public static VailRagdollEvent Create()
	{
		return null;
	}

	// Token: 0x06001E0A RID: 7690 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E0A")]
	[Address(RVA = "0x7F3E70", Offset = "0x7F2470", VA = "0x1807F3E70")]
	public static VailRagdollEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
