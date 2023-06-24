using System;
using System.Collections.Generic;
using Assemblies.Sons.Items.Core;
using Il2CppDummyDll;
using Sons.Crafting;
using Sons.Gameplay.Cooking;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.UI
{
	// Token: 0x020004EE RID: 1262
	[Token(Token = "0x20004EE")]
	[AddComponentMenu("Sons/UI/CookingRecipeView")]
	public class CookingRecipeView : CraftingRecipeView
	{
		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06002112 RID: 8466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000487")]
		public CookingRecipe Recipe
		{
			[Token(Token = "0x6002112")]
			[Address(RVA = "0x120B640", Offset = "0x1209C40", VA = "0x18120B640")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002113")]
		[Address(RVA = "0x3321EE0", Offset = "0x33204E0", VA = "0x183321EE0")]
		public void Initialize(CookingRecipe recipe, bool isSelected)
		{
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x000099F0 File Offset: 0x00007BF0
		[Token(Token = "0x6002114")]
		[Address(RVA = "0x3322D80", Offset = "0x3321380", VA = "0x183322D80")]
		private Color GetPanelColor(bool isCraftable, bool isSelected)
		{
			return default(Color);
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002115")]
		[Address(RVA = "0x3322DB0", Offset = "0x33213B0", VA = "0x183322DB0")]
		private void InitializeStatEffects()
		{
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002116")]
		[Address(RVA = "0x3322FF0", Offset = "0x33215F0", VA = "0x183322FF0")]
		private void ShowBuffEffect(StatEffect statEffect, int index)
		{
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002117")]
		[Address(RVA = "0x33232B0", Offset = "0x33218B0", VA = "0x1833232B0")]
		private void ShowStatEffect(StatEffect statEffect)
		{
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002118")]
		[Address(RVA = "0x33232E0", Offset = "0x33218E0", VA = "0x1833232E0")]
		private void ShowStatEffect(StatEffect.Types statEffectType, float statEffectAmount)
		{
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x00009A08 File Offset: 0x00007C08
		[Token(Token = "0x6002119")]
		[Address(RVA = "0x33234E0", Offset = "0x3321AE0", VA = "0x1833234E0")]
		private Vector4 CalculateMaskPadding(StatEffect.Types statEffectType, float statEffectAmount, Vector4 padding, out bool isFullMask)
		{
			return default(Vector4);
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x00009A20 File Offset: 0x00007C20
		[Token(Token = "0x600211A")]
		[Address(RVA = "0x33236B0", Offset = "0x3321CB0", VA = "0x1833236B0")]
		private static float CalculateStatFactor(StatEffect.Types statEffectType, float statEffectAmount)
		{
			return 0f;
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x00009A38 File Offset: 0x00007C38
		[Token(Token = "0x600211B")]
		[Address(RVA = "0x33237B0", Offset = "0x3321DB0", VA = "0x1833237B0", Slot = "4")]
		protected override bool IsIngredientAvailableInInventory(ItemData itemData, CraftingIngredient ingredient)
		{
			return default(bool);
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600211C")]
		[Address(RVA = "0x3323990", Offset = "0x3321F90", VA = "0x183323990")]
		protected void ClearBuffs()
		{
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600211D")]
		[Address(RVA = "0x3323B70", Offset = "0x3322170", VA = "0x183323B70")]
		public CookingRecipeView()
		{
		}

		// Token: 0x04001EA7 RID: 7847
		[Token(Token = "0x4001EA7")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		protected RectTransform _buffsRoot;

		// Token: 0x04001EA8 RID: 7848
		[Token(Token = "0x4001EA8")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		protected List<RectTransform> _buffsRoots;

		// Token: 0x04001EA9 RID: 7849
		[Token(Token = "0x4001EA9")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _buffViewTemplate;

		// Token: 0x04001EAA RID: 7850
		[Token(Token = "0x4001EAA")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private CookingBuffs _cookingBuffs;

		// Token: 0x04001EAB RID: 7851
		[Token(Token = "0x4001EAB")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private List<GameObject> _cookingBuffGroups;

		// Token: 0x04001EAC RID: 7852
		[Token(Token = "0x4001EAC")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private List<GameObject> _cookingBuffSpacerGroups;

		// Token: 0x04001EAD RID: 7853
		[Token(Token = "0x4001EAD")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _healthStatGroup;

		// Token: 0x04001EAE RID: 7854
		[Token(Token = "0x4001EAE")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private RectMask2D _healthStatGroupMask;

		// Token: 0x04001EAF RID: 7855
		[Token(Token = "0x4001EAF")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private List<Image> _backgroundPanels;

		// Token: 0x04001EB0 RID: 7856
		[Token(Token = "0x4001EB0")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _selectedGameObject;

		// Token: 0x04001EB1 RID: 7857
		[Token(Token = "0x4001EB1")]
		[FieldOffset(Offset = "0xF8")]
		private List<CookingBuffView> _buffViews;

		// Token: 0x04001EB2 RID: 7858
		[Token(Token = "0x4001EB2")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private GameObject _hydrationStatGroup;

		// Token: 0x04001EB3 RID: 7859
		[Token(Token = "0x4001EB3")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private RectMask2D _hydrationStatGroupMask;

		// Token: 0x04001EB4 RID: 7860
		[Token(Token = "0x4001EB4")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private GameObject _staminaStatGroup;

		// Token: 0x04001EB5 RID: 7861
		[Token(Token = "0x4001EB5")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private RectMask2D _staminaStatGroupMask;

		// Token: 0x04001EB6 RID: 7862
		[Token(Token = "0x4001EB6")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private GameObject _fullnessStatGroup;

		// Token: 0x04001EB7 RID: 7863
		[Token(Token = "0x4001EB7")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private RectMask2D _fullnessStatGroupMask;

		// Token: 0x04001EB8 RID: 7864
		[Token(Token = "0x4001EB8")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private GameObject _restStatGroup;

		// Token: 0x04001EB9 RID: 7865
		[Token(Token = "0x4001EB9")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private RectMask2D _restStatGroupMask;

		// Token: 0x04001EBA RID: 7866
		[Token(Token = "0x4001EBA")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private float _statRectMaskSize;

		// Token: 0x04001EBB RID: 7867
		[Token(Token = "0x4001EBB")]
		[FieldOffset(Offset = "0x144")]
		[SerializeField]
		private float _statRoundUpFactor;

		// Token: 0x04001EBC RID: 7868
		[Token(Token = "0x4001EBC")]
		[FieldOffset(Offset = "0x148")]
		private CookingRecipe _recipe;

		// Token: 0x04001EBD RID: 7869
		[Token(Token = "0x4001EBD")]
		[FieldOffset(Offset = "0x0")]
		private static float _servingsPerContainer;
	}
}
