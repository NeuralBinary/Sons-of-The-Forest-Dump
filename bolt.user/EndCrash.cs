using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200018F RID: 399
[Token(Token = "0x200018F")]
public class EndCrash : Event
{
	// Token: 0x06001239 RID: 4665 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001239")]
	[Address(RVA = "0x88BE30", Offset = "0x88A430", VA = "0x18088BE30")]
	public EndCrash()
	{
	}

	// Token: 0x17000616 RID: 1558
	// (get) Token: 0x0600123A RID: 4666 RVA: 0x000069D8 File Offset: 0x00004BD8
	// (set) Token: 0x0600123B RID: 4667 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000616")]
	public bool Aborted
	{
		[Token(Token = "0x600123A")]
		[Address(RVA = "0x7B4A10", Offset = "0x7B3010", VA = "0x1807B4A10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600123B")]
		[Address(RVA = "0x7DB320", Offset = "0x7D9920", VA = "0x1807DB320")]
		set
		{
		}
	}

	// Token: 0x0600123C RID: 4668 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600123C")]
	[Address(RVA = "0x88BE90", Offset = "0x88A490", VA = "0x18088BE90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0600123D RID: 4669 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600123D")]
	[Address(RVA = "0x88BF40", Offset = "0x88A540", VA = "0x18088BF40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static EndCrash Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600123E RID: 4670 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600123E")]
	[Address(RVA = "0x88BF50", Offset = "0x88A550", VA = "0x18088BF50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static EndCrash Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600123F RID: 4671 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600123F")]
	[Address(RVA = "0x88C150", Offset = "0x88A750", VA = "0x18088C150")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static EndCrash Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001240 RID: 4672 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001240")]
	[Address(RVA = "0x88C270", Offset = "0x88A870", VA = "0x18088C270")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static EndCrash Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001241 RID: 4673 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001241")]
	[Address(RVA = "0x88C280", Offset = "0x88A880", VA = "0x18088C280")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static EndCrash Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001242 RID: 4674 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001242")]
	[Address(RVA = "0x88C290", Offset = "0x88A890", VA = "0x18088C290")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static EndCrash Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001243 RID: 4675 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001243")]
	[Address(RVA = "0x88C2A0", Offset = "0x88A8A0", VA = "0x18088C2A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static EndCrash Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001244 RID: 4676 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001244")]
	[Address(RVA = "0x88C2C0", Offset = "0x88A8C0", VA = "0x18088C2C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static EndCrash Raise()
	{
		return null;
	}

	// Token: 0x06001245 RID: 4677 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001245")]
	[Address(RVA = "0x88C2E0", Offset = "0x88A8E0", VA = "0x18088C2E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static EndCrash Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001246 RID: 4678 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001246")]
	[Address(RVA = "0x88BF40", Offset = "0x88A540", VA = "0x18088BF40")]
	public static EndCrash Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001247 RID: 4679 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001247")]
	[Address(RVA = "0x88C2F0", Offset = "0x88A8F0", VA = "0x18088C2F0")]
	public static EndCrash Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001248 RID: 4680 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001248")]
	[Address(RVA = "0x88C4F0", Offset = "0x88AAF0", VA = "0x18088C4F0")]
	private static EndCrash Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001249 RID: 4681 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001249")]
	[Address(RVA = "0x88C270", Offset = "0x88A870", VA = "0x18088C270")]
	public static EndCrash Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600124A RID: 4682 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600124A")]
	[Address(RVA = "0x88C280", Offset = "0x88A880", VA = "0x18088C280")]
	public static EndCrash Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600124B RID: 4683 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600124B")]
	[Address(RVA = "0x88C290", Offset = "0x88A890", VA = "0x18088C290")]
	public static EndCrash Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600124C RID: 4684 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600124C")]
	[Address(RVA = "0x88C2A0", Offset = "0x88A8A0", VA = "0x18088C2A0")]
	public static EndCrash Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600124D RID: 4685 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600124D")]
	[Address(RVA = "0x88C2C0", Offset = "0x88A8C0", VA = "0x18088C2C0")]
	public static EndCrash Create()
	{
		return null;
	}

	// Token: 0x0600124E RID: 4686 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600124E")]
	[Address(RVA = "0x88C2E0", Offset = "0x88A8E0", VA = "0x18088C2E0")]
	public static EndCrash Create(ReliabilityModes reliability)
	{
		return null;
	}
}
