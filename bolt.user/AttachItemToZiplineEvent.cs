using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000234 RID: 564
[Token(Token = "0x2000234")]
public class AttachItemToZiplineEvent : Event
{
	// Token: 0x060019ED RID: 6637 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019ED")]
	[Address(RVA = "0x8CD610", Offset = "0x8CBC10", VA = "0x1808CD610")]
	public AttachItemToZiplineEvent()
	{
	}

	// Token: 0x17000776 RID: 1910
	// (get) Token: 0x060019EE RID: 6638 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060019EF RID: 6639 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000776")]
	public BoltEntity TargetZipline
	{
		[Token(Token = "0x60019EE")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60019EF")]
		[Address(RVA = "0x8CD670", Offset = "0x8CBC70", VA = "0x1808CD670")]
		set
		{
		}
	}

	// Token: 0x17000777 RID: 1911
	// (get) Token: 0x060019F0 RID: 6640 RVA: 0x00008100 File Offset: 0x00006300
	// (set) Token: 0x060019F1 RID: 6641 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000777")]
	public int ItemId
	{
		[Token(Token = "0x60019F0")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60019F1")]
		[Address(RVA = "0x7D8500", Offset = "0x7D6B00", VA = "0x1807D8500")]
		set
		{
		}
	}

	// Token: 0x17000778 RID: 1912
	// (get) Token: 0x060019F2 RID: 6642 RVA: 0x00008118 File Offset: 0x00006318
	// (set) Token: 0x060019F3 RID: 6643 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000778")]
	public Vector3 Position
	{
		[Token(Token = "0x60019F2")]
		[Address(RVA = "0x7B55E0", Offset = "0x7B3BE0", VA = "0x1807B55E0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60019F3")]
		[Address(RVA = "0x843CF0", Offset = "0x8422F0", VA = "0x180843CF0")]
		set
		{
		}
	}

	// Token: 0x17000779 RID: 1913
	// (get) Token: 0x060019F4 RID: 6644 RVA: 0x00008130 File Offset: 0x00006330
	// (set) Token: 0x060019F5 RID: 6645 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000779")]
	public Vector3 Direction
	{
		[Token(Token = "0x60019F4")]
		[Address(RVA = "0x7D5EB0", Offset = "0x7D44B0", VA = "0x1807D5EB0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60019F5")]
		[Address(RVA = "0x8CD880", Offset = "0x8CBE80", VA = "0x1808CD880")]
		set
		{
		}
	}

	// Token: 0x060019F6 RID: 6646 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019F6")]
	[Address(RVA = "0x8CD990", Offset = "0x8CBF90", VA = "0x1808CD990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060019F7 RID: 6647 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019F7")]
	[Address(RVA = "0x8CDC60", Offset = "0x8CC260", VA = "0x1808CDC60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AttachItemToZiplineEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060019F8 RID: 6648 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019F8")]
	[Address(RVA = "0x8CDC70", Offset = "0x8CC270", VA = "0x1808CDC70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AttachItemToZiplineEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060019F9 RID: 6649 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019F9")]
	[Address(RVA = "0x8CDE70", Offset = "0x8CC470", VA = "0x1808CDE70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static AttachItemToZiplineEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060019FA RID: 6650 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019FA")]
	[Address(RVA = "0x8CE000", Offset = "0x8CC600", VA = "0x1808CE000")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AttachItemToZiplineEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060019FB RID: 6651 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019FB")]
	[Address(RVA = "0x8CE010", Offset = "0x8CC610", VA = "0x1808CE010")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AttachItemToZiplineEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060019FC RID: 6652 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019FC")]
	[Address(RVA = "0x8CE020", Offset = "0x8CC620", VA = "0x1808CE020")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AttachItemToZiplineEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060019FD RID: 6653 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019FD")]
	[Address(RVA = "0x8CE030", Offset = "0x8CC630", VA = "0x1808CE030")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AttachItemToZiplineEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060019FE RID: 6654 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019FE")]
	[Address(RVA = "0x8CE050", Offset = "0x8CC650", VA = "0x1808CE050")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AttachItemToZiplineEvent Raise()
	{
		return null;
	}

	// Token: 0x060019FF RID: 6655 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019FF")]
	[Address(RVA = "0x8CE070", Offset = "0x8CC670", VA = "0x1808CE070")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AttachItemToZiplineEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A00 RID: 6656 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A00")]
	[Address(RVA = "0x8CDC60", Offset = "0x8CC260", VA = "0x1808CDC60")]
	public static AttachItemToZiplineEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001A01 RID: 6657 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A01")]
	[Address(RVA = "0x8CE080", Offset = "0x8CC680", VA = "0x1808CE080")]
	public static AttachItemToZiplineEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001A02 RID: 6658 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A02")]
	[Address(RVA = "0x8CE280", Offset = "0x8CC880", VA = "0x1808CE280")]
	private static AttachItemToZiplineEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A03 RID: 6659 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A03")]
	[Address(RVA = "0x8CE000", Offset = "0x8CC600", VA = "0x1808CE000")]
	public static AttachItemToZiplineEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001A04 RID: 6660 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A04")]
	[Address(RVA = "0x8CE010", Offset = "0x8CC610", VA = "0x1808CE010")]
	public static AttachItemToZiplineEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A05 RID: 6661 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A05")]
	[Address(RVA = "0x8CE020", Offset = "0x8CC620", VA = "0x1808CE020")]
	public static AttachItemToZiplineEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001A06 RID: 6662 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A06")]
	[Address(RVA = "0x8CE030", Offset = "0x8CC630", VA = "0x1808CE030")]
	public static AttachItemToZiplineEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001A07 RID: 6663 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A07")]
	[Address(RVA = "0x8CE050", Offset = "0x8CC650", VA = "0x1808CE050")]
	public static AttachItemToZiplineEvent Create()
	{
		return null;
	}

	// Token: 0x06001A08 RID: 6664 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A08")]
	[Address(RVA = "0x8CE070", Offset = "0x8CC670", VA = "0x1808CE070")]
	public static AttachItemToZiplineEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
