using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200026A RID: 618
[Token(Token = "0x200026A")]
public class Resin3dPrinterSetBusyEvent : Event
{
	// Token: 0x06001C6D RID: 7277 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C6D")]
	[Address(RVA = "0x7E8070", Offset = "0x7E6670", VA = "0x1807E8070")]
	public Resin3dPrinterSetBusyEvent()
	{
	}

	// Token: 0x170007E0 RID: 2016
	// (get) Token: 0x06001C6E RID: 7278 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001C6F RID: 7279 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007E0")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001C6E")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001C6F")]
		[Address(RVA = "0x7E80D0", Offset = "0x7E66D0", VA = "0x1807E80D0")]
		set
		{
		}
	}

	// Token: 0x170007E1 RID: 2017
	// (get) Token: 0x06001C70 RID: 7280 RVA: 0x000087C0 File Offset: 0x000069C0
	// (set) Token: 0x06001C71 RID: 7281 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007E1")]
	public bool IsBusy
	{
		[Token(Token = "0x6001C70")]
		[Address(RVA = "0x7B5490", Offset = "0x7B3A90", VA = "0x1807B5490")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001C71")]
		[Address(RVA = "0x7E82E0", Offset = "0x7E68E0", VA = "0x1807E82E0")]
		set
		{
		}
	}

	// Token: 0x06001C72 RID: 7282 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C72")]
	[Address(RVA = "0x7E8380", Offset = "0x7E6980", VA = "0x1807E8380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001C73 RID: 7283 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C73")]
	[Address(RVA = "0x7E8440", Offset = "0x7E6A40", VA = "0x1807E8440")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterSetBusyEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001C74 RID: 7284 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C74")]
	[Address(RVA = "0x7E8450", Offset = "0x7E6A50", VA = "0x1807E8450")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterSetBusyEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001C75 RID: 7285 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C75")]
	[Address(RVA = "0x7E8650", Offset = "0x7E6C50", VA = "0x1807E8650")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static Resin3dPrinterSetBusyEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C76 RID: 7286 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C76")]
	[Address(RVA = "0x7E8770", Offset = "0x7E6D70", VA = "0x1807E8770")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterSetBusyEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001C77 RID: 7287 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C77")]
	[Address(RVA = "0x7E8780", Offset = "0x7E6D80", VA = "0x1807E8780")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterSetBusyEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C78 RID: 7288 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C78")]
	[Address(RVA = "0x7E8790", Offset = "0x7E6D90", VA = "0x1807E8790")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterSetBusyEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001C79 RID: 7289 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C79")]
	[Address(RVA = "0x7E87A0", Offset = "0x7E6DA0", VA = "0x1807E87A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterSetBusyEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C7A RID: 7290 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C7A")]
	[Address(RVA = "0x7E87C0", Offset = "0x7E6DC0", VA = "0x1807E87C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterSetBusyEvent Raise()
	{
		return null;
	}

	// Token: 0x06001C7B RID: 7291 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C7B")]
	[Address(RVA = "0x7E87E0", Offset = "0x7E6DE0", VA = "0x1807E87E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterSetBusyEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C7C RID: 7292 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C7C")]
	[Address(RVA = "0x7E8440", Offset = "0x7E6A40", VA = "0x1807E8440")]
	public static Resin3dPrinterSetBusyEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001C7D RID: 7293 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C7D")]
	[Address(RVA = "0x7E87F0", Offset = "0x7E6DF0", VA = "0x1807E87F0")]
	public static Resin3dPrinterSetBusyEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001C7E RID: 7294 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C7E")]
	[Address(RVA = "0x7E89F0", Offset = "0x7E6FF0", VA = "0x1807E89F0")]
	private static Resin3dPrinterSetBusyEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C7F RID: 7295 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C7F")]
	[Address(RVA = "0x7E8770", Offset = "0x7E6D70", VA = "0x1807E8770")]
	public static Resin3dPrinterSetBusyEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001C80 RID: 7296 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C80")]
	[Address(RVA = "0x7E8780", Offset = "0x7E6D80", VA = "0x1807E8780")]
	public static Resin3dPrinterSetBusyEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C81 RID: 7297 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C81")]
	[Address(RVA = "0x7E8790", Offset = "0x7E6D90", VA = "0x1807E8790")]
	public static Resin3dPrinterSetBusyEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001C82 RID: 7298 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C82")]
	[Address(RVA = "0x7E87A0", Offset = "0x7E6DA0", VA = "0x1807E87A0")]
	public static Resin3dPrinterSetBusyEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C83 RID: 7299 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C83")]
	[Address(RVA = "0x7E87C0", Offset = "0x7E6DC0", VA = "0x1807E87C0")]
	public static Resin3dPrinterSetBusyEvent Create()
	{
		return null;
	}

	// Token: 0x06001C84 RID: 7300 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C84")]
	[Address(RVA = "0x7E87E0", Offset = "0x7E6DE0", VA = "0x1807E87E0")]
	public static Resin3dPrinterSetBusyEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
