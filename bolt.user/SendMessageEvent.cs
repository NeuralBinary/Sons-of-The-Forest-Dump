using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000E1 RID: 225
[Token(Token = "0x20000E1")]
public class SendMessageEvent : Event
{
	// Token: 0x06000A75 RID: 2677 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A75")]
	[Address(RVA = "0x84C000", Offset = "0x84A600", VA = "0x18084C000")]
	public SendMessageEvent()
	{
	}

	// Token: 0x170004EC RID: 1260
	// (get) Token: 0x06000A76 RID: 2678 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000A77 RID: 2679 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004EC")]
	public string Message
	{
		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x7D27A0", Offset = "0x7D0DA0", VA = "0x1807D27A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x84C060", Offset = "0x84A660", VA = "0x18084C060")]
		set
		{
		}
	}

	// Token: 0x170004ED RID: 1261
	// (get) Token: 0x06000A78 RID: 2680 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000A79 RID: 2681 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004ED")]
	public BoltEntity Target
	{
		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x84C1A0", Offset = "0x84A7A0", VA = "0x18084C1A0")]
		set
		{
		}
	}

	// Token: 0x06000A7A RID: 2682 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A7A")]
	[Address(RVA = "0x84C3B0", Offset = "0x84A9B0", VA = "0x18084C3B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000A7B RID: 2683 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A7B")]
	[Address(RVA = "0x84C490", Offset = "0x84AA90", VA = "0x18084C490")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SendMessageEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000A7C RID: 2684 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A7C")]
	[Address(RVA = "0x84C4A0", Offset = "0x84AAA0", VA = "0x18084C4A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SendMessageEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000A7D RID: 2685 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A7D")]
	[Address(RVA = "0x84C6A0", Offset = "0x84ACA0", VA = "0x18084C6A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static SendMessageEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A7E RID: 2686 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A7E")]
	[Address(RVA = "0x84C7C0", Offset = "0x84ADC0", VA = "0x18084C7C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SendMessageEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000A7F RID: 2687 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A7F")]
	[Address(RVA = "0x84C7D0", Offset = "0x84ADD0", VA = "0x18084C7D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SendMessageEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A80 RID: 2688 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A80")]
	[Address(RVA = "0x84C7E0", Offset = "0x84ADE0", VA = "0x18084C7E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SendMessageEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000A81 RID: 2689 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A81")]
	[Address(RVA = "0x84C7F0", Offset = "0x84ADF0", VA = "0x18084C7F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SendMessageEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A82 RID: 2690 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A82")]
	[Address(RVA = "0x84C810", Offset = "0x84AE10", VA = "0x18084C810")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SendMessageEvent Raise()
	{
		return null;
	}

	// Token: 0x06000A83 RID: 2691 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A83")]
	[Address(RVA = "0x84C830", Offset = "0x84AE30", VA = "0x18084C830")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SendMessageEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A84 RID: 2692 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A84")]
	[Address(RVA = "0x84C490", Offset = "0x84AA90", VA = "0x18084C490")]
	public static SendMessageEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000A85 RID: 2693 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A85")]
	[Address(RVA = "0x84C840", Offset = "0x84AE40", VA = "0x18084C840")]
	public static SendMessageEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000A86 RID: 2694 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A86")]
	[Address(RVA = "0x84CA40", Offset = "0x84B040", VA = "0x18084CA40")]
	private static SendMessageEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A87 RID: 2695 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A87")]
	[Address(RVA = "0x84C7C0", Offset = "0x84ADC0", VA = "0x18084C7C0")]
	public static SendMessageEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000A88 RID: 2696 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A88")]
	[Address(RVA = "0x84C7D0", Offset = "0x84ADD0", VA = "0x18084C7D0")]
	public static SendMessageEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A89 RID: 2697 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A89")]
	[Address(RVA = "0x84C7E0", Offset = "0x84ADE0", VA = "0x18084C7E0")]
	public static SendMessageEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000A8A RID: 2698 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A8A")]
	[Address(RVA = "0x84C7F0", Offset = "0x84ADF0", VA = "0x18084C7F0")]
	public static SendMessageEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000A8B RID: 2699 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A8B")]
	[Address(RVA = "0x84C810", Offset = "0x84AE10", VA = "0x18084C810")]
	public static SendMessageEvent Create()
	{
		return null;
	}

	// Token: 0x06000A8C RID: 2700 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A8C")]
	[Address(RVA = "0x84C830", Offset = "0x84AE30", VA = "0x18084C830")]
	public static SendMessageEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
