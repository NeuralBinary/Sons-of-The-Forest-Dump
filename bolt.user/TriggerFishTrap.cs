using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001B3 RID: 435
[Token(Token = "0x20001B3")]
public class TriggerFishTrap : Event
{
	// Token: 0x060013D5 RID: 5077 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013D5")]
	[Address(RVA = "0x898E80", Offset = "0x897480", VA = "0x180898E80")]
	public TriggerFishTrap()
	{
	}

	// Token: 0x17000656 RID: 1622
	// (get) Token: 0x060013D6 RID: 5078 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060013D7 RID: 5079 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000656")]
	public BoltEntity Trap
	{
		[Token(Token = "0x60013D6")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60013D7")]
		[Address(RVA = "0x898EE0", Offset = "0x8974E0", VA = "0x180898EE0")]
		set
		{
		}
	}

	// Token: 0x17000657 RID: 1623
	// (get) Token: 0x060013D8 RID: 5080 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060013D9 RID: 5081 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000657")]
	public string Fish
	{
		[Token(Token = "0x60013D8")]
		[Address(RVA = "0x83FC10", Offset = "0x83E210", VA = "0x18083FC10")]
		get
		{
			return null;
		}
		[Token(Token = "0x60013D9")]
		[Address(RVA = "0x83FCB0", Offset = "0x83E2B0", VA = "0x18083FCB0")]
		set
		{
		}
	}

	// Token: 0x17000658 RID: 1624
	// (get) Token: 0x060013DA RID: 5082 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060013DB RID: 5083 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000658")]
	public string Spawnner
	{
		[Token(Token = "0x60013DA")]
		[Address(RVA = "0x82C9C0", Offset = "0x82AFC0", VA = "0x18082C9C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60013DB")]
		[Address(RVA = "0x893010", Offset = "0x891610", VA = "0x180893010")]
		set
		{
		}
	}

	// Token: 0x17000659 RID: 1625
	// (get) Token: 0x060013DC RID: 5084 RVA: 0x00006D80 File Offset: 0x00004F80
	// (set) Token: 0x060013DD RID: 5085 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000659")]
	public Vector3 Position
	{
		[Token(Token = "0x60013DC")]
		[Address(RVA = "0x7D5EB0", Offset = "0x7D44B0", VA = "0x1807D5EB0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60013DD")]
		[Address(RVA = "0x83E5C0", Offset = "0x83CBC0", VA = "0x18083E5C0")]
		set
		{
		}
	}

	// Token: 0x060013DE RID: 5086 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013DE")]
	[Address(RVA = "0x8990F0", Offset = "0x8976F0", VA = "0x1808990F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060013DF RID: 5087 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013DF")]
	[Address(RVA = "0x899480", Offset = "0x897A80", VA = "0x180899480")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TriggerFishTrap Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060013E0 RID: 5088 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013E0")]
	[Address(RVA = "0x899490", Offset = "0x897A90", VA = "0x180899490")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TriggerFishTrap Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060013E1 RID: 5089 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013E1")]
	[Address(RVA = "0x899690", Offset = "0x897C90", VA = "0x180899690")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static TriggerFishTrap Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060013E2 RID: 5090 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013E2")]
	[Address(RVA = "0x8997B0", Offset = "0x897DB0", VA = "0x1808997B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TriggerFishTrap Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060013E3 RID: 5091 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013E3")]
	[Address(RVA = "0x8997C0", Offset = "0x897DC0", VA = "0x1808997C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TriggerFishTrap Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060013E4 RID: 5092 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013E4")]
	[Address(RVA = "0x8997D0", Offset = "0x897DD0", VA = "0x1808997D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TriggerFishTrap Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060013E5 RID: 5093 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013E5")]
	[Address(RVA = "0x8997E0", Offset = "0x897DE0", VA = "0x1808997E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TriggerFishTrap Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060013E6 RID: 5094 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013E6")]
	[Address(RVA = "0x899800", Offset = "0x897E00", VA = "0x180899800")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TriggerFishTrap Raise()
	{
		return null;
	}

	// Token: 0x060013E7 RID: 5095 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013E7")]
	[Address(RVA = "0x899820", Offset = "0x897E20", VA = "0x180899820")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static TriggerFishTrap Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060013E8 RID: 5096 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013E8")]
	[Address(RVA = "0x899480", Offset = "0x897A80", VA = "0x180899480")]
	public static TriggerFishTrap Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060013E9 RID: 5097 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013E9")]
	[Address(RVA = "0x899830", Offset = "0x897E30", VA = "0x180899830")]
	public static TriggerFishTrap Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060013EA RID: 5098 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013EA")]
	[Address(RVA = "0x899A30", Offset = "0x898030", VA = "0x180899A30")]
	private static TriggerFishTrap Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060013EB RID: 5099 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013EB")]
	[Address(RVA = "0x8997B0", Offset = "0x897DB0", VA = "0x1808997B0")]
	public static TriggerFishTrap Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060013EC RID: 5100 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013EC")]
	[Address(RVA = "0x8997C0", Offset = "0x897DC0", VA = "0x1808997C0")]
	public static TriggerFishTrap Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060013ED RID: 5101 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013ED")]
	[Address(RVA = "0x8997D0", Offset = "0x897DD0", VA = "0x1808997D0")]
	public static TriggerFishTrap Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060013EE RID: 5102 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013EE")]
	[Address(RVA = "0x8997E0", Offset = "0x897DE0", VA = "0x1808997E0")]
	public static TriggerFishTrap Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060013EF RID: 5103 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013EF")]
	[Address(RVA = "0x899800", Offset = "0x897E00", VA = "0x180899800")]
	public static TriggerFishTrap Create()
	{
		return null;
	}

	// Token: 0x060013F0 RID: 5104 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013F0")]
	[Address(RVA = "0x899820", Offset = "0x897E20", VA = "0x180899820")]
	public static TriggerFishTrap Create(ReliabilityModes reliability)
	{
		return null;
	}
}
