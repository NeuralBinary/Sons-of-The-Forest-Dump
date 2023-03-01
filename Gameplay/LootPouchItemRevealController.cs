using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Crafting;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200066C RID: 1644
	[Token(Token = "0x200066C")]
	[AddComponentMenu("Sons/Gameplay/LootPouchItemRevealController")]
	public class LootPouchItemRevealController : MonoBehaviour
	{
		// Token: 0x06002A01 RID: 10753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A01")]
		[Address(RVA = "0x2DD1CC0", Offset = "0x2DD0CC0", VA = "0x182DD1CC0")]
		private void OnEnable()
		{
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A02")]
		[Address(RVA = "0x2DD1BF0", Offset = "0x2DD0BF0", VA = "0x182DD1BF0")]
		private void OnDisable()
		{
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A03")]
		[Address(RVA = "0x541270", Offset = "0x540270", VA = "0x180541270")]
		private void OnCraftingBegin(CraftingRecipe recipe)
		{
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A04")]
		[Address(RVA = "0x2DD1E90", Offset = "0x2DD0E90", VA = "0x182DD1E90")]
		public void RevealItems()
		{
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A05")]
		[Address(RVA = "0x2DD20A0", Offset = "0x2DD10A0", VA = "0x182DD20A0")]
		public LootPouchItemRevealController()
		{
		}

		// Token: 0x04002587 RID: 9607
		[Token(Token = "0x4002587")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<LootPouchItemRevealController.ItemLocator> _itemLocators;

		// Token: 0x04002588 RID: 9608
		[Token(Token = "0x4002588")]
		[FieldOffset(Offset = "0x28")]
		private CraftingRecipe _recipe;

		// Token: 0x0200066D RID: 1645
		[Token(Token = "0x200066D")]
		[Serializable]
		private class ItemLocator
		{
			// Token: 0x06002A06 RID: 10758 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002A06")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public ItemLocator()
			{
			}

			// Token: 0x04002589 RID: 9609
			[Token(Token = "0x4002589")]
			[FieldOffset(Offset = "0x10")]
			[ItemIdPicker(true)]
			[SerializeField]
			public int _itemId;

			// Token: 0x0400258A RID: 9610
			[Token(Token = "0x400258A")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public GameObject _locator;
		}
	}
}
