using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000068 RID: 104
[Token(Token = "0x2000068")]
public class CoopMecanimPlayerTweaks : EntityBehaviour<IPlayerState>
{
	// Token: 0x060002F6 RID: 758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x2B63800", Offset = "0x2B62800", VA = "0x182B63800")]
	private void Awake()
	{
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x2B637C0", Offset = "0x2B627C0", VA = "0x182B637C0", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x2B638C0", Offset = "0x2B628C0", VA = "0x182B638C0")]
	private void Update()
	{
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x2B63F30", Offset = "0x2B62F30", VA = "0x182B63F30")]
	public CoopMecanimPlayerTweaks()
	{
	}

	// Token: 0x040002BF RID: 703
	[Token(Token = "0x40002BF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform targetTransform;

	// Token: 0x040002C0 RID: 704
	[Token(Token = "0x40002C0")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private CoopMecanimReplicator Replicator;

	// Token: 0x040002C1 RID: 705
	[Token(Token = "0x40002C1")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float remoteSpeedAdjustment;

	// Token: 0x040002C2 RID: 706
	[Token(Token = "0x40002C2")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float remoteMovementLimit;

	// Token: 0x040002C3 RID: 707
	[Token(Token = "0x40002C3")]
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	private Vector3 last_position;

	// Token: 0x040002C4 RID: 708
	[Token(Token = "0x40002C4")]
	[FieldOffset(Offset = "0x4C")]
	private int idleHash;

	// Token: 0x040002C5 RID: 709
	[Token(Token = "0x40002C5")]
	[FieldOffset(Offset = "0x50")]
	private int locoHash;
}
