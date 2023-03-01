using System;
using Il2CppDummyDll;
using Sons.Inventory;
using Sons.Wearable.Clothing;
using TheForest.Items.Inventory;
using UnityEngine;

namespace Sons.Items
{
	// Token: 0x0200082B RID: 2091
	[Token(Token = "0x200082B")]
	public class BackpackVisuals : MonoBehaviour
	{
		// Token: 0x0600379F RID: 14239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600379F")]
		[Address(RVA = "0x2EAA740", Offset = "0x2EA9740", VA = "0x182EAA740")]
		private void OnEnable()
		{
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037A0")]
		[Address(RVA = "0x2EAAA90", Offset = "0x2EA9A90", VA = "0x182EAAA90")]
		private void OnItemUnequipped(ItemInstance _, int itemId)
		{
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037A1")]
		[Address(RVA = "0x2EAA9F0", Offset = "0x2EA99F0", VA = "0x182EAA9F0")]
		private void OnItemEquipped(ItemInstance _, int itemId)
		{
		}

		// Token: 0x060037A2 RID: 14242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037A2")]
		[Address(RVA = "0x2EAA980", Offset = "0x2EA9980", VA = "0x182EAA980")]
		private void OnItemAdded(ItemInstance _, int itemId)
		{
		}

		// Token: 0x060037A3 RID: 14243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037A3")]
		[Address(RVA = "0x2EAAA40", Offset = "0x2EA9A40", VA = "0x182EAAA40")]
		private void OnItemRemoved(ItemInstance _, int itemId)
		{
		}

		// Token: 0x060037A4 RID: 14244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037A4")]
		[Address(RVA = "0x2EAAAE0", Offset = "0x2EA9AE0", VA = "0x182EAAAE0")]
		private void ShowBackpack(bool show)
		{
		}

		// Token: 0x060037A5 RID: 14245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037A5")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public BackpackVisuals()
		{
		}

		// Token: 0x04002F9D RID: 12189
		[Token(Token = "0x4002F9D")]
		[FieldOffset(Offset = "0x20")]
		private PlayerInventory _inventory;

		// Token: 0x04002F9E RID: 12190
		[Token(Token = "0x4002F9E")]
		[FieldOffset(Offset = "0x28")]
		private PlayerClothingSystem _clothing;
	}
}
