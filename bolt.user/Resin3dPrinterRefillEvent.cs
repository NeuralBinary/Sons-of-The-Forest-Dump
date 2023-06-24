using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000270 RID: 624
[Token(Token = "0x2000270")]
public class Resin3dPrinterRefillEvent : Event
{
	// Token: 0x06001CB1 RID: 7345 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CB1")]
	[Address(RVA = "0x7EA2B0", Offset = "0x7E88B0", VA = "0x1807EA2B0")]
	public Resin3dPrinterRefillEvent()
	{
	}

	// Token: 0x170007EA RID: 2026
	// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007EA")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001CB2")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001CB3")]
		[Address(RVA = "0x7EA310", Offset = "0x7E8910", VA = "0x1807EA310")]
		set
		{
		}
	}

	// Token: 0x170007EB RID: 2027
	// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x00008850 File Offset: 0x00006A50
	// (set) Token: 0x06001CB5 RID: 7349 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007EB")]
	public int Amount
	{
		[Token(Token = "0x6001CB4")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001CB5")]
		[Address(RVA = "0x7D8500", Offset = "0x7D6B00", VA = "0x1807D8500")]
		set
		{
		}
	}

	// Token: 0x06001CB6 RID: 7350 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CB6")]
	[Address(RVA = "0x7EA520", Offset = "0x7E8B20", VA = "0x1807EA520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001CB7 RID: 7351 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CB7")]
	[Address(RVA = "0x7EA5E0", Offset = "0x7E8BE0", VA = "0x1807EA5E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterRefillEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001CB8 RID: 7352 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CB8")]
	[Address(RVA = "0x7EA5F0", Offset = "0x7E8BF0", VA = "0x1807EA5F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterRefillEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001CB9 RID: 7353 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CB9")]
	[Address(RVA = "0x7EA7F0", Offset = "0x7E8DF0", VA = "0x1807EA7F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static Resin3dPrinterRefillEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001CBA RID: 7354 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CBA")]
	[Address(RVA = "0x7EA980", Offset = "0x7E8F80", VA = "0x1807EA980")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterRefillEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001CBB RID: 7355 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CBB")]
	[Address(RVA = "0x7EA990", Offset = "0x7E8F90", VA = "0x1807EA990")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterRefillEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001CBC RID: 7356 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CBC")]
	[Address(RVA = "0x7EA9A0", Offset = "0x7E8FA0", VA = "0x1807EA9A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterRefillEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001CBD RID: 7357 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CBD")]
	[Address(RVA = "0x7EA9B0", Offset = "0x7E8FB0", VA = "0x1807EA9B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterRefillEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001CBE RID: 7358 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CBE")]
	[Address(RVA = "0x7EA9D0", Offset = "0x7E8FD0", VA = "0x1807EA9D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterRefillEvent Raise()
	{
		return null;
	}

	// Token: 0x06001CBF RID: 7359 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CBF")]
	[Address(RVA = "0x7EA9F0", Offset = "0x7E8FF0", VA = "0x1807EA9F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterRefillEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001CC0 RID: 7360 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CC0")]
	[Address(RVA = "0x7EA5E0", Offset = "0x7E8BE0", VA = "0x1807EA5E0")]
	public static Resin3dPrinterRefillEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001CC1 RID: 7361 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CC1")]
	[Address(RVA = "0x7EAA00", Offset = "0x7E9000", VA = "0x1807EAA00")]
	public static Resin3dPrinterRefillEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001CC2 RID: 7362 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CC2")]
	[Address(RVA = "0x7EAC00", Offset = "0x7E9200", VA = "0x1807EAC00")]
	private static Resin3dPrinterRefillEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001CC3 RID: 7363 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CC3")]
	[Address(RVA = "0x7EA980", Offset = "0x7E8F80", VA = "0x1807EA980")]
	public static Resin3dPrinterRefillEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001CC4 RID: 7364 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CC4")]
	[Address(RVA = "0x7EA990", Offset = "0x7E8F90", VA = "0x1807EA990")]
	public static Resin3dPrinterRefillEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001CC5 RID: 7365 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CC5")]
	[Address(RVA = "0x7EA9A0", Offset = "0x7E8FA0", VA = "0x1807EA9A0")]
	public static Resin3dPrinterRefillEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001CC6 RID: 7366 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CC6")]
	[Address(RVA = "0x7EA9B0", Offset = "0x7E8FB0", VA = "0x1807EA9B0")]
	public static Resin3dPrinterRefillEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001CC7 RID: 7367 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CC7")]
	[Address(RVA = "0x7EA9D0", Offset = "0x7E8FD0", VA = "0x1807EA9D0")]
	public static Resin3dPrinterRefillEvent Create()
	{
		return null;
	}

	// Token: 0x06001CC8 RID: 7368 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CC8")]
	[Address(RVA = "0x7EA9F0", Offset = "0x7E8FF0", VA = "0x1807EA9F0")]
	public static Resin3dPrinterRefillEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
