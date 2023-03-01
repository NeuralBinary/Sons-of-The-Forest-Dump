using System;
using Ballistics;
using Il2CppDummyDll;
using Sons.Multiplayer;
using UnityEngine;

// Token: 0x0200004A RID: 74
[Token(Token = "0x200004A")]
public class Molotov : BoltEntityBehaviourWrapper<IMolotovState>
{
	// Token: 0x06000215 RID: 533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000215")]
	[Address(RVA = "0x2B6FD50", Offset = "0x2B6ED50", VA = "0x182B6FD50")]
	private void Start()
	{
	}

	// Token: 0x06000216 RID: 534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000216")]
	[Address(RVA = "0x2B6F750", Offset = "0x2B6E750", VA = "0x182B6F750", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000217 RID: 535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000217")]
	[Address(RVA = "0x2B6FC10", Offset = "0x2B6EC10", VA = "0x182B6FC10", Slot = "17")]
	public override void Detached()
	{
	}

	// Token: 0x06000218 RID: 536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000218")]
	[Address(RVA = "0x2B6FC90", Offset = "0x2B6EC90", VA = "0x182B6FC90")]
	public void OnImpact(SurfaceImpactInfo impactInfo)
	{
	}

	// Token: 0x06000219 RID: 537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000219")]
	[Address(RVA = "0x2B6FB70", Offset = "0x2B6EB70", VA = "0x182B6FB70")]
	private void BreakBottle()
	{
	}

	// Token: 0x0600021A RID: 538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600021A")]
	[Address(RVA = "0x2B6F9F0", Offset = "0x2B6E9F0", VA = "0x182B6F9F0")]
	public void BreakBottleReal()
	{
	}

	// Token: 0x0600021B RID: 539 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600021B")]
	[Address(RVA = "0x2B6FD90", Offset = "0x2B6ED90", VA = "0x182B6FD90")]
	public Molotov()
	{
	}

	// Token: 0x040001FC RID: 508
	[Token(Token = "0x40001FC")]
	[FieldOffset(Offset = "0x30")]
	public bool isLit;

	// Token: 0x040001FD RID: 509
	[Token(Token = "0x40001FD")]
	[FieldOffset(Offset = "0x31")]
	private bool _isBroken;

	// Token: 0x040001FE RID: 510
	[Token(Token = "0x40001FE")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Bottle;

	// Token: 0x040001FF RID: 511
	[Token(Token = "0x40001FF")]
	[FieldOffset(Offset = "0x40")]
	public GameObject BottleBroken;

	// Token: 0x04000200 RID: 512
	[Token(Token = "0x4000200")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject _explosion;

	// Token: 0x04000201 RID: 513
	[Token(Token = "0x4000201")]
	[FieldOffset(Offset = "0x50")]
	public float DelayBeforeCleanup;
}
