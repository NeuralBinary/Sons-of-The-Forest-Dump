using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000249 RID: 585
[Token(Token = "0x2000249")]
public class ChangeIdObjectState : Event
{
	// Token: 0x06001AF9 RID: 6905 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AF9")]
	[Address(RVA = "0x7DC460", Offset = "0x7DAA60", VA = "0x1807DC460")]
	public ChangeIdObjectState()
	{
	}

	// Token: 0x170007A8 RID: 1960
	// (get) Token: 0x06001AFA RID: 6906 RVA: 0x00008448 File Offset: 0x00006648
	// (set) Token: 0x06001AFB RID: 6907 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007A8")]
	public int Id
	{
		[Token(Token = "0x6001AFA")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001AFB")]
		[Address(RVA = "0x7DC4C0", Offset = "0x7DAAC0", VA = "0x1807DC4C0")]
		set
		{
		}
	}

	// Token: 0x170007A9 RID: 1961
	// (get) Token: 0x06001AFC RID: 6908 RVA: 0x00008460 File Offset: 0x00006660
	// (set) Token: 0x06001AFD RID: 6909 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007A9")]
	public int StateValue
	{
		[Token(Token = "0x6001AFC")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001AFD")]
		[Address(RVA = "0x7DC560", Offset = "0x7DAB60", VA = "0x1807DC560")]
		set
		{
		}
	}

	// Token: 0x06001AFE RID: 6910 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AFE")]
	[Address(RVA = "0x7DC610", Offset = "0x7DAC10", VA = "0x1807DC610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001AFF RID: 6911 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AFF")]
	[Address(RVA = "0x7DC720", Offset = "0x7DAD20", VA = "0x1807DC720")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ChangeIdObjectState Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001B00 RID: 6912 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B00")]
	[Address(RVA = "0x7DC730", Offset = "0x7DAD30", VA = "0x1807DC730")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ChangeIdObjectState Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001B01 RID: 6913 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B01")]
	[Address(RVA = "0x7DC930", Offset = "0x7DAF30", VA = "0x1807DC930")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static ChangeIdObjectState Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B02 RID: 6914 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B02")]
	[Address(RVA = "0x7DCA50", Offset = "0x7DB050", VA = "0x1807DCA50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ChangeIdObjectState Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001B03 RID: 6915 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B03")]
	[Address(RVA = "0x7DCA60", Offset = "0x7DB060", VA = "0x1807DCA60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ChangeIdObjectState Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B04 RID: 6916 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B04")]
	[Address(RVA = "0x7DCA70", Offset = "0x7DB070", VA = "0x1807DCA70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ChangeIdObjectState Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001B05 RID: 6917 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B05")]
	[Address(RVA = "0x7DCA80", Offset = "0x7DB080", VA = "0x1807DCA80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ChangeIdObjectState Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B06 RID: 6918 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B06")]
	[Address(RVA = "0x7DCAA0", Offset = "0x7DB0A0", VA = "0x1807DCAA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ChangeIdObjectState Raise()
	{
		return null;
	}

	// Token: 0x06001B07 RID: 6919 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B07")]
	[Address(RVA = "0x7DCAC0", Offset = "0x7DB0C0", VA = "0x1807DCAC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ChangeIdObjectState Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B08 RID: 6920 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B08")]
	[Address(RVA = "0x7DC720", Offset = "0x7DAD20", VA = "0x1807DC720")]
	public static ChangeIdObjectState Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001B09 RID: 6921 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B09")]
	[Address(RVA = "0x7DCAD0", Offset = "0x7DB0D0", VA = "0x1807DCAD0")]
	public static ChangeIdObjectState Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001B0A RID: 6922 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B0A")]
	[Address(RVA = "0x7DCCD0", Offset = "0x7DB2D0", VA = "0x1807DCCD0")]
	private static ChangeIdObjectState Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B0B RID: 6923 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B0B")]
	[Address(RVA = "0x7DCA50", Offset = "0x7DB050", VA = "0x1807DCA50")]
	public static ChangeIdObjectState Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001B0C RID: 6924 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B0C")]
	[Address(RVA = "0x7DCA60", Offset = "0x7DB060", VA = "0x1807DCA60")]
	public static ChangeIdObjectState Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B0D RID: 6925 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B0D")]
	[Address(RVA = "0x7DCA70", Offset = "0x7DB070", VA = "0x1807DCA70")]
	public static ChangeIdObjectState Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001B0E RID: 6926 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B0E")]
	[Address(RVA = "0x7DCA80", Offset = "0x7DB080", VA = "0x1807DCA80")]
	public static ChangeIdObjectState Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B0F RID: 6927 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B0F")]
	[Address(RVA = "0x7DCAA0", Offset = "0x7DB0A0", VA = "0x1807DCAA0")]
	public static ChangeIdObjectState Create()
	{
		return null;
	}

	// Token: 0x06001B10 RID: 6928 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B10")]
	[Address(RVA = "0x7DCAC0", Offset = "0x7DB0C0", VA = "0x1807DCAC0")]
	public static ChangeIdObjectState Create(ReliabilityModes reliability)
	{
		return null;
	}
}
