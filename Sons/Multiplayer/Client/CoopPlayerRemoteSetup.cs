using System;
using System.Collections.Generic;
using Bolt;
using Il2CppDummyDll;
using Sons.Gameplay;
using Sons.Gameplay.GPS;
using Sons.Inventory;
using Sons.Player;
using Sons.Wearable.Armour;
using Sons.Wearable.Clothing;
using Sons.Wearable.Race;
using TheForest.Items.Inventory;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Sons.Multiplayer.Client
{
	// Token: 0x02000576 RID: 1398
	[Token(Token = "0x2000576")]
	public class CoopPlayerRemoteSetup : EntityEventListener<IPlayerState>
	{
		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060024F3 RID: 9459 RVA: 0x0000AC80 File Offset: 0x00008E80
		[Token(Token = "0x170004E2")]
		public static bool ShowRemotePlayersOverride
		{
			[Token(Token = "0x60024F3")]
			[Address(RVA = "0x3392D40", Offset = "0x3391340", VA = "0x183392D40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F4")]
		[Address(RVA = "0x3392D90", Offset = "0x3391390", VA = "0x183392D90")]
		public static void SetShowRemotePlayersOverride(bool value)
		{
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060024F5 RID: 9461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004E3")]
		public PlayerClothingSystem ClothingSystem
		{
			[Token(Token = "0x60024F5")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F6")]
		[Address(RVA = "0x3392DF0", Offset = "0x33913F0", VA = "0x183392DF0")]
		private void Update()
		{
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F7")]
		[Address(RVA = "0x3392F90", Offset = "0x3391590", VA = "0x183392F90", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F8")]
		[Address(RVA = "0x3393AD0", Offset = "0x33920D0", VA = "0x183393AD0")]
		private void UpdatePlayerView()
		{
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F9")]
		[Address(RVA = "0x3393C50", Offset = "0x3392250", VA = "0x183393C50")]
		[ContextMenu("SetVisibility - On")]
		private void DebugVisibilityOn()
		{
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FA")]
		[Address(RVA = "0x3393C60", Offset = "0x3392260", VA = "0x183393C60")]
		[ContextMenu("SetVisibility - Off")]
		private void DebugVisibilityOff()
		{
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FB")]
		[Address(RVA = "0x3393C70", Offset = "0x3392270", VA = "0x183393C70")]
		private void SetPlayerVisibility(bool value)
		{
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FC")]
		[Address(RVA = "0x3393E70", Offset = "0x3392470", VA = "0x183393E70")]
		private void SetPlayerActive(bool value)
		{
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FD")]
		[Address(RVA = "0x3394610", Offset = "0x3392C10", VA = "0x183394610")]
		private void UpdateName()
		{
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FE")]
		[Address(RVA = "0x3394A10", Offset = "0x3393010", VA = "0x183394A10", Slot = "17")]
		public override void Detached()
		{
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FF")]
		[Address(RVA = "0x3394BA0", Offset = "0x33931A0", VA = "0x183394BA0")]
		private void UpdateRace()
		{
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002500")]
		[Address(RVA = "0x3394C50", Offset = "0x3393250", VA = "0x183394C50")]
		private void UpdateClothing()
		{
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002501")]
		[Address(RVA = "0x33950F0", Offset = "0x33936F0", VA = "0x1833950F0")]
		private void UpdateArmour()
		{
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002502")]
		[Address(RVA = "0x3395380", Offset = "0x3393980", VA = "0x183395380")]
		private void UpdateBlockingColliders()
		{
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002503")]
		[Address(RVA = "0x3395600", Offset = "0x3393C00", VA = "0x183395600")]
		private void UpdateRightHandItemFire()
		{
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002504")]
		[Address(RVA = "0x3395920", Offset = "0x3393F20", VA = "0x183395920")]
		private void UpdateHeldItemSlotTransfer()
		{
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002505")]
		[Address(RVA = "0x3395AB0", Offset = "0x33940B0", VA = "0x183395AB0")]
		private void UpdateHeldItems()
		{
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002506")]
		[Address(RVA = "0x33966B0", Offset = "0x3394CB0", VA = "0x1833966B0")]
		private void RemoveHeldItem(int eachItem, bool instantDestroy)
		{
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002507")]
		[Address(RVA = "0x33967B0", Offset = "0x3394DB0", VA = "0x1833967B0")]
		private void AddHeldItem(int eachItem)
		{
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002508")]
		[Address(RVA = "0x33968E0", Offset = "0x3394EE0", VA = "0x1833968E0")]
		private void TryAddHeldItemWeaponMods(ItemInstance itemInstance)
		{
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002509")]
		[Address(RVA = "0x3396DE0", Offset = "0x33953E0", VA = "0x183396DE0")]
		private void TryAddHeldItemPerishableState(ItemInstance itemInstance)
		{
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600250A")]
		[Address(RVA = "0x3397060", Offset = "0x3395660", VA = "0x183397060")]
		private InventoryProps.PropDefinition GetPropDefinitionForItem(int itemId)
		{
			return null;
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600250B")]
		[Address(RVA = "0x3397090", Offset = "0x3395690", VA = "0x183397090")]
		public void RegisterOnItemEquipped(UnityAction<ItemInstance> action)
		{
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600250C")]
		[Address(RVA = "0x33970F0", Offset = "0x33956F0", VA = "0x1833970F0")]
		public CoopPlayerRemoteSetup()
		{
		}

		// Token: 0x04002126 RID: 8486
		[Token(Token = "0x4002126")]
		private const string UnknownPlayerName = "Unknown player";

		// Token: 0x04002127 RID: 8487
		[Token(Token = "0x4002127")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color DefaultPlayerColor;

		// Token: 0x04002128 RID: 8488
		[Token(Token = "0x4002128")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("CarryBody")]
		private GameObject _carryBody;

		// Token: 0x04002129 RID: 8489
		[Token(Token = "0x4002129")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private InventoryProps _inventoryProps;

		// Token: 0x0400212A RID: 8490
		[Token(Token = "0x400212A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private PlayerRaceSystem _raceSystem;

		// Token: 0x0400212B RID: 8491
		[Token(Token = "0x400212B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PlayerClothingSystem _clothingSystem;

		// Token: 0x0400212C RID: 8492
		[Token(Token = "0x400212C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private PlayerArmourSystem _armourSystem;

		// Token: 0x0400212D RID: 8493
		[Token(Token = "0x400212D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GPSLocator _gpsLocator;

		// Token: 0x0400212E RID: 8494
		[Token(Token = "0x400212E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Animator _playerAnimator;

		// Token: 0x0400212F RID: 8495
		[Token(Token = "0x400212F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private PlayerRobbyInteraction _robbyInteraction;

		// Token: 0x04002130 RID: 8496
		[Token(Token = "0x4002130")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UnityEvent<ItemInstance> _onItemEquipped;

		// Token: 0x04002131 RID: 8497
		[Token(Token = "0x4002131")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<Collider> _blockingColliders;

		// Token: 0x04002132 RID: 8498
		[Token(Token = "0x4002132")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<GameObject> _visibilityLinkedGameObjects;

		// Token: 0x04002133 RID: 8499
		[Token(Token = "0x4002133")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[FormerlySerializedAs("_interactionLinkedObjects")]
		private List<GameObject> _activeLinkedObjects;

		// Token: 0x04002134 RID: 8500
		[Token(Token = "0x4002134")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Collider _bodyDamageCollider;

		// Token: 0x04002135 RID: 8501
		[Token(Token = "0x4002135")]
		[FieldOffset(Offset = "0x90")]
		private List<int> _currentHeldItems;

		// Token: 0x04002136 RID: 8502
		[Token(Token = "0x4002136")]
		[FieldOffset(Offset = "0x98")]
		private List<ItemInstance> _equippedItemInstances;

		// Token: 0x04002137 RID: 8503
		[Token(Token = "0x4002137")]
		[FieldOffset(Offset = "0xA0")]
		private bool _doOnce;

		// Token: 0x04002138 RID: 8504
		[Token(Token = "0x4002138")]
		[FieldOffset(Offset = "0xA1")]
		private bool _appliedViewVisibility;

		// Token: 0x04002139 RID: 8505
		[Token(Token = "0x4002139")]
		[FieldOffset(Offset = "0xA2")]
		private bool _appliedPlayerActive;

		// Token: 0x0400213A RID: 8506
		[Token(Token = "0x400213A")]
		[FieldOffset(Offset = "0xA3")]
		private bool _previousShowRemotePlayersOverride;

		// Token: 0x0400213B RID: 8507
		[Token(Token = "0x400213B")]
		[FieldOffset(Offset = "0xA4")]
		private PlayerInventory.PlayerViews _appliedCurrentView;

		// Token: 0x0400213C RID: 8508
		[Token(Token = "0x400213C")]
		[FieldOffset(Offset = "0x10")]
		private static bool _showRemotePlayersOverride;

		// Token: 0x0400213D RID: 8509
		[Token(Token = "0x400213D")]
		[FieldOffset(Offset = "0xA8")]
		private string _cachedPlayerName;

		// Token: 0x0400213E RID: 8510
		[Token(Token = "0x400213E")]
		[FieldOffset(Offset = "0xB0")]
		private Color _cachedPlayerColor;
	}
}
