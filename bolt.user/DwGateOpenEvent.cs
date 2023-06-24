using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200021C RID: 540
[Token(Token = "0x200021C")]
public class DwGateOpenEvent : Event
{
	// Token: 0x060018D5 RID: 6357 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018D5")]
	[Address(RVA = "0x8C4560", Offset = "0x8C2B60", VA = "0x1808C4560")]
	public DwGateOpenEvent()
	{
	}

	// Token: 0x1700074A RID: 1866
	// (get) Token: 0x060018D6 RID: 6358 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060018D7 RID: 6359 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700074A")]
	public BoltEntity Target
	{
		[Token(Token = "0x60018D6")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60018D7")]
		[Address(RVA = "0x8C45C0", Offset = "0x8C2BC0", VA = "0x1808C45C0")]
		set
		{
		}
	}

	// Token: 0x1700074B RID: 1867
	// (get) Token: 0x060018D8 RID: 6360 RVA: 0x00007E48 File Offset: 0x00006048
	// (set) Token: 0x060018D9 RID: 6361 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700074B")]
	public int TargetInstanceId
	{
		[Token(Token = "0x60018D8")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60018D9")]
		[Address(RVA = "0x7D6DC0", Offset = "0x7D53C0", VA = "0x1807D6DC0")]
		set
		{
		}
	}

	// Token: 0x060018DA RID: 6362 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018DA")]
	[Address(RVA = "0x8C47D0", Offset = "0x8C2DD0", VA = "0x1808C47D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060018DB RID: 6363 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018DB")]
	[Address(RVA = "0x8C4910", Offset = "0x8C2F10", VA = "0x1808C4910")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DwGateOpenEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060018DC RID: 6364 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018DC")]
	[Address(RVA = "0x8C4920", Offset = "0x8C2F20", VA = "0x1808C4920")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DwGateOpenEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060018DD RID: 6365 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018DD")]
	[Address(RVA = "0x8C4B20", Offset = "0x8C3120", VA = "0x1808C4B20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static DwGateOpenEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060018DE RID: 6366 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018DE")]
	[Address(RVA = "0x8C4C40", Offset = "0x8C3240", VA = "0x1808C4C40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DwGateOpenEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060018DF RID: 6367 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018DF")]
	[Address(RVA = "0x8C4C50", Offset = "0x8C3250", VA = "0x1808C4C50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DwGateOpenEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060018E0 RID: 6368 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018E0")]
	[Address(RVA = "0x8C4C60", Offset = "0x8C3260", VA = "0x1808C4C60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DwGateOpenEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060018E1 RID: 6369 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018E1")]
	[Address(RVA = "0x8C4C70", Offset = "0x8C3270", VA = "0x1808C4C70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DwGateOpenEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060018E2 RID: 6370 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018E2")]
	[Address(RVA = "0x8C4C90", Offset = "0x8C3290", VA = "0x1808C4C90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DwGateOpenEvent Raise()
	{
		return null;
	}

	// Token: 0x060018E3 RID: 6371 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018E3")]
	[Address(RVA = "0x8C4CB0", Offset = "0x8C32B0", VA = "0x1808C4CB0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DwGateOpenEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060018E4 RID: 6372 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018E4")]
	[Address(RVA = "0x8C4910", Offset = "0x8C2F10", VA = "0x1808C4910")]
	public static DwGateOpenEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060018E5 RID: 6373 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018E5")]
	[Address(RVA = "0x8C4CC0", Offset = "0x8C32C0", VA = "0x1808C4CC0")]
	public static DwGateOpenEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060018E6 RID: 6374 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018E6")]
	[Address(RVA = "0x8C4EC0", Offset = "0x8C34C0", VA = "0x1808C4EC0")]
	private static DwGateOpenEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060018E7 RID: 6375 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018E7")]
	[Address(RVA = "0x8C4C40", Offset = "0x8C3240", VA = "0x1808C4C40")]
	public static DwGateOpenEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060018E8 RID: 6376 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018E8")]
	[Address(RVA = "0x8C4C50", Offset = "0x8C3250", VA = "0x1808C4C50")]
	public static DwGateOpenEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060018E9 RID: 6377 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018E9")]
	[Address(RVA = "0x8C4C60", Offset = "0x8C3260", VA = "0x1808C4C60")]
	public static DwGateOpenEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060018EA RID: 6378 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018EA")]
	[Address(RVA = "0x8C4C70", Offset = "0x8C3270", VA = "0x1808C4C70")]
	public static DwGateOpenEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060018EB RID: 6379 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018EB")]
	[Address(RVA = "0x8C4C90", Offset = "0x8C3290", VA = "0x1808C4C90")]
	public static DwGateOpenEvent Create()
	{
		return null;
	}

	// Token: 0x060018EC RID: 6380 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018EC")]
	[Address(RVA = "0x8C4CB0", Offset = "0x8C32B0", VA = "0x1808C4CB0")]
	public static DwGateOpenEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
