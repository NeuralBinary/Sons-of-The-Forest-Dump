using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.Crafting.Structures
{
	// Token: 0x020007DB RID: 2011
	[Token(Token = "0x20007DB")]
	[AddComponentMenu("Sons/Crafting/Structures/StructureCraftingNodeIngredientUi")]
	public class StructureCraftingNodeIngredientUi : MonoBehaviour
	{
		// Token: 0x06003535 RID: 13621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003535")]
		[Address(RVA = "0x2E9DDD0", Offset = "0x2E9CDD0", VA = "0x182E9DDD0")]
		public void SetItem(int itemId)
		{
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003536")]
		[Address(RVA = "0x2E9DD80", Offset = "0x2E9CD80", VA = "0x182E9DD80")]
		public void SetAmount(int amount)
		{
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003537")]
		[Address(RVA = "0x2E9DCF0", Offset = "0x2E9CCF0", VA = "0x182E9DCF0")]
		public void SetActiveIngredient(bool show)
		{
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003538")]
		[Address(RVA = "0x2E9DB70", Offset = "0x2E9CB70", VA = "0x182E9DB70")]
		public void CanAfford(bool canAfford)
		{
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x0000F390 File Offset: 0x0000D590
		[Token(Token = "0x6003539")]
		[Address(RVA = "0x1E52250", Offset = "0x1E51250", VA = "0x181E52250")]
		public bool CanAfford()
		{
			return default(bool);
		}

		// Token: 0x0600353A RID: 13626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600353A")]
		[Address(RVA = "0x2E9DE50", Offset = "0x2E9CE50", VA = "0x182E9DE50")]
		public StructureCraftingNodeIngredientUi()
		{
		}

		// Token: 0x04002DA9 RID: 11689
		[Token(Token = "0x4002DA9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RawImage _icon;

		// Token: 0x04002DAA RID: 11690
		[Token(Token = "0x4002DAA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RawImage _iconOutline;

		// Token: 0x04002DAB RID: 11691
		[Token(Token = "0x4002DAB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _border;

		// Token: 0x04002DAC RID: 11692
		[Token(Token = "0x4002DAC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _background;

		// Token: 0x04002DAD RID: 11693
		[Token(Token = "0x4002DAD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _amount;

		// Token: 0x04002DAE RID: 11694
		[Token(Token = "0x4002DAE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RawImage _arrow;

		// Token: 0x04002DAF RID: 11695
		[Token(Token = "0x4002DAF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _inactive;

		// Token: 0x04002DB0 RID: 11696
		[Token(Token = "0x4002DB0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _inactiveFadeLevel;

		// Token: 0x04002DB1 RID: 11697
		[Token(Token = "0x4002DB1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04002DB2 RID: 11698
		[Token(Token = "0x4002DB2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _canAfford;

		// Token: 0x04002DB3 RID: 11699
		[Token(Token = "0x4002DB3")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Color _cantAffordColor;
	}
}
