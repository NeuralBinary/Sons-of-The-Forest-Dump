using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200021F RID: 543
[Token(Token = "0x200021F")]
public class DwGateCloseEvent : Event
{
	// Token: 0x060018F7 RID: 6391 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018F7")]
	[Address(RVA = "0x8C5670", Offset = "0x8C3C70", VA = "0x1808C5670")]
	public DwGateCloseEvent()
	{
	}

	// Token: 0x1700074F RID: 1871
	// (get) Token: 0x060018F8 RID: 6392 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060018F9 RID: 6393 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700074F")]
	public BoltEntity Target
	{
		[Token(Token = "0x60018F8")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60018F9")]
		[Address(RVA = "0x8C56D0", Offset = "0x8C3CD0", VA = "0x1808C56D0")]
		set
		{
		}
	}

	// Token: 0x17000750 RID: 1872
	// (get) Token: 0x060018FA RID: 6394 RVA: 0x00007E90 File Offset: 0x00006090
	// (set) Token: 0x060018FB RID: 6395 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000750")]
	public int TargetInstanceId
	{
		[Token(Token = "0x60018FA")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60018FB")]
		[Address(RVA = "0x7D6DC0", Offset = "0x7D53C0", VA = "0x1807D6DC0")]
		set
		{
		}
	}

	// Token: 0x060018FC RID: 6396 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018FC")]
	[Address(RVA = "0x8C58E0", Offset = "0x8C3EE0", VA = "0x1808C58E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060018FD RID: 6397 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018FD")]
	[Address(RVA = "0x8C5A20", Offset = "0x8C4020", VA = "0x1808C5A20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DwGateCloseEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060018FE RID: 6398 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018FE")]
	[Address(RVA = "0x8C5A30", Offset = "0x8C4030", VA = "0x1808C5A30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DwGateCloseEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060018FF RID: 6399 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018FF")]
	[Address(RVA = "0x8C5C30", Offset = "0x8C4230", VA = "0x1808C5C30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static DwGateCloseEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001900 RID: 6400 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001900")]
	[Address(RVA = "0x8C5D50", Offset = "0x8C4350", VA = "0x1808C5D50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DwGateCloseEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001901 RID: 6401 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001901")]
	[Address(RVA = "0x8C5D60", Offset = "0x8C4360", VA = "0x1808C5D60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DwGateCloseEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001902 RID: 6402 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001902")]
	[Address(RVA = "0x8C5D70", Offset = "0x8C4370", VA = "0x1808C5D70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DwGateCloseEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001903 RID: 6403 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001903")]
	[Address(RVA = "0x8C5D80", Offset = "0x8C4380", VA = "0x1808C5D80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DwGateCloseEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001904 RID: 6404 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001904")]
	[Address(RVA = "0x8C5DA0", Offset = "0x8C43A0", VA = "0x1808C5DA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DwGateCloseEvent Raise()
	{
		return null;
	}

	// Token: 0x06001905 RID: 6405 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001905")]
	[Address(RVA = "0x8C5DC0", Offset = "0x8C43C0", VA = "0x1808C5DC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DwGateCloseEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001906 RID: 6406 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001906")]
	[Address(RVA = "0x8C5A20", Offset = "0x8C4020", VA = "0x1808C5A20")]
	public static DwGateCloseEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001907 RID: 6407 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001907")]
	[Address(RVA = "0x8C5DD0", Offset = "0x8C43D0", VA = "0x1808C5DD0")]
	public static DwGateCloseEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001908 RID: 6408 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001908")]
	[Address(RVA = "0x8C5FD0", Offset = "0x8C45D0", VA = "0x1808C5FD0")]
	private static DwGateCloseEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001909 RID: 6409 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001909")]
	[Address(RVA = "0x8C5D50", Offset = "0x8C4350", VA = "0x1808C5D50")]
	public static DwGateCloseEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600190A RID: 6410 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600190A")]
	[Address(RVA = "0x8C5D60", Offset = "0x8C4360", VA = "0x1808C5D60")]
	public static DwGateCloseEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600190B RID: 6411 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600190B")]
	[Address(RVA = "0x8C5D70", Offset = "0x8C4370", VA = "0x1808C5D70")]
	public static DwGateCloseEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600190C RID: 6412 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600190C")]
	[Address(RVA = "0x8C5D80", Offset = "0x8C4380", VA = "0x1808C5D80")]
	public static DwGateCloseEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600190D RID: 6413 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600190D")]
	[Address(RVA = "0x8C5DA0", Offset = "0x8C43A0", VA = "0x1808C5DA0")]
	public static DwGateCloseEvent Create()
	{
		return null;
	}

	// Token: 0x0600190E RID: 6414 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600190E")]
	[Address(RVA = "0x8C5DC0", Offset = "0x8C43C0", VA = "0x1808C5DC0")]
	public static DwGateCloseEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
