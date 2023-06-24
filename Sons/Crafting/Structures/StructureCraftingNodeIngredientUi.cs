using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.Crafting.Structures
{
	// Token: 0x020006E7 RID: 1767
	[Token(Token = "0x20006E7")]
	[AddComponentMenu("Sons/Crafting/Structures/StructureCraftingNodeIngredientUi")]
	public class StructureCraftingNodeIngredientUi : MonoBehaviour
	{
		// Token: 0x06002ECA RID: 11978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ECA")]
		[Address(RVA = "0x3456070", Offset = "0x3454670", VA = "0x183456070")]
		public void SetItem(int itemId)
		{
		}

		// Token: 0x06002ECB RID: 11979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ECB")]
		[Address(RVA = "0x34560F0", Offset = "0x34546F0", VA = "0x1834560F0")]
		public void SetAmount(int amount)
		{
		}

		// Token: 0x06002ECC RID: 11980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ECC")]
		[Address(RVA = "0x3456130", Offset = "0x3454730", VA = "0x183456130")]
		public void SetActiveIngredient(bool show)
		{
		}

		// Token: 0x06002ECD RID: 11981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ECD")]
		[Address(RVA = "0x34562D0", Offset = "0x34548D0", VA = "0x1834562D0")]
		public void CanAfford(bool canAfford)
		{
		}

		// Token: 0x06002ECE RID: 11982 RVA: 0x0000DD40 File Offset: 0x0000BF40
		[Token(Token = "0x6002ECE")]
		[Address(RVA = "0x15771D0", Offset = "0x15757D0", VA = "0x1815771D0")]
		public bool CanAfford()
		{
			return default(bool);
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ECF")]
		[Address(RVA = "0x3456450", Offset = "0x3454A50", VA = "0x183456450")]
		public StructureCraftingNodeIngredientUi()
		{
		}

		// Token: 0x0400288C RID: 10380
		[Token(Token = "0x400288C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RawImage _icon;

		// Token: 0x0400288D RID: 10381
		[Token(Token = "0x400288D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RawImage _iconOutline;

		// Token: 0x0400288E RID: 10382
		[Token(Token = "0x400288E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _border;

		// Token: 0x0400288F RID: 10383
		[Token(Token = "0x400288F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _background;

		// Token: 0x04002890 RID: 10384
		[Token(Token = "0x4002890")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _amount;

		// Token: 0x04002891 RID: 10385
		[Token(Token = "0x4002891")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RawImage _arrow;

		// Token: 0x04002892 RID: 10386
		[Token(Token = "0x4002892")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _inactive;

		// Token: 0x04002893 RID: 10387
		[Token(Token = "0x4002893")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _inactiveFadeLevel;

		// Token: 0x04002894 RID: 10388
		[Token(Token = "0x4002894")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04002895 RID: 10389
		[Token(Token = "0x4002895")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _canAfford;

		// Token: 0x04002896 RID: 10390
		[Token(Token = "0x4002896")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Color _cantAffordColor;
	}
}
