using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000186 RID: 390
[Token(Token = "0x2000186")]
public class PlaceDryingFood : Event
{
	// Token: 0x060011C9 RID: 4553 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011C9")]
	[Address(RVA = "0x887ED0", Offset = "0x8864D0", VA = "0x180887ED0")]
	public PlaceDryingFood()
	{
	}

	// Token: 0x17000602 RID: 1538
	// (get) Token: 0x060011CA RID: 4554 RVA: 0x00006888 File Offset: 0x00004A88
	// (set) Token: 0x060011CB RID: 4555 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000602")]
	public Vector3 Position
	{
		[Token(Token = "0x60011CA")]
		[Address(RVA = "0x7D3CB0", Offset = "0x7D22B0", VA = "0x1807D3CB0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60011CB")]
		[Address(RVA = "0x7DD4E0", Offset = "0x7DBAE0", VA = "0x1807DD4E0")]
		set
		{
		}
	}

	// Token: 0x17000603 RID: 1539
	// (get) Token: 0x060011CC RID: 4556 RVA: 0x000068A0 File Offset: 0x00004AA0
	// (set) Token: 0x060011CD RID: 4557 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000603")]
	public Quaternion Rotation
	{
		[Token(Token = "0x60011CC")]
		[Address(RVA = "0x7FBD60", Offset = "0x7FA360", VA = "0x1807FBD60")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x60011CD")]
		[Address(RVA = "0x7FBDD0", Offset = "0x7FA3D0", VA = "0x1807FBDD0")]
		set
		{
		}
	}

	// Token: 0x17000604 RID: 1540
	// (get) Token: 0x060011CE RID: 4558 RVA: 0x000068B8 File Offset: 0x00004AB8
	// (set) Token: 0x060011CF RID: 4559 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000604")]
	public PrefabId PrefabId
	{
		[Token(Token = "0x60011CE")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return default(PrefabId);
		}
		[Token(Token = "0x60011CF")]
		[Address(RVA = "0x835B10", Offset = "0x834110", VA = "0x180835B10")]
		set
		{
		}
	}

	// Token: 0x17000605 RID: 1541
	// (get) Token: 0x060011D0 RID: 4560 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060011D1 RID: 4561 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000605")]
	public BoltEntity Parent
	{
		[Token(Token = "0x60011D0")]
		[Address(RVA = "0x7BEA80", Offset = "0x7BD080", VA = "0x1807BEA80")]
		get
		{
			return null;
		}
		[Token(Token = "0x60011D1")]
		[Address(RVA = "0x887F30", Offset = "0x886530", VA = "0x180887F30")]
		set
		{
		}
	}

	// Token: 0x17000606 RID: 1542
	// (get) Token: 0x060011D2 RID: 4562 RVA: 0x000068D0 File Offset: 0x00004AD0
	// (set) Token: 0x060011D3 RID: 4563 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000606")]
	public int DecayState
	{
		[Token(Token = "0x60011D2")]
		[Address(RVA = "0x7BB500", Offset = "0x7B9B00", VA = "0x1807BB500")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60011D3")]
		[Address(RVA = "0x888150", Offset = "0x886750", VA = "0x180888150")]
		set
		{
		}
	}

	// Token: 0x060011D4 RID: 4564 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011D4")]
	[Address(RVA = "0x888200", Offset = "0x886800", VA = "0x180888200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060011D5 RID: 4565 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011D5")]
	[Address(RVA = "0x8885F0", Offset = "0x886BF0", VA = "0x1808885F0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceDryingFood Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060011D6 RID: 4566 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011D6")]
	[Address(RVA = "0x888600", Offset = "0x886C00", VA = "0x180888600")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceDryingFood Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060011D7 RID: 4567 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011D7")]
	[Address(RVA = "0x888800", Offset = "0x886E00", VA = "0x180888800")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static PlaceDryingFood Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060011D8 RID: 4568 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011D8")]
	[Address(RVA = "0x888920", Offset = "0x886F20", VA = "0x180888920")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceDryingFood Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060011D9 RID: 4569 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011D9")]
	[Address(RVA = "0x888930", Offset = "0x886F30", VA = "0x180888930")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceDryingFood Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060011DA RID: 4570 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011DA")]
	[Address(RVA = "0x888940", Offset = "0x886F40", VA = "0x180888940")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceDryingFood Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060011DB RID: 4571 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011DB")]
	[Address(RVA = "0x888950", Offset = "0x886F50", VA = "0x180888950")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceDryingFood Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060011DC RID: 4572 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011DC")]
	[Address(RVA = "0x888970", Offset = "0x886F70", VA = "0x180888970")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceDryingFood Raise()
	{
		return null;
	}

	// Token: 0x060011DD RID: 4573 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011DD")]
	[Address(RVA = "0x888990", Offset = "0x886F90", VA = "0x180888990")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceDryingFood Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060011DE RID: 4574 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011DE")]
	[Address(RVA = "0x8885F0", Offset = "0x886BF0", VA = "0x1808885F0")]
	public static PlaceDryingFood Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060011DF RID: 4575 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011DF")]
	[Address(RVA = "0x8889A0", Offset = "0x886FA0", VA = "0x1808889A0")]
	public static PlaceDryingFood Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060011E0 RID: 4576 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011E0")]
	[Address(RVA = "0x888BA0", Offset = "0x8871A0", VA = "0x180888BA0")]
	private static PlaceDryingFood Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060011E1 RID: 4577 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011E1")]
	[Address(RVA = "0x888920", Offset = "0x886F20", VA = "0x180888920")]
	public static PlaceDryingFood Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060011E2 RID: 4578 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011E2")]
	[Address(RVA = "0x888930", Offset = "0x886F30", VA = "0x180888930")]
	public static PlaceDryingFood Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060011E3 RID: 4579 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011E3")]
	[Address(RVA = "0x888940", Offset = "0x886F40", VA = "0x180888940")]
	public static PlaceDryingFood Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060011E4 RID: 4580 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011E4")]
	[Address(RVA = "0x888950", Offset = "0x886F50", VA = "0x180888950")]
	public static PlaceDryingFood Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060011E5 RID: 4581 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011E5")]
	[Address(RVA = "0x888970", Offset = "0x886F70", VA = "0x180888970")]
	public static PlaceDryingFood Create()
	{
		return null;
	}

	// Token: 0x060011E6 RID: 4582 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60011E6")]
	[Address(RVA = "0x888990", Offset = "0x886F90", VA = "0x180888990")]
	public static PlaceDryingFood Create(ReliabilityModes reliability)
	{
		return null;
	}
}
