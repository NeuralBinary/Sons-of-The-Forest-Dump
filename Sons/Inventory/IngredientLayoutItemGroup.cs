using System;
using Il2CppDummyDll;
using Sons.Crafting;
using UnityEngine.InputSystem;

namespace Sons.Inventory
{
	// Token: 0x02000600 RID: 1536
	[Token(Token = "0x2000600")]
	public class IngredientLayoutItemGroup : LayoutItemGroup<IngredientLayoutItem>
	{
		// Token: 0x060027E4 RID: 10212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E4")]
		[Address(RVA = "0x33CED30", Offset = "0x33CD330", VA = "0x1833CED30", Slot = "6")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E5")]
		[Address(RVA = "0x33CF130", Offset = "0x33CD730", VA = "0x1833CF130", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E6")]
		[Address(RVA = "0x33CF4E0", Offset = "0x33CDAE0", VA = "0x1833CF4E0")]
		public void AddBackToInventory(int itemId)
		{
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E7")]
		[Address(RVA = "0x33CF880", Offset = "0x33CDE80", VA = "0x1833CF880")]
		private void OnInteractWithItem(InputAction.CallbackContext context)
		{
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E8")]
		[Address(RVA = "0x33CFA90", Offset = "0x33CE090", VA = "0x1833CFA90")]
		private void OnRemoveItemFromMat(InputAction.CallbackContext context)
		{
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E9")]
		[Address(RVA = "0x33CFC10", Offset = "0x33CE210", VA = "0x1833CFC10")]
		public IngredientLayoutItemGroup()
		{
		}
	}
}
