using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001EC RID: 492
[Token(Token = "0x20001EC")]
public class StorageContainerOpened : Event
{
	// Token: 0x0600166F RID: 5743 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600166F")]
	[Address(RVA = "0x8AEA50", Offset = "0x8AD050", VA = "0x1808AEA50")]
	public StorageContainerOpened()
	{
	}

	// Token: 0x170006D1 RID: 1745
	// (get) Token: 0x06001670 RID: 5744 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001671 RID: 5745 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006D1")]
	public BoltEntity ContainerEntity
	{
		[Token(Token = "0x6001670")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001671")]
		[Address(RVA = "0x8AEAB0", Offset = "0x8AD0B0", VA = "0x1808AEAB0")]
		set
		{
		}
	}

	// Token: 0x170006D2 RID: 1746
	// (get) Token: 0x06001672 RID: 5746 RVA: 0x000075D8 File Offset: 0x000057D8
	// (set) Token: 0x06001673 RID: 5747 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006D2")]
	public int ContentsSeed
	{
		[Token(Token = "0x6001672")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001673")]
		[Address(RVA = "0x7D6DC0", Offset = "0x7D53C0", VA = "0x1807D6DC0")]
		set
		{
		}
	}

	// Token: 0x06001674 RID: 5748 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001674")]
	[Address(RVA = "0x8AECC0", Offset = "0x8AD2C0", VA = "0x1808AECC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001675 RID: 5749 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001675")]
	[Address(RVA = "0x8AED80", Offset = "0x8AD380", VA = "0x1808AED80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StorageContainerOpened Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001676 RID: 5750 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001676")]
	[Address(RVA = "0x8AED90", Offset = "0x8AD390", VA = "0x1808AED90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StorageContainerOpened Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001677 RID: 5751 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001677")]
	[Address(RVA = "0x8AEF90", Offset = "0x8AD590", VA = "0x1808AEF90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static StorageContainerOpened Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001678 RID: 5752 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001678")]
	[Address(RVA = "0x8AF0B0", Offset = "0x8AD6B0", VA = "0x1808AF0B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StorageContainerOpened Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001679 RID: 5753 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001679")]
	[Address(RVA = "0x8AF0C0", Offset = "0x8AD6C0", VA = "0x1808AF0C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StorageContainerOpened Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600167A RID: 5754 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600167A")]
	[Address(RVA = "0x8AF0D0", Offset = "0x8AD6D0", VA = "0x1808AF0D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StorageContainerOpened Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600167B RID: 5755 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600167B")]
	[Address(RVA = "0x8AF0E0", Offset = "0x8AD6E0", VA = "0x1808AF0E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StorageContainerOpened Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600167C RID: 5756 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600167C")]
	[Address(RVA = "0x8AF100", Offset = "0x8AD700", VA = "0x1808AF100")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StorageContainerOpened Raise()
	{
		return null;
	}

	// Token: 0x0600167D RID: 5757 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600167D")]
	[Address(RVA = "0x8AF120", Offset = "0x8AD720", VA = "0x1808AF120")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static StorageContainerOpened Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600167E RID: 5758 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600167E")]
	[Address(RVA = "0x8AED80", Offset = "0x8AD380", VA = "0x1808AED80")]
	public static StorageContainerOpened Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600167F RID: 5759 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600167F")]
	[Address(RVA = "0x8AF130", Offset = "0x8AD730", VA = "0x1808AF130")]
	public static StorageContainerOpened Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001680 RID: 5760 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001680")]
	[Address(RVA = "0x8AF330", Offset = "0x8AD930", VA = "0x1808AF330")]
	private static StorageContainerOpened Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001681 RID: 5761 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001681")]
	[Address(RVA = "0x8AF0B0", Offset = "0x8AD6B0", VA = "0x1808AF0B0")]
	public static StorageContainerOpened Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001682 RID: 5762 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001682")]
	[Address(RVA = "0x8AF0C0", Offset = "0x8AD6C0", VA = "0x1808AF0C0")]
	public static StorageContainerOpened Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001683 RID: 5763 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001683")]
	[Address(RVA = "0x8AF0D0", Offset = "0x8AD6D0", VA = "0x1808AF0D0")]
	public static StorageContainerOpened Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001684 RID: 5764 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001684")]
	[Address(RVA = "0x8AF0E0", Offset = "0x8AD6E0", VA = "0x1808AF0E0")]
	public static StorageContainerOpened Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001685 RID: 5765 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001685")]
	[Address(RVA = "0x8AF100", Offset = "0x8AD700", VA = "0x1808AF100")]
	public static StorageContainerOpened Create()
	{
		return null;
	}

	// Token: 0x06001686 RID: 5766 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001686")]
	[Address(RVA = "0x8AF120", Offset = "0x8AD720", VA = "0x1808AF120")]
	public static StorageContainerOpened Create(ReliabilityModes reliability)
	{
		return null;
	}
}
