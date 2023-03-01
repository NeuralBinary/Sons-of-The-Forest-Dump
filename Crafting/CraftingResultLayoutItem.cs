using System;
using Il2CppDummyDll;
using Sons.Inventory;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Crafting
{
	// Token: 0x020007B9 RID: 1977
	[Token(Token = "0x20007B9")]
	public class CraftingResultLayoutItem : LayoutItem
	{
		// Token: 0x0600343E RID: 13374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600343E")]
		[Address(RVA = "0x2E5AA30", Offset = "0x2E59A30", VA = "0x182E5AA30", Slot = "6")]
		protected override void OnEnable()
		{
		}

		// Token: 0x0600343F RID: 13375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600343F")]
		[Address(RVA = "0x2E5A860", Offset = "0x2E59860", VA = "0x182E5A860", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06003440 RID: 13376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003440")]
		[Address(RVA = "0x2E5A6F0", Offset = "0x2E596F0", VA = "0x182E5A6F0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003441 RID: 13377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003441")]
		[Address(RVA = "0x2E5AD90", Offset = "0x2E59D90", VA = "0x182E5AD90", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x06003442 RID: 13378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003442")]
		[Address(RVA = "0x2E5AC00", Offset = "0x2E59C00", VA = "0x182E5AC00")]
		private void OnInteractWithItem(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06003443 RID: 13379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003443")]
		[Address(RVA = "0x2E5AD40", Offset = "0x2E59D40", VA = "0x182E5AD40")]
		private void OnRemoveItemFromMat(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06003444 RID: 13380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003444")]
		[Address(RVA = "0x2E5A6A0", Offset = "0x2E596A0", VA = "0x182E5A6A0", Slot = "11")]
		public override void Initialize(Transform rootTransform)
		{
		}

		// Token: 0x06003445 RID: 13381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003445")]
		[Address(RVA = "0x2E5AF10", Offset = "0x2E59F10", VA = "0x182E5AF10")]
		public void StashToInventory()
		{
		}

		// Token: 0x06003446 RID: 13382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003446")]
		[Address(RVA = "0x2E5A690", Offset = "0x2E59690", VA = "0x182E5A690")]
		private void DelayedAnimatedReveal(Transform renderableTransform)
		{
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003447")]
		[Address(RVA = "0x2E59E60", Offset = "0x2E58E60", VA = "0x182E59E60")]
		public void AnimateRevealedDuringCraft(CraftingRecipe recipe)
		{
		}

		// Token: 0x06003448 RID: 13384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003448")]
		[Address(RVA = "0x2E5B000", Offset = "0x2E5A000", VA = "0x182E5B000")]
		public CraftingResultLayoutItem()
		{
		}

		// Token: 0x04002D38 RID: 11576
		[Token(Token = "0x4002D38")]
		[FieldOffset(Offset = "0x68")]
		private Animator _craftingAnimator;

		// Token: 0x04002D39 RID: 11577
		[Token(Token = "0x4002D39")]
		[FieldOffset(Offset = "0x70")]
		private CraftingRecipe _cachedCraftingRecipe;
	}
}
