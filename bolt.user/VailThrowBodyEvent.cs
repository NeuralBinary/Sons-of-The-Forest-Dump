using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000225 RID: 549
[Token(Token = "0x2000225")]
public class VailThrowBodyEvent : Event
{
	// Token: 0x0600193B RID: 6459 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600193B")]
	[Address(RVA = "0x8C77F0", Offset = "0x8C5DF0", VA = "0x1808C77F0")]
	public VailThrowBodyEvent()
	{
	}

	// Token: 0x17000759 RID: 1881
	// (get) Token: 0x0600193C RID: 6460 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600193D RID: 6461 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000759")]
	public BoltEntity Target
	{
		[Token(Token = "0x600193C")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600193D")]
		[Address(RVA = "0x8C7850", Offset = "0x8C5E50", VA = "0x1808C7850")]
		set
		{
		}
	}

	// Token: 0x1700075A RID: 1882
	// (get) Token: 0x0600193E RID: 6462 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600193F RID: 6463 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700075A")]
	public BoltEntity ThrowingActor
	{
		[Token(Token = "0x600193E")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600193F")]
		[Address(RVA = "0x8C7A60", Offset = "0x8C6060", VA = "0x1808C7A60")]
		set
		{
		}
	}

	// Token: 0x1700075B RID: 1883
	// (get) Token: 0x06001940 RID: 6464 RVA: 0x00007F20 File Offset: 0x00006120
	// (set) Token: 0x06001941 RID: 6465 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700075B")]
	public int Stage
	{
		[Token(Token = "0x6001940")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001941")]
		[Address(RVA = "0x83CBD0", Offset = "0x83B1D0", VA = "0x18083CBD0")]
		set
		{
		}
	}

	// Token: 0x1700075C RID: 1884
	// (get) Token: 0x06001942 RID: 6466 RVA: 0x00007F38 File Offset: 0x00006138
	// (set) Token: 0x06001943 RID: 6467 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700075C")]
	public Vector3 ThrowDir
	{
		[Token(Token = "0x6001942")]
		[Address(RVA = "0x7D5EB0", Offset = "0x7D44B0", VA = "0x1807D5EB0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001943")]
		[Address(RVA = "0x8C7C70", Offset = "0x8C6270", VA = "0x1808C7C70")]
		set
		{
		}
	}

	// Token: 0x06001944 RID: 6468 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001944")]
	[Address(RVA = "0x8C7D80", Offset = "0x8C6380", VA = "0x1808C7D80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001945 RID: 6469 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001945")]
	[Address(RVA = "0x8C7FF0", Offset = "0x8C65F0", VA = "0x1808C7FF0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailThrowBodyEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001946 RID: 6470 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001946")]
	[Address(RVA = "0x8C8000", Offset = "0x8C6600", VA = "0x1808C8000")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailThrowBodyEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001947 RID: 6471 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001947")]
	[Address(RVA = "0x8C8200", Offset = "0x8C6800", VA = "0x1808C8200")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static VailThrowBodyEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001948 RID: 6472 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001948")]
	[Address(RVA = "0x8C8320", Offset = "0x8C6920", VA = "0x1808C8320")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailThrowBodyEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001949 RID: 6473 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001949")]
	[Address(RVA = "0x8C8330", Offset = "0x8C6930", VA = "0x1808C8330")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailThrowBodyEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600194A RID: 6474 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600194A")]
	[Address(RVA = "0x8C8340", Offset = "0x8C6940", VA = "0x1808C8340")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailThrowBodyEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600194B RID: 6475 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600194B")]
	[Address(RVA = "0x8C8350", Offset = "0x8C6950", VA = "0x1808C8350")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailThrowBodyEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600194C RID: 6476 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600194C")]
	[Address(RVA = "0x8C8370", Offset = "0x8C6970", VA = "0x1808C8370")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailThrowBodyEvent Raise()
	{
		return null;
	}

	// Token: 0x0600194D RID: 6477 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600194D")]
	[Address(RVA = "0x8C8390", Offset = "0x8C6990", VA = "0x1808C8390")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailThrowBodyEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600194E RID: 6478 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600194E")]
	[Address(RVA = "0x8C7FF0", Offset = "0x8C65F0", VA = "0x1808C7FF0")]
	public static VailThrowBodyEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600194F RID: 6479 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600194F")]
	[Address(RVA = "0x8C83A0", Offset = "0x8C69A0", VA = "0x1808C83A0")]
	public static VailThrowBodyEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001950 RID: 6480 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001950")]
	[Address(RVA = "0x8C85A0", Offset = "0x8C6BA0", VA = "0x1808C85A0")]
	private static VailThrowBodyEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001951 RID: 6481 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001951")]
	[Address(RVA = "0x8C8320", Offset = "0x8C6920", VA = "0x1808C8320")]
	public static VailThrowBodyEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001952 RID: 6482 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001952")]
	[Address(RVA = "0x8C8330", Offset = "0x8C6930", VA = "0x1808C8330")]
	public static VailThrowBodyEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001953 RID: 6483 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001953")]
	[Address(RVA = "0x8C8340", Offset = "0x8C6940", VA = "0x1808C8340")]
	public static VailThrowBodyEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001954 RID: 6484 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001954")]
	[Address(RVA = "0x8C8350", Offset = "0x8C6950", VA = "0x1808C8350")]
	public static VailThrowBodyEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001955 RID: 6485 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001955")]
	[Address(RVA = "0x8C8370", Offset = "0x8C6970", VA = "0x1808C8370")]
	public static VailThrowBodyEvent Create()
	{
		return null;
	}

	// Token: 0x06001956 RID: 6486 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001956")]
	[Address(RVA = "0x8C8390", Offset = "0x8C6990", VA = "0x1808C8390")]
	public static VailThrowBodyEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
