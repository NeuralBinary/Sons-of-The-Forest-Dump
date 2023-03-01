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
	// Token: 0x02000566 RID: 1382
	[Token(Token = "0x2000566")]
	public class CoopPlayerRemoteSetup : EntityEventListener<IPlayerState>
	{
		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x0000A5C0 File Offset: 0x000087C0
		[Token(Token = "0x170004CE")]
		public static bool ShowRemotePlayersOverride
		{
			[Token(Token = "0x60023F5")]
			[Address(RVA = "0x2D80BF0", Offset = "0x2D7FBF0", VA = "0x182D80BF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F6")]
		[Address(RVA = "0x2D7EDA0", Offset = "0x2D7DDA0", VA = "0x182D7EDA0")]
		public static void SetShowRemotePlayersOverride(bool value)
		{
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004CF")]
		public PlayerClothingSystem ClothingSystem
		{
			[Token(Token = "0x60023F7")]
			[Address(RVA = "0x52F1A0", Offset = "0x52E1A0", VA = "0x18052F1A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F8")]
		[Address(RVA = "0x2D808B0", Offset = "0x2D7F8B0", VA = "0x182D808B0")]
		private void Update()
		{
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F9")]
		[Address(RVA = "0x2D7E040", Offset = "0x2D7D040", VA = "0x182D7E040", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FA")]
		[Address(RVA = "0x2D80440", Offset = "0x2D7F440", VA = "0x182D80440")]
		private void UpdatePlayerView()
		{
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FB")]
		[Address(RVA = "0x2D7E7B0", Offset = "0x2D7D7B0", VA = "0x182D7E7B0")]
		[ContextMenu("SetVisibility - On")]
		private void DebugVisibilityOn()
		{
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FC")]
		[Address(RVA = "0x2D7E7A0", Offset = "0x2D7D7A0", VA = "0x182D7E7A0")]
		[ContextMenu("SetVisibility - Off")]
		private void DebugVisibilityOff()
		{
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FD")]
		[Address(RVA = "0x2D7EC30", Offset = "0x2D7DC30", VA = "0x182D7EC30")]
		private void SetPlayerVisibility(bool value)
		{
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FE")]
		[Address(RVA = "0x2D7EA40", Offset = "0x2D7DA40", VA = "0x182D7EA40")]
		private void SetPlayerActive(bool value)
		{
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FF")]
		[Address(RVA = "0x2D800B0", Offset = "0x2D7F0B0", VA = "0x182D800B0")]
		private void UpdateName()
		{
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002400")]
		[Address(RVA = "0x2D7E7C0", Offset = "0x2D7D7C0", VA = "0x182D7E7C0", Slot = "17")]
		public override void Detached()
		{
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002401")]
		[Address(RVA = "0x2D805D0", Offset = "0x2D7F5D0", VA = "0x182D805D0")]
		private void UpdateRace()
		{
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002402")]
		[Address(RVA = "0x2D7F890", Offset = "0x2D7E890", VA = "0x182D7F890")]
		private void UpdateClothing()
		{
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002403")]
		[Address(RVA = "0x2D7F4E0", Offset = "0x2D7E4E0", VA = "0x182D7F4E0")]
		private void UpdateArmour()
		{
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002404")]
		[Address(RVA = "0x2D7F6A0", Offset = "0x2D7E6A0", VA = "0x182D7F6A0")]
		private void UpdateBlockingColliders()
		{
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002405")]
		[Address(RVA = "0x2D80650", Offset = "0x2D7F650", VA = "0x182D80650")]
		private void UpdateRightHandItemFire()
		{
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002406")]
		[Address(RVA = "0x2D7FAE0", Offset = "0x2D7EAE0", VA = "0x182D7FAE0")]
		private void UpdateHeldItems()
		{
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002407")]
		[Address(RVA = "0x2D7E940", Offset = "0x2D7D940", VA = "0x182D7E940")]
		private void RemoveHeldItem(int eachItem, bool instantDestroy)
		{
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002408")]
		[Address(RVA = "0x2D7DD70", Offset = "0x2D7CD70", VA = "0x182D7DD70")]
		private void AddHeldItem(int eachItem)
		{
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002409")]
		[Address(RVA = "0x2D7EF70", Offset = "0x2D7DF70", VA = "0x182D7EF70")]
		private void TryAddHeldItemWeaponMods(ItemInstance itemInstance)
		{
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240A")]
		[Address(RVA = "0x2D7EE00", Offset = "0x2D7DE00", VA = "0x182D7EE00")]
		private void TryAddHeldItemPerishableState(ItemInstance itemInstance)
		{
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600240B")]
		[Address(RVA = "0x2D7E8C0", Offset = "0x2D7D8C0", VA = "0x182D7E8C0")]
		private InventoryProps.PropDefinition GetPropDefinitionForItem(int itemId)
		{
			return null;
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240C")]
		[Address(RVA = "0x2D7E8E0", Offset = "0x2D7D8E0", VA = "0x182D7E8E0")]
		public void RegisterOnItemEquipped(UnityAction<ItemInstance> action)
		{
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240D")]
		[Address(RVA = "0x2D80A50", Offset = "0x2D7FA50", VA = "0x182D80A50")]
		public CoopPlayerRemoteSetup()
		{
		}

		// Token: 0x04002053 RID: 8275
		[Token(Token = "0x4002053")]
		private const string UnknownPlayerName = "Unknown player";

		// Token: 0x04002054 RID: 8276
		[Token(Token = "0x4002054")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color DefaultPlayerColor;

		// Token: 0x04002055 RID: 8277
		[Token(Token = "0x4002055")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("CarryBody")]
		private GameObject _carryBody;

		// Token: 0x04002056 RID: 8278
		[Token(Token = "0x4002056")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private InventoryProps _inventoryProps;

		// Token: 0x04002057 RID: 8279
		[Token(Token = "0x4002057")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private PlayerRaceSystem _raceSystem;

		// Token: 0x04002058 RID: 8280
		[Token(Token = "0x4002058")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PlayerClothingSystem _clothingSystem;

		// Token: 0x04002059 RID: 8281
		[Token(Token = "0x4002059")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private PlayerArmourSystem _armourSystem;

		// Token: 0x0400205A RID: 8282
		[Token(Token = "0x400205A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GPSLocator _gpsLocator;

		// Token: 0x0400205B RID: 8283
		[Token(Token = "0x400205B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Animator _playerAnimator;

		// Token: 0x0400205C RID: 8284
		[Token(Token = "0x400205C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private PlayerRobbyInteraction _robbyInteraction;

		// Token: 0x0400205D RID: 8285
		[Token(Token = "0x400205D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UnityEvent<ItemInstance> _onItemEquipped;

		// Token: 0x0400205E RID: 8286
		[Token(Token = "0x400205E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<Collider> _blockingColliders;

		// Token: 0x0400205F RID: 8287
		[Token(Token = "0x400205F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<GameObject> _visibilityLinkedGameObjects;

		// Token: 0x04002060 RID: 8288
		[Token(Token = "0x4002060")]
		[FieldOffset(Offset = "0x80")]
		[FormerlySerializedAs("_interactionLinkedObjects")]
		[SerializeField]
		private List<GameObject> _activeLinkedObjects;

		// Token: 0x04002061 RID: 8289
		[Token(Token = "0x4002061")]
		[FieldOffset(Offset = "0x88")]
		private List<int> _currentHeldItems;

		// Token: 0x04002062 RID: 8290
		[Token(Token = "0x4002062")]
		[FieldOffset(Offset = "0x90")]
		private List<ItemInstance> _equippedItemInstances;

		// Token: 0x04002063 RID: 8291
		[Token(Token = "0x4002063")]
		[FieldOffset(Offset = "0x98")]
		private bool _doOnce;

		// Token: 0x04002064 RID: 8292
		[Token(Token = "0x4002064")]
		[FieldOffset(Offset = "0x99")]
		private bool _appliedViewVisibility;

		// Token: 0x04002065 RID: 8293
		[Token(Token = "0x4002065")]
		[FieldOffset(Offset = "0x9A")]
		private bool _appliedPlayerActive;

		// Token: 0x04002066 RID: 8294
		[Token(Token = "0x4002066")]
		[FieldOffset(Offset = "0x9B")]
		private bool _previousShowRemotePlayersOverride;

		// Token: 0x04002067 RID: 8295
		[Token(Token = "0x4002067")]
		[FieldOffset(Offset = "0x9C")]
		private PlayerInventory.PlayerViews _appliedCurrentView;

		// Token: 0x04002068 RID: 8296
		[Token(Token = "0x4002068")]
		[FieldOffset(Offset = "0x10")]
		private static bool _showRemotePlayersOverride;

		// Token: 0x04002069 RID: 8297
		[Token(Token = "0x4002069")]
		[FieldOffset(Offset = "0xA0")]
		private string _cachedPlayerName;

		// Token: 0x0400206A RID: 8298
		[Token(Token = "0x400206A")]
		[FieldOffset(Offset = "0xA8")]
		private Color _cachedPlayerColor;
	}
}
