using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200017D RID: 381
[Token(Token = "0x200017D")]
public class DropBodyEvent : Event
{
	// Token: 0x0600115F RID: 4447 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600115F")]
	[Address(RVA = "0x884690", Offset = "0x882C90", VA = "0x180884690")]
	public DropBodyEvent()
	{
	}

	// Token: 0x170005F1 RID: 1521
	// (get) Token: 0x06001160 RID: 4448 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001161 RID: 4449 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005F1")]
	public BoltEntity Target
	{
		[Token(Token = "0x6001160")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001161")]
		[Address(RVA = "0x8846F0", Offset = "0x882CF0", VA = "0x1808846F0")]
		set
		{
		}
	}

	// Token: 0x170005F2 RID: 1522
	// (get) Token: 0x06001162 RID: 4450 RVA: 0x00006768 File Offset: 0x00004968
	// (set) Token: 0x06001163 RID: 4451 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005F2")]
	public Vector3 Position
	{
		[Token(Token = "0x6001162")]
		[Address(RVA = "0x7BCBD0", Offset = "0x7BB1D0", VA = "0x1807BCBD0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001163")]
		[Address(RVA = "0x84D2D0", Offset = "0x84B8D0", VA = "0x18084D2D0")]
		set
		{
		}
	}

	// Token: 0x170005F3 RID: 1523
	// (get) Token: 0x06001164 RID: 4452 RVA: 0x00006780 File Offset: 0x00004980
	// (set) Token: 0x06001165 RID: 4453 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005F3")]
	public Quaternion Rotation
	{
		[Token(Token = "0x6001164")]
		[Address(RVA = "0x7BCDA0", Offset = "0x7BB3A0", VA = "0x1807BCDA0")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6001165")]
		[Address(RVA = "0x83A2C0", Offset = "0x8388C0", VA = "0x18083A2C0")]
		set
		{
		}
	}

	// Token: 0x170005F4 RID: 1524
	// (get) Token: 0x06001166 RID: 4454 RVA: 0x00006798 File Offset: 0x00004998
	// (set) Token: 0x06001167 RID: 4455 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005F4")]
	public int BodyId
	{
		[Token(Token = "0x6001166")]
		[Address(RVA = "0x7B6B40", Offset = "0x7B5140", VA = "0x1807B6B40")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001167")]
		[Address(RVA = "0x7E1CC0", Offset = "0x7E02C0", VA = "0x1807E1CC0")]
		set
		{
		}
	}

	// Token: 0x170005F5 RID: 1525
	// (get) Token: 0x06001168 RID: 4456 RVA: 0x000067B0 File Offset: 0x000049B0
	// (set) Token: 0x06001169 RID: 4457 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005F5")]
	public Vector3 AddVelocity
	{
		[Token(Token = "0x6001168")]
		[Address(RVA = "0x84D4F0", Offset = "0x84BAF0", VA = "0x18084D4F0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001169")]
		[Address(RVA = "0x884900", Offset = "0x882F00", VA = "0x180884900")]
		set
		{
		}
	}

	// Token: 0x0600116A RID: 4458 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600116A")]
	[Address(RVA = "0x8849B0", Offset = "0x882FB0", VA = "0x1808849B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0600116B RID: 4459 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600116B")]
	[Address(RVA = "0x884D30", Offset = "0x883330", VA = "0x180884D30")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DropBodyEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x0600116C RID: 4460 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600116C")]
	[Address(RVA = "0x884D40", Offset = "0x883340", VA = "0x180884D40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DropBodyEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x0600116D RID: 4461 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600116D")]
	[Address(RVA = "0x884F40", Offset = "0x883540", VA = "0x180884F40")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static DropBodyEvent Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600116E RID: 4462 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600116E")]
	[Address(RVA = "0x885060", Offset = "0x883660", VA = "0x180885060")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DropBodyEvent Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x0600116F RID: 4463 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600116F")]
	[Address(RVA = "0x885070", Offset = "0x883670", VA = "0x180885070")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DropBodyEvent Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001170 RID: 4464 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001170")]
	[Address(RVA = "0x885080", Offset = "0x883680", VA = "0x180885080")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DropBodyEvent Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001171 RID: 4465 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001171")]
	[Address(RVA = "0x885090", Offset = "0x883690", VA = "0x180885090")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DropBodyEvent Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001172 RID: 4466 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001172")]
	[Address(RVA = "0x8850B0", Offset = "0x8836B0", VA = "0x1808850B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DropBodyEvent Raise()
	{
		return null;
	}

	// Token: 0x06001173 RID: 4467 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001173")]
	[Address(RVA = "0x8850D0", Offset = "0x8836D0", VA = "0x1808850D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static DropBodyEvent Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001174 RID: 4468 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001174")]
	[Address(RVA = "0x884D30", Offset = "0x883330", VA = "0x180884D30")]
	public static DropBodyEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001175 RID: 4469 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001175")]
	[Address(RVA = "0x8850E0", Offset = "0x8836E0", VA = "0x1808850E0")]
	public static DropBodyEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001176 RID: 4470 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001176")]
	[Address(RVA = "0x8852E0", Offset = "0x8838E0", VA = "0x1808852E0")]
	private static DropBodyEvent Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001177 RID: 4471 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001177")]
	[Address(RVA = "0x885060", Offset = "0x883660", VA = "0x180885060")]
	public static DropBodyEvent Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06001178 RID: 4472 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001178")]
	[Address(RVA = "0x885070", Offset = "0x883670", VA = "0x180885070")]
	public static DropBodyEvent Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001179 RID: 4473 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001179")]
	[Address(RVA = "0x885080", Offset = "0x883680", VA = "0x180885080")]
	public static DropBodyEvent Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x0600117A RID: 4474 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600117A")]
	[Address(RVA = "0x885090", Offset = "0x883690", VA = "0x180885090")]
	public static DropBodyEvent Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x0600117B RID: 4475 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600117B")]
	[Address(RVA = "0x8850B0", Offset = "0x8836B0", VA = "0x1808850B0")]
	public static DropBodyEvent Create()
	{
		return null;
	}

	// Token: 0x0600117C RID: 4476 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600117C")]
	[Address(RVA = "0x8850D0", Offset = "0x8836D0", VA = "0x1808850D0")]
	public static DropBodyEvent Create(ReliabilityModes reliability)
	{
		return null;
	}
}
