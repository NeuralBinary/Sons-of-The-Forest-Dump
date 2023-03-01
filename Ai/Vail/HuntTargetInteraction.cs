using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020008ED RID: 2285
	[Token(Token = "0x20008ED")]
	[AddComponentMenu("Sons/Ai/Interact/Hunt Target")]
	public class HuntTargetInteraction : MonoBehaviour, IVailActorInteract
	{
		// Token: 0x06003E1A RID: 15898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E1A")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "4")]
		public void BeginInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06003E1B RID: 15899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E1B")]
		[Address(RVA = "0x2F1F9F0", Offset = "0x2F1E9F0", VA = "0x182F1F9F0", Slot = "5")]
		public void DoInteract(VailActor vailActor, float deltaTime, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06003E1C RID: 15900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E1C")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "6")]
		public void EndInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06003E1D RID: 15901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E1D")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public HuntTargetInteraction()
		{
		}
	}
}
