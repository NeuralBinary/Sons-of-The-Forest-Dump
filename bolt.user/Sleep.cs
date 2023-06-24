using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000180 RID: 384
[Token(Token = "0x2000180")]
public class Sleep : Event
{
	// Token: 0x06001187 RID: 4487 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001187")]
	[Address(RVA = "0x885F90", Offset = "0x884590", VA = "0x180885F90")]
	public Sleep()
	{
	}

	// Token: 0x170005F9 RID: 1529
	// (get) Token: 0x06001188 RID: 4488 RVA: 0x000067F8 File Offset: 0x000049F8
	// (set) Token: 0x06001189 RID: 4489 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005F9")]
	public bool Aborted
	{
		[Token(Token = "0x6001188")]
		[Address(RVA = "0x7B4A10", Offset = "0x7B3010", VA = "0x1807B4A10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001189")]
		[Address(RVA = "0x7DB320", Offset = "0x7D9920", VA = "0x1807DB320")]
		set
		{
		}
	}

	// Token: 0x0600118A RID: 4490 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600118A")]
	[Address(RVA = "0x885FF0", Offset = "0x8845F0", VA = "0x180885FF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0600118B RID: 4491 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600118B")]
	[Address(RVA = "0x8860A0", Offset = "0x8846A0", VA = "0x1808860A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Sleep Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600118C RID: 4492 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600118C")]
	[Address(RVA = "0x8860B0", Offset = "0x8846B0", VA = "0x1808860B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Sleep Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600118D RID: 4493 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600118D")]
	[Address(RVA = "0x8862B0", Offset = "0x8848B0", VA = "0x1808862B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static Sleep Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600118E RID: 4494 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600118E")]
	[Address(RVA = "0x8863D0", Offset = "0x8849D0", VA = "0x1808863D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Sleep Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600118F RID: 4495 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600118F")]
	[Address(RVA = "0x8863E0", Offset = "0x8849E0", VA = "0x1808863E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Sleep Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001190 RID: 4496 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001190")]
	[Address(RVA = "0x8863F0", Offset = "0x8849F0", VA = "0x1808863F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Sleep Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001191 RID: 4497 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001191")]
	[Address(RVA = "0x886400", Offset = "0x884A00", VA = "0x180886400")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Sleep Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001192 RID: 4498 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001192")]
	[Address(RVA = "0x886420", Offset = "0x884A20", VA = "0x180886420")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Sleep Raise()
	{
		return null;
	}

	// Token: 0x06001193 RID: 4499 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001193")]
	[Address(RVA = "0x886440", Offset = "0x884A40", VA = "0x180886440")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Sleep Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001194 RID: 4500 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001194")]
	[Address(RVA = "0x8860A0", Offset = "0x8846A0", VA = "0x1808860A0")]
	public static Sleep Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001195 RID: 4501 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001195")]
	[Address(RVA = "0x886450", Offset = "0x884A50", VA = "0x180886450")]
	public static Sleep Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001196 RID: 4502 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001196")]
	[Address(RVA = "0x886650", Offset = "0x884C50", VA = "0x180886650")]
	private static Sleep Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001197 RID: 4503 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001197")]
	[Address(RVA = "0x8863D0", Offset = "0x8849D0", VA = "0x1808863D0")]
	public static Sleep Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001198 RID: 4504 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001198")]
	[Address(RVA = "0x8863E0", Offset = "0x8849E0", VA = "0x1808863E0")]
	public static Sleep Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001199 RID: 4505 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001199")]
	[Address(RVA = "0x8863F0", Offset = "0x8849F0", VA = "0x1808863F0")]
	public static Sleep Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600119A RID: 4506 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600119A")]
	[Address(RVA = "0x886400", Offset = "0x884A00", VA = "0x180886400")]
	public static Sleep Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600119B RID: 4507 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600119B")]
	[Address(RVA = "0x886420", Offset = "0x884A20", VA = "0x180886420")]
	public static Sleep Create()
	{
		return null;
	}

	// Token: 0x0600119C RID: 4508 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600119C")]
	[Address(RVA = "0x886440", Offset = "0x884A40", VA = "0x180886440")]
	public static Sleep Create(ReliabilityModes reliability)
	{
		return null;
	}
}
