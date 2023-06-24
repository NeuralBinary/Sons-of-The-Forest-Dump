using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000FF RID: 255
[Token(Token = "0x20000FF")]
public class TrapResetEvent : Event
{
	// Token: 0x06000BBB RID: 3003 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BBB")]
	[Address(RVA = "0x855950", Offset = "0x853F50", VA = "0x180855950")]
	public TrapResetEvent()
	{
	}

	// Token: 0x17000517 RID: 1303
	// (get) Token: 0x06000BBC RID: 3004 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000BBD RID: 3005 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000517")]
	public BoltEntity Target
	{
		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x8559B0", Offset = "0x853FB0", VA = "0x1808559B0")]
		set
		{
		}
	}

	// Token: 0x06000BBE RID: 3006 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000BBE")]
	[Address(RVA = "0x855BC0", Offset = "0x8541C0", VA = "0x180855BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000BBF RID: 3007 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000BBF")]
	[Address(RVA = "0x855C10", Offset = "0x854210", VA = "0x180855C10")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TrapResetEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000BC0 RID: 3008 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000BC0")]
	[Address(RVA = "0x855C20", Offset = "0x854220", VA = "0x180855C20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TrapResetEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000BC1 RID: 3009 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000BC1")]
	[Address(RVA = "0x855E20", Offset = "0x854420", VA = "0x180855E20")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static TrapResetEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000BC2 RID: 3010 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000BC2")]
	[Address(RVA = "0x855F40", Offset = "0x854540", VA = "0x180855F40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TrapResetEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000BC3 RID: 3011 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000BC3")]
	[Address(RVA = "0x855F50", Offset = "0x854550", VA = "0x180855F50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TrapResetEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000BC4 RID: 3012 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000BC4")]
	[Address(RVA = "0x855F60", Offset = "0x854560", VA = "0x180855F60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TrapResetEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000BC5 RID: 3013 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000BC5")]
	[Address(RVA = "0x855F70", Offset = "0x854570", VA = "0x180855F70")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TrapResetEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000BC6 RID: 3014 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000BC6")]
	[Address(RVA = "0x855F90", Offset = "0x854590", VA = "0x180855F90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TrapResetEvent Raise()
	{
		return null;
	}

	// Token: 0x06000BC7 RID: 3015 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000BC7")]
	[Address(RVA = "0x855FB0", Offset = "0x8545B0", VA = "0x180855FB0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TrapResetEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000BC8 RID: 3016 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000BC8")]
	[Address(RVA = "0x855C10", Offset = "0x854210", VA = "0x180855C10")]
	public static TrapResetEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000BC9 RID: 3017 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000BC9")]
	[Address(RVA = "0x855FC0", Offset = "0x8545C0", VA = "0x180855FC0")]
	public static TrapResetEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000BCA RID: 3018 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000BCA")]
	[Address(RVA = "0x8561C0", Offset = "0x8547C0", VA = "0x1808561C0")]
	private static TrapResetEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000BCB RID: 3019 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000BCB")]
	[Address(RVA = "0x855F40", Offset = "0x854540", VA = "0x180855F40")]
	public static TrapResetEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000BCC RID: 3020 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000BCC")]
	[Address(RVA = "0x855F50", Offset = "0x854550", VA = "0x180855F50")]
	public static TrapResetEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000BCD RID: 3021 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000BCD")]
	[Address(RVA = "0x855F60", Offset = "0x854560", VA = "0x180855F60")]
	public static TrapResetEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000BCE RID: 3022 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000BCE")]
	[Address(RVA = "0x855F70", Offset = "0x854570", VA = "0x180855F70")]
	public static TrapResetEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000BCF RID: 3023 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000BCF")]
	[Address(RVA = "0x855F90", Offset = "0x854590", VA = "0x180855F90")]
	public static TrapResetEvent Create()
	{
		return null;
	}

	// Token: 0x06000BD0 RID: 3024 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000BD0")]
	[Address(RVA = "0x855FB0", Offset = "0x8545B0", VA = "0x180855FB0")]
	public static TrapResetEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
