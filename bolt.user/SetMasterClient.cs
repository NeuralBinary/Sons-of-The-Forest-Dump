using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001A7 RID: 423
[Token(Token = "0x20001A7")]
public class SetMasterClient : Event
{
	// Token: 0x06001357 RID: 4951 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001357")]
	[Address(RVA = "0x8956E0", Offset = "0x893CE0", VA = "0x1808956E0")]
	public SetMasterClient()
	{
	}

	// Token: 0x17000645 RID: 1605
	// (get) Token: 0x06001358 RID: 4952 RVA: 0x00006C90 File Offset: 0x00004E90
	// (set) Token: 0x06001359 RID: 4953 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000645")]
	public bool IsMaster
	{
		[Token(Token = "0x6001358")]
		[Address(RVA = "0x7B4A10", Offset = "0x7B3010", VA = "0x1807B4A10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001359")]
		[Address(RVA = "0x7DB320", Offset = "0x7D9920", VA = "0x1807DB320")]
		set
		{
		}
	}

	// Token: 0x0600135A RID: 4954 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600135A")]
	[Address(RVA = "0x895740", Offset = "0x893D40", VA = "0x180895740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0600135B RID: 4955 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600135B")]
	[Address(RVA = "0x8957F0", Offset = "0x893DF0", VA = "0x1808957F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static SetMasterClient Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600135C RID: 4956 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600135C")]
	[Address(RVA = "0x895980", Offset = "0x893F80", VA = "0x180895980")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetMasterClient Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600135D RID: 4957 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600135D")]
	[Address(RVA = "0x895990", Offset = "0x893F90", VA = "0x180895990")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetMasterClient Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600135E RID: 4958 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600135E")]
	[Address(RVA = "0x8959A0", Offset = "0x893FA0", VA = "0x1808959A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetMasterClient Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600135F RID: 4959 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600135F")]
	[Address(RVA = "0x8959B0", Offset = "0x893FB0", VA = "0x1808959B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetMasterClient Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001360 RID: 4960 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001360")]
	[Address(RVA = "0x8959D0", Offset = "0x893FD0", VA = "0x1808959D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetMasterClient Raise()
	{
		return null;
	}

	// Token: 0x06001361 RID: 4961 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001361")]
	[Address(RVA = "0x8959F0", Offset = "0x893FF0", VA = "0x1808959F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetMasterClient Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001362 RID: 4962 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001362")]
	[Address(RVA = "0x895A00", Offset = "0x894000", VA = "0x180895A00")]
	private static SetMasterClient Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001363 RID: 4963 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001363")]
	[Address(RVA = "0x895980", Offset = "0x893F80", VA = "0x180895980")]
	public static SetMasterClient Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001364 RID: 4964 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001364")]
	[Address(RVA = "0x895990", Offset = "0x893F90", VA = "0x180895990")]
	public static SetMasterClient Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001365 RID: 4965 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001365")]
	[Address(RVA = "0x8959A0", Offset = "0x893FA0", VA = "0x1808959A0")]
	public static SetMasterClient Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001366 RID: 4966 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001366")]
	[Address(RVA = "0x8959B0", Offset = "0x893FB0", VA = "0x1808959B0")]
	public static SetMasterClient Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001367 RID: 4967 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001367")]
	[Address(RVA = "0x8959D0", Offset = "0x893FD0", VA = "0x1808959D0")]
	public static SetMasterClient Create()
	{
		return null;
	}

	// Token: 0x06001368 RID: 4968 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001368")]
	[Address(RVA = "0x8959F0", Offset = "0x893FF0", VA = "0x1808959F0")]
	public static SetMasterClient Create(ReliabilityModes reliability)
	{
		return null;
	}
}
