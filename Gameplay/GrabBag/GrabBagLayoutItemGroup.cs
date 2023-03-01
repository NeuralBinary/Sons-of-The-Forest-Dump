using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Inventory;
using TheForest.Items.Inventory;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Sons.Gameplay.GrabBag
{
	// Token: 0x02000700 RID: 1792
	[Token(Token = "0x2000700")]
	public class GrabBagLayoutItemGroup : LayoutItemGroup<GrabBagLayoutItem>
	{
		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06002E86 RID: 11910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CA")]
		public UnityEvent<ItemInstance, bool> OnItemInteraction
		{
			[Token(Token = "0x6002E86")]
			[Address(RVA = "0x68B100", Offset = "0x68A100", VA = "0x18068B100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06002E87 RID: 11911 RVA: 0x0000D3E0 File Offset: 0x0000B5E0
		[Token(Token = "0x170005CB")]
		public bool DisableGroupIfRecieverHasEquipped
		{
			[Token(Token = "0x6002E87")]
			[Address(RVA = "0x5F0C80", Offset = "0x5EFC80", VA = "0x1805F0C80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E88")]
		[Address(RVA = "0x2E0FD10", Offset = "0x2E0ED10", VA = "0x182E0FD10", Slot = "6")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E89")]
		[Address(RVA = "0x2E0F8C0", Offset = "0x2E0E8C0", VA = "0x182E0F8C0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x0000D3F8 File Offset: 0x0000B5F8
		[Token(Token = "0x6002E8A")]
		[Address(RVA = "0x2E10AD0", Offset = "0x2E0FAD0", VA = "0x182E10AD0", Slot = "9")]
		public override bool TryAddItem(ItemInstance itemInstance, int itemId)
		{
			return default(bool);
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E8B")]
		[Address(RVA = "0x2E10B90", Offset = "0x2E0FB90", VA = "0x182E10B90", Slot = "10")]
		public override void TryRemoveItem(ItemInstance itemInstance, int itemId)
		{
		}

		// Token: 0x06002E8C RID: 11916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E8C")]
		[Address(RVA = "0x2E103F0", Offset = "0x2E0F3F0", VA = "0x182E103F0", Slot = "8")]
		protected override void RefreshItems()
		{
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x0000D410 File Offset: 0x0000B610
		[Token(Token = "0x6002E8D")]
		[Address(RVA = "0x2E10CA0", Offset = "0x2E0FCA0", VA = "0x182E10CA0")]
		private bool WouldEnableVisualLayoutItem()
		{
			return default(bool);
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x0000D428 File Offset: 0x0000B628
		[Token(Token = "0x6002E8E")]
		[Address(RVA = "0x2E10C60", Offset = "0x2E0FC60", VA = "0x182E10C60")]
		private bool WouldDisableVisualLayoutItem()
		{
			return default(bool);
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E8F")]
		[Address(RVA = "0x2E0F620", Offset = "0x2E0E620", VA = "0x182E0F620")]
		private void GetNonUniqueCollectionValues(out int outCurrentVisualCount, out int outFinalVisualCount)
		{
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E90")]
		[Address(RVA = "0x2E10160", Offset = "0x2E0F160", VA = "0x182E10160")]
		private void OnInteractWithItem(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E91")]
		[Address(RVA = "0x2E10390", Offset = "0x2E0F390", VA = "0x182E10390")]
		public void OnMouseEnterLayoutItem(LayoutItem layoutItem)
		{
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E92")]
		[Address(RVA = "0x2E103C0", Offset = "0x2E0F3C0", VA = "0x182E103C0")]
		public void OnMouseExitLayoutItem(LayoutItem layoutItem)
		{
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E93")]
		[Address(RVA = "0x2E10390", Offset = "0x2E0F390", VA = "0x182E10390")]
		public void OnMouseOverLayoutItem(LayoutItem layoutItem)
		{
		}

		// Token: 0x06002E94 RID: 11924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E94")]
		[Address(RVA = "0x2E0F7A0", Offset = "0x2E0E7A0", VA = "0x182E0F7A0")]
		public void GrayOutItems(bool shouldGreyout)
		{
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E95")]
		[Address(RVA = "0x2E10960", Offset = "0x2E0F960", VA = "0x182E10960")]
		public void SetFromInventoryLayoutItemGroup(int itemId, bool isUniqueCollection)
		{
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E96")]
		[Address(RVA = "0x2E10CE0", Offset = "0x2E0FCE0", VA = "0x182E10CE0")]
		public GrabBagLayoutItemGroup()
		{
		}

		// Token: 0x04002944 RID: 10564
		[Token(Token = "0x4002944")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private bool _disableGroupIfRecieverHasEquipped;

		// Token: 0x04002945 RID: 10565
		[Token(Token = "0x4002945")]
		[FieldOffset(Offset = "0x78")]
		private PlayerInventory _inventory;
	}
}
