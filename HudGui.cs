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

// Token: 0x02000292 RID: 658
[Token(Token = "0x2000292")]
public class HudGui : MonoBehaviour
{
	// Token: 0x060010DF RID: 4319 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010DF")]
	[Address(RVA = "0x2FAFA10", Offset = "0x2FAEA10", VA = "0x182FAFA10")]
	public void ShowRecipeInfo(ItemInstance itemInstance)
	{
	}

	// Token: 0x060010E0 RID: 4320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010E0")]
	[Address(RVA = "0x2FAD8B0", Offset = "0x2FAC8B0", VA = "0x182FAD8B0")]
	public void HideRecipeInfo()
	{
	}

	// Token: 0x060010E1 RID: 4321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010E1")]
	[Address(RVA = "0x2FAB2B0", Offset = "0x2FAA2B0", VA = "0x182FAB2B0")]
	private void CookingUpdate()
	{
	}

	// Token: 0x060010E2 RID: 4322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010E2")]
	[Address(RVA = "0x2FB2ED0", Offset = "0x2FB1ED0", VA = "0x182FB2ED0")]
	private void UpdateCookingRecipeTitleAndImage(ItemInstance itemInstance)
	{
	}

	// Token: 0x170001F7 RID: 503
	// (get) Token: 0x060010E3 RID: 4323 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F7")]
	public static PlayerTutorials Tutorials
	{
		[Token(Token = "0x60010E3")]
		[Address(RVA = "0x2FB46B0", Offset = "0x2FB36B0", VA = "0x182FB46B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001F8 RID: 504
	// (get) Token: 0x060010E4 RID: 4324 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F8")]
	public static HudGui Instance
	{
		[Token(Token = "0x60010E4")]
		[Address(RVA = "0x2FB45B0", Offset = "0x2FB35B0", VA = "0x182FB45B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001F9 RID: 505
	// (get) Token: 0x060010E5 RID: 4325 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060010E6 RID: 4326 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001F9")]
	public MonoBehaviour DelayedActionIconController
	{
		[Token(Token = "0x60010E5")]
		[Address(RVA = "0x8C5E60", Offset = "0x8C4E60", VA = "0x1808C5E60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60010E6")]
		[Address(RVA = "0x8C6640", Offset = "0x8C5640", VA = "0x1808C6640")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x170001FA RID: 506
	// (get) Token: 0x060010E7 RID: 4327 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001FA")]
	private PlayerInventory Inventory
	{
		[Token(Token = "0x60010E7")]
		[Address(RVA = "0x2868DC0", Offset = "0x2867DC0", VA = "0x182868DC0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060010E8 RID: 4328 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010E8")]
	[Address(RVA = "0x2FAA9D0", Offset = "0x2FA99D0", VA = "0x182FAA9D0")]
	private void Awake()
	{
	}

	// Token: 0x060010E9 RID: 4329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010E9")]
	[Address(RVA = "0x2FB09A0", Offset = "0x2FAF9A0", VA = "0x182FB09A0")]
	private void Start()
	{
	}

	// Token: 0x060010EA RID: 4330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010EA")]
	[Address(RVA = "0x2FAE270", Offset = "0x2FAD270", VA = "0x182FAE270")]
	private void OnDestroy()
	{
	}

	// Token: 0x060010EB RID: 4331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010EB")]
	[Address(RVA = "0x2FB0E60", Offset = "0x2FAFE60", VA = "0x182FB0E60")]
	private void SubscribeCallbacks()
	{
	}

	// Token: 0x060010EC RID: 4332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010EC")]
	[Address(RVA = "0x2FB2290", Offset = "0x2FB1290", VA = "0x182FB2290")]
	private void UnsubscribeCallbacks()
	{
	}

	// Token: 0x060010ED RID: 4333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010ED")]
	[Address(RVA = "0x2FAE100", Offset = "0x2FAD100", VA = "0x182FAE100")]
	private void OnAfterSave(bool wasAutosave)
	{
	}

	// Token: 0x060010EE RID: 4334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010EE")]
	[Address(RVA = "0x2FADF90", Offset = "0x2FACF90", VA = "0x182FADF90")]
	private void OnAfterLoad()
	{
	}

	// Token: 0x060010EF RID: 4335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010EF")]
	[Address(RVA = "0x2FADF10", Offset = "0x2FACF10", VA = "0x182FADF10")]
	private void OnAdrenaline(object o)
	{
	}

	// Token: 0x060010F0 RID: 4336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F0")]
	[Address(RVA = "0x2FAE3D0", Offset = "0x2FAD3D0", VA = "0x182FAE3D0")]
	private void OnPlayerResetFromHeal(object o)
	{
	}

	// Token: 0x060010F1 RID: 4337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F1")]
	[Address(RVA = "0x2FAE360", Offset = "0x2FAD360", VA = "0x182FAE360")]
	public void OnLoadedFromRespawn(object o)
	{
	}

	// Token: 0x060010F2 RID: 4338 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010F2")]
	[Address(RVA = "0x2FACA40", Offset = "0x2FABA40", VA = "0x182FACA40")]
	private IEnumerator ForceBlackScreen(float duration)
	{
		return null;
	}

	// Token: 0x060010F3 RID: 4339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F3")]
	[Address(RVA = "0x2FB3EC0", Offset = "0x2FB2EC0", VA = "0x182FB3EC0")]
	private void Update()
	{
	}

	// Token: 0x060010F4 RID: 4340 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010F4")]
	[Address(RVA = "0x2FB4240", Offset = "0x2FB3240", VA = "0x182FB4240")]
	private IEnumerator WaitForGameStart()
	{
		return null;
	}

	// Token: 0x060010F5 RID: 4341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F5")]
	[Address(RVA = "0x2FADA70", Offset = "0x2FACA70", VA = "0x182FADA70")]
	private static void InitPrefabPool(Transform prefab)
	{
	}

	// Token: 0x060010F6 RID: 4342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F6")]
	[Address(RVA = "0x2FAD8E0", Offset = "0x2FAC8E0", VA = "0x182FAD8E0")]
	private static void InitPrefabPoolLarge(Transform prefab)
	{
	}

	// Token: 0x060010F7 RID: 4343 RVA: 0x000060C0 File Offset: 0x000042C0
	[Token(Token = "0x60010F7")]
	[Address(RVA = "0x2CE7B00", Offset = "0x2CE6B00", VA = "0x182CE7B00")]
	private int GetScreenResolutionHash()
	{
		return default(int);
	}

	// Token: 0x060010F8 RID: 4344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F8")]
	[Address(RVA = "0x2FAADF0", Offset = "0x2FA9DF0", VA = "0x182FAADF0")]
	private void CheckTimedGOs(List<HudGui.TimedGameObject> timedGameObjects)
	{
	}

	// Token: 0x060010F9 RID: 4345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F9")]
	[Address(RVA = "0x2FAACD0", Offset = "0x2FA9CD0", VA = "0x182FAACD0")]
	private void CheckTimedGOs(Dictionary<int, HudGui.TimedGameObject> gos)
	{
	}

	// Token: 0x060010FA RID: 4346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010FA")]
	[Address(RVA = "0x2FAAEE0", Offset = "0x2FA9EE0", VA = "0x182FAAEE0")]
	private void CheckTimedGameObject(HudGui.TimedGameObject timedGameObject, out bool isDone)
	{
	}

	// Token: 0x060010FB RID: 4347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010FB")]
	[Address(RVA = "0x2FAF230", Offset = "0x2FAE230", VA = "0x182FAF230")]
	public void SetPauseMenuActive(bool active)
	{
	}

	// Token: 0x060010FC RID: 4348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010FC")]
	[Address(RVA = "0x2FB0E20", Offset = "0x2FAFE20", VA = "0x182FB0E20")]
	private void StopSlowTimeToZeroWorker()
	{
	}

	// Token: 0x060010FD RID: 4349 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010FD")]
	[Address(RVA = "0x2FB0850", Offset = "0x2FAF850", VA = "0x182FB0850")]
	private IEnumerator SlowTimeToZero()
	{
		return null;
	}

	// Token: 0x060010FE RID: 4350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010FE")]
	[Address(RVA = "0x2FAF190", Offset = "0x2FAE190", VA = "0x182FAF190")]
	public void SetDelayedIconController(MonoBehaviour mb)
	{
	}

	// Token: 0x060010FF RID: 4351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010FF")]
	[Address(RVA = "0x2FB21A0", Offset = "0x2FB11A0", VA = "0x182FB21A0")]
	public void UnsetDelayedIconController(MonoBehaviour mb)
	{
	}

	// Token: 0x06001100 RID: 4352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001100")]
	[Address(RVA = "0x2FAAB60", Offset = "0x2FA9B60", VA = "0x182FAAB60")]
	public void CheckDelayedActionController()
	{
	}

	// Token: 0x06001101 RID: 4353 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001101")]
	[Address(RVA = "0x2FAD480", Offset = "0x2FAC480", VA = "0x182FAD480")]
	public static string GetTutorialTranslation(string translationKey)
	{
		return null;
	}

	// Token: 0x06001102 RID: 4354 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001102")]
	[Address(RVA = "0x2FACBF0", Offset = "0x2FABBF0", VA = "0x182FACBF0")]
	public static string GetItemsTranslation(string translationKey)
	{
		return null;
	}

	// Token: 0x06001103 RID: 4355 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001103")]
	[Address(RVA = "0x2FAD070", Offset = "0x2FAC070", VA = "0x182FAD070")]
	private string GetMeatItemName(ItemUiData uiData, bool plural, bool caps)
	{
		return null;
	}

	// Token: 0x06001104 RID: 4356 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001104")]
	[Address(RVA = "0x2FACD40", Offset = "0x2FABD40", VA = "0x182FACD40")]
	private static string GetLeftClickActionName(ItemData itemData)
	{
		return null;
	}

	// Token: 0x06001105 RID: 4357 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001105")]
	[Address(RVA = "0x2FAD130", Offset = "0x2FAC130", VA = "0x182FAD130")]
	private string GetRightClickActionName(ItemData itemData)
	{
		return null;
	}

	// Token: 0x06001106 RID: 4358 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001106")]
	[Address(RVA = "0x2FB08C0", Offset = "0x2FAF8C0", VA = "0x182FB08C0")]
	private HudGui.TimedGameObject SpawnTimedGameObject(int itemId, int amount, float endTime, GameObject go, TextMeshProUGUI label)
	{
		return null;
	}

	// Token: 0x06001107 RID: 4359 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001107")]
	[Address(RVA = "0x2FB10B0", Offset = "0x2FB00B0", VA = "0x182FB10B0")]
	public void ToggleFullCapacityHud(int itemId)
	{
	}

	// Token: 0x06001108 RID: 4360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001108")]
	[Address(RVA = "0x2FB17F0", Offset = "0x2FB07F0", VA = "0x182FB17F0")]
	public void ToggleGotItemHud(ItemInstance itemInstance, int amount)
	{
	}

	// Token: 0x06001109 RID: 4361 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001109")]
	[Address(RVA = "0x2FAB510", Offset = "0x2FAA510", VA = "0x182FAB510")]
	public void DisplayGeneralMessage(string message, float duration = 3f, [Optional] ItemUiData uiData)
	{
	}

	// Token: 0x0600110A RID: 4362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110A")]
	[Address(RVA = "0x2FAB160", Offset = "0x2FAA160", VA = "0x182FAB160")]
	public void ClearAllRequiredCollectionCounts()
	{
	}

	// Token: 0x0600110B RID: 4363 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110B")]
	[Address(RVA = "0x2FABB10", Offset = "0x2FAAB10", VA = "0x182FABB10")]
	public void DisplayRequiredCollectionCountForItem(ItemData itemData, int totalAmountNeeded, int amountInInventory)
	{
	}

	// Token: 0x0600110C RID: 4364 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600110C")]
	[Address(RVA = "0x2FAD5D0", Offset = "0x2FAC5D0", VA = "0x182FAD5D0")]
	private static string GotItemText(ItemInstance itemInstance, int amount)
	{
		return null;
	}

	// Token: 0x0600110D RID: 4365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110D")]
	[Address(RVA = "0x2FAEF60", Offset = "0x2FADF60", VA = "0x182FAEF60")]
	public void SetCutsceneMode(bool enable)
	{
	}

	// Token: 0x0600110E RID: 4366 RVA: 0x000060D8 File Offset: 0x000042D8
	[Token(Token = "0x600110E")]
	[Address(RVA = "0x2FACAA0", Offset = "0x2FABAA0", VA = "0x182FACAA0")]
	private static Vector2 GetContextWindowScreenPosition()
	{
		return default(Vector2);
	}

	// Token: 0x0600110F RID: 4367 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110F")]
	[Address(RVA = "0x2FAC7E0", Offset = "0x2FAB7E0", VA = "0x182FAC7E0")]
	public void EnableMainCameraBlurUI(bool enable)
	{
	}

	// Token: 0x06001110 RID: 4368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001110")]
	[Address(RVA = "0x2FAFAD0", Offset = "0x2FAEAD0", VA = "0x182FAFAD0")]
	public void ShowSleepNotification(bool show, int playersWaiting = 0, int totalPlayerCount = 0)
	{
	}

	// Token: 0x06001111 RID: 4369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001111")]
	[Address(RVA = "0x2FAC6F0", Offset = "0x2FAB6F0", VA = "0x182FAC6F0")]
	private void EnableCursor(bool enabled)
	{
	}

	// Token: 0x06001112 RID: 4370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001112")]
	[Address(RVA = "0x2FAED30", Offset = "0x2FADD30", VA = "0x182FAED30")]
	private void SetCursorType(InputSystem.SoftwareCursor.Types type)
	{
	}

	// Token: 0x06001113 RID: 4371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001113")]
	[Address(RVA = "0x2FAEB90", Offset = "0x2FADB90", VA = "0x182FAEB90")]
	private void SetCursorScreenPosition(Vector3 screenPosition)
	{
	}

	// Token: 0x06001114 RID: 4372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001114")]
	[Address(RVA = "0x2FAF4A0", Offset = "0x2FAE4A0", VA = "0x182FAF4A0")]
	public void ShowInventoryItemInfo(ItemInstance itemInstance, bool isOnCraftMat = false, int itemHotkeyIndex = -1)
	{
	}

	// Token: 0x06001115 RID: 4373 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001115")]
	[Address(RVA = "0x2FACBE0", Offset = "0x2FABBE0", VA = "0x182FACBE0")]
	public ItemInstance GetHoveredItemInstance()
	{
		return null;
	}

	// Token: 0x06001116 RID: 4374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001116")]
	[Address(RVA = "0x2FADC10", Offset = "0x2FACC10", VA = "0x182FADC10")]
	private void InventoryUpdate()
	{
	}

	// Token: 0x06001117 RID: 4375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001117")]
	[Address(RVA = "0x2FAB290", Offset = "0x2FAA290", VA = "0x182FAB290")]
	private void ClearHoveredItemInstance()
	{
	}

	// Token: 0x06001118 RID: 4376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001118")]
	[Address(RVA = "0x2FB39B0", Offset = "0x2FB29B0", VA = "0x182FB39B0")]
	private void UpdateTitleAndImage(ItemInstance itemInstance)
	{
	}

	// Token: 0x06001119 RID: 4377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001119")]
	[Address(RVA = "0x2FB2980", Offset = "0x2FB1980", VA = "0x182FB2980")]
	private void UpdateAmountDisplay(ItemInstance itemInstance, ItemAmountLabel itemAmountLabel)
	{
	}

	// Token: 0x0600111A RID: 4378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111A")]
	[Address(RVA = "0x2FB24E0", Offset = "0x2FB14E0", VA = "0x182FB24E0")]
	private void UpdateActionIcons(ItemInstance itemInstance)
	{
	}

	// Token: 0x0600111B RID: 4379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111B")]
	[Address(RVA = "0x2FB31D0", Offset = "0x2FB21D0", VA = "0x182FB31D0")]
	private void UpdateDescription(ItemInstance itemInstance)
	{
	}

	// Token: 0x0600111C RID: 4380 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600111C")]
	[Address(RVA = "0x2FAE9C0", Offset = "0x2FAD9C0", VA = "0x182FAE9C0")]
	private static string RecipeDisplayName(VolumeContainerItemInstanceModule module)
	{
		return null;
	}

	// Token: 0x0600111D RID: 4381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111D")]
	[Address(RVA = "0x2FB36A0", Offset = "0x2FB26A0", VA = "0x182FB36A0")]
	private void UpdateStats(ItemInstance itemInstance)
	{
	}

	// Token: 0x0600111E RID: 4382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111E")]
	[Address(RVA = "0x2FB3590", Offset = "0x2FB2590", VA = "0x182FB3590")]
	private void UpdateMeleeWeaponStats(ItemInstance itemInstance)
	{
	}

	// Token: 0x0600111F RID: 4383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111F")]
	[Address(RVA = "0x2FB2C70", Offset = "0x2FB1C70", VA = "0x182FB2C70")]
	private void UpdateClothingStats(ItemInstance itemInstance)
	{
	}

	// Token: 0x06001120 RID: 4384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001120")]
	[Address(RVA = "0x2FB2E10", Offset = "0x2FB1E10", VA = "0x182FB2E10")]
	private void UpdateContainerVolumeStats(ItemInstance itemInstance)
	{
	}

	// Token: 0x06001121 RID: 4385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001121")]
	[Address(RVA = "0x2FAFED0", Offset = "0x2FAEED0", VA = "0x182FAFED0")]
	public void ShowValidCraftingRecipes(bool enable, [Optional] IEnumerable<CraftingRecipe> recipes)
	{
	}

	// Token: 0x06001122 RID: 4386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001122")]
	[Address(RVA = "0x2FAE440", Offset = "0x2FAD440", VA = "0x182FAE440")]
	public void PlayerConnectionStateChanged(string playerName, Color playerColor, CoopUtils.PlayerConnectionState state)
	{
	}

	// Token: 0x06001123 RID: 4387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001123")]
	[Address(RVA = "0x2FAE6D0", Offset = "0x2FAD6D0", VA = "0x182FAE6D0")]
	private void QuickSelectUpdate()
	{
	}

	// Token: 0x06001124 RID: 4388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001124")]
	[Address(RVA = "0x2FAF7C0", Offset = "0x2FAE7C0", VA = "0x182FAF7C0")]
	public void ShowQuickSelectItemInfo(ItemInstance itemInstance)
	{
	}

	// Token: 0x06001125 RID: 4389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001125")]
	[Address(RVA = "0x2FB3BD0", Offset = "0x2FB2BD0", VA = "0x182FB3BD0")]
	private void UpdateTooltip()
	{
	}

	// Token: 0x06001126 RID: 4390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001126")]
	[Address(RVA = "0x2FAFBB0", Offset = "0x2FAEBB0", VA = "0x182FAFBB0")]
	public void ShowToolTipInfo(string toolTipTextKey)
	{
	}

	// Token: 0x06001127 RID: 4391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001127")]
	[Address(RVA = "0x2FB4340", Offset = "0x2FB3340", VA = "0x182FB4340")]
	public HudGui()
	{
	}

	// Token: 0x06001129 RID: 4393 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001129")]
	[Address(RVA = "0x2FB2080", Offset = "0x2FB1080", VA = "0x182FB2080")]
	[CompilerGenerated]
	internal static string <PlayerConnectionStateChanged>g__FloatNormalizedToHex|193_0(float value)
	{
		return null;
	}

	// Token: 0x04001066 RID: 4198
	[Token(Token = "0x4001066")]
	private const string EmptyRecipeKey = "EMPTY";

	// Token: 0x04001067 RID: 4199
	[Token(Token = "0x4001067")]
	private const string CookingLocalizationTableKey = "Cooking";

	// Token: 0x04001068 RID: 4200
	[Token(Token = "0x4001068")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private HudGui.CookingRecipeInfoView _cookingRecipeInfoView;

	// Token: 0x04001069 RID: 4201
	[Token(Token = "0x4001069")]
	private const string TutorialTableReferenceKey = "Tutorials";

	// Token: 0x0400106A RID: 4202
	[Token(Token = "0x400106A")]
	private const string ItemsTableReferenceKey = "Items";

	// Token: 0x0400106B RID: 4203
	[Token(Token = "0x400106B")]
	private const string ScreenPromptsTableReferenceKey = "ScreenPrompts";

	// Token: 0x0400106C RID: 4204
	[Token(Token = "0x400106C")]
	private const string UseTranslationKey = "USE";

	// Token: 0x0400106D RID: 4205
	[Token(Token = "0x400106D")]
	private const string EquipTranslationKey = "EQUIP";

	// Token: 0x0400106E RID: 4206
	[Token(Token = "0x400106E")]
	private const string PlayTranslationKey = "PLAY";

	// Token: 0x0400106F RID: 4207
	[Token(Token = "0x400106F")]
	private const string DrinkTranslationKey = "DRINK";

	// Token: 0x04001070 RID: 4208
	[Token(Token = "0x4001070")]
	private const string ReadTranslationKey = "READ";

	// Token: 0x04001071 RID: 4209
	[Token(Token = "0x4001071")]
	private const string TakeTranslationKey = "TAKE";

	// Token: 0x04001072 RID: 4210
	[Token(Token = "0x4001072")]
	private const string ChargeTranslationKey = "CHARGE";

	// Token: 0x04001073 RID: 4211
	[Token(Token = "0x4001073")]
	private const string WearTranslationKey = "WEAR";

	// Token: 0x04001074 RID: 4212
	[Token(Token = "0x4001074")]
	private const string EatTranslationKey = "EAT";

	// Token: 0x04001075 RID: 4213
	[Token(Token = "0x4001075")]
	private const string SelectTranslationKey = "SELECT";

	// Token: 0x04001076 RID: 4214
	[Token(Token = "0x4001076")]
	private const string RemoveTranslationKey = "REMOVE";

	// Token: 0x04001077 RID: 4215
	[Token(Token = "0x4001077")]
	private const string AddItemsTranslationKey = "ADDITEMS";

	// Token: 0x04001078 RID: 4216
	[Token(Token = "0x4001078")]
	private const string AddTranslationKey = "ADD";

	// Token: 0x04001079 RID: 4217
	[Token(Token = "0x4001079")]
	private const string CombineTranslationKey = "COMBINE";

	// Token: 0x0400107A RID: 4218
	[Token(Token = "0x400107A")]
	private const string OpenTranslationKey = "OPEN";

	// Token: 0x0400107B RID: 4219
	[Token(Token = "0x400107B")]
	private const string UnequipTranslationKey = "UNEQUIP";

	// Token: 0x0400107C RID: 4220
	[Token(Token = "0x400107C")]
	private const string DropTranslationKey = "DROP";

	// Token: 0x0400107D RID: 4221
	[Token(Token = "0x400107D")]
	private const string CantCarryAnyMoreTranslationKey = "TUTORIAL_CANT_CARRY_ANY_MORE";

	// Token: 0x0400107E RID: 4222
	[Token(Token = "0x400107E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly CultureInfo _cultureInfo;

	// Token: 0x0400107F RID: 4223
	[Token(Token = "0x400107F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private PauseMenu _pauseMenuComponent;

	// Token: 0x04001080 RID: 4224
	[Token(Token = "0x4001080")]
	[FieldOffset(Offset = "0x30")]
	[Header("Survival Hud")]
	public GameObject StomachOutline;

	// Token: 0x04001081 RID: 4225
	[Token(Token = "0x4001081")]
	[FieldOffset(Offset = "0x38")]
	public Image Stomach;

	// Token: 0x04001082 RID: 4226
	[Token(Token = "0x4001082")]
	[FieldOffset(Offset = "0x40")]
	public GameObject ThirstOutline;

	// Token: 0x04001083 RID: 4227
	[Token(Token = "0x4001083")]
	[FieldOffset(Offset = "0x48")]
	public Image Hydration;

	// Token: 0x04001084 RID: 4228
	[Token(Token = "0x4001084")]
	[FieldOffset(Offset = "0x50")]
	public Image HealthBar;

	// Token: 0x04001085 RID: 4229
	[Token(Token = "0x4001085")]
	[FieldOffset(Offset = "0x58")]
	public Image HealthBarTarget;

	// Token: 0x04001086 RID: 4230
	[Token(Token = "0x4001086")]
	[FieldOffset(Offset = "0x60")]
	public Image StaminaBar;

	// Token: 0x04001087 RID: 4231
	[Token(Token = "0x4001087")]
	[FieldOffset(Offset = "0x68")]
	public Image EnergyBar;

	// Token: 0x04001088 RID: 4232
	[Token(Token = "0x4001088")]
	[FieldOffset(Offset = "0x70")]
	public GameObject EnergyFlash;

	// Token: 0x04001089 RID: 4233
	[Token(Token = "0x4001089")]
	[FieldOffset(Offset = "0x78")]
	public GameObject HealthBarOutline;

	// Token: 0x0400108A RID: 4234
	[Token(Token = "0x400108A")]
	[FieldOffset(Offset = "0x80")]
	public GameObject StaminaBarOutline;

	// Token: 0x0400108B RID: 4235
	[Token(Token = "0x400108B")]
	[FieldOffset(Offset = "0x88")]
	public GameObject EnergyBarOutline;

	// Token: 0x0400108C RID: 4236
	[Token(Token = "0x400108C")]
	[FieldOffset(Offset = "0x90")]
	[Space(15f)]
	public UIGrid Grid;

	// Token: 0x0400108D RID: 4237
	[Token(Token = "0x400108D")]
	[FieldOffset(Offset = "0x98")]
	[Header("Multiplayer")]
	public ChatBox Chatbox;

	// Token: 0x0400108E RID: 4238
	[Token(Token = "0x400108E")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel MpRespawnLabel;

	// Token: 0x0400108F RID: 4239
	[Token(Token = "0x400108F")]
	[FieldOffset(Offset = "0xA8")]
	public UISprite MpRespawnMaxTimer;

	// Token: 0x04001090 RID: 4240
	[Token(Token = "0x4001090")]
	[FieldOffset(Offset = "0xB0")]
	[Header("Icons")]
	public GameObject EyeIcon;

	// Token: 0x04001091 RID: 4241
	[Token(Token = "0x4001091")]
	[FieldOffset(Offset = "0xB8")]
	public UISprite EyeIconFill1;

	// Token: 0x04001092 RID: 4242
	[Token(Token = "0x4001092")]
	[FieldOffset(Offset = "0xC0")]
	public UISprite EyeIconFill2;

	// Token: 0x04001093 RID: 4243
	[Token(Token = "0x4001093")]
	[FieldOffset(Offset = "0xC8")]
	public RoundStepProgressBarWidget RepairIcon;

	// Token: 0x04001094 RID: 4244
	[Token(Token = "0x4001094")]
	[FieldOffset(Offset = "0xD0")]
	public RoundStepProgressBarWidget RepairLogIcon;

	// Token: 0x04001095 RID: 4245
	[Token(Token = "0x4001095")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject RepairMissingToolIcon;

	// Token: 0x04001096 RID: 4246
	[Token(Token = "0x4001096")]
	[FieldOffset(Offset = "0xE0")]
	public UILabel MpEndCrashLabel;

	// Token: 0x04001097 RID: 4247
	[Token(Token = "0x4001097")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject RewindCamcorderIcon;

	// Token: 0x04001098 RID: 4248
	[Token(Token = "0x4001098")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject LoadingCavesInfo;

	// Token: 0x04001099 RID: 4249
	[Token(Token = "0x4001099")]
	[FieldOffset(Offset = "0xF8")]
	public UISprite LoadingCavesFill;

	// Token: 0x0400109A RID: 4250
	[Token(Token = "0x400109A")]
	[FieldOffset(Offset = "0x100")]
	[Space(15f)]
	public GameObject DelayedActionIcon;

	// Token: 0x0400109B RID: 4251
	[Token(Token = "0x400109B")]
	[FieldOffset(Offset = "0x108")]
	[Header("Construction")]
	public GameObject AddIcon;

	// Token: 0x0400109C RID: 4252
	[Token(Token = "0x400109C")]
	[FieldOffset(Offset = "0x110")]
	public Color BuildingIngredientOwned;

	// Token: 0x0400109D RID: 4253
	[Token(Token = "0x400109D")]
	[FieldOffset(Offset = "0x120")]
	public Color BuildingIngredientMissing;

	// Token: 0x0400109E RID: 4254
	[Token(Token = "0x400109E")]
	[FieldOffset(Offset = "0x130")]
	[Header("Cameras")]
	public GameObject GuiCam;

	// Token: 0x0400109F RID: 4255
	[Token(Token = "0x400109F")]
	[FieldOffset(Offset = "0x138")]
	public HudGui.LoadingScreen Loading;

	// Token: 0x040010A0 RID: 4256
	[Token(Token = "0x40010A0")]
	[FieldOffset(Offset = "0x140")]
	public Camera GuiCamC;

	// Token: 0x040010A1 RID: 4257
	[Token(Token = "0x40010A1")]
	[FieldOffset(Offset = "0x148")]
	public Camera VRGuiCamC;

	// Token: 0x040010A2 RID: 4258
	[Token(Token = "0x40010A2")]
	[FieldOffset(Offset = "0x150")]
	public Camera ActionIconCams;

	// Token: 0x040010A3 RID: 4259
	[Token(Token = "0x40010A3")]
	[FieldOffset(Offset = "0x158")]
	public GameObject SaveSlotSelectionScreen;

	// Token: 0x040010A4 RID: 4260
	[Token(Token = "0x40010A4")]
	[FieldOffset(Offset = "0x160")]
	public UILabel PauseMenuCoordsLabel;

	// Token: 0x040010A5 RID: 4261
	[Token(Token = "0x40010A5")]
	[FieldOffset(Offset = "0x168")]
	public Camera VRTutorialCam;

	// Token: 0x040010A6 RID: 4262
	[Token(Token = "0x40010A6")]
	[FieldOffset(Offset = "0x170")]
	public Camera VRIconCam;

	// Token: 0x040010A7 RID: 4263
	[Token(Token = "0x40010A7")]
	[FieldOffset(Offset = "0x178")]
	public Transform _taskMessagesContainer;

	// Token: 0x040010A8 RID: 4264
	[Token(Token = "0x40010A8")]
	[FieldOffset(Offset = "0x180")]
	[SerializeField]
	private PlayerTutorials _tutorials;

	// Token: 0x040010A9 RID: 4265
	[Token(Token = "0x40010A9")]
	[FieldOffset(Offset = "0x188")]
	[Header("Story/tasks")]
	public GameObject _todoListMessageView;

	// Token: 0x040010AA RID: 4266
	[Token(Token = "0x40010AA")]
	[FieldOffset(Offset = "0x190")]
	[Header("Mods")]
	public HudGui.ModTimerView ModTimer;

	// Token: 0x040010AB RID: 4267
	[Token(Token = "0x40010AB")]
	[FieldOffset(Offset = "0x198")]
	[Header("Gizmos")]
	public LineRenderer RangedWeaponTrajectory;

	// Token: 0x040010AC RID: 4268
	[Token(Token = "0x40010AC")]
	[FieldOffset(Offset = "0x1A0")]
	public GameObject RangedWeaponHitTarget;

	// Token: 0x040010AD RID: 4269
	[Token(Token = "0x40010AD")]
	[FieldOffset(Offset = "0x1A8")]
	public GameObject RangedWeaponHitGroundTarget;

	// Token: 0x040010AE RID: 4270
	[Token(Token = "0x40010AE")]
	[FieldOffset(Offset = "0x1B0")]
	public Transform MouseSprite;

	// Token: 0x040010AF RID: 4271
	[Token(Token = "0x40010AF")]
	[FieldOffset(Offset = "0x1B8")]
	public Transform NewMouseSprite;

	// Token: 0x040010B0 RID: 4272
	[Token(Token = "0x40010B0")]
	[FieldOffset(Offset = "0x1C0")]
	public RawImage MouseSpriteInventoryInner;

	// Token: 0x040010B1 RID: 4273
	[Token(Token = "0x40010B1")]
	[FieldOffset(Offset = "0x1C8")]
	public RawImage MouseSpriteInventoryOuter;

	// Token: 0x040010B2 RID: 4274
	[Token(Token = "0x40010B2")]
	[FieldOffset(Offset = "0x1D0")]
	public RawImage MouseSpriteInventoryArrow;

	// Token: 0x040010B3 RID: 4275
	[Token(Token = "0x40010B3")]
	[FieldOffset(Offset = "0x1D8")]
	[SerializeField]
	[Space(15f)]
	private GameObject _cantCarryItemView;

	// Token: 0x040010B4 RID: 4276
	[Token(Token = "0x40010B4")]
	[FieldOffset(Offset = "0x1E0")]
	[SerializeField]
	private GameObject _gotItemView;

	// Token: 0x040010B5 RID: 4277
	[Token(Token = "0x40010B5")]
	[FieldOffset(Offset = "0x1E8")]
	[SerializeField]
	private GameObject _requiredItemView;

	// Token: 0x040010B6 RID: 4278
	[Token(Token = "0x40010B6")]
	[FieldOffset(Offset = "0x1F0")]
	[SerializeField]
	private GameObject _generalMessageView;

	// Token: 0x040010B7 RID: 4279
	[Token(Token = "0x40010B7")]
	[FieldOffset(Offset = "0x1F8")]
	[Header("VR")]
	public UILabel FpsLabel;

	// Token: 0x040010B8 RID: 4280
	[Token(Token = "0x40010B8")]
	[FieldOffset(Offset = "0x200")]
	public UIWidget HealthHudWidget;

	// Token: 0x040010B9 RID: 4281
	[Token(Token = "0x40010B9")]
	[FieldOffset(Offset = "0x208")]
	private readonly Dictionary<int, HudGui.TimedGameObject> _cantCarryItemViewGOs;

	// Token: 0x040010BA RID: 4282
	[Token(Token = "0x40010BA")]
	[FieldOffset(Offset = "0x210")]
	private readonly Dictionary<int, HudGui.TimedGameObject> _gotItemViewGOs;

	// Token: 0x040010BB RID: 4283
	[Token(Token = "0x40010BB")]
	[FieldOffset(Offset = "0x218")]
	private readonly Dictionary<int, HudGui.TimedGameObject> _ingredientItemCountViewGOs;

	// Token: 0x040010BC RID: 4284
	[Token(Token = "0x40010BC")]
	[FieldOffset(Offset = "0x220")]
	private readonly Queue<HudGui.TimedGameObject> _tgoPool;

	// Token: 0x040010BD RID: 4285
	[Token(Token = "0x40010BD")]
	[FieldOffset(Offset = "0x228")]
	private readonly List<HudGui.TimedGameObject> _generalMessages;

	// Token: 0x040010BE RID: 4286
	[Token(Token = "0x40010BE")]
	[FieldOffset(Offset = "0x230")]
	private float _nextBuildMissionDisplay;

	// Token: 0x040010BF RID: 4287
	[Token(Token = "0x40010BF")]
	[FieldOffset(Offset = "0x234")]
	private float _nextItemInfoDisplay;

	// Token: 0x040010C0 RID: 4288
	[Token(Token = "0x40010C0")]
	[FieldOffset(Offset = "0x238")]
	private ItemInstance _nextItemInstance;

	// Token: 0x040010C1 RID: 4289
	[Token(Token = "0x40010C1")]
	[FieldOffset(Offset = "0x240")]
	private bool _nextItemInfoIsCraft;

	// Token: 0x040010C2 RID: 4290
	[Token(Token = "0x40010C2")]
	[FieldOffset(Offset = "0x244")]
	private int _nextItemInfoViewCounter;

	// Token: 0x040010C3 RID: 4291
	[Token(Token = "0x40010C3")]
	[FieldOffset(Offset = "0x248")]
	private float _nextQuickInfoDisplay;

	// Token: 0x040010C4 RID: 4292
	[Token(Token = "0x40010C4")]
	[FieldOffset(Offset = "0x24C")]
	private float _nextRecipeListDisplay;

	// Token: 0x040010C5 RID: 4293
	[Token(Token = "0x40010C5")]
	[FieldOffset(Offset = "0x250")]
	private float _fps;

	// Token: 0x040010C7 RID: 4295
	[Token(Token = "0x40010C7")]
	[FieldOffset(Offset = "0x260")]
	[SerializeField]
	private List<RectTransform> _cutsceneModeObjectsToDisable;

	// Token: 0x040010C8 RID: 4296
	[Token(Token = "0x40010C8")]
	[FieldOffset(Offset = "0x268")]
	[SerializeField]
	private List<RectTransform> _cutsceneModeObjectsToEnable;

	// Token: 0x040010C9 RID: 4297
	[Token(Token = "0x40010C9")]
	[FieldOffset(Offset = "0x270")]
	[SerializeField]
	private float _delayedDisabledNullItemInstance;

	// Token: 0x040010CA RID: 4298
	[Token(Token = "0x40010CA")]
	[FieldOffset(Offset = "0x278")]
	[SerializeField]
	private GameObject _sleepingMultiplayerNotification;

	// Token: 0x040010CB RID: 4299
	[Token(Token = "0x40010CB")]
	[FieldOffset(Offset = "0x280")]
	[SerializeField]
	private TextMeshProUGUI _playersWaitingToSleep;

	// Token: 0x040010CC RID: 4300
	[Token(Token = "0x40010CC")]
	[FieldOffset(Offset = "0x288")]
	private float _lastTimeItemInstanceWasSet;

	// Token: 0x040010CD RID: 4301
	[Token(Token = "0x40010CD")]
	[FieldOffset(Offset = "0x28C")]
	private float _previousTimescale;

	// Token: 0x040010CE RID: 4302
	[Token(Token = "0x40010CE")]
	[FieldOffset(Offset = "0x290")]
	private CustomPassVolume _blurUiPass;

	// Token: 0x040010CF RID: 4303
	[Token(Token = "0x40010CF")]
	[FieldOffset(Offset = "0x298")]
	private int _screenResolutionHash;

	// Token: 0x040010D0 RID: 4304
	[Token(Token = "0x40010D0")]
	[FieldOffset(Offset = "0x2A0")]
	private Coroutine _slowTimeToZeroWorker;

	// Token: 0x040010D1 RID: 4305
	[Token(Token = "0x40010D1")]
	[FieldOffset(Offset = "0x8")]
	private static HudGui _instance;

	// Token: 0x040010D2 RID: 4306
	[Token(Token = "0x40010D2")]
	[FieldOffset(Offset = "0x2A8")]
	[SerializeField]
	private float _maxWeaponDamage;

	// Token: 0x040010D3 RID: 4307
	[Token(Token = "0x40010D3")]
	[FieldOffset(Offset = "0x2B0")]
	public HudGui.InventoryItemInfoView _inventoryItemInfoView;

	// Token: 0x040010D4 RID: 4308
	[Token(Token = "0x40010D4")]
	[FieldOffset(Offset = "0x2B8")]
	public GameObject ClickToRemoveInfo;

	// Token: 0x040010D5 RID: 4309
	[Token(Token = "0x40010D5")]
	[FieldOffset(Offset = "0x2C0")]
	public GameObject ClickToEquipInfo;

	// Token: 0x040010D6 RID: 4310
	[Token(Token = "0x40010D6")]
	[FieldOffset(Offset = "0x2C8")]
	public RectTransform _availableRecipesView;

	// Token: 0x040010D7 RID: 4311
	[Token(Token = "0x40010D7")]
	[FieldOffset(Offset = "0x2D0")]
	[SerializeField]
	private List<CraftingRecipeView> _craftingRecipeViews;

	// Token: 0x040010D8 RID: 4312
	[Token(Token = "0x40010D8")]
	[FieldOffset(Offset = "0x2D8")]
	[SerializeField]
	private GameObject _recipeListDots;

	// Token: 0x040010D9 RID: 4313
	[Token(Token = "0x40010D9")]
	[FieldOffset(Offset = "0x2E0")]
	[SerializeField]
	private int _maxCraftingRecipeListCount;

	// Token: 0x040010DA RID: 4314
	[Token(Token = "0x40010DA")]
	[FieldOffset(Offset = "0x2E8")]
	[SerializeField]
	private ItemInstance _hoveredItemInstance;

	// Token: 0x040010DB RID: 4315
	[Token(Token = "0x40010DB")]
	[FieldOffset(Offset = "0x2F0")]
	public HudGui.QuickSelectItemInfoView _quickSelectItemInfoView;

	// Token: 0x040010DC RID: 4316
	[Token(Token = "0x40010DC")]
	[FieldOffset(Offset = "0x2F8")]
	public HudGui.ToolTipInfoView _toolTipInfoView;

	// Token: 0x02000293 RID: 659
	[Token(Token = "0x2000293")]
	[Serializable]
	private class CookingRecipeInfoView
	{
		// Token: 0x0600112A RID: 4394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600112A")]
		[Address(RVA = "0x2FAA9C0", Offset = "0x2FA99C0", VA = "0x182FAA9C0")]
		public CookingRecipeInfoView()
		{
		}

		// Token: 0x040010DD RID: 4317
		[Token(Token = "0x40010DD")]
		[FieldOffset(Offset = "0x10")]
		public GameObject _root;

		// Token: 0x040010DE RID: 4318
		[Token(Token = "0x40010DE")]
		[FieldOffset(Offset = "0x18")]
		public RawImage _icon;

		// Token: 0x040010DF RID: 4319
		[Token(Token = "0x40010DF")]
		[FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI _title;

		// Token: 0x040010E0 RID: 4320
		[Token(Token = "0x40010E0")]
		[FieldOffset(Offset = "0x28")]
		public float _mouseFollowSpeed;

		// Token: 0x040010E1 RID: 4321
		[Token(Token = "0x40010E1")]
		[FieldOffset(Offset = "0x30")]
		public StatusEffectBarView _containerVolumeBarView;
	}

	// Token: 0x02000294 RID: 660
	[Token(Token = "0x2000294")]
	private class TimedGameObject
	{
		// Token: 0x0600112B RID: 4395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600112B")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public TimedGameObject()
		{
		}

		// Token: 0x040010E2 RID: 4322
		[Token(Token = "0x40010E2")]
		[FieldOffset(Offset = "0x10")]
		public int _amount;

		// Token: 0x040010E3 RID: 4323
		[Token(Token = "0x40010E3")]
		[FieldOffset(Offset = "0x14")]
		public float _endTime;

		// Token: 0x040010E4 RID: 4324
		[Token(Token = "0x40010E4")]
		[FieldOffset(Offset = "0x18")]
		public GameObject _GO;

		// Token: 0x040010E5 RID: 4325
		[Token(Token = "0x40010E5")]
		[FieldOffset(Offset = "0x20")]
		public int _itemId;

		// Token: 0x040010E6 RID: 4326
		[Token(Token = "0x40010E6")]
		[FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI _label;
	}

	// Token: 0x02000295 RID: 661
	[Token(Token = "0x2000295")]
	[Serializable]
	public class ModTimerView : IModTimerView
	{
		// Token: 0x0600112C RID: 4396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600112C")]
		[Address(RVA = "0x2FB5750", Offset = "0x2FB4750", VA = "0x182FB5750", Slot = "7")]
		public void Toggle(bool onOff)
		{
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600112D")]
		[Address(RVA = "0x2FB56C0", Offset = "0x2FB46C0", VA = "0x182FB56C0", Slot = "6")]
		public void SetTitle(bool onOff, [Optional] string text)
		{
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600112E")]
		[Address(RVA = "0x2FB5630", Offset = "0x2FB4630", VA = "0x182FB5630", Slot = "5")]
		public void SetTimer(bool onOff, [Optional] string text)
		{
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600112F")]
		[Address(RVA = "0x2FB55A0", Offset = "0x2FB45A0", VA = "0x182FB55A0", Slot = "4")]
		public void SetSubtitle(bool onOff, [Optional] string text)
		{
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001130")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public ModTimerView()
		{
		}

		// Token: 0x040010E7 RID: 4327
		[Token(Token = "0x40010E7")]
		[FieldOffset(Offset = "0x10")]
		public GameObject _root;

		// Token: 0x040010E8 RID: 4328
		[Token(Token = "0x40010E8")]
		[FieldOffset(Offset = "0x18")]
		public UILabel _title;

		// Token: 0x040010E9 RID: 4329
		[Token(Token = "0x40010E9")]
		[FieldOffset(Offset = "0x20")]
		public UILabel _timer;

		// Token: 0x040010EA RID: 4330
		[Token(Token = "0x40010EA")]
		[FieldOffset(Offset = "0x28")]
		public UILabel _subtitle;
	}

	// Token: 0x02000296 RID: 662
	[Token(Token = "0x2000296")]
	[Serializable]
	public class LoadingScreen
	{
		// Token: 0x06001131 RID: 4401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001131")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public LoadingScreen()
		{
		}

		// Token: 0x040010EB RID: 4331
		[Token(Token = "0x40010EB")]
		[FieldOffset(Offset = "0x10")]
		public GameObject _cam;

		// Token: 0x040010EC RID: 4332
		[Token(Token = "0x40010EC")]
		[FieldOffset(Offset = "0x18")]
		public GameObject _message;
	}

	// Token: 0x02000297 RID: 663
	[Token(Token = "0x2000297")]
	[Serializable]
	public class InventoryItemInfoView
	{
		// Token: 0x06001132 RID: 4402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001132")]
		[Address(RVA = "0x2FB47E0", Offset = "0x2FB37E0", VA = "0x182FB47E0")]
		public void ShowHotKey(bool showHotKey, int index)
		{
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001133")]
		[Address(RVA = "0x2FB4AE0", Offset = "0x2FB3AE0", VA = "0x182FB4AE0")]
		public InventoryItemInfoView()
		{
		}

		// Token: 0x040010ED RID: 4333
		[Token(Token = "0x40010ED")]
		[FieldOffset(Offset = "0x10")]
		public GameObject _root;

		// Token: 0x040010EE RID: 4334
		[Token(Token = "0x40010EE")]
		[FieldOffset(Offset = "0x18")]
		public RawImage _icon;

		// Token: 0x040010EF RID: 4335
		[Token(Token = "0x40010EF")]
		[FieldOffset(Offset = "0x20")]
		public Image _inQuickSelectIcon;

		// Token: 0x040010F0 RID: 4336
		[Token(Token = "0x40010F0")]
		[FieldOffset(Offset = "0x28")]
		public bool _isOnCraftMat;

		// Token: 0x040010F1 RID: 4337
		[Token(Token = "0x40010F1")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI _title;

		// Token: 0x040010F2 RID: 4338
		[Token(Token = "0x40010F2")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI _effect;

		// Token: 0x040010F3 RID: 4339
		[Token(Token = "0x40010F3")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI _description;

		// Token: 0x040010F4 RID: 4340
		[Token(Token = "0x40010F4")]
		[FieldOffset(Offset = "0x48")]
		public ItemAmountLabel _amountText;

		// Token: 0x040010F5 RID: 4341
		[Token(Token = "0x40010F5")]
		[FieldOffset(Offset = "0x50")]
		public GameObject _clothingStatsGroup;

		// Token: 0x040010F6 RID: 4342
		[Token(Token = "0x40010F6")]
		[FieldOffset(Offset = "0x58")]
		public StatusEffectBarView _thermalRatingStatBarView;

		// Token: 0x040010F7 RID: 4343
		[Token(Token = "0x40010F7")]
		[FieldOffset(Offset = "0x60")]
		public StatusEffectBarView _comfortRatingStatBarView;

		// Token: 0x040010F8 RID: 4344
		[Token(Token = "0x40010F8")]
		[FieldOffset(Offset = "0x68")]
		public StatusEffectBarView _waterResistRatingStatBarView;

		// Token: 0x040010F9 RID: 4345
		[Token(Token = "0x40010F9")]
		[FieldOffset(Offset = "0x70")]
		public GameObject _weaponStatsGroup;

		// Token: 0x040010FA RID: 4346
		[Token(Token = "0x40010FA")]
		[FieldOffset(Offset = "0x78")]
		public StatusEffectBarView _speedRatingStatBarView;

		// Token: 0x040010FB RID: 4347
		[Token(Token = "0x40010FB")]
		[FieldOffset(Offset = "0x80")]
		public StatusEffectBarView _damageRatingStatBarView;

		// Token: 0x040010FC RID: 4348
		[Token(Token = "0x40010FC")]
		[FieldOffset(Offset = "0x88")]
		public StatusEffectBarView _blockRatingStatBarView;

		// Token: 0x040010FD RID: 4349
		[Token(Token = "0x40010FD")]
		[FieldOffset(Offset = "0x90")]
		public GameObject _containerVolumeGroup;

		// Token: 0x040010FE RID: 4350
		[Token(Token = "0x40010FE")]
		[FieldOffset(Offset = "0x98")]
		public StatusEffectBarView _containerVolumeBarView;

		// Token: 0x040010FF RID: 4351
		[Token(Token = "0x40010FF")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject _leftClickIcon;

		// Token: 0x04001100 RID: 4352
		[Token(Token = "0x4001100")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject _rightClickIcon;

		// Token: 0x04001101 RID: 4353
		[Token(Token = "0x4001101")]
		[FieldOffset(Offset = "0xB0")]
		public TextMeshProUGUI _leftClickText;

		// Token: 0x04001102 RID: 4354
		[Token(Token = "0x4001102")]
		[FieldOffset(Offset = "0xB8")]
		public TextMeshProUGUI _rightClickText;

		// Token: 0x04001103 RID: 4355
		[Token(Token = "0x4001103")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject _hotkeyGroup;

		// Token: 0x04001104 RID: 4356
		[Token(Token = "0x4001104")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject _emptyHotkeyGroup;

		// Token: 0x04001105 RID: 4357
		[Token(Token = "0x4001105")]
		[FieldOffset(Offset = "0xD0")]
		public DynamicInputIcon _hotkeyIcon;

		// Token: 0x04001106 RID: 4358
		[Token(Token = "0x4001106")]
		[FieldOffset(Offset = "0xD8")]
		public float _mouseFollowSpeed;
	}

	// Token: 0x02000298 RID: 664
	[Token(Token = "0x2000298")]
	[Serializable]
	public class QuickSelectItemInfoView
	{
		// Token: 0x06001134 RID: 4404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001134")]
		[Address(RVA = "0x2FB65F0", Offset = "0x2FB55F0", VA = "0x182FB65F0")]
		public QuickSelectItemInfoView()
		{
		}

		// Token: 0x04001107 RID: 4359
		[Token(Token = "0x4001107")]
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public int _itemId;

		// Token: 0x04001108 RID: 4360
		[Token(Token = "0x4001108")]
		[FieldOffset(Offset = "0x18")]
		public GameObject _root;

		// Token: 0x04001109 RID: 4361
		[Token(Token = "0x4001109")]
		[FieldOffset(Offset = "0x20")]
		public RawImage _icon;

		// Token: 0x0400110A RID: 4362
		[Token(Token = "0x400110A")]
		[FieldOffset(Offset = "0x28")]
		public ItemAmountLabel _amountText;

		// Token: 0x0400110B RID: 4363
		[Token(Token = "0x400110B")]
		[FieldOffset(Offset = "0x30")]
		public GameObject _leftClickIcon;

		// Token: 0x0400110C RID: 4364
		[Token(Token = "0x400110C")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI _leftClickText;

		// Token: 0x0400110D RID: 4365
		[Token(Token = "0x400110D")]
		[FieldOffset(Offset = "0x40")]
		public float _mouseFollowSpeed;
	}

	// Token: 0x02000299 RID: 665
	[Token(Token = "0x2000299")]
	[Serializable]
	public class ToolTipInfoView
	{
		// Token: 0x06001135 RID: 4405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001135")]
		[Address(RVA = "0x2FBB8F0", Offset = "0x2FBA8F0", VA = "0x182FBB8F0")]
		public ToolTipInfoView()
		{
		}

		// Token: 0x0400110E RID: 4366
		[Token(Token = "0x400110E")]
		[FieldOffset(Offset = "0x10")]
		public GameObject _root;

		// Token: 0x0400110F RID: 4367
		[Token(Token = "0x400110F")]
		[FieldOffset(Offset = "0x18")]
		public RawImage _icon;

		// Token: 0x04001110 RID: 4368
		[Token(Token = "0x4001110")]
		[FieldOffset(Offset = "0x20")]
		public GameObject _leftClickIcon;

		// Token: 0x04001111 RID: 4369
		[Token(Token = "0x4001111")]
		[FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI _leftClickText;

		// Token: 0x04001112 RID: 4370
		[Token(Token = "0x4001112")]
		[FieldOffset(Offset = "0x30")]
		public float _mouseFollowSpeed;
	}
}
