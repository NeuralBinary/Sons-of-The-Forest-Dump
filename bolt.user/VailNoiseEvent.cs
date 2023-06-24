using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001DD RID: 477
[Token(Token = "0x20001DD")]
public class VailNoiseEvent : Event
{
	// Token: 0x060015C7 RID: 5575 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015C7")]
	[Address(RVA = "0x8A9A70", Offset = "0x8A8070", VA = "0x1808A9A70")]
	public VailNoiseEvent()
	{
	}

	// Token: 0x170006B7 RID: 1719
	// (get) Token: 0x060015C8 RID: 5576 RVA: 0x00007428 File Offset: 0x00005628
	// (set) Token: 0x060015C9 RID: 5577 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006B7")]
	public int NoiseType
	{
		[Token(Token = "0x60015C8")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60015C9")]
		[Address(RVA = "0x7FDC20", Offset = "0x7FC220", VA = "0x1807FDC20")]
		set
		{
		}
	}

	// Token: 0x170006B8 RID: 1720
	// (get) Token: 0x060015CA RID: 5578 RVA: 0x00007440 File Offset: 0x00005640
	// (set) Token: 0x060015CB RID: 5579 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006B8")]
	public Vector3 Position
	{
		[Token(Token = "0x60015CA")]
		[Address(RVA = "0x7BCBD0", Offset = "0x7BB1D0", VA = "0x1807BCBD0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60015CB")]
		[Address(RVA = "0x84D2D0", Offset = "0x84B8D0", VA = "0x18084D2D0")]
		set
		{
		}
	}

	// Token: 0x060015CC RID: 5580 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015CC")]
	[Address(RVA = "0x8A9AD0", Offset = "0x8A80D0", VA = "0x1808A9AD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060015CD RID: 5581 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015CD")]
	[Address(RVA = "0x8A9C00", Offset = "0x8A8200", VA = "0x1808A9C00")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailNoiseEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060015CE RID: 5582 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015CE")]
	[Address(RVA = "0x8A9C10", Offset = "0x8A8210", VA = "0x1808A9C10")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailNoiseEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060015CF RID: 5583 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015CF")]
	[Address(RVA = "0x8A9E10", Offset = "0x8A8410", VA = "0x1808A9E10")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static VailNoiseEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060015D0 RID: 5584 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015D0")]
	[Address(RVA = "0x8A9F30", Offset = "0x8A8530", VA = "0x1808A9F30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailNoiseEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060015D1 RID: 5585 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015D1")]
	[Address(RVA = "0x8A9F40", Offset = "0x8A8540", VA = "0x1808A9F40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailNoiseEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060015D2 RID: 5586 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015D2")]
	[Address(RVA = "0x8A9F50", Offset = "0x8A8550", VA = "0x1808A9F50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailNoiseEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060015D3 RID: 5587 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015D3")]
	[Address(RVA = "0x8A9F60", Offset = "0x8A8560", VA = "0x1808A9F60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailNoiseEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060015D4 RID: 5588 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015D4")]
	[Address(RVA = "0x8A9F80", Offset = "0x8A8580", VA = "0x1808A9F80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailNoiseEvent Raise()
	{
		return null;
	}

	// Token: 0x060015D5 RID: 5589 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015D5")]
	[Address(RVA = "0x8A9FA0", Offset = "0x8A85A0", VA = "0x1808A9FA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailNoiseEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060015D6 RID: 5590 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015D6")]
	[Address(RVA = "0x8A9C00", Offset = "0x8A8200", VA = "0x1808A9C00")]
	public static VailNoiseEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060015D7 RID: 5591 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015D7")]
	[Address(RVA = "0x8A9FB0", Offset = "0x8A85B0", VA = "0x1808A9FB0")]
	public static VailNoiseEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060015D8 RID: 5592 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015D8")]
	[Address(RVA = "0x8AA1B0", Offset = "0x8A87B0", VA = "0x1808AA1B0")]
	private static VailNoiseEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060015D9 RID: 5593 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015D9")]
	[Address(RVA = "0x8A9F30", Offset = "0x8A8530", VA = "0x1808A9F30")]
	public static VailNoiseEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060015DA RID: 5594 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015DA")]
	[Address(RVA = "0x8A9F40", Offset = "0x8A8540", VA = "0x1808A9F40")]
	public static VailNoiseEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060015DB RID: 5595 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015DB")]
	[Address(RVA = "0x8A9F50", Offset = "0x8A8550", VA = "0x1808A9F50")]
	public static VailNoiseEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060015DC RID: 5596 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015DC")]
	[Address(RVA = "0x8A9F60", Offset = "0x8A8560", VA = "0x1808A9F60")]
	public static VailNoiseEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060015DD RID: 5597 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015DD")]
	[Address(RVA = "0x8A9F80", Offset = "0x8A8580", VA = "0x1808A9F80")]
	public static VailNoiseEvent Create()
	{
		return null;
	}

	// Token: 0x060015DE RID: 5598 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015DE")]
	[Address(RVA = "0x8A9FA0", Offset = "0x8A85A0", VA = "0x1808A9FA0")]
	public static VailNoiseEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
