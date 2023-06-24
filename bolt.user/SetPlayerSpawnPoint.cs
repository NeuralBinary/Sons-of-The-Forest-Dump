using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A6 RID: 678
[Token(Token = "0x20002A6")]
public class SetPlayerSpawnPoint : Event
{
	// Token: 0x06001EFF RID: 7935 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EFF")]
	[Address(RVA = "0x7FBD00", Offset = "0x7FA300", VA = "0x1807FBD00")]
	public SetPlayerSpawnPoint()
	{
	}

	// Token: 0x17000849 RID: 2121
	// (get) Token: 0x06001F00 RID: 7936 RVA: 0x00008E50 File Offset: 0x00007050
	// (set) Token: 0x06001F01 RID: 7937 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000849")]
	public Vector3 Position
	{
		[Token(Token = "0x6001F00")]
		[Address(RVA = "0x7D3CB0", Offset = "0x7D22B0", VA = "0x1807D3CB0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001F01")]
		[Address(RVA = "0x7DD4E0", Offset = "0x7DBAE0", VA = "0x1807DD4E0")]
		set
		{
		}
	}

	// Token: 0x1700084A RID: 2122
	// (get) Token: 0x06001F02 RID: 7938 RVA: 0x00008E68 File Offset: 0x00007068
	// (set) Token: 0x06001F03 RID: 7939 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700084A")]
	public Quaternion Rotation
	{
		[Token(Token = "0x6001F02")]
		[Address(RVA = "0x7FBD60", Offset = "0x7FA360", VA = "0x1807FBD60")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6001F03")]
		[Address(RVA = "0x7FBDD0", Offset = "0x7FA3D0", VA = "0x1807FBDD0")]
		set
		{
		}
	}

	// Token: 0x1700084B RID: 2123
	// (get) Token: 0x06001F04 RID: 7940 RVA: 0x00008E80 File Offset: 0x00007080
	// (set) Token: 0x06001F05 RID: 7941 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700084B")]
	public int Race
	{
		[Token(Token = "0x6001F04")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001F05")]
		[Address(RVA = "0x7D6E60", Offset = "0x7D5460", VA = "0x1807D6E60")]
		set
		{
		}
	}

	// Token: 0x06001F06 RID: 7942 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F06")]
	[Address(RVA = "0x7FBE70", Offset = "0x7FA470", VA = "0x1807FBE70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001F07 RID: 7943 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F07")]
	[Address(RVA = "0x7FC020", Offset = "0x7FA620", VA = "0x1807FC020")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetPlayerSpawnPoint Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001F08 RID: 7944 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F08")]
	[Address(RVA = "0x7FC030", Offset = "0x7FA630", VA = "0x1807FC030")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetPlayerSpawnPoint Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001F09 RID: 7945 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F09")]
	[Address(RVA = "0x7FC230", Offset = "0x7FA830", VA = "0x1807FC230")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static SetPlayerSpawnPoint Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001F0A RID: 7946 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F0A")]
	[Address(RVA = "0x7FC350", Offset = "0x7FA950", VA = "0x1807FC350")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetPlayerSpawnPoint Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001F0B RID: 7947 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F0B")]
	[Address(RVA = "0x7FC360", Offset = "0x7FA960", VA = "0x1807FC360")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetPlayerSpawnPoint Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001F0C RID: 7948 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F0C")]
	[Address(RVA = "0x7FC370", Offset = "0x7FA970", VA = "0x1807FC370")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetPlayerSpawnPoint Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001F0D RID: 7949 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F0D")]
	[Address(RVA = "0x7FC380", Offset = "0x7FA980", VA = "0x1807FC380")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetPlayerSpawnPoint Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001F0E RID: 7950 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F0E")]
	[Address(RVA = "0x7FC3A0", Offset = "0x7FA9A0", VA = "0x1807FC3A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetPlayerSpawnPoint Raise()
	{
		return null;
	}

	// Token: 0x06001F0F RID: 7951 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F0F")]
	[Address(RVA = "0x7FC3C0", Offset = "0x7FA9C0", VA = "0x1807FC3C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SetPlayerSpawnPoint Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001F10 RID: 7952 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F10")]
	[Address(RVA = "0x7FC020", Offset = "0x7FA620", VA = "0x1807FC020")]
	public static SetPlayerSpawnPoint Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001F11 RID: 7953 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F11")]
	[Address(RVA = "0x7FC3D0", Offset = "0x7FA9D0", VA = "0x1807FC3D0")]
	public static SetPlayerSpawnPoint Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001F12 RID: 7954 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F12")]
	[Address(RVA = "0x7FC5D0", Offset = "0x7FABD0", VA = "0x1807FC5D0")]
	private static SetPlayerSpawnPoint Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001F13 RID: 7955 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F13")]
	[Address(RVA = "0x7FC350", Offset = "0x7FA950", VA = "0x1807FC350")]
	public static SetPlayerSpawnPoint Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001F14 RID: 7956 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F14")]
	[Address(RVA = "0x7FC360", Offset = "0x7FA960", VA = "0x1807FC360")]
	public static SetPlayerSpawnPoint Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001F15 RID: 7957 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F15")]
	[Address(RVA = "0x7FC370", Offset = "0x7FA970", VA = "0x1807FC370")]
	public static SetPlayerSpawnPoint Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001F16 RID: 7958 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F16")]
	[Address(RVA = "0x7FC380", Offset = "0x7FA980", VA = "0x1807FC380")]
	public static SetPlayerSpawnPoint Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001F17 RID: 7959 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F17")]
	[Address(RVA = "0x7FC3A0", Offset = "0x7FA9A0", VA = "0x1807FC3A0")]
	public static SetPlayerSpawnPoint Create()
	{
		return null;
	}

	// Token: 0x06001F18 RID: 7960 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F18")]
	[Address(RVA = "0x7FC3C0", Offset = "0x7FA9C0", VA = "0x1807FC3C0")]
	public static SetPlayerSpawnPoint Create(ReliabilityModes reliability)
	{
		return null;
	}
}
