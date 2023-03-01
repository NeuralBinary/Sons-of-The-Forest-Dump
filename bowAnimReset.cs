using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000109 RID: 265
[Token(Token = "0x2000109")]
public class bowAnimReset : StateMachineBehaviour
{
	// Token: 0x060007F4 RID: 2036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F4")]
	[Address(RVA = "0x2F44FD0", Offset = "0x2F43FD0", VA = "0x182F44FD0", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060007F5 RID: 2037 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F5")]
	[Address(RVA = "0x2F44E60", Offset = "0x2F43E60", VA = "0x182F44E60", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060007F6 RID: 2038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F6")]
	[Address(RVA = "0x54CB80", Offset = "0x54BB80", VA = "0x18054CB80")]
	public bowAnimReset()
	{
	}

	// Token: 0x04000677 RID: 1655
	[Token(Token = "0x4000677")]
	[FieldOffset(Offset = "0x18")]
	private animEventsManager playerEvents;
}
