using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Crafting
{
	// Token: 0x020007BE RID: 1982
	[Token(Token = "0x20007BE")]
	public class IngredientLayoutItem : LayoutItem
	{
		// Token: 0x0600345A RID: 13402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600345A")]
		[Address(RVA = "0x2E60860", Offset = "0x2E5F860", VA = "0x182E60860")]
		private void Awake()
		{
		}

		// Token: 0x0600345B RID: 13403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600345B")]
		[Address(RVA = "0x2E610F0", Offset = "0x2E600F0", VA = "0x182E610F0", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x0600345C RID: 13404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600345C")]
		[Address(RVA = "0x2E615E0", Offset = "0x2E605E0", VA = "0x182E615E0", Slot = "4")]
		protected override void Update()
		{
		}

		// Token: 0x0600345D RID: 13405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600345D")]
		[Address(RVA = "0x2E608F0", Offset = "0x2E5F8F0", VA = "0x182E608F0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600345E")]
		[Address(RVA = "0x2E60F50", Offset = "0x2E5FF50", VA = "0x182E60F50", Slot = "6")]
		protected override void OnEnable()
		{
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600345F")]
		[Address(RVA = "0x2E60DE0", Offset = "0x2E5FDE0", VA = "0x182E60DE0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003460")]
		[Address(RVA = "0x2E608D0", Offset = "0x2E5F8D0", VA = "0x182E608D0", Slot = "11")]
		public override void Initialize(Transform rootTransform)
		{
		}

		// Token: 0x06003461 RID: 13409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003461")]
		[Address(RVA = "0x2E60920", Offset = "0x2E5F920", VA = "0x182E60920")]
		public void OnCraftBegin(CraftingRecipe recipe)
		{
		}

		// Token: 0x06003462 RID: 13410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003462")]
		[Address(RVA = "0x2E60D50", Offset = "0x2E5FD50", VA = "0x182E60D50")]
		public void OnCraftComplete(CraftingRecipe recipe)
		{
		}

		// Token: 0x06003463 RID: 13411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003463")]
		[Address(RVA = "0x2E606F0", Offset = "0x2E5F6F0", VA = "0x182E606F0")]
		private void AddAnimator()
		{
		}

		// Token: 0x06003464 RID: 13412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003464")]
		[Address(RVA = "0x2E610C0", Offset = "0x2E600C0", VA = "0x182E610C0", Slot = "8")]
		protected override void OnMouseEnter()
		{
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003465")]
		[Address(RVA = "0x2E61670", Offset = "0x2E60670", VA = "0x182E61670")]
		public IngredientLayoutItem()
		{
		}

		// Token: 0x04002D46 RID: 11590
		[Token(Token = "0x4002D46")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _resetTransformAfterCraftAnimation;

		// Token: 0x04002D47 RID: 11591
		[Token(Token = "0x4002D47")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<int> _resetChildNodeIndicies;

		// Token: 0x04002D48 RID: 11592
		[Token(Token = "0x4002D48")]
		[FieldOffset(Offset = "0x78")]
		public bool ShouldHaveAnimator;

		// Token: 0x04002D49 RID: 11593
		[Token(Token = "0x4002D49")]
		[FieldOffset(Offset = "0x80")]
		private Animator _craftingAnimator;

		// Token: 0x04002D4A RID: 11594
		[Token(Token = "0x4002D4A")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 _storedLocalPosition;

		// Token: 0x04002D4B RID: 11595
		[Token(Token = "0x4002D4B")]
		[FieldOffset(Offset = "0x94")]
		private Quaternion _storedLocalRotation;

		// Token: 0x04002D4C RID: 11596
		[Token(Token = "0x4002D4C")]
		[FieldOffset(Offset = "0xA4")]
		private bool _doDelayedReset;
	}
}
