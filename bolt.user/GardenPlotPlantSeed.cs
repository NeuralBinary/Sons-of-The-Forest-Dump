using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200013B RID: 315
[Token(Token = "0x200013B")]
public class GardenPlotPlantSeed : Event
{
	// Token: 0x06000E7B RID: 3707 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E7B")]
	[Address(RVA = "0x86D550", Offset = "0x86BB50", VA = "0x18086D550")]
	public GardenPlotPlantSeed()
	{
	}

	// Token: 0x17000587 RID: 1415
	// (get) Token: 0x06000E7C RID: 3708 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000E7D RID: 3709 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000587")]
	public BoltEntity Target
	{
		[Token(Token = "0x6000E7C")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E7D")]
		[Address(RVA = "0x86D5B0", Offset = "0x86BBB0", VA = "0x18086D5B0")]
		set
		{
		}
	}

	// Token: 0x17000588 RID: 1416
	// (get) Token: 0x06000E7E RID: 3710 RVA: 0x000061B0 File Offset: 0x000043B0
	// (set) Token: 0x06000E7F RID: 3711 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000588")]
	public int SeedId
	{
		[Token(Token = "0x6000E7E")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000E7F")]
		[Address(RVA = "0x7D8500", Offset = "0x7D6B00", VA = "0x1807D8500")]
		set
		{
		}
	}

	// Token: 0x06000E80 RID: 3712 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E80")]
	[Address(RVA = "0x86D7C0", Offset = "0x86BDC0", VA = "0x18086D7C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000E81 RID: 3713 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E81")]
	[Address(RVA = "0x86D880", Offset = "0x86BE80", VA = "0x18086D880")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static GardenPlotPlantSeed Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000E82 RID: 3714 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E82")]
	[Address(RVA = "0x86D890", Offset = "0x86BE90", VA = "0x18086D890")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static GardenPlotPlantSeed Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000E83 RID: 3715 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E83")]
	[Address(RVA = "0x86DA90", Offset = "0x86C090", VA = "0x18086DA90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static GardenPlotPlantSeed Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E84 RID: 3716 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E84")]
	[Address(RVA = "0x86DBB0", Offset = "0x86C1B0", VA = "0x18086DBB0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static GardenPlotPlantSeed Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000E85 RID: 3717 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E85")]
	[Address(RVA = "0x86DBC0", Offset = "0x86C1C0", VA = "0x18086DBC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static GardenPlotPlantSeed Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E86 RID: 3718 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E86")]
	[Address(RVA = "0x86DBD0", Offset = "0x86C1D0", VA = "0x18086DBD0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static GardenPlotPlantSeed Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000E87 RID: 3719 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E87")]
	[Address(RVA = "0x86DBE0", Offset = "0x86C1E0", VA = "0x18086DBE0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static GardenPlotPlantSeed Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E88 RID: 3720 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E88")]
	[Address(RVA = "0x86DC00", Offset = "0x86C200", VA = "0x18086DC00")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static GardenPlotPlantSeed Raise()
	{
		return null;
	}

	// Token: 0x06000E89 RID: 3721 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E89")]
	[Address(RVA = "0x86DC20", Offset = "0x86C220", VA = "0x18086DC20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static GardenPlotPlantSeed Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E8A RID: 3722 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E8A")]
	[Address(RVA = "0x86D880", Offset = "0x86BE80", VA = "0x18086D880")]
	public static GardenPlotPlantSeed Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000E8B RID: 3723 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E8B")]
	[Address(RVA = "0x86DC30", Offset = "0x86C230", VA = "0x18086DC30")]
	public static GardenPlotPlantSeed Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000E8C RID: 3724 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E8C")]
	[Address(RVA = "0x86DE30", Offset = "0x86C430", VA = "0x18086DE30")]
	private static GardenPlotPlantSeed Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E8D RID: 3725 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E8D")]
	[Address(RVA = "0x86DBB0", Offset = "0x86C1B0", VA = "0x18086DBB0")]
	public static GardenPlotPlantSeed Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000E8E RID: 3726 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E8E")]
	[Address(RVA = "0x86DBC0", Offset = "0x86C1C0", VA = "0x18086DBC0")]
	public static GardenPlotPlantSeed Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E8F RID: 3727 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E8F")]
	[Address(RVA = "0x86DBD0", Offset = "0x86C1D0", VA = "0x18086DBD0")]
	public static GardenPlotPlantSeed Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000E90 RID: 3728 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E90")]
	[Address(RVA = "0x86DBE0", Offset = "0x86C1E0", VA = "0x18086DBE0")]
	public static GardenPlotPlantSeed Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000E91 RID: 3729 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E91")]
	[Address(RVA = "0x86DC00", Offset = "0x86C200", VA = "0x18086DC00")]
	public static GardenPlotPlantSeed Create()
	{
		return null;
	}

	// Token: 0x06000E92 RID: 3730 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E92")]
	[Address(RVA = "0x86DC20", Offset = "0x86C220", VA = "0x18086DC20")]
	public static GardenPlotPlantSeed Create(ReliabilityModes reliability)
	{
		return null;
	}
}
