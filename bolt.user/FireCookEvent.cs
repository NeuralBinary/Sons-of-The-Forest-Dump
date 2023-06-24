using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000D5 RID: 213
[Token(Token = "0x20000D5")]
public class FireCookEvent : Event
{
	// Token: 0x060009E7 RID: 2535 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009E7")]
	[Address(RVA = "0x847270", Offset = "0x845870", VA = "0x180847270")]
	public FireCookEvent()
	{
	}

	// Token: 0x170004D3 RID: 1235
	// (get) Token: 0x060009E8 RID: 2536 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060009E9 RID: 2537 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004D3")]
	public BoltEntity TargetFire
	{
		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x8472D0", Offset = "0x8458D0", VA = "0x1808472D0")]
		set
		{
		}
	}

	// Token: 0x170004D4 RID: 1236
	// (get) Token: 0x060009EA RID: 2538 RVA: 0x00005718 File Offset: 0x00003918
	// (set) Token: 0x060009EB RID: 2539 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004D4")]
	public int ItemId
	{
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x7D8500", Offset = "0x7D6B00", VA = "0x1807D8500")]
		set
		{
		}
	}

	// Token: 0x170004D5 RID: 1237
	// (get) Token: 0x060009EC RID: 2540 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060009ED RID: 2541 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004D5")]
	public IProtocolToken ItemInstance
	{
		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x80EF20", Offset = "0x80D520", VA = "0x18080EF20")]
		get
		{
			return null;
		}
		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x8474E0", Offset = "0x845AE0", VA = "0x1808474E0")]
		set
		{
		}
	}

	// Token: 0x060009EE RID: 2542 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009EE")]
	[Address(RVA = "0x847630", Offset = "0x845C30", VA = "0x180847630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060009EF RID: 2543 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009EF")]
	[Address(RVA = "0x847710", Offset = "0x845D10", VA = "0x180847710")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static FireCookEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060009F0 RID: 2544 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009F0")]
	[Address(RVA = "0x8478A0", Offset = "0x845EA0", VA = "0x1808478A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FireCookEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060009F1 RID: 2545 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009F1")]
	[Address(RVA = "0x8478B0", Offset = "0x845EB0", VA = "0x1808478B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FireCookEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060009F2 RID: 2546 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009F2")]
	[Address(RVA = "0x8478C0", Offset = "0x845EC0", VA = "0x1808478C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FireCookEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060009F3 RID: 2547 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009F3")]
	[Address(RVA = "0x8478D0", Offset = "0x845ED0", VA = "0x1808478D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FireCookEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009F4")]
	[Address(RVA = "0x8478F0", Offset = "0x845EF0", VA = "0x1808478F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FireCookEvent Raise()
	{
		return null;
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009F5")]
	[Address(RVA = "0x847910", Offset = "0x845F10", VA = "0x180847910")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FireCookEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009F6")]
	[Address(RVA = "0x847920", Offset = "0x845F20", VA = "0x180847920")]
	private static FireCookEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009F7")]
	[Address(RVA = "0x8478A0", Offset = "0x845EA0", VA = "0x1808478A0")]
	public static FireCookEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009F8")]
	[Address(RVA = "0x8478B0", Offset = "0x845EB0", VA = "0x1808478B0")]
	public static FireCookEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060009F9 RID: 2553 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009F9")]
	[Address(RVA = "0x8478C0", Offset = "0x845EC0", VA = "0x1808478C0")]
	public static FireCookEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060009FA RID: 2554 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009FA")]
	[Address(RVA = "0x8478D0", Offset = "0x845ED0", VA = "0x1808478D0")]
	public static FireCookEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009FB")]
	[Address(RVA = "0x8478F0", Offset = "0x845EF0", VA = "0x1808478F0")]
	public static FireCookEvent Create()
	{
		return null;
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009FC")]
	[Address(RVA = "0x847910", Offset = "0x845F10", VA = "0x180847910")]
	public static FireCookEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
