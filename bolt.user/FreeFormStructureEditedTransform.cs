using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001CB RID: 459
[Token(Token = "0x20001CB")]
public class FreeFormStructureEditedTransform : Event
{
	// Token: 0x060014E9 RID: 5353 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014E9")]
	[Address(RVA = "0x8A1EA0", Offset = "0x8A04A0", VA = "0x1808A1EA0")]
	public FreeFormStructureEditedTransform()
	{
	}

	// Token: 0x17000686 RID: 1670
	// (get) Token: 0x060014EA RID: 5354 RVA: 0x00007080 File Offset: 0x00005280
	// (set) Token: 0x060014EB RID: 5355 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000686")]
	public int DBVersion
	{
		[Token(Token = "0x60014EA")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60014EB")]
		[Address(RVA = "0x7EB470", Offset = "0x7E9A70", VA = "0x1807EB470")]
		set
		{
		}
	}

	// Token: 0x17000687 RID: 1671
	// (get) Token: 0x060014EC RID: 5356 RVA: 0x00007098 File Offset: 0x00005298
	// (set) Token: 0x060014ED RID: 5357 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000687")]
	public int TypeID
	{
		[Token(Token = "0x60014EC")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60014ED")]
		[Address(RVA = "0x7EB500", Offset = "0x7E9B00", VA = "0x1807EB500")]
		set
		{
		}
	}

	// Token: 0x17000688 RID: 1672
	// (get) Token: 0x060014EE RID: 5358 RVA: 0x000070B0 File Offset: 0x000052B0
	// (set) Token: 0x060014EF RID: 5359 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000688")]
	public int InstanceID
	{
		[Token(Token = "0x60014EE")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60014EF")]
		[Address(RVA = "0x7D6E60", Offset = "0x7D5460", VA = "0x1807D6E60")]
		set
		{
		}
	}

	// Token: 0x17000689 RID: 1673
	// (get) Token: 0x060014F0 RID: 5360 RVA: 0x000070C8 File Offset: 0x000052C8
	// (set) Token: 0x060014F1 RID: 5361 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000689")]
	public Vector3 Position
	{
		[Token(Token = "0x60014F0")]
		[Address(RVA = "0x7D5EB0", Offset = "0x7D44B0", VA = "0x1807D5EB0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60014F1")]
		[Address(RVA = "0x83E5C0", Offset = "0x83CBC0", VA = "0x18083E5C0")]
		set
		{
		}
	}

	// Token: 0x1700068A RID: 1674
	// (get) Token: 0x060014F2 RID: 5362 RVA: 0x000070E0 File Offset: 0x000052E0
	// (set) Token: 0x060014F3 RID: 5363 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700068A")]
	public Quaternion Rotation
	{
		[Token(Token = "0x60014F2")]
		[Address(RVA = "0x7C22A0", Offset = "0x7C08A0", VA = "0x1807C22A0")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x60014F3")]
		[Address(RVA = "0x7DD7D0", Offset = "0x7DBDD0", VA = "0x1807DD7D0")]
		set
		{
		}
	}

	// Token: 0x060014F4 RID: 5364 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014F4")]
	[Address(RVA = "0x8A1F00", Offset = "0x8A0500", VA = "0x1808A1F00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060014F5 RID: 5365 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014F5")]
	[Address(RVA = "0x8A22C0", Offset = "0x8A08C0", VA = "0x1808A22C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static FreeFormStructureEditedTransform Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060014F6 RID: 5366 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014F6")]
	[Address(RVA = "0x8A2450", Offset = "0x8A0A50", VA = "0x1808A2450")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureEditedTransform Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060014F7 RID: 5367 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014F7")]
	[Address(RVA = "0x8A2460", Offset = "0x8A0A60", VA = "0x1808A2460")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureEditedTransform Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060014F8 RID: 5368 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014F8")]
	[Address(RVA = "0x8A2470", Offset = "0x8A0A70", VA = "0x1808A2470")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureEditedTransform Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060014F9 RID: 5369 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014F9")]
	[Address(RVA = "0x8A2480", Offset = "0x8A0A80", VA = "0x1808A2480")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureEditedTransform Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060014FA RID: 5370 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014FA")]
	[Address(RVA = "0x8A24A0", Offset = "0x8A0AA0", VA = "0x1808A24A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureEditedTransform Raise()
	{
		return null;
	}

	// Token: 0x060014FB RID: 5371 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014FB")]
	[Address(RVA = "0x8A24C0", Offset = "0x8A0AC0", VA = "0x1808A24C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureEditedTransform Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060014FC RID: 5372 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014FC")]
	[Address(RVA = "0x8A24D0", Offset = "0x8A0AD0", VA = "0x1808A24D0")]
	private static FreeFormStructureEditedTransform Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060014FD RID: 5373 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014FD")]
	[Address(RVA = "0x8A2450", Offset = "0x8A0A50", VA = "0x1808A2450")]
	public static FreeFormStructureEditedTransform Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060014FE RID: 5374 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014FE")]
	[Address(RVA = "0x8A2460", Offset = "0x8A0A60", VA = "0x1808A2460")]
	public static FreeFormStructureEditedTransform Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060014FF RID: 5375 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014FF")]
	[Address(RVA = "0x8A2470", Offset = "0x8A0A70", VA = "0x1808A2470")]
	public static FreeFormStructureEditedTransform Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06001500 RID: 5376 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001500")]
	[Address(RVA = "0x8A2480", Offset = "0x8A0A80", VA = "0x1808A2480")]
	public static FreeFormStructureEditedTransform Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06001501 RID: 5377 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001501")]
	[Address(RVA = "0x8A24A0", Offset = "0x8A0AA0", VA = "0x1808A24A0")]
	public static FreeFormStructureEditedTransform Create()
	{
		return null;
	}

	// Token: 0x06001502 RID: 5378 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001502")]
	[Address(RVA = "0x8A24C0", Offset = "0x8A0AC0", VA = "0x1808A24C0")]
	public static FreeFormStructureEditedTransform Create(ReliabilityModes reliability)
	{
		return null;
	}
}
