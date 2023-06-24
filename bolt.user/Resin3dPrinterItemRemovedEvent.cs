using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200026D RID: 621
[Token(Token = "0x200026D")]
public class Resin3dPrinterItemRemovedEvent : Event
{
	// Token: 0x06001C8F RID: 7311 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C8F")]
	[Address(RVA = "0x7E9180", Offset = "0x7E7780", VA = "0x1807E9180")]
	public Resin3dPrinterItemRemovedEvent()
	{
	}

	// Token: 0x170007E5 RID: 2021
	// (get) Token: 0x06001C90 RID: 7312 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001C91 RID: 7313 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007E5")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001C90")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001C91")]
		[Address(RVA = "0x7E91E0", Offset = "0x7E77E0", VA = "0x1807E91E0")]
		set
		{
		}
	}

	// Token: 0x170007E6 RID: 2022
	// (get) Token: 0x06001C92 RID: 7314 RVA: 0x00008808 File Offset: 0x00006A08
	// (set) Token: 0x06001C93 RID: 7315 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007E6")]
	public int Index
	{
		[Token(Token = "0x6001C92")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001C93")]
		[Address(RVA = "0x7E93F0", Offset = "0x7E79F0", VA = "0x1807E93F0")]
		set
		{
		}
	}

	// Token: 0x06001C94 RID: 7316 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C94")]
	[Address(RVA = "0x7E94A0", Offset = "0x7E7AA0", VA = "0x1807E94A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001C95 RID: 7317 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C95")]
	[Address(RVA = "0x7E9560", Offset = "0x7E7B60", VA = "0x1807E9560")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterItemRemovedEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001C96 RID: 7318 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C96")]
	[Address(RVA = "0x7E9570", Offset = "0x7E7B70", VA = "0x1807E9570")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterItemRemovedEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001C97 RID: 7319 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C97")]
	[Address(RVA = "0x7E9770", Offset = "0x7E7D70", VA = "0x1807E9770")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static Resin3dPrinterItemRemovedEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C98 RID: 7320 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C98")]
	[Address(RVA = "0x7E9890", Offset = "0x7E7E90", VA = "0x1807E9890")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterItemRemovedEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001C99 RID: 7321 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C99")]
	[Address(RVA = "0x7E98A0", Offset = "0x7E7EA0", VA = "0x1807E98A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterItemRemovedEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C9A RID: 7322 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C9A")]
	[Address(RVA = "0x7E98B0", Offset = "0x7E7EB0", VA = "0x1807E98B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterItemRemovedEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001C9B RID: 7323 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C9B")]
	[Address(RVA = "0x7E98C0", Offset = "0x7E7EC0", VA = "0x1807E98C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterItemRemovedEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C9C RID: 7324 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C9C")]
	[Address(RVA = "0x7E98E0", Offset = "0x7E7EE0", VA = "0x1807E98E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterItemRemovedEvent Raise()
	{
		return null;
	}

	// Token: 0x06001C9D RID: 7325 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C9D")]
	[Address(RVA = "0x7E9900", Offset = "0x7E7F00", VA = "0x1807E9900")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static Resin3dPrinterItemRemovedEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C9E RID: 7326 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C9E")]
	[Address(RVA = "0x7E9560", Offset = "0x7E7B60", VA = "0x1807E9560")]
	public static Resin3dPrinterItemRemovedEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001C9F RID: 7327 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C9F")]
	[Address(RVA = "0x7E9910", Offset = "0x7E7F10", VA = "0x1807E9910")]
	public static Resin3dPrinterItemRemovedEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001CA0 RID: 7328 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CA0")]
	[Address(RVA = "0x7E9B10", Offset = "0x7E8110", VA = "0x1807E9B10")]
	private static Resin3dPrinterItemRemovedEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001CA1 RID: 7329 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CA1")]
	[Address(RVA = "0x7E9890", Offset = "0x7E7E90", VA = "0x1807E9890")]
	public static Resin3dPrinterItemRemovedEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001CA2 RID: 7330 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CA2")]
	[Address(RVA = "0x7E98A0", Offset = "0x7E7EA0", VA = "0x1807E98A0")]
	public static Resin3dPrinterItemRemovedEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001CA3 RID: 7331 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CA3")]
	[Address(RVA = "0x7E98B0", Offset = "0x7E7EB0", VA = "0x1807E98B0")]
	public static Resin3dPrinterItemRemovedEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001CA4 RID: 7332 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CA4")]
	[Address(RVA = "0x7E98C0", Offset = "0x7E7EC0", VA = "0x1807E98C0")]
	public static Resin3dPrinterItemRemovedEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001CA5 RID: 7333 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CA5")]
	[Address(RVA = "0x7E98E0", Offset = "0x7E7EE0", VA = "0x1807E98E0")]
	public static Resin3dPrinterItemRemovedEvent Create()
	{
		return null;
	}

	// Token: 0x06001CA6 RID: 7334 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CA6")]
	[Address(RVA = "0x7E9900", Offset = "0x7E7F00", VA = "0x1807E9900")]
	public static Resin3dPrinterItemRemovedEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
