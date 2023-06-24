using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200027F RID: 639
[Token(Token = "0x200027F")]
public class FreeFormSwitchLightState : Event
{
	// Token: 0x06001D55 RID: 7509 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D55")]
	[Address(RVA = "0x7EF120", Offset = "0x7ED720", VA = "0x1807EF120")]
	public FreeFormSwitchLightState()
	{
	}

	// Token: 0x17000806 RID: 2054
	// (get) Token: 0x06001D56 RID: 7510 RVA: 0x00008A30 File Offset: 0x00006C30
	// (set) Token: 0x06001D57 RID: 7511 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000806")]
	public int DbVersion
	{
		[Token(Token = "0x6001D56")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001D57")]
		[Address(RVA = "0x7EB470", Offset = "0x7E9A70", VA = "0x1807EB470")]
		set
		{
		}
	}

	// Token: 0x17000807 RID: 2055
	// (get) Token: 0x06001D58 RID: 7512 RVA: 0x00008A48 File Offset: 0x00006C48
	// (set) Token: 0x06001D59 RID: 7513 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000807")]
	public int InstanceID
	{
		[Token(Token = "0x6001D58")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001D59")]
		[Address(RVA = "0x7D6DC0", Offset = "0x7D53C0", VA = "0x1807D6DC0")]
		set
		{
		}
	}

	// Token: 0x17000808 RID: 2056
	// (get) Token: 0x06001D5A RID: 7514 RVA: 0x00008A60 File Offset: 0x00006C60
	// (set) Token: 0x06001D5B RID: 7515 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000808")]
	public bool IsOn
	{
		[Token(Token = "0x6001D5A")]
		[Address(RVA = "0x7B8B00", Offset = "0x7B7100", VA = "0x1807B8B00")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001D5B")]
		[Address(RVA = "0x7DD620", Offset = "0x7DBC20", VA = "0x1807DD620")]
		set
		{
		}
	}

	// Token: 0x06001D5C RID: 7516 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D5C")]
	[Address(RVA = "0x7EF180", Offset = "0x7ED780", VA = "0x1807EF180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001D5D RID: 7517 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D5D")]
	[Address(RVA = "0x7EF310", Offset = "0x7ED910", VA = "0x1807EF310")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static FreeFormSwitchLightState Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001D5E RID: 7518 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D5E")]
	[Address(RVA = "0x7EF4A0", Offset = "0x7EDAA0", VA = "0x1807EF4A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormSwitchLightState Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001D5F RID: 7519 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D5F")]
	[Address(RVA = "0x7EF4B0", Offset = "0x7EDAB0", VA = "0x1807EF4B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormSwitchLightState Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001D60 RID: 7520 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D60")]
	[Address(RVA = "0x7EF4C0", Offset = "0x7EDAC0", VA = "0x1807EF4C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormSwitchLightState Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001D61 RID: 7521 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D61")]
	[Address(RVA = "0x7EF4D0", Offset = "0x7EDAD0", VA = "0x1807EF4D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormSwitchLightState Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001D62 RID: 7522 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D62")]
	[Address(RVA = "0x7EF4F0", Offset = "0x7EDAF0", VA = "0x1807EF4F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormSwitchLightState Raise()
	{
		return null;
	}

	// Token: 0x06001D63 RID: 7523 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D63")]
	[Address(RVA = "0x7EF510", Offset = "0x7EDB10", VA = "0x1807EF510")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormSwitchLightState Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001D64 RID: 7524 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D64")]
	[Address(RVA = "0x7EF520", Offset = "0x7EDB20", VA = "0x1807EF520")]
	private static FreeFormSwitchLightState Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001D65 RID: 7525 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D65")]
	[Address(RVA = "0x7EF4A0", Offset = "0x7EDAA0", VA = "0x1807EF4A0")]
	public static FreeFormSwitchLightState Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001D66 RID: 7526 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D66")]
	[Address(RVA = "0x7EF4B0", Offset = "0x7EDAB0", VA = "0x1807EF4B0")]
	public static FreeFormSwitchLightState Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001D67 RID: 7527 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D67")]
	[Address(RVA = "0x7EF4C0", Offset = "0x7EDAC0", VA = "0x1807EF4C0")]
	public static FreeFormSwitchLightState Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001D68 RID: 7528 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D68")]
	[Address(RVA = "0x7EF4D0", Offset = "0x7EDAD0", VA = "0x1807EF4D0")]
	public static FreeFormSwitchLightState Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001D69 RID: 7529 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D69")]
	[Address(RVA = "0x7EF4F0", Offset = "0x7EDAF0", VA = "0x1807EF4F0")]
	public static FreeFormSwitchLightState Create()
	{
		return null;
	}

	// Token: 0x06001D6A RID: 7530 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D6A")]
	[Address(RVA = "0x7EF510", Offset = "0x7EDB10", VA = "0x1807EF510")]
	public static FreeFormSwitchLightState Create(ReliabilityModes reliability)
	{
		return null;
	}
}
