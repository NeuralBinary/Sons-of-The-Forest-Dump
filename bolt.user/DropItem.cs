using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000BD RID: 189
[Token(Token = "0x20000BD")]
public class DropItem : Event
{
	// Token: 0x060008A3 RID: 2211 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008A3")]
	[Address(RVA = "0x83A180", Offset = "0x838780", VA = "0x18083A180")]
	public DropItem()
	{
	}

	// Token: 0x17000491 RID: 1169
	// (get) Token: 0x060008A4 RID: 2212 RVA: 0x00005280 File Offset: 0x00003480
	// (set) Token: 0x060008A5 RID: 2213 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000491")]
	public PrefabId PrefabId
	{
		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x83A1E0", Offset = "0x8387E0", VA = "0x18083A1E0")]
		get
		{
			return default(PrefabId);
		}
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x83A230", Offset = "0x838830", VA = "0x18083A230")]
		set
		{
		}
	}

	// Token: 0x17000492 RID: 1170
	// (get) Token: 0x060008A6 RID: 2214 RVA: 0x00005298 File Offset: 0x00003498
	// (set) Token: 0x060008A7 RID: 2215 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000492")]
	public Vector3 Position
	{
		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x7BCBD0", Offset = "0x7BB1D0", VA = "0x1807BCBD0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x7DD580", Offset = "0x7DBB80", VA = "0x1807DD580")]
		set
		{
		}
	}

	// Token: 0x17000493 RID: 1171
	// (get) Token: 0x060008A8 RID: 2216 RVA: 0x000052B0 File Offset: 0x000034B0
	// (set) Token: 0x060008A9 RID: 2217 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000493")]
	public Quaternion Rotation
	{
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x7BCDA0", Offset = "0x7BB3A0", VA = "0x1807BCDA0")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x83A2C0", Offset = "0x8388C0", VA = "0x18083A2C0")]
		set
		{
		}
	}

	// Token: 0x17000494 RID: 1172
	// (get) Token: 0x060008AA RID: 2218 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060008AB RID: 2219 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000494")]
	public BoltEntity PreSpawned
	{
		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x7BEA80", Offset = "0x7BD080", VA = "0x1807BEA80")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x83A360", Offset = "0x838960", VA = "0x18083A360")]
		set
		{
		}
	}

	// Token: 0x17000495 RID: 1173
	// (get) Token: 0x060008AC RID: 2220 RVA: 0x000052C8 File Offset: 0x000034C8
	// (set) Token: 0x060008AD RID: 2221 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000495")]
	public bool AvoidImpacts
	{
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x7BBF10", Offset = "0x7BA510", VA = "0x1807BBF10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x835BB0", Offset = "0x8341B0", VA = "0x180835BB0")]
		set
		{
		}
	}

	// Token: 0x17000496 RID: 1174
	// (get) Token: 0x060008AE RID: 2222 RVA: 0x000052E0 File Offset: 0x000034E0
	// (set) Token: 0x060008AF RID: 2223 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000496")]
	public Vector3 Velocity
	{
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x83A580", Offset = "0x838B80", VA = "0x18083A580")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x83A600", Offset = "0x838C00", VA = "0x18083A600")]
		set
		{
		}
	}

	// Token: 0x17000497 RID: 1175
	// (get) Token: 0x060008B0 RID: 2224 RVA: 0x000052F8 File Offset: 0x000034F8
	// (set) Token: 0x060008B1 RID: 2225 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000497")]
	public Vector3 Torque
	{
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x83A710", Offset = "0x838D10", VA = "0x18083A710")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x83A790", Offset = "0x838D90", VA = "0x18083A790")]
		set
		{
		}
	}

	// Token: 0x17000498 RID: 1176
	// (get) Token: 0x060008B2 RID: 2226 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060008B3 RID: 2227 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000498")]
	public IProtocolToken ItemInstance
	{
		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x83A8A0", Offset = "0x838EA0", VA = "0x18083A8A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x83A950", Offset = "0x838F50", VA = "0x18083A950")]
		set
		{
		}
	}

	// Token: 0x17000499 RID: 1177
	// (get) Token: 0x060008B4 RID: 2228 RVA: 0x00005310 File Offset: 0x00003510
	// (set) Token: 0x060008B5 RID: 2229 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000499")]
	public bool ShouldDespawn
	{
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x82D170", Offset = "0x82B770", VA = "0x18082D170")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x83AAA0", Offset = "0x8390A0", VA = "0x18083AAA0")]
		set
		{
		}
	}

	// Token: 0x1700049A RID: 1178
	// (get) Token: 0x060008B6 RID: 2230 RVA: 0x00005328 File Offset: 0x00003528
	// (set) Token: 0x060008B7 RID: 2231 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700049A")]
	public bool IsKinematic
	{
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x82D2C0", Offset = "0x82B8C0", VA = "0x18082D2C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x83AB40", Offset = "0x839140", VA = "0x18083AB40")]
		set
		{
		}
	}

	// Token: 0x060008B8 RID: 2232 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008B8")]
	[Address(RVA = "0x83ABE0", Offset = "0x8391E0", VA = "0x18083ABE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060008B9 RID: 2233 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008B9")]
	[Address(RVA = "0x83B240", Offset = "0x839840", VA = "0x18083B240")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DropItem Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060008BA RID: 2234 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008BA")]
	[Address(RVA = "0x83B250", Offset = "0x839850", VA = "0x18083B250")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DropItem Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060008BB RID: 2235 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008BB")]
	[Address(RVA = "0x83B450", Offset = "0x839A50", VA = "0x18083B450")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static DropItem Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060008BC RID: 2236 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008BC")]
	[Address(RVA = "0x83B570", Offset = "0x839B70", VA = "0x18083B570")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DropItem Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060008BD RID: 2237 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008BD")]
	[Address(RVA = "0x83B580", Offset = "0x839B80", VA = "0x18083B580")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DropItem Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060008BE RID: 2238 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008BE")]
	[Address(RVA = "0x83B590", Offset = "0x839B90", VA = "0x18083B590")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DropItem Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060008BF RID: 2239 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008BF")]
	[Address(RVA = "0x83B5A0", Offset = "0x839BA0", VA = "0x18083B5A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DropItem Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060008C0 RID: 2240 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008C0")]
	[Address(RVA = "0x83B5C0", Offset = "0x839BC0", VA = "0x18083B5C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DropItem Raise()
	{
		return null;
	}

	// Token: 0x060008C1 RID: 2241 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008C1")]
	[Address(RVA = "0x83B5E0", Offset = "0x839BE0", VA = "0x18083B5E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DropItem Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060008C2 RID: 2242 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008C2")]
	[Address(RVA = "0x83B240", Offset = "0x839840", VA = "0x18083B240")]
	public static DropItem Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060008C3 RID: 2243 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008C3")]
	[Address(RVA = "0x83B5F0", Offset = "0x839BF0", VA = "0x18083B5F0")]
	public static DropItem Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060008C4 RID: 2244 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008C4")]
	[Address(RVA = "0x83B7F0", Offset = "0x839DF0", VA = "0x18083B7F0")]
	private static DropItem Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060008C5 RID: 2245 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008C5")]
	[Address(RVA = "0x83B570", Offset = "0x839B70", VA = "0x18083B570")]
	public static DropItem Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060008C6 RID: 2246 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008C6")]
	[Address(RVA = "0x83B580", Offset = "0x839B80", VA = "0x18083B580")]
	public static DropItem Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060008C7 RID: 2247 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008C7")]
	[Address(RVA = "0x83B590", Offset = "0x839B90", VA = "0x18083B590")]
	public static DropItem Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060008C8 RID: 2248 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008C8")]
	[Address(RVA = "0x83B5A0", Offset = "0x839BA0", VA = "0x18083B5A0")]
	public static DropItem Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060008C9 RID: 2249 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008C9")]
	[Address(RVA = "0x83B5C0", Offset = "0x839BC0", VA = "0x18083B5C0")]
	public static DropItem Create()
	{
		return null;
	}

	// Token: 0x060008CA RID: 2250 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008CA")]
	[Address(RVA = "0x83B5E0", Offset = "0x839BE0", VA = "0x18083B5E0")]
	public static DropItem Create(ReliabilityModes reliability)
	{
		return null;
	}
}
