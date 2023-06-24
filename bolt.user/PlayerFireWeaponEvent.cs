using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001E0 RID: 480
[Token(Token = "0x20001E0")]
public class PlayerFireWeaponEvent : Event
{
	// Token: 0x060015E9 RID: 5609 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015E9")]
	[Address(RVA = "0x8AAA10", Offset = "0x8A9010", VA = "0x1808AAA10")]
	public PlayerFireWeaponEvent()
	{
	}

	// Token: 0x170006BC RID: 1724
	// (get) Token: 0x060015EA RID: 5610 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060015EB RID: 5611 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006BC")]
	public BoltEntity Target
	{
		[Token(Token = "0x60015EA")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60015EB")]
		[Address(RVA = "0x8AAA70", Offset = "0x8A9070", VA = "0x1808AAA70")]
		set
		{
		}
	}

	// Token: 0x060015EC RID: 5612 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015EC")]
	[Address(RVA = "0x8AAC80", Offset = "0x8A9280", VA = "0x1808AAC80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060015ED RID: 5613 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015ED")]
	[Address(RVA = "0x8AACD0", Offset = "0x8A92D0", VA = "0x1808AACD0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerFireWeaponEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060015EE RID: 5614 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015EE")]
	[Address(RVA = "0x8AACE0", Offset = "0x8A92E0", VA = "0x1808AACE0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerFireWeaponEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060015EF RID: 5615 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015EF")]
	[Address(RVA = "0x8AAEE0", Offset = "0x8A94E0", VA = "0x1808AAEE0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static PlayerFireWeaponEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060015F0 RID: 5616 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015F0")]
	[Address(RVA = "0x8AB000", Offset = "0x8A9600", VA = "0x1808AB000")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerFireWeaponEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060015F1 RID: 5617 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015F1")]
	[Address(RVA = "0x8AB010", Offset = "0x8A9610", VA = "0x1808AB010")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerFireWeaponEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060015F2 RID: 5618 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015F2")]
	[Address(RVA = "0x8AB020", Offset = "0x8A9620", VA = "0x1808AB020")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerFireWeaponEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060015F3 RID: 5619 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015F3")]
	[Address(RVA = "0x8AB030", Offset = "0x8A9630", VA = "0x1808AB030")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerFireWeaponEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060015F4 RID: 5620 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015F4")]
	[Address(RVA = "0x8AB050", Offset = "0x8A9650", VA = "0x1808AB050")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerFireWeaponEvent Raise()
	{
		return null;
	}

	// Token: 0x060015F5 RID: 5621 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015F5")]
	[Address(RVA = "0x8AB070", Offset = "0x8A9670", VA = "0x1808AB070")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerFireWeaponEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060015F6 RID: 5622 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015F6")]
	[Address(RVA = "0x8AACD0", Offset = "0x8A92D0", VA = "0x1808AACD0")]
	public static PlayerFireWeaponEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060015F7 RID: 5623 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015F7")]
	[Address(RVA = "0x8AB080", Offset = "0x8A9680", VA = "0x1808AB080")]
	public static PlayerFireWeaponEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060015F8 RID: 5624 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015F8")]
	[Address(RVA = "0x8AB280", Offset = "0x8A9880", VA = "0x1808AB280")]
	private static PlayerFireWeaponEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060015F9 RID: 5625 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015F9")]
	[Address(RVA = "0x8AB000", Offset = "0x8A9600", VA = "0x1808AB000")]
	public static PlayerFireWeaponEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060015FA RID: 5626 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015FA")]
	[Address(RVA = "0x8AB010", Offset = "0x8A9610", VA = "0x1808AB010")]
	public static PlayerFireWeaponEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060015FB RID: 5627 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015FB")]
	[Address(RVA = "0x8AB020", Offset = "0x8A9620", VA = "0x1808AB020")]
	public static PlayerFireWeaponEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060015FC RID: 5628 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015FC")]
	[Address(RVA = "0x8AB030", Offset = "0x8A9630", VA = "0x1808AB030")]
	public static PlayerFireWeaponEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060015FD RID: 5629 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015FD")]
	[Address(RVA = "0x8AB050", Offset = "0x8A9650", VA = "0x1808AB050")]
	public static PlayerFireWeaponEvent Create()
	{
		return null;
	}

	// Token: 0x060015FE RID: 5630 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60015FE")]
	[Address(RVA = "0x8AB070", Offset = "0x8A9670", VA = "0x1808AB070")]
	public static PlayerFireWeaponEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
