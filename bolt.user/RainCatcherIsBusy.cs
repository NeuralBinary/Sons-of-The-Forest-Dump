using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000288 RID: 648
[Token(Token = "0x2000288")]
public class RainCatcherIsBusy : Event
{
	// Token: 0x06001DAB RID: 7595 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DAB")]
	[Address(RVA = "0x7F10F0", Offset = "0x7EF6F0", VA = "0x1807F10F0")]
	public RainCatcherIsBusy()
	{
	}

	// Token: 0x17000813 RID: 2067
	// (get) Token: 0x06001DAC RID: 7596 RVA: 0x00008B08 File Offset: 0x00006D08
	// (set) Token: 0x06001DAD RID: 7597 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000813")]
	public bool IsBusy
	{
		[Token(Token = "0x6001DAC")]
		[Address(RVA = "0x7B4A10", Offset = "0x7B3010", VA = "0x1807B4A10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001DAD")]
		[Address(RVA = "0x7DB320", Offset = "0x7D9920", VA = "0x1807DB320")]
		set
		{
		}
	}

	// Token: 0x17000814 RID: 2068
	// (get) Token: 0x06001DAE RID: 7598 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001DAF RID: 7599 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000814")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001DAE")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001DAF")]
		[Address(RVA = "0x7F1150", Offset = "0x7EF750", VA = "0x1807F1150")]
		set
		{
		}
	}

	// Token: 0x06001DB0 RID: 7600 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DB0")]
	[Address(RVA = "0x7F1360", Offset = "0x7EF960", VA = "0x1807F1360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001DB1 RID: 7601 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DB1")]
	[Address(RVA = "0x7F1420", Offset = "0x7EFA20", VA = "0x1807F1420")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RainCatcherIsBusy Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001DB2 RID: 7602 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DB2")]
	[Address(RVA = "0x7F1430", Offset = "0x7EFA30", VA = "0x1807F1430")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RainCatcherIsBusy Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001DB3 RID: 7603 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DB3")]
	[Address(RVA = "0x7F1630", Offset = "0x7EFC30", VA = "0x1807F1630")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static RainCatcherIsBusy Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001DB4 RID: 7604 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DB4")]
	[Address(RVA = "0x7F1750", Offset = "0x7EFD50", VA = "0x1807F1750")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RainCatcherIsBusy Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001DB5 RID: 7605 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DB5")]
	[Address(RVA = "0x7F1760", Offset = "0x7EFD60", VA = "0x1807F1760")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RainCatcherIsBusy Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001DB6 RID: 7606 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DB6")]
	[Address(RVA = "0x7F1770", Offset = "0x7EFD70", VA = "0x1807F1770")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RainCatcherIsBusy Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001DB7 RID: 7607 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DB7")]
	[Address(RVA = "0x7F1780", Offset = "0x7EFD80", VA = "0x1807F1780")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RainCatcherIsBusy Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001DB8 RID: 7608 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DB8")]
	[Address(RVA = "0x7F17A0", Offset = "0x7EFDA0", VA = "0x1807F17A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RainCatcherIsBusy Raise()
	{
		return null;
	}

	// Token: 0x06001DB9 RID: 7609 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DB9")]
	[Address(RVA = "0x7F17C0", Offset = "0x7EFDC0", VA = "0x1807F17C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RainCatcherIsBusy Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001DBA RID: 7610 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DBA")]
	[Address(RVA = "0x7F1420", Offset = "0x7EFA20", VA = "0x1807F1420")]
	public static RainCatcherIsBusy Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001DBB RID: 7611 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DBB")]
	[Address(RVA = "0x7F17D0", Offset = "0x7EFDD0", VA = "0x1807F17D0")]
	public static RainCatcherIsBusy Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001DBC RID: 7612 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DBC")]
	[Address(RVA = "0x7F19D0", Offset = "0x7EFFD0", VA = "0x1807F19D0")]
	private static RainCatcherIsBusy Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001DBD RID: 7613 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DBD")]
	[Address(RVA = "0x7F1750", Offset = "0x7EFD50", VA = "0x1807F1750")]
	public static RainCatcherIsBusy Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001DBE RID: 7614 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DBE")]
	[Address(RVA = "0x7F1760", Offset = "0x7EFD60", VA = "0x1807F1760")]
	public static RainCatcherIsBusy Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001DBF RID: 7615 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DBF")]
	[Address(RVA = "0x7F1770", Offset = "0x7EFD70", VA = "0x1807F1770")]
	public static RainCatcherIsBusy Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001DC0 RID: 7616 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DC0")]
	[Address(RVA = "0x7F1780", Offset = "0x7EFD80", VA = "0x1807F1780")]
	public static RainCatcherIsBusy Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001DC1 RID: 7617 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DC1")]
	[Address(RVA = "0x7F17A0", Offset = "0x7EFDA0", VA = "0x1807F17A0")]
	public static RainCatcherIsBusy Create()
	{
		return null;
	}

	// Token: 0x06001DC2 RID: 7618 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DC2")]
	[Address(RVA = "0x7F17C0", Offset = "0x7EFDC0", VA = "0x1807F17C0")]
	public static RainCatcherIsBusy Create(ReliabilityModes reliability)
	{
		return null;
	}
}
