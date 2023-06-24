using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000106 RID: 262
[Token(Token = "0x2000106")]
public class bowAnimReset : StateMachineBehaviour
{
	// Token: 0x0600083C RID: 2108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083C")]
	[Address(RVA = "0x3684820", Offset = "0x3682E20", VA = "0x183684820", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x0600083D RID: 2109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083D")]
	[Address(RVA = "0x3684AB0", Offset = "0x36830B0", VA = "0x183684AB0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x0600083E RID: 2110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083E")]
	[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
	public bowAnimReset()
	{
	}

	// Token: 0x04000693 RID: 1683
	[Token(Token = "0x4000693")]
	[FieldOffset(Offset = "0x18")]
	private animEventsManager playerEvents;
}
