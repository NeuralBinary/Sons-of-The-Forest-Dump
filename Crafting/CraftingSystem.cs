using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FMOD.Studio;
using Il2CppDummyDll;
using Sons.Inventory;
using Sons.Player;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Sons.Crafting
{
	// Token: 0x020007AA RID: 1962
	[Token(Token = "0x20007AA")]
	public class CraftingSystem : MonoBehaviour
	{
		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x060033E2 RID: 13282 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060033E3 RID: 13283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700069B")]
		public static CraftingSystem Instance
		{
			[Token(Token = "0x60033E2")]
			[Address(RVA = "0x2E5F8F0", Offset = "0x2E5E8F0", VA = "0x182E5F8F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60033E3")]
			[Address(RVA = "0x2E5F930", Offset = "0x2E5E930", VA = "0x182E5F930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x060033E4 RID: 13284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069C")]
		public Transform IngredientLayoutGroups
		{
			[Token(Token = "0x60033E4")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x060033E5 RID: 13285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069D")]
		public Transform CraftingResultLocatorGroups
		{
			[Token(Token = "0x60033E5")]
			[Address(RVA = "0x541210", Offset = "0x540210", VA = "0x180541210")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060033E6 RID: 13286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069E")]
		public List<CraftingIngredient> CurrentIngredients
		{
			[Token(Token = "0x60033E6")]
			[Address(RVA = "0x68B0F0", Offset = "0x68A0F0", VA = "0x18068B0F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x060033E7 RID: 13287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069F")]
		public UnityEvent<int> OnIngredientAddedEvent
		{
			[Token(Token = "0x60033E7")]
			[Address(RVA = "0x6AC8C0", Offset = "0x6AB8C0", VA = "0x1806AC8C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x060033E8 RID: 13288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A0")]
		public UnityEvent<int> OnIngredientRemovedEvent
		{
			[Token(Token = "0x60033E8")]
			[Address(RVA = "0x8C25D0", Offset = "0x8C15D0", VA = "0x1808C25D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x060033E9 RID: 13289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A1")]
		public UnityEvent<CraftingRecipe> OnCraftBegin
		{
			[Token(Token = "0x60033E9")]
			[Address(RVA = "0x5F1A50", Offset = "0x5F0A50", VA = "0x1805F1A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x060033EA RID: 13290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A2")]
		public UnityEvent<CraftingRecipe> OnCraftComplete
		{
			[Token(Token = "0x60033EA")]
			[Address(RVA = "0x7CCBE0", Offset = "0x7CBBE0", VA = "0x1807CCBE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060033EB RID: 13291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A3")]
		public UnityEvent<CraftingRecipe> OnRevealResultingItem
		{
			[Token(Token = "0x60033EB")]
			[Address(RVA = "0x6B70E0", Offset = "0x6B60E0", VA = "0x1806B70E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060033EC RID: 13292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A4")]
		public UnityEvent<int> OnReuseIngredientEvent
		{
			[Token(Token = "0x60033EC")]
			[Address(RVA = "0x6B7130", Offset = "0x6B6130", VA = "0x1806B7130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060033ED RID: 13293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A5")]
		public IEnumerable<CraftingRecipe> CurrentlyAvailableRecipes
		{
			[Token(Token = "0x60033ED")]
			[Address(RVA = "0x2E5F8A0", Offset = "0x2E5E8A0", VA = "0x182E5F8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033EE")]
		[Address(RVA = "0x2E5C520", Offset = "0x2E5B520", VA = "0x182E5C520")]
		private string GetIsNewCraftingRecipeKey(CraftingRecipe recipe)
		{
			return null;
		}

		// Token: 0x060033EF RID: 13295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033EF")]
		[Address(RVA = "0x2E5C580", Offset = "0x2E5B580", VA = "0x182E5C580")]
		public static string GetIsNewCraftingRecipeNotificationKey(CraftingRecipe recipe)
		{
			return null;
		}

		// Token: 0x060033F0 RID: 13296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F0")]
		[Address(RVA = "0x604130", Offset = "0x603130", VA = "0x180604130")]
		public IEnumerable<int> GetResultingItemIdsOnMat()
		{
			return null;
		}

		// Token: 0x060033F1 RID: 13297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F1")]
		[Address(RVA = "0x2E5B3E0", Offset = "0x2E5A3E0", VA = "0x182E5B3E0")]
		private void Awake()
		{
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F2")]
		[Address(RVA = "0x2E5CB00", Offset = "0x2E5BB00", VA = "0x182E5CB00")]
		private void Initialize()
		{
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F3")]
		[Address(RVA = "0x2E5D490", Offset = "0x2E5C490", VA = "0x182E5D490")]
		private void OnEnable()
		{
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F4")]
		[Address(RVA = "0x2E5D8E0", Offset = "0x2E5C8E0", VA = "0x182E5D8E0")]
		private void RefreshRecipesEvent(ItemInstance arg0, int arg1)
		{
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F5")]
		[Address(RVA = "0x2E5D8E0", Offset = "0x2E5C8E0", VA = "0x182E5D8E0")]
		private void RefreshRecipesEvent(ItemInstance arg0)
		{
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F6")]
		[Address(RVA = "0x2E5D200", Offset = "0x2E5C200", VA = "0x182E5D200")]
		private void OnDisable()
		{
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F7")]
		[Address(RVA = "0x2E5F520", Offset = "0x2E5E520", VA = "0x182E5F520")]
		private void Update()
		{
		}

		// Token: 0x060033F8 RID: 13304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F8")]
		[Address(RVA = "0x2E5B050", Offset = "0x2E5A050", VA = "0x182E5B050")]
		public void AddIngredient(ItemInstance itemInstance)
		{
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F9")]
		[Address(RVA = "0x2E5DEB0", Offset = "0x2E5CEB0", VA = "0x182E5DEB0")]
		private IEnumerator StopCogWhenTutorialIsComplete()
		{
			return null;
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x0000ED30 File Offset: 0x0000CF30
		[Token(Token = "0x60033FA")]
		[Address(RVA = "0x2E5C430", Offset = "0x2E5B430", VA = "0x182E5C430")]
		public int GetIngredientCount(int itemId)
		{
			return default(int);
		}

		// Token: 0x060033FB RID: 13307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033FB")]
		[Address(RVA = "0x2E5D8F0", Offset = "0x2E5C8F0", VA = "0x182E5D8F0")]
		public void RemoveIngredient(int itemId, int count)
		{
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033FC")]
		[Address(RVA = "0x2E5DCD0", Offset = "0x2E5CCD0", VA = "0x182E5DCD0")]
		public void StashAllIngredients()
		{
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033FD")]
		[Address(RVA = "0x2E5D890", Offset = "0x2E5C890", VA = "0x182E5D890")]
		private void RefreshAvailableRecipes()
		{
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033FE")]
		[Address(RVA = "0x2E5DBA0", Offset = "0x2E5CBA0", VA = "0x182E5DBA0")]
		public void StashAllCraftingResultItems()
		{
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x0000ED48 File Offset: 0x0000CF48
		[Token(Token = "0x60033FF")]
		[Address(RVA = "0x2E5C5E0", Offset = "0x2E5B5E0", VA = "0x182E5C5E0")]
		public bool HasSatisfiedRecipeWithCurrentIngredients(out CraftingRecipe recipeOut)
		{
			return default(bool);
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x0000ED60 File Offset: 0x0000CF60
		[Token(Token = "0x6003400")]
		[Address(RVA = "0x2E5DF20", Offset = "0x2E5CF20", VA = "0x182E5DF20")]
		public bool TryCombineIngredients()
		{
			return default(bool);
		}

		// Token: 0x06003401 RID: 13313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003401")]
		[Address(RVA = "0x2E5CE10", Offset = "0x2E5BE10", VA = "0x182E5CE10")]
		private void OnCraftCompleteInternal(CraftingRecipe recipe)
		{
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003402")]
		[Address(RVA = "0x2E5D830", Offset = "0x2E5C830", VA = "0x182E5D830")]
		private void OnRevealResultingItemInternal(CraftingRecipe recipe)
		{
		}

		// Token: 0x06003403 RID: 13315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003403")]
		[Address(RVA = "0x2E5B770", Offset = "0x2E5A770", VA = "0x182E5B770")]
		private void ConsumeIngredientsForRecipe(CraftingRecipe recipe)
		{
		}

		// Token: 0x06003404 RID: 13316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003404")]
		[Address(RVA = "0x2E5BE20", Offset = "0x2E5AE20", VA = "0x182E5BE20")]
		private void CraftResultingItems(CraftingRecipe recipe)
		{
		}

		// Token: 0x06003405 RID: 13317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003405")]
		[Address(RVA = "0x2E5B960", Offset = "0x2E5A960", VA = "0x182E5B960")]
		private void CraftResultingItem(CraftingRecipe recipe, CraftingRecipe.ResultingItem resultingItem)
		{
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003406")]
		[Address(RVA = "0x2E5BFC0", Offset = "0x2E5AFC0", VA = "0x182E5BFC0")]
		private void DismantleWeaponMods(CraftingRecipe recipe)
		{
		}

		// Token: 0x06003407 RID: 13319 RVA: 0x0000ED78 File Offset: 0x0000CF78
		[Token(Token = "0x6003407")]
		[Address(RVA = "0x2E5B440", Offset = "0x2E5A440", VA = "0x182E5B440")]
		public bool CanHoldMoreOfIngredient(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003408")]
		[Address(RVA = "0x2E5DB80", Offset = "0x2E5CB80", VA = "0x182E5DB80")]
		public void ShowUI(bool enable)
		{
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003409")]
		[Address(RVA = "0x2E5E300", Offset = "0x2E5D300", VA = "0x182E5E300")]
		private void UpdateIngredientProgress()
		{
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600340A")]
		[Address(RVA = "0x2E5D670", Offset = "0x2E5C670", VA = "0x182E5D670")]
		public void OnMouseEnterCogProgress()
		{
		}

		// Token: 0x0600340B RID: 13323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600340B")]
		[Address(RVA = "0x2E5D7B0", Offset = "0x2E5C7B0", VA = "0x182E5D7B0")]
		public void OnMouseExitCogProgress()
		{
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600340C")]
		[Address(RVA = "0x2E5ECB0", Offset = "0x2E5DCB0", VA = "0x182E5ECB0")]
		private void UpdateNewRecipes(bool forceOff = false)
		{
		}

		// Token: 0x0600340D RID: 13325 RVA: 0x0000ED90 File Offset: 0x0000CF90
		[Token(Token = "0x600340D")]
		[Address(RVA = "0x2E5C400", Offset = "0x2E5B400", VA = "0x182E5C400")]
		public float GetConsecutiveItemAnimCraftSpeed()
		{
			return default(float);
		}

		// Token: 0x0600340E RID: 13326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600340E")]
		[Address(RVA = "0x2E5B6F0", Offset = "0x2E5A6F0", VA = "0x182E5B6F0")]
		public void CheckForModalTutorial()
		{
		}

		// Token: 0x0600340F RID: 13327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600340F")]
		[Address(RVA = "0x2E5F560", Offset = "0x2E5E560", VA = "0x182E5F560")]
		public CraftingSystem()
		{
		}

		// Token: 0x04002CF0 RID: 11504
		[Token(Token = "0x4002CF0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CraftingRecipeDatabase _recipeDatabase;

		// Token: 0x04002CF1 RID: 11505
		[Token(Token = "0x4002CF1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _ingredientLayoutGroups;

		// Token: 0x04002CF2 RID: 11506
		[Token(Token = "0x4002CF2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _craftingResultLayoutGroups;

		// Token: 0x04002CF3 RID: 11507
		[Token(Token = "0x4002CF3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CraftingCog _craftingCog;

		// Token: 0x04002CF4 RID: 11508
		[Token(Token = "0x4002CF4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _consecutiveItemCraftingSpeedIncrease;

		// Token: 0x04002CF5 RID: 11509
		[Token(Token = "0x4002CF5")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _maxConsecutiveItemCraftingSpeed;

		// Token: 0x04002CF6 RID: 11510
		[Token(Token = "0x4002CF6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _consecutiveCraftClickDelay;

		// Token: 0x04002CF7 RID: 11511
		[Token(Token = "0x4002CF7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _craftingUiRoot;

		// Token: 0x04002CF8 RID: 11512
		[Token(Token = "0x4002CF8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _ingredientsProgressBar;

		// Token: 0x04002CF9 RID: 11513
		[Token(Token = "0x4002CF9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _ingredientsProgressBarOutline;

		// Token: 0x04002CFA RID: 11514
		[Token(Token = "0x4002CFA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TextMeshProUGUI _inventoryFull;

		// Token: 0x04002CFB RID: 11515
		[Token(Token = "0x4002CFB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _exclamationMark;

		// Token: 0x04002CFC RID: 11516
		[Token(Token = "0x4002CFC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _newRecipeCountGroup;

		// Token: 0x04002CFD RID: 11517
		[Token(Token = "0x4002CFD")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TextMeshPro _newRecipeCount;

		// Token: 0x04002CFE RID: 11518
		[Token(Token = "0x4002CFE")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _addIngredientsNotification;

		// Token: 0x04002CFF RID: 11519
		[Token(Token = "0x4002CFF")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _addItemsToMatTutorialModal;

		// Token: 0x04002D00 RID: 11520
		[Token(Token = "0x4002D00")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _clickCogTutorialModal;

		// Token: 0x04002D08 RID: 11528
		[Token(Token = "0x4002D08")]
		[FieldOffset(Offset = "0xD8")]
		private List<IngredientLayoutItemGroup> _ingredientLayoutItemGroups;

		// Token: 0x04002D09 RID: 11529
		[Token(Token = "0x4002D09")]
		[FieldOffset(Offset = "0xE0")]
		private List<CraftingResultLayoutItemGroup> _craftingResultLayoutItemGroups;

		// Token: 0x04002D0A RID: 11530
		[Token(Token = "0x4002D0A")]
		[FieldOffset(Offset = "0xE8")]
		private List<int> _resultingItemIdsOnMat;

		// Token: 0x04002D0B RID: 11531
		[Token(Token = "0x4002D0B")]
		[FieldOffset(Offset = "0xF0")]
		private List<CraftingRecipe> _availableRecipes;

		// Token: 0x04002D0C RID: 11532
		[Token(Token = "0x4002D0C")]
		[FieldOffset(Offset = "0xF8")]
		private CraftingAnimationEventsProxy _craftingAnimationEventsProxy;

		// Token: 0x04002D0D RID: 11533
		[Token(Token = "0x4002D0D")]
		[FieldOffset(Offset = "0x100")]
		private int _cycleRecipesIndex;

		// Token: 0x04002D0E RID: 11534
		[Token(Token = "0x4002D0E")]
		[FieldOffset(Offset = "0x104")]
		private bool _isInitialized;

		// Token: 0x04002D0F RID: 11535
		[Token(Token = "0x4002D0F")]
		[FieldOffset(Offset = "0x108")]
		private EventInstance _duringCraftJingle;

		// Token: 0x04002D10 RID: 11536
		[Token(Token = "0x4002D10")]
		[FieldOffset(Offset = "0x110")]
		private float _timeUntilNextAllowedCraft;

		// Token: 0x04002D11 RID: 11537
		[Token(Token = "0x4002D11")]
		[FieldOffset(Offset = "0x118")]
		private PlayerState _playerState;

		// Token: 0x04002D12 RID: 11538
		[Token(Token = "0x4002D12")]
		[FieldOffset(Offset = "0x120")]
		private List<CraftingRecipe> _newCraftingRecipes;

		// Token: 0x04002D13 RID: 11539
		[Token(Token = "0x4002D13")]
		[FieldOffset(Offset = "0x128")]
		private int _consecutiveCraftsOfTheSameItem;

		// Token: 0x04002D14 RID: 11540
		[Token(Token = "0x4002D14")]
		[FieldOffset(Offset = "0x130")]
		private CraftingRecipe _lastCraftedRecipe;

		// Token: 0x04002D15 RID: 11541
		[Token(Token = "0x4002D15")]
		[FieldOffset(Offset = "0x138")]
		private Coroutine _waitForCogTutorialCompletion;
	}
}
