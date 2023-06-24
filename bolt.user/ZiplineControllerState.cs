using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200004C RID: 76
[Token(Token = "0x200004C")]
internal class ZiplineControllerState : NetworkState, IZiplineControllerState, IState, IDisposable
{
	// Token: 0x060002E2 RID: 738 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x7D3C50", Offset = "0x7D2250", VA = "0x1807D3C50")]
	public ZiplineControllerState()
	{
	}

	// Token: 0x17000180 RID: 384
	// (get) Token: 0x060002E3 RID: 739 RVA: 0x000030C0 File Offset: 0x000012C0
	// (set) Token: 0x060002E4 RID: 740 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000180")]
	public Vector3 AnchorAPosition
	{
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x7D3CB0", Offset = "0x7D22B0", VA = "0x1807D3CB0", Slot = "31")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x7D3D30", Offset = "0x7D2330", VA = "0x1807D3D30", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x17000181 RID: 385
	// (get) Token: 0x060002E5 RID: 741 RVA: 0x000030D8 File Offset: 0x000012D8
	// (set) Token: 0x060002E6 RID: 742 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000181")]
	public Vector3 AnchorBPosition
	{
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x7BCBD0", Offset = "0x7BB1D0", VA = "0x1807BCBD0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x7BCC50", Offset = "0x7BB250", VA = "0x1807BCC50", Slot = "34")]
		set
		{
		}
	}

	// Token: 0x17000182 RID: 386
	// (get) Token: 0x060002E7 RID: 743 RVA: 0x000030F0 File Offset: 0x000012F0
	// (set) Token: 0x060002E8 RID: 744 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000182")]
	public bool CanBeDismantled
	{
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x7B8B00", Offset = "0x7B7100", VA = "0x1807B8B00", Slot = "35")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x7B8B60", Offset = "0x7B7160", VA = "0x1807B8B60", Slot = "36")]
		set
		{
		}
	}
}
