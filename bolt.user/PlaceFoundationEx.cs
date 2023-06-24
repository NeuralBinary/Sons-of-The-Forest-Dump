using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000114 RID: 276
[Token(Token = "0x2000114")]
public class PlaceFoundationEx : Event
{
	// Token: 0x06000CB1 RID: 3249 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CB1")]
	[Address(RVA = "0x85D9E0", Offset = "0x85BFE0", VA = "0x18085D9E0")]
	public PlaceFoundationEx()
	{
	}

	// Token: 0x1700053E RID: 1342
	// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000CB3 RID: 3251 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700053E")]
	public IProtocolToken Token
	{
		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x85DA40", Offset = "0x85C040", VA = "0x18085DA40")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000CB3")]
		[Address(RVA = "0x85DAF0", Offset = "0x85C0F0", VA = "0x18085DAF0")]
		set
		{
		}
	}

	// Token: 0x1700053F RID: 1343
	// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x00005DA8 File Offset: 0x00003FA8
	// (set) Token: 0x06000CB5 RID: 3253 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700053F")]
	public PrefabId Prefab
	{
		[Token(Token = "0x6000CB4")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return default(PrefabId);
		}
		[Token(Token = "0x6000CB5")]
		[Address(RVA = "0x85DC40", Offset = "0x85C240", VA = "0x18085DC40")]
		set
		{
		}
	}

	// Token: 0x17000540 RID: 1344
	// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x00005DC0 File Offset: 0x00003FC0
	// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000540")]
	public Vector3 Position
	{
		[Token(Token = "0x6000CB6")]
		[Address(RVA = "0x7B55E0", Offset = "0x7B3BE0", VA = "0x1807B55E0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000CB7")]
		[Address(RVA = "0x843CF0", Offset = "0x8422F0", VA = "0x180843CF0")]
		set
		{
		}
	}

	// Token: 0x17000541 RID: 1345
	// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x00005DD8 File Offset: 0x00003FD8
	// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000541")]
	public Quaternion Rotation
	{
		[Token(Token = "0x6000CB8")]
		[Address(RVA = "0x7DD6C0", Offset = "0x7DBCC0", VA = "0x1807DD6C0")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000CB9")]
		[Address(RVA = "0x7DD730", Offset = "0x7DBD30", VA = "0x1807DD730")]
		set
		{
		}
	}

	// Token: 0x17000542 RID: 1346
	// (get) Token: 0x06000CBA RID: 3258 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000CBB RID: 3259 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000542")]
	public BoltEntity Parent
	{
		[Token(Token = "0x6000CBA")]
		[Address(RVA = "0x8314C0", Offset = "0x82FAC0", VA = "0x1808314C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000CBB")]
		[Address(RVA = "0x85DCE0", Offset = "0x85C2E0", VA = "0x18085DCE0")]
		set
		{
		}
	}

	// Token: 0x06000CBC RID: 3260 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CBC")]
	[Address(RVA = "0x85DF00", Offset = "0x85C500", VA = "0x18085DF00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000CBD RID: 3261 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CBD")]
	[Address(RVA = "0x85E330", Offset = "0x85C930", VA = "0x18085E330")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceFoundationEx Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000CBE RID: 3262 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CBE")]
	[Address(RVA = "0x85E340", Offset = "0x85C940", VA = "0x18085E340")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceFoundationEx Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000CBF RID: 3263 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CBF")]
	[Address(RVA = "0x85E540", Offset = "0x85CB40", VA = "0x18085E540")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static PlaceFoundationEx Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000CC0 RID: 3264 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CC0")]
	[Address(RVA = "0x85E660", Offset = "0x85CC60", VA = "0x18085E660")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceFoundationEx Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000CC1 RID: 3265 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CC1")]
	[Address(RVA = "0x85E670", Offset = "0x85CC70", VA = "0x18085E670")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceFoundationEx Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000CC2 RID: 3266 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CC2")]
	[Address(RVA = "0x85E680", Offset = "0x85CC80", VA = "0x18085E680")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceFoundationEx Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000CC3 RID: 3267 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CC3")]
	[Address(RVA = "0x85E690", Offset = "0x85CC90", VA = "0x18085E690")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceFoundationEx Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000CC4 RID: 3268 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CC4")]
	[Address(RVA = "0x85E6B0", Offset = "0x85CCB0", VA = "0x18085E6B0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceFoundationEx Raise()
	{
		return null;
	}

	// Token: 0x06000CC5 RID: 3269 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CC5")]
	[Address(RVA = "0x85E6D0", Offset = "0x85CCD0", VA = "0x18085E6D0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static PlaceFoundationEx Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000CC6 RID: 3270 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CC6")]
	[Address(RVA = "0x85E330", Offset = "0x85C930", VA = "0x18085E330")]
	public static PlaceFoundationEx Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06000CC7 RID: 3271 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CC7")]
	[Address(RVA = "0x85E6E0", Offset = "0x85CCE0", VA = "0x18085E6E0")]
	public static PlaceFoundationEx Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06000CC8 RID: 3272 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CC8")]
	[Address(RVA = "0x85E8E0", Offset = "0x85CEE0", VA = "0x18085E8E0")]
	private static PlaceFoundationEx Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000CC9 RID: 3273 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CC9")]
	[Address(RVA = "0x85E660", Offset = "0x85CC60", VA = "0x18085E660")]
	public static PlaceFoundationEx Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x06000CCA RID: 3274 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CCA")]
	[Address(RVA = "0x85E670", Offset = "0x85CC70", VA = "0x18085E670")]
	public static PlaceFoundationEx Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000CCB RID: 3275 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CCB")]
	[Address(RVA = "0x85E680", Offset = "0x85CC80", VA = "0x18085E680")]
	public static PlaceFoundationEx Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x06000CCC RID: 3276 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CCC")]
	[Address(RVA = "0x85E690", Offset = "0x85CC90", VA = "0x18085E690")]
	public static PlaceFoundationEx Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x06000CCD RID: 3277 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CCD")]
	[Address(RVA = "0x85E6B0", Offset = "0x85CCB0", VA = "0x18085E6B0")]
	public static PlaceFoundationEx Create()
	{
		return null;
	}

	// Token: 0x06000CCE RID: 3278 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CCE")]
	[Address(RVA = "0x85E6D0", Offset = "0x85CCD0", VA = "0x18085E6D0")]
	public static PlaceFoundationEx Create(ReliabilityModes reliability)
	{
		return null;
	}
}
