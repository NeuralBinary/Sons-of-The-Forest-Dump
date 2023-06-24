using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000C3 RID: 195
[Token(Token = "0x20000C3")]
public class PlayerHitByEnemey : Event
{
	// Token: 0x060008FB RID: 2299 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008FB")]
	[Address(RVA = "0x83E2A0", Offset = "0x83C8A0", VA = "0x18083E2A0")]
	public PlayerHitByEnemey()
	{
	}

	// Token: 0x170004A5 RID: 1189
	// (get) Token: 0x060008FC RID: 2300 RVA: 0x00005400 File Offset: 0x00003600
	// (set) Token: 0x060008FD RID: 2301 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004A5")]
	public int Damage
	{
		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x7EB470", Offset = "0x7E9A70", VA = "0x1807EB470")]
		set
		{
		}
	}

	// Token: 0x170004A6 RID: 1190
	// (get) Token: 0x060008FE RID: 2302 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060008FF RID: 2303 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004A6")]
	public BoltEntity Target
	{
		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x83E300", Offset = "0x83C900", VA = "0x18083E300")]
		set
		{
		}
	}

	// Token: 0x170004A7 RID: 1191
	// (get) Token: 0x06000900 RID: 2304 RVA: 0x00005418 File Offset: 0x00003618
	// (set) Token: 0x06000901 RID: 2305 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004A7")]
	public int Type
	{
		[Token(Token = "0x6000900")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000901")]
		[Address(RVA = "0x83E510", Offset = "0x83CB10", VA = "0x18083E510")]
		set
		{
		}
	}

	// Token: 0x170004A8 RID: 1192
	// (get) Token: 0x06000902 RID: 2306 RVA: 0x00005430 File Offset: 0x00003630
	// (set) Token: 0x06000903 RID: 2307 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004A8")]
	public Vector3 Direction
	{
		[Token(Token = "0x6000902")]
		[Address(RVA = "0x7D5EB0", Offset = "0x7D44B0", VA = "0x1807D5EB0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000903")]
		[Address(RVA = "0x83E5C0", Offset = "0x83CBC0", VA = "0x18083E5C0")]
		set
		{
		}
	}

	// Token: 0x170004A9 RID: 1193
	// (get) Token: 0x06000904 RID: 2308 RVA: 0x00005448 File Offset: 0x00003648
	// (set) Token: 0x06000905 RID: 2309 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004A9")]
	public bool SharkHit
	{
		[Token(Token = "0x6000904")]
		[Address(RVA = "0x7BBF10", Offset = "0x7BA510", VA = "0x1807BBF10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000905")]
		[Address(RVA = "0x835BB0", Offset = "0x8341B0", VA = "0x180835BB0")]
		set
		{
		}
	}

	// Token: 0x06000906 RID: 2310 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000906")]
	[Address(RVA = "0x83E670", Offset = "0x83CC70", VA = "0x18083E670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000907 RID: 2311 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000907")]
	[Address(RVA = "0x83EA60", Offset = "0x83D060", VA = "0x18083EA60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerHitByEnemey Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000908 RID: 2312 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000908")]
	[Address(RVA = "0x83EA70", Offset = "0x83D070", VA = "0x18083EA70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerHitByEnemey Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000909 RID: 2313 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000909")]
	[Address(RVA = "0x83EC70", Offset = "0x83D270", VA = "0x18083EC70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static PlayerHitByEnemey Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600090A RID: 2314 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600090A")]
	[Address(RVA = "0x83ED90", Offset = "0x83D390", VA = "0x18083ED90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerHitByEnemey Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600090B RID: 2315 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600090B")]
	[Address(RVA = "0x83EDA0", Offset = "0x83D3A0", VA = "0x18083EDA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerHitByEnemey Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600090C RID: 2316 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600090C")]
	[Address(RVA = "0x83EDB0", Offset = "0x83D3B0", VA = "0x18083EDB0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerHitByEnemey Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600090D RID: 2317 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600090D")]
	[Address(RVA = "0x83EDC0", Offset = "0x83D3C0", VA = "0x18083EDC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerHitByEnemey Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600090E RID: 2318 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600090E")]
	[Address(RVA = "0x83EDE0", Offset = "0x83D3E0", VA = "0x18083EDE0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerHitByEnemey Raise()
	{
		return null;
	}

	// Token: 0x0600090F RID: 2319 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600090F")]
	[Address(RVA = "0x83EE00", Offset = "0x83D400", VA = "0x18083EE00")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerHitByEnemey Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000910 RID: 2320 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000910")]
	[Address(RVA = "0x83EA60", Offset = "0x83D060", VA = "0x18083EA60")]
	public static PlayerHitByEnemey Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000911 RID: 2321 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000911")]
	[Address(RVA = "0x83EE10", Offset = "0x83D410", VA = "0x18083EE10")]
	public static PlayerHitByEnemey Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000912 RID: 2322 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000912")]
	[Address(RVA = "0x83F010", Offset = "0x83D610", VA = "0x18083F010")]
	private static PlayerHitByEnemey Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000913 RID: 2323 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000913")]
	[Address(RVA = "0x83ED90", Offset = "0x83D390", VA = "0x18083ED90")]
	public static PlayerHitByEnemey Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000914 RID: 2324 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000914")]
	[Address(RVA = "0x83EDA0", Offset = "0x83D3A0", VA = "0x18083EDA0")]
	public static PlayerHitByEnemey Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000915 RID: 2325 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000915")]
	[Address(RVA = "0x83EDB0", Offset = "0x83D3B0", VA = "0x18083EDB0")]
	public static PlayerHitByEnemey Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000916 RID: 2326 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000916")]
	[Address(RVA = "0x83EDC0", Offset = "0x83D3C0", VA = "0x18083EDC0")]
	public static PlayerHitByEnemey Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000917 RID: 2327 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000917")]
	[Address(RVA = "0x83EDE0", Offset = "0x83D3E0", VA = "0x18083EDE0")]
	public static PlayerHitByEnemey Create()
	{
		return null;
	}

	// Token: 0x06000918 RID: 2328 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000918")]
	[Address(RVA = "0x83EE00", Offset = "0x83D400", VA = "0x18083EE00")]
	public static PlayerHitByEnemey Create(ReliabilityModes reliability)
	{
		return null;
	}
}
