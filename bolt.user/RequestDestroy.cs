using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000D2 RID: 210
[Token(Token = "0x20000D2")]
public class RequestDestroy : Event
{
	// Token: 0x060009C7 RID: 2503 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009C7")]
	[Address(RVA = "0x846370", Offset = "0x844970", VA = "0x180846370")]
	public RequestDestroy()
	{
	}

	// Token: 0x170004CF RID: 1231
	// (get) Token: 0x060009C8 RID: 2504 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060009C9 RID: 2505 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004CF")]
	public BoltEntity Entity
	{
		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x8463D0", Offset = "0x8449D0", VA = "0x1808463D0")]
		set
		{
		}
	}

	// Token: 0x060009CA RID: 2506 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009CA")]
	[Address(RVA = "0x8465E0", Offset = "0x844BE0", VA = "0x1808465E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060009CB RID: 2507 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009CB")]
	[Address(RVA = "0x846630", Offset = "0x844C30", VA = "0x180846630")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RequestDestroy Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060009CC RID: 2508 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009CC")]
	[Address(RVA = "0x846640", Offset = "0x844C40", VA = "0x180846640")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RequestDestroy Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060009CD RID: 2509 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009CD")]
	[Address(RVA = "0x846840", Offset = "0x844E40", VA = "0x180846840")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static RequestDestroy Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060009CE RID: 2510 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009CE")]
	[Address(RVA = "0x846960", Offset = "0x844F60", VA = "0x180846960")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RequestDestroy Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060009CF RID: 2511 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009CF")]
	[Address(RVA = "0x846970", Offset = "0x844F70", VA = "0x180846970")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RequestDestroy Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060009D0 RID: 2512 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009D0")]
	[Address(RVA = "0x846980", Offset = "0x844F80", VA = "0x180846980")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RequestDestroy Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060009D1 RID: 2513 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009D1")]
	[Address(RVA = "0x846990", Offset = "0x844F90", VA = "0x180846990")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RequestDestroy Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060009D2 RID: 2514 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009D2")]
	[Address(RVA = "0x8469B0", Offset = "0x844FB0", VA = "0x1808469B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RequestDestroy Raise()
	{
		return null;
	}

	// Token: 0x060009D3 RID: 2515 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009D3")]
	[Address(RVA = "0x8469D0", Offset = "0x844FD0", VA = "0x1808469D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RequestDestroy Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060009D4 RID: 2516 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009D4")]
	[Address(RVA = "0x846630", Offset = "0x844C30", VA = "0x180846630")]
	public static RequestDestroy Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060009D5 RID: 2517 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009D5")]
	[Address(RVA = "0x8469E0", Offset = "0x844FE0", VA = "0x1808469E0")]
	public static RequestDestroy Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060009D6 RID: 2518 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009D6")]
	[Address(RVA = "0x846BE0", Offset = "0x8451E0", VA = "0x180846BE0")]
	private static RequestDestroy Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060009D7 RID: 2519 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009D7")]
	[Address(RVA = "0x846960", Offset = "0x844F60", VA = "0x180846960")]
	public static RequestDestroy Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060009D8 RID: 2520 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009D8")]
	[Address(RVA = "0x846970", Offset = "0x844F70", VA = "0x180846970")]
	public static RequestDestroy Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060009D9 RID: 2521 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009D9")]
	[Address(RVA = "0x846980", Offset = "0x844F80", VA = "0x180846980")]
	public static RequestDestroy Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060009DA RID: 2522 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009DA")]
	[Address(RVA = "0x846990", Offset = "0x844F90", VA = "0x180846990")]
	public static RequestDestroy Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060009DB RID: 2523 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009DB")]
	[Address(RVA = "0x8469B0", Offset = "0x844FB0", VA = "0x1808469B0")]
	public static RequestDestroy Create()
	{
		return null;
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009DC")]
	[Address(RVA = "0x8469D0", Offset = "0x844FD0", VA = "0x1808469D0")]
	public static RequestDestroy Create(ReliabilityModes reliability)
	{
		return null;
	}
}
