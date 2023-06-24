using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020002A3 RID: 675
[Token(Token = "0x20002A3")]
public class CookingUpdateVolumeEvent : Event
{
	// Token: 0x06001EDD RID: 7901 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EDD")]
	[Address(RVA = "0x7FAB80", Offset = "0x7F9180", VA = "0x1807FAB80")]
	public CookingUpdateVolumeEvent()
	{
	}

	// Token: 0x17000844 RID: 2116
	// (get) Token: 0x06001EDE RID: 7902 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001EDF RID: 7903 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000844")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001EDE")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001EDF")]
		[Address(RVA = "0x7FABE0", Offset = "0x7F91E0", VA = "0x1807FABE0")]
		set
		{
		}
	}

	// Token: 0x17000845 RID: 2117
	// (get) Token: 0x06001EE0 RID: 7904 RVA: 0x00008E08 File Offset: 0x00007008
	// (set) Token: 0x06001EE1 RID: 7905 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000845")]
	public float Amount
	{
		[Token(Token = "0x6001EE0")]
		[Address(RVA = "0x7B78E0", Offset = "0x7B5EE0", VA = "0x1807B78E0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001EE1")]
		[Address(RVA = "0x7FADF0", Offset = "0x7F93F0", VA = "0x1807FADF0")]
		set
		{
		}
	}

	// Token: 0x06001EE2 RID: 7906 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EE2")]
	[Address(RVA = "0x7FAEB0", Offset = "0x7F94B0", VA = "0x1807FAEB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001EE3 RID: 7907 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EE3")]
	[Address(RVA = "0x7FAF80", Offset = "0x7F9580", VA = "0x1807FAF80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingUpdateVolumeEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001EE4 RID: 7908 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EE4")]
	[Address(RVA = "0x7FAF90", Offset = "0x7F9590", VA = "0x1807FAF90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingUpdateVolumeEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001EE5 RID: 7909 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EE5")]
	[Address(RVA = "0x7FB190", Offset = "0x7F9790", VA = "0x1807FB190")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static CookingUpdateVolumeEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001EE6 RID: 7910 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EE6")]
	[Address(RVA = "0x7FB2B0", Offset = "0x7F98B0", VA = "0x1807FB2B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingUpdateVolumeEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001EE7 RID: 7911 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EE7")]
	[Address(RVA = "0x7FB2C0", Offset = "0x7F98C0", VA = "0x1807FB2C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingUpdateVolumeEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001EE8 RID: 7912 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EE8")]
	[Address(RVA = "0x7FB2D0", Offset = "0x7F98D0", VA = "0x1807FB2D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingUpdateVolumeEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001EE9 RID: 7913 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EE9")]
	[Address(RVA = "0x7FB2E0", Offset = "0x7F98E0", VA = "0x1807FB2E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingUpdateVolumeEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001EEA RID: 7914 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EEA")]
	[Address(RVA = "0x7FB300", Offset = "0x7F9900", VA = "0x1807FB300")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingUpdateVolumeEvent Raise()
	{
		return null;
	}

	// Token: 0x06001EEB RID: 7915 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EEB")]
	[Address(RVA = "0x7FB320", Offset = "0x7F9920", VA = "0x1807FB320")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static CookingUpdateVolumeEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001EEC RID: 7916 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EEC")]
	[Address(RVA = "0x7FAF80", Offset = "0x7F9580", VA = "0x1807FAF80")]
	public static CookingUpdateVolumeEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001EED RID: 7917 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EED")]
	[Address(RVA = "0x7FB330", Offset = "0x7F9930", VA = "0x1807FB330")]
	public static CookingUpdateVolumeEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001EEE RID: 7918 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EEE")]
	[Address(RVA = "0x7FB530", Offset = "0x7F9B30", VA = "0x1807FB530")]
	private static CookingUpdateVolumeEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001EEF RID: 7919 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EEF")]
	[Address(RVA = "0x7FB2B0", Offset = "0x7F98B0", VA = "0x1807FB2B0")]
	public static CookingUpdateVolumeEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001EF0 RID: 7920 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EF0")]
	[Address(RVA = "0x7FB2C0", Offset = "0x7F98C0", VA = "0x1807FB2C0")]
	public static CookingUpdateVolumeEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001EF1 RID: 7921 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EF1")]
	[Address(RVA = "0x7FB2D0", Offset = "0x7F98D0", VA = "0x1807FB2D0")]
	public static CookingUpdateVolumeEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001EF2 RID: 7922 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EF2")]
	[Address(RVA = "0x7FB2E0", Offset = "0x7F98E0", VA = "0x1807FB2E0")]
	public static CookingUpdateVolumeEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001EF3 RID: 7923 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EF3")]
	[Address(RVA = "0x7FB300", Offset = "0x7F9900", VA = "0x1807FB300")]
	public static CookingUpdateVolumeEvent Create()
	{
		return null;
	}

	// Token: 0x06001EF4 RID: 7924 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001EF4")]
	[Address(RVA = "0x7FB320", Offset = "0x7F9920", VA = "0x1807FB320")]
	public static CookingUpdateVolumeEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
