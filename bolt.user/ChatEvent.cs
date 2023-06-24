using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000C6 RID: 198
[Token(Token = "0x20000C6")]
public class ChatEvent : Event
{
	// Token: 0x06000923 RID: 2339 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000923")]
	[Address(RVA = "0x83FBB0", Offset = "0x83E1B0", VA = "0x18083FBB0")]
	public ChatEvent()
	{
	}

	// Token: 0x170004AD RID: 1197
	// (get) Token: 0x06000924 RID: 2340 RVA: 0x00005490 File Offset: 0x00003690
	// (set) Token: 0x06000925 RID: 2341 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004AD")]
	public NetworkId Sender
	{
		[Token(Token = "0x6000924")]
		[Address(RVA = "0x7BA0A0", Offset = "0x7B86A0", VA = "0x1807BA0A0")]
		get
		{
			return default(NetworkId);
		}
		[Token(Token = "0x6000925")]
		[Address(RVA = "0x7F5BE0", Offset = "0x7F41E0", VA = "0x1807F5BE0")]
		set
		{
		}
	}

	// Token: 0x170004AE RID: 1198
	// (get) Token: 0x06000926 RID: 2342 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000927 RID: 2343 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004AE")]
	public string Message
	{
		[Token(Token = "0x6000926")]
		[Address(RVA = "0x83FC10", Offset = "0x83E210", VA = "0x18083FC10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000927")]
		[Address(RVA = "0x83FCB0", Offset = "0x83E2B0", VA = "0x18083FCB0")]
		set
		{
		}
	}

	// Token: 0x06000928 RID: 2344 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000928")]
	[Address(RVA = "0x83FDF0", Offset = "0x83E3F0", VA = "0x18083FDF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000929 RID: 2345 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000929")]
	[Address(RVA = "0x83FEB0", Offset = "0x83E4B0", VA = "0x18083FEB0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ChatEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600092A RID: 2346 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600092A")]
	[Address(RVA = "0x83FEC0", Offset = "0x83E4C0", VA = "0x18083FEC0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ChatEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600092B RID: 2347 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600092B")]
	[Address(RVA = "0x8400C0", Offset = "0x83E6C0", VA = "0x1808400C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static ChatEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600092C RID: 2348 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600092C")]
	[Address(RVA = "0x8401E0", Offset = "0x83E7E0", VA = "0x1808401E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ChatEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600092D RID: 2349 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600092D")]
	[Address(RVA = "0x8401F0", Offset = "0x83E7F0", VA = "0x1808401F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ChatEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600092E RID: 2350 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600092E")]
	[Address(RVA = "0x840200", Offset = "0x83E800", VA = "0x180840200")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ChatEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600092F RID: 2351 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600092F")]
	[Address(RVA = "0x840210", Offset = "0x83E810", VA = "0x180840210")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ChatEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000930 RID: 2352 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000930")]
	[Address(RVA = "0x840230", Offset = "0x83E830", VA = "0x180840230")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ChatEvent Raise()
	{
		return null;
	}

	// Token: 0x06000931 RID: 2353 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000931")]
	[Address(RVA = "0x840250", Offset = "0x83E850", VA = "0x180840250")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static ChatEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000932 RID: 2354 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000932")]
	[Address(RVA = "0x83FEB0", Offset = "0x83E4B0", VA = "0x18083FEB0")]
	public static ChatEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000933 RID: 2355 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000933")]
	[Address(RVA = "0x840260", Offset = "0x83E860", VA = "0x180840260")]
	public static ChatEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000934 RID: 2356 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000934")]
	[Address(RVA = "0x840460", Offset = "0x83EA60", VA = "0x180840460")]
	private static ChatEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000935 RID: 2357 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000935")]
	[Address(RVA = "0x8401E0", Offset = "0x83E7E0", VA = "0x1808401E0")]
	public static ChatEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000936 RID: 2358 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000936")]
	[Address(RVA = "0x8401F0", Offset = "0x83E7F0", VA = "0x1808401F0")]
	public static ChatEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000937 RID: 2359 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000937")]
	[Address(RVA = "0x840200", Offset = "0x83E800", VA = "0x180840200")]
	public static ChatEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000938 RID: 2360 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000938")]
	[Address(RVA = "0x840210", Offset = "0x83E810", VA = "0x180840210")]
	public static ChatEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000939 RID: 2361 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000939")]
	[Address(RVA = "0x840230", Offset = "0x83E830", VA = "0x180840230")]
	public static ChatEvent Create()
	{
		return null;
	}

	// Token: 0x0600093A RID: 2362 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600093A")]
	[Address(RVA = "0x840250", Offset = "0x83E850", VA = "0x180840250")]
	public static ChatEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
