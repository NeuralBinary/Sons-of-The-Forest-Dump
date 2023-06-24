using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200029A RID: 666
[Token(Token = "0x200029A")]
public class CookingSpotIsBusyEvent : Event
{
	// Token: 0x06001E79 RID: 7801 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E79")]
	[Address(RVA = "0x7F7B80", Offset = "0x7F6180", VA = "0x1807F7B80")]
	public CookingSpotIsBusyEvent()
	{
	}

	// Token: 0x17000836 RID: 2102
	// (get) Token: 0x06001E7A RID: 7802 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001E7B RID: 7803 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000836")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001E7A")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001E7B")]
		[Address(RVA = "0x7F7BE0", Offset = "0x7F61E0", VA = "0x1807F7BE0")]
		set
		{
		}
	}

	// Token: 0x17000837 RID: 2103
	// (get) Token: 0x06001E7C RID: 7804 RVA: 0x00008D48 File Offset: 0x00006F48
	// (set) Token: 0x06001E7D RID: 7805 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000837")]
	public bool IsBusy
	{
		[Token(Token = "0x6001E7C")]
		[Address(RVA = "0x7B5490", Offset = "0x7B3A90", VA = "0x1807B5490")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001E7D")]
		[Address(RVA = "0x7E82E0", Offset = "0x7E68E0", VA = "0x1807E82E0")]
		set
		{
		}
	}

	// Token: 0x06001E7E RID: 7806 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E7E")]
	[Address(RVA = "0x7F7DF0", Offset = "0x7F63F0", VA = "0x1807F7DF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001E7F RID: 7807 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E7F")]
	[Address(RVA = "0x7F7EB0", Offset = "0x7F64B0", VA = "0x1807F7EB0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingSpotIsBusyEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001E80 RID: 7808 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E80")]
	[Address(RVA = "0x7F7EC0", Offset = "0x7F64C0", VA = "0x1807F7EC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingSpotIsBusyEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001E81 RID: 7809 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E81")]
	[Address(RVA = "0x7F80C0", Offset = "0x7F66C0", VA = "0x1807F80C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static CookingSpotIsBusyEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E82 RID: 7810 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E82")]
	[Address(RVA = "0x7F81E0", Offset = "0x7F67E0", VA = "0x1807F81E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingSpotIsBusyEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001E83 RID: 7811 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E83")]
	[Address(RVA = "0x7F81F0", Offset = "0x7F67F0", VA = "0x1807F81F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingSpotIsBusyEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E84 RID: 7812 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E84")]
	[Address(RVA = "0x7F8200", Offset = "0x7F6800", VA = "0x1807F8200")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingSpotIsBusyEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001E85 RID: 7813 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E85")]
	[Address(RVA = "0x7F8210", Offset = "0x7F6810", VA = "0x1807F8210")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingSpotIsBusyEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E86 RID: 7814 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E86")]
	[Address(RVA = "0x7F8230", Offset = "0x7F6830", VA = "0x1807F8230")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingSpotIsBusyEvent Raise()
	{
		return null;
	}

	// Token: 0x06001E87 RID: 7815 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E87")]
	[Address(RVA = "0x7F8250", Offset = "0x7F6850", VA = "0x1807F8250")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingSpotIsBusyEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E88 RID: 7816 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E88")]
	[Address(RVA = "0x7F7EB0", Offset = "0x7F64B0", VA = "0x1807F7EB0")]
	public static CookingSpotIsBusyEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001E89 RID: 7817 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E89")]
	[Address(RVA = "0x7F8260", Offset = "0x7F6860", VA = "0x1807F8260")]
	public static CookingSpotIsBusyEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001E8A RID: 7818 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E8A")]
	[Address(RVA = "0x7F8460", Offset = "0x7F6A60", VA = "0x1807F8460")]
	private static CookingSpotIsBusyEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E8B RID: 7819 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E8B")]
	[Address(RVA = "0x7F81E0", Offset = "0x7F67E0", VA = "0x1807F81E0")]
	public static CookingSpotIsBusyEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001E8C RID: 7820 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E8C")]
	[Address(RVA = "0x7F81F0", Offset = "0x7F67F0", VA = "0x1807F81F0")]
	public static CookingSpotIsBusyEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E8D RID: 7821 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E8D")]
	[Address(RVA = "0x7F8200", Offset = "0x7F6800", VA = "0x1807F8200")]
	public static CookingSpotIsBusyEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001E8E RID: 7822 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E8E")]
	[Address(RVA = "0x7F8210", Offset = "0x7F6810", VA = "0x1807F8210")]
	public static CookingSpotIsBusyEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E8F RID: 7823 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E8F")]
	[Address(RVA = "0x7F8230", Offset = "0x7F6830", VA = "0x1807F8230")]
	public static CookingSpotIsBusyEvent Create()
	{
		return null;
	}

	// Token: 0x06001E90 RID: 7824 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E90")]
	[Address(RVA = "0x7F8250", Offset = "0x7F6850", VA = "0x1807F8250")]
	public static CookingSpotIsBusyEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
