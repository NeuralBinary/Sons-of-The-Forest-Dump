using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000065 RID: 101
[Token(Token = "0x2000065")]
public class CoopMecanimPlayerTweaks : EntityBehaviour<IPlayerState>
{
	// Token: 0x060002F9 RID: 761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x31BB750", Offset = "0x31B9D50", VA = "0x1831BB750")]
	private void Awake()
	{
	}

	// Token: 0x060002FA RID: 762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x31BB910", Offset = "0x31B9F10", VA = "0x1831BB910", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x060002FB RID: 763 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x31BB9A0", Offset = "0x31B9FA0", VA = "0x1831BB9A0")]
	private void Update()
	{
	}

	// Token: 0x060002FC RID: 764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x31BC200", Offset = "0x31BA800", VA = "0x1831BC200")]
	public CoopMecanimPlayerTweaks()
	{
	}

	// Token: 0x040002C1 RID: 705
	[Token(Token = "0x40002C1")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform targetTransform;

	// Token: 0x040002C2 RID: 706
	[Token(Token = "0x40002C2")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private CoopMecanimReplicator Replicator;

	// Token: 0x040002C3 RID: 707
	[Token(Token = "0x40002C3")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float remoteSpeedAdjustment;

	// Token: 0x040002C4 RID: 708
	[Token(Token = "0x40002C4")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float remoteMovementLimit;

	// Token: 0x040002C5 RID: 709
	[Token(Token = "0x40002C5")]
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	private Vector3 last_position;

	// Token: 0x040002C6 RID: 710
	[Token(Token = "0x40002C6")]
	[FieldOffset(Offset = "0x4C")]
	private int idleHash;

	// Token: 0x040002C7 RID: 711
	[Token(Token = "0x40002C7")]
	[FieldOffset(Offset = "0x50")]
	private int locoHash;
}
