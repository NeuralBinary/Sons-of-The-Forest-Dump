using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200010A RID: 266
[Token(Token = "0x200010A")]
public class bowBlendSpine : StateMachineBehaviour
{
	// Token: 0x060007F7 RID: 2039 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F7")]
	[Address(RVA = "0x2F45140", Offset = "0x2F44140", VA = "0x182F45140", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060007F8 RID: 2040 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F8")]
	[Address(RVA = "0x2F451B0", Offset = "0x2F441B0", VA = "0x182F451B0", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060007F9 RID: 2041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F9")]
	[Address(RVA = "0x54CB80", Offset = "0x54BB80", VA = "0x18054CB80")]
	public bowBlendSpine()
	{
	}

	// Token: 0x04000678 RID: 1656
	[Token(Token = "0x4000678")]
	[FieldOffset(Offset = "0x18")]
	private Animator thisAnimator;

	// Token: 0x04000679 RID: 1657
	[Token(Token = "0x4000679")]
	[FieldOffset(Offset = "0x20")]
	public bool doBlend;

	// Token: 0x0400067A RID: 1658
	[Token(Token = "0x400067A")]
	[FieldOffset(Offset = "0x24")]
	private AnimatorStateInfo info1;

	// Token: 0x0400067B RID: 1659
	[Token(Token = "0x400067B")]
	[FieldOffset(Offset = "0x48")]
	private float n;
}
