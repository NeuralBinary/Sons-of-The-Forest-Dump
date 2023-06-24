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
	// Token: 0x020004F4 RID: 1268
	[Token(Token = "0x20004F4")]
	[AddComponentMenu("Sons/UI/CraftingRecipeView")]
	public class CraftingRecipeView : MonoBehaviour
	{
		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x0600212B RID: 8491 RVA: 0x00009AB0 File Offset: 0x00007CB0
		// (set) Token: 0x0600212C RID: 8492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700048A")]
		public bool IsCraftable
		{
			[Token(Token = "0x600212B")]
			[Address(RVA = "0x6124E0", Offset = "0x610AE0", VA = "0x1806124E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600212C")]
			[Address(RVA = "0x6124F0", Offset = "0x610AF0", VA = "0x1806124F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x0600212D RID: 8493 RVA: 0x00009AC8 File Offset: 0x00007CC8
		// (set) Token: 0x0600212E RID: 8494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700048B")]
		public bool IsBeingUsed
		{
			[Token(Token = "0x600212D")]
			[Address(RVA = "0x25AEEA0", Offset = "0x25AD4A0", VA = "0x1825AEEA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600212E")]
			[Address(RVA = "0x25AEEB0", Offset = "0x25AD4B0", VA = "0x1825AEEB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x0600212F RID: 8495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048C")]
		public string Name
		{
			[Token(Token = "0x600212F")]
			[Address(RVA = "0x3324240", Offset = "0x3322840", VA = "0x183324240")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002130")]
		[Address(RVA = "0x3324270", Offset = "0x3322870", VA = "0x183324270")]
		public void Initialize(CraftingRecipe recipe)
		{
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x00009AE0 File Offset: 0x00007CE0
		[Token(Token = "0x6002131")]
		[Address(RVA = "0x3324E60", Offset = "0x3323460", VA = "0x183324E60", Slot = "4")]
		protected virtual bool IsIngredientAvailableInInventory(ItemData itemData, CraftingIngredient ingredient)
		{
			return default(bool);
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002132")]
		[Address(RVA = "0x3325040", Offset = "0x3323640", VA = "0x183325040")]
		protected void ClearIngredients()
		{
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002133")]
		[Address(RVA = "0x3325210", Offset = "0x3323810", VA = "0x183325210")]
		public CraftingRecipeView()
		{
		}

		// Token: 0x04001ECC RID: 7884
		[Token(Token = "0x4001ECC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected TextMeshProUGUI _recipeName;

		// Token: 0x04001ECD RID: 7885
		[Token(Token = "0x4001ECD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected RectTransform _ingredientsRoot;

		// Token: 0x04001ECE RID: 7886
		[Token(Token = "0x4001ECE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected GameObject _missingIngredientAsset;

		// Token: 0x04001ECF RID: 7887
		[Token(Token = "0x4001ECF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected GameObject _availableIngredientAsset;

		// Token: 0x04001ED0 RID: 7888
		[Token(Token = "0x4001ED0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected GameObject _completedIngredientAsset;

		// Token: 0x04001ED1 RID: 7889
		[Token(Token = "0x4001ED1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected Color _defaultBackgroundColor;

		// Token: 0x04001ED2 RID: 7890
		[Token(Token = "0x4001ED2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected Color _craftableBackgroundColor;

		// Token: 0x04001ED3 RID: 7891
		[Token(Token = "0x4001ED3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected Color _activeBackgroundColor;

		// Token: 0x04001ED4 RID: 7892
		[Token(Token = "0x4001ED4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		protected Color _availableColor;

		// Token: 0x04001ED5 RID: 7893
		[Token(Token = "0x4001ED5")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		protected Color _unavailableColor;

		// Token: 0x04001ED6 RID: 7894
		[Token(Token = "0x4001ED6")]
		[FieldOffset(Offset = "0x98")]
		protected List<CraftingIngredientView> _ingredientViews;
	}
}
