using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001E3 RID: 483
[Token(Token = "0x20001E3")]
public class WorldObjectLocatorState : Event
{
	// Token: 0x06001609 RID: 5641 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001609")]
	[Address(RVA = "0x8AB910", Offset = "0x8A9F10", VA = "0x1808AB910")]
	public WorldObjectLocatorState()
	{
	}

	// Token: 0x170006C0 RID: 1728
	// (get) Token: 0x0600160A RID: 5642 RVA: 0x000074B8 File Offset: 0x000056B8
	// (set) Token: 0x0600160B RID: 5643 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006C0")]
	public Guid Guid
	{
		[Token(Token = "0x600160A")]
		[Address(RVA = "0x886D40", Offset = "0x885340", VA = "0x180886D40")]
		get
		{
			return default(Guid);
		}
		[Token(Token = "0x600160B")]
		[Address(RVA = "0x886DB0", Offset = "0x8853B0", VA = "0x180886DB0")]
		set
		{
		}
	}

	// Token: 0x170006C1 RID: 1729
	// (get) Token: 0x0600160C RID: 5644 RVA: 0x000074D0 File Offset: 0x000056D0
	// (set) Token: 0x0600160D RID: 5645 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006C1")]
	public int State
	{
		[Token(Token = "0x600160C")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600160D")]
		[Address(RVA = "0x7D6DC0", Offset = "0x7D53C0", VA = "0x1807D6DC0")]
		set
		{
		}
	}

	// Token: 0x0600160E RID: 5646 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600160E")]
	[Address(RVA = "0x8AB970", Offset = "0x8A9F70", VA = "0x1808AB970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0600160F RID: 5647 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600160F")]
	[Address(RVA = "0x8ABA90", Offset = "0x8AA090", VA = "0x1808ABA90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static WorldObjectLocatorState Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001610 RID: 5648 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001610")]
	[Address(RVA = "0x8ABAA0", Offset = "0x8AA0A0", VA = "0x1808ABAA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static WorldObjectLocatorState Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001611 RID: 5649 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001611")]
	[Address(RVA = "0x8ABCA0", Offset = "0x8AA2A0", VA = "0x1808ABCA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static WorldObjectLocatorState Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001612 RID: 5650 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001612")]
	[Address(RVA = "0x8ABDC0", Offset = "0x8AA3C0", VA = "0x1808ABDC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static WorldObjectLocatorState Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001613 RID: 5651 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001613")]
	[Address(RVA = "0x8ABDD0", Offset = "0x8AA3D0", VA = "0x1808ABDD0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static WorldObjectLocatorState Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001614 RID: 5652 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001614")]
	[Address(RVA = "0x8ABDE0", Offset = "0x8AA3E0", VA = "0x1808ABDE0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static WorldObjectLocatorState Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001615 RID: 5653 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001615")]
	[Address(RVA = "0x8ABDF0", Offset = "0x8AA3F0", VA = "0x1808ABDF0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static WorldObjectLocatorState Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001616 RID: 5654 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001616")]
	[Address(RVA = "0x8ABE10", Offset = "0x8AA410", VA = "0x1808ABE10")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static WorldObjectLocatorState Raise()
	{
		return null;
	}

	// Token: 0x06001617 RID: 5655 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001617")]
	[Address(RVA = "0x8ABE30", Offset = "0x8AA430", VA = "0x1808ABE30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static WorldObjectLocatorState Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001618 RID: 5656 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001618")]
	[Address(RVA = "0x8ABA90", Offset = "0x8AA090", VA = "0x1808ABA90")]
	public static WorldObjectLocatorState Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001619 RID: 5657 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001619")]
	[Address(RVA = "0x8ABE40", Offset = "0x8AA440", VA = "0x1808ABE40")]
	public static WorldObjectLocatorState Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600161A RID: 5658 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600161A")]
	[Address(RVA = "0x8AC040", Offset = "0x8AA640", VA = "0x1808AC040")]
	private static WorldObjectLocatorState Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600161B RID: 5659 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600161B")]
	[Address(RVA = "0x8ABDC0", Offset = "0x8AA3C0", VA = "0x1808ABDC0")]
	public static WorldObjectLocatorState Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600161C RID: 5660 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600161C")]
	[Address(RVA = "0x8ABDD0", Offset = "0x8AA3D0", VA = "0x1808ABDD0")]
	public static WorldObjectLocatorState Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600161D RID: 5661 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600161D")]
	[Address(RVA = "0x8ABDE0", Offset = "0x8AA3E0", VA = "0x1808ABDE0")]
	public static WorldObjectLocatorState Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600161E RID: 5662 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600161E")]
	[Address(RVA = "0x8ABDF0", Offset = "0x8AA3F0", VA = "0x1808ABDF0")]
	public static WorldObjectLocatorState Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600161F RID: 5663 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600161F")]
	[Address(RVA = "0x8ABE10", Offset = "0x8AA410", VA = "0x1808ABE10")]
	public static WorldObjectLocatorState Create()
	{
		return null;
	}

	// Token: 0x06001620 RID: 5664 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001620")]
	[Address(RVA = "0x8ABE30", Offset = "0x8AA430", VA = "0x1808ABE30")]
	public static WorldObjectLocatorState Create(ReliabilityModes reliability)
	{
		return null;
	}
}
