using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000174 RID: 372
[Token(Token = "0x2000174")]
public class DisablePickup : Event
{
	// Token: 0x060010FB RID: 4347 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010FB")]
	[Address(RVA = "0x881590", Offset = "0x87FB90", VA = "0x180881590")]
	public DisablePickup()
	{
	}

	// Token: 0x170005E3 RID: 1507
	// (get) Token: 0x060010FC RID: 4348 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060010FD RID: 4349 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005E3")]
	public BoltEntity Entity
	{
		[Token(Token = "0x60010FC")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60010FD")]
		[Address(RVA = "0x8815F0", Offset = "0x87FBF0", VA = "0x1808815F0")]
		set
		{
		}
	}

	// Token: 0x170005E4 RID: 1508
	// (get) Token: 0x060010FE RID: 4350 RVA: 0x000066A8 File Offset: 0x000048A8
	// (set) Token: 0x060010FF RID: 4351 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005E4")]
	public int Num
	{
		[Token(Token = "0x60010FE")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60010FF")]
		[Address(RVA = "0x7E93F0", Offset = "0x7E79F0", VA = "0x1807E93F0")]
		set
		{
		}
	}

	// Token: 0x06001100 RID: 4352 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001100")]
	[Address(RVA = "0x881800", Offset = "0x87FE00", VA = "0x180881800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001101 RID: 4353 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001101")]
	[Address(RVA = "0x8818C0", Offset = "0x87FEC0", VA = "0x1808818C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DisablePickup Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001102 RID: 4354 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001102")]
	[Address(RVA = "0x8818D0", Offset = "0x87FED0", VA = "0x1808818D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DisablePickup Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001103 RID: 4355 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001103")]
	[Address(RVA = "0x881AD0", Offset = "0x8800D0", VA = "0x180881AD0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static DisablePickup Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001104 RID: 4356 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001104")]
	[Address(RVA = "0x881BF0", Offset = "0x8801F0", VA = "0x180881BF0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DisablePickup Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001105 RID: 4357 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001105")]
	[Address(RVA = "0x881C00", Offset = "0x880200", VA = "0x180881C00")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DisablePickup Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001106 RID: 4358 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001106")]
	[Address(RVA = "0x881C10", Offset = "0x880210", VA = "0x180881C10")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DisablePickup Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001107 RID: 4359 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001107")]
	[Address(RVA = "0x881C20", Offset = "0x880220", VA = "0x180881C20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DisablePickup Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001108 RID: 4360 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001108")]
	[Address(RVA = "0x881C40", Offset = "0x880240", VA = "0x180881C40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DisablePickup Raise()
	{
		return null;
	}

	// Token: 0x06001109 RID: 4361 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001109")]
	[Address(RVA = "0x881C60", Offset = "0x880260", VA = "0x180881C60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DisablePickup Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600110A RID: 4362 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600110A")]
	[Address(RVA = "0x8818C0", Offset = "0x87FEC0", VA = "0x1808818C0")]
	public static DisablePickup Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600110B RID: 4363 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600110B")]
	[Address(RVA = "0x881C70", Offset = "0x880270", VA = "0x180881C70")]
	public static DisablePickup Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600110C RID: 4364 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600110C")]
	[Address(RVA = "0x881E70", Offset = "0x880470", VA = "0x180881E70")]
	private static DisablePickup Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600110D RID: 4365 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600110D")]
	[Address(RVA = "0x881BF0", Offset = "0x8801F0", VA = "0x180881BF0")]
	public static DisablePickup Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600110E RID: 4366 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600110E")]
	[Address(RVA = "0x881C00", Offset = "0x880200", VA = "0x180881C00")]
	public static DisablePickup Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600110F RID: 4367 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600110F")]
	[Address(RVA = "0x881C10", Offset = "0x880210", VA = "0x180881C10")]
	public static DisablePickup Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001110 RID: 4368 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001110")]
	[Address(RVA = "0x881C20", Offset = "0x880220", VA = "0x180881C20")]
	public static DisablePickup Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001111 RID: 4369 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001111")]
	[Address(RVA = "0x881C40", Offset = "0x880240", VA = "0x180881C40")]
	public static DisablePickup Create()
	{
		return null;
	}

	// Token: 0x06001112 RID: 4370 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001112")]
	[Address(RVA = "0x881C60", Offset = "0x880260", VA = "0x180881C60")]
	public static DisablePickup Create(ReliabilityModes reliability)
	{
		return null;
	}
}
