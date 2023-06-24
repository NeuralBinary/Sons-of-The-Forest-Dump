using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000258 RID: 600
[Token(Token = "0x2000258")]
public class DeathMarkerRequest : Event
{
	// Token: 0x06001BA3 RID: 7075 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BA3")]
	[Address(RVA = "0x7E1AB0", Offset = "0x7E00B0", VA = "0x1807E1AB0")]
	public DeathMarkerRequest()
	{
	}

	// Token: 0x170007C1 RID: 1985
	// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x000085E0 File Offset: 0x000067E0
	// (set) Token: 0x06001BA5 RID: 7077 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007C1")]
	public int DeathCutsceneType
	{
		[Token(Token = "0x6001BA4")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001BA5")]
		[Address(RVA = "0x7E1B10", Offset = "0x7E0110", VA = "0x1807E1B10")]
		set
		{
		}
	}

	// Token: 0x170007C2 RID: 1986
	// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x000085F8 File Offset: 0x000067F8
	// (set) Token: 0x06001BA7 RID: 7079 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007C2")]
	public Vector3 Position
	{
		[Token(Token = "0x6001BA6")]
		[Address(RVA = "0x7BCBD0", Offset = "0x7BB1D0", VA = "0x1807BCBD0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001BA7")]
		[Address(RVA = "0x7E1BB0", Offset = "0x7E01B0", VA = "0x1807E1BB0")]
		set
		{
		}
	}

	// Token: 0x170007C3 RID: 1987
	// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x00008610 File Offset: 0x00006810
	// (set) Token: 0x06001BA9 RID: 7081 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007C3")]
	public int MarkerHash
	{
		[Token(Token = "0x6001BA8")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001BA9")]
		[Address(RVA = "0x7D6E60", Offset = "0x7D5460", VA = "0x1807D6E60")]
		set
		{
		}
	}

	// Token: 0x170007C4 RID: 1988
	// (get) Token: 0x06001BAA RID: 7082 RVA: 0x00008628 File Offset: 0x00006828
	// (set) Token: 0x06001BAB RID: 7083 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007C4")]
	public int AreaMask
	{
		[Token(Token = "0x6001BAA")]
		[Address(RVA = "0x7B6B40", Offset = "0x7B5140", VA = "0x1807B6B40")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001BAB")]
		[Address(RVA = "0x7E1CC0", Offset = "0x7E02C0", VA = "0x1807E1CC0")]
		set
		{
		}
	}

	// Token: 0x170007C5 RID: 1989
	// (get) Token: 0x06001BAC RID: 7084 RVA: 0x00008640 File Offset: 0x00006840
	// (set) Token: 0x06001BAD RID: 7085 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007C5")]
	public int GroupIdMask
	{
		[Token(Token = "0x6001BAC")]
		[Address(RVA = "0x7BB500", Offset = "0x7B9B00", VA = "0x1807BB500")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001BAD")]
		[Address(RVA = "0x7E1D60", Offset = "0x7E0360", VA = "0x1807E1D60")]
		set
		{
		}
	}

	// Token: 0x170007C6 RID: 1990
	// (get) Token: 0x06001BAE RID: 7086 RVA: 0x00008658 File Offset: 0x00006858
	// (set) Token: 0x06001BAF RID: 7087 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007C6")]
	public int ConnectionId
	{
		[Token(Token = "0x6001BAE")]
		[Address(RVA = "0x7E1E00", Offset = "0x7E0400", VA = "0x1807E1E00")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001BAF")]
		[Address(RVA = "0x7E1E60", Offset = "0x7E0460", VA = "0x1807E1E60")]
		set
		{
		}
	}

	// Token: 0x06001BB0 RID: 7088 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BB0")]
	[Address(RVA = "0x7E1F00", Offset = "0x7E0500", VA = "0x1807E1F00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001BB1 RID: 7089 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BB1")]
	[Address(RVA = "0x7E2350", Offset = "0x7E0950", VA = "0x1807E2350")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DeathMarkerRequest Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001BB2 RID: 7090 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BB2")]
	[Address(RVA = "0x7E2360", Offset = "0x7E0960", VA = "0x1807E2360")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DeathMarkerRequest Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001BB3 RID: 7091 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BB3")]
	[Address(RVA = "0x7E2560", Offset = "0x7E0B60", VA = "0x1807E2560")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static DeathMarkerRequest Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001BB4 RID: 7092 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BB4")]
	[Address(RVA = "0x7E2680", Offset = "0x7E0C80", VA = "0x1807E2680")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DeathMarkerRequest Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001BB5 RID: 7093 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BB5")]
	[Address(RVA = "0x7E2690", Offset = "0x7E0C90", VA = "0x1807E2690")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DeathMarkerRequest Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001BB6 RID: 7094 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BB6")]
	[Address(RVA = "0x7E26A0", Offset = "0x7E0CA0", VA = "0x1807E26A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DeathMarkerRequest Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001BB7 RID: 7095 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BB7")]
	[Address(RVA = "0x7E26B0", Offset = "0x7E0CB0", VA = "0x1807E26B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DeathMarkerRequest Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001BB8 RID: 7096 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BB8")]
	[Address(RVA = "0x7E26D0", Offset = "0x7E0CD0", VA = "0x1807E26D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DeathMarkerRequest Raise()
	{
		return null;
	}

	// Token: 0x06001BB9 RID: 7097 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BB9")]
	[Address(RVA = "0x7E26F0", Offset = "0x7E0CF0", VA = "0x1807E26F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DeathMarkerRequest Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001BBA RID: 7098 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BBA")]
	[Address(RVA = "0x7E2350", Offset = "0x7E0950", VA = "0x1807E2350")]
	public static DeathMarkerRequest Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001BBB RID: 7099 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BBB")]
	[Address(RVA = "0x7E2700", Offset = "0x7E0D00", VA = "0x1807E2700")]
	public static DeathMarkerRequest Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001BBC RID: 7100 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BBC")]
	[Address(RVA = "0x7E2900", Offset = "0x7E0F00", VA = "0x1807E2900")]
	private static DeathMarkerRequest Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001BBD RID: 7101 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BBD")]
	[Address(RVA = "0x7E2680", Offset = "0x7E0C80", VA = "0x1807E2680")]
	public static DeathMarkerRequest Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001BBE RID: 7102 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BBE")]
	[Address(RVA = "0x7E2690", Offset = "0x7E0C90", VA = "0x1807E2690")]
	public static DeathMarkerRequest Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001BBF RID: 7103 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BBF")]
	[Address(RVA = "0x7E26A0", Offset = "0x7E0CA0", VA = "0x1807E26A0")]
	public static DeathMarkerRequest Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001BC0 RID: 7104 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BC0")]
	[Address(RVA = "0x7E26B0", Offset = "0x7E0CB0", VA = "0x1807E26B0")]
	public static DeathMarkerRequest Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001BC1 RID: 7105 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BC1")]
	[Address(RVA = "0x7E26D0", Offset = "0x7E0CD0", VA = "0x1807E26D0")]
	public static DeathMarkerRequest Create()
	{
		return null;
	}

	// Token: 0x06001BC2 RID: 7106 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BC2")]
	[Address(RVA = "0x7E26F0", Offset = "0x7E0CF0", VA = "0x1807E26F0")]
	public static DeathMarkerRequest Create(ReliabilityModes reliability)
	{
		return null;
	}
}
