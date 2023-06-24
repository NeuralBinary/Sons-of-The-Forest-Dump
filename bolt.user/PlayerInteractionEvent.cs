using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020002B5 RID: 693
[Token(Token = "0x20002B5")]
public class PlayerInteractionEvent : Event
{
	// Token: 0x06001F87 RID: 8071 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F87")]
	[Address(RVA = "0x8004B0", Offset = "0x7FEAB0", VA = "0x1808004B0")]
	public PlayerInteractionEvent()
	{
	}

	// Token: 0x17000861 RID: 2145
	// (get) Token: 0x06001F88 RID: 8072 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001F89 RID: 8073 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000861")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001F88")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F89")]
		[Address(RVA = "0x800510", Offset = "0x7FEB10", VA = "0x180800510")]
		set
		{
		}
	}

	// Token: 0x17000862 RID: 2146
	// (get) Token: 0x06001F8A RID: 8074 RVA: 0x00008FE8 File Offset: 0x000071E8
	// (set) Token: 0x06001F8B RID: 8075 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000862")]
	public int InteractionState
	{
		[Token(Token = "0x6001F8A")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001F8B")]
		[Address(RVA = "0x7F3530", Offset = "0x7F1B30", VA = "0x1807F3530")]
		set
		{
		}
	}

	// Token: 0x17000863 RID: 2147
	// (get) Token: 0x06001F8C RID: 8076 RVA: 0x00009000 File Offset: 0x00007200
	// (set) Token: 0x06001F8D RID: 8077 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000863")]
	public NetworkId SentBy
	{
		[Token(Token = "0x6001F8C")]
		[Address(RVA = "0x800720", Offset = "0x7FED20", VA = "0x180800720")]
		get
		{
			return default(NetworkId);
		}
		[Token(Token = "0x6001F8D")]
		[Address(RVA = "0x800780", Offset = "0x7FED80", VA = "0x180800780")]
		set
		{
		}
	}

	// Token: 0x06001F8E RID: 8078 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F8E")]
	[Address(RVA = "0x800820", Offset = "0x7FEE20", VA = "0x180800820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001F8F RID: 8079 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F8F")]
	[Address(RVA = "0x8009E0", Offset = "0x7FEFE0", VA = "0x1808009E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerInteractionEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001F90 RID: 8080 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F90")]
	[Address(RVA = "0x8009F0", Offset = "0x7FEFF0", VA = "0x1808009F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerInteractionEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001F91 RID: 8081 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F91")]
	[Address(RVA = "0x800BF0", Offset = "0x7FF1F0", VA = "0x180800BF0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static PlayerInteractionEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001F92 RID: 8082 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F92")]
	[Address(RVA = "0x800D80", Offset = "0x7FF380", VA = "0x180800D80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerInteractionEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001F93 RID: 8083 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F93")]
	[Address(RVA = "0x800D90", Offset = "0x7FF390", VA = "0x180800D90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerInteractionEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001F94 RID: 8084 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F94")]
	[Address(RVA = "0x800DA0", Offset = "0x7FF3A0", VA = "0x180800DA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerInteractionEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001F95 RID: 8085 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F95")]
	[Address(RVA = "0x800DB0", Offset = "0x7FF3B0", VA = "0x180800DB0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerInteractionEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001F96 RID: 8086 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F96")]
	[Address(RVA = "0x800DD0", Offset = "0x7FF3D0", VA = "0x180800DD0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerInteractionEvent Raise()
	{
		return null;
	}

	// Token: 0x06001F97 RID: 8087 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F97")]
	[Address(RVA = "0x800DF0", Offset = "0x7FF3F0", VA = "0x180800DF0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlayerInteractionEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001F98 RID: 8088 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F98")]
	[Address(RVA = "0x8009E0", Offset = "0x7FEFE0", VA = "0x1808009E0")]
	public static PlayerInteractionEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001F99 RID: 8089 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F99")]
	[Address(RVA = "0x800E00", Offset = "0x7FF400", VA = "0x180800E00")]
	public static PlayerInteractionEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001F9A RID: 8090 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F9A")]
	[Address(RVA = "0x801000", Offset = "0x7FF600", VA = "0x180801000")]
	private static PlayerInteractionEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001F9B RID: 8091 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F9B")]
	[Address(RVA = "0x800D80", Offset = "0x7FF380", VA = "0x180800D80")]
	public static PlayerInteractionEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001F9C RID: 8092 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F9C")]
	[Address(RVA = "0x800D90", Offset = "0x7FF390", VA = "0x180800D90")]
	public static PlayerInteractionEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001F9D RID: 8093 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F9D")]
	[Address(RVA = "0x800DA0", Offset = "0x7FF3A0", VA = "0x180800DA0")]
	public static PlayerInteractionEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001F9E RID: 8094 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F9E")]
	[Address(RVA = "0x800DB0", Offset = "0x7FF3B0", VA = "0x180800DB0")]
	public static PlayerInteractionEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001F9F RID: 8095 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F9F")]
	[Address(RVA = "0x800DD0", Offset = "0x7FF3D0", VA = "0x180800DD0")]
	public static PlayerInteractionEvent Create()
	{
		return null;
	}

	// Token: 0x06001FA0 RID: 8096 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001FA0")]
	[Address(RVA = "0x800DF0", Offset = "0x7FF3F0", VA = "0x180800DF0")]
	public static PlayerInteractionEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
