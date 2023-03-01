using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Crafting;
using Sons.Items.Core;
using TMPro;
using UnityEngine;

namespace Sons.UI
{
	// Token: 0x020004F5 RID: 1269
	[Token(Token = "0x20004F5")]
	[AddComponentMenu("Sons/UI/CraftingRecipeView")]
	public class CraftingRecipeView : MonoBehaviour
	{
		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06002078 RID: 8312 RVA: 0x000095B8 File Offset: 0x000077B8
		// (set) Token: 0x06002079 RID: 8313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000478")]
		public bool IsCraftable
		{
			[Token(Token = "0x6002078")]
			[Address(RVA = "0x6743F0", Offset = "0x6733F0", VA = "0x1806743F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002079")]
			[Address(RVA = "0x674510", Offset = "0x673510", VA = "0x180674510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x0600207A RID: 8314 RVA: 0x000095D0 File Offset: 0x000077D0
		// (set) Token: 0x0600207B RID: 8315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000479")]
		public bool IsBeingUsed
		{
			[Token(Token = "0x600207A")]
			[Address(RVA = "0x2AF6C60", Offset = "0x2AF5C60", VA = "0x182AF6C60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600207B")]
			[Address(RVA = "0x2D27400", Offset = "0x2D26400", VA = "0x182D27400")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x0600207C RID: 8316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047A")]
		public string Name
		{
			[Token(Token = "0x600207C")]
			[Address(RVA = "0x2D273D0", Offset = "0x2D263D0", VA = "0x182D273D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600207D")]
		[Address(RVA = "0x2D26830", Offset = "0x2D25830", VA = "0x182D26830")]
		public void Initialize(CraftingRecipe recipe)
		{
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x000095E8 File Offset: 0x000077E8
		[Token(Token = "0x600207E")]
		[Address(RVA = "0x2D27170", Offset = "0x2D26170", VA = "0x182D27170")]
		private static bool IsIngredientAvailableInInventory(ItemData itemData, CraftingIngredient ingredient)
		{
			return default(bool);
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600207F")]
		[Address(RVA = "0x2D26720", Offset = "0x2D25720", VA = "0x182D26720")]
		private void ClearIngredients()
		{
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002080")]
		[Address(RVA = "0x2D27320", Offset = "0x2D26320", VA = "0x182D27320")]
		public CraftingRecipeView()
		{
		}

		// Token: 0x04001E3D RID: 7741
		[Token(Token = "0x4001E3D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _recipeName;

		// Token: 0x04001E3E RID: 7742
		[Token(Token = "0x4001E3E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _ingredientsRoot;

		// Token: 0x04001E3F RID: 7743
		[Token(Token = "0x4001E3F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _missingIngredientAsset;

		// Token: 0x04001E40 RID: 7744
		[Token(Token = "0x4001E40")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _availableIngredientAsset;

		// Token: 0x04001E41 RID: 7745
		[Token(Token = "0x4001E41")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _completedIngredientAsset;

		// Token: 0x04001E42 RID: 7746
		[Token(Token = "0x4001E42")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _defaultBackgroundColor;

		// Token: 0x04001E43 RID: 7747
		[Token(Token = "0x4001E43")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _craftableBackgroundColor;

		// Token: 0x04001E44 RID: 7748
		[Token(Token = "0x4001E44")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _availableColor;

		// Token: 0x04001E45 RID: 7749
		[Token(Token = "0x4001E45")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _unavailableColor;

		// Token: 0x04001E46 RID: 7750
		[Token(Token = "0x4001E46")]
		[FieldOffset(Offset = "0x88")]
		private List<CraftingIngredientView> _ingredientViews;
	}
}
