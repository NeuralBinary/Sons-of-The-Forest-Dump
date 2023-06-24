using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000105 RID: 261
[Token(Token = "0x2000105")]
public class PlayerHealed : Event
{
	// Token: 0x06000BFB RID: 3067 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BFB")]
	[Address(RVA = "0x8577C0", Offset = "0x855DC0", VA = "0x1808577C0")]
	public PlayerHealed()
	{
	}

	// Token: 0x1700051F RID: 1311
	// (get) Token: 0x06000BFC RID: 3068 RVA: 0x00005BC8 File Offset: 0x00003DC8
	// (set) Token: 0x06000BFD RID: 3069 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700051F")]
	public int HealingItemId
	{
		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x7EB470", Offset = "0x7E9A70", VA = "0x1807EB470")]
		set
		{
		}
	}

	// Token: 0x17000520 RID: 1312
	// (get) Token: 0x06000BFE RID: 3070 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000BFF RID: 3071 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000520")]
	public BoltEntity HealTarget
	{
		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x857820", Offset = "0x855E20", VA = "0x180857820")]
		set
		{
		}
	}

	// Token: 0x06000C00 RID: 3072 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C00")]
	[Address(RVA = "0x857A30", Offset = "0x856030", VA = "0x180857A30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000C01 RID: 3073 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C01")]
	[Address(RVA = "0x857AF0", Offset = "0x8560F0", VA = "0x180857AF0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerHealed Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000C02 RID: 3074 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C02")]
	[Address(RVA = "0x857B00", Offset = "0x856100", VA = "0x180857B00")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerHealed Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000C03 RID: 3075 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C03")]
	[Address(RVA = "0x857D00", Offset = "0x856300", VA = "0x180857D00")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static PlayerHealed Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C04 RID: 3076 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C04")]
	[Address(RVA = "0x857E20", Offset = "0x856420", VA = "0x180857E20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerHealed Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000C05 RID: 3077 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C05")]
	[Address(RVA = "0x857E30", Offset = "0x856430", VA = "0x180857E30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerHealed Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C06 RID: 3078 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C06")]
	[Address(RVA = "0x857E40", Offset = "0x856440", VA = "0x180857E40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerHealed Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000C07 RID: 3079 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C07")]
	[Address(RVA = "0x857E50", Offset = "0x856450", VA = "0x180857E50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerHealed Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C08 RID: 3080 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C08")]
	[Address(RVA = "0x857E70", Offset = "0x856470", VA = "0x180857E70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerHealed Raise()
	{
		return null;
	}

	// Token: 0x06000C09 RID: 3081 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C09")]
	[Address(RVA = "0x857E90", Offset = "0x856490", VA = "0x180857E90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerHealed Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C0A RID: 3082 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C0A")]
	[Address(RVA = "0x857AF0", Offset = "0x8560F0", VA = "0x180857AF0")]
	public static PlayerHealed Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000C0B RID: 3083 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C0B")]
	[Address(RVA = "0x857EA0", Offset = "0x8564A0", VA = "0x180857EA0")]
	public static PlayerHealed Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000C0C RID: 3084 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C0C")]
	[Address(RVA = "0x8580A0", Offset = "0x8566A0", VA = "0x1808580A0")]
	private static PlayerHealed Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C0D RID: 3085 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C0D")]
	[Address(RVA = "0x857E20", Offset = "0x856420", VA = "0x180857E20")]
	public static PlayerHealed Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000C0E RID: 3086 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C0E")]
	[Address(RVA = "0x857E30", Offset = "0x856430", VA = "0x180857E30")]
	public static PlayerHealed Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C0F RID: 3087 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C0F")]
	[Address(RVA = "0x857E40", Offset = "0x856440", VA = "0x180857E40")]
	public static PlayerHealed Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000C10 RID: 3088 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C10")]
	[Address(RVA = "0x857E50", Offset = "0x856450", VA = "0x180857E50")]
	public static PlayerHealed Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000C11 RID: 3089 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C11")]
	[Address(RVA = "0x857E70", Offset = "0x856470", VA = "0x180857E70")]
	public static PlayerHealed Create()
	{
		return null;
	}

	// Token: 0x06000C12 RID: 3090 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C12")]
	[Address(RVA = "0x857E90", Offset = "0x856490", VA = "0x180857E90")]
	public static PlayerHealed Create(ReliabilityModes reliability)
	{
		return null;
	}
}
