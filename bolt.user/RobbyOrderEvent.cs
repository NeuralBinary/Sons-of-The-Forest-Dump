using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001E6 RID: 486
[Token(Token = "0x20001E6")]
public class RobbyOrderEvent : Event
{
	// Token: 0x0600162B RID: 5675 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600162B")]
	[Address(RVA = "0x8AC7F0", Offset = "0x8AADF0", VA = "0x1808AC7F0")]
	public RobbyOrderEvent()
	{
	}

	// Token: 0x170006C5 RID: 1733
	// (get) Token: 0x0600162C RID: 5676 RVA: 0x00007518 File Offset: 0x00005718
	// (set) Token: 0x0600162D RID: 5677 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006C5")]
	public int orderType
	{
		[Token(Token = "0x600162C")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600162D")]
		[Address(RVA = "0x7FDC20", Offset = "0x7FC220", VA = "0x1807FDC20")]
		set
		{
		}
	}

	// Token: 0x170006C6 RID: 1734
	// (get) Token: 0x0600162E RID: 5678 RVA: 0x00007530 File Offset: 0x00005730
	// (set) Token: 0x0600162F RID: 5679 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006C6")]
	public int orderSubType1
	{
		[Token(Token = "0x600162E")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600162F")]
		[Address(RVA = "0x7F3530", Offset = "0x7F1B30", VA = "0x1807F3530")]
		set
		{
		}
	}

	// Token: 0x170006C7 RID: 1735
	// (get) Token: 0x06001630 RID: 5680 RVA: 0x00007548 File Offset: 0x00005748
	// (set) Token: 0x06001631 RID: 5681 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006C7")]
	public int orderSubType2
	{
		[Token(Token = "0x6001630")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001631")]
		[Address(RVA = "0x83CBD0", Offset = "0x83B1D0", VA = "0x18083CBD0")]
		set
		{
		}
	}

	// Token: 0x170006C8 RID: 1736
	// (get) Token: 0x06001632 RID: 5682 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001633 RID: 5683 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006C8")]
	public BoltEntity target
	{
		[Token(Token = "0x6001632")]
		[Address(RVA = "0x7BEA80", Offset = "0x7BD080", VA = "0x1807BEA80")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001633")]
		[Address(RVA = "0x8AC850", Offset = "0x8AAE50", VA = "0x1808AC850")]
		set
		{
		}
	}

	// Token: 0x170006C9 RID: 1737
	// (get) Token: 0x06001634 RID: 5684 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001635 RID: 5685 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006C9")]
	public BoltEntity playerEntity
	{
		[Token(Token = "0x6001634")]
		[Address(RVA = "0x8314C0", Offset = "0x82FAC0", VA = "0x1808314C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001635")]
		[Address(RVA = "0x8ACA70", Offset = "0x8AB070", VA = "0x1808ACA70")]
		set
		{
		}
	}

	// Token: 0x170006CA RID: 1738
	// (get) Token: 0x06001636 RID: 5686 RVA: 0x00007560 File Offset: 0x00005760
	// (set) Token: 0x06001637 RID: 5687 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006CA")]
	public int orderEventType
	{
		[Token(Token = "0x6001636")]
		[Address(RVA = "0x7E1E00", Offset = "0x7E0400", VA = "0x1807E1E00")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001637")]
		[Address(RVA = "0x8A6A90", Offset = "0x8A5090", VA = "0x1808A6A90")]
		set
		{
		}
	}

	// Token: 0x06001638 RID: 5688 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001638")]
	[Address(RVA = "0x8ACC90", Offset = "0x8AB290", VA = "0x1808ACC90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001639 RID: 5689 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001639")]
	[Address(RVA = "0x8AD020", Offset = "0x8AB620", VA = "0x1808AD020")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RobbyOrderEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600163A RID: 5690 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600163A")]
	[Address(RVA = "0x8AD030", Offset = "0x8AB630", VA = "0x1808AD030")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RobbyOrderEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600163B RID: 5691 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600163B")]
	[Address(RVA = "0x8AD230", Offset = "0x8AB830", VA = "0x1808AD230")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static RobbyOrderEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600163C RID: 5692 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600163C")]
	[Address(RVA = "0x8AD350", Offset = "0x8AB950", VA = "0x1808AD350")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RobbyOrderEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600163D RID: 5693 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600163D")]
	[Address(RVA = "0x8AD360", Offset = "0x8AB960", VA = "0x1808AD360")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RobbyOrderEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600163E RID: 5694 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600163E")]
	[Address(RVA = "0x8AD370", Offset = "0x8AB970", VA = "0x1808AD370")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RobbyOrderEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600163F RID: 5695 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600163F")]
	[Address(RVA = "0x8AD380", Offset = "0x8AB980", VA = "0x1808AD380")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RobbyOrderEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001640 RID: 5696 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001640")]
	[Address(RVA = "0x8AD3A0", Offset = "0x8AB9A0", VA = "0x1808AD3A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RobbyOrderEvent Raise()
	{
		return null;
	}

	// Token: 0x06001641 RID: 5697 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001641")]
	[Address(RVA = "0x8AD3C0", Offset = "0x8AB9C0", VA = "0x1808AD3C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RobbyOrderEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001642 RID: 5698 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001642")]
	[Address(RVA = "0x8AD020", Offset = "0x8AB620", VA = "0x1808AD020")]
	public static RobbyOrderEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001643 RID: 5699 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001643")]
	[Address(RVA = "0x8AD3D0", Offset = "0x8AB9D0", VA = "0x1808AD3D0")]
	public static RobbyOrderEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001644 RID: 5700 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001644")]
	[Address(RVA = "0x8AD5D0", Offset = "0x8ABBD0", VA = "0x1808AD5D0")]
	private static RobbyOrderEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001645 RID: 5701 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001645")]
	[Address(RVA = "0x8AD350", Offset = "0x8AB950", VA = "0x1808AD350")]
	public static RobbyOrderEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001646 RID: 5702 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001646")]
	[Address(RVA = "0x8AD360", Offset = "0x8AB960", VA = "0x1808AD360")]
	public static RobbyOrderEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001647 RID: 5703 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001647")]
	[Address(RVA = "0x8AD370", Offset = "0x8AB970", VA = "0x1808AD370")]
	public static RobbyOrderEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001648 RID: 5704 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001648")]
	[Address(RVA = "0x8AD380", Offset = "0x8AB980", VA = "0x1808AD380")]
	public static RobbyOrderEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001649 RID: 5705 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001649")]
	[Address(RVA = "0x8AD3A0", Offset = "0x8AB9A0", VA = "0x1808AD3A0")]
	public static RobbyOrderEvent Create()
	{
		return null;
	}

	// Token: 0x0600164A RID: 5706 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600164A")]
	[Address(RVA = "0x8AD3C0", Offset = "0x8AB9C0", VA = "0x1808AD3C0")]
	public static RobbyOrderEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
