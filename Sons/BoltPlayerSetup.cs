using System;
using System.Collections;
using Bolt;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using Sons.Animation;
using Sons.Gameplay;
using Sons.Inventory;
using Sons.Items.Core;
using Sons.Player;
using Sons.Weapon;
using Sons.Wearable;
using Sons.Wearable.Armour;
using Sons.Wearable.Clothing;
using Sons.Wearable.Race;
using TheForest.Items.Inventory;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Serialization;

// Token: 0x0200009D RID: 157
[Token(Token = "0x200009D")]
public class BoltPlayerSetup : EntityEventListener<IPlayerState>, IPriorityCalculator
{
	// Token: 0x170000CE RID: 206
	// (get) Token: 0x06000553 RID: 1363 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000CE")]
	public IkTargetsController IkTargetsController
	{
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x5EE390", Offset = "0x5EC990", VA = "0x1805EE390")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000554 RID: 1364 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000554")]
	[Address(RVA = "0x3501700", Offset = "0x34FFD00", VA = "0x183501700")]
	private void Update()
	{
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000555")]
	[Address(RVA = "0x3501780", Offset = "0x34FFD80", VA = "0x183501780")]
	private void OnDestroy()
	{
	}

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x06000556 RID: 1366 RVA: 0x00003B40 File Offset: 0x00001D40
	[Token(Token = "0x170000CF")]
	private bool Always
	{
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "324")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x00003B58 File Offset: 0x00001D58
	[Token(Token = "0x6000557")]
	[Address(RVA = "0x35019B0", Offset = "0x34FFFB0", VA = "0x1835019B0", Slot = "323")]
	private float CalculateEventPriority(BoltConnection connection, Bolt.Event evnt)
	{
		return 0f;
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x00003B70 File Offset: 0x00001D70
	[Token(Token = "0x6000558")]
	[Address(RVA = "0x35019F0", Offset = "0x34FFFF0", VA = "0x1835019F0", Slot = "322")]
	private float CalculateStatePriority(BoltConnection connection, int skipped)
	{
		return 0f;
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000559")]
	[Address(RVA = "0x3501A40", Offset = "0x3500040", VA = "0x183501A40")]
	public void WaitForInventoryToBeEnabledAndThenDo(Action action)
	{
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600055A")]
	[Address(RVA = "0x3501AF0", Offset = "0x35000F0", VA = "0x183501AF0")]
	private IEnumerator WaitForInv(Action action)
	{
		return null;
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055B")]
	[Address(RVA = "0x3501B80", Offset = "0x3500180", VA = "0x183501B80", Slot = "17")]
	public override void Detached()
	{
	}

	// Token: 0x0600055C RID: 1372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055C")]
	[Address(RVA = "0x35028B0", Offset = "0x3500EB0", VA = "0x1835028B0", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x0600055D RID: 1373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055D")]
	[Address(RVA = "0x3502DB0", Offset = "0x35013B0", VA = "0x183502DB0")]
	private void RemoteAttached()
	{
	}

	// Token: 0x0600055E RID: 1374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055E")]
	[Address(RVA = "0x35036C0", Offset = "0x3501CC0", VA = "0x1835036C0")]
	private void DedicatedServerPlayerPiggyback(bool attached)
	{
	}

	// Token: 0x0600055F RID: 1375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055F")]
	[Address(RVA = "0x3504130", Offset = "0x3502730", VA = "0x183504130")]
	private void LocalAttached()
	{
	}

	// Token: 0x06000560 RID: 1376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000560")]
	[Address(RVA = "0x3504EB0", Offset = "0x35034B0", VA = "0x183504EB0")]
	private void OnDyingChanged()
	{
	}

	// Token: 0x06000561 RID: 1377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000561")]
	[Address(RVA = "0x35050B0", Offset = "0x35036B0", VA = "0x1835050B0")]
	private void OnInWaterChanged()
	{
	}

	// Token: 0x06000562 RID: 1378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000562")]
	[Address(RVA = "0x3505200", Offset = "0x3503800", VA = "0x183505200")]
	private void OnFireFxChanged()
	{
	}

	// Token: 0x06000563 RID: 1379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000563")]
	[Address(RVA = "0x3505350", Offset = "0x3503950", VA = "0x183505350")]
	private void OnStimuliFlagsChanged()
	{
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000564")]
	[Address(RVA = "0x35054C0", Offset = "0x3503AC0", VA = "0x1835054C0")]
	private void OnVisibilityRangeMultChanged()
	{
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000565")]
	[Address(RVA = "0x3505600", Offset = "0x3503C00", VA = "0x183505600")]
	private void OnExpressionChanged()
	{
	}

	// Token: 0x06000566 RID: 1382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000566")]
	[Address(RVA = "0x3505880", Offset = "0x3503E80", VA = "0x183505880")]
	private void SetPlayerColor()
	{
	}

	// Token: 0x06000567 RID: 1383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000567")]
	[Address(RVA = "0x3505CD0", Offset = "0x35042D0", VA = "0x183505CD0")]
	private void OnCurrentViewChanged()
	{
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000568")]
	[Address(RVA = "0x3505E20", Offset = "0x3504420", VA = "0x183505E20")]
	private static string GetPlayerName(BoltEntity boltEntity, IPlayerState playerState)
	{
		return null;
	}

	// Token: 0x06000569 RID: 1385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000569")]
	[Address(RVA = "0x3505F40", Offset = "0x3504540", VA = "0x183505F40")]
	private void OnRaceChanged(PlayerRace.Race race)
	{
	}

	// Token: 0x0600056A RID: 1386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600056A")]
	[Address(RVA = "0x3505FE0", Offset = "0x35045E0", VA = "0x183505FE0")]
	private void OnClothingEquipped(int itemId)
	{
	}

	// Token: 0x0600056B RID: 1387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600056B")]
	[Address(RVA = "0x3506220", Offset = "0x3504820", VA = "0x183506220")]
	private void OnClothingUnequipped(int itemId)
	{
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600056C")]
	[Address(RVA = "0x35063F0", Offset = "0x35049F0", VA = "0x1835063F0")]
	private void OnArmourEquipped(ArmourPiece armourPiece, WearableSlots slot)
	{
	}

	// Token: 0x0600056D RID: 1389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600056D")]
	[Address(RVA = "0x35064C0", Offset = "0x3504AC0", VA = "0x1835064C0")]
	private void OnArmourUnequipped(ArmourPiece armourPiece, WearableSlots slot)
	{
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600056E")]
	[Address(RVA = "0x3506580", Offset = "0x3504B80", VA = "0x183506580")]
	private void OnArmourBroken(ArmourPiece armourPiece, WearableSlots slot)
	{
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600056F")]
	[Address(RVA = "0x3506640", Offset = "0x3504C40", VA = "0x183506640")]
	private void OnRightHandItemLit(bool isLit)
	{
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000570")]
	[Address(RVA = "0x35066E0", Offset = "0x3504CE0", VA = "0x1835066E0")]
	private void OnHeldItemInitialized(GameObject newInstance, InventoryProps.PropDefinition propDefinition, ItemInstance itemInstance)
	{
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000571")]
	[Address(RVA = "0x35066F0", Offset = "0x3504CF0", VA = "0x1835066F0")]
	private void OnItemTransferredToSlot(int itemId, EquipmentSlot fromSlot, EquipmentSlot toSlot)
	{
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000572")]
	[Address(RVA = "0x3506A00", Offset = "0x3505000", VA = "0x183506A00")]
	private void OnHeldItemRemoved(int itemId, bool mpIgnoreCallback)
	{
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000573")]
	[Address(RVA = "0x3506A10", Offset = "0x3505010", VA = "0x183506A10")]
	private void AddHeldItem(ItemInstance itemInstance)
	{
	}

	// Token: 0x06000574 RID: 1396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000574")]
	[Address(RVA = "0x3506DC0", Offset = "0x35053C0", VA = "0x183506DC0")]
	private void TryAddHeldItemWeaponMods(ItemInstance itemInstance)
	{
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000575")]
	[Address(RVA = "0x3507460", Offset = "0x3505A60", VA = "0x183507460")]
	private void TryAddPerishableState(ItemInstance itemInstance)
	{
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000576")]
	[Address(RVA = "0x35075D0", Offset = "0x3505BD0", VA = "0x1835075D0")]
	private void RemoveHeldItem(int itemId)
	{
	}

	// Token: 0x06000577 RID: 1399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000577")]
	[Address(RVA = "0x35078A0", Offset = "0x3505EA0", VA = "0x1835078A0")]
	private void RemoveHeldItemWeaponMods(int itemId)
	{
	}

	// Token: 0x06000578 RID: 1400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000578")]
	[Address(RVA = "0x3507B50", Offset = "0x3506150", VA = "0x183507B50")]
	private void RemoveHeldItemPerishableState()
	{
	}

	// Token: 0x06000579 RID: 1401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000579")]
	[Address(RVA = "0x3507C40", Offset = "0x3506240", VA = "0x183507C40")]
	private void SendPlayerHit(IImpactSender sender, IImpactData data)
	{
	}

	// Token: 0x0600057A RID: 1402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057A")]
	[Address(RVA = "0x3508500", Offset = "0x3506B00", VA = "0x183508500", Slot = "181")]
	public override void OnEvent(HitPlayer evnt)
	{
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057B")]
	[Address(RVA = "0x3508940", Offset = "0x3506F40", VA = "0x183508940")]
	public void FiredWeaponNetwork()
	{
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057C")]
	[Address(RVA = "0x3508A30", Offset = "0x3507030", VA = "0x183508A30")]
	private void UpdateState()
	{
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057D")]
	[Address(RVA = "0x3508E90", Offset = "0x3507490", VA = "0x183508E90")]
	public BoltPlayerSetup()
	{
	}

	// Token: 0x040004EB RID: 1259
	[Token(Token = "0x40004EB")]
	private const string MultiplayerRealisticPlayerDamageKey = "Multiplayer.RealisticPlayerDamage";

	// Token: 0x040004EC RID: 1260
	[Token(Token = "0x40004EC")]
	private const string ConnectedTransformObjectName = "ConnectedTransform";

	// Token: 0x040004ED RID: 1261
	[Token(Token = "0x40004ED")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[FormerlySerializedAs("RespawnDeadTrigger")]
	private GameObject _revivePlayerInteraction;

	// Token: 0x040004EE RID: 1262
	[Token(Token = "0x40004EE")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject _receiveItemsInteraction;

	// Token: 0x040004EF RID: 1263
	[Token(Token = "0x40004EF")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private PlayerInventory _inventory;

	// Token: 0x040004F0 RID: 1264
	[Token(Token = "0x40004F0")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private InventoryProps _inventoryProps;

	// Token: 0x040004F1 RID: 1265
	[Token(Token = "0x40004F1")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private DamageController _damageController;

	// Token: 0x040004F2 RID: 1266
	[Token(Token = "0x40004F2")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private PlayerRaceSystem _raceSystem;

	// Token: 0x040004F3 RID: 1267
	[Token(Token = "0x40004F3")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private PlayerClothingSystem _clothingSystem;

	// Token: 0x040004F4 RID: 1268
	[Token(Token = "0x40004F4")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private PlayerArmourSystem _armourSystem;

	// Token: 0x040004F5 RID: 1269
	[Token(Token = "0x40004F5")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private PlayerStimuli _playerStimuli;

	// Token: 0x040004F6 RID: 1270
	[Token(Token = "0x40004F6")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private PlayerExpressions _playerExpressions;

	// Token: 0x040004F7 RID: 1271
	[Token(Token = "0x40004F7")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private PlayerStats _playerStats;

	// Token: 0x040004F8 RID: 1272
	[Token(Token = "0x40004F8")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private PlayerEffects _playerEffects;

	// Token: 0x040004F9 RID: 1273
	[Token(Token = "0x40004F9")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[FormerlySerializedAs("_controllerTransform")]
	private Transform _connectedTransform;

	// Token: 0x040004FA RID: 1274
	[Token(Token = "0x40004FA")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	public IkTargetsController _ikTargetsController;

	// Token: 0x040004FB RID: 1275
	[Token(Token = "0x40004FB")]
	[FieldOffset(Offset = "0x98")]
	private bool[] _loggedFeetErrors;

	// Token: 0x040004FC RID: 1276
	[Token(Token = "0x40004FC")]
	[FieldOffset(Offset = "0xA0")]
	private float _limitDamageTimer;

	// Token: 0x040004FD RID: 1277
	[Token(Token = "0x40004FD")]
	[FieldOffset(Offset = "0xA8")]
	private PositionConstraint _dedicatedServerPiggyBackConstraint;
}
