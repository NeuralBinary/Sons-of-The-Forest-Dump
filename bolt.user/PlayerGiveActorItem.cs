using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200023D RID: 573
[Token(Token = "0x200023D")]
public class PlayerGiveActorItem : Event
{
	// Token: 0x06001A61 RID: 6753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A61")]
	[Address(RVA = "0x7D6B50", Offset = "0x7D5150", VA = "0x1807D6B50")]
	public PlayerGiveActorItem()
	{
	}

	// Token: 0x1700078C RID: 1932
	// (get) Token: 0x06001A62 RID: 6754 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001A63 RID: 6755 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700078C")]
	public BoltEntity Actor
	{
		[Token(Token = "0x6001A62")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A63")]
		[Address(RVA = "0x7D6BB0", Offset = "0x7D51B0", VA = "0x1807D6BB0")]
		set
		{
		}
	}

	// Token: 0x1700078D RID: 1933
	// (get) Token: 0x06001A64 RID: 6756 RVA: 0x000082B0 File Offset: 0x000064B0
	// (set) Token: 0x06001A65 RID: 6757 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700078D")]
	public int ItemId
	{
		[Token(Token = "0x6001A64")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001A65")]
		[Address(RVA = "0x7D6DC0", Offset = "0x7D53C0", VA = "0x1807D6DC0")]
		set
		{
		}
	}

	// Token: 0x1700078E RID: 1934
	// (get) Token: 0x06001A66 RID: 6758 RVA: 0x000082C8 File Offset: 0x000064C8
	// (set) Token: 0x06001A67 RID: 6759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700078E")]
	public int Amount
	{
		[Token(Token = "0x6001A66")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001A67")]
		[Address(RVA = "0x7D6E60", Offset = "0x7D5460", VA = "0x1807D6E60")]
		set
		{
		}
	}

	// Token: 0x1700078F RID: 1935
	// (get) Token: 0x06001A68 RID: 6760 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001A69 RID: 6761 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700078F")]
	public IProtocolToken ItemInstance
	{
		[Token(Token = "0x6001A68")]
		[Address(RVA = "0x7BDAB0", Offset = "0x7BC0B0", VA = "0x1807BDAB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A69")]
		[Address(RVA = "0x7D6F00", Offset = "0x7D5500", VA = "0x1807D6F00")]
		set
		{
		}
	}

	// Token: 0x06001A6A RID: 6762 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A6A")]
	[Address(RVA = "0x7D7050", Offset = "0x7D5650", VA = "0x1807D7050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001A6B RID: 6763 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A6B")]
	[Address(RVA = "0x7D72B0", Offset = "0x7D58B0", VA = "0x1807D72B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerGiveActorItem Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001A6C RID: 6764 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A6C")]
	[Address(RVA = "0x7D72C0", Offset = "0x7D58C0", VA = "0x1807D72C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerGiveActorItem Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001A6D RID: 6765 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A6D")]
	[Address(RVA = "0x7D74C0", Offset = "0x7D5AC0", VA = "0x1807D74C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static PlayerGiveActorItem Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A6E RID: 6766 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A6E")]
	[Address(RVA = "0x7D75E0", Offset = "0x7D5BE0", VA = "0x1807D75E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerGiveActorItem Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001A6F RID: 6767 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A6F")]
	[Address(RVA = "0x7D75F0", Offset = "0x7D5BF0", VA = "0x1807D75F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerGiveActorItem Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A70 RID: 6768 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A70")]
	[Address(RVA = "0x7D7600", Offset = "0x7D5C00", VA = "0x1807D7600")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerGiveActorItem Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001A71 RID: 6769 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A71")]
	[Address(RVA = "0x7D7610", Offset = "0x7D5C10", VA = "0x1807D7610")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerGiveActorItem Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A72 RID: 6770 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A72")]
	[Address(RVA = "0x7D7630", Offset = "0x7D5C30", VA = "0x1807D7630")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerGiveActorItem Raise()
	{
		return null;
	}

	// Token: 0x06001A73 RID: 6771 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A73")]
	[Address(RVA = "0x7D7650", Offset = "0x7D5C50", VA = "0x1807D7650")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerGiveActorItem Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A74 RID: 6772 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A74")]
	[Address(RVA = "0x7D72B0", Offset = "0x7D58B0", VA = "0x1807D72B0")]
	public static PlayerGiveActorItem Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001A75 RID: 6773 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A75")]
	[Address(RVA = "0x7D7660", Offset = "0x7D5C60", VA = "0x1807D7660")]
	public static PlayerGiveActorItem Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001A76 RID: 6774 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A76")]
	[Address(RVA = "0x7D7860", Offset = "0x7D5E60", VA = "0x1807D7860")]
	private static PlayerGiveActorItem Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A77 RID: 6775 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A77")]
	[Address(RVA = "0x7D75E0", Offset = "0x7D5BE0", VA = "0x1807D75E0")]
	public static PlayerGiveActorItem Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001A78 RID: 6776 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A78")]
	[Address(RVA = "0x7D75F0", Offset = "0x7D5BF0", VA = "0x1807D75F0")]
	public static PlayerGiveActorItem Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A79 RID: 6777 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A79")]
	[Address(RVA = "0x7D7600", Offset = "0x7D5C00", VA = "0x1807D7600")]
	public static PlayerGiveActorItem Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001A7A RID: 6778 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A7A")]
	[Address(RVA = "0x7D7610", Offset = "0x7D5C10", VA = "0x1807D7610")]
	public static PlayerGiveActorItem Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A7B RID: 6779 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A7B")]
	[Address(RVA = "0x7D7630", Offset = "0x7D5C30", VA = "0x1807D7630")]
	public static PlayerGiveActorItem Create()
	{
		return null;
	}

	// Token: 0x06001A7C RID: 6780 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A7C")]
	[Address(RVA = "0x7D7650", Offset = "0x7D5C50", VA = "0x1807D7650")]
	public static PlayerGiveActorItem Create(ReliabilityModes reliability)
	{
		return null;
	}
}
