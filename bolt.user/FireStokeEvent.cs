using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000252 RID: 594
[Token(Token = "0x2000252")]
public class FireStokeEvent : Event
{
	// Token: 0x06001B63 RID: 7011 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B63")]
	[Address(RVA = "0x7DFCB0", Offset = "0x7DE2B0", VA = "0x1807DFCB0")]
	public FireStokeEvent()
	{
	}

	// Token: 0x170007B9 RID: 1977
	// (get) Token: 0x06001B64 RID: 7012 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001B65 RID: 7013 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007B9")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001B64")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B65")]
		[Address(RVA = "0x7DFD10", Offset = "0x7DE310", VA = "0x1807DFD10")]
		set
		{
		}
	}

	// Token: 0x06001B66 RID: 7014 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B66")]
	[Address(RVA = "0x7DFF20", Offset = "0x7DE520", VA = "0x1807DFF20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001B67 RID: 7015 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B67")]
	[Address(RVA = "0x7DFF70", Offset = "0x7DE570", VA = "0x1807DFF70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FireStokeEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001B68 RID: 7016 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B68")]
	[Address(RVA = "0x7DFF80", Offset = "0x7DE580", VA = "0x1807DFF80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FireStokeEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001B69 RID: 7017 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B69")]
	[Address(RVA = "0x7E0180", Offset = "0x7DE780", VA = "0x1807E0180")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static FireStokeEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B6A RID: 7018 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B6A")]
	[Address(RVA = "0x7E02A0", Offset = "0x7DE8A0", VA = "0x1807E02A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FireStokeEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001B6B RID: 7019 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B6B")]
	[Address(RVA = "0x7E02B0", Offset = "0x7DE8B0", VA = "0x1807E02B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FireStokeEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B6C RID: 7020 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B6C")]
	[Address(RVA = "0x7E02C0", Offset = "0x7DE8C0", VA = "0x1807E02C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FireStokeEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001B6D RID: 7021 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B6D")]
	[Address(RVA = "0x7E02D0", Offset = "0x7DE8D0", VA = "0x1807E02D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FireStokeEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B6E RID: 7022 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B6E")]
	[Address(RVA = "0x7E02F0", Offset = "0x7DE8F0", VA = "0x1807E02F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FireStokeEvent Raise()
	{
		return null;
	}

	// Token: 0x06001B6F RID: 7023 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B6F")]
	[Address(RVA = "0x7E0310", Offset = "0x7DE910", VA = "0x1807E0310")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FireStokeEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B70 RID: 7024 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B70")]
	[Address(RVA = "0x7DFF70", Offset = "0x7DE570", VA = "0x1807DFF70")]
	public static FireStokeEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001B71 RID: 7025 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B71")]
	[Address(RVA = "0x7E0320", Offset = "0x7DE920", VA = "0x1807E0320")]
	public static FireStokeEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001B72 RID: 7026 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B72")]
	[Address(RVA = "0x7E0520", Offset = "0x7DEB20", VA = "0x1807E0520")]
	private static FireStokeEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B73 RID: 7027 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B73")]
	[Address(RVA = "0x7E02A0", Offset = "0x7DE8A0", VA = "0x1807E02A0")]
	public static FireStokeEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001B74 RID: 7028 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B74")]
	[Address(RVA = "0x7E02B0", Offset = "0x7DE8B0", VA = "0x1807E02B0")]
	public static FireStokeEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B75 RID: 7029 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B75")]
	[Address(RVA = "0x7E02C0", Offset = "0x7DE8C0", VA = "0x1807E02C0")]
	public static FireStokeEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001B76 RID: 7030 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B76")]
	[Address(RVA = "0x7E02D0", Offset = "0x7DE8D0", VA = "0x1807E02D0")]
	public static FireStokeEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001B77 RID: 7031 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B77")]
	[Address(RVA = "0x7E02F0", Offset = "0x7DE8F0", VA = "0x1807E02F0")]
	public static FireStokeEvent Create()
	{
		return null;
	}

	// Token: 0x06001B78 RID: 7032 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B78")]
	[Address(RVA = "0x7E0310", Offset = "0x7DE910", VA = "0x1807E0310")]
	public static FireStokeEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
