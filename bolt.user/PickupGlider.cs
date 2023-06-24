using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C2 RID: 450
[Token(Token = "0x20001C2")]
public class PickupGlider : Event
{
	// Token: 0x06001477 RID: 5239 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001477")]
	[Address(RVA = "0x89DB10", Offset = "0x89C110", VA = "0x18089DB10")]
	public PickupGlider()
	{
	}

	// Token: 0x1700066D RID: 1645
	// (get) Token: 0x06001478 RID: 5240 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001479 RID: 5241 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700066D")]
	public BoltEntity targetEntity
	{
		[Token(Token = "0x6001478")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001479")]
		[Address(RVA = "0x89DB70", Offset = "0x89C170", VA = "0x18089DB70")]
		set
		{
		}
	}

	// Token: 0x1700066E RID: 1646
	// (get) Token: 0x0600147A RID: 5242 RVA: 0x00006EB8 File Offset: 0x000050B8
	// (set) Token: 0x0600147B RID: 5243 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700066E")]
	public bool dropGlider
	{
		[Token(Token = "0x600147A")]
		[Address(RVA = "0x7B5490", Offset = "0x7B3A90", VA = "0x1807B5490")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600147B")]
		[Address(RVA = "0x7E82E0", Offset = "0x7E68E0", VA = "0x1807E82E0")]
		set
		{
		}
	}

	// Token: 0x1700066F RID: 1647
	// (get) Token: 0x0600147C RID: 5244 RVA: 0x00006ED0 File Offset: 0x000050D0
	// (set) Token: 0x0600147D RID: 5245 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700066F")]
	public Vector3 dropPos
	{
		[Token(Token = "0x600147C")]
		[Address(RVA = "0x7B55E0", Offset = "0x7B3BE0", VA = "0x1807B55E0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600147D")]
		[Address(RVA = "0x843CF0", Offset = "0x8422F0", VA = "0x180843CF0")]
		set
		{
		}
	}

	// Token: 0x17000670 RID: 1648
	// (get) Token: 0x0600147E RID: 5246 RVA: 0x00006EE8 File Offset: 0x000050E8
	// (set) Token: 0x0600147F RID: 5247 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000670")]
	public Quaternion dropRot
	{
		[Token(Token = "0x600147E")]
		[Address(RVA = "0x7DD6C0", Offset = "0x7DBCC0", VA = "0x1807DD6C0")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600147F")]
		[Address(RVA = "0x7DD730", Offset = "0x7DBD30", VA = "0x1807DD730")]
		set
		{
		}
	}

	// Token: 0x17000671 RID: 1649
	// (get) Token: 0x06001480 RID: 5248 RVA: 0x00006F00 File Offset: 0x00005100
	// (set) Token: 0x06001481 RID: 5249 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000671")]
	public Vector3 targetVelocity
	{
		[Token(Token = "0x6001480")]
		[Address(RVA = "0x84D4F0", Offset = "0x84BAF0", VA = "0x18084D4F0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001481")]
		[Address(RVA = "0x89DD80", Offset = "0x89C380", VA = "0x18089DD80")]
		set
		{
		}
	}

	// Token: 0x17000672 RID: 1650
	// (get) Token: 0x06001482 RID: 5250 RVA: 0x00006F18 File Offset: 0x00005118
	// (set) Token: 0x06001483 RID: 5251 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000672")]
	public PrefabId gliderId
	{
		[Token(Token = "0x6001482")]
		[Address(RVA = "0x7E1E00", Offset = "0x7E0400", VA = "0x1807E1E00")]
		get
		{
			return default(PrefabId);
		}
		[Token(Token = "0x6001483")]
		[Address(RVA = "0x89DE90", Offset = "0x89C490", VA = "0x18089DE90")]
		set
		{
		}
	}

	// Token: 0x06001484 RID: 5252 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001484")]
	[Address(RVA = "0x89DF30", Offset = "0x89C530", VA = "0x18089DF30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001485 RID: 5253 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001485")]
	[Address(RVA = "0x89E360", Offset = "0x89C960", VA = "0x18089E360")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupGlider Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001486 RID: 5254 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001486")]
	[Address(RVA = "0x89E370", Offset = "0x89C970", VA = "0x18089E370")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupGlider Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001487 RID: 5255 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001487")]
	[Address(RVA = "0x89E570", Offset = "0x89CB70", VA = "0x18089E570")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static PickupGlider Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001488 RID: 5256 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001488")]
	[Address(RVA = "0x89E690", Offset = "0x89CC90", VA = "0x18089E690")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupGlider Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001489 RID: 5257 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001489")]
	[Address(RVA = "0x89E6A0", Offset = "0x89CCA0", VA = "0x18089E6A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupGlider Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600148A RID: 5258 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600148A")]
	[Address(RVA = "0x89E6B0", Offset = "0x89CCB0", VA = "0x18089E6B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupGlider Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600148B RID: 5259 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600148B")]
	[Address(RVA = "0x89E6C0", Offset = "0x89CCC0", VA = "0x18089E6C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupGlider Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600148C RID: 5260 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600148C")]
	[Address(RVA = "0x89E6E0", Offset = "0x89CCE0", VA = "0x18089E6E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupGlider Raise()
	{
		return null;
	}

	// Token: 0x0600148D RID: 5261 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600148D")]
	[Address(RVA = "0x89E700", Offset = "0x89CD00", VA = "0x18089E700")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupGlider Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600148E RID: 5262 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600148E")]
	[Address(RVA = "0x89E360", Offset = "0x89C960", VA = "0x18089E360")]
	public static PickupGlider Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600148F RID: 5263 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600148F")]
	[Address(RVA = "0x89E710", Offset = "0x89CD10", VA = "0x18089E710")]
	public static PickupGlider Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001490 RID: 5264 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001490")]
	[Address(RVA = "0x89E910", Offset = "0x89CF10", VA = "0x18089E910")]
	private static PickupGlider Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001491 RID: 5265 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001491")]
	[Address(RVA = "0x89E690", Offset = "0x89CC90", VA = "0x18089E690")]
	public static PickupGlider Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001492 RID: 5266 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001492")]
	[Address(RVA = "0x89E6A0", Offset = "0x89CCA0", VA = "0x18089E6A0")]
	public static PickupGlider Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001493 RID: 5267 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001493")]
	[Address(RVA = "0x89E6B0", Offset = "0x89CCB0", VA = "0x18089E6B0")]
	public static PickupGlider Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001494 RID: 5268 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001494")]
	[Address(RVA = "0x89E6C0", Offset = "0x89CCC0", VA = "0x18089E6C0")]
	public static PickupGlider Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001495 RID: 5269 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001495")]
	[Address(RVA = "0x89E6E0", Offset = "0x89CCE0", VA = "0x18089E6E0")]
	public static PickupGlider Create()
	{
		return null;
	}

	// Token: 0x06001496 RID: 5270 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001496")]
	[Address(RVA = "0x89E700", Offset = "0x89CD00", VA = "0x18089E700")]
	public static PickupGlider Create(ReliabilityModes reliability)
	{
		return null;
	}
}
