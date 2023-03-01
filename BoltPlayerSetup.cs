using System;
using System.Collections;
using Bolt;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using Sons.Gameplay;
using Sons.Inventory;
using Sons.Player;
using Sons.Weapon;
using Sons.Wearable;
using Sons.Wearable.Armour;
using Sons.Wearable.Clothing;
using Sons.Wearable.Race;
using TheForest.Items.Inventory;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x0200009D RID: 157
[Token(Token = "0x200009D")]
public class BoltPlayerSetup : EntityEventListener<IPlayerState>, IPriorityCalculator
{
	// Token: 0x06000529 RID: 1321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000529")]
	[Address(RVA = "0x2D4DEA0", Offset = "0x2D4CEA0", VA = "0x182D4DEA0")]
	private void Update()
	{
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600052A")]
	[Address(RVA = "0x2D4B230", Offset = "0x2D4A230", VA = "0x182D4B230")]
	private void OnDestroy()
	{
	}

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x0600052B RID: 1323 RVA: 0x00003990 File Offset: 0x00001B90
	[Token(Token = "0x170000C9")]
	private bool Always
	{
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "298")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x000039A8 File Offset: 0x00001BA8
	[Token(Token = "0x600052C")]
	[Address(RVA = "0x2D49CC0", Offset = "0x2D48CC0", VA = "0x182D49CC0", Slot = "297")]
	private float CalculateEventPriority(BoltConnection connection, Event evnt)
	{
		return default(float);
	}

	// Token: 0x0600052D RID: 1325 RVA: 0x000039C0 File Offset: 0x00001BC0
	[Token(Token = "0x600052D")]
	[Address(RVA = "0x2D49D00", Offset = "0x2D48D00", VA = "0x182D49D00", Slot = "296")]
	private float CalculateStatePriority(BoltConnection connection, int skipped)
	{
		return default(float);
	}

	// Token: 0x0600052E RID: 1326 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600052E")]
	[Address(RVA = "0x2D4DF50", Offset = "0x2D4CF50", VA = "0x182D4DF50")]
	public void WaitForInventoryToBeEnabledAndThenDo(Action action)
	{
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600052F")]
	[Address(RVA = "0x2D4DEE0", Offset = "0x2D4CEE0", VA = "0x182D4DEE0")]
	private IEnumerator WaitForInv(Action action)
	{
		return null;
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000530")]
	[Address(RVA = "0x2D49D50", Offset = "0x2D48D50", VA = "0x182D49D50", Slot = "17")]
	public override void Detached()
	{
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000531")]
	[Address(RVA = "0x2D49B50", Offset = "0x2D48B50", VA = "0x182D49B50", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000532")]
	[Address(RVA = "0x2D4BE90", Offset = "0x2D4AE90", VA = "0x182D4BE90")]
	private void RemoteAttached()
	{
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000533")]
	[Address(RVA = "0x2D4A530", Offset = "0x2D49530", VA = "0x182D4A530")]
	private void LocalAttached()
	{
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000534")]
	[Address(RVA = "0x2D4B360", Offset = "0x2D4A360", VA = "0x182D4B360")]
	private void OnDyingChanged()
	{
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000535")]
	[Address(RVA = "0x2D4BB50", Offset = "0x2D4AB50", VA = "0x182D4BB50")]
	private void OnInWaterChanged()
	{
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000536")]
	[Address(RVA = "0x2D4B8F0", Offset = "0x2D4A8F0", VA = "0x182D4B8F0")]
	private void OnFireFxChanged()
	{
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000537")]
	[Address(RVA = "0x2D4BD10", Offset = "0x2D4AD10", VA = "0x182D4BD10")]
	private void OnStimuliFlagsChanged()
	{
	}

	// Token: 0x06000538 RID: 1336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000538")]
	[Address(RVA = "0x2D4BDD0", Offset = "0x2D4ADD0", VA = "0x182D4BDD0")]
	private void OnVisibilityRangeMultChanged()
	{
	}

	// Token: 0x06000539 RID: 1337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000539")]
	[Address(RVA = "0x2D4B830", Offset = "0x2D4A830", VA = "0x182D4B830")]
	private void OnExpressionChanged()
	{
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600053A")]
	[Address(RVA = "0x2D4CE40", Offset = "0x2D4BE40", VA = "0x182D4CE40")]
	private void SetPlayerColor()
	{
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600053B")]
	[Address(RVA = "0x2D4B150", Offset = "0x2D4A150", VA = "0x182D4B150")]
	private void OnCurrentViewChanged()
	{
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600053C")]
	[Address(RVA = "0x2D4A410", Offset = "0x2D49410", VA = "0x182D4A410")]
	private static string GetPlayerName(BoltEntity boltEntity, IPlayerState playerState)
	{
		return null;
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600053D")]
	[Address(RVA = "0x2D4BC10", Offset = "0x2D4AC10", VA = "0x182D4BC10")]
	private void OnRaceChanged(PlayerRace.Race race)
	{
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600053E")]
	[Address(RVA = "0x2D4AE30", Offset = "0x2D49E30", VA = "0x182D4AE30")]
	private void OnClothingEquipped(int itemId)
	{
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600053F")]
	[Address(RVA = "0x2D4AFF0", Offset = "0x2D49FF0", VA = "0x182D4AFF0")]
	private void OnClothingUnequipped(int itemId)
	{
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000540")]
	[Address(RVA = "0x2D4ACE0", Offset = "0x2D49CE0", VA = "0x182D4ACE0")]
	private void OnArmourEquipped(ArmourPiece armourPiece, WearableSlots slot)
	{
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000541")]
	[Address(RVA = "0x2D4AD90", Offset = "0x2D49D90", VA = "0x182D4AD90")]
	private void OnArmourUnequipped(ArmourPiece armourPiece, WearableSlots slot)
	{
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000542")]
	[Address(RVA = "0x2D4AC40", Offset = "0x2D49C40", VA = "0x182D4AC40")]
	private void OnArmourBroken(ArmourPiece armourPiece, WearableSlots slot)
	{
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000543")]
	[Address(RVA = "0x2D4BC90", Offset = "0x2D4AC90", VA = "0x182D4BC90")]
	private void OnRightHandItemLit(bool isLit)
	{
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000544")]
	[Address(RVA = "0x2D4B9C0", Offset = "0x2D4A9C0", VA = "0x182D4B9C0")]
	private void OnHeldItemInitialized(GameObject newInstance, InventoryProps.PropDefinition propDefinition, ItemInstance itemInstance)
	{
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000545")]
	[Address(RVA = "0x2D4B9D0", Offset = "0x2D4A9D0", VA = "0x182D4B9D0")]
	private void OnHeldItemRemoved(int itemId)
	{
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000546")]
	[Address(RVA = "0x2D49830", Offset = "0x2D48830", VA = "0x182D49830")]
	private void AddHeldItem(ItemInstance itemInstance)
	{
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000547")]
	[Address(RVA = "0x2D4D4D0", Offset = "0x2D4C4D0", VA = "0x182D4D4D0")]
	private void TryAddHeldItemWeaponMods(ItemInstance itemInstance)
	{
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000548")]
	[Address(RVA = "0x2D4D9C0", Offset = "0x2D4C9C0", VA = "0x182D4D9C0")]
	private void TryAddPerishableState(ItemInstance itemInstance)
	{
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000549")]
	[Address(RVA = "0x2D4B9D0", Offset = "0x2D4A9D0", VA = "0x182D4B9D0")]
	private void RemoveHeldItem(int itemId)
	{
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054A")]
	[Address(RVA = "0x2D4C600", Offset = "0x2D4B600", VA = "0x182D4C600")]
	private void RemoveHeldItemWeaponMods(int itemId)
	{
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054B")]
	[Address(RVA = "0x2D4C540", Offset = "0x2D4B540", VA = "0x182D4C540")]
	private void RemoveHeldItemPerishableState()
	{
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054C")]
	[Address(RVA = "0x2D4C860", Offset = "0x2D4B860", VA = "0x182D4C860")]
	private void SendPlayerHit(IImpactSender sender, IImpactData data)
	{
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054D")]
	[Address(RVA = "0x2D4B460", Offset = "0x2D4A460", VA = "0x182D4B460", Slot = "168")]
	public override void OnEvent(HitPlayer evnt)
	{
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054E")]
	[Address(RVA = "0x2D4A370", Offset = "0x2D49370", VA = "0x182D4A370")]
	public void FiredWeaponNetwork()
	{
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054F")]
	[Address(RVA = "0x2D4DB00", Offset = "0x2D4CB00", VA = "0x182D4DB00")]
	private void UpdateState()
	{
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000550")]
	[Address(RVA = "0x2D4DFD0", Offset = "0x2D4CFD0", VA = "0x182D4DFD0")]
	public BoltPlayerSetup()
	{
	}

	// Token: 0x040004CE RID: 1230
	[Token(Token = "0x40004CE")]
	private const string MultiplayerRealisticPlayerDamageKey = "Multiplayer.RealisticPlayerDamage";

	// Token: 0x040004CF RID: 1231
	[Token(Token = "0x40004CF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[FormerlySerializedAs("RespawnDeadTrigger")]
	private GameObject _revivePlayerInteraction;

	// Token: 0x040004D0 RID: 1232
	[Token(Token = "0x40004D0")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject _receiveItemsInteraction;

	// Token: 0x040004D1 RID: 1233
	[Token(Token = "0x40004D1")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private PlayerInventory _inventory;

	// Token: 0x040004D2 RID: 1234
	[Token(Token = "0x40004D2")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private InventoryProps _inventoryProps;

	// Token: 0x040004D3 RID: 1235
	[Token(Token = "0x40004D3")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private DamageController _damageController;

	// Token: 0x040004D4 RID: 1236
	[Token(Token = "0x40004D4")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private PlayerRaceSystem _raceSystem;

	// Token: 0x040004D5 RID: 1237
	[Token(Token = "0x40004D5")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private PlayerClothingSystem _clothingSystem;

	// Token: 0x040004D6 RID: 1238
	[Token(Token = "0x40004D6")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private PlayerArmourSystem _armourSystem;

	// Token: 0x040004D7 RID: 1239
	[Token(Token = "0x40004D7")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private PlayerStimuli _playerStimuli;

	// Token: 0x040004D8 RID: 1240
	[Token(Token = "0x40004D8")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private PlayerExpressions _playerExpressions;

	// Token: 0x040004D9 RID: 1241
	[Token(Token = "0x40004D9")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private PlayerStats _playerStats;

	// Token: 0x040004DA RID: 1242
	[Token(Token = "0x40004DA")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private PlayerEffects _playerEffects;

	// Token: 0x040004DB RID: 1243
	[Token(Token = "0x40004DB")]
	[FieldOffset(Offset = "0x88")]
	private bool[] _loggedFeetErrors;

	// Token: 0x040004DC RID: 1244
	[Token(Token = "0x40004DC")]
	[FieldOffset(Offset = "0x90")]
	private float _limitDamageTimer;
}
