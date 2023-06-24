using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000240 RID: 576
[Token(Token = "0x2000240")]
public class ItemStorageAddItemEvent : Event
{
	// Token: 0x06001A87 RID: 6791 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A87")]
	[Address(RVA = "0x7D8290", Offset = "0x7D6890", VA = "0x1807D8290")]
	public ItemStorageAddItemEvent()
	{
	}

	// Token: 0x17000793 RID: 1939
	// (get) Token: 0x06001A88 RID: 6792 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001A89 RID: 6793 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000793")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001A88")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A89")]
		[Address(RVA = "0x7D82F0", Offset = "0x7D68F0", VA = "0x1807D82F0")]
		set
		{
		}
	}

	// Token: 0x17000794 RID: 1940
	// (get) Token: 0x06001A8A RID: 6794 RVA: 0x00008310 File Offset: 0x00006510
	// (set) Token: 0x06001A8B RID: 6795 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000794")]
	public int ItemId
	{
		[Token(Token = "0x6001A8A")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001A8B")]
		[Address(RVA = "0x7D8500", Offset = "0x7D6B00", VA = "0x1807D8500")]
		set
		{
		}
	}

	// Token: 0x17000795 RID: 1941
	// (get) Token: 0x06001A8C RID: 6796 RVA: 0x00008328 File Offset: 0x00006528
	// (set) Token: 0x06001A8D RID: 6797 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000795")]
	public int Count
	{
		[Token(Token = "0x6001A8C")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001A8D")]
		[Address(RVA = "0x7D85B0", Offset = "0x7D6BB0", VA = "0x1807D85B0")]
		set
		{
		}
	}

	// Token: 0x17000796 RID: 1942
	// (get) Token: 0x06001A8E RID: 6798 RVA: 0x00008340 File Offset: 0x00006540
	// (set) Token: 0x06001A8F RID: 6799 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000796")]
	public int StorageSlotIndex
	{
		[Token(Token = "0x6001A8E")]
		[Address(RVA = "0x7B6B40", Offset = "0x7B5140", VA = "0x1807B6B40")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001A8F")]
		[Address(RVA = "0x7D8660", Offset = "0x7D6C60", VA = "0x1807D8660")]
		set
		{
		}
	}

	// Token: 0x17000797 RID: 1943
	// (get) Token: 0x06001A90 RID: 6800 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001A91 RID: 6801 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000797")]
	public IProtocolToken ItemInstance
	{
		[Token(Token = "0x6001A90")]
		[Address(RVA = "0x7D8710", Offset = "0x7D6D10", VA = "0x1807D8710")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A91")]
		[Address(RVA = "0x7D87C0", Offset = "0x7D6DC0", VA = "0x1807D87C0")]
		set
		{
		}
	}

	// Token: 0x06001A92 RID: 6802 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A92")]
	[Address(RVA = "0x7D8910", Offset = "0x7D6F10", VA = "0x1807D8910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001A93 RID: 6803 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A93")]
	[Address(RVA = "0x7D8C10", Offset = "0x7D7210", VA = "0x1807D8C10")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemStorageAddItemEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001A94 RID: 6804 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A94")]
	[Address(RVA = "0x7D8C20", Offset = "0x7D7220", VA = "0x1807D8C20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemStorageAddItemEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001A95 RID: 6805 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A95")]
	[Address(RVA = "0x7D8E20", Offset = "0x7D7420", VA = "0x1807D8E20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static ItemStorageAddItemEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A96 RID: 6806 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A96")]
	[Address(RVA = "0x7D8F40", Offset = "0x7D7540", VA = "0x1807D8F40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemStorageAddItemEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001A97 RID: 6807 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A97")]
	[Address(RVA = "0x7D8F50", Offset = "0x7D7550", VA = "0x1807D8F50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemStorageAddItemEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A98 RID: 6808 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A98")]
	[Address(RVA = "0x7D8F60", Offset = "0x7D7560", VA = "0x1807D8F60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemStorageAddItemEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001A99 RID: 6809 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A99")]
	[Address(RVA = "0x7D8F70", Offset = "0x7D7570", VA = "0x1807D8F70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemStorageAddItemEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A9A RID: 6810 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A9A")]
	[Address(RVA = "0x7D8F90", Offset = "0x7D7590", VA = "0x1807D8F90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemStorageAddItemEvent Raise()
	{
		return null;
	}

	// Token: 0x06001A9B RID: 6811 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A9B")]
	[Address(RVA = "0x7D8FB0", Offset = "0x7D75B0", VA = "0x1807D8FB0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemStorageAddItemEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A9C RID: 6812 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A9C")]
	[Address(RVA = "0x7D8C10", Offset = "0x7D7210", VA = "0x1807D8C10")]
	public static ItemStorageAddItemEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001A9D RID: 6813 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A9D")]
	[Address(RVA = "0x7D8FC0", Offset = "0x7D75C0", VA = "0x1807D8FC0")]
	public static ItemStorageAddItemEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001A9E RID: 6814 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A9E")]
	[Address(RVA = "0x7D91C0", Offset = "0x7D77C0", VA = "0x1807D91C0")]
	private static ItemStorageAddItemEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A9F RID: 6815 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A9F")]
	[Address(RVA = "0x7D8F40", Offset = "0x7D7540", VA = "0x1807D8F40")]
	public static ItemStorageAddItemEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001AA0 RID: 6816 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AA0")]
	[Address(RVA = "0x7D8F50", Offset = "0x7D7550", VA = "0x1807D8F50")]
	public static ItemStorageAddItemEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001AA1 RID: 6817 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AA1")]
	[Address(RVA = "0x7D8F60", Offset = "0x7D7560", VA = "0x1807D8F60")]
	public static ItemStorageAddItemEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001AA2 RID: 6818 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AA2")]
	[Address(RVA = "0x7D8F70", Offset = "0x7D7570", VA = "0x1807D8F70")]
	public static ItemStorageAddItemEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001AA3 RID: 6819 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AA3")]
	[Address(RVA = "0x7D8F90", Offset = "0x7D7590", VA = "0x1807D8F90")]
	public static ItemStorageAddItemEvent Create()
	{
		return null;
	}

	// Token: 0x06001AA4 RID: 6820 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AA4")]
	[Address(RVA = "0x7D8FB0", Offset = "0x7D75B0", VA = "0x1807D8FB0")]
	public static ItemStorageAddItemEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
