using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000C6 RID: 198
[Token(Token = "0x20000C6")]
public class CoopPlayerClientHitPrediction : MonoBehaviour
{
	// Token: 0x0600064F RID: 1615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600064F")]
	[Address(RVA = "0x35176D0", Offset = "0x3515CD0", VA = "0x1835176D0")]
	private void Start()
	{
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000650")]
	[Address(RVA = "0x35177E0", Offset = "0x3515DE0", VA = "0x1835177E0")]
	private void Update()
	{
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000651")]
	[Address(RVA = "0x3517D10", Offset = "0x3516310", VA = "0x183517D10")]
	public void getCombo(int getCombo)
	{
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000652")]
	[Address(RVA = "0x3517D70", Offset = "0x3516370", VA = "0x183517D70")]
	public void getClientHitDirection(int getDir)
	{
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000653")]
	[Address(RVA = "0x3517DD0", Offset = "0x35163D0", VA = "0x183517DD0")]
	public void StartPrediction()
	{
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000654")]
	[Address(RVA = "0x3517F60", Offset = "0x3516560", VA = "0x183517F60")]
	public CoopPlayerClientHitPrediction()
	{
	}

	// Token: 0x04000559 RID: 1369
	[Token(Token = "0x4000559")]
	[FieldOffset(Offset = "0x20")]
	private float segmentTime;

	// Token: 0x0400055A RID: 1370
	[Token(Token = "0x400055A")]
	[FieldOffset(Offset = "0x24")]
	private float endTime;

	// Token: 0x0400055B RID: 1371
	[Token(Token = "0x400055B")]
	[FieldOffset(Offset = "0x28")]
	private float blendAmount;

	// Token: 0x0400055C RID: 1372
	[Token(Token = "0x400055C")]
	[FieldOffset(Offset = "0x30")]
	public Animator Animator;

	// Token: 0x0400055D RID: 1373
	[Token(Token = "0x400055D")]
	[FieldOffset(Offset = "0x38")]
	private Transform rotateTr;

	// Token: 0x0400055E RID: 1374
	[Token(Token = "0x400055E")]
	[FieldOffset(Offset = "0x40")]
	private AnimatorStateInfo currState0;

	// Token: 0x0400055F RID: 1375
	[Token(Token = "0x400055F")]
	[FieldOffset(Offset = "0x64")]
	private AnimatorStateInfo currState1;

	// Token: 0x04000560 RID: 1376
	[Token(Token = "0x4000560")]
	[FieldOffset(Offset = "0x88")]
	private AnimatorStateInfo currState2;

	// Token: 0x04000561 RID: 1377
	[Token(Token = "0x4000561")]
	[FieldOffset(Offset = "0xAC")]
	private int deathTag;

	// Token: 0x04000562 RID: 1378
	[Token(Token = "0x4000562")]
	[FieldOffset(Offset = "0xB0")]
	private int hitStaggerTag;

	// Token: 0x04000563 RID: 1379
	[Token(Token = "0x4000563")]
	[FieldOffset(Offset = "0xB4")]
	private int knockBackTag;

	// Token: 0x04000564 RID: 1380
	[Token(Token = "0x4000564")]
	[FieldOffset(Offset = "0xB8")]
	private int explodeTag;

	// Token: 0x04000565 RID: 1381
	[Token(Token = "0x4000565")]
	[FieldOffset(Offset = "0xBC")]
	private int blockTag;

	// Token: 0x04000566 RID: 1382
	[Token(Token = "0x4000566")]
	[FieldOffset(Offset = "0xC0")]
	private bool doingPrediction;

	// Token: 0x04000567 RID: 1383
	[Token(Token = "0x4000567")]
	[FieldOffset(Offset = "0xC1")]
	private bool restoreRotationCheck;

	// Token: 0x04000568 RID: 1384
	[Token(Token = "0x4000568")]
	[FieldOffset(Offset = "0xC4")]
	private float hitTimer;
}
