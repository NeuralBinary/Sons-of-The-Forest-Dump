using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000297 RID: 663
[Token(Token = "0x2000297")]
public class VailAttachItemEvent : Event
{
	// Token: 0x06001E55 RID: 7765 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E55")]
	[Address(RVA = "0x7F67C0", Offset = "0x7F4DC0", VA = "0x1807F67C0")]
	public VailAttachItemEvent()
	{
	}

	// Token: 0x17000830 RID: 2096
	// (get) Token: 0x06001E56 RID: 7766 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001E57 RID: 7767 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000830")]
	public BoltEntity TargetActor
	{
		[Token(Token = "0x6001E56")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001E57")]
		[Address(RVA = "0x7F6820", Offset = "0x7F4E20", VA = "0x1807F6820")]
		set
		{
		}
	}

	// Token: 0x17000831 RID: 2097
	// (get) Token: 0x06001E58 RID: 7768 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001E59 RID: 7769 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000831")]
	public BoltEntity TargetItem
	{
		[Token(Token = "0x6001E58")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001E59")]
		[Address(RVA = "0x7F6A30", Offset = "0x7F5030", VA = "0x1807F6A30")]
		set
		{
		}
	}

	// Token: 0x17000832 RID: 2098
	// (get) Token: 0x06001E5A RID: 7770 RVA: 0x00008D00 File Offset: 0x00006F00
	// (set) Token: 0x06001E5B RID: 7771 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000832")]
	public bool Attached
	{
		[Token(Token = "0x6001E5A")]
		[Address(RVA = "0x7B8B00", Offset = "0x7B7100", VA = "0x1807B8B00")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001E5B")]
		[Address(RVA = "0x7DD620", Offset = "0x7DBC20", VA = "0x1807DD620")]
		set
		{
		}
	}

	// Token: 0x06001E5C RID: 7772 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E5C")]
	[Address(RVA = "0x7F6C40", Offset = "0x7F5240", VA = "0x1807F6C40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001E5D RID: 7773 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E5D")]
	[Address(RVA = "0x7F6D30", Offset = "0x7F5330", VA = "0x1807F6D30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailAttachItemEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001E5E RID: 7774 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E5E")]
	[Address(RVA = "0x7F6D40", Offset = "0x7F5340", VA = "0x1807F6D40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailAttachItemEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001E5F RID: 7775 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E5F")]
	[Address(RVA = "0x7F6F40", Offset = "0x7F5540", VA = "0x1807F6F40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static VailAttachItemEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E60 RID: 7776 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E60")]
	[Address(RVA = "0x7F7060", Offset = "0x7F5660", VA = "0x1807F7060")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailAttachItemEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001E61 RID: 7777 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E61")]
	[Address(RVA = "0x7F7070", Offset = "0x7F5670", VA = "0x1807F7070")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailAttachItemEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E62 RID: 7778 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E62")]
	[Address(RVA = "0x7F7080", Offset = "0x7F5680", VA = "0x1807F7080")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailAttachItemEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001E63 RID: 7779 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E63")]
	[Address(RVA = "0x7F7090", Offset = "0x7F5690", VA = "0x1807F7090")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailAttachItemEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E64 RID: 7780 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E64")]
	[Address(RVA = "0x7F70B0", Offset = "0x7F56B0", VA = "0x1807F70B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailAttachItemEvent Raise()
	{
		return null;
	}

	// Token: 0x06001E65 RID: 7781 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E65")]
	[Address(RVA = "0x7F70D0", Offset = "0x7F56D0", VA = "0x1807F70D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static VailAttachItemEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E66 RID: 7782 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E66")]
	[Address(RVA = "0x7F6D30", Offset = "0x7F5330", VA = "0x1807F6D30")]
	public static VailAttachItemEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001E67 RID: 7783 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E67")]
	[Address(RVA = "0x7F70E0", Offset = "0x7F56E0", VA = "0x1807F70E0")]
	public static VailAttachItemEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001E68 RID: 7784 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E68")]
	[Address(RVA = "0x7F72E0", Offset = "0x7F58E0", VA = "0x1807F72E0")]
	private static VailAttachItemEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E69 RID: 7785 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E69")]
	[Address(RVA = "0x7F7060", Offset = "0x7F5660", VA = "0x1807F7060")]
	public static VailAttachItemEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001E6A RID: 7786 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E6A")]
	[Address(RVA = "0x7F7070", Offset = "0x7F5670", VA = "0x1807F7070")]
	public static VailAttachItemEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E6B RID: 7787 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E6B")]
	[Address(RVA = "0x7F7080", Offset = "0x7F5680", VA = "0x1807F7080")]
	public static VailAttachItemEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001E6C RID: 7788 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E6C")]
	[Address(RVA = "0x7F7090", Offset = "0x7F5690", VA = "0x1807F7090")]
	public static VailAttachItemEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E6D RID: 7789 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E6D")]
	[Address(RVA = "0x7F70B0", Offset = "0x7F56B0", VA = "0x1807F70B0")]
	public static VailAttachItemEvent Create()
	{
		return null;
	}

	// Token: 0x06001E6E RID: 7790 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E6E")]
	[Address(RVA = "0x7F70D0", Offset = "0x7F56D0", VA = "0x1807F70D0")]
	public static VailAttachItemEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
