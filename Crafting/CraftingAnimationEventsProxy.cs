using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Crafting
{
	// Token: 0x020007A0 RID: 1952
	[Token(Token = "0x20007A0")]
	[AddComponentMenu("Sons/Crafting/CraftingAnimationEventsProxy")]
	public class CraftingAnimationEventsProxy : MonoBehaviour
	{
		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x060033B3 RID: 13235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700068E")]
		public UnityEvent<CraftingRecipe> OnCraftingAnimationComplete
		{
			[Token(Token = "0x60033B3")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x060033B4 RID: 13236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700068F")]
		public UnityEvent<CraftingRecipe> OnRevealResultingItem
		{
			[Token(Token = "0x60033B4")]
			[Address(RVA = "0x541210", Offset = "0x540210", VA = "0x180541210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060033B5 RID: 13237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033B5")]
		[Address(RVA = "0x2E57810", Offset = "0x2E56810", VA = "0x182E57810")]
		public void TriggerCraftingAnimationComplete()
		{
		}

		// Token: 0x060033B6 RID: 13238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033B6")]
		[Address(RVA = "0x2E57860", Offset = "0x2E56860", VA = "0x182E57860")]
		public void TriggerRevealResultingItem()
		{
		}

		// Token: 0x060033B7 RID: 13239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033B7")]
		[Address(RVA = "0x2E578B0", Offset = "0x2E568B0", VA = "0x182E578B0")]
		public CraftingAnimationEventsProxy()
		{
		}

		// Token: 0x04002CC6 RID: 11462
		[Token(Token = "0x4002CC6")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public CraftingRecipe CurrentRecipe;
	}
}
