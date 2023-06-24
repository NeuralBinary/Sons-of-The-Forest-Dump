using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000210 RID: 528
[Token(Token = "0x2000210")]
public class RadioActivate : Event
{
	// Token: 0x06001847 RID: 6215 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001847")]
	[Address(RVA = "0x8BFE50", Offset = "0x8BE450", VA = "0x1808BFE50")]
	public RadioActivate()
	{
	}

	// Token: 0x17000733 RID: 1843
	// (get) Token: 0x06001848 RID: 6216 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001849 RID: 6217 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000733")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001848")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001849")]
		[Address(RVA = "0x8BFEB0", Offset = "0x8BE4B0", VA = "0x1808BFEB0")]
		set
		{
		}
	}

	// Token: 0x17000734 RID: 1844
	// (get) Token: 0x0600184A RID: 6218 RVA: 0x00007CC8 File Offset: 0x00005EC8
	// (set) Token: 0x0600184B RID: 6219 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000734")]
	public int EventType
	{
		[Token(Token = "0x600184A")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600184B")]
		[Address(RVA = "0x7F3530", Offset = "0x7F1B30", VA = "0x1807F3530")]
		set
		{
		}
	}

	// Token: 0x0600184C RID: 6220 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600184C")]
	[Address(RVA = "0x8C00C0", Offset = "0x8BE6C0", VA = "0x1808C00C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0600184D RID: 6221 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600184D")]
	[Address(RVA = "0x8C0180", Offset = "0x8BE780", VA = "0x1808C0180")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RadioActivate Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600184E RID: 6222 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600184E")]
	[Address(RVA = "0x8C0190", Offset = "0x8BE790", VA = "0x1808C0190")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RadioActivate Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600184F RID: 6223 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600184F")]
	[Address(RVA = "0x8C0390", Offset = "0x8BE990", VA = "0x1808C0390")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static RadioActivate Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001850 RID: 6224 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001850")]
	[Address(RVA = "0x8C04B0", Offset = "0x8BEAB0", VA = "0x1808C04B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RadioActivate Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001851 RID: 6225 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001851")]
	[Address(RVA = "0x8C04C0", Offset = "0x8BEAC0", VA = "0x1808C04C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RadioActivate Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001852 RID: 6226 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001852")]
	[Address(RVA = "0x8C04D0", Offset = "0x8BEAD0", VA = "0x1808C04D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RadioActivate Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001853 RID: 6227 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001853")]
	[Address(RVA = "0x8C04E0", Offset = "0x8BEAE0", VA = "0x1808C04E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RadioActivate Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001854 RID: 6228 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001854")]
	[Address(RVA = "0x8C0500", Offset = "0x8BEB00", VA = "0x1808C0500")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RadioActivate Raise()
	{
		return null;
	}

	// Token: 0x06001855 RID: 6229 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001855")]
	[Address(RVA = "0x8C0520", Offset = "0x8BEB20", VA = "0x1808C0520")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static RadioActivate Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001856 RID: 6230 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001856")]
	[Address(RVA = "0x8C0180", Offset = "0x8BE780", VA = "0x1808C0180")]
	public static RadioActivate Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001857 RID: 6231 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001857")]
	[Address(RVA = "0x8C0530", Offset = "0x8BEB30", VA = "0x1808C0530")]
	public static RadioActivate Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001858 RID: 6232 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001858")]
	[Address(RVA = "0x8C0730", Offset = "0x8BED30", VA = "0x1808C0730")]
	private static RadioActivate Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001859 RID: 6233 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001859")]
	[Address(RVA = "0x8C04B0", Offset = "0x8BEAB0", VA = "0x1808C04B0")]
	public static RadioActivate Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600185A RID: 6234 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600185A")]
	[Address(RVA = "0x8C04C0", Offset = "0x8BEAC0", VA = "0x1808C04C0")]
	public static RadioActivate Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600185B RID: 6235 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600185B")]
	[Address(RVA = "0x8C04D0", Offset = "0x8BEAD0", VA = "0x1808C04D0")]
	public static RadioActivate Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600185C RID: 6236 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600185C")]
	[Address(RVA = "0x8C04E0", Offset = "0x8BEAE0", VA = "0x1808C04E0")]
	public static RadioActivate Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600185D RID: 6237 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600185D")]
	[Address(RVA = "0x8C0500", Offset = "0x8BEB00", VA = "0x1808C0500")]
	public static RadioActivate Create()
	{
		return null;
	}

	// Token: 0x0600185E RID: 6238 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600185E")]
	[Address(RVA = "0x8C0520", Offset = "0x8BEB20", VA = "0x1808C0520")]
	public static RadioActivate Create(ReliabilityModes reliability)
	{
		return null;
	}
}
