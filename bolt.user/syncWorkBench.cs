using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001A4 RID: 420
[Token(Token = "0x20001A4")]
public class syncWorkBench : Event
{
	// Token: 0x0600132F RID: 4911 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600132F")]
	[Address(RVA = "0x894030", Offset = "0x892630", VA = "0x180894030")]
	public syncWorkBench()
	{
	}

	// Token: 0x1700063D RID: 1597
	// (get) Token: 0x06001330 RID: 4912 RVA: 0x00006C00 File Offset: 0x00004E00
	// (set) Token: 0x06001331 RID: 4913 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700063D")]
	public bool occupied1
	{
		[Token(Token = "0x6001330")]
		[Address(RVA = "0x7B4A10", Offset = "0x7B3010", VA = "0x1807B4A10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001331")]
		[Address(RVA = "0x7DB320", Offset = "0x7D9920", VA = "0x1807DB320")]
		set
		{
		}
	}

	// Token: 0x1700063E RID: 1598
	// (get) Token: 0x06001332 RID: 4914 RVA: 0x00006C18 File Offset: 0x00004E18
	// (set) Token: 0x06001333 RID: 4915 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700063E")]
	public bool occupied2
	{
		[Token(Token = "0x6001332")]
		[Address(RVA = "0x7B5490", Offset = "0x7B3A90", VA = "0x1807B5490")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001333")]
		[Address(RVA = "0x7E82E0", Offset = "0x7E68E0", VA = "0x1807E82E0")]
		set
		{
		}
	}

	// Token: 0x1700063F RID: 1599
	// (get) Token: 0x06001334 RID: 4916 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001335 RID: 4917 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700063F")]
	public BoltEntity target
	{
		[Token(Token = "0x6001334")]
		[Address(RVA = "0x80A6A0", Offset = "0x808CA0", VA = "0x18080A6A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001335")]
		[Address(RVA = "0x894090", Offset = "0x892690", VA = "0x180894090")]
		set
		{
		}
	}

	// Token: 0x17000640 RID: 1600
	// (get) Token: 0x06001336 RID: 4918 RVA: 0x00006C30 File Offset: 0x00004E30
	// (set) Token: 0x06001337 RID: 4919 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000640")]
	public bool resetOccupied1
	{
		[Token(Token = "0x6001336")]
		[Address(RVA = "0x7BB3B0", Offset = "0x7B99B0", VA = "0x1807BB3B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001337")]
		[Address(RVA = "0x7EE100", Offset = "0x7EC700", VA = "0x1807EE100")]
		set
		{
		}
	}

	// Token: 0x17000641 RID: 1601
	// (get) Token: 0x06001338 RID: 4920 RVA: 0x00006C48 File Offset: 0x00004E48
	// (set) Token: 0x06001339 RID: 4921 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000641")]
	public bool resetOccupied2
	{
		[Token(Token = "0x6001338")]
		[Address(RVA = "0x7BBF10", Offset = "0x7BA510", VA = "0x1807BBF10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001339")]
		[Address(RVA = "0x835BB0", Offset = "0x8341B0", VA = "0x180835BB0")]
		set
		{
		}
	}

	// Token: 0x0600133A RID: 4922 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600133A")]
	[Address(RVA = "0x8942B0", Offset = "0x8928B0", VA = "0x1808942B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0600133B RID: 4923 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600133B")]
	[Address(RVA = "0x894670", Offset = "0x892C70", VA = "0x180894670")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static syncWorkBench Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600133C RID: 4924 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600133C")]
	[Address(RVA = "0x894680", Offset = "0x892C80", VA = "0x180894680")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static syncWorkBench Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600133D RID: 4925 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600133D")]
	[Address(RVA = "0x894880", Offset = "0x892E80", VA = "0x180894880")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static syncWorkBench Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600133E RID: 4926 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600133E")]
	[Address(RVA = "0x8949A0", Offset = "0x892FA0", VA = "0x1808949A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static syncWorkBench Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600133F RID: 4927 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600133F")]
	[Address(RVA = "0x8949B0", Offset = "0x892FB0", VA = "0x1808949B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static syncWorkBench Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001340 RID: 4928 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001340")]
	[Address(RVA = "0x8949C0", Offset = "0x892FC0", VA = "0x1808949C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static syncWorkBench Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001341 RID: 4929 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001341")]
	[Address(RVA = "0x8949D0", Offset = "0x892FD0", VA = "0x1808949D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static syncWorkBench Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001342 RID: 4930 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001342")]
	[Address(RVA = "0x8949F0", Offset = "0x892FF0", VA = "0x1808949F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static syncWorkBench Raise()
	{
		return null;
	}

	// Token: 0x06001343 RID: 4931 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001343")]
	[Address(RVA = "0x894A10", Offset = "0x893010", VA = "0x180894A10")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static syncWorkBench Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001344 RID: 4932 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001344")]
	[Address(RVA = "0x894670", Offset = "0x892C70", VA = "0x180894670")]
	public static syncWorkBench Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001345 RID: 4933 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001345")]
	[Address(RVA = "0x894A20", Offset = "0x893020", VA = "0x180894A20")]
	public static syncWorkBench Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001346 RID: 4934 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001346")]
	[Address(RVA = "0x894C20", Offset = "0x893220", VA = "0x180894C20")]
	private static syncWorkBench Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001347 RID: 4935 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001347")]
	[Address(RVA = "0x8949A0", Offset = "0x892FA0", VA = "0x1808949A0")]
	public static syncWorkBench Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001348 RID: 4936 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001348")]
	[Address(RVA = "0x8949B0", Offset = "0x892FB0", VA = "0x1808949B0")]
	public static syncWorkBench Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001349 RID: 4937 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001349")]
	[Address(RVA = "0x8949C0", Offset = "0x892FC0", VA = "0x1808949C0")]
	public static syncWorkBench Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600134A RID: 4938 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600134A")]
	[Address(RVA = "0x8949D0", Offset = "0x892FD0", VA = "0x1808949D0")]
	public static syncWorkBench Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600134B RID: 4939 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600134B")]
	[Address(RVA = "0x8949F0", Offset = "0x892FF0", VA = "0x1808949F0")]
	public static syncWorkBench Create()
	{
		return null;
	}

	// Token: 0x0600134C RID: 4940 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600134C")]
	[Address(RVA = "0x894A10", Offset = "0x893010", VA = "0x180894A10")]
	public static syncWorkBench Create(ReliabilityModes reliability)
	{
		return null;
	}
}
