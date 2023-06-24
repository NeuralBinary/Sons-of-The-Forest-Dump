using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000C0 RID: 192
[Token(Token = "0x20000C0")]
public class SpawnImpactEffect : Event
{
	// Token: 0x060008D5 RID: 2261 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008D5")]
	[Address(RVA = "0x83CA60", Offset = "0x83B060", VA = "0x18083CA60")]
	public SpawnImpactEffect()
	{
	}

	// Token: 0x1700049E RID: 1182
	// (get) Token: 0x060008D6 RID: 2262 RVA: 0x00005370 File Offset: 0x00003570
	// (set) Token: 0x060008D7 RID: 2263 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700049E")]
	public Vector3 Position
	{
		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x7D3CB0", Offset = "0x7D22B0", VA = "0x1807D3CB0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x83CAC0", Offset = "0x83B0C0", VA = "0x18083CAC0")]
		set
		{
		}
	}

	// Token: 0x1700049F RID: 1183
	// (get) Token: 0x060008D8 RID: 2264 RVA: 0x00005388 File Offset: 0x00003588
	// (set) Token: 0x060008D9 RID: 2265 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700049F")]
	public Quaternion Rotation
	{
		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x7FBD60", Offset = "0x7FA360", VA = "0x1807FBD60")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x7FBDD0", Offset = "0x7FA3D0", VA = "0x1807FBDD0")]
		set
		{
		}
	}

	// Token: 0x170004A0 RID: 1184
	// (get) Token: 0x060008DA RID: 2266 RVA: 0x000053A0 File Offset: 0x000035A0
	// (set) Token: 0x060008DB RID: 2267 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004A0")]
	public int Type
	{
		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x83CBD0", Offset = "0x83B1D0", VA = "0x18083CBD0")]
		set
		{
		}
	}

	// Token: 0x170004A1 RID: 1185
	// (get) Token: 0x060008DC RID: 2268 RVA: 0x000053B8 File Offset: 0x000035B8
	// (set) Token: 0x060008DD RID: 2269 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004A1")]
	public Vector3 Velocity
	{
		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x7D5EB0", Offset = "0x7D44B0", VA = "0x1807D5EB0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x83CC80", Offset = "0x83B280", VA = "0x18083CC80")]
		set
		{
		}
	}

	// Token: 0x060008DE RID: 2270 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008DE")]
	[Address(RVA = "0x83CD90", Offset = "0x83B390", VA = "0x18083CD90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060008DF RID: 2271 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008DF")]
	[Address(RVA = "0x83D0C0", Offset = "0x83B6C0", VA = "0x18083D0C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SpawnImpactEffect Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060008E0 RID: 2272 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008E0")]
	[Address(RVA = "0x83D0D0", Offset = "0x83B6D0", VA = "0x18083D0D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SpawnImpactEffect Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060008E1 RID: 2273 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008E1")]
	[Address(RVA = "0x83D2F0", Offset = "0x83B8F0", VA = "0x18083D2F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static SpawnImpactEffect Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060008E2 RID: 2274 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008E2")]
	[Address(RVA = "0x83D410", Offset = "0x83BA10", VA = "0x18083D410")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SpawnImpactEffect Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060008E3 RID: 2275 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008E3")]
	[Address(RVA = "0x83D420", Offset = "0x83BA20", VA = "0x18083D420")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SpawnImpactEffect Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060008E4 RID: 2276 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008E4")]
	[Address(RVA = "0x83D430", Offset = "0x83BA30", VA = "0x18083D430")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SpawnImpactEffect Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060008E5 RID: 2277 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008E5")]
	[Address(RVA = "0x83D440", Offset = "0x83BA40", VA = "0x18083D440")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SpawnImpactEffect Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060008E6 RID: 2278 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008E6")]
	[Address(RVA = "0x83D460", Offset = "0x83BA60", VA = "0x18083D460")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SpawnImpactEffect Raise()
	{
		return null;
	}

	// Token: 0x060008E7 RID: 2279 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008E7")]
	[Address(RVA = "0x83D480", Offset = "0x83BA80", VA = "0x18083D480")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static SpawnImpactEffect Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060008E8 RID: 2280 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008E8")]
	[Address(RVA = "0x83D0C0", Offset = "0x83B6C0", VA = "0x18083D0C0")]
	public static SpawnImpactEffect Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060008E9 RID: 2281 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008E9")]
	[Address(RVA = "0x83D490", Offset = "0x83BA90", VA = "0x18083D490")]
	public static SpawnImpactEffect Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060008EA RID: 2282 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008EA")]
	[Address(RVA = "0x83D6B0", Offset = "0x83BCB0", VA = "0x18083D6B0")]
	private static SpawnImpactEffect Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060008EB RID: 2283 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008EB")]
	[Address(RVA = "0x83D410", Offset = "0x83BA10", VA = "0x18083D410")]
	public static SpawnImpactEffect Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060008EC RID: 2284 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008EC")]
	[Address(RVA = "0x83D420", Offset = "0x83BA20", VA = "0x18083D420")]
	public static SpawnImpactEffect Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060008ED RID: 2285 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008ED")]
	[Address(RVA = "0x83D430", Offset = "0x83BA30", VA = "0x18083D430")]
	public static SpawnImpactEffect Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060008EE RID: 2286 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008EE")]
	[Address(RVA = "0x83D440", Offset = "0x83BA40", VA = "0x18083D440")]
	public static SpawnImpactEffect Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060008EF RID: 2287 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008EF")]
	[Address(RVA = "0x83D460", Offset = "0x83BA60", VA = "0x18083D460")]
	public static SpawnImpactEffect Create()
	{
		return null;
	}

	// Token: 0x060008F0 RID: 2288 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008F0")]
	[Address(RVA = "0x83D480", Offset = "0x83BA80", VA = "0x18083D480")]
	public static SpawnImpactEffect Create(ReliabilityModes reliability)
	{
		return null;
	}
}
