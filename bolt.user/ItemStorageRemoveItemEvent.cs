using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000243 RID: 579
[Token(Token = "0x2000243")]
public class ItemStorageRemoveItemEvent : Event
{
	// Token: 0x06001AAF RID: 6831 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AAF")]
	[Address(RVA = "0x7D9CB0", Offset = "0x7D82B0", VA = "0x1807D9CB0")]
	public ItemStorageRemoveItemEvent()
	{
	}

	// Token: 0x1700079B RID: 1947
	// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001AB1 RID: 6833 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700079B")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001AB0")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001AB1")]
		[Address(RVA = "0x7D9D10", Offset = "0x7D8310", VA = "0x1807D9D10")]
		set
		{
		}
	}

	// Token: 0x1700079C RID: 1948
	// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x00008388 File Offset: 0x00006588
	// (set) Token: 0x06001AB3 RID: 6835 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700079C")]
	public int ItemId
	{
		[Token(Token = "0x6001AB2")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001AB3")]
		[Address(RVA = "0x7D8500", Offset = "0x7D6B00", VA = "0x1807D8500")]
		set
		{
		}
	}

	// Token: 0x1700079D RID: 1949
	// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x000083A0 File Offset: 0x000065A0
	// (set) Token: 0x06001AB5 RID: 6837 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700079D")]
	public int Count
	{
		[Token(Token = "0x6001AB4")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001AB5")]
		[Address(RVA = "0x7D85B0", Offset = "0x7D6BB0", VA = "0x1807D85B0")]
		set
		{
		}
	}

	// Token: 0x1700079E RID: 1950
	// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x000083B8 File Offset: 0x000065B8
	// (set) Token: 0x06001AB7 RID: 6839 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700079E")]
	public int StorageSlotIndex
	{
		[Token(Token = "0x6001AB6")]
		[Address(RVA = "0x7B6B40", Offset = "0x7B5140", VA = "0x1807B6B40")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001AB7")]
		[Address(RVA = "0x7D8660", Offset = "0x7D6C60", VA = "0x1807D8660")]
		set
		{
		}
	}

	// Token: 0x1700079F RID: 1951
	// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001AB9 RID: 6841 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700079F")]
	public IProtocolToken ItemInstance
	{
		[Token(Token = "0x6001AB8")]
		[Address(RVA = "0x7D8710", Offset = "0x7D6D10", VA = "0x1807D8710")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001AB9")]
		[Address(RVA = "0x7D87C0", Offset = "0x7D6DC0", VA = "0x1807D87C0")]
		set
		{
		}
	}

	// Token: 0x06001ABA RID: 6842 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ABA")]
	[Address(RVA = "0x7D9F20", Offset = "0x7D8520", VA = "0x1807D9F20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001ABB RID: 6843 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ABB")]
	[Address(RVA = "0x7DA220", Offset = "0x7D8820", VA = "0x1807DA220")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemStorageRemoveItemEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001ABC RID: 6844 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ABC")]
	[Address(RVA = "0x7DA230", Offset = "0x7D8830", VA = "0x1807DA230")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemStorageRemoveItemEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001ABD RID: 6845 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ABD")]
	[Address(RVA = "0x7DA430", Offset = "0x7D8A30", VA = "0x1807DA430")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static ItemStorageRemoveItemEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001ABE RID: 6846 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ABE")]
	[Address(RVA = "0x7DA550", Offset = "0x7D8B50", VA = "0x1807DA550")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemStorageRemoveItemEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001ABF RID: 6847 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ABF")]
	[Address(RVA = "0x7DA560", Offset = "0x7D8B60", VA = "0x1807DA560")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemStorageRemoveItemEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001AC0 RID: 6848 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AC0")]
	[Address(RVA = "0x7DA570", Offset = "0x7D8B70", VA = "0x1807DA570")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemStorageRemoveItemEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001AC1 RID: 6849 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AC1")]
	[Address(RVA = "0x7DA580", Offset = "0x7D8B80", VA = "0x1807DA580")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemStorageRemoveItemEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001AC2 RID: 6850 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AC2")]
	[Address(RVA = "0x7DA5A0", Offset = "0x7D8BA0", VA = "0x1807DA5A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemStorageRemoveItemEvent Raise()
	{
		return null;
	}

	// Token: 0x06001AC3 RID: 6851 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AC3")]
	[Address(RVA = "0x7DA5C0", Offset = "0x7D8BC0", VA = "0x1807DA5C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ItemStorageRemoveItemEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001AC4 RID: 6852 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AC4")]
	[Address(RVA = "0x7DA220", Offset = "0x7D8820", VA = "0x1807DA220")]
	public static ItemStorageRemoveItemEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001AC5 RID: 6853 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AC5")]
	[Address(RVA = "0x7DA5D0", Offset = "0x7D8BD0", VA = "0x1807DA5D0")]
	public static ItemStorageRemoveItemEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001AC6 RID: 6854 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AC6")]
	[Address(RVA = "0x7DA7D0", Offset = "0x7D8DD0", VA = "0x1807DA7D0")]
	private static ItemStorageRemoveItemEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001AC7 RID: 6855 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AC7")]
	[Address(RVA = "0x7DA550", Offset = "0x7D8B50", VA = "0x1807DA550")]
	public static ItemStorageRemoveItemEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001AC8 RID: 6856 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AC8")]
	[Address(RVA = "0x7DA560", Offset = "0x7D8B60", VA = "0x1807DA560")]
	public static ItemStorageRemoveItemEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001AC9 RID: 6857 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AC9")]
	[Address(RVA = "0x7DA570", Offset = "0x7D8B70", VA = "0x1807DA570")]
	public static ItemStorageRemoveItemEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001ACA RID: 6858 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ACA")]
	[Address(RVA = "0x7DA580", Offset = "0x7D8B80", VA = "0x1807DA580")]
	public static ItemStorageRemoveItemEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001ACB RID: 6859 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ACB")]
	[Address(RVA = "0x7DA5A0", Offset = "0x7D8BA0", VA = "0x1807DA5A0")]
	public static ItemStorageRemoveItemEvent Create()
	{
		return null;
	}

	// Token: 0x06001ACC RID: 6860 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ACC")]
	[Address(RVA = "0x7DA5C0", Offset = "0x7D8BC0", VA = "0x1807DA5C0")]
	public static ItemStorageRemoveItemEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
