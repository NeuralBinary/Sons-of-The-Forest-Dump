using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000291 RID: 657
[Token(Token = "0x2000291")]
public class FreeFormSwitchState : Event
{
	// Token: 0x06001E15 RID: 7701 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E15")]
	[Address(RVA = "0x7F4BA0", Offset = "0x7F31A0", VA = "0x1807F4BA0")]
	public FreeFormSwitchState()
	{
	}

	// Token: 0x17000824 RID: 2084
	// (get) Token: 0x06001E16 RID: 7702 RVA: 0x00008C10 File Offset: 0x00006E10
	// (set) Token: 0x06001E17 RID: 7703 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000824")]
	public int DbVersion
	{
		[Token(Token = "0x6001E16")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001E17")]
		[Address(RVA = "0x7EB470", Offset = "0x7E9A70", VA = "0x1807EB470")]
		set
		{
		}
	}

	// Token: 0x17000825 RID: 2085
	// (get) Token: 0x06001E18 RID: 7704 RVA: 0x00008C28 File Offset: 0x00006E28
	// (set) Token: 0x06001E19 RID: 7705 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000825")]
	public int TypeID
	{
		[Token(Token = "0x6001E18")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001E19")]
		[Address(RVA = "0x7D6DC0", Offset = "0x7D53C0", VA = "0x1807D6DC0")]
		set
		{
		}
	}

	// Token: 0x17000826 RID: 2086
	// (get) Token: 0x06001E1A RID: 7706 RVA: 0x00008C40 File Offset: 0x00006E40
	// (set) Token: 0x06001E1B RID: 7707 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000826")]
	public int InstanceID
	{
		[Token(Token = "0x6001E1A")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001E1B")]
		[Address(RVA = "0x7D6E60", Offset = "0x7D5460", VA = "0x1807D6E60")]
		set
		{
		}
	}

	// Token: 0x17000827 RID: 2087
	// (get) Token: 0x06001E1C RID: 7708 RVA: 0x00008C58 File Offset: 0x00006E58
	// (set) Token: 0x06001E1D RID: 7709 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000827")]
	public bool Locked
	{
		[Token(Token = "0x6001E1C")]
		[Address(RVA = "0x7BB3B0", Offset = "0x7B99B0", VA = "0x1807BB3B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001E1D")]
		[Address(RVA = "0x7EE100", Offset = "0x7EC700", VA = "0x1807EE100")]
		set
		{
		}
	}

	// Token: 0x06001E1E RID: 7710 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E1E")]
	[Address(RVA = "0x7F4C00", Offset = "0x7F3200", VA = "0x1807F4C00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001E1F RID: 7711 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E1F")]
	[Address(RVA = "0x7F4F10", Offset = "0x7F3510", VA = "0x1807F4F10")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static FreeFormSwitchState Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E20 RID: 7712 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E20")]
	[Address(RVA = "0x7F50A0", Offset = "0x7F36A0", VA = "0x1807F50A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormSwitchState Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001E21 RID: 7713 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E21")]
	[Address(RVA = "0x7F50B0", Offset = "0x7F36B0", VA = "0x1807F50B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormSwitchState Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E22 RID: 7714 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E22")]
	[Address(RVA = "0x7F50C0", Offset = "0x7F36C0", VA = "0x1807F50C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormSwitchState Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001E23 RID: 7715 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E23")]
	[Address(RVA = "0x7F50D0", Offset = "0x7F36D0", VA = "0x1807F50D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormSwitchState Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E24 RID: 7716 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E24")]
	[Address(RVA = "0x7F50F0", Offset = "0x7F36F0", VA = "0x1807F50F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormSwitchState Raise()
	{
		return null;
	}

	// Token: 0x06001E25 RID: 7717 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E25")]
	[Address(RVA = "0x7F5110", Offset = "0x7F3710", VA = "0x1807F5110")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormSwitchState Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E26 RID: 7718 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E26")]
	[Address(RVA = "0x7F5120", Offset = "0x7F3720", VA = "0x1807F5120")]
	private static FreeFormSwitchState Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E27 RID: 7719 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E27")]
	[Address(RVA = "0x7F50A0", Offset = "0x7F36A0", VA = "0x1807F50A0")]
	public static FreeFormSwitchState Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001E28 RID: 7720 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E28")]
	[Address(RVA = "0x7F50B0", Offset = "0x7F36B0", VA = "0x1807F50B0")]
	public static FreeFormSwitchState Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E29 RID: 7721 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E29")]
	[Address(RVA = "0x7F50C0", Offset = "0x7F36C0", VA = "0x1807F50C0")]
	public static FreeFormSwitchState Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001E2A RID: 7722 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E2A")]
	[Address(RVA = "0x7F50D0", Offset = "0x7F36D0", VA = "0x1807F50D0")]
	public static FreeFormSwitchState Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001E2B RID: 7723 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E2B")]
	[Address(RVA = "0x7F50F0", Offset = "0x7F36F0", VA = "0x1807F50F0")]
	public static FreeFormSwitchState Create()
	{
		return null;
	}

	// Token: 0x06001E2C RID: 7724 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E2C")]
	[Address(RVA = "0x7F5110", Offset = "0x7F3710", VA = "0x1807F5110")]
	public static FreeFormSwitchState Create(ReliabilityModes reliability)
	{
		return null;
	}
}
