using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200015C RID: 348
[Token(Token = "0x200015C")]
public class PushRaft : Event
{
	// Token: 0x06000FF1 RID: 4081 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FF1")]
	[Address(RVA = "0x8792A0", Offset = "0x8778A0", VA = "0x1808792A0")]
	public PushRaft()
	{
	}

	// Token: 0x170005BE RID: 1470
	// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x000064E0 File Offset: 0x000046E0
	// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005BE")]
	public Vector3 Direction
	{
		[Token(Token = "0x6000FF2")]
		[Address(RVA = "0x7D3CB0", Offset = "0x7D22B0", VA = "0x1807D3CB0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000FF3")]
		[Address(RVA = "0x7DD4E0", Offset = "0x7DBAE0", VA = "0x1807DD4E0")]
		set
		{
		}
	}

	// Token: 0x170005BF RID: 1471
	// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005BF")]
	public BoltEntity Raft
	{
		[Token(Token = "0x6000FF4")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7D99B0", VA = "0x1807DB3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000FF5")]
		[Address(RVA = "0x879300", Offset = "0x877900", VA = "0x180879300")]
		set
		{
		}
	}

	// Token: 0x06000FF6 RID: 4086 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FF6")]
	[Address(RVA = "0x879510", Offset = "0x877B10", VA = "0x180879510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000FF7 RID: 4087 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FF7")]
	[Address(RVA = "0x879660", Offset = "0x877C60", VA = "0x180879660")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PushRaft Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000FF8 RID: 4088 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FF8")]
	[Address(RVA = "0x879670", Offset = "0x877C70", VA = "0x180879670")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PushRaft Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000FF9 RID: 4089 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FF9")]
	[Address(RVA = "0x879870", Offset = "0x877E70", VA = "0x180879870")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static PushRaft Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000FFA RID: 4090 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FFA")]
	[Address(RVA = "0x879990", Offset = "0x877F90", VA = "0x180879990")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PushRaft Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000FFB RID: 4091 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FFB")]
	[Address(RVA = "0x8799A0", Offset = "0x877FA0", VA = "0x1808799A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PushRaft Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000FFC RID: 4092 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FFC")]
	[Address(RVA = "0x8799B0", Offset = "0x877FB0", VA = "0x1808799B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PushRaft Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000FFD RID: 4093 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FFD")]
	[Address(RVA = "0x8799C0", Offset = "0x877FC0", VA = "0x1808799C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PushRaft Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000FFE RID: 4094 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FFE")]
	[Address(RVA = "0x8799E0", Offset = "0x877FE0", VA = "0x1808799E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PushRaft Raise()
	{
		return null;
	}

	// Token: 0x06000FFF RID: 4095 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FFF")]
	[Address(RVA = "0x879A00", Offset = "0x878000", VA = "0x180879A00")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PushRaft Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001000 RID: 4096 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001000")]
	[Address(RVA = "0x879660", Offset = "0x877C60", VA = "0x180879660")]
	public static PushRaft Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001001 RID: 4097 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001001")]
	[Address(RVA = "0x879A10", Offset = "0x878010", VA = "0x180879A10")]
	public static PushRaft Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001002 RID: 4098 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001002")]
	[Address(RVA = "0x879C10", Offset = "0x878210", VA = "0x180879C10")]
	private static PushRaft Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001003 RID: 4099 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001003")]
	[Address(RVA = "0x879990", Offset = "0x877F90", VA = "0x180879990")]
	public static PushRaft Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001004 RID: 4100 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001004")]
	[Address(RVA = "0x8799A0", Offset = "0x877FA0", VA = "0x1808799A0")]
	public static PushRaft Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001005 RID: 4101 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001005")]
	[Address(RVA = "0x8799B0", Offset = "0x877FB0", VA = "0x1808799B0")]
	public static PushRaft Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001006 RID: 4102 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001006")]
	[Address(RVA = "0x8799C0", Offset = "0x877FC0", VA = "0x1808799C0")]
	public static PushRaft Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001007 RID: 4103 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001007")]
	[Address(RVA = "0x8799E0", Offset = "0x877FE0", VA = "0x1808799E0")]
	public static PushRaft Create()
	{
		return null;
	}

	// Token: 0x06001008 RID: 4104 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001008")]
	[Address(RVA = "0x879A00", Offset = "0x878000", VA = "0x180879A00")]
	public static PushRaft Create(ReliabilityModes reliability)
	{
		return null;
	}
}
