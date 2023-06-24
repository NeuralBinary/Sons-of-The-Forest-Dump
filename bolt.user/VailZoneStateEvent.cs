using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000219 RID: 537
[Token(Token = "0x2000219")]
public class VailZoneStateEvent : Event
{
	// Token: 0x060018AF RID: 6319 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018AF")]
	[Address(RVA = "0x8C31A0", Offset = "0x8C17A0", VA = "0x1808C31A0")]
	public VailZoneStateEvent()
	{
	}

	// Token: 0x17000743 RID: 1859
	// (get) Token: 0x060018B0 RID: 6320 RVA: 0x00007DB8 File Offset: 0x00005FB8
	// (set) Token: 0x060018B1 RID: 6321 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000743")]
	public int VillageId
	{
		[Token(Token = "0x60018B0")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60018B1")]
		[Address(RVA = "0x7EB470", Offset = "0x7E9A70", VA = "0x1807EB470")]
		set
		{
		}
	}

	// Token: 0x17000744 RID: 1860
	// (get) Token: 0x060018B2 RID: 6322 RVA: 0x00007DD0 File Offset: 0x00005FD0
	// (set) Token: 0x060018B3 RID: 6323 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000744")]
	public int ObjectId
	{
		[Token(Token = "0x60018B2")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60018B3")]
		[Address(RVA = "0x8C3200", Offset = "0x8C1800", VA = "0x1808C3200")]
		set
		{
		}
	}

	// Token: 0x17000745 RID: 1861
	// (get) Token: 0x060018B4 RID: 6324 RVA: 0x00007DE8 File Offset: 0x00005FE8
	// (set) Token: 0x060018B5 RID: 6325 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000745")]
	public int ActionType
	{
		[Token(Token = "0x60018B4")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60018B5")]
		[Address(RVA = "0x83CBD0", Offset = "0x83B1D0", VA = "0x18083CBD0")]
		set
		{
		}
	}

	// Token: 0x17000746 RID: 1862
	// (get) Token: 0x060018B6 RID: 6326 RVA: 0x00007E00 File Offset: 0x00006000
	// (set) Token: 0x060018B7 RID: 6327 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000746")]
	public int Flag
	{
		[Token(Token = "0x60018B6")]
		[Address(RVA = "0x7B6B40", Offset = "0x7B5140", VA = "0x1807B6B40")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60018B7")]
		[Address(RVA = "0x7E1CC0", Offset = "0x7E02C0", VA = "0x1807E1CC0")]
		set
		{
		}
	}

	// Token: 0x060018B8 RID: 6328 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018B8")]
	[Address(RVA = "0x8C32B0", Offset = "0x8C18B0", VA = "0x1808C32B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060018B9 RID: 6329 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018B9")]
	[Address(RVA = "0x8C35B0", Offset = "0x8C1BB0", VA = "0x1808C35B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailZoneStateEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060018BA RID: 6330 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018BA")]
	[Address(RVA = "0x8C35C0", Offset = "0x8C1BC0", VA = "0x1808C35C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailZoneStateEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060018BB RID: 6331 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018BB")]
	[Address(RVA = "0x8C37C0", Offset = "0x8C1DC0", VA = "0x1808C37C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static VailZoneStateEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060018BC RID: 6332 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018BC")]
	[Address(RVA = "0x8C38E0", Offset = "0x8C1EE0", VA = "0x1808C38E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailZoneStateEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060018BD RID: 6333 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018BD")]
	[Address(RVA = "0x8C38F0", Offset = "0x8C1EF0", VA = "0x1808C38F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailZoneStateEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060018BE RID: 6334 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018BE")]
	[Address(RVA = "0x8C3900", Offset = "0x8C1F00", VA = "0x1808C3900")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailZoneStateEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060018BF RID: 6335 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018BF")]
	[Address(RVA = "0x8C3910", Offset = "0x8C1F10", VA = "0x1808C3910")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailZoneStateEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060018C0 RID: 6336 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018C0")]
	[Address(RVA = "0x8C3930", Offset = "0x8C1F30", VA = "0x1808C3930")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailZoneStateEvent Raise()
	{
		return null;
	}

	// Token: 0x060018C1 RID: 6337 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018C1")]
	[Address(RVA = "0x8C3950", Offset = "0x8C1F50", VA = "0x1808C3950")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailZoneStateEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060018C2 RID: 6338 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018C2")]
	[Address(RVA = "0x8C35B0", Offset = "0x8C1BB0", VA = "0x1808C35B0")]
	public static VailZoneStateEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060018C3 RID: 6339 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018C3")]
	[Address(RVA = "0x8C3960", Offset = "0x8C1F60", VA = "0x1808C3960")]
	public static VailZoneStateEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060018C4 RID: 6340 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018C4")]
	[Address(RVA = "0x8C3B60", Offset = "0x8C2160", VA = "0x1808C3B60")]
	private static VailZoneStateEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060018C5 RID: 6341 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018C5")]
	[Address(RVA = "0x8C38E0", Offset = "0x8C1EE0", VA = "0x1808C38E0")]
	public static VailZoneStateEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060018C6 RID: 6342 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018C6")]
	[Address(RVA = "0x8C38F0", Offset = "0x8C1EF0", VA = "0x1808C38F0")]
	public static VailZoneStateEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060018C7 RID: 6343 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018C7")]
	[Address(RVA = "0x8C3900", Offset = "0x8C1F00", VA = "0x1808C3900")]
	public static VailZoneStateEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060018C8 RID: 6344 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018C8")]
	[Address(RVA = "0x8C3910", Offset = "0x8C1F10", VA = "0x1808C3910")]
	public static VailZoneStateEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060018C9 RID: 6345 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018C9")]
	[Address(RVA = "0x8C3930", Offset = "0x8C1F30", VA = "0x1808C3930")]
	public static VailZoneStateEvent Create()
	{
		return null;
	}

	// Token: 0x060018CA RID: 6346 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018CA")]
	[Address(RVA = "0x8C3950", Offset = "0x8C1F50", VA = "0x1808C3950")]
	public static VailZoneStateEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
