using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x0200096E RID: 2414
	[Token(Token = "0x200096E")]
	[AddComponentMenu("Sons/Ai/Interact/Hunt Target")]
	public class HuntTargetInteraction : MonoBehaviour, IVailActorInteract
	{
		// Token: 0x060045EE RID: 17902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045EE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public void BeginInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x060045EF RID: 17903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045EF")]
		[Address(RVA = "0x366E120", Offset = "0x366C720", VA = "0x18366E120", Slot = "5")]
		public void DoInteract(VailActor vailActor, float deltaTime, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x060045F0 RID: 17904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045F0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		public void EndInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x060045F1 RID: 17905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045F1")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public HuntTargetInteraction()
		{
		}
	}
}
