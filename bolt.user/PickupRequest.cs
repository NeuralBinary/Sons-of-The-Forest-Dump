using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200015F RID: 351
[Token(Token = "0x200015F")]
public class PickupRequest : Event
{
	// Token: 0x06001013 RID: 4115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001013")]
	[Address(RVA = "0x87A450", Offset = "0x878A50", VA = "0x18087A450")]
	public PickupRequest()
	{
	}

	// Token: 0x170005C3 RID: 1475
	// (get) Token: 0x06001014 RID: 4116 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001015 RID: 4117 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005C3")]
	public BoltEntity Item
	{
		[Token(Token = "0x6001014")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001015")]
		[Address(RVA = "0x87A4B0", Offset = "0x878AB0", VA = "0x18087A4B0")]
		set
		{
		}
	}

	// Token: 0x170005C4 RID: 1476
	// (get) Token: 0x06001016 RID: 4118 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001017 RID: 4119 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005C4")]
	public BoltEntity Player
	{
		[Token(Token = "0x6001016")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001017")]
		[Address(RVA = "0x87A6C0", Offset = "0x878CC0", VA = "0x18087A6C0")]
		set
		{
		}
	}

	// Token: 0x06001018 RID: 4120 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001018")]
	[Address(RVA = "0x87A8D0", Offset = "0x878ED0", VA = "0x18087A8D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001019 RID: 4121 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001019")]
	[Address(RVA = "0x87AA40", Offset = "0x879040", VA = "0x18087AA40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupRequest Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600101A RID: 4122 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600101A")]
	[Address(RVA = "0x87AA50", Offset = "0x879050", VA = "0x18087AA50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupRequest Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600101B RID: 4123 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600101B")]
	[Address(RVA = "0x87AC50", Offset = "0x879250", VA = "0x18087AC50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static PickupRequest Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600101C RID: 4124 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600101C")]
	[Address(RVA = "0x87AD70", Offset = "0x879370", VA = "0x18087AD70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupRequest Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600101D RID: 4125 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600101D")]
	[Address(RVA = "0x87AD80", Offset = "0x879380", VA = "0x18087AD80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupRequest Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600101E RID: 4126 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600101E")]
	[Address(RVA = "0x87AD90", Offset = "0x879390", VA = "0x18087AD90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupRequest Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600101F RID: 4127 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600101F")]
	[Address(RVA = "0x87ADA0", Offset = "0x8793A0", VA = "0x18087ADA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupRequest Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001020 RID: 4128 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001020")]
	[Address(RVA = "0x87ADC0", Offset = "0x8793C0", VA = "0x18087ADC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupRequest Raise()
	{
		return null;
	}

	// Token: 0x06001021 RID: 4129 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001021")]
	[Address(RVA = "0x87ADE0", Offset = "0x8793E0", VA = "0x18087ADE0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PickupRequest Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001022 RID: 4130 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001022")]
	[Address(RVA = "0x87AA40", Offset = "0x879040", VA = "0x18087AA40")]
	public static PickupRequest Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001023 RID: 4131 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001023")]
	[Address(RVA = "0x87ADF0", Offset = "0x8793F0", VA = "0x18087ADF0")]
	public static PickupRequest Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001024 RID: 4132 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001024")]
	[Address(RVA = "0x87AFF0", Offset = "0x8795F0", VA = "0x18087AFF0")]
	private static PickupRequest Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001025 RID: 4133 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001025")]
	[Address(RVA = "0x87AD70", Offset = "0x879370", VA = "0x18087AD70")]
	public static PickupRequest Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001026 RID: 4134 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001026")]
	[Address(RVA = "0x87AD80", Offset = "0x879380", VA = "0x18087AD80")]
	public static PickupRequest Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001027 RID: 4135 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001027")]
	[Address(RVA = "0x87AD90", Offset = "0x879390", VA = "0x18087AD90")]
	public static PickupRequest Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001028 RID: 4136 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001028")]
	[Address(RVA = "0x87ADA0", Offset = "0x8793A0", VA = "0x18087ADA0")]
	public static PickupRequest Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001029 RID: 4137 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001029")]
	[Address(RVA = "0x87ADC0", Offset = "0x8793C0", VA = "0x18087ADC0")]
	public static PickupRequest Create()
	{
		return null;
	}

	// Token: 0x0600102A RID: 4138 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600102A")]
	[Address(RVA = "0x87ADE0", Offset = "0x8793E0", VA = "0x18087ADE0")]
	public static PickupRequest Create(ReliabilityModes reliability)
	{
		return null;
	}
}
