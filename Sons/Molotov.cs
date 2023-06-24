using System;
using Ballistics;
using Il2CppDummyDll;
using Sons.Multiplayer;
using UnityEngine;

// Token: 0x0200004C RID: 76
[Token(Token = "0x200004C")]
public class Molotov : BoltEntityBehaviourWrapper<IMolotovState>
{
	// Token: 0x06000231 RID: 561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000231")]
	[Address(RVA = "0x31ABAD0", Offset = "0x31AA0D0", VA = "0x1831ABAD0")]
	private void Start()
	{
	}

	// Token: 0x06000232 RID: 562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000232")]
	[Address(RVA = "0x31ABB10", Offset = "0x31AA110", VA = "0x1831ABB10", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000233 RID: 563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000233")]
	[Address(RVA = "0x31ABFB0", Offset = "0x31AA5B0", VA = "0x1831ABFB0", Slot = "17")]
	public override void Detached()
	{
	}

	// Token: 0x06000234 RID: 564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000234")]
	[Address(RVA = "0x31AC060", Offset = "0x31AA660", VA = "0x1831AC060")]
	public void OnImpact(SurfaceImpactInfo impactInfo)
	{
	}

	// Token: 0x06000235 RID: 565 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000235")]
	[Address(RVA = "0x31AC1B0", Offset = "0x31AA7B0", VA = "0x1831AC1B0")]
	private void BreakBottle()
	{
	}

	// Token: 0x06000236 RID: 566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000236")]
	[Address(RVA = "0x31AC2E0", Offset = "0x31AA8E0", VA = "0x1831AC2E0")]
	public void BreakBottleReal()
	{
	}

	// Token: 0x06000237 RID: 567 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000237")]
	[Address(RVA = "0x31AC7A0", Offset = "0x31AADA0", VA = "0x1831AC7A0")]
	public Molotov()
	{
	}

	// Token: 0x0400022D RID: 557
	[Token(Token = "0x400022D")]
	[FieldOffset(Offset = "0x30")]
	public bool isLit;

	// Token: 0x0400022E RID: 558
	[Token(Token = "0x400022E")]
	[FieldOffset(Offset = "0x31")]
	private bool _isBroken;

	// Token: 0x0400022F RID: 559
	[Token(Token = "0x400022F")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Bottle;

	// Token: 0x04000230 RID: 560
	[Token(Token = "0x4000230")]
	[FieldOffset(Offset = "0x40")]
	public GameObject BottleBroken;

	// Token: 0x04000231 RID: 561
	[Token(Token = "0x4000231")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject _explosion;

	// Token: 0x04000232 RID: 562
	[Token(Token = "0x4000232")]
	[FieldOffset(Offset = "0x50")]
	public float DelayBeforeCleanup;
}
