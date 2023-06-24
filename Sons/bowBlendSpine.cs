using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000107 RID: 263
[Token(Token = "0x2000107")]
public class bowBlendSpine : StateMachineBehaviour
{
	// Token: 0x0600083F RID: 2111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083F")]
	[Address(RVA = "0x3684D50", Offset = "0x3683350", VA = "0x183684D50", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000840")]
	[Address(RVA = "0x3684E40", Offset = "0x3683440", VA = "0x183684E40", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000841 RID: 2113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000841")]
	[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
	public bowBlendSpine()
	{
	}

	// Token: 0x04000694 RID: 1684
	[Token(Token = "0x4000694")]
	[FieldOffset(Offset = "0x18")]
	private Animator thisAnimator;

	// Token: 0x04000695 RID: 1685
	[Token(Token = "0x4000695")]
	[FieldOffset(Offset = "0x20")]
	public bool doBlend;

	// Token: 0x04000696 RID: 1686
	[Token(Token = "0x4000696")]
	[FieldOffset(Offset = "0x24")]
	private AnimatorStateInfo info1;

	// Token: 0x04000697 RID: 1687
	[Token(Token = "0x4000697")]
	[FieldOffset(Offset = "0x48")]
	private float n;
}
