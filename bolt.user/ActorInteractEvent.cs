using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000246 RID: 582
[Token(Token = "0x2000246")]
public class ActorInteractEvent : Event
{
	// Token: 0x06001AD7 RID: 6871 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AD7")]
	[Address(RVA = "0x7DB2C0", Offset = "0x7D98C0", VA = "0x1807DB2C0")]
	public ActorInteractEvent()
	{
	}

	// Token: 0x170007A3 RID: 1955
	// (get) Token: 0x06001AD8 RID: 6872 RVA: 0x00008400 File Offset: 0x00006600
	// (set) Token: 0x06001AD9 RID: 6873 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007A3")]
	public bool Active
	{
		[Token(Token = "0x6001AD8")]
		[Address(RVA = "0x7B4A10", Offset = "0x7B3010", VA = "0x1807B4A10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001AD9")]
		[Address(RVA = "0x7DB320", Offset = "0x7D9920", VA = "0x1807DB320")]
		set
		{
		}
	}

	// Token: 0x170007A4 RID: 1956
	// (get) Token: 0x06001ADA RID: 6874 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001ADB RID: 6875 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007A4")]
	public BoltEntity Actor
	{
		[Token(Token = "0x6001ADA")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001ADB")]
		[Address(RVA = "0x7DB450", Offset = "0x7D9A50", VA = "0x1807DB450")]
		set
		{
		}
	}

	// Token: 0x06001ADC RID: 6876 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ADC")]
	[Address(RVA = "0x7DB660", Offset = "0x7D9C60", VA = "0x1807DB660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001ADD RID: 6877 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ADD")]
	[Address(RVA = "0x7DB720", Offset = "0x7D9D20", VA = "0x1807DB720")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ActorInteractEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001ADE RID: 6878 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ADE")]
	[Address(RVA = "0x7DB730", Offset = "0x7D9D30", VA = "0x1807DB730")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ActorInteractEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001ADF RID: 6879 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001ADF")]
	[Address(RVA = "0x7DB930", Offset = "0x7D9F30", VA = "0x1807DB930")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static ActorInteractEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001AE0 RID: 6880 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AE0")]
	[Address(RVA = "0x7DBA50", Offset = "0x7DA050", VA = "0x1807DBA50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ActorInteractEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001AE1 RID: 6881 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AE1")]
	[Address(RVA = "0x7DBA60", Offset = "0x7DA060", VA = "0x1807DBA60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ActorInteractEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001AE2 RID: 6882 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AE2")]
	[Address(RVA = "0x7DBA70", Offset = "0x7DA070", VA = "0x1807DBA70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ActorInteractEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001AE3 RID: 6883 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AE3")]
	[Address(RVA = "0x7DBA80", Offset = "0x7DA080", VA = "0x1807DBA80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ActorInteractEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001AE4 RID: 6884 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AE4")]
	[Address(RVA = "0x7DBAA0", Offset = "0x7DA0A0", VA = "0x1807DBAA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ActorInteractEvent Raise()
	{
		return null;
	}

	// Token: 0x06001AE5 RID: 6885 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AE5")]
	[Address(RVA = "0x7DBAC0", Offset = "0x7DA0C0", VA = "0x1807DBAC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ActorInteractEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001AE6 RID: 6886 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AE6")]
	[Address(RVA = "0x7DB720", Offset = "0x7D9D20", VA = "0x1807DB720")]
	public static ActorInteractEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001AE7 RID: 6887 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AE7")]
	[Address(RVA = "0x7DBAD0", Offset = "0x7DA0D0", VA = "0x1807DBAD0")]
	public static ActorInteractEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001AE8 RID: 6888 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AE8")]
	[Address(RVA = "0x7DBCD0", Offset = "0x7DA2D0", VA = "0x1807DBCD0")]
	private static ActorInteractEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001AE9 RID: 6889 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AE9")]
	[Address(RVA = "0x7DBA50", Offset = "0x7DA050", VA = "0x1807DBA50")]
	public static ActorInteractEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001AEA RID: 6890 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AEA")]
	[Address(RVA = "0x7DBA60", Offset = "0x7DA060", VA = "0x1807DBA60")]
	public static ActorInteractEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001AEB RID: 6891 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AEB")]
	[Address(RVA = "0x7DBA70", Offset = "0x7DA070", VA = "0x1807DBA70")]
	public static ActorInteractEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001AEC RID: 6892 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AEC")]
	[Address(RVA = "0x7DBA80", Offset = "0x7DA080", VA = "0x1807DBA80")]
	public static ActorInteractEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001AED RID: 6893 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AED")]
	[Address(RVA = "0x7DBAA0", Offset = "0x7DA0A0", VA = "0x1807DBAA0")]
	public static ActorInteractEvent Create()
	{
		return null;
	}

	// Token: 0x06001AEE RID: 6894 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AEE")]
	[Address(RVA = "0x7DBAC0", Offset = "0x7DA0C0", VA = "0x1807DBAC0")]
	public static ActorInteractEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
