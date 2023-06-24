using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000E7 RID: 231
[Token(Token = "0x20000E7")]
public class FauxWeaponHit : Event
{
	// Token: 0x06000AC3 RID: 2755 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AC3")]
	[Address(RVA = "0x84F320", Offset = "0x84D920", VA = "0x18084F320")]
	public FauxWeaponHit()
	{
	}

	// Token: 0x170004FB RID: 1275
	// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x00005988 File Offset: 0x00003B88
	// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004FB")]
	public Vector3 Position
	{
		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x7D3CB0", Offset = "0x7D22B0", VA = "0x1807D3CB0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x83CAC0", Offset = "0x83B0C0", VA = "0x18083CAC0")]
		set
		{
		}
	}

	// Token: 0x170004FC RID: 1276
	// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x000059A0 File Offset: 0x00003BA0
	// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004FC")]
	public int Damage
	{
		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x84F380", Offset = "0x84D980", VA = "0x18084F380")]
		set
		{
		}
	}

	// Token: 0x06000AC8 RID: 2760 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000AC8")]
	[Address(RVA = "0x84F430", Offset = "0x84DA30", VA = "0x18084F430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000AC9 RID: 2761 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000AC9")]
	[Address(RVA = "0x84F560", Offset = "0x84DB60", VA = "0x18084F560")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FauxWeaponHit Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000ACA RID: 2762 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ACA")]
	[Address(RVA = "0x84F570", Offset = "0x84DB70", VA = "0x18084F570")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FauxWeaponHit Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000ACB RID: 2763 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ACB")]
	[Address(RVA = "0x84F770", Offset = "0x84DD70", VA = "0x18084F770")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static FauxWeaponHit Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000ACC RID: 2764 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ACC")]
	[Address(RVA = "0x84F890", Offset = "0x84DE90", VA = "0x18084F890")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FauxWeaponHit Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000ACD RID: 2765 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ACD")]
	[Address(RVA = "0x84F8A0", Offset = "0x84DEA0", VA = "0x18084F8A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FauxWeaponHit Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000ACE RID: 2766 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ACE")]
	[Address(RVA = "0x84F8B0", Offset = "0x84DEB0", VA = "0x18084F8B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FauxWeaponHit Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000ACF RID: 2767 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ACF")]
	[Address(RVA = "0x84F8C0", Offset = "0x84DEC0", VA = "0x18084F8C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FauxWeaponHit Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000AD0 RID: 2768 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000AD0")]
	[Address(RVA = "0x84F8E0", Offset = "0x84DEE0", VA = "0x18084F8E0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FauxWeaponHit Raise()
	{
		return null;
	}

	// Token: 0x06000AD1 RID: 2769 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000AD1")]
	[Address(RVA = "0x84F900", Offset = "0x84DF00", VA = "0x18084F900")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FauxWeaponHit Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000AD2 RID: 2770 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000AD2")]
	[Address(RVA = "0x84F560", Offset = "0x84DB60", VA = "0x18084F560")]
	public static FauxWeaponHit Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000AD3 RID: 2771 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000AD3")]
	[Address(RVA = "0x84F910", Offset = "0x84DF10", VA = "0x18084F910")]
	public static FauxWeaponHit Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000AD4 RID: 2772 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000AD4")]
	[Address(RVA = "0x84FB10", Offset = "0x84E110", VA = "0x18084FB10")]
	private static FauxWeaponHit Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000AD5 RID: 2773 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000AD5")]
	[Address(RVA = "0x84F890", Offset = "0x84DE90", VA = "0x18084F890")]
	public static FauxWeaponHit Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000AD6 RID: 2774 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000AD6")]
	[Address(RVA = "0x84F8A0", Offset = "0x84DEA0", VA = "0x18084F8A0")]
	public static FauxWeaponHit Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000AD7 RID: 2775 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000AD7")]
	[Address(RVA = "0x84F8B0", Offset = "0x84DEB0", VA = "0x18084F8B0")]
	public static FauxWeaponHit Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000AD8 RID: 2776 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000AD8")]
	[Address(RVA = "0x84F8C0", Offset = "0x84DEC0", VA = "0x18084F8C0")]
	public static FauxWeaponHit Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000AD9 RID: 2777 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000AD9")]
	[Address(RVA = "0x84F8E0", Offset = "0x84DEE0", VA = "0x18084F8E0")]
	public static FauxWeaponHit Create()
	{
		return null;
	}

	// Token: 0x06000ADA RID: 2778 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ADA")]
	[Address(RVA = "0x84F900", Offset = "0x84DF00", VA = "0x18084F900")]
	public static FauxWeaponHit Create(ReliabilityModes reliability)
	{
		return null;
	}
}
