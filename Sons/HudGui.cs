using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using NGUI.Interaction;
using NGUI.Internal;
using NGUI.UI;
using Sons.Crafting;
using Sons.Gameplay.Cooking;
using Sons.Gui;
using Sons.Gui.Input;
using Sons.Input;
using Sons.Inventory;
using Sons.Items.Core;
using Sons.UI;
using TheForest.Items.Inventory;
using TheForest.Items.UI;
using TheForest.Modding.Bridge.Interfaces;
using TheForest.UI;
using TheForest.UI.Multiplayer;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.UI;

// Token: 0x02000287 RID: 647
[Token(Token = "0x2000287")]
public class HudGui : MonoBehaviour
{
	// Token: 0x0600111C RID: 4380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111C")]
	[Address(RVA = "0x37440E0", Offset = "0x37426E0", VA = "0x1837440E0")]
	public void ShowValidCookingRecipes(bool enable, bool hasWater, bool excludeCleanWater = false, [Optional] IEnumerable<CookingRecipe> recipes, [Optional] CookingRecipe selectedRecipe)
	{
	}

	// Token: 0x17000200 RID: 512
	// (get) Token: 0x0600111D RID: 4381 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000200")]
	public static PlayerTutorials Tutorials
	{
		[Token(Token = "0x600111D")]
		[Address(RVA = "0x37451C0", Offset = "0x37437C0", VA = "0x1837451C0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000201 RID: 513
	// (get) Token: 0x0600111E RID: 4382 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000201")]
	public static HudGui Instance
	{
		[Token(Token = "0x600111E")]
		[Address(RVA = "0x3745220", Offset = "0x3743820", VA = "0x183745220")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000202 RID: 514
	// (get) Token: 0x0600111F RID: 4383 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001120 RID: 4384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000202")]
	public MonoBehaviour DelayedActionIconController
	{
		[Token(Token = "0x600111F")]
		[Address(RVA = "0x3745370", Offset = "0x3743970", VA = "0x183745370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001120")]
		[Address(RVA = "0x3745380", Offset = "0x3743980", VA = "0x183745380")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000203 RID: 515
	// (get) Token: 0x06001121 RID: 4385 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000203")]
	private PlayerInventory Inventory
	{
		[Token(Token = "0x6001121")]
		[Address(RVA = "0x2D80570", Offset = "0x2D7EB70", VA = "0x182D80570")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001122 RID: 4386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001122")]
	[Address(RVA = "0x37453E0", Offset = "0x37439E0", VA = "0x1837453E0")]
	private void Awake()
	{
	}

	// Token: 0x06001123 RID: 4387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001123")]
	[Address(RVA = "0x37456C0", Offset = "0x3743CC0", VA = "0x1837456C0")]
	private void Start()
	{
	}

	// Token: 0x06001124 RID: 4388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001124")]
	[Address(RVA = "0x37461D0", Offset = "0x37447D0", VA = "0x1837461D0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001125 RID: 4389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001125")]
	[Address(RVA = "0x37463A0", Offset = "0x37449A0", VA = "0x1837463A0")]
	private void SubscribeCallbacks()
	{
	}

	// Token: 0x06001126 RID: 4390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001126")]
	[Address(RVA = "0x3746710", Offset = "0x3744D10", VA = "0x183746710")]
	private void UnsubscribeCallbacks()
	{
	}

	// Token: 0x06001127 RID: 4391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001127")]
	[Address(RVA = "0x37469F0", Offset = "0x3744FF0", VA = "0x1837469F0")]
	private void OnAfterSave(bool wasAutosave)
	{
	}

	// Token: 0x06001128 RID: 4392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001128")]
	[Address(RVA = "0x3746C00", Offset = "0x3745200", VA = "0x183746C00")]
	private void OnAfterLoad()
	{
	}

	// Token: 0x06001129 RID: 4393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001129")]
	[Address(RVA = "0x3746E10", Offset = "0x3745410", VA = "0x183746E10")]
	private void OnAdrenaline(object o)
	{
	}

	// Token: 0x0600112A RID: 4394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600112A")]
	[Address(RVA = "0x3746ED0", Offset = "0x37454D0", VA = "0x183746ED0")]
	private void OnPlayerResetFromHeal(object o)
	{
	}

	// Token: 0x0600112B RID: 4395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600112B")]
	[Address(RVA = "0x3747040", Offset = "0x3745640", VA = "0x183747040")]
	public void OnLoadedFromRespawn(object o)
	{
	}

	// Token: 0x0600112C RID: 4396 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600112C")]
	[Address(RVA = "0x37470A0", Offset = "0x37456A0", VA = "0x1837470A0")]
	private IEnumerator ForceBlackScreen(float duration)
	{
		return null;
	}

	// Token: 0x0600112D RID: 4397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600112D")]
	[Address(RVA = "0x37470F0", Offset = "0x37456F0", VA = "0x1837470F0")]
	private void Update()
	{
	}

	// Token: 0x0600112E RID: 4398 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600112E")]
	[Address(RVA = "0x3747680", Offset = "0x3745C80", VA = "0x183747680")]
	private IEnumerator WaitForGameStart()
	{
		return null;
	}

	// Token: 0x0600112F RID: 4399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600112F")]
	[Address(RVA = "0x3747710", Offset = "0x3745D10", VA = "0x183747710")]
	private static void InitPrefabPool(Transform prefab)
	{
	}

	// Token: 0x06001130 RID: 4400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001130")]
	[Address(RVA = "0x37478B0", Offset = "0x3745EB0", VA = "0x1837478B0")]
	private static void InitPrefabPoolLarge(Transform prefab)
	{
	}

	// Token: 0x06001131 RID: 4401 RVA: 0x00006330 File Offset: 0x00004530
	[Token(Token = "0x6001131")]
	[Address(RVA = "0x32B4710", Offset = "0x32B2D10", VA = "0x1832B4710")]
	private int GetScreenResolutionHash()
	{
		return 0;
	}

	// Token: 0x06001132 RID: 4402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001132")]
	[Address(RVA = "0x3747A40", Offset = "0x3746040", VA = "0x183747A40")]
	private void CheckTimedGOs(List<HudGui.TimedGameObject> timedGameObjects)
	{
	}

	// Token: 0x06001133 RID: 4403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001133")]
	[Address(RVA = "0x3747B80", Offset = "0x3746180", VA = "0x183747B80")]
	private void CheckTimedGOs(Dictionary<int, HudGui.TimedGameObject> gos)
	{
	}

	// Token: 0x06001134 RID: 4404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001134")]
	[Address(RVA = "0x3747D00", Offset = "0x3746300", VA = "0x183747D00")]
	private void CheckTimedGameObject(HudGui.TimedGameObject timedGameObject, out bool isDone)
	{
	}

	// Token: 0x06001135 RID: 4405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001135")]
	[Address(RVA = "0x37480E0", Offset = "0x37466E0", VA = "0x1837480E0")]
	public void SetPauseMenuActive(bool active)
	{
	}

	// Token: 0x06001136 RID: 4406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001136")]
	[Address(RVA = "0x37484E0", Offset = "0x3746AE0", VA = "0x1837484E0")]
	private void StopSlowTimeToZeroWorker()
	{
	}

	// Token: 0x06001137 RID: 4407 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001137")]
	[Address(RVA = "0x3748550", Offset = "0x3746B50", VA = "0x183748550")]
	private IEnumerator SlowTimeToZero()
	{
		return null;
	}

	// Token: 0x06001138 RID: 4408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001138")]
	[Address(RVA = "0x37485E0", Offset = "0x3746BE0", VA = "0x1837485E0")]
	public void SetDelayedIconController(MonoBehaviour mb)
	{
	}

	// Token: 0x06001139 RID: 4409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001139")]
	[Address(RVA = "0x3748760", Offset = "0x3746D60", VA = "0x183748760")]
	public void UnsetDelayedIconController(MonoBehaviour mb)
	{
	}

	// Token: 0x0600113A RID: 4410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600113A")]
	[Address(RVA = "0x3748980", Offset = "0x3746F80", VA = "0x183748980")]
	public void CheckDelayedActionController()
	{
	}

	// Token: 0x0600113B RID: 4411 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600113B")]
	[Address(RVA = "0x3748C10", Offset = "0x3747210", VA = "0x183748C10")]
	public static string GetTutorialTranslation(string translationKey)
	{
		return null;
	}

	// Token: 0x0600113C RID: 4412 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600113C")]
	[Address(RVA = "0x3748E00", Offset = "0x3747400", VA = "0x183748E00")]
	public static string GetItemsTranslation(string translationKey)
	{
		return null;
	}

	// Token: 0x0600113D RID: 4413 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600113D")]
	[Address(RVA = "0x3748FF0", Offset = "0x37475F0", VA = "0x183748FF0")]
	private string GetMeatItemName(ItemUiData uiData, bool plural, bool caps)
	{
		return null;
	}

	// Token: 0x0600113E RID: 4414 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600113E")]
	[Address(RVA = "0x37490A0", Offset = "0x37476A0", VA = "0x1837490A0")]
	private static string GetLeftClickActionName(ItemData itemData)
	{
		return null;
	}

	// Token: 0x0600113F RID: 4415 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600113F")]
	[Address(RVA = "0x37493D0", Offset = "0x37479D0", VA = "0x1837493D0")]
	private string GetRightClickActionName(ItemData itemData)
	{
		return null;
	}

	// Token: 0x06001140 RID: 4416 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001140")]
	[Address(RVA = "0x3749730", Offset = "0x3747D30", VA = "0x183749730")]
	private HudGui.TimedGameObject SpawnTimedGameObject(int itemId, int amount, float endTime, GameObject go, TextMeshProUGUI label)
	{
		return null;
	}

	// Token: 0x06001141 RID: 4417 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001141")]
	[Address(RVA = "0x37498A0", Offset = "0x3747EA0", VA = "0x1837498A0")]
	public void ToggleFullCapacityHud(int itemId)
	{
	}

	// Token: 0x06001142 RID: 4418 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001142")]
	[Address(RVA = "0x374A1D0", Offset = "0x37487D0", VA = "0x18374A1D0")]
	public void ToggleGotItemHud(ItemInstance itemInstance, int amount)
	{
	}

	// Token: 0x06001143 RID: 4419 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001143")]
	[Address(RVA = "0x374AC50", Offset = "0x3749250", VA = "0x18374AC50")]
	public void DisplayGeneralMessage(string message, float duration = 3f, [Optional] ItemUiData uiData)
	{
	}

	// Token: 0x06001144 RID: 4420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001144")]
	[Address(RVA = "0x374B470", Offset = "0x3749A70", VA = "0x18374B470")]
	public void ClearAllRequiredCollectionCounts()
	{
	}

	// Token: 0x06001145 RID: 4421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001145")]
	[Address(RVA = "0x374B610", Offset = "0x3749C10", VA = "0x18374B610")]
	public void DisplayRequiredCollectionCountForItem(ItemData itemData, int totalAmountNeeded, int amountInInventory)
	{
	}

	// Token: 0x06001146 RID: 4422 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001146")]
	[Address(RVA = "0x374C3C0", Offset = "0x374A9C0", VA = "0x18374C3C0")]
	private static string GotItemText(ItemInstance itemInstance, int amount)
	{
		return null;
	}

	// Token: 0x06001147 RID: 4423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001147")]
	[Address(RVA = "0x374CA20", Offset = "0x374B020", VA = "0x18374CA20")]
	public void SetCutsceneMode(bool enable)
	{
	}

	// Token: 0x06001148 RID: 4424 RVA: 0x00006348 File Offset: 0x00004548
	[Token(Token = "0x6001148")]
	[Address(RVA = "0x374CDF0", Offset = "0x374B3F0", VA = "0x18374CDF0")]
	private static Vector2 GetContextWindowScreenPosition()
	{
		return default(Vector2);
	}

	// Token: 0x06001149 RID: 4425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001149")]
	[Address(RVA = "0x374D020", Offset = "0x374B620", VA = "0x18374D020")]
	public void EnableMainCameraBlurUI(bool enable)
	{
	}

	// Token: 0x0600114A RID: 4426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600114A")]
	[Address(RVA = "0x374D310", Offset = "0x374B910", VA = "0x18374D310")]
	public void ShowSleepNotification(bool show, int playersWaiting = 0, int totalPlayerCount = 0)
	{
	}

	// Token: 0x0600114B RID: 4427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600114B")]
	[Address(RVA = "0x374D340", Offset = "0x374B940", VA = "0x18374D340")]
	public void ShowNetworkInteractionNotification(bool show, int playersWaiting = 0, int totalPlayerCount = 0)
	{
	}

	// Token: 0x0600114C RID: 4428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600114C")]
	[Address(RVA = "0x374D370", Offset = "0x374B970", VA = "0x18374D370")]
	private void ShowPlayerWaitingNotification(bool show, int playersWaiting, int totalPlayerCount, GameObject playerNotificationGroup, TextMeshProUGUI playersWaitingText)
	{
	}

	// Token: 0x0600114D RID: 4429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600114D")]
	[Address(RVA = "0x374D490", Offset = "0x374BA90", VA = "0x18374D490")]
	private void EnableCursor(bool enabled)
	{
	}

	// Token: 0x0600114E RID: 4430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600114E")]
	[Address(RVA = "0x374D660", Offset = "0x374BC60", VA = "0x18374D660")]
	private void SetCursorType(InputSystem.SoftwareCursor.Types type)
	{
	}

	// Token: 0x0600114F RID: 4431 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600114F")]
	[Address(RVA = "0x374DA70", Offset = "0x374C070", VA = "0x18374DA70")]
	private void SetCursorScreenPosition(Vector3 screenPosition)
	{
	}

	// Token: 0x06001150 RID: 4432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001150")]
	[Address(RVA = "0x374DE60", Offset = "0x374C460", VA = "0x18374DE60")]
	public void ShowInventoryItemInfo(ItemInstance itemInstance, bool isOnCraftMat = false, int itemHotkeyIndex = -1)
	{
	}

	// Token: 0x06001151 RID: 4433 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001151")]
	[Address(RVA = "0x374E2C0", Offset = "0x374C8C0", VA = "0x18374E2C0")]
	public ItemInstance GetHoveredItemInstance()
	{
		return null;
	}

	// Token: 0x06001152 RID: 4434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001152")]
	[Address(RVA = "0x374E2D0", Offset = "0x374C8D0", VA = "0x18374E2D0")]
	private void InventoryUpdate()
	{
	}

	// Token: 0x06001153 RID: 4435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001153")]
	[Address(RVA = "0x374E7F0", Offset = "0x374CDF0", VA = "0x18374E7F0")]
	private void ClearHoveredItemInstance()
	{
	}

	// Token: 0x06001154 RID: 4436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001154")]
	[Address(RVA = "0x374E850", Offset = "0x374CE50", VA = "0x18374E850")]
	private void UpdateTitleAndImage(ItemInstance itemInstance)
	{
	}

	// Token: 0x06001155 RID: 4437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001155")]
	[Address(RVA = "0x374EAC0", Offset = "0x374D0C0", VA = "0x18374EAC0")]
	private void UpdateAmountDisplay(ItemInstance itemInstance, ItemAmountLabel itemAmountLabel)
	{
	}

	// Token: 0x06001156 RID: 4438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001156")]
	[Address(RVA = "0x374F060", Offset = "0x374D660", VA = "0x18374F060")]
	private void UpdateActionIcons(ItemInstance itemInstance)
	{
	}

	// Token: 0x06001157 RID: 4439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001157")]
	[Address(RVA = "0x374F5F0", Offset = "0x374DBF0", VA = "0x18374F5F0")]
	private void UpdateDescription(ItemInstance itemInstance)
	{
	}

	// Token: 0x06001158 RID: 4440 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001158")]
	[Address(RVA = "0x374FBB0", Offset = "0x374E1B0", VA = "0x18374FBB0")]
	private static string RecipeDisplayName(VolumeContainerItemInstanceModule module)
	{
		return null;
	}

	// Token: 0x06001159 RID: 4441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001159")]
	[Address(RVA = "0x374FE60", Offset = "0x374E460", VA = "0x18374FE60")]
	private void UpdateStats(ItemInstance itemInstance)
	{
	}

	// Token: 0x0600115A RID: 4442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115A")]
	[Address(RVA = "0x3750220", Offset = "0x374E820", VA = "0x183750220")]
	private void UpdateMeleeWeaponStats(ItemInstance itemInstance)
	{
	}

	// Token: 0x0600115B RID: 4443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115B")]
	[Address(RVA = "0x3750330", Offset = "0x374E930", VA = "0x183750330")]
	private void UpdateClothingStats(ItemInstance itemInstance)
	{
	}

	// Token: 0x0600115C RID: 4444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115C")]
	[Address(RVA = "0x37504D0", Offset = "0x374EAD0", VA = "0x1837504D0")]
	private void UpdateContainerVolumeStats(ItemInstance itemInstance)
	{
	}

	// Token: 0x0600115D RID: 4445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115D")]
	[Address(RVA = "0x3750590", Offset = "0x374EB90", VA = "0x183750590")]
	public void ShowValidCraftingRecipes(bool enable, [Optional] IEnumerable<CraftingRecipe> recipes)
	{
	}

	// Token: 0x0600115E RID: 4446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115E")]
	[Address(RVA = "0x3751340", Offset = "0x374F940", VA = "0x183751340")]
	public void PlayerConnectionStateChanged(string playerName, Color playerColor, CoopUtils.PlayerConnectionState state)
	{
	}

	// Token: 0x0600115F RID: 4447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115F")]
	[Address(RVA = "0x3751590", Offset = "0x374FB90", VA = "0x183751590")]
	private void QuickSelectUpdate()
	{
	}

	// Token: 0x06001160 RID: 4448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001160")]
	[Address(RVA = "0x3751A10", Offset = "0x3750010", VA = "0x183751A10")]
	public void ShowQuickSelectItemInfo(ItemInstance itemInstance)
	{
	}

	// Token: 0x06001161 RID: 4449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001161")]
	[Address(RVA = "0x3751CE0", Offset = "0x37502E0", VA = "0x183751CE0")]
	private void UpdateTooltip()
	{
	}

	// Token: 0x06001162 RID: 4450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001162")]
	[Address(RVA = "0x3752160", Offset = "0x3750760", VA = "0x183752160")]
	public void ShowToolTipInfo(string toolTipTextKey)
	{
	}

	// Token: 0x06001163 RID: 4451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001163")]
	[Address(RVA = "0x3752620", Offset = "0x3750C20", VA = "0x183752620")]
	public HudGui()
	{
	}

	// Token: 0x06001165 RID: 4453 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001165")]
	[Address(RVA = "0x3752C40", Offset = "0x3751240", VA = "0x183752C40")]
	[CompilerGenerated]
	internal static string <PlayerConnectionStateChanged>g__FloatNormalizedToHex|198_0(float value)
	{
		return null;
	}

	// Token: 0x04001088 RID: 4232
	[Token(Token = "0x4001088")]
	private const string EmptyRecipeKey = "EMPTY";

	// Token: 0x04001089 RID: 4233
	[Token(Token = "0x4001089")]
	private const string CookingLocalizationTableKey = "Cooking";

	// Token: 0x0400108A RID: 4234
	[Token(Token = "0x400108A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform _cookingRecipeInfoView;

	// Token: 0x0400108B RID: 4235
	[Token(Token = "0x400108B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<CookingRecipeView> _cookingRecipeViews;

	// Token: 0x0400108C RID: 4236
	[Token(Token = "0x400108C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject _cookingRecipeListDots;

	// Token: 0x0400108D RID: 4237
	[Token(Token = "0x400108D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject _cookingWaterRequired;

	// Token: 0x0400108E RID: 4238
	[Token(Token = "0x400108E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private int _maxCookingRecipeListCount;

	// Token: 0x0400108F RID: 4239
	[Token(Token = "0x400108F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private CookingRecipeDatabase _cookingRecipeDatabase;

	// Token: 0x04001090 RID: 4240
	[Token(Token = "0x4001090")]
	private const string TutorialTableReferenceKey = "Tutorials";

	// Token: 0x04001091 RID: 4241
	[Token(Token = "0x4001091")]
	private const string ItemsTableReferenceKey = "Items";

	// Token: 0x04001092 RID: 4242
	[Token(Token = "0x4001092")]
	private const string ScreenPromptsTableReferenceKey = "ScreenPrompts";

	// Token: 0x04001093 RID: 4243
	[Token(Token = "0x4001093")]
	private const string UseTranslationKey = "USE";

	// Token: 0x04001094 RID: 4244
	[Token(Token = "0x4001094")]
	private const string EquipTranslationKey = "EQUIP";

	// Token: 0x04001095 RID: 4245
	[Token(Token = "0x4001095")]
	private const string PlayTranslationKey = "PLAY";

	// Token: 0x04001096 RID: 4246
	[Token(Token = "0x4001096")]
	private const string DrinkTranslationKey = "DRINK";

	// Token: 0x04001097 RID: 4247
	[Token(Token = "0x4001097")]
	private const string ReadTranslationKey = "READ";

	// Token: 0x04001098 RID: 4248
	[Token(Token = "0x4001098")]
	private const string TakeTranslationKey = "TAKE";

	// Token: 0x04001099 RID: 4249
	[Token(Token = "0x4001099")]
	private const string ChargeTranslationKey = "CHARGE";

	// Token: 0x0400109A RID: 4250
	[Token(Token = "0x400109A")]
	private const string WearTranslationKey = "WEAR";

	// Token: 0x0400109B RID: 4251
	[Token(Token = "0x400109B")]
	private const string EatTranslationKey = "EAT";

	// Token: 0x0400109C RID: 4252
	[Token(Token = "0x400109C")]
	private const string SelectTranslationKey = "SELECT";

	// Token: 0x0400109D RID: 4253
	[Token(Token = "0x400109D")]
	private const string RemoveTranslationKey = "REMOVE";

	// Token: 0x0400109E RID: 4254
	[Token(Token = "0x400109E")]
	private const string AddItemsTranslationKey = "ADDITEMS";

	// Token: 0x0400109F RID: 4255
	[Token(Token = "0x400109F")]
	private const string AddTranslationKey = "ADD";

	// Token: 0x040010A0 RID: 4256
	[Token(Token = "0x40010A0")]
	private const string CombineTranslationKey = "COMBINE";

	// Token: 0x040010A1 RID: 4257
	[Token(Token = "0x40010A1")]
	private const string OpenTranslationKey = "OPEN";

	// Token: 0x040010A2 RID: 4258
	[Token(Token = "0x40010A2")]
	private const string UnequipTranslationKey = "UNEQUIP";

	// Token: 0x040010A3 RID: 4259
	[Token(Token = "0x40010A3")]
	private const string DropTranslationKey = "DROP";

	// Token: 0x040010A4 RID: 4260
	[Token(Token = "0x40010A4")]
	private const string CantCarryAnyMoreTranslationKey = "TUTORIAL_CANT_CARRY_ANY_MORE";

	// Token: 0x040010A5 RID: 4261
	[Token(Token = "0x40010A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly CultureInfo _cultureInfo;

	// Token: 0x040010A6 RID: 4262
	[Token(Token = "0x40010A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private PauseMenu _pauseMenuComponent;

	// Token: 0x040010A7 RID: 4263
	[Token(Token = "0x40010A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Header("Survival Hud")]
	public GameObject StomachOutline;

	// Token: 0x040010A8 RID: 4264
	[Token(Token = "0x40010A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Image Stomach;

	// Token: 0x040010A9 RID: 4265
	[Token(Token = "0x40010A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject ThirstOutline;

	// Token: 0x040010AA RID: 4266
	[Token(Token = "0x40010AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Image Hydration;

	// Token: 0x040010AB RID: 4267
	[Token(Token = "0x40010AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Image HealthBar;

	// Token: 0x040010AC RID: 4268
	[Token(Token = "0x40010AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Image HealthBarTarget;

	// Token: 0x040010AD RID: 4269
	[Token(Token = "0x40010AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Image StaminaBar;

	// Token: 0x040010AE RID: 4270
	[Token(Token = "0x40010AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Image EnergyBar;

	// Token: 0x040010AF RID: 4271
	[Token(Token = "0x40010AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject EnergyFlash;

	// Token: 0x040010B0 RID: 4272
	[Token(Token = "0x40010B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject HealthBarOutline;

	// Token: 0x040010B1 RID: 4273
	[Token(Token = "0x40010B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject StaminaBarOutline;

	// Token: 0x040010B2 RID: 4274
	[Token(Token = "0x40010B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject EnergyBarOutline;

	// Token: 0x040010B3 RID: 4275
	[Token(Token = "0x40010B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[Space(15f)]
	public UIGrid Grid;

	// Token: 0x040010B4 RID: 4276
	[Token(Token = "0x40010B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[Header("Multiplayer")]
	public ChatBox Chatbox;

	// Token: 0x040010B5 RID: 4277
	[Token(Token = "0x40010B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public UILabel MpRespawnLabel;

	// Token: 0x040010B6 RID: 4278
	[Token(Token = "0x40010B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public UISprite MpRespawnMaxTimer;

	// Token: 0x040010B7 RID: 4279
	[Token(Token = "0x40010B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[Header("Icons")]
	public GameObject EyeIcon;

	// Token: 0x040010B8 RID: 4280
	[Token(Token = "0x40010B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public UISprite EyeIconFill1;

	// Token: 0x040010B9 RID: 4281
	[Token(Token = "0x40010B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public UISprite EyeIconFill2;

	// Token: 0x040010BA RID: 4282
	[Token(Token = "0x40010BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public RoundStepProgressBarWidget RepairIcon;

	// Token: 0x040010BB RID: 4283
	[Token(Token = "0x40010BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public RoundStepProgressBarWidget RepairLogIcon;

	// Token: 0x040010BC RID: 4284
	[Token(Token = "0x40010BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public GameObject RepairMissingToolIcon;

	// Token: 0x040010BD RID: 4285
	[Token(Token = "0x40010BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public UILabel MpEndCrashLabel;

	// Token: 0x040010BE RID: 4286
	[Token(Token = "0x40010BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public GameObject RewindCamcorderIcon;

	// Token: 0x040010BF RID: 4287
	[Token(Token = "0x40010BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public GameObject LoadingCavesInfo;

	// Token: 0x040010C0 RID: 4288
	[Token(Token = "0x40010C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public UISprite LoadingCavesFill;

	// Token: 0x040010C1 RID: 4289
	[Token(Token = "0x40010C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[Space(15f)]
	public GameObject DelayedActionIcon;

	// Token: 0x040010C2 RID: 4290
	[Token(Token = "0x40010C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	[Header("Construction")]
	public GameObject AddIcon;

	// Token: 0x040010C3 RID: 4291
	[Token(Token = "0x40010C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public Color BuildingIngredientOwned;

	// Token: 0x040010C4 RID: 4292
	[Token(Token = "0x40010C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public Color BuildingIngredientMissing;

	// Token: 0x040010C5 RID: 4293
	[Token(Token = "0x40010C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	[Header("Cameras")]
	public GameObject GuiCam;

	// Token: 0x040010C6 RID: 4294
	[Token(Token = "0x40010C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public HudGui.LoadingScreen Loading;

	// Token: 0x040010C7 RID: 4295
	[Token(Token = "0x40010C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public Camera GuiCamC;

	// Token: 0x040010C8 RID: 4296
	[Token(Token = "0x40010C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public Camera VRGuiCamC;

	// Token: 0x040010C9 RID: 4297
	[Token(Token = "0x40010C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public Camera ActionIconCams;

	// Token: 0x040010CA RID: 4298
	[Token(Token = "0x40010CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public GameObject SaveSlotSelectionScreen;

	// Token: 0x040010CB RID: 4299
	[Token(Token = "0x40010CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public UILabel PauseMenuCoordsLabel;

	// Token: 0x040010CC RID: 4300
	[Token(Token = "0x40010CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public Camera VRTutorialCam;

	// Token: 0x040010CD RID: 4301
	[Token(Token = "0x40010CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public Camera VRIconCam;

	// Token: 0x040010CE RID: 4302
	[Token(Token = "0x40010CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public Transform _taskMessagesContainer;

	// Token: 0x040010CF RID: 4303
	[Token(Token = "0x40010CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	[SerializeField]
	private PlayerTutorials _tutorials;

	// Token: 0x040010D0 RID: 4304
	[Token(Token = "0x40010D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	[Header("Story/tasks")]
	public GameObject _todoListMessageView;

	// Token: 0x040010D1 RID: 4305
	[Token(Token = "0x40010D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	[Header("Mods")]
	public HudGui.ModTimerView ModTimer;

	// Token: 0x040010D2 RID: 4306
	[Token(Token = "0x40010D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	[Header("Gizmos")]
	public LineRenderer RangedWeaponTrajectory;

	// Token: 0x040010D3 RID: 4307
	[Token(Token = "0x40010D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public GameObject RangedWeaponHitTarget;

	// Token: 0x040010D4 RID: 4308
	[Token(Token = "0x40010D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public GameObject RangedWeaponHitGroundTarget;

	// Token: 0x040010D5 RID: 4309
	[Token(Token = "0x40010D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public Transform MouseSprite;

	// Token: 0x040010D6 RID: 4310
	[Token(Token = "0x40010D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public Transform NewMouseSprite;

	// Token: 0x040010D7 RID: 4311
	[Token(Token = "0x40010D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public RawImage MouseSpriteInventoryInner;

	// Token: 0x040010D8 RID: 4312
	[Token(Token = "0x40010D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public RawImage MouseSpriteInventoryOuter;

	// Token: 0x040010D9 RID: 4313
	[Token(Token = "0x40010D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public RawImage MouseSpriteInventoryArrow;

	// Token: 0x040010DA RID: 4314
	[Token(Token = "0x40010DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	[SerializeField]
	[Space(15f)]
	private GameObject _cantCarryItemView;

	// Token: 0x040010DB RID: 4315
	[Token(Token = "0x40010DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	[SerializeField]
	private GameObject _gotItemView;

	// Token: 0x040010DC RID: 4316
	[Token(Token = "0x40010DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	[SerializeField]
	private GameObject _requiredItemView;

	// Token: 0x040010DD RID: 4317
	[Token(Token = "0x40010DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	[SerializeField]
	private GameObject _generalMessageView;

	// Token: 0x040010DE RID: 4318
	[Token(Token = "0x40010DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	[Header("VR")]
	public UILabel FpsLabel;

	// Token: 0x040010DF RID: 4319
	[Token(Token = "0x40010DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	public UIWidget HealthHudWidget;

	// Token: 0x040010E0 RID: 4320
	[Token(Token = "0x40010E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private readonly Dictionary<int, HudGui.TimedGameObject> _cantCarryItemViewGOs;

	// Token: 0x040010E1 RID: 4321
	[Token(Token = "0x40010E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private readonly Dictionary<int, HudGui.TimedGameObject> _gotItemViewGOs;

	// Token: 0x040010E2 RID: 4322
	[Token(Token = "0x40010E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private readonly Dictionary<int, HudGui.TimedGameObject> _ingredientItemCountViewGOs;

	// Token: 0x040010E3 RID: 4323
	[Token(Token = "0x40010E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private readonly Queue<HudGui.TimedGameObject> _tgoPool;

	// Token: 0x040010E4 RID: 4324
	[Token(Token = "0x40010E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	private readonly List<HudGui.TimedGameObject> _generalMessages;

	// Token: 0x040010E5 RID: 4325
	[Token(Token = "0x40010E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	private float _nextBuildMissionDisplay;

	// Token: 0x040010E6 RID: 4326
	[Token(Token = "0x40010E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
	private float _nextItemInfoDisplay;

	// Token: 0x040010E7 RID: 4327
	[Token(Token = "0x40010E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	private ItemInstance _nextItemInstance;

	// Token: 0x040010E8 RID: 4328
	[Token(Token = "0x40010E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	private bool _nextItemInfoIsCraft;

	// Token: 0x040010E9 RID: 4329
	[Token(Token = "0x40010E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
	private int _nextItemInfoViewCounter;

	// Token: 0x040010EA RID: 4330
	[Token(Token = "0x40010EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	private float _nextQuickInfoDisplay;

	// Token: 0x040010EB RID: 4331
	[Token(Token = "0x40010EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x274")]
	private float _nextRecipeListDisplay;

	// Token: 0x040010EC RID: 4332
	[Token(Token = "0x40010EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	private float _fps;

	// Token: 0x040010EE RID: 4334
	[Token(Token = "0x40010EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	[SerializeField]
	private List<RectTransform> _cutsceneModeObjectsToDisable;

	// Token: 0x040010EF RID: 4335
	[Token(Token = "0x40010EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	[SerializeField]
	private List<RectTransform> _cutsceneModeObjectsToEnable;

	// Token: 0x040010F0 RID: 4336
	[Token(Token = "0x40010F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	[SerializeField]
	private float _delayedDisabledNullItemInstance;

	// Token: 0x040010F1 RID: 4337
	[Token(Token = "0x40010F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	[SerializeField]
	private GameObject _sleepingMultiplayerNotification;

	// Token: 0x040010F2 RID: 4338
	[Token(Token = "0x40010F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	[SerializeField]
	private TextMeshProUGUI _playersWaitingToSleep;

	// Token: 0x040010F3 RID: 4339
	[Token(Token = "0x40010F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	[SerializeField]
	private GameObject _networkInteractionNotification;

	// Token: 0x040010F4 RID: 4340
	[Token(Token = "0x40010F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	[SerializeField]
	private TextMeshProUGUI _networkInteractionWaiting;

	// Token: 0x040010F5 RID: 4341
	[Token(Token = "0x40010F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	private float _lastTimeItemInstanceWasSet;

	// Token: 0x040010F6 RID: 4342
	[Token(Token = "0x40010F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C4")]
	private float _previousTimescale;

	// Token: 0x040010F7 RID: 4343
	[Token(Token = "0x40010F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	private CustomPassVolume _blurUiPass;

	// Token: 0x040010F8 RID: 4344
	[Token(Token = "0x40010F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	private int _screenResolutionHash;

	// Token: 0x040010F9 RID: 4345
	[Token(Token = "0x40010F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	private Coroutine _slowTimeToZeroWorker;

	// Token: 0x040010FA RID: 4346
	[Token(Token = "0x40010FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static HudGui _instance;

	// Token: 0x040010FB RID: 4347
	[Token(Token = "0x40010FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	[SerializeField]
	private float _maxWeaponDamage;

	// Token: 0x040010FC RID: 4348
	[Token(Token = "0x40010FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	public HudGui.InventoryItemInfoView _inventoryItemInfoView;

	// Token: 0x040010FD RID: 4349
	[Token(Token = "0x40010FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	public GameObject ClickToRemoveInfo;

	// Token: 0x040010FE RID: 4350
	[Token(Token = "0x40010FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	public GameObject ClickToEquipInfo;

	// Token: 0x040010FF RID: 4351
	[Token(Token = "0x40010FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	public RectTransform _availableRecipesView;

	// Token: 0x04001100 RID: 4352
	[Token(Token = "0x4001100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
	[SerializeField]
	private List<CraftingRecipeView> _craftingRecipeViews;

	// Token: 0x04001101 RID: 4353
	[Token(Token = "0x4001101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
	[SerializeField]
	private GameObject _recipeListDots;

	// Token: 0x04001102 RID: 4354
	[Token(Token = "0x4001102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	[SerializeField]
	private int _maxCraftingRecipeListCount;

	// Token: 0x04001103 RID: 4355
	[Token(Token = "0x4001103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	[SerializeField]
	private ItemInstance _hoveredItemInstance;

	// Token: 0x04001104 RID: 4356
	[Token(Token = "0x4001104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	public HudGui.QuickSelectItemInfoView _quickSelectItemInfoView;

	// Token: 0x04001105 RID: 4357
	[Token(Token = "0x4001105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	public HudGui.ToolTipInfoView _toolTipInfoView;

	// Token: 0x02000288 RID: 648
	[Token(Token = "0x2000288")]
	private class TimedGameObject
	{
		// Token: 0x06001166 RID: 4454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001166")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public TimedGameObject()
		{
		}

		// Token: 0x04001106 RID: 4358
		[Token(Token = "0x4001106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int _amount;

		// Token: 0x04001107 RID: 4359
		[Token(Token = "0x4001107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float _endTime;

		// Token: 0x04001108 RID: 4360
		[Token(Token = "0x4001108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject _GO;

		// Token: 0x04001109 RID: 4361
		[Token(Token = "0x4001109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int _itemId;

		// Token: 0x0400110A RID: 4362
		[Token(Token = "0x400110A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI _label;
	}

	// Token: 0x02000289 RID: 649
	[Token(Token = "0x2000289")]
	[Serializable]
	public class ModTimerView : IModTimerView
	{
		// Token: 0x06001167 RID: 4455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001167")]
		[Address(RVA = "0x3752D30", Offset = "0x3751330", VA = "0x183752D30", Slot = "7")]
		public void Toggle(bool onOff)
		{
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001168")]
		[Address(RVA = "0x3752E00", Offset = "0x3751400", VA = "0x183752E00", Slot = "6")]
		public void SetTitle(bool onOff, [Optional] string text)
		{
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001169")]
		[Address(RVA = "0x3752F90", Offset = "0x3751590", VA = "0x183752F90", Slot = "5")]
		public void SetTimer(bool onOff, [Optional] string text)
		{
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600116A")]
		[Address(RVA = "0x3753120", Offset = "0x3751720", VA = "0x183753120", Slot = "4")]
		public void SetSubtitle(bool onOff, [Optional] string text)
		{
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600116B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ModTimerView()
		{
		}

		// Token: 0x0400110B RID: 4363
		[Token(Token = "0x400110B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject _root;

		// Token: 0x0400110C RID: 4364
		[Token(Token = "0x400110C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UILabel _title;

		// Token: 0x0400110D RID: 4365
		[Token(Token = "0x400110D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UILabel _timer;

		// Token: 0x0400110E RID: 4366
		[Token(Token = "0x400110E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UILabel _subtitle;
	}

	// Token: 0x0200028A RID: 650
	[Token(Token = "0x200028A")]
	[Serializable]
	public class LoadingScreen
	{
		// Token: 0x0600116C RID: 4460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600116C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public LoadingScreen()
		{
		}

		// Token: 0x0400110F RID: 4367
		[Token(Token = "0x400110F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject _cam;

		// Token: 0x04001110 RID: 4368
		[Token(Token = "0x4001110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject _message;
	}

	// Token: 0x0200028B RID: 651
	[Token(Token = "0x200028B")]
	[Serializable]
	public class InventoryItemInfoView
	{
		// Token: 0x0600116D RID: 4461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600116D")]
		[Address(RVA = "0x37532B0", Offset = "0x37518B0", VA = "0x1837532B0")]
		public void ShowHotKey(bool showHotKey, int index)
		{
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600116E")]
		[Address(RVA = "0x37536E0", Offset = "0x3751CE0", VA = "0x1837536E0")]
		public InventoryItemInfoView()
		{
		}

		// Token: 0x04001111 RID: 4369
		[Token(Token = "0x4001111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject _root;

		// Token: 0x04001112 RID: 4370
		[Token(Token = "0x4001112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RawImage _icon;

		// Token: 0x04001113 RID: 4371
		[Token(Token = "0x4001113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image _inQuickSelectIcon;

		// Token: 0x04001114 RID: 4372
		[Token(Token = "0x4001114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool _isOnCraftMat;

		// Token: 0x04001115 RID: 4373
		[Token(Token = "0x4001115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI _title;

		// Token: 0x04001116 RID: 4374
		[Token(Token = "0x4001116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI _effect;

		// Token: 0x04001117 RID: 4375
		[Token(Token = "0x4001117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI _description;

		// Token: 0x04001118 RID: 4376
		[Token(Token = "0x4001118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ItemAmountLabel _amountText;

		// Token: 0x04001119 RID: 4377
		[Token(Token = "0x4001119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject _clothingStatsGroup;

		// Token: 0x0400111A RID: 4378
		[Token(Token = "0x400111A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public StatusEffectBarView _thermalRatingStatBarView;

		// Token: 0x0400111B RID: 4379
		[Token(Token = "0x400111B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public StatusEffectBarView _comfortRatingStatBarView;

		// Token: 0x0400111C RID: 4380
		[Token(Token = "0x400111C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public StatusEffectBarView _waterResistRatingStatBarView;

		// Token: 0x0400111D RID: 4381
		[Token(Token = "0x400111D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject _weaponStatsGroup;

		// Token: 0x0400111E RID: 4382
		[Token(Token = "0x400111E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public StatusEffectBarView _speedRatingStatBarView;

		// Token: 0x0400111F RID: 4383
		[Token(Token = "0x400111F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public StatusEffectBarView _damageRatingStatBarView;

		// Token: 0x04001120 RID: 4384
		[Token(Token = "0x4001120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public StatusEffectBarView _blockRatingStatBarView;

		// Token: 0x04001121 RID: 4385
		[Token(Token = "0x4001121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public GameObject _containerVolumeGroup;

		// Token: 0x04001122 RID: 4386
		[Token(Token = "0x4001122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public StatusEffectBarView _containerVolumeBarView;

		// Token: 0x04001123 RID: 4387
		[Token(Token = "0x4001123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public GameObject _leftClickIcon;

		// Token: 0x04001124 RID: 4388
		[Token(Token = "0x4001124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public GameObject _rightClickIcon;

		// Token: 0x04001125 RID: 4389
		[Token(Token = "0x4001125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public TextMeshProUGUI _leftClickText;

		// Token: 0x04001126 RID: 4390
		[Token(Token = "0x4001126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public TextMeshProUGUI _rightClickText;

		// Token: 0x04001127 RID: 4391
		[Token(Token = "0x4001127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public GameObject _hotkeyGroup;

		// Token: 0x04001128 RID: 4392
		[Token(Token = "0x4001128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public GameObject _emptyHotkeyGroup;

		// Token: 0x04001129 RID: 4393
		[Token(Token = "0x4001129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public DynamicInputIcon _hotkeyIcon;

		// Token: 0x0400112A RID: 4394
		[Token(Token = "0x400112A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float _mouseFollowSpeed;
	}

	// Token: 0x0200028C RID: 652
	[Token(Token = "0x200028C")]
	[Serializable]
	public class QuickSelectItemInfoView
	{
		// Token: 0x0600116F RID: 4463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600116F")]
		[Address(RVA = "0x37536F0", Offset = "0x3751CF0", VA = "0x1837536F0")]
		public QuickSelectItemInfoView()
		{
		}

		// Token: 0x0400112B RID: 4395
		[Token(Token = "0x400112B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public int _itemId;

		// Token: 0x0400112C RID: 4396
		[Token(Token = "0x400112C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject _root;

		// Token: 0x0400112D RID: 4397
		[Token(Token = "0x400112D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RawImage _icon;

		// Token: 0x0400112E RID: 4398
		[Token(Token = "0x400112E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ItemAmountLabel _amountText;

		// Token: 0x0400112F RID: 4399
		[Token(Token = "0x400112F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject _leftClickIcon;

		// Token: 0x04001130 RID: 4400
		[Token(Token = "0x4001130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI _leftClickText;

		// Token: 0x04001131 RID: 4401
		[Token(Token = "0x4001131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float _mouseFollowSpeed;
	}

	// Token: 0x0200028D RID: 653
	[Token(Token = "0x200028D")]
	[Serializable]
	public class ToolTipInfoView
	{
		// Token: 0x06001170 RID: 4464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001170")]
		[Address(RVA = "0x3753700", Offset = "0x3751D00", VA = "0x183753700")]
		public ToolTipInfoView()
		{
		}

		// Token: 0x04001132 RID: 4402
		[Token(Token = "0x4001132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject _root;

		// Token: 0x04001133 RID: 4403
		[Token(Token = "0x4001133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RawImage _icon;

		// Token: 0x04001134 RID: 4404
		[Token(Token = "0x4001134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject _leftClickIcon;

		// Token: 0x04001135 RID: 4405
		[Token(Token = "0x4001135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI _leftClickText;

		// Token: 0x04001136 RID: 4406
		[Token(Token = "0x4001136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float _mouseFollowSpeed;
	}
}
