using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Crafting;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200078B RID: 1931
	[Token(Token = "0x200078B")]
	[AddComponentMenu("Sons/Gameplay/LootPouchItemRevealController")]
	public class LootPouchItemRevealController : MonoBehaviour
	{
		// Token: 0x060033FE RID: 13310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033FE")]
		[Address(RVA = "0x34C3370", Offset = "0x34C1970", VA = "0x1834C3370")]
		private void OnEnable()
		{
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033FF")]
		[Address(RVA = "0x34C35A0", Offset = "0x34C1BA0", VA = "0x1834C35A0")]
		private void OnDisable()
		{
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003400")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
		private void OnCraftingBegin(CraftingRecipe recipe)
		{
		}

		// Token: 0x06003401 RID: 13313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003401")]
		[Address(RVA = "0x34C36A0", Offset = "0x34C1CA0", VA = "0x1834C36A0")]
		public void RevealItems()
		{
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003402")]
		[Address(RVA = "0x34C39D0", Offset = "0x34C1FD0", VA = "0x1834C39D0")]
		public LootPouchItemRevealController()
		{
		}

		// Token: 0x04002CE4 RID: 11492
		[Token(Token = "0x4002CE4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<LootPouchItemRevealController.ItemLocator> _itemLocators;

		// Token: 0x04002CE5 RID: 11493
		[Token(Token = "0x4002CE5")]
		[FieldOffset(Offset = "0x28")]
		private CraftingRecipe _recipe;

		// Token: 0x0200078C RID: 1932
		[Token(Token = "0x200078C")]
		[Serializable]
		private class ItemLocator
		{
			// Token: 0x06003403 RID: 13315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003403")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ItemLocator()
			{
			}

			// Token: 0x04002CE6 RID: 11494
			[Token(Token = "0x4002CE6")]
			[FieldOffset(Offset = "0x10")]
			[ItemIdPicker(true)]
			[SerializeField]
			public int _itemId;

			// Token: 0x04002CE7 RID: 11495
			[Token(Token = "0x4002CE7")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public GameObject _locator;
		}
	}
}
