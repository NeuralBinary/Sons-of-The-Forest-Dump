using System;
using Il2CppDummyDll;
using Sons.Inventory;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Crafting
{
	// Token: 0x020006C4 RID: 1732
	[Token(Token = "0x20006C4")]
	public class CraftingResultLayoutItem : LayoutItem
	{
		// Token: 0x06002DB7 RID: 11703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DB7")]
		[Address(RVA = "0x343C370", Offset = "0x343A970", VA = "0x18343C370", Slot = "6")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DB8")]
		[Address(RVA = "0x343C650", Offset = "0x343AC50", VA = "0x18343C650", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DB9")]
		[Address(RVA = "0x343C930", Offset = "0x343AF30", VA = "0x18343C930", Slot = "4")]
		protected override void Update()
		{
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DBA")]
		[Address(RVA = "0x343CA10", Offset = "0x343B010", VA = "0x18343CA10")]
		private void LateUpdate()
		{
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DBB")]
		[Address(RVA = "0x343CD20", Offset = "0x343B320", VA = "0x18343CD20", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DBC")]
		[Address(RVA = "0x343D090", Offset = "0x343B690", VA = "0x18343D090")]
		private void OnInteractWithItem(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DBD")]
		[Address(RVA = "0x343D1C0", Offset = "0x343B7C0", VA = "0x18343D1C0")]
		private void OnRemoveItemFromMat(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DBE")]
		[Address(RVA = "0x343D210", Offset = "0x343B810", VA = "0x18343D210", Slot = "11")]
		public override void Initialize(Transform rootTransform)
		{
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DBF")]
		[Address(RVA = "0x343D290", Offset = "0x343B890", VA = "0x18343D290")]
		public void StashToInventory()
		{
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC0")]
		[Address(RVA = "0x343D580", Offset = "0x343BB80", VA = "0x18343D580")]
		private void DelayedAnimatedReveal(Transform renderableTransform)
		{
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC1")]
		[Address(RVA = "0x343D590", Offset = "0x343BB90", VA = "0x18343D590")]
		public void AnimateRevealedDuringCraft(CraftingRecipe recipe)
		{
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC2")]
		[Address(RVA = "0x343E540", Offset = "0x343CB40", VA = "0x18343E540")]
		public CraftingResultLayoutItem()
		{
		}

		// Token: 0x0400280C RID: 10252
		[Token(Token = "0x400280C")]
		[FieldOffset(Offset = "0x68")]
		private Animator _craftingAnimator;

		// Token: 0x0400280D RID: 10253
		[Token(Token = "0x400280D")]
		[FieldOffset(Offset = "0x70")]
		private CraftingRecipe _cachedCraftingRecipe;
	}
}
