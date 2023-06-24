using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001FE RID: 510
[Token(Token = "0x20001FE")]
public class FireLightEvent : Event
{
	// Token: 0x06001731 RID: 5937 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001731")]
	[Address(RVA = "0x8B42E0", Offset = "0x8B28E0", VA = "0x1808B42E0")]
	public FireLightEvent()
	{
	}

	// Token: 0x170006EE RID: 1774
	// (get) Token: 0x06001732 RID: 5938 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001733 RID: 5939 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006EE")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001732")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001733")]
		[Address(RVA = "0x8B4340", Offset = "0x8B2940", VA = "0x1808B4340")]
		set
		{
		}
	}

	// Token: 0x06001734 RID: 5940 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001734")]
	[Address(RVA = "0x8B4550", Offset = "0x8B2B50", VA = "0x1808B4550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001735 RID: 5941 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001735")]
	[Address(RVA = "0x8B45A0", Offset = "0x8B2BA0", VA = "0x1808B45A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FireLightEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001736 RID: 5942 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001736")]
	[Address(RVA = "0x8B45B0", Offset = "0x8B2BB0", VA = "0x1808B45B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FireLightEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001737 RID: 5943 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001737")]
	[Address(RVA = "0x8B47B0", Offset = "0x8B2DB0", VA = "0x1808B47B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static FireLightEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001738 RID: 5944 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001738")]
	[Address(RVA = "0x8B48D0", Offset = "0x8B2ED0", VA = "0x1808B48D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FireLightEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001739 RID: 5945 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001739")]
	[Address(RVA = "0x8B48E0", Offset = "0x8B2EE0", VA = "0x1808B48E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FireLightEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600173A RID: 5946 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600173A")]
	[Address(RVA = "0x8B48F0", Offset = "0x8B2EF0", VA = "0x1808B48F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FireLightEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600173B RID: 5947 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600173B")]
	[Address(RVA = "0x8B4900", Offset = "0x8B2F00", VA = "0x1808B4900")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FireLightEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600173C RID: 5948 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600173C")]
	[Address(RVA = "0x8B4920", Offset = "0x8B2F20", VA = "0x1808B4920")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FireLightEvent Raise()
	{
		return null;
	}

	// Token: 0x0600173D RID: 5949 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600173D")]
	[Address(RVA = "0x8B4940", Offset = "0x8B2F40", VA = "0x1808B4940")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FireLightEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600173E RID: 5950 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600173E")]
	[Address(RVA = "0x8B45A0", Offset = "0x8B2BA0", VA = "0x1808B45A0")]
	public static FireLightEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600173F RID: 5951 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600173F")]
	[Address(RVA = "0x8B4950", Offset = "0x8B2F50", VA = "0x1808B4950")]
	public static FireLightEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001740 RID: 5952 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001740")]
	[Address(RVA = "0x8B4B50", Offset = "0x8B3150", VA = "0x1808B4B50")]
	private static FireLightEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001741 RID: 5953 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001741")]
	[Address(RVA = "0x8B48D0", Offset = "0x8B2ED0", VA = "0x1808B48D0")]
	public static FireLightEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001742 RID: 5954 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001742")]
	[Address(RVA = "0x8B48E0", Offset = "0x8B2EE0", VA = "0x1808B48E0")]
	public static FireLightEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001743 RID: 5955 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001743")]
	[Address(RVA = "0x8B48F0", Offset = "0x8B2EF0", VA = "0x1808B48F0")]
	public static FireLightEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001744 RID: 5956 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001744")]
	[Address(RVA = "0x8B4900", Offset = "0x8B2F00", VA = "0x1808B4900")]
	public static FireLightEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001745 RID: 5957 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001745")]
	[Address(RVA = "0x8B4920", Offset = "0x8B2F20", VA = "0x1808B4920")]
	public static FireLightEvent Create()
	{
		return null;
	}

	// Token: 0x06001746 RID: 5958 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001746")]
	[Address(RVA = "0x8B4940", Offset = "0x8B2F40", VA = "0x1808B4940")]
	public static FireLightEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
