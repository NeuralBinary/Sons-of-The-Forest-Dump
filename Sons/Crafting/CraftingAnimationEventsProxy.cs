using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Crafting
{
	// Token: 0x020006AB RID: 1707
	[Token(Token = "0x20006AB")]
	[AddComponentMenu("Sons/Crafting/CraftingAnimationEventsProxy")]
	public class CraftingAnimationEventsProxy : MonoBehaviour
	{
		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06002D2B RID: 11563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005FB")]
		public UnityEvent<CraftingRecipe> OnCraftingAnimationComplete
		{
			[Token(Token = "0x6002D2B")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06002D2C RID: 11564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005FC")]
		public UnityEvent<CraftingRecipe> OnRevealResultingItem
		{
			[Token(Token = "0x6002D2C")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D2D")]
		[Address(RVA = "0x3431970", Offset = "0x342FF70", VA = "0x183431970")]
		public void TriggerCraftingAnimationComplete()
		{
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D2E")]
		[Address(RVA = "0x34319C0", Offset = "0x342FFC0", VA = "0x1834319C0")]
		public void TriggerRevealResultingItem()
		{
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D2F")]
		[Address(RVA = "0x3431A10", Offset = "0x3430010", VA = "0x183431A10")]
		public CraftingAnimationEventsProxy()
		{
		}

		// Token: 0x04002799 RID: 10137
		[Token(Token = "0x4002799")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public CraftingRecipe CurrentRecipe;
	}
}
