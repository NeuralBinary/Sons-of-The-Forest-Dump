using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200018C RID: 396
[Token(Token = "0x200018C")]
public class updateMecanimRemoteState : Event
{
	// Token: 0x06001211 RID: 4625 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001211")]
	[Address(RVA = "0x88A6F0", Offset = "0x888CF0", VA = "0x18088A6F0")]
	public updateMecanimRemoteState()
	{
	}

	// Token: 0x1700060E RID: 1550
	// (get) Token: 0x06001212 RID: 4626 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001213 RID: 4627 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700060E")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001212")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001213")]
		[Address(RVA = "0x88A750", Offset = "0x888D50", VA = "0x18088A750")]
		set
		{
		}
	}

	// Token: 0x1700060F RID: 1551
	// (get) Token: 0x06001214 RID: 4628 RVA: 0x00006948 File Offset: 0x00004B48
	// (set) Token: 0x06001215 RID: 4629 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700060F")]
	public int layer
	{
		[Token(Token = "0x6001214")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001215")]
		[Address(RVA = "0x88A960", Offset = "0x888F60", VA = "0x18088A960")]
		set
		{
		}
	}

	// Token: 0x17000610 RID: 1552
	// (get) Token: 0x06001216 RID: 4630 RVA: 0x00006960 File Offset: 0x00004B60
	// (set) Token: 0x06001217 RID: 4631 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000610")]
	public int hash
	{
		[Token(Token = "0x6001216")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001217")]
		[Address(RVA = "0x7D6E60", Offset = "0x7D5460", VA = "0x1807D6E60")]
		set
		{
		}
	}

	// Token: 0x17000611 RID: 1553
	// (get) Token: 0x06001218 RID: 4632 RVA: 0x00006978 File Offset: 0x00004B78
	// (set) Token: 0x06001219 RID: 4633 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000611")]
	public float normalizedTime
	{
		[Token(Token = "0x6001218")]
		[Address(RVA = "0x7C2150", Offset = "0x7C0750", VA = "0x1807C2150")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001219")]
		[Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
		set
		{
		}
	}

	// Token: 0x17000612 RID: 1554
	// (get) Token: 0x0600121A RID: 4634 RVA: 0x00006990 File Offset: 0x00004B90
	// (set) Token: 0x0600121B RID: 4635 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000612")]
	public bool anyState
	{
		[Token(Token = "0x600121A")]
		[Address(RVA = "0x7BBF10", Offset = "0x7BA510", VA = "0x1807BBF10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600121B")]
		[Address(RVA = "0x835BB0", Offset = "0x8341B0", VA = "0x180835BB0")]
		set
		{
		}
	}

	// Token: 0x0600121C RID: 4636 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600121C")]
	[Address(RVA = "0x88AA10", Offset = "0x889010", VA = "0x18088AA10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0600121D RID: 4637 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600121D")]
	[Address(RVA = "0x88AD70", Offset = "0x889370", VA = "0x18088AD70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static updateMecanimRemoteState Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600121E RID: 4638 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600121E")]
	[Address(RVA = "0x88AD80", Offset = "0x889380", VA = "0x18088AD80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static updateMecanimRemoteState Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600121F RID: 4639 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600121F")]
	[Address(RVA = "0x88AF80", Offset = "0x889580", VA = "0x18088AF80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static updateMecanimRemoteState Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001220 RID: 4640 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001220")]
	[Address(RVA = "0x88B0A0", Offset = "0x8896A0", VA = "0x18088B0A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static updateMecanimRemoteState Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001221 RID: 4641 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001221")]
	[Address(RVA = "0x88B0B0", Offset = "0x8896B0", VA = "0x18088B0B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static updateMecanimRemoteState Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001222 RID: 4642 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001222")]
	[Address(RVA = "0x88B0C0", Offset = "0x8896C0", VA = "0x18088B0C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static updateMecanimRemoteState Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001223 RID: 4643 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001223")]
	[Address(RVA = "0x88B0D0", Offset = "0x8896D0", VA = "0x18088B0D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static updateMecanimRemoteState Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001224 RID: 4644 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001224")]
	[Address(RVA = "0x88B0F0", Offset = "0x8896F0", VA = "0x18088B0F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static updateMecanimRemoteState Raise()
	{
		return null;
	}

	// Token: 0x06001225 RID: 4645 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001225")]
	[Address(RVA = "0x88B110", Offset = "0x889710", VA = "0x18088B110")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static updateMecanimRemoteState Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001226 RID: 4646 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001226")]
	[Address(RVA = "0x88AD70", Offset = "0x889370", VA = "0x18088AD70")]
	public static updateMecanimRemoteState Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001227 RID: 4647 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001227")]
	[Address(RVA = "0x88B120", Offset = "0x889720", VA = "0x18088B120")]
	public static updateMecanimRemoteState Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001228 RID: 4648 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001228")]
	[Address(RVA = "0x88B320", Offset = "0x889920", VA = "0x18088B320")]
	private static updateMecanimRemoteState Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001229 RID: 4649 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001229")]
	[Address(RVA = "0x88B0A0", Offset = "0x8896A0", VA = "0x18088B0A0")]
	public static updateMecanimRemoteState Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600122A RID: 4650 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600122A")]
	[Address(RVA = "0x88B0B0", Offset = "0x8896B0", VA = "0x18088B0B0")]
	public static updateMecanimRemoteState Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600122B RID: 4651 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600122B")]
	[Address(RVA = "0x88B0C0", Offset = "0x8896C0", VA = "0x18088B0C0")]
	public static updateMecanimRemoteState Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600122C RID: 4652 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600122C")]
	[Address(RVA = "0x88B0D0", Offset = "0x8896D0", VA = "0x18088B0D0")]
	public static updateMecanimRemoteState Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600122D RID: 4653 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600122D")]
	[Address(RVA = "0x88B0F0", Offset = "0x8896F0", VA = "0x18088B0F0")]
	public static updateMecanimRemoteState Create()
	{
		return null;
	}

	// Token: 0x0600122E RID: 4654 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600122E")]
	[Address(RVA = "0x88B110", Offset = "0x889710", VA = "0x18088B110")]
	public static updateMecanimRemoteState Create(ReliabilityModes reliability)
	{
		return null;
	}
}
