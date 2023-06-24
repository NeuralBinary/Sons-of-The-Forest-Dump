using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000156 RID: 342
[Token(Token = "0x2000156")]
public class AddItemToDoor : Event
{
	// Token: 0x06000FA7 RID: 4007 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FA7")]
	[Address(RVA = "0x876B60", Offset = "0x875160", VA = "0x180876B60")]
	public AddItemToDoor()
	{
	}

	// Token: 0x170005B1 RID: 1457
	// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x000063F0 File Offset: 0x000045F0
	// (set) Token: 0x06000FA9 RID: 4009 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005B1")]
	public int Door
	{
		[Token(Token = "0x6000FA8")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000FA9")]
		[Address(RVA = "0x7EB470", Offset = "0x7E9A70", VA = "0x1807EB470")]
		set
		{
		}
	}

	// Token: 0x170005B2 RID: 1458
	// (get) Token: 0x06000FAA RID: 4010 RVA: 0x00006408 File Offset: 0x00004608
	// (set) Token: 0x06000FAB RID: 4011 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005B2")]
	public int Slot
	{
		[Token(Token = "0x6000FAA")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000FAB")]
		[Address(RVA = "0x7D6DC0", Offset = "0x7D53C0", VA = "0x1807D6DC0")]
		set
		{
		}
	}

	// Token: 0x170005B3 RID: 1459
	// (get) Token: 0x06000FAC RID: 4012 RVA: 0x00006420 File Offset: 0x00004620
	// (set) Token: 0x06000FAD RID: 4013 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005B3")]
	public int Item
	{
		[Token(Token = "0x6000FAC")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000FAD")]
		[Address(RVA = "0x7D6E60", Offset = "0x7D5460", VA = "0x1807D6E60")]
		set
		{
		}
	}

	// Token: 0x06000FAE RID: 4014 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FAE")]
	[Address(RVA = "0x876BC0", Offset = "0x8751C0", VA = "0x180876BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000FAF RID: 4015 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FAF")]
	[Address(RVA = "0x876D50", Offset = "0x875350", VA = "0x180876D50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AddItemToDoor Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000FB0 RID: 4016 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FB0")]
	[Address(RVA = "0x876D60", Offset = "0x875360", VA = "0x180876D60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AddItemToDoor Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000FB1 RID: 4017 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FB1")]
	[Address(RVA = "0x876F60", Offset = "0x875560", VA = "0x180876F60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static AddItemToDoor Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000FB2 RID: 4018 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FB2")]
	[Address(RVA = "0x877080", Offset = "0x875680", VA = "0x180877080")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AddItemToDoor Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000FB3 RID: 4019 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FB3")]
	[Address(RVA = "0x877090", Offset = "0x875690", VA = "0x180877090")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AddItemToDoor Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000FB4 RID: 4020 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FB4")]
	[Address(RVA = "0x8770A0", Offset = "0x8756A0", VA = "0x1808770A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AddItemToDoor Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000FB5 RID: 4021 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FB5")]
	[Address(RVA = "0x8770B0", Offset = "0x8756B0", VA = "0x1808770B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AddItemToDoor Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000FB6 RID: 4022 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FB6")]
	[Address(RVA = "0x8770D0", Offset = "0x8756D0", VA = "0x1808770D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AddItemToDoor Raise()
	{
		return null;
	}

	// Token: 0x06000FB7 RID: 4023 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FB7")]
	[Address(RVA = "0x8770F0", Offset = "0x8756F0", VA = "0x1808770F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AddItemToDoor Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000FB8 RID: 4024 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FB8")]
	[Address(RVA = "0x876D50", Offset = "0x875350", VA = "0x180876D50")]
	public static AddItemToDoor Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000FB9 RID: 4025 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FB9")]
	[Address(RVA = "0x877100", Offset = "0x875700", VA = "0x180877100")]
	public static AddItemToDoor Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000FBA RID: 4026 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FBA")]
	[Address(RVA = "0x877300", Offset = "0x875900", VA = "0x180877300")]
	private static AddItemToDoor Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000FBB RID: 4027 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FBB")]
	[Address(RVA = "0x877080", Offset = "0x875680", VA = "0x180877080")]
	public static AddItemToDoor Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000FBC RID: 4028 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FBC")]
	[Address(RVA = "0x877090", Offset = "0x875690", VA = "0x180877090")]
	public static AddItemToDoor Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000FBD RID: 4029 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FBD")]
	[Address(RVA = "0x8770A0", Offset = "0x8756A0", VA = "0x1808770A0")]
	public static AddItemToDoor Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000FBE RID: 4030 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FBE")]
	[Address(RVA = "0x8770B0", Offset = "0x8756B0", VA = "0x1808770B0")]
	public static AddItemToDoor Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000FBF RID: 4031 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FBF")]
	[Address(RVA = "0x8770D0", Offset = "0x8756D0", VA = "0x1808770D0")]
	public static AddItemToDoor Create()
	{
		return null;
	}

	// Token: 0x06000FC0 RID: 4032 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FC0")]
	[Address(RVA = "0x8770F0", Offset = "0x8756F0", VA = "0x1808770F0")]
	public static AddItemToDoor Create(ReliabilityModes reliability)
	{
		return null;
	}
}
