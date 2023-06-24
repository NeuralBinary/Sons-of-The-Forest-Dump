using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001DA RID: 474
[Token(Token = "0x20001DA")]
public class VailHitEvent : Event
{
	// Token: 0x06001589 RID: 5513 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001589")]
	[Address(RVA = "0x8A65F0", Offset = "0x8A4BF0", VA = "0x1808A65F0")]
	public VailHitEvent()
	{
	}

	// Token: 0x170006A4 RID: 1700
	// (get) Token: 0x0600158A RID: 5514 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600158B RID: 5515 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006A4")]
	public BoltEntity Target
	{
		[Token(Token = "0x600158A")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600158B")]
		[Address(RVA = "0x8A6650", Offset = "0x8A4C50", VA = "0x1808A6650")]
		set
		{
		}
	}

	// Token: 0x170006A5 RID: 1701
	// (get) Token: 0x0600158C RID: 5516 RVA: 0x00007290 File Offset: 0x00005490
	// (set) Token: 0x0600158D RID: 5517 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006A5")]
	public float Damage
	{
		[Token(Token = "0x600158C")]
		[Address(RVA = "0x7B78E0", Offset = "0x7B5EE0", VA = "0x1807B78E0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600158D")]
		[Address(RVA = "0x8A6860", Offset = "0x8A4E60", VA = "0x1808A6860")]
		set
		{
		}
	}

	// Token: 0x170006A6 RID: 1702
	// (get) Token: 0x0600158E RID: 5518 RVA: 0x000072A8 File Offset: 0x000054A8
	// (set) Token: 0x0600158F RID: 5519 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006A6")]
	public int DamageNodeId
	{
		[Token(Token = "0x600158E")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600158F")]
		[Address(RVA = "0x83CBD0", Offset = "0x83B1D0", VA = "0x18083CBD0")]
		set
		{
		}
	}

	// Token: 0x170006A7 RID: 1703
	// (get) Token: 0x06001590 RID: 5520 RVA: 0x000072C0 File Offset: 0x000054C0
	// (set) Token: 0x06001591 RID: 5521 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006A7")]
	public float Weight
	{
		[Token(Token = "0x6001590")]
		[Address(RVA = "0x7C2150", Offset = "0x7C0750", VA = "0x1807C2150")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001591")]
		[Address(RVA = "0x8A6920", Offset = "0x8A4F20", VA = "0x1808A6920")]
		set
		{
		}
	}

	// Token: 0x170006A8 RID: 1704
	// (get) Token: 0x06001592 RID: 5522 RVA: 0x000072D8 File Offset: 0x000054D8
	// (set) Token: 0x06001593 RID: 5523 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006A8")]
	public int Direction
	{
		[Token(Token = "0x6001592")]
		[Address(RVA = "0x7BB500", Offset = "0x7B9B00", VA = "0x1807BB500")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001593")]
		[Address(RVA = "0x8A69E0", Offset = "0x8A4FE0", VA = "0x1808A69E0")]
		set
		{
		}
	}

	// Token: 0x170006A9 RID: 1705
	// (get) Token: 0x06001594 RID: 5524 RVA: 0x000072F0 File Offset: 0x000054F0
	// (set) Token: 0x06001595 RID: 5525 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006A9")]
	public int ImpactType
	{
		[Token(Token = "0x6001594")]
		[Address(RVA = "0x7E1E00", Offset = "0x7E0400", VA = "0x1807E1E00")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001595")]
		[Address(RVA = "0x8A6A90", Offset = "0x8A5090", VA = "0x1808A6A90")]
		set
		{
		}
	}

	// Token: 0x170006AA RID: 1706
	// (get) Token: 0x06001596 RID: 5526 RVA: 0x00007308 File Offset: 0x00005508
	// (set) Token: 0x06001597 RID: 5527 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006AA")]
	public int SubImpactType
	{
		[Token(Token = "0x6001596")]
		[Address(RVA = "0x8268A0", Offset = "0x824EA0", VA = "0x1808268A0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001597")]
		[Address(RVA = "0x8A6B40", Offset = "0x8A5140", VA = "0x1808A6B40")]
		set
		{
		}
	}

	// Token: 0x170006AB RID: 1707
	// (get) Token: 0x06001598 RID: 5528 RVA: 0x00007320 File Offset: 0x00005520
	// (set) Token: 0x06001599 RID: 5529 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006AB")]
	public Vector3 Velocity
	{
		[Token(Token = "0x6001598")]
		[Address(RVA = "0x8A6BF0", Offset = "0x8A51F0", VA = "0x1808A6BF0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001599")]
		[Address(RVA = "0x8A6C70", Offset = "0x8A5270", VA = "0x1808A6C70")]
		set
		{
		}
	}

	// Token: 0x170006AC RID: 1708
	// (get) Token: 0x0600159A RID: 5530 RVA: 0x00007338 File Offset: 0x00005538
	// (set) Token: 0x0600159B RID: 5531 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006AC")]
	public Vector3 SenderDir
	{
		[Token(Token = "0x600159A")]
		[Address(RVA = "0x8A6D80", Offset = "0x8A5380", VA = "0x1808A6D80")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600159B")]
		[Address(RVA = "0x8A6E00", Offset = "0x8A5400", VA = "0x1808A6E00")]
		set
		{
		}
	}

	// Token: 0x170006AD RID: 1709
	// (get) Token: 0x0600159C RID: 5532 RVA: 0x00007350 File Offset: 0x00005550
	// (set) Token: 0x0600159D RID: 5533 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006AD")]
	public bool HitBehind
	{
		[Token(Token = "0x600159C")]
		[Address(RVA = "0x82D2C0", Offset = "0x82B8C0", VA = "0x18082D2C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600159D")]
		[Address(RVA = "0x83AB40", Offset = "0x839140", VA = "0x18083AB40")]
		set
		{
		}
	}

	// Token: 0x170006AE RID: 1710
	// (get) Token: 0x0600159E RID: 5534 RVA: 0x00007368 File Offset: 0x00005568
	// (set) Token: 0x0600159F RID: 5535 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006AE")]
	public bool ComboEnder
	{
		[Token(Token = "0x600159E")]
		[Address(RVA = "0x8410B0", Offset = "0x83F6B0", VA = "0x1808410B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600159F")]
		[Address(RVA = "0x841110", Offset = "0x83F710", VA = "0x180841110")]
		set
		{
		}
	}

	// Token: 0x170006AF RID: 1711
	// (get) Token: 0x060015A0 RID: 5536 RVA: 0x00007380 File Offset: 0x00005580
	// (set) Token: 0x060015A1 RID: 5537 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006AF")]
	public bool Knockdown
	{
		[Token(Token = "0x60015A0")]
		[Address(RVA = "0x8411B0", Offset = "0x83F7B0", VA = "0x1808411B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60015A1")]
		[Address(RVA = "0x841210", Offset = "0x83F810", VA = "0x180841210")]
		set
		{
		}
	}

	// Token: 0x170006B0 RID: 1712
	// (get) Token: 0x060015A2 RID: 5538 RVA: 0x00007398 File Offset: 0x00005598
	// (set) Token: 0x060015A3 RID: 5539 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006B0")]
	public bool PowerAttack
	{
		[Token(Token = "0x60015A2")]
		[Address(RVA = "0x80C6B0", Offset = "0x80ACB0", VA = "0x18080C6B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60015A3")]
		[Address(RVA = "0x8412B0", Offset = "0x83F8B0", VA = "0x1808412B0")]
		set
		{
		}
	}

	// Token: 0x170006B1 RID: 1713
	// (get) Token: 0x060015A4 RID: 5540 RVA: 0x000073B0 File Offset: 0x000055B0
	// (set) Token: 0x060015A5 RID: 5541 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006B1")]
	public int StatusType
	{
		[Token(Token = "0x60015A4")]
		[Address(RVA = "0x8A6F10", Offset = "0x8A5510", VA = "0x1808A6F10")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60015A5")]
		[Address(RVA = "0x8A6F70", Offset = "0x8A5570", VA = "0x1808A6F70")]
		set
		{
		}
	}

	// Token: 0x170006B2 RID: 1714
	// (get) Token: 0x060015A6 RID: 5542 RVA: 0x000073C8 File Offset: 0x000055C8
	// (set) Token: 0x060015A7 RID: 5543 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006B2")]
	public float StatusDuration
	{
		[Token(Token = "0x60015A6")]
		[Address(RVA = "0x8A7020", Offset = "0x8A5620", VA = "0x1808A7020")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60015A7")]
		[Address(RVA = "0x8A7080", Offset = "0x8A5680", VA = "0x1808A7080")]
		set
		{
		}
	}

	// Token: 0x170006B3 RID: 1715
	// (get) Token: 0x060015A8 RID: 5544 RVA: 0x000073E0 File Offset: 0x000055E0
	// (set) Token: 0x060015A9 RID: 5545 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006B3")]
	public bool Blocked
	{
		[Token(Token = "0x60015A8")]
		[Address(RVA = "0x80CB10", Offset = "0x80B110", VA = "0x18080CB10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60015A9")]
		[Address(RVA = "0x8A7140", Offset = "0x8A5740", VA = "0x1808A7140")]
		set
		{
		}
	}

	// Token: 0x060015AA RID: 5546 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015AA")]
	[Address(RVA = "0x8A71E0", Offset = "0x8A57E0", VA = "0x1808A71E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060015AB RID: 5547 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015AB")]
	[Address(RVA = "0x8A7C30", Offset = "0x8A6230", VA = "0x1808A7C30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailHitEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060015AC RID: 5548 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015AC")]
	[Address(RVA = "0x8A7C40", Offset = "0x8A6240", VA = "0x1808A7C40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailHitEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060015AD RID: 5549 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015AD")]
	[Address(RVA = "0x8A7E40", Offset = "0x8A6440", VA = "0x1808A7E40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static VailHitEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060015AE RID: 5550 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015AE")]
	[Address(RVA = "0x8A7F60", Offset = "0x8A6560", VA = "0x1808A7F60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailHitEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060015AF RID: 5551 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015AF")]
	[Address(RVA = "0x8A7F70", Offset = "0x8A6570", VA = "0x1808A7F70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailHitEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060015B0 RID: 5552 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015B0")]
	[Address(RVA = "0x8A7F80", Offset = "0x8A6580", VA = "0x1808A7F80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailHitEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060015B1 RID: 5553 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015B1")]
	[Address(RVA = "0x8A7F90", Offset = "0x8A6590", VA = "0x1808A7F90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailHitEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060015B2 RID: 5554 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015B2")]
	[Address(RVA = "0x8A7FB0", Offset = "0x8A65B0", VA = "0x1808A7FB0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailHitEvent Raise()
	{
		return null;
	}

	// Token: 0x060015B3 RID: 5555 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015B3")]
	[Address(RVA = "0x8A7FD0", Offset = "0x8A65D0", VA = "0x1808A7FD0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailHitEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060015B4 RID: 5556 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015B4")]
	[Address(RVA = "0x8A7C30", Offset = "0x8A6230", VA = "0x1808A7C30")]
	public static VailHitEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060015B5 RID: 5557 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015B5")]
	[Address(RVA = "0x8A7FE0", Offset = "0x8A65E0", VA = "0x1808A7FE0")]
	public static VailHitEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060015B6 RID: 5558 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015B6")]
	[Address(RVA = "0x8A81E0", Offset = "0x8A67E0", VA = "0x1808A81E0")]
	private static VailHitEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060015B7 RID: 5559 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015B7")]
	[Address(RVA = "0x8A7F60", Offset = "0x8A6560", VA = "0x1808A7F60")]
	public static VailHitEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060015B8 RID: 5560 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015B8")]
	[Address(RVA = "0x8A7F70", Offset = "0x8A6570", VA = "0x1808A7F70")]
	public static VailHitEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060015B9 RID: 5561 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015B9")]
	[Address(RVA = "0x8A7F80", Offset = "0x8A6580", VA = "0x1808A7F80")]
	public static VailHitEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060015BA RID: 5562 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015BA")]
	[Address(RVA = "0x8A7F90", Offset = "0x8A6590", VA = "0x1808A7F90")]
	public static VailHitEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060015BB RID: 5563 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015BB")]
	[Address(RVA = "0x8A7FB0", Offset = "0x8A65B0", VA = "0x1808A7FB0")]
	public static VailHitEvent Create()
	{
		return null;
	}

	// Token: 0x060015BC RID: 5564 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015BC")]
	[Address(RVA = "0x8A7FD0", Offset = "0x8A65D0", VA = "0x1808A7FD0")]
	public static VailHitEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
