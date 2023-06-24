using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000150 RID: 336
[Token(Token = "0x2000150")]
public class TakeBody : Event
{
	// Token: 0x06000F65 RID: 3941 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F65")]
	[Address(RVA = "0x874930", Offset = "0x872F30", VA = "0x180874930")]
	public TakeBody()
	{
	}

	// Token: 0x170005A8 RID: 1448
	// (get) Token: 0x06000F66 RID: 3942 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000F67 RID: 3943 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005A8")]
	public BoltEntity Sled
	{
		[Token(Token = "0x6000F66")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000F67")]
		[Address(RVA = "0x874990", Offset = "0x872F90", VA = "0x180874990")]
		set
		{
		}
	}

	// Token: 0x170005A9 RID: 1449
	// (get) Token: 0x06000F68 RID: 3944 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000F69 RID: 3945 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005A9")]
	public BoltEntity Body
	{
		[Token(Token = "0x6000F68")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000F69")]
		[Address(RVA = "0x874BA0", Offset = "0x8731A0", VA = "0x180874BA0")]
		set
		{
		}
	}

	// Token: 0x06000F6A RID: 3946 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F6A")]
	[Address(RVA = "0x874DB0", Offset = "0x8733B0", VA = "0x180874DB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000F6B RID: 3947 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F6B")]
	[Address(RVA = "0x874F20", Offset = "0x873520", VA = "0x180874F20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TakeBody Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000F6C RID: 3948 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F6C")]
	[Address(RVA = "0x874F30", Offset = "0x873530", VA = "0x180874F30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TakeBody Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000F6D RID: 3949 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F6D")]
	[Address(RVA = "0x875130", Offset = "0x873730", VA = "0x180875130")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static TakeBody Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000F6E RID: 3950 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F6E")]
	[Address(RVA = "0x875250", Offset = "0x873850", VA = "0x180875250")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TakeBody Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000F6F RID: 3951 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F6F")]
	[Address(RVA = "0x875260", Offset = "0x873860", VA = "0x180875260")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TakeBody Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000F70 RID: 3952 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F70")]
	[Address(RVA = "0x875270", Offset = "0x873870", VA = "0x180875270")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TakeBody Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000F71 RID: 3953 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F71")]
	[Address(RVA = "0x875280", Offset = "0x873880", VA = "0x180875280")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TakeBody Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000F72 RID: 3954 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F72")]
	[Address(RVA = "0x8752A0", Offset = "0x8738A0", VA = "0x1808752A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TakeBody Raise()
	{
		return null;
	}

	// Token: 0x06000F73 RID: 3955 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F73")]
	[Address(RVA = "0x8752C0", Offset = "0x8738C0", VA = "0x1808752C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TakeBody Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000F74 RID: 3956 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F74")]
	[Address(RVA = "0x874F20", Offset = "0x873520", VA = "0x180874F20")]
	public static TakeBody Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000F75 RID: 3957 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F75")]
	[Address(RVA = "0x8752D0", Offset = "0x8738D0", VA = "0x1808752D0")]
	public static TakeBody Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000F76 RID: 3958 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F76")]
	[Address(RVA = "0x8754D0", Offset = "0x873AD0", VA = "0x1808754D0")]
	private static TakeBody Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000F77 RID: 3959 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F77")]
	[Address(RVA = "0x875250", Offset = "0x873850", VA = "0x180875250")]
	public static TakeBody Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000F78 RID: 3960 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F78")]
	[Address(RVA = "0x875260", Offset = "0x873860", VA = "0x180875260")]
	public static TakeBody Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000F79 RID: 3961 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F79")]
	[Address(RVA = "0x875270", Offset = "0x873870", VA = "0x180875270")]
	public static TakeBody Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000F7A RID: 3962 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F7A")]
	[Address(RVA = "0x875280", Offset = "0x873880", VA = "0x180875280")]
	public static TakeBody Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000F7B RID: 3963 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F7B")]
	[Address(RVA = "0x8752A0", Offset = "0x8738A0", VA = "0x1808752A0")]
	public static TakeBody Create()
	{
		return null;
	}

	// Token: 0x06000F7C RID: 3964 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F7C")]
	[Address(RVA = "0x8752C0", Offset = "0x8738C0", VA = "0x1808752C0")]
	public static TakeBody Create(ReliabilityModes reliability)
	{
		return null;
	}
}
