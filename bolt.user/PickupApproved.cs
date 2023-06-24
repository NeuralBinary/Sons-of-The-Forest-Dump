using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000162 RID: 354
[Token(Token = "0x2000162")]
public class PickupApproved : Event
{
	// Token: 0x06001035 RID: 4149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001035")]
	[Address(RVA = "0x87B780", Offset = "0x879D80", VA = "0x18087B780")]
	public PickupApproved()
	{
	}

	// Token: 0x170005C8 RID: 1480
	// (get) Token: 0x06001036 RID: 4150 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001037 RID: 4151 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005C8")]
	public BoltEntity Item
	{
		[Token(Token = "0x6001036")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001037")]
		[Address(RVA = "0x87B7E0", Offset = "0x879DE0", VA = "0x18087B7E0")]
		set
		{
		}
	}

	// Token: 0x170005C9 RID: 1481
	// (get) Token: 0x06001038 RID: 4152 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001039 RID: 4153 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005C9")]
	public BoltEntity Player
	{
		[Token(Token = "0x6001038")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001039")]
		[Address(RVA = "0x87B9F0", Offset = "0x879FF0", VA = "0x18087B9F0")]
		set
		{
		}
	}

	// Token: 0x0600103A RID: 4154 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600103A")]
	[Address(RVA = "0x87BC00", Offset = "0x87A200", VA = "0x18087BC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0600103B RID: 4155 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600103B")]
	[Address(RVA = "0x87BD70", Offset = "0x87A370", VA = "0x18087BD70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupApproved Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600103C RID: 4156 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600103C")]
	[Address(RVA = "0x87BD80", Offset = "0x87A380", VA = "0x18087BD80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupApproved Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600103D RID: 4157 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600103D")]
	[Address(RVA = "0x87BF80", Offset = "0x87A580", VA = "0x18087BF80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static PickupApproved Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600103E RID: 4158 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600103E")]
	[Address(RVA = "0x87C0A0", Offset = "0x87A6A0", VA = "0x18087C0A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupApproved Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600103F RID: 4159 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600103F")]
	[Address(RVA = "0x87C0B0", Offset = "0x87A6B0", VA = "0x18087C0B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupApproved Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001040 RID: 4160 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001040")]
	[Address(RVA = "0x87C0C0", Offset = "0x87A6C0", VA = "0x18087C0C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupApproved Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001041 RID: 4161 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001041")]
	[Address(RVA = "0x87C0D0", Offset = "0x87A6D0", VA = "0x18087C0D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupApproved Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001042 RID: 4162 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001042")]
	[Address(RVA = "0x87C0F0", Offset = "0x87A6F0", VA = "0x18087C0F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupApproved Raise()
	{
		return null;
	}

	// Token: 0x06001043 RID: 4163 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001043")]
	[Address(RVA = "0x87C110", Offset = "0x87A710", VA = "0x18087C110")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupApproved Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001044 RID: 4164 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001044")]
	[Address(RVA = "0x87BD70", Offset = "0x87A370", VA = "0x18087BD70")]
	public static PickupApproved Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001045 RID: 4165 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001045")]
	[Address(RVA = "0x87C120", Offset = "0x87A720", VA = "0x18087C120")]
	public static PickupApproved Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001046 RID: 4166 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001046")]
	[Address(RVA = "0x87C320", Offset = "0x87A920", VA = "0x18087C320")]
	private static PickupApproved Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001047 RID: 4167 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001047")]
	[Address(RVA = "0x87C0A0", Offset = "0x87A6A0", VA = "0x18087C0A0")]
	public static PickupApproved Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001048 RID: 4168 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001048")]
	[Address(RVA = "0x87C0B0", Offset = "0x87A6B0", VA = "0x18087C0B0")]
	public static PickupApproved Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001049 RID: 4169 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001049")]
	[Address(RVA = "0x87C0C0", Offset = "0x87A6C0", VA = "0x18087C0C0")]
	public static PickupApproved Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600104A RID: 4170 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600104A")]
	[Address(RVA = "0x87C0D0", Offset = "0x87A6D0", VA = "0x18087C0D0")]
	public static PickupApproved Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600104B RID: 4171 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600104B")]
	[Address(RVA = "0x87C0F0", Offset = "0x87A6F0", VA = "0x18087C0F0")]
	public static PickupApproved Create()
	{
		return null;
	}

	// Token: 0x0600104C RID: 4172 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600104C")]
	[Address(RVA = "0x87C110", Offset = "0x87A710", VA = "0x18087C110")]
	public static PickupApproved Create(ReliabilityModes reliability)
	{
		return null;
	}
}
