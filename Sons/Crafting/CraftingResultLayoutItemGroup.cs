using System;
using Il2CppDummyDll;
using Sons.Inventory;
using UnityEngine.InputSystem;

namespace Sons.Crafting
{
	// Token: 0x020006C6 RID: 1734
	[Token(Token = "0x20006C6")]
	public class CraftingResultLayoutItemGroup : LayoutItemGroup<CraftingResultLayoutItem>
	{
		// Token: 0x06002DC5 RID: 11717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC5")]
		[Address(RVA = "0x343E5C0", Offset = "0x343CBC0", VA = "0x18343E5C0", Slot = "6")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06002DC6 RID: 11718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC6")]
		[Address(RVA = "0x343E7D0", Offset = "0x343CDD0", VA = "0x18343E7D0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC7")]
		[Address(RVA = "0x343E9E0", Offset = "0x343CFE0", VA = "0x18343E9E0")]
		private void OnInteractWithItem(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC8")]
		[Address(RVA = "0x343ECA0", Offset = "0x343D2A0", VA = "0x18343ECA0")]
		private void OnAlternateInteractWithItem(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002DC9 RID: 11721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC9")]
		[Address(RVA = "0x343EE00", Offset = "0x343D400", VA = "0x18343EE00")]
		public void StashToInventory()
		{
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DCA")]
		[Address(RVA = "0x343EF50", Offset = "0x343D550", VA = "0x18343EF50")]
		public CraftingResultLayoutItemGroup()
		{
		}
	}
}
