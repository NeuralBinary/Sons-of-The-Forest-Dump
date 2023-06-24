using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000276 RID: 630
[Token(Token = "0x2000276")]
public class PlayerRequestActorItem : Event
{
	// Token: 0x06001CF3 RID: 7411 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CF3")]
	[Address(RVA = "0x7EC2A0", Offset = "0x7EA8A0", VA = "0x1807EC2A0")]
	public PlayerRequestActorItem()
	{
	}

	// Token: 0x170007F5 RID: 2037
	// (get) Token: 0x06001CF4 RID: 7412 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001CF5 RID: 7413 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007F5")]
	public BoltEntity Actor
	{
		[Token(Token = "0x6001CF4")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001CF5")]
		[Address(RVA = "0x7EC300", Offset = "0x7EA900", VA = "0x1807EC300")]
		set
		{
		}
	}

	// Token: 0x170007F6 RID: 2038
	// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x00008910 File Offset: 0x00006B10
	// (set) Token: 0x06001CF7 RID: 7415 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007F6")]
	public int ItemId
	{
		[Token(Token = "0x6001CF6")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001CF7")]
		[Address(RVA = "0x7D6DC0", Offset = "0x7D53C0", VA = "0x1807D6DC0")]
		set
		{
		}
	}

	// Token: 0x170007F7 RID: 2039
	// (get) Token: 0x06001CF8 RID: 7416 RVA: 0x00008928 File Offset: 0x00006B28
	// (set) Token: 0x06001CF9 RID: 7417 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007F7")]
	public int Amount
	{
		[Token(Token = "0x6001CF8")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001CF9")]
		[Address(RVA = "0x7D6E60", Offset = "0x7D5460", VA = "0x1807D6E60")]
		set
		{
		}
	}

	// Token: 0x06001CFA RID: 7418 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CFA")]
	[Address(RVA = "0x7EC510", Offset = "0x7EAB10", VA = "0x1807EC510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001CFB RID: 7419 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CFB")]
	[Address(RVA = "0x7EC650", Offset = "0x7EAC50", VA = "0x1807EC650")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerRequestActorItem Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001CFC RID: 7420 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CFC")]
	[Address(RVA = "0x7EC660", Offset = "0x7EAC60", VA = "0x1807EC660")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerRequestActorItem Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001CFD RID: 7421 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CFD")]
	[Address(RVA = "0x7EC860", Offset = "0x7EAE60", VA = "0x1807EC860")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static PlayerRequestActorItem Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001CFE RID: 7422 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CFE")]
	[Address(RVA = "0x7EC980", Offset = "0x7EAF80", VA = "0x1807EC980")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerRequestActorItem Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001CFF RID: 7423 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CFF")]
	[Address(RVA = "0x7EC990", Offset = "0x7EAF90", VA = "0x1807EC990")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerRequestActorItem Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001D00 RID: 7424 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D00")]
	[Address(RVA = "0x7EC9A0", Offset = "0x7EAFA0", VA = "0x1807EC9A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerRequestActorItem Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001D01 RID: 7425 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D01")]
	[Address(RVA = "0x7EC9B0", Offset = "0x7EAFB0", VA = "0x1807EC9B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerRequestActorItem Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001D02 RID: 7426 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D02")]
	[Address(RVA = "0x7EC9D0", Offset = "0x7EAFD0", VA = "0x1807EC9D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerRequestActorItem Raise()
	{
		return null;
	}

	// Token: 0x06001D03 RID: 7427 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D03")]
	[Address(RVA = "0x7EC9F0", Offset = "0x7EAFF0", VA = "0x1807EC9F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerRequestActorItem Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001D04 RID: 7428 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D04")]
	[Address(RVA = "0x7EC650", Offset = "0x7EAC50", VA = "0x1807EC650")]
	public static PlayerRequestActorItem Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001D05 RID: 7429 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D05")]
	[Address(RVA = "0x7ECA00", Offset = "0x7EB000", VA = "0x1807ECA00")]
	public static PlayerRequestActorItem Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001D06 RID: 7430 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D06")]
	[Address(RVA = "0x7ECC00", Offset = "0x7EB200", VA = "0x1807ECC00")]
	private static PlayerRequestActorItem Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001D07 RID: 7431 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D07")]
	[Address(RVA = "0x7EC980", Offset = "0x7EAF80", VA = "0x1807EC980")]
	public static PlayerRequestActorItem Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001D08 RID: 7432 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D08")]
	[Address(RVA = "0x7EC990", Offset = "0x7EAF90", VA = "0x1807EC990")]
	public static PlayerRequestActorItem Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001D09 RID: 7433 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D09")]
	[Address(RVA = "0x7EC9A0", Offset = "0x7EAFA0", VA = "0x1807EC9A0")]
	public static PlayerRequestActorItem Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001D0A RID: 7434 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D0A")]
	[Address(RVA = "0x7EC9B0", Offset = "0x7EAFB0", VA = "0x1807EC9B0")]
	public static PlayerRequestActorItem Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001D0B RID: 7435 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D0B")]
	[Address(RVA = "0x7EC9D0", Offset = "0x7EAFD0", VA = "0x1807EC9D0")]
	public static PlayerRequestActorItem Create()
	{
		return null;
	}

	// Token: 0x06001D0C RID: 7436 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D0C")]
	[Address(RVA = "0x7EC9F0", Offset = "0x7EAFF0", VA = "0x1807EC9F0")]
	public static PlayerRequestActorItem Create(ReliabilityModes reliability)
	{
		return null;
	}
}
