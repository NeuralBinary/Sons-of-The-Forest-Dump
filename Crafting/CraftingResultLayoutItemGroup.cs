using System;
using Il2CppDummyDll;
using Sons.Inventory;
using UnityEngine.InputSystem;

namespace Sons.Crafting
{
	// Token: 0x020007BB RID: 1979
	[Token(Token = "0x20007BB")]
	public class CraftingResultLayoutItemGroup : LayoutItemGroup<CraftingResultLayoutItem>
	{
		// Token: 0x0600344B RID: 13387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600344B")]
		[Address(RVA = "0x2E59940", Offset = "0x2E58940", VA = "0x182E59940", Slot = "6")]
		protected override void OnEnable()
		{
		}

		// Token: 0x0600344C RID: 13388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600344C")]
		[Address(RVA = "0x2E597C0", Offset = "0x2E587C0", VA = "0x182E597C0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x0600344D RID: 13389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600344D")]
		[Address(RVA = "0x2E59AC0", Offset = "0x2E58AC0", VA = "0x182E59AC0")]
		private void OnInteractWithItem(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600344E RID: 13390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600344E")]
		[Address(RVA = "0x2E596A0", Offset = "0x2E586A0", VA = "0x182E596A0")]
		private void OnAlternateInteractWithItem(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600344F RID: 13391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600344F")]
		[Address(RVA = "0x2E59D00", Offset = "0x2E58D00", VA = "0x182E59D00")]
		public void StashToInventory()
		{
		}

		// Token: 0x06003450 RID: 13392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003450")]
		[Address(RVA = "0x2E59E20", Offset = "0x2E58E20", VA = "0x182E59E20")]
		public CraftingResultLayoutItemGroup()
		{
		}
	}
}
