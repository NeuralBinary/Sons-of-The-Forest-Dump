using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000189 RID: 393
[Token(Token = "0x2000189")]
public class RequestMecanimSync : Event
{
	// Token: 0x060011F1 RID: 4593 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011F1")]
	[Address(RVA = "0x889780", Offset = "0x887D80", VA = "0x180889780")]
	public RequestMecanimSync()
	{
	}

	// Token: 0x1700060A RID: 1546
	// (get) Token: 0x060011F2 RID: 4594 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060011F3 RID: 4595 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700060A")]
	public BoltEntity PlayerRequesting
	{
		[Token(Token = "0x60011F2")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60011F3")]
		[Address(RVA = "0x8897E0", Offset = "0x887DE0", VA = "0x1808897E0")]
		set
		{
		}
	}

	// Token: 0x060011F4 RID: 4596 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011F4")]
	[Address(RVA = "0x8899F0", Offset = "0x887FF0", VA = "0x1808899F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060011F5 RID: 4597 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011F5")]
	[Address(RVA = "0x889AB0", Offset = "0x8880B0", VA = "0x180889AB0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RequestMecanimSync Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060011F6 RID: 4598 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011F6")]
	[Address(RVA = "0x889AC0", Offset = "0x8880C0", VA = "0x180889AC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RequestMecanimSync Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060011F7 RID: 4599 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011F7")]
	[Address(RVA = "0x889CC0", Offset = "0x8882C0", VA = "0x180889CC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static RequestMecanimSync Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060011F8 RID: 4600 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011F8")]
	[Address(RVA = "0x889DE0", Offset = "0x8883E0", VA = "0x180889DE0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RequestMecanimSync Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060011F9 RID: 4601 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011F9")]
	[Address(RVA = "0x889DF0", Offset = "0x8883F0", VA = "0x180889DF0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RequestMecanimSync Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060011FA RID: 4602 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011FA")]
	[Address(RVA = "0x889E00", Offset = "0x888400", VA = "0x180889E00")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RequestMecanimSync Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060011FB RID: 4603 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011FB")]
	[Address(RVA = "0x889E10", Offset = "0x888410", VA = "0x180889E10")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RequestMecanimSync Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060011FC RID: 4604 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011FC")]
	[Address(RVA = "0x889E30", Offset = "0x888430", VA = "0x180889E30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RequestMecanimSync Raise()
	{
		return null;
	}

	// Token: 0x060011FD RID: 4605 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011FD")]
	[Address(RVA = "0x889E50", Offset = "0x888450", VA = "0x180889E50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RequestMecanimSync Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060011FE RID: 4606 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011FE")]
	[Address(RVA = "0x889AB0", Offset = "0x8880B0", VA = "0x180889AB0")]
	public static RequestMecanimSync Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060011FF RID: 4607 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011FF")]
	[Address(RVA = "0x889E60", Offset = "0x888460", VA = "0x180889E60")]
	public static RequestMecanimSync Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001200 RID: 4608 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001200")]
	[Address(RVA = "0x88A060", Offset = "0x888660", VA = "0x18088A060")]
	private static RequestMecanimSync Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001201 RID: 4609 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001201")]
	[Address(RVA = "0x889DE0", Offset = "0x8883E0", VA = "0x180889DE0")]
	public static RequestMecanimSync Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001202 RID: 4610 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001202")]
	[Address(RVA = "0x889DF0", Offset = "0x8883F0", VA = "0x180889DF0")]
	public static RequestMecanimSync Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001203 RID: 4611 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001203")]
	[Address(RVA = "0x889E00", Offset = "0x888400", VA = "0x180889E00")]
	public static RequestMecanimSync Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001204 RID: 4612 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001204")]
	[Address(RVA = "0x889E10", Offset = "0x888410", VA = "0x180889E10")]
	public static RequestMecanimSync Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001205 RID: 4613 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001205")]
	[Address(RVA = "0x889E30", Offset = "0x888430", VA = "0x180889E30")]
	public static RequestMecanimSync Create()
	{
		return null;
	}

	// Token: 0x06001206 RID: 4614 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001206")]
	[Address(RVA = "0x889E50", Offset = "0x888450", VA = "0x180889E50")]
	public static RequestMecanimSync Create(ReliabilityModes reliability)
	{
		return null;
	}
}
