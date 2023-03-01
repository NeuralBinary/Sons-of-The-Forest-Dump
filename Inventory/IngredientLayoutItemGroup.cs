using System;
using Il2CppDummyDll;
using Sons.Crafting;
using UnityEngine.InputSystem;

namespace Sons.Inventory
{
	// Token: 0x020005EE RID: 1518
	[Token(Token = "0x20005EE")]
	public class IngredientLayoutItemGroup : LayoutItemGroup<IngredientLayoutItem>
	{
		// Token: 0x060026DA RID: 9946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DA")]
		[Address(RVA = "0x2D940E0", Offset = "0x2D930E0", VA = "0x182D940E0", Slot = "6")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DB")]
		[Address(RVA = "0x2D93E40", Offset = "0x2D92E40", VA = "0x182D93E40", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DC")]
		[Address(RVA = "0x2D93B20", Offset = "0x2D92B20", VA = "0x182D93B20")]
		public void AddBackToInventory(int itemId)
		{
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DD")]
		[Address(RVA = "0x2D943B0", Offset = "0x2D933B0", VA = "0x182D943B0")]
		private void OnInteractWithItem(InputAction.CallbackContext context)
		{
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DE")]
		[Address(RVA = "0x2D94590", Offset = "0x2D93590", VA = "0x182D94590")]
		private void OnRemoveItemFromMat(InputAction.CallbackContext context)
		{
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DF")]
		[Address(RVA = "0x2D946F0", Offset = "0x2D936F0", VA = "0x182D946F0")]
		public IngredientLayoutItemGroup()
		{
		}
	}
}
