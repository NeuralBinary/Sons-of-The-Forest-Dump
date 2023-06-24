using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C5 RID: 453
[Token(Token = "0x20001C5")]
public class FreeFormStructureCreated : Event
{
	// Token: 0x060014A1 RID: 5281 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014A1")]
	[Address(RVA = "0x89F6D0", Offset = "0x89DCD0", VA = "0x18089F6D0")]
	public FreeFormStructureCreated()
	{
	}

	// Token: 0x17000676 RID: 1654
	// (get) Token: 0x060014A2 RID: 5282 RVA: 0x00006F60 File Offset: 0x00005160
	// (set) Token: 0x060014A3 RID: 5283 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000676")]
	public int DBVersion
	{
		[Token(Token = "0x60014A2")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60014A3")]
		[Address(RVA = "0x7EB470", Offset = "0x7E9A70", VA = "0x1807EB470")]
		set
		{
		}
	}

	// Token: 0x17000677 RID: 1655
	// (get) Token: 0x060014A4 RID: 5284 RVA: 0x00006F78 File Offset: 0x00005178
	// (set) Token: 0x060014A5 RID: 5285 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000677")]
	public int TypeID
	{
		[Token(Token = "0x60014A4")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60014A5")]
		[Address(RVA = "0x7EB500", Offset = "0x7E9B00", VA = "0x1807EB500")]
		set
		{
		}
	}

	// Token: 0x17000678 RID: 1656
	// (get) Token: 0x060014A6 RID: 5286 RVA: 0x00006F90 File Offset: 0x00005190
	// (set) Token: 0x060014A7 RID: 5287 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000678")]
	public int InstanceID
	{
		[Token(Token = "0x60014A6")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60014A7")]
		[Address(RVA = "0x7D6E60", Offset = "0x7D5460", VA = "0x1807D6E60")]
		set
		{
		}
	}

	// Token: 0x17000679 RID: 1657
	// (get) Token: 0x060014A8 RID: 5288 RVA: 0x00006FA8 File Offset: 0x000051A8
	// (set) Token: 0x060014A9 RID: 5289 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000679")]
	public Vector3 Position
	{
		[Token(Token = "0x60014A8")]
		[Address(RVA = "0x7D5EB0", Offset = "0x7D44B0", VA = "0x1807D5EB0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60014A9")]
		[Address(RVA = "0x83E5C0", Offset = "0x83CBC0", VA = "0x18083E5C0")]
		set
		{
		}
	}

	// Token: 0x1700067A RID: 1658
	// (get) Token: 0x060014AA RID: 5290 RVA: 0x00006FC0 File Offset: 0x000051C0
	// (set) Token: 0x060014AB RID: 5291 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700067A")]
	public Quaternion Rotation
	{
		[Token(Token = "0x60014AA")]
		[Address(RVA = "0x7C22A0", Offset = "0x7C08A0", VA = "0x1807C22A0")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x60014AB")]
		[Address(RVA = "0x7DD7D0", Offset = "0x7DBDD0", VA = "0x1807DD7D0")]
		set
		{
		}
	}

	// Token: 0x1700067B RID: 1659
	// (get) Token: 0x060014AC RID: 5292 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060014AD RID: 5293 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700067B")]
	public IProtocolToken LinkedStructures
	{
		[Token(Token = "0x60014AC")]
		[Address(RVA = "0x89F730", Offset = "0x89DD30", VA = "0x18089F730")]
		get
		{
			return null;
		}
		[Token(Token = "0x60014AD")]
		[Address(RVA = "0x89F7E0", Offset = "0x89DDE0", VA = "0x18089F7E0")]
		set
		{
		}
	}

	// Token: 0x1700067C RID: 1660
	// (get) Token: 0x060014AE RID: 5294 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060014AF RID: 5295 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700067C")]
	public IProtocolToken Elements
	{
		[Token(Token = "0x60014AE")]
		[Address(RVA = "0x89F930", Offset = "0x89DF30", VA = "0x18089F930")]
		get
		{
			return null;
		}
		[Token(Token = "0x60014AF")]
		[Address(RVA = "0x89F9E0", Offset = "0x89DFE0", VA = "0x18089F9E0")]
		set
		{
		}
	}

	// Token: 0x060014B0 RID: 5296 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014B0")]
	[Address(RVA = "0x89FB30", Offset = "0x89E130", VA = "0x18089FB30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060014B1 RID: 5297 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014B1")]
	[Address(RVA = "0x8A00C0", Offset = "0x89E6C0", VA = "0x1808A00C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static FreeFormStructureCreated Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060014B2 RID: 5298 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014B2")]
	[Address(RVA = "0x8A0250", Offset = "0x89E850", VA = "0x1808A0250")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureCreated Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060014B3 RID: 5299 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014B3")]
	[Address(RVA = "0x8A0260", Offset = "0x89E860", VA = "0x1808A0260")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureCreated Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060014B4 RID: 5300 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014B4")]
	[Address(RVA = "0x8A0270", Offset = "0x89E870", VA = "0x1808A0270")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureCreated Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060014B5 RID: 5301 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014B5")]
	[Address(RVA = "0x8A0280", Offset = "0x89E880", VA = "0x1808A0280")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureCreated Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060014B6 RID: 5302 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014B6")]
	[Address(RVA = "0x8A02A0", Offset = "0x89E8A0", VA = "0x1808A02A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureCreated Raise()
	{
		return null;
	}

	// Token: 0x060014B7 RID: 5303 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014B7")]
	[Address(RVA = "0x8A02C0", Offset = "0x89E8C0", VA = "0x1808A02C0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static FreeFormStructureCreated Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060014B8 RID: 5304 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014B8")]
	[Address(RVA = "0x8A02D0", Offset = "0x89E8D0", VA = "0x1808A02D0")]
	private static FreeFormStructureCreated Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060014B9 RID: 5305 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014B9")]
	[Address(RVA = "0x8A0250", Offset = "0x89E850", VA = "0x1808A0250")]
	public static FreeFormStructureCreated Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060014BA RID: 5306 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014BA")]
	[Address(RVA = "0x8A0260", Offset = "0x89E860", VA = "0x1808A0260")]
	public static FreeFormStructureCreated Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060014BB RID: 5307 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014BB")]
	[Address(RVA = "0x8A0270", Offset = "0x89E870", VA = "0x1808A0270")]
	public static FreeFormStructureCreated Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060014BC RID: 5308 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014BC")]
	[Address(RVA = "0x8A0280", Offset = "0x89E880", VA = "0x1808A0280")]
	public static FreeFormStructureCreated Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060014BD RID: 5309 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014BD")]
	[Address(RVA = "0x8A02A0", Offset = "0x89E8A0", VA = "0x1808A02A0")]
	public static FreeFormStructureCreated Create()
	{
		return null;
	}

	// Token: 0x060014BE RID: 5310 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014BE")]
	[Address(RVA = "0x8A02C0", Offset = "0x89E8C0", VA = "0x1808A02C0")]
	public static FreeFormStructureCreated Create(ReliabilityModes reliability)
	{
		return null;
	}
}
