using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000141 RID: 321
[Token(Token = "0x2000141")]
public class FmodOneShotParameter : Event
{
	// Token: 0x06000EBF RID: 3775 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EBF")]
	[Address(RVA = "0x86F6F0", Offset = "0x86DCF0", VA = "0x18086F6F0")]
	public FmodOneShotParameter()
	{
	}

	// Token: 0x17000591 RID: 1425
	// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x00006240 File Offset: 0x00004440
	// (set) Token: 0x06000EC1 RID: 3777 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000591")]
	public Vector3 Position
	{
		[Token(Token = "0x6000EC0")]
		[Address(RVA = "0x7D3CB0", Offset = "0x7D22B0", VA = "0x1807D3CB0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000EC1")]
		[Address(RVA = "0x83CAC0", Offset = "0x83B0C0", VA = "0x18083CAC0")]
		set
		{
		}
	}

	// Token: 0x17000592 RID: 1426
	// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x00006258 File Offset: 0x00004458
	// (set) Token: 0x06000EC3 RID: 3779 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000592")]
	public int EventPath
	{
		[Token(Token = "0x6000EC2")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000EC3")]
		[Address(RVA = "0x7D6DC0", Offset = "0x7D53C0", VA = "0x1807D6DC0")]
		set
		{
		}
	}

	// Token: 0x17000593 RID: 1427
	// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x00006270 File Offset: 0x00004470
	// (set) Token: 0x06000EC5 RID: 3781 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000593")]
	public int Index
	{
		[Token(Token = "0x6000EC4")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000EC5")]
		[Address(RVA = "0x7D6E60", Offset = "0x7D5460", VA = "0x1807D6E60")]
		set
		{
		}
	}

	// Token: 0x17000594 RID: 1428
	// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x00006288 File Offset: 0x00004488
	// (set) Token: 0x06000EC7 RID: 3783 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000594")]
	public float Value
	{
		[Token(Token = "0x6000EC6")]
		[Address(RVA = "0x7C2150", Offset = "0x7C0750", VA = "0x1807C2150")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000EC7")]
		[Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
		set
		{
		}
	}

	// Token: 0x06000EC8 RID: 3784 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EC8")]
	[Address(RVA = "0x86F7F0", Offset = "0x86DDF0", VA = "0x18086F7F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000EC9 RID: 3785 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EC9")]
	[Address(RVA = "0x86FB10", Offset = "0x86E110", VA = "0x18086FB10")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FmodOneShotParameter Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000ECA RID: 3786 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ECA")]
	[Address(RVA = "0x86FB20", Offset = "0x86E120", VA = "0x18086FB20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FmodOneShotParameter Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000ECB RID: 3787 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ECB")]
	[Address(RVA = "0x86FD20", Offset = "0x86E320", VA = "0x18086FD20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static FmodOneShotParameter Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000ECC RID: 3788 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ECC")]
	[Address(RVA = "0x86FE40", Offset = "0x86E440", VA = "0x18086FE40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FmodOneShotParameter Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000ECD RID: 3789 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ECD")]
	[Address(RVA = "0x86FE50", Offset = "0x86E450", VA = "0x18086FE50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FmodOneShotParameter Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000ECE RID: 3790 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ECE")]
	[Address(RVA = "0x86FE60", Offset = "0x86E460", VA = "0x18086FE60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FmodOneShotParameter Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000ECF RID: 3791 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ECF")]
	[Address(RVA = "0x86FE70", Offset = "0x86E470", VA = "0x18086FE70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FmodOneShotParameter Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000ED0 RID: 3792 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ED0")]
	[Address(RVA = "0x86FE90", Offset = "0x86E490", VA = "0x18086FE90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FmodOneShotParameter Raise()
	{
		return null;
	}

	// Token: 0x06000ED1 RID: 3793 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ED1")]
	[Address(RVA = "0x86FEB0", Offset = "0x86E4B0", VA = "0x18086FEB0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FmodOneShotParameter Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000ED2 RID: 3794 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ED2")]
	[Address(RVA = "0x86FB10", Offset = "0x86E110", VA = "0x18086FB10")]
	public static FmodOneShotParameter Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000ED3 RID: 3795 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ED3")]
	[Address(RVA = "0x86FEC0", Offset = "0x86E4C0", VA = "0x18086FEC0")]
	public static FmodOneShotParameter Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000ED4 RID: 3796 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ED4")]
	[Address(RVA = "0x8700C0", Offset = "0x86E6C0", VA = "0x1808700C0")]
	private static FmodOneShotParameter Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000ED5 RID: 3797 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ED5")]
	[Address(RVA = "0x86FE40", Offset = "0x86E440", VA = "0x18086FE40")]
	public static FmodOneShotParameter Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000ED6 RID: 3798 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ED6")]
	[Address(RVA = "0x86FE50", Offset = "0x86E450", VA = "0x18086FE50")]
	public static FmodOneShotParameter Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000ED7 RID: 3799 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ED7")]
	[Address(RVA = "0x86FE60", Offset = "0x86E460", VA = "0x18086FE60")]
	public static FmodOneShotParameter Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000ED8 RID: 3800 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ED8")]
	[Address(RVA = "0x86FE70", Offset = "0x86E470", VA = "0x18086FE70")]
	public static FmodOneShotParameter Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000ED9 RID: 3801 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ED9")]
	[Address(RVA = "0x86FE90", Offset = "0x86E490", VA = "0x18086FE90")]
	public static FmodOneShotParameter Create()
	{
		return null;
	}

	// Token: 0x06000EDA RID: 3802 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EDA")]
	[Address(RVA = "0x86FEB0", Offset = "0x86E4B0", VA = "0x18086FEB0")]
	public static FmodOneShotParameter Create(ReliabilityModes reliability)
	{
		return null;
	}
}
