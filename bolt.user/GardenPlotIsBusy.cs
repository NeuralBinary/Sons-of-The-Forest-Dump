using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200022B RID: 555
[Token(Token = "0x200022B")]
public class GardenPlotIsBusy : Event
{
	// Token: 0x0600198B RID: 6539 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600198B")]
	[Address(RVA = "0x8CA960", Offset = "0x8C8F60", VA = "0x1808CA960")]
	public GardenPlotIsBusy()
	{
	}

	// Token: 0x17000769 RID: 1897
	// (get) Token: 0x0600198C RID: 6540 RVA: 0x00008040 File Offset: 0x00006240
	// (set) Token: 0x0600198D RID: 6541 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000769")]
	public bool IsBusy
	{
		[Token(Token = "0x600198C")]
		[Address(RVA = "0x7B4A10", Offset = "0x7B3010", VA = "0x1807B4A10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600198D")]
		[Address(RVA = "0x7DB320", Offset = "0x7D9920", VA = "0x1807DB320")]
		set
		{
		}
	}

	// Token: 0x1700076A RID: 1898
	// (get) Token: 0x0600198E RID: 6542 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600198F RID: 6543 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700076A")]
	public BoltEntity Target
	{
		[Token(Token = "0x600198E")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600198F")]
		[Address(RVA = "0x8CA9C0", Offset = "0x8C8FC0", VA = "0x1808CA9C0")]
		set
		{
		}
	}

	// Token: 0x06001990 RID: 6544 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001990")]
	[Address(RVA = "0x8CABD0", Offset = "0x8C91D0", VA = "0x1808CABD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001991 RID: 6545 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001991")]
	[Address(RVA = "0x8CAC90", Offset = "0x8C9290", VA = "0x1808CAC90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static GardenPlotIsBusy Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001992 RID: 6546 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001992")]
	[Address(RVA = "0x8CACA0", Offset = "0x8C92A0", VA = "0x1808CACA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static GardenPlotIsBusy Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001993 RID: 6547 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001993")]
	[Address(RVA = "0x8CAEA0", Offset = "0x8C94A0", VA = "0x1808CAEA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static GardenPlotIsBusy Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001994 RID: 6548 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001994")]
	[Address(RVA = "0x8CAFC0", Offset = "0x8C95C0", VA = "0x1808CAFC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static GardenPlotIsBusy Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001995 RID: 6549 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001995")]
	[Address(RVA = "0x8CAFD0", Offset = "0x8C95D0", VA = "0x1808CAFD0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static GardenPlotIsBusy Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001996 RID: 6550 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001996")]
	[Address(RVA = "0x8CAFE0", Offset = "0x8C95E0", VA = "0x1808CAFE0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static GardenPlotIsBusy Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001997 RID: 6551 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001997")]
	[Address(RVA = "0x8CAFF0", Offset = "0x8C95F0", VA = "0x1808CAFF0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static GardenPlotIsBusy Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001998 RID: 6552 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001998")]
	[Address(RVA = "0x8CB010", Offset = "0x8C9610", VA = "0x1808CB010")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static GardenPlotIsBusy Raise()
	{
		return null;
	}

	// Token: 0x06001999 RID: 6553 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001999")]
	[Address(RVA = "0x8CB030", Offset = "0x8C9630", VA = "0x1808CB030")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static GardenPlotIsBusy Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600199A RID: 6554 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600199A")]
	[Address(RVA = "0x8CAC90", Offset = "0x8C9290", VA = "0x1808CAC90")]
	public static GardenPlotIsBusy Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600199B RID: 6555 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600199B")]
	[Address(RVA = "0x8CB040", Offset = "0x8C9640", VA = "0x1808CB040")]
	public static GardenPlotIsBusy Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600199C RID: 6556 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600199C")]
	[Address(RVA = "0x8CB240", Offset = "0x8C9840", VA = "0x1808CB240")]
	private static GardenPlotIsBusy Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600199D RID: 6557 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600199D")]
	[Address(RVA = "0x8CAFC0", Offset = "0x8C95C0", VA = "0x1808CAFC0")]
	public static GardenPlotIsBusy Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600199E RID: 6558 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600199E")]
	[Address(RVA = "0x8CAFD0", Offset = "0x8C95D0", VA = "0x1808CAFD0")]
	public static GardenPlotIsBusy Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600199F RID: 6559 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600199F")]
	[Address(RVA = "0x8CAFE0", Offset = "0x8C95E0", VA = "0x1808CAFE0")]
	public static GardenPlotIsBusy Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060019A0 RID: 6560 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019A0")]
	[Address(RVA = "0x8CAFF0", Offset = "0x8C95F0", VA = "0x1808CAFF0")]
	public static GardenPlotIsBusy Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060019A1 RID: 6561 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019A1")]
	[Address(RVA = "0x8CB010", Offset = "0x8C9610", VA = "0x1808CB010")]
	public static GardenPlotIsBusy Create()
	{
		return null;
	}

	// Token: 0x060019A2 RID: 6562 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019A2")]
	[Address(RVA = "0x8CB030", Offset = "0x8C9630", VA = "0x1808CB030")]
	public static GardenPlotIsBusy Create(ReliabilityModes reliability)
	{
		return null;
	}
}
