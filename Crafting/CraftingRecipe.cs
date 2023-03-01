using System;
using System.Collections.Generic;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Gameplay;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Crafting
{
	// Token: 0x020007A4 RID: 1956
	[Token(Token = "0x20007A4")]
	[CreateAssetMenu(fileName = "CraftingRecipe", menuName = "Sons/Crafting/Recipe")]
	public class CraftingRecipe : ScriptableObject
	{
		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x060033CB RID: 13259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000691")]
		public string CraftCompleteAudioEvent
		{
			[Token(Token = "0x60033CB")]
			[Address(RVA = "0x5E9610", Offset = "0x5E8610", VA = "0x1805E9610")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x060033CC RID: 13260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000692")]
		public string DuringCraftJingleAudioEvent
		{
			[Token(Token = "0x60033CC")]
			[Address(RVA = "0x5E9600", Offset = "0x5E8600", VA = "0x1805E9600")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x060033CD RID: 13261 RVA: 0x0000EC88 File Offset: 0x0000CE88
		[Token(Token = "0x17000693")]
		public CraftingRecipe.Type RecipeType
		{
			[Token(Token = "0x60033CD")]
			[Address(RVA = "0x5D9500", Offset = "0x5D8500", VA = "0x1805D9500")]
			get
			{
				return CraftingRecipe.Type.CraftNewItem;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x060033CE RID: 13262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000694")]
		public string Name
		{
			[Token(Token = "0x60033CE")]
			[Address(RVA = "0x28E6AF0", Offset = "0x28E5AF0", VA = "0x1828E6AF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x060033CF RID: 13263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000695")]
		public List<CraftingIngredient> Ingredients
		{
			[Token(Token = "0x60033CF")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x060033D0 RID: 13264 RVA: 0x0000ECA0 File Offset: 0x0000CEA0
		[Token(Token = "0x17000696")]
		public bool ForceNewItemInstance
		{
			[Token(Token = "0x60033D0")]
			[Address(RVA = "0x86F2E0", Offset = "0x86E2E0", VA = "0x18086F2E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060033D1 RID: 13265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D1")]
		[Address(RVA = "0x2E59370", Offset = "0x2E58370", VA = "0x182E59370")]
		public List<CraftingRecipe.ResultingItem> GenerateResultingItems()
		{
			return null;
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x060033D2 RID: 13266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000697")]
		public string AnimationStateName
		{
			[Token(Token = "0x60033D2")]
			[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x060033D3 RID: 13267 RVA: 0x0000ECB8 File Offset: 0x0000CEB8
		[Token(Token = "0x17000698")]
		public bool HasCraftAnimation
		{
			[Token(Token = "0x60033D3")]
			[Address(RVA = "0x2E59680", Offset = "0x2E58680", VA = "0x182E59680")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060033D4 RID: 13268 RVA: 0x0000ECD0 File Offset: 0x0000CED0
		[Token(Token = "0x60033D4")]
		[Address(RVA = "0x2E593D0", Offset = "0x2E583D0", VA = "0x182E593D0")]
		public bool HasIngredient(int itemId)
		{
			return default(bool);
		}

		// Token: 0x060033D5 RID: 13269 RVA: 0x0000ECE8 File Offset: 0x0000CEE8
		[Token(Token = "0x60033D5")]
		[Address(RVA = "0x2E594A0", Offset = "0x2E584A0", VA = "0x182E594A0")]
		public int RequiredCount(int itemId)
		{
			return default(int);
		}

		// Token: 0x060033D6 RID: 13270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D6")]
		[Address(RVA = "0x2E590A0", Offset = "0x2E580A0", VA = "0x182E590A0")]
		public void GenerateResultingItemList()
		{
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x060033D7 RID: 13271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000699")]
		public WeaponMod WeaponMod
		{
			[Token(Token = "0x60033D7")]
			[Address(RVA = "0x5E4C40", Offset = "0x5E3C40", VA = "0x1805E4C40")]
			get
			{
				return null;
			}
		}

		// Token: 0x060033D8 RID: 13272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D8")]
		[Address(RVA = "0x2E59590", Offset = "0x2E58590", VA = "0x182E59590")]
		public CraftingRecipe()
		{
		}

		// Token: 0x04002CDA RID: 11482
		[Token(Token = "0x4002CDA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CraftingRecipe.Type _recipeType;

		// Token: 0x04002CDB RID: 11483
		[Token(Token = "0x4002CDB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _animationStateName;

		// Token: 0x04002CDC RID: 11484
		[Token(Token = "0x4002CDC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<CraftingIngredient> _ingredients;

		// Token: 0x04002CDD RID: 11485
		[Token(Token = "0x4002CDD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _useContainerDataForResultingItems;

		// Token: 0x04002CDE RID: 11486
		[Token(Token = "0x4002CDE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ContainerItemSpawnerData _containerItemData;

		// Token: 0x04002CDF RID: 11487
		[Token(Token = "0x4002CDF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<CraftingRecipe.ResultingItem> _resultingItems;

		// Token: 0x04002CE0 RID: 11488
		[Token(Token = "0x4002CE0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _forceNewItemInstance;

		// Token: 0x04002CE1 RID: 11489
		[Token(Token = "0x4002CE1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[EventRef]
		private string _craftCompleteAudioEvent;

		// Token: 0x04002CE2 RID: 11490
		[Token(Token = "0x4002CE2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[EventRef]
		private string _duringCraftJingleAudioEvent;

		// Token: 0x04002CE3 RID: 11491
		[Token(Token = "0x4002CE3")]
		[FieldOffset(Offset = "0x60")]
		private List<CraftingRecipe.ResultingItem> _generatedResultingItems;

		// Token: 0x04002CE4 RID: 11492
		[Token(Token = "0x4002CE4")]
		[FieldOffset(Offset = "0x68")]
		[Space]
		[SerializeField]
		private WeaponMod _weaponMod;

		// Token: 0x020007A5 RID: 1957
		[Token(Token = "0x20007A5")]
		public enum Type
		{
			// Token: 0x04002CE6 RID: 11494
			[Token(Token = "0x4002CE6")]
			CraftNewItem,
			// Token: 0x04002CE7 RID: 11495
			[Token(Token = "0x4002CE7")]
			ApplyWeaponMod,
			// Token: 0x04002CE8 RID: 11496
			[Token(Token = "0x4002CE8")]
			DismantleWeaponMods
		}

		// Token: 0x020007A6 RID: 1958
		[Token(Token = "0x20007A6")]
		[Serializable]
		public class ResultingItem
		{
			// Token: 0x060033D9 RID: 13273 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60033D9")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public ResultingItem()
			{
			}

			// Token: 0x04002CE9 RID: 11497
			[Token(Token = "0x4002CE9")]
			[FieldOffset(Offset = "0x10")]
			[ItemIdPicker(2048, true)]
			public int Id;
		}
	}
}
