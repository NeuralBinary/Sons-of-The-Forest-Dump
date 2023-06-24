using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001B0 RID: 432
[Token(Token = "0x20001B0")]
public class SetTrappedEnemy : Event
{
	// Token: 0x060013B3 RID: 5043 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013B3")]
	[Address(RVA = "0x897B50", Offset = "0x896150", VA = "0x180897B50")]
	public SetTrappedEnemy()
	{
	}

	// Token: 0x17000651 RID: 1617
	// (get) Token: 0x060013B4 RID: 5044 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060013B5 RID: 5045 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000651")]
	public BoltEntity Enemy
	{
		[Token(Token = "0x60013B4")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60013B5")]
		[Address(RVA = "0x897BB0", Offset = "0x8961B0", VA = "0x180897BB0")]
		set
		{
		}
	}

	// Token: 0x17000652 RID: 1618
	// (get) Token: 0x060013B6 RID: 5046 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060013B7 RID: 5047 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000652")]
	public BoltEntity Trap
	{
		[Token(Token = "0x60013B6")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60013B7")]
		[Address(RVA = "0x897DC0", Offset = "0x8963C0", VA = "0x180897DC0")]
		set
		{
		}
	}

	// Token: 0x060013B8 RID: 5048 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013B8")]
	[Address(RVA = "0x897FD0", Offset = "0x8965D0", VA = "0x180897FD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060013B9 RID: 5049 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013B9")]
	[Address(RVA = "0x898140", Offset = "0x896740", VA = "0x180898140")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetTrappedEnemy Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060013BA RID: 5050 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013BA")]
	[Address(RVA = "0x898150", Offset = "0x896750", VA = "0x180898150")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetTrappedEnemy Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060013BB RID: 5051 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013BB")]
	[Address(RVA = "0x898350", Offset = "0x896950", VA = "0x180898350")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static SetTrappedEnemy Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060013BC RID: 5052 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013BC")]
	[Address(RVA = "0x898470", Offset = "0x896A70", VA = "0x180898470")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetTrappedEnemy Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060013BD RID: 5053 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013BD")]
	[Address(RVA = "0x898480", Offset = "0x896A80", VA = "0x180898480")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetTrappedEnemy Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060013BE RID: 5054 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013BE")]
	[Address(RVA = "0x898490", Offset = "0x896A90", VA = "0x180898490")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetTrappedEnemy Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060013BF RID: 5055 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013BF")]
	[Address(RVA = "0x8984A0", Offset = "0x896AA0", VA = "0x1808984A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetTrappedEnemy Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060013C0 RID: 5056 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013C0")]
	[Address(RVA = "0x8984C0", Offset = "0x896AC0", VA = "0x1808984C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetTrappedEnemy Raise()
	{
		return null;
	}

	// Token: 0x060013C1 RID: 5057 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013C1")]
	[Address(RVA = "0x8984E0", Offset = "0x896AE0", VA = "0x1808984E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetTrappedEnemy Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060013C2 RID: 5058 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013C2")]
	[Address(RVA = "0x898140", Offset = "0x896740", VA = "0x180898140")]
	public static SetTrappedEnemy Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060013C3 RID: 5059 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013C3")]
	[Address(RVA = "0x8984F0", Offset = "0x896AF0", VA = "0x1808984F0")]
	public static SetTrappedEnemy Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060013C4 RID: 5060 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013C4")]
	[Address(RVA = "0x8986F0", Offset = "0x896CF0", VA = "0x1808986F0")]
	private static SetTrappedEnemy Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060013C5 RID: 5061 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013C5")]
	[Address(RVA = "0x898470", Offset = "0x896A70", VA = "0x180898470")]
	public static SetTrappedEnemy Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060013C6 RID: 5062 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013C6")]
	[Address(RVA = "0x898480", Offset = "0x896A80", VA = "0x180898480")]
	public static SetTrappedEnemy Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060013C7 RID: 5063 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013C7")]
	[Address(RVA = "0x898490", Offset = "0x896A90", VA = "0x180898490")]
	public static SetTrappedEnemy Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060013C8 RID: 5064 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013C8")]
	[Address(RVA = "0x8984A0", Offset = "0x896AA0", VA = "0x1808984A0")]
	public static SetTrappedEnemy Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060013C9 RID: 5065 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013C9")]
	[Address(RVA = "0x8984C0", Offset = "0x896AC0", VA = "0x1808984C0")]
	public static SetTrappedEnemy Create()
	{
		return null;
	}

	// Token: 0x060013CA RID: 5066 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013CA")]
	[Address(RVA = "0x8984E0", Offset = "0x896AE0", VA = "0x1808984E0")]
	public static SetTrappedEnemy Create(ReliabilityModes reliability)
	{
		return null;
	}
}
