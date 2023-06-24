using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000261 RID: 609
[Token(Token = "0x2000261")]
public class TrapActivateEvent : Event
{
	// Token: 0x06001C0B RID: 7179 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C0B")]
	[Address(RVA = "0x7E51F0", Offset = "0x7E37F0", VA = "0x1807E51F0")]
	public TrapActivateEvent()
	{
	}

	// Token: 0x170007D3 RID: 2003
	// (get) Token: 0x06001C0C RID: 7180 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001C0D RID: 7181 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007D3")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001C0C")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001C0D")]
		[Address(RVA = "0x7E5250", Offset = "0x7E3850", VA = "0x1807E5250")]
		set
		{
		}
	}

	// Token: 0x06001C0E RID: 7182 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C0E")]
	[Address(RVA = "0x7E5460", Offset = "0x7E3A60", VA = "0x1807E5460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001C0F RID: 7183 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C0F")]
	[Address(RVA = "0x7E54B0", Offset = "0x7E3AB0", VA = "0x1807E54B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TrapActivateEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001C10 RID: 7184 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C10")]
	[Address(RVA = "0x7E54C0", Offset = "0x7E3AC0", VA = "0x1807E54C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TrapActivateEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001C11 RID: 7185 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C11")]
	[Address(RVA = "0x7E56C0", Offset = "0x7E3CC0", VA = "0x1807E56C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static TrapActivateEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C12 RID: 7186 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C12")]
	[Address(RVA = "0x7E57E0", Offset = "0x7E3DE0", VA = "0x1807E57E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TrapActivateEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001C13 RID: 7187 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C13")]
	[Address(RVA = "0x7E57F0", Offset = "0x7E3DF0", VA = "0x1807E57F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TrapActivateEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C14 RID: 7188 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C14")]
	[Address(RVA = "0x7E5800", Offset = "0x7E3E00", VA = "0x1807E5800")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TrapActivateEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001C15 RID: 7189 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C15")]
	[Address(RVA = "0x7E5810", Offset = "0x7E3E10", VA = "0x1807E5810")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TrapActivateEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C16 RID: 7190 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C16")]
	[Address(RVA = "0x7E5830", Offset = "0x7E3E30", VA = "0x1807E5830")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TrapActivateEvent Raise()
	{
		return null;
	}

	// Token: 0x06001C17 RID: 7191 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C17")]
	[Address(RVA = "0x7E5850", Offset = "0x7E3E50", VA = "0x1807E5850")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TrapActivateEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C18 RID: 7192 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C18")]
	[Address(RVA = "0x7E54B0", Offset = "0x7E3AB0", VA = "0x1807E54B0")]
	public static TrapActivateEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001C19 RID: 7193 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C19")]
	[Address(RVA = "0x7E5860", Offset = "0x7E3E60", VA = "0x1807E5860")]
	public static TrapActivateEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001C1A RID: 7194 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C1A")]
	[Address(RVA = "0x7E5A60", Offset = "0x7E4060", VA = "0x1807E5A60")]
	private static TrapActivateEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C1B RID: 7195 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C1B")]
	[Address(RVA = "0x7E57E0", Offset = "0x7E3DE0", VA = "0x1807E57E0")]
	public static TrapActivateEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001C1C RID: 7196 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C1C")]
	[Address(RVA = "0x7E57F0", Offset = "0x7E3DF0", VA = "0x1807E57F0")]
	public static TrapActivateEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C1D RID: 7197 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C1D")]
	[Address(RVA = "0x7E5800", Offset = "0x7E3E00", VA = "0x1807E5800")]
	public static TrapActivateEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001C1E RID: 7198 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C1E")]
	[Address(RVA = "0x7E5810", Offset = "0x7E3E10", VA = "0x1807E5810")]
	public static TrapActivateEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001C1F RID: 7199 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C1F")]
	[Address(RVA = "0x7E5830", Offset = "0x7E3E30", VA = "0x1807E5830")]
	public static TrapActivateEvent Create()
	{
		return null;
	}

	// Token: 0x06001C20 RID: 7200 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C20")]
	[Address(RVA = "0x7E5850", Offset = "0x7E3E50", VA = "0x1807E5850")]
	public static TrapActivateEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
