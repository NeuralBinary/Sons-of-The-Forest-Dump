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
	// Token: 0x020006B5 RID: 1717
	[Token(Token = "0x20006B5")]
	public class CraftingSystem : MonoBehaviour
	{
		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06002D5A RID: 11610 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002D5B RID: 11611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000608")]
		public static CraftingSystem Instance
		{
			[Token(Token = "0x6002D5A")]
			[Address(RVA = "0x3434360", Offset = "0x3432960", VA = "0x183434360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D5B")]
			[Address(RVA = "0x34343A0", Offset = "0x34329A0", VA = "0x1834343A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06002D5C RID: 11612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000609")]
		public Transform IngredientLayoutGroups
		{
			[Token(Token = "0x6002D5C")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06002D5D RID: 11613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700060A")]
		public Transform CraftingResultLocatorGroups
		{
			[Token(Token = "0x6002D5D")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06002D5E RID: 11614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700060B")]
		public List<CraftingIngredient> CurrentIngredients
		{
			[Token(Token = "0x6002D5E")]
			[Address(RVA = "0x737420", Offset = "0x735A20", VA = "0x180737420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06002D5F RID: 11615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700060C")]
		public UnityEvent<int> OnIngredientAddedEvent
		{
			[Token(Token = "0x6002D5F")]
			[Address(RVA = "0x751010", Offset = "0x74F610", VA = "0x180751010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06002D60 RID: 11616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700060D")]
		public UnityEvent<int> OnIngredientRemovedEvent
		{
			[Token(Token = "0x6002D60")]
			[Address(RVA = "0xA03D90", Offset = "0xA02390", VA = "0x180A03D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06002D61 RID: 11617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700060E")]
		public UnityEvent<CraftingRecipe> OnCraftBegin
		{
			[Token(Token = "0x6002D61")]
			[Address(RVA = "0x671190", Offset = "0x66F790", VA = "0x180671190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06002D62 RID: 11618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700060F")]
		public UnityEvent<CraftingRecipe> OnCraftComplete
		{
			[Token(Token = "0x6002D62")]
			[Address(RVA = "0x8ECC80", Offset = "0x8EB280", VA = "0x1808ECC80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06002D63 RID: 11619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000610")]
		public UnityEvent<CraftingRecipe> OnRevealResultingItem
		{
			[Token(Token = "0x6002D63")]
			[Address(RVA = "0x7849C0", Offset = "0x782FC0", VA = "0x1807849C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06002D64 RID: 11620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000611")]
		public UnityEvent<int> OnReuseIngredientEvent
		{
			[Token(Token = "0x6002D64")]
			[Address(RVA = "0x784A30", Offset = "0x783030", VA = "0x180784A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06002D65 RID: 11621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000612")]
		public IEnumerable<CraftingRecipe> CurrentlyAvailableRecipes
		{
			[Token(Token = "0x6002D65")]
			[Address(RVA = "0x3434430", Offset = "0x3432A30", VA = "0x183434430")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D66")]
		[Address(RVA = "0x3434480", Offset = "0x3432A80", VA = "0x183434480")]
		private string GetIsNewCraftingRecipeKey(CraftingRecipe recipe)
		{
			return null;
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D67")]
		[Address(RVA = "0x34344E0", Offset = "0x3432AE0", VA = "0x1834344E0")]
		public static string GetIsNewCraftingRecipeNotificationKey(CraftingRecipe recipe)
		{
			return null;
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D68")]
		[Address(RVA = "0x691530", Offset = "0x68FB30", VA = "0x180691530")]
		public IEnumerable<int> GetResultingItemIdsOnMat()
		{
			return null;
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D69")]
		[Address(RVA = "0x3434540", Offset = "0x3432B40", VA = "0x183434540")]
		private void Awake()
		{
		}

		// Token: 0x06002D6A RID: 11626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D6A")]
		[Address(RVA = "0x34345D0", Offset = "0x3432BD0", VA = "0x1834345D0")]
		private void Initialize()
		{
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D6B")]
		[Address(RVA = "0x34349F0", Offset = "0x3432FF0", VA = "0x1834349F0")]
		private void OnEnable()
		{
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D6C")]
		[Address(RVA = "0x3434C40", Offset = "0x3433240", VA = "0x183434C40")]
		private void RefreshRecipesEvent(ItemInstance arg0, int arg1)
		{
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D6D")]
		[Address(RVA = "0x3434C40", Offset = "0x3433240", VA = "0x183434C40")]
		private void RefreshRecipesEvent(ItemInstance arg0)
		{
		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D6E")]
		[Address(RVA = "0x3434C50", Offset = "0x3433250", VA = "0x183434C50")]
		private void OnDisable()
		{
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D6F")]
		[Address(RVA = "0x34350A0", Offset = "0x34336A0", VA = "0x1834350A0")]
		private void Update()
		{
		}

		// Token: 0x06002D70 RID: 11632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D70")]
		[Address(RVA = "0x3435110", Offset = "0x3433710", VA = "0x183435110")]
		public void AddIngredient(ItemInstance itemInstance)
		{
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D71")]
		[Address(RVA = "0x3435540", Offset = "0x3433B40", VA = "0x183435540")]
		private IEnumerator StopCogWhenTutorialIsComplete()
		{
			return null;
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x0000D608 File Offset: 0x0000B808
		[Token(Token = "0x6002D72")]
		[Address(RVA = "0x34355D0", Offset = "0x3433BD0", VA = "0x1834355D0")]
		public int GetIngredientCount(int itemId)
		{
			return 0;
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D73")]
		[Address(RVA = "0x34356B0", Offset = "0x3433CB0", VA = "0x1834356B0")]
		public void RemoveIngredient(int itemId, int count)
		{
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D74")]
		[Address(RVA = "0x3435A10", Offset = "0x3434010", VA = "0x183435A10")]
		public void StashAllIngredients()
		{
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D75")]
		[Address(RVA = "0x3435C30", Offset = "0x3434230", VA = "0x183435C30")]
		private void RefreshAvailableRecipes()
		{
		}

		// Token: 0x06002D76 RID: 11638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D76")]
		[Address(RVA = "0x3435CC0", Offset = "0x34342C0", VA = "0x183435CC0")]
		public void StashAllCraftingResultItems()
		{
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x0000D620 File Offset: 0x0000B820
		[Token(Token = "0x6002D77")]
		[Address(RVA = "0x3435E20", Offset = "0x3434420", VA = "0x183435E20")]
		public bool HasSatisfiedRecipeWithCurrentIngredients(out CraftingRecipe recipeOut)
		{
			return default(bool);
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x0000D638 File Offset: 0x0000B838
		[Token(Token = "0x6002D78")]
		[Address(RVA = "0x34363A0", Offset = "0x34349A0", VA = "0x1834363A0")]
		public bool TryCombineIngredients()
		{
			return default(bool);
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D79")]
		[Address(RVA = "0x3436910", Offset = "0x3434F10", VA = "0x183436910")]
		public void ForceCompleteCurrentCraft()
		{
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D7A")]
		[Address(RVA = "0x3436C40", Offset = "0x3435240", VA = "0x183436C40")]
		private void OnCraftCompleteInternal(CraftingRecipe recipe)
		{
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D7B")]
		[Address(RVA = "0x3437420", Offset = "0x3435A20", VA = "0x183437420")]
		private void OnRevealResultingItemInternal(CraftingRecipe recipe)
		{
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D7C")]
		[Address(RVA = "0x3437480", Offset = "0x3435A80", VA = "0x183437480")]
		private void ConsumeIngredientsForRecipe(CraftingRecipe recipe)
		{
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D7D")]
		[Address(RVA = "0x3437680", Offset = "0x3435C80", VA = "0x183437680")]
		private void CraftResultingItems(CraftingRecipe recipe)
		{
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D7E")]
		[Address(RVA = "0x3437850", Offset = "0x3435E50", VA = "0x183437850")]
		private void CraftResultingItem(CraftingRecipe recipe, CraftingRecipe.ResultingItem resultingItem)
		{
		}

		// Token: 0x06002D7F RID: 11647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D7F")]
		[Address(RVA = "0x3437D30", Offset = "0x3436330", VA = "0x183437D30")]
		private void DismantleWeaponMods(CraftingRecipe recipe)
		{
		}

		// Token: 0x06002D80 RID: 11648 RVA: 0x0000D650 File Offset: 0x0000B850
		[Token(Token = "0x6002D80")]
		[Address(RVA = "0x3438270", Offset = "0x3436870", VA = "0x183438270")]
		public bool CanHoldMoreOfIngredient(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D81")]
		[Address(RVA = "0x3438560", Offset = "0x3436B60", VA = "0x183438560")]
		public void ShowUI(bool enable)
		{
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D82")]
		[Address(RVA = "0x34385D0", Offset = "0x3436BD0", VA = "0x1834385D0")]
		private void UpdateIngredientProgress()
		{
		}

		// Token: 0x06002D83 RID: 11651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D83")]
		[Address(RVA = "0x34391B0", Offset = "0x34377B0", VA = "0x1834391B0")]
		public void OnMouseEnterCogProgress()
		{
		}

		// Token: 0x06002D84 RID: 11652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D84")]
		[Address(RVA = "0x3439330", Offset = "0x3437930", VA = "0x183439330")]
		public void OnMouseExitCogProgress()
		{
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D85")]
		[Address(RVA = "0x34393E0", Offset = "0x34379E0", VA = "0x1834393E0")]
		private void UpdateNewRecipes(bool forceOff = false)
		{
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x0000D668 File Offset: 0x0000B868
		[Token(Token = "0x6002D86")]
		[Address(RVA = "0x3439F20", Offset = "0x3438520", VA = "0x183439F20")]
		public float GetConsecutiveItemAnimCraftSpeed()
		{
			return 0f;
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D87")]
		[Address(RVA = "0x3439F50", Offset = "0x3438550", VA = "0x183439F50")]
		public void CheckForModalTutorial()
		{
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D88")]
		[Address(RVA = "0x343A050", Offset = "0x3438650", VA = "0x18343A050")]
		public CraftingSystem()
		{
		}

		// Token: 0x040027C3 RID: 10179
		[Token(Token = "0x40027C3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CraftingRecipeDatabase _recipeDatabase;

		// Token: 0x040027C4 RID: 10180
		[Token(Token = "0x40027C4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _ingredientLayoutGroups;

		// Token: 0x040027C5 RID: 10181
		[Token(Token = "0x40027C5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _craftingResultLayoutGroups;

		// Token: 0x040027C6 RID: 10182
		[Token(Token = "0x40027C6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CraftingCog _craftingCog;

		// Token: 0x040027C7 RID: 10183
		[Token(Token = "0x40027C7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _consecutiveItemCraftingSpeedIncrease;

		// Token: 0x040027C8 RID: 10184
		[Token(Token = "0x40027C8")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _maxConsecutiveItemCraftingSpeed;

		// Token: 0x040027C9 RID: 10185
		[Token(Token = "0x40027C9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _consecutiveCraftClickDelay;

		// Token: 0x040027CA RID: 10186
		[Token(Token = "0x40027CA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _craftingUiRoot;

		// Token: 0x040027CB RID: 10187
		[Token(Token = "0x40027CB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _ingredientsProgressBar;

		// Token: 0x040027CC RID: 10188
		[Token(Token = "0x40027CC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _ingredientsProgressBarOutline;

		// Token: 0x040027CD RID: 10189
		[Token(Token = "0x40027CD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TextMeshProUGUI _inventoryFull;

		// Token: 0x040027CE RID: 10190
		[Token(Token = "0x40027CE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _exclamationMark;

		// Token: 0x040027CF RID: 10191
		[Token(Token = "0x40027CF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _newRecipeCountGroup;

		// Token: 0x040027D0 RID: 10192
		[Token(Token = "0x40027D0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TextMeshPro _newRecipeCount;

		// Token: 0x040027D1 RID: 10193
		[Token(Token = "0x40027D1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _addIngredientsNotification;

		// Token: 0x040027D2 RID: 10194
		[Token(Token = "0x40027D2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _addItemsToMatTutorialModal;

		// Token: 0x040027D3 RID: 10195
		[Token(Token = "0x40027D3")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _clickCogTutorialModal;

		// Token: 0x040027DB RID: 10203
		[Token(Token = "0x40027DB")]
		[FieldOffset(Offset = "0xD8")]
		private List<IngredientLayoutItemGroup> _ingredientLayoutItemGroups;

		// Token: 0x040027DC RID: 10204
		[Token(Token = "0x40027DC")]
		[FieldOffset(Offset = "0xE0")]
		private List<CraftingResultLayoutItemGroup> _craftingResultLayoutItemGroups;

		// Token: 0x040027DD RID: 10205
		[Token(Token = "0x40027DD")]
		[FieldOffset(Offset = "0xE8")]
		private List<int> _resultingItemIdsOnMat;

		// Token: 0x040027DE RID: 10206
		[Token(Token = "0x40027DE")]
		[FieldOffset(Offset = "0xF0")]
		private List<CraftingRecipe> _availableRecipes;

		// Token: 0x040027DF RID: 10207
		[Token(Token = "0x40027DF")]
		[FieldOffset(Offset = "0xF8")]
		private CraftingAnimationEventsProxy _craftingAnimationEventsProxy;

		// Token: 0x040027E0 RID: 10208
		[Token(Token = "0x40027E0")]
		[FieldOffset(Offset = "0x100")]
		private int _cycleRecipesIndex;

		// Token: 0x040027E1 RID: 10209
		[Token(Token = "0x40027E1")]
		[FieldOffset(Offset = "0x104")]
		private bool _isInitialized;

		// Token: 0x040027E2 RID: 10210
		[Token(Token = "0x40027E2")]
		[FieldOffset(Offset = "0x105")]
		private bool _suppressCraftCompleteAudio;

		// Token: 0x040027E3 RID: 10211
		[Token(Token = "0x40027E3")]
		[FieldOffset(Offset = "0x108")]
		private EventInstance _duringCraftJingle;

		// Token: 0x040027E4 RID: 10212
		[Token(Token = "0x40027E4")]
		[FieldOffset(Offset = "0x110")]
		private float _timeUntilNextAllowedCraft;

		// Token: 0x040027E5 RID: 10213
		[Token(Token = "0x40027E5")]
		[FieldOffset(Offset = "0x118")]
		private PlayerState _playerState;

		// Token: 0x040027E6 RID: 10214
		[Token(Token = "0x40027E6")]
		[FieldOffset(Offset = "0x120")]
		private List<CraftingRecipe> _newCraftingRecipes;

		// Token: 0x040027E7 RID: 10215
		[Token(Token = "0x40027E7")]
		[FieldOffset(Offset = "0x128")]
		private int _consecutiveCraftsOfTheSameItem;

		// Token: 0x040027E8 RID: 10216
		[Token(Token = "0x40027E8")]
		[FieldOffset(Offset = "0x130")]
		private CraftingRecipe _lastCraftedRecipe;

		// Token: 0x040027E9 RID: 10217
		[Token(Token = "0x40027E9")]
		[FieldOffset(Offset = "0x138")]
		private Coroutine _waitForCogTutorialCompletion;
	}
}
