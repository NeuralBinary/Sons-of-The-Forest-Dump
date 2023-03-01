using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000C8 RID: 200
[Token(Token = "0x20000C8")]
public class CoopPlayerClientHitPrediction : MonoBehaviour
{
	// Token: 0x06000617 RID: 1559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000617")]
	[Address(RVA = "0x2E7AA70", Offset = "0x2E79A70", VA = "0x182E7AA70")]
	private void Start()
	{
	}

	// Token: 0x06000618 RID: 1560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000618")]
	[Address(RVA = "0x2E7AAC0", Offset = "0x2E79AC0", VA = "0x182E7AAC0")]
	private void Update()
	{
	}

	// Token: 0x06000619 RID: 1561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000619")]
	[Address(RVA = "0x2E7AE60", Offset = "0x2E79E60", VA = "0x182E7AE60")]
	public void getCombo(int getCombo)
	{
	}

	// Token: 0x0600061A RID: 1562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600061A")]
	[Address(RVA = "0x2E7AE00", Offset = "0x2E79E00", VA = "0x182E7AE00")]
	public void getClientHitDirection(int getDir)
	{
	}

	// Token: 0x0600061B RID: 1563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600061B")]
	[Address(RVA = "0x2E7A9E0", Offset = "0x2E799E0", VA = "0x182E7A9E0")]
	public void StartPrediction()
	{
	}

	// Token: 0x0600061C RID: 1564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600061C")]
	[Address(RVA = "0x2E7AD30", Offset = "0x2E79D30", VA = "0x182E7AD30")]
	public CoopPlayerClientHitPrediction()
	{
	}

	// Token: 0x0400053F RID: 1343
	[Token(Token = "0x400053F")]
	[FieldOffset(Offset = "0x20")]
	private float segmentTime;

	// Token: 0x04000540 RID: 1344
	[Token(Token = "0x4000540")]
	[FieldOffset(Offset = "0x24")]
	private float endTime;

	// Token: 0x04000541 RID: 1345
	[Token(Token = "0x4000541")]
	[FieldOffset(Offset = "0x28")]
	private float blendAmount;

	// Token: 0x04000542 RID: 1346
	[Token(Token = "0x4000542")]
	[FieldOffset(Offset = "0x30")]
	public Animator Animator;

	// Token: 0x04000543 RID: 1347
	[Token(Token = "0x4000543")]
	[FieldOffset(Offset = "0x38")]
	private Transform rotateTr;

	// Token: 0x04000544 RID: 1348
	[Token(Token = "0x4000544")]
	[FieldOffset(Offset = "0x40")]
	private AnimatorStateInfo currState0;

	// Token: 0x04000545 RID: 1349
	[Token(Token = "0x4000545")]
	[FieldOffset(Offset = "0x64")]
	private AnimatorStateInfo currState1;

	// Token: 0x04000546 RID: 1350
	[Token(Token = "0x4000546")]
	[FieldOffset(Offset = "0x88")]
	private AnimatorStateInfo currState2;

	// Token: 0x04000547 RID: 1351
	[Token(Token = "0x4000547")]
	[FieldOffset(Offset = "0xAC")]
	private int deathTag;

	// Token: 0x04000548 RID: 1352
	[Token(Token = "0x4000548")]
	[FieldOffset(Offset = "0xB0")]
	private int hitStaggerTag;

	// Token: 0x04000549 RID: 1353
	[Token(Token = "0x4000549")]
	[FieldOffset(Offset = "0xB4")]
	private int knockBackTag;

	// Token: 0x0400054A RID: 1354
	[Token(Token = "0x400054A")]
	[FieldOffset(Offset = "0xB8")]
	private int explodeTag;

	// Token: 0x0400054B RID: 1355
	[Token(Token = "0x400054B")]
	[FieldOffset(Offset = "0xBC")]
	private int blockTag;

	// Token: 0x0400054C RID: 1356
	[Token(Token = "0x400054C")]
	[FieldOffset(Offset = "0xC0")]
	private bool doingPrediction;

	// Token: 0x0400054D RID: 1357
	[Token(Token = "0x400054D")]
	[FieldOffset(Offset = "0xC1")]
	private bool restoreRotationCheck;

	// Token: 0x0400054E RID: 1358
	[Token(Token = "0x400054E")]
	[FieldOffset(Offset = "0xC4")]
	private float hitTimer;
}
