using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FMOD.Studio;
using Il2CppDummyDll;
using Sons.Crafting;
using Sons.Cutscenes;
using Sons.Inventory;
using Sons.Items.Core;
using Sons.Player;
using Sons.Save;
using Sons.Wearable;
using Sons.Wearable.Armour;
using TheForest.Items.Special;
using TheForest.Player.Actions;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

namespace TheForest.Items.Inventory
{
	// Token: 0x020004A8 RID: 1192
	[Token(Token = "0x20004A8")]
	[AddComponentMenu("Items/Inventory/PlayerInventory")]
	public class PlayerInventory : MonoBehaviour, IReceiveItems, ISaveGameSerializer<PlayerInventory.PlayerInventorySaveData>
	{
		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001EEF RID: 7919 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EF0 RID: 7920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000448")]
		public InventoryProps InventoryProps
		{
			[Token(Token = "0x6001EEF")]
			[Address(RVA = "0x8ECC80", Offset = "0x8EB280", VA = "0x1808ECC80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EF0")]
			[Address(RVA = "0x8ECC90", Offset = "0x8EB290", VA = "0x1808ECC90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000449")]
		public InventoryCameraController CameraController
		{
			[Token(Token = "0x6001EF1")]
			[Address(RVA = "0x32F9860", Offset = "0x32F7E60", VA = "0x1832F9860")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044A")]
		public PlayerState PlayerState
		{
			[Token(Token = "0x6001EF2")]
			[Address(RVA = "0x750FA0", Offset = "0x74F5A0", VA = "0x180750FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044B")]
		public GameObject SpecialActions
		{
			[Token(Token = "0x6001EF3")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06001EF4 RID: 7924 RVA: 0x00008D90 File Offset: 0x00006F90
		// (set) Token: 0x06001EF5 RID: 7925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044C")]
		public bool BlockTogglingInventory
		{
			[Token(Token = "0x6001EF4")]
			[Address(RVA = "0x22711D0", Offset = "0x226F7D0", VA = "0x1822711D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EF5")]
			[Address(RVA = "0x32F9880", Offset = "0x32F7E80", VA = "0x1832F9880")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001EF6 RID: 7926 RVA: 0x00008DA8 File Offset: 0x00006FA8
		// (set) Token: 0x06001EF7 RID: 7927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044D")]
		public bool IsWeaponBurning
		{
			[Token(Token = "0x6001EF6")]
			[Address(RVA = "0x30C6AB0", Offset = "0x30C50B0", VA = "0x1830C6AB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EF7")]
			[Address(RVA = "0x32F9890", Offset = "0x32F7E90", VA = "0x1832F9890")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06001EF8 RID: 7928 RVA: 0x00008DC0 File Offset: 0x00006FC0
		// (set) Token: 0x06001EF9 RID: 7929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044E")]
		public bool CancelNextChargedAttack
		{
			[Token(Token = "0x6001EF8")]
			[Address(RVA = "0x32F98A0", Offset = "0x32F7EA0", VA = "0x1832F98A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EF9")]
			[Address(RVA = "0x32F98B0", Offset = "0x32F7EB0", VA = "0x1832F98B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06001EFA RID: 7930 RVA: 0x00008DD8 File Offset: 0x00006FD8
		// (set) Token: 0x06001EFB RID: 7931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044F")]
		public bool SkipNextAddItemWoosh
		{
			[Token(Token = "0x6001EFA")]
			[Address(RVA = "0x32F98C0", Offset = "0x32F7EC0", VA = "0x1832F98C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EFB")]
			[Address(RVA = "0x32F98D0", Offset = "0x32F7ED0", VA = "0x1832F98D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06001EFC RID: 7932 RVA: 0x00008DF0 File Offset: 0x00006FF0
		// (set) Token: 0x06001EFD RID: 7933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000450")]
		public bool DontShowDrop
		{
			[Token(Token = "0x6001EFC")]
			[Address(RVA = "0x2739A00", Offset = "0x2738000", VA = "0x182739A00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EFD")]
			[Address(RVA = "0x32F98E0", Offset = "0x32F7EE0", VA = "0x1832F98E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06001EFE RID: 7934 RVA: 0x00008E08 File Offset: 0x00007008
		// (set) Token: 0x06001EFF RID: 7935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000451")]
		public bool BlockDrop
		{
			[Token(Token = "0x6001EFE")]
			[Address(RVA = "0x2A22CA0", Offset = "0x2A212A0", VA = "0x182A22CA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EFF")]
			[Address(RVA = "0x2F7D290", Offset = "0x2F7B890", VA = "0x182F7D290")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06001F00 RID: 7936 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F01 RID: 7937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000452")]
		public string PendingSendMessage
		{
			[Token(Token = "0x6001F00")]
			[Address(RVA = "0x784A30", Offset = "0x783030", VA = "0x180784A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F01")]
			[Address(RVA = "0x784A40", Offset = "0x783040", VA = "0x180784A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06001F02 RID: 7938 RVA: 0x00008E20 File Offset: 0x00007020
		[Token(Token = "0x17000453")]
		public float WeaponChargeStartTime
		{
			[Token(Token = "0x6001F02")]
			[Address(RVA = "0x69B280", Offset = "0x699880", VA = "0x18069B280")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001F03 RID: 7939 RVA: 0x00008E38 File Offset: 0x00007038
		[Token(Token = "0x17000454")]
		public bool IsThrowing
		{
			[Token(Token = "0x6001F03")]
			[Address(RVA = "0x28068F0", Offset = "0x2804EF0", VA = "0x1828068F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001F04 RID: 7940 RVA: 0x00008E50 File Offset: 0x00007050
		// (set) Token: 0x06001F05 RID: 7941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000455")]
		public bool blockRangedAttack
		{
			[Token(Token = "0x6001F04")]
			[Address(RVA = "0x32F98F0", Offset = "0x32F7EF0", VA = "0x1832F98F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001F05")]
			[Address(RVA = "0x32F9900", Offset = "0x32F7F00", VA = "0x1832F9900")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06001F06 RID: 7942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000456")]
		public List<int> VitalItemsThatCantBeLost
		{
			[Token(Token = "0x6001F06")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001F07 RID: 7943 RVA: 0x00008E68 File Offset: 0x00007068
		[Token(Token = "0x17000457")]
		public PlayerInventory.PlayerViews CurrentView
		{
			[Token(Token = "0x6001F07")]
			[Address(RVA = "0xAFF2D0", Offset = "0xAFD8D0", VA = "0x180AFF2D0")]
			get
			{
				return PlayerInventory.PlayerViews.Loading;
			}
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F08")]
		[Address(RVA = "0x32F9910", Offset = "0x32F7F10", VA = "0x1832F9910")]
		public void SetCurrentView(PlayerInventory.PlayerViews value)
		{
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F09")]
		[Address(RVA = "0x32F9A40", Offset = "0x32F8040", VA = "0x1832F9A40")]
		private void UpdatePlayerStimuli(PlayerInventory.PlayerViews currentView)
		{
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F0A")]
		[Address(RVA = "0x32F9AF0", Offset = "0x32F80F0", VA = "0x1832F9AF0")]
		private static void UpdateCoopPlayerState(PlayerInventory.PlayerViews value)
		{
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F0B")]
		[Address(RVA = "0x32F9CD0", Offset = "0x32F82D0", VA = "0x1832F9CD0")]
		private void Awake()
		{
		}

		// Token: 0x06001F0C RID: 7948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F0C")]
		[Address(RVA = "0x32F9E30", Offset = "0x32F8430", VA = "0x1832F9E30")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F0D")]
		[Address(RVA = "0x32F9E90", Offset = "0x32F8490", VA = "0x1832F9E90")]
		public void Start()
		{
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F0E")]
		[Address(RVA = "0x32F9F30", Offset = "0x32F8530", VA = "0x1832F9F30")]
		private void Update()
		{
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F0F")]
		[Address(RVA = "0x32FA110", Offset = "0x32F8710", VA = "0x1832FA110")]
		public PlayerState GetPlayerState()
		{
			return null;
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F10")]
		[Address(RVA = "0x32FA250", Offset = "0x32F8850", VA = "0x1832FA250")]
		private void OnEnable()
		{
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F11")]
		[Address(RVA = "0x32FB980", Offset = "0x32F9F80", VA = "0x1832FB980")]
		private void OnDisable()
		{
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F12")]
		[Address(RVA = "0x32FD0A0", Offset = "0x32FB6A0", VA = "0x1832FD0A0", Slot = "4")]
		public void ReceiveItems(IEnumerable<ItemAndRange> itemsAndRanges)
		{
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F13")]
		[Address(RVA = "0x32FD2E0", Offset = "0x32FB8E0", VA = "0x1832FD2E0")]
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00008E80 File Offset: 0x00007080
		[Token(Token = "0x6001F14")]
		[Address(RVA = "0x32FD400", Offset = "0x32FBA00", VA = "0x1832FD400")]
		public bool IsInventoryToggleBlocked()
		{
			return default(bool);
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F15")]
		[Address(RVA = "0x32FD6A0", Offset = "0x32FBCA0", VA = "0x1832FD6A0")]
		private void OpenQuickSelectCallback(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F16")]
		[Address(RVA = "0x32FD980", Offset = "0x32FBF80", VA = "0x1832FD980")]
		private void ToggleInventoryCallback(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F17")]
		[Address(RVA = "0x32FDC10", Offset = "0x32FC210", VA = "0x1832FDC10")]
		public void Open()
		{
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F18")]
		[Address(RVA = "0x32FDE50", Offset = "0x32FC450", VA = "0x1832FDE50")]
		public void Close(bool forceClose = false)
		{
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x00008E98 File Offset: 0x00007098
		[Token(Token = "0x6001F19")]
		[Address(RVA = "0x32FE070", Offset = "0x32FC670", VA = "0x1832FE070")]
		public bool AddItem(int itemId, int amount = 1, bool preventAutoEquip = false, bool wasCrafted = false, [Optional] ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x00008EB0 File Offset: 0x000070B0
		[Token(Token = "0x6001F1A")]
		[Address(RVA = "0x32FEA90", Offset = "0x32FD090", VA = "0x1832FEA90")]
		public bool HasFirstEquippedItemBefore(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F1B")]
		[Address(RVA = "0x32FEB40", Offset = "0x32FD140", VA = "0x1832FEB40")]
		public void RemoveAllItems()
		{
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x00008EC8 File Offset: 0x000070C8
		[Token(Token = "0x6001F1C")]
		[Address(RVA = "0x32FED50", Offset = "0x32FD350", VA = "0x1832FED50")]
		public bool RemoveItem(int itemId, int amount = 1, bool allowAmountOverflow = false, bool shouldEquipPrevious = true, bool removeFromQuickSelect = true, [Optional] ItemInstance itemInstance, bool instantDestroy = false)
		{
			return default(bool);
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F1D")]
		[Address(RVA = "0x32FF130", Offset = "0x32FD730", VA = "0x1832FF130")]
		private string GetIsNewItemInInventoryKey(int itemId)
		{
			return null;
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x00008EE0 File Offset: 0x000070E0
		[Token(Token = "0x6001F1E")]
		[Address(RVA = "0x32FF190", Offset = "0x32FD790", VA = "0x1832FF190")]
		public bool GetIsNewItemInInventory(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F1F")]
		[Address(RVA = "0x32FF240", Offset = "0x32FD840", VA = "0x1832FF240")]
		public void SetIsNewItemInInventory(int itemId, bool isNew)
		{
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x00008EF8 File Offset: 0x000070F8
		[Token(Token = "0x6001F20")]
		[Address(RVA = "0x32FF2E0", Offset = "0x32FD8E0", VA = "0x1832FF2E0")]
		public bool Owns(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F21")]
		[Address(RVA = "0x32FF340", Offset = "0x32FD940", VA = "0x1832FF340")]
		public ItemInstance GetItemInstanceOfType(int itemId)
		{
			return null;
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F22")]
		[Address(RVA = "0x32FF360", Offset = "0x32FD960", VA = "0x1832FF360")]
		public List<ItemInstance> GetItemInstancesOfType(int itemId)
		{
			return null;
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x00008F10 File Offset: 0x00007110
		[Token(Token = "0x6001F23")]
		[Address(RVA = "0x32FF380", Offset = "0x32FD980", VA = "0x1832FF380")]
		public int AmountOf(int itemId, bool includeEquipped = true)
		{
			return 0;
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x00008F28 File Offset: 0x00007128
		[Token(Token = "0x6001F24")]
		[Address(RVA = "0x32FF520", Offset = "0x32FDB20", VA = "0x1832FF520")]
		public bool HasRoomFor(int itemId, int amount = 1)
		{
			return default(bool);
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x00008F40 File Offset: 0x00007140
		[Token(Token = "0x6001F25")]
		[Address(RVA = "0x32FF580", Offset = "0x32FDB80", VA = "0x1832FF580")]
		public int GetMaxAmountOf(int itemId)
		{
			return 0;
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x00008F58 File Offset: 0x00007158
		[Token(Token = "0x6001F26")]
		[Address(RVA = "0x32FF5B0", Offset = "0x32FDBB0", VA = "0x1832FF5B0")]
		public int GetAvailableSpaceForItem(int itemId)
		{
			return 0;
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F27")]
		[Address(RVA = "0x32FF610", Offset = "0x32FDC10", VA = "0x1832FF610")]
		public void GotClay([Optional] int? amount)
		{
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F28")]
		[Address(RVA = "0x32FF6D0", Offset = "0x32FDCD0", VA = "0x1832FF6D0")]
		public void DropFakeItem(int itemId)
		{
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F29")]
		[Address(RVA = "0x32FF700", Offset = "0x32FDD00", VA = "0x1832FF700")]
		public void DropItem(ItemInstance item, bool fakeDrop = false)
		{
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F2A")]
		[Address(RVA = "0x32FF760", Offset = "0x32FDD60", VA = "0x1832FF760")]
		public void DropItemFromInventory(int itemId, out GameObject outResultingItem)
		{
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F2B")]
		[Address(RVA = "0x32FF830", Offset = "0x32FDE30", VA = "0x1832FF830")]
		public void DropHeldOnlyItem(ItemInstance itemInstance, GameObject preSpawned)
		{
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F2C")]
		[Address(RVA = "0x32FF920", Offset = "0x32FDF20", VA = "0x1832FF920")]
		private static void DropItemInternal(int itemId, ItemInstance item, bool fakeDrop, out GameObject resultingItem)
		{
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F2D")]
		[Address(RVA = "0x3300680", Offset = "0x32FEC80", VA = "0x183300680")]
		private static void ApplyRandomForce(Rigidbody pickUpRigidbody, Vector3 sourceForward)
		{
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F2E")]
		[Address(RVA = "0x3300910", Offset = "0x32FEF10", VA = "0x183300910")]
		public void RefreshItemCache()
		{
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F2F")]
		[Address(RVA = "0x3300C40", Offset = "0x32FF240", VA = "0x183300C40")]
		public InventoryProps.PropDefinition GetPropDefinitionForItem(int itemId, [Optional] EquipmentSlot? slot)
		{
			return null;
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F30")]
		[Address(RVA = "0x3300C70", Offset = "0x32FF270", VA = "0x183300C70")]
		public void CheckForNewCraftingRecipeNotification()
		{
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F31")]
		[Address(RVA = "0x3301430", Offset = "0x32FFA30", VA = "0x183301430")]
		public void ClearNewCraftingRecipeTutorials()
		{
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F32")]
		[Address(RVA = "0x3301550", Offset = "0x32FFB50", VA = "0x183301550")]
		public void SetLastLightItemUsed(int itemId)
		{
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06001F33 RID: 7987 RVA: 0x00008F70 File Offset: 0x00007170
		[Token(Token = "0x17000458")]
		public bool SuppressFirstLookAts
		{
			[Token(Token = "0x6001F33")]
			[Address(RVA = "0x30AECB0", Offset = "0x30AD2B0", VA = "0x1830AECB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F34")]
		[Address(RVA = "0x3301590", Offset = "0x32FFB90", VA = "0x183301590")]
		public void SetSuppressFirstLookAts(bool value)
		{
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06001F35 RID: 7989 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F36 RID: 7990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000459")]
		private ItemInstance PreviousLeftHandItem
		{
			[Token(Token = "0x6001F35")]
			[Address(RVA = "0x33015A0", Offset = "0x32FFBA0", VA = "0x1833015A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F36")]
			[Address(RVA = "0x33015D0", Offset = "0x32FFBD0", VA = "0x1833015D0")]
			set
			{
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06001F37 RID: 7991 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F38 RID: 7992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045A")]
		private ItemInstance PreviousRightHandItem
		{
			[Token(Token = "0x6001F37")]
			[Address(RVA = "0x3301640", Offset = "0x32FFC40", VA = "0x183301640")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F38")]
			[Address(RVA = "0x3301670", Offset = "0x32FFC70", VA = "0x183301670")]
			set
			{
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06001F39 RID: 7993 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F3A RID: 7994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045B")]
		private ItemInstance PreviousChestItem
		{
			[Token(Token = "0x6001F39")]
			[Address(RVA = "0x33016D0", Offset = "0x32FFCD0", VA = "0x1833016D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F3A")]
			[Address(RVA = "0x3301700", Offset = "0x32FFD00", VA = "0x183301700")]
			set
			{
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06001F3B RID: 7995 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F3C RID: 7996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045C")]
		private ItemInstance PreviousFeetItem
		{
			[Token(Token = "0x6001F3B")]
			[Address(RVA = "0x3301770", Offset = "0x32FFD70", VA = "0x183301770")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F3C")]
			[Address(RVA = "0x33017A0", Offset = "0x32FFDA0", VA = "0x1833017A0")]
			set
			{
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06001F3D RID: 7997 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F3E RID: 7998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045D")]
		private ItemInstance PreviousEyesItem
		{
			[Token(Token = "0x6001F3D")]
			[Address(RVA = "0x3301810", Offset = "0x32FFE10", VA = "0x183301810")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F3E")]
			[Address(RVA = "0x3301840", Offset = "0x32FFE40", VA = "0x183301840")]
			set
			{
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06001F3F RID: 7999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045E")]
		public ItemInstance LeftHandItem
		{
			[Token(Token = "0x6001F3F")]
			[Address(RVA = "0x33018B0", Offset = "0x32FFEB0", VA = "0x1833018B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06001F40 RID: 8000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045F")]
		public ItemInstance RightHandItem
		{
			[Token(Token = "0x6001F40")]
			[Address(RVA = "0x33018E0", Offset = "0x32FFEE0", VA = "0x1833018E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001F41 RID: 8001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000460")]
		public ItemInstance EquippedChestItem
		{
			[Token(Token = "0x6001F41")]
			[Address(RVA = "0x3301910", Offset = "0x32FFF10", VA = "0x183301910")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001F42 RID: 8002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000461")]
		public ItemInstance EquippedFeetItem
		{
			[Token(Token = "0x6001F42")]
			[Address(RVA = "0x3301940", Offset = "0x32FFF40", VA = "0x183301940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001F43 RID: 8003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000462")]
		public ItemInstance EquippedEyesItem
		{
			[Token(Token = "0x6001F43")]
			[Address(RVA = "0x3301970", Offset = "0x32FFF70", VA = "0x183301970")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001F44 RID: 8004 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F45 RID: 8005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000463")]
		public LogController Logs
		{
			[Token(Token = "0x6001F44")]
			[Address(RVA = "0x2A3B6F0", Offset = "0x2A39CF0", VA = "0x182A3B6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F45")]
			[Address(RVA = "0x2F77E40", Offset = "0x2F76440", VA = "0x182F77E40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001F46 RID: 8006 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F47 RID: 8007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000464")]
		public IHeldOnlyItemController HeldOnlyItemController
		{
			[Token(Token = "0x6001F46")]
			[Address(RVA = "0x120B640", Offset = "0x1209C40", VA = "0x18120B640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F47")]
			[Address(RVA = "0x120B650", Offset = "0x1209C50", VA = "0x18120B650")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06001F48 RID: 8008 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001F49 RID: 8009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000013")]
		public event Action OnStashHeldItems
		{
			[Token(Token = "0x6001F48")]
			[Address(RVA = "0x33019A0", Offset = "0x32FFFA0", VA = "0x1833019A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001F49")]
			[Address(RVA = "0x3301A90", Offset = "0x3300090", VA = "0x183301A90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F4A")]
		[Address(RVA = "0x3301B80", Offset = "0x3300180", VA = "0x183301B80")]
		private void AwakeEquipment()
		{
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F4B")]
		[Address(RVA = "0x3301F90", Offset = "0x3300590", VA = "0x183301F90")]
		public void ForgetAllStashedItems()
		{
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F4C")]
		[Address(RVA = "0x33020D0", Offset = "0x33006D0", VA = "0x1833020D0")]
		public void ForgetPreviousItemInSlot(EquipmentSlot slot)
		{
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F4D")]
		[Address(RVA = "0x3302100", Offset = "0x3300700", VA = "0x183302100")]
		private void Update_Equipment()
		{
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x00008F88 File Offset: 0x00007188
		[Token(Token = "0x6001F4E")]
		[Address(RVA = "0x33024F0", Offset = "0x3300AF0", VA = "0x1833024F0")]
		public bool TryEquip(int itemId, bool pickedUpFromWorld, bool memorizePrevious = true)
		{
			return default(bool);
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x00008FA0 File Offset: 0x000071A0
		[Token(Token = "0x6001F4F")]
		[Address(RVA = "0x33025E0", Offset = "0x3300BE0", VA = "0x1833025E0")]
		public bool TryEquip(ItemInstance itemInstance, bool pickedUpFromWorld, bool memorizePrevious = true, [Optional] EquipmentSlot? slotOverride, bool skipCreateItemObject = false)
		{
			return default(bool);
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F50")]
		[Address(RVA = "0x3302BC0", Offset = "0x33011C0", VA = "0x183302BC0")]
		private IEnumerator EquipSequence(EquipmentSlot slot, bool memorizePrevious, ItemInstance itemInstance, InventoryProps.PropDefinition propDefinition, bool skipCreateItemObject = false)
		{
			return null;
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F51")]
		[Address(RVA = "0x3302D40", Offset = "0x3301340", VA = "0x183302D40")]
		public void UnequipItemAtSlot(EquipmentSlot slot, bool drop, bool stash, bool equipPrevious, bool instantDestroy = false, bool skipDestroyItemObject = false, bool mpIgnoreCallback = false)
		{
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F52")]
		[Address(RVA = "0x33033F0", Offset = "0x33019F0", VA = "0x1833033F0")]
		public void ThrowRightHandItem(int itemId)
		{
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F53")]
		[Address(RVA = "0x3303480", Offset = "0x3301A80", VA = "0x183303480")]
		private IEnumerator EquipPreviousHeld(EquipmentSlot equipmentSlot)
		{
			return null;
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F54")]
		[Address(RVA = "0x3303540", Offset = "0x3301B40", VA = "0x183303540")]
		public void MemorizeHeldItems()
		{
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F55")]
		[Address(RVA = "0x3303570", Offset = "0x3301B70", VA = "0x183303570")]
		public void MemorizeEquippedSlot(EquipmentSlot slot)
		{
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F56")]
		[Address(RVA = "0x33036A0", Offset = "0x3301CA0", VA = "0x1833036A0")]
		public void EquipPreviouslyHeldItems()
		{
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F57")]
		[Address(RVA = "0x33036D0", Offset = "0x3301CD0", VA = "0x1833036D0")]
		public void EquipPreviousLeftHandItem(bool keepPrevious = false)
		{
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F58")]
		[Address(RVA = "0x33037D0", Offset = "0x3301DD0", VA = "0x1833037D0")]
		public void EquipPreviousRightHandItem(bool allowInInventory = false)
		{
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F59")]
		[Address(RVA = "0x3303A00", Offset = "0x3302000", VA = "0x183303A00")]
		public void EquipPreviousChestItem(bool keepPrevious = false)
		{
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F5A")]
		[Address(RVA = "0x3303B00", Offset = "0x3302100", VA = "0x183303B00")]
		public void DropRightHandItem(bool equipPrevious)
		{
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F5B")]
		[Address(RVA = "0x3303BC0", Offset = "0x33021C0", VA = "0x183303BC0")]
		public void StashRightHandItem(bool equipPrevious, bool memorizeItem = false, bool instantaneous = false)
		{
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F5C")]
		[Address(RVA = "0x3303CE0", Offset = "0x33022E0", VA = "0x183303CE0")]
		public void StashLeftHandItem(bool memorizeItem = false, bool instantaneous = false)
		{
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F5D")]
		[Address(RVA = "0x3303D60", Offset = "0x3302360", VA = "0x183303D60")]
		public void StashHeldItems(bool memorize = true, bool instantaneous = false)
		{
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x00008FB8 File Offset: 0x000071B8
		[Token(Token = "0x6001F5E")]
		[Address(RVA = "0x3303DD0", Offset = "0x33023D0", VA = "0x183303DD0")]
		public bool TryGetEquipped(int itemId, out ItemInstance outItemInstance)
		{
			return default(bool);
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x00008FD0 File Offset: 0x000071D0
		[Token(Token = "0x6001F5F")]
		[Address(RVA = "0x3303FD0", Offset = "0x33025D0", VA = "0x183303FD0")]
		public bool IsSlotEmpty(EquipmentSlot slot)
		{
			return default(bool);
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x00008FE8 File Offset: 0x000071E8
		[Token(Token = "0x6001F60")]
		[Address(RVA = "0x3304010", Offset = "0x3302610", VA = "0x183304010")]
		public bool IsSlotNextEmpty(EquipmentSlot slot)
		{
			return default(bool);
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x00009000 File Offset: 0x00007200
		[Token(Token = "0x6001F61")]
		[Address(RVA = "0x3304060", Offset = "0x3302660", VA = "0x183304060")]
		public bool IsSlotAndNextSlotEmpty(EquipmentSlot slot)
		{
			return default(bool);
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x00009018 File Offset: 0x00007218
		[Token(Token = "0x6001F62")]
		[Address(RVA = "0x33040D0", Offset = "0x33026D0", VA = "0x1833040D0")]
		public bool IsRightHandEmpty()
		{
			return default(bool);
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x00009030 File Offset: 0x00007230
		[Token(Token = "0x6001F63")]
		[Address(RVA = "0x3304150", Offset = "0x3302750", VA = "0x183304150")]
		public bool IsRightHandHolding(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x00009048 File Offset: 0x00007248
		[Token(Token = "0x6001F64")]
		[Address(RVA = "0x33041A0", Offset = "0x33027A0", VA = "0x1833041A0")]
		public bool IsLeftHandEmpty()
		{
			return default(bool);
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x00009060 File Offset: 0x00007260
		[Token(Token = "0x6001F65")]
		[Address(RVA = "0x33041D0", Offset = "0x33027D0", VA = "0x1833041D0")]
		public bool IsLeftHandHolding(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x00009078 File Offset: 0x00007278
		[Token(Token = "0x6001F66")]
		[Address(RVA = "0x3304220", Offset = "0x3302820", VA = "0x183304220")]
		public bool HasInSlot(EquipmentSlot slot, int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x00009090 File Offset: 0x00007290
		[Token(Token = "0x6001F67")]
		[Address(RVA = "0x3304380", Offset = "0x3302980", VA = "0x183304380")]
		public bool HasInPreviousSlot(EquipmentSlot slot, int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x000090A8 File Offset: 0x000072A8
		[Token(Token = "0x6001F68")]
		[Address(RVA = "0x33044E0", Offset = "0x3302AE0", VA = "0x1833044E0")]
		public bool HasInNextSlot(EquipmentSlot slot, int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x000090C0 File Offset: 0x000072C0
		[Token(Token = "0x6001F69")]
		[Address(RVA = "0x3304640", Offset = "0x3302C40", VA = "0x183304640")]
		public bool HasInSlotOrNextSlot(EquipmentSlot slot, int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x000090D8 File Offset: 0x000072D8
		[Token(Token = "0x6001F6A")]
		[Address(RVA = "0x33047F0", Offset = "0x3302DF0", VA = "0x1833047F0")]
		public bool TryGetItemInSlot(EquipmentSlot slot, out ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F6B")]
		[Address(RVA = "0x3304870", Offset = "0x3302E70", VA = "0x183304870")]
		private void CycleUtility(InputAction.CallbackContext c)
		{
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F6C")]
		[Address(RVA = "0x3304AA0", Offset = "0x33030A0", VA = "0x183304AA0")]
		private void ToggleGpsTracker(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F6D")]
		[Address(RVA = "0x3304AB0", Offset = "0x33030B0", VA = "0x183304AB0")]
		public void ToggleBook(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F6E")]
		[Address(RVA = "0x3304D10", Offset = "0x3303310", VA = "0x183304D10")]
		public void CloseBook(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F6F")]
		[Address(RVA = "0x3304EB0", Offset = "0x33034B0", VA = "0x183304EB0")]
		private void ToggleVoiceChat(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F70")]
		[Address(RVA = "0x3304F10", Offset = "0x3303510", VA = "0x183304F10")]
		private void ToggleLeftHandLight(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x000090F0 File Offset: 0x000072F0
		[Token(Token = "0x6001F71")]
		[Address(RVA = "0x3305070", Offset = "0x3303670", VA = "0x183305070")]
		private bool ToggleLeftHandItem(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F72")]
		[Address(RVA = "0x3305370", Offset = "0x3303970", VA = "0x183305370")]
		public void RestartLeftHandWait()
		{
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x00009108 File Offset: 0x00007308
		[Token(Token = "0x6001F73")]
		[Address(RVA = "0x3305380", Offset = "0x3303980", VA = "0x183305380")]
		public bool CanEquipItemInLeftHand(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F74")]
		[Address(RVA = "0x33055C0", Offset = "0x3303BC0", VA = "0x1833055C0")]
		private void ToggleRightHandItem(int itemId)
		{
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F75")]
		[Address(RVA = "0x3305740", Offset = "0x3303D40", VA = "0x183305740")]
		public void RestartRightHandWait()
		{
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x00009120 File Offset: 0x00007320
		[Token(Token = "0x6001F76")]
		[Address(RVA = "0x3305750", Offset = "0x3303D50", VA = "0x183305750")]
		public bool CanEquipItemInRightHand(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F77")]
		[Address(RVA = "0x33058B0", Offset = "0x3303EB0", VA = "0x1833058B0")]
		public void BloodyWeapon()
		{
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F78")]
		[Address(RVA = "0x3305A10", Offset = "0x3304010", VA = "0x183305A10")]
		public void CleanWeapon()
		{
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F79")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void LockEquipmentSlot(EquipmentSlot slot)
		{
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F7A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void UnlockEquipmentSlot(EquipmentSlot slot)
		{
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x00009138 File Offset: 0x00007338
		[Token(Token = "0x6001F7B")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70")]
		public bool IsSlotLocked(EquipmentSlot slot)
		{
			return default(bool);
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F7C")]
		[Address(RVA = "0x3305B70", Offset = "0x3304170", VA = "0x183305B70")]
		public void DelayAttackReset()
		{
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F7D")]
		[Address(RVA = "0x3305EC0", Offset = "0x33044C0", VA = "0x183305EC0")]
		private void OnArmourEquipped(ArmourPiece armourPiece, WearableSlots slot)
		{
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F7E")]
		[Address(RVA = "0x3305F00", Offset = "0x3304500", VA = "0x183305F00")]
		private void OnArmourUnequipped(ArmourPiece armourPiece, WearableSlots slot)
		{
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F7F")]
		[Address(RVA = "0x3305FA0", Offset = "0x33045A0", VA = "0x183305FA0")]
		private void OnArmourBroken(ArmourPiece armourPiece, WearableSlots slot)
		{
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F80")]
		[Address(RVA = "0x2EFF450", Offset = "0x2EFDA50", VA = "0x182EFF450")]
		public IReadOnlyDictionary<int, ItemInstanceManager.Items> GetAllItems()
		{
			return null;
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F81")]
		[Address(RVA = "0x3305FE0", Offset = "0x33045E0", VA = "0x183305FE0")]
		public void RemoveAllItemsOnDeath()
		{
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F82")]
		[Address(RVA = "0x33064D0", Offset = "0x3304AD0", VA = "0x1833064D0")]
		public void CacheProjectileItemInstance(int id, ItemInstance itemInstance)
		{
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x00009150 File Offset: 0x00007350
		[Token(Token = "0x6001F83")]
		[Address(RVA = "0x3306550", Offset = "0x3304B50", VA = "0x183306550")]
		public bool TryRetrieveProjectileItemInstance(int id, out ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F84")]
		[Address(RVA = "0x33065C0", Offset = "0x3304BC0", VA = "0x1833065C0")]
		public void EquipItemAsProp(int itemId, out ItemInstance itemInstance, out GameObject heldInstance, out Animator heldAnimator, [Optional] EquipmentSlot? forceSlot, bool dummyProp = false)
		{
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F85")]
		[Address(RVA = "0x33066B0", Offset = "0x3304CB0", VA = "0x1833066B0")]
		public void EquipItemAsProp(ItemInstance itemInstance, out GameObject heldInstance, out Animator heldAnimator, [Optional] EquipmentSlot? forceSlot, bool dummyProp = false)
		{
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x00009168 File Offset: 0x00007368
		[Token(Token = "0x6001F86")]
		[Address(RVA = "0x33068E0", Offset = "0x3304EE0", VA = "0x1833068E0")]
		public bool TryRemoveProp(ref GameObject propGameObject, int itemId, bool forceDelete = true)
		{
			return default(bool);
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x00009180 File Offset: 0x00007380
		[Token(Token = "0x6001F87")]
		[Address(RVA = "0x3306A90", Offset = "0x3305090", VA = "0x183306A90")]
		public bool TryTransferToSlotEquip(ItemInstance itemInstance, EquipmentSlot currentSlot, EquipmentSlot newSlot, bool memorizePrevious)
		{
			return default(bool);
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001F88 RID: 8072 RVA: 0x00009198 File Offset: 0x00007398
		// (set) Token: 0x06001F89 RID: 8073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000465")]
		public bool IsInQuickSelect
		{
			[Token(Token = "0x6001F88")]
			[Address(RVA = "0x26413E0", Offset = "0x263F9E0", VA = "0x1826413E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001F89")]
			[Address(RVA = "0x3306D70", Offset = "0x3305370", VA = "0x183306D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F8A")]
		[Address(RVA = "0x3306D80", Offset = "0x3305380", VA = "0x183306D80")]
		public void SetQuickSelectContext(bool enable)
		{
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x000091B0 File Offset: 0x000073B0
		[Token(Token = "0x6001F8B")]
		[Address(RVA = "0x3306DC0", Offset = "0x33053C0", VA = "0x183306DC0")]
		public bool IsItemInAQuickSlot(ItemData itemData)
		{
			return default(bool);
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F8C")]
		[Address(RVA = "0x3306DF0", Offset = "0x33053F0", VA = "0x183306DF0")]
		public void GetQuickSlotItems(out List<int> ids)
		{
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x000091C8 File Offset: 0x000073C8
		[Token(Token = "0x6001F8D")]
		[Address(RVA = "0x3307040", Offset = "0x3305640", VA = "0x183307040")]
		public bool IsItemInAQuickSlot(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x000091E0 File Offset: 0x000073E0
		[Token(Token = "0x6001F8E")]
		[Address(RVA = "0x3307100", Offset = "0x3305700", VA = "0x183307100")]
		public bool TryAddItemToQuickSlot(ItemData itemData, bool replaceIfSlotsFull)
		{
			return default(bool);
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F8F")]
		[Address(RVA = "0x33075B0", Offset = "0x3305BB0", VA = "0x1833075B0")]
		private void ClearItemFromQuickSlotList(int itemId)
		{
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x000091F8 File Offset: 0x000073F8
		[Token(Token = "0x6001F90")]
		[Address(RVA = "0x33076D0", Offset = "0x3305CD0", VA = "0x1833076D0")]
		public bool TryRemoveItemFromQuickSlot(ItemData itemData)
		{
			return default(bool);
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06001F91 RID: 8081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000466")]
		public string SerializedName
		{
			[Token(Token = "0x6001F91")]
			[Address(RVA = "0x33079C0", Offset = "0x3305FC0", VA = "0x1833079C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06001F92 RID: 8082 RVA: 0x00009210 File Offset: 0x00007410
		[Token(Token = "0x17000467")]
		private bool UniqueFile
		{
			[Token(Token = "0x6001F92")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001F93 RID: 8083 RVA: 0x00009228 File Offset: 0x00007428
		[Token(Token = "0x17000468")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x6001F93")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001F94 RID: 8084 RVA: 0x00009240 File Offset: 0x00007440
		[Token(Token = "0x17000469")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6001F94")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F95")]
		[Address(RVA = "0x33079F0", Offset = "0x3305FF0", VA = "0x1833079F0", Slot = "6")]
		private PlayerInventory.PlayerInventorySaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F96")]
		[Address(RVA = "0x3308070", Offset = "0x3306670", VA = "0x183308070", Slot = "7")]
		private void OnDeserialize(PlayerInventory.PlayerInventorySaveData data)
		{
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x00009258 File Offset: 0x00007458
		[Token(Token = "0x6001F97")]
		[Address(RVA = "0x3308BE0", Offset = "0x33071E0", VA = "0x183308BE0")]
		private int GetLoadSlotCount(PlayerInventory.PlayerInventorySaveData data)
		{
			return 0;
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F98")]
		[Address(RVA = "0x3308D90", Offset = "0x3307390", VA = "0x183308D90")]
		public static void SanityCheckItems(ItemInstanceManager itemInstanceManager)
		{
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F99")]
		[Address(RVA = "0x33096A0", Offset = "0x3307CA0", VA = "0x1833096A0")]
		public PlayerInventory()
		{
		}

		// Token: 0x04001CBA RID: 7354
		[Token(Token = "0x4001CBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InventoryCutscene _inventoryCutscene;

		// Token: 0x04001CBB RID: 7355
		[Token(Token = "0x4001CBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<InventoryItem> _possessedItems;

		// Token: 0x04001CBC RID: 7356
		[Token(Token = "0x4001CBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[ItemIdPicker(true)]
		[SerializeField]
		private List<int> _vitalItemsThatCantBeLost;

		// Token: 0x04001CBD RID: 7357
		[Token(Token = "0x4001CBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<InventoryItem> _multiplayerPossessedItems;

		// Token: 0x04001CBE RID: 7358
		[Token(Token = "0x4001CBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CraftingRecipeDatabase _craftingRecipeDatabase;

		// Token: 0x04001CBF RID: 7359
		[Token(Token = "0x4001CBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject _specialActions;

		// Token: 0x04001CC0 RID: 7360
		[Token(Token = "0x4001CC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[ItemIdPicker]
		[SerializeField]
		public int _clayItemId;

		// Token: 0x04001CC1 RID: 7361
		[Token(Token = "0x4001CC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		private ItemInstanceManager _itemInstanceManager;

		// Token: 0x04001CC2 RID: 7362
		[Token(Token = "0x4001CC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[SerializeField]
		private List<int> _itemsThatHaveBeenInspected;

		// Token: 0x04001CC3 RID: 7363
		[Token(Token = "0x4001CC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public UnityEvent<ItemInstance, int> OnItemAddedEvent;

		// Token: 0x04001CC4 RID: 7364
		[Token(Token = "0x4001CC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public UnityEvent<ItemInstance, int> OnItemRemovedEvent;

		// Token: 0x04001CC5 RID: 7365
		[Token(Token = "0x4001CC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public UnityEvent<ItemInstance, int> OnItemEquippedEvent;

		// Token: 0x04001CC6 RID: 7366
		[Token(Token = "0x4001CC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public UnityEvent<ItemInstance, int> OnItemUnequippedEvent;

		// Token: 0x04001CC7 RID: 7367
		[Token(Token = "0x4001CC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private PlayerInventory.PlayerViews _currentView;

		// Token: 0x04001CC8 RID: 7368
		[Token(Token = "0x4001CC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private EventInstance _pauseSnapshot;

		// Token: 0x04001CC9 RID: 7369
		[Token(Token = "0x4001CC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private PlayerState _playerState;

		// Token: 0x04001CCA RID: 7370
		[Token(Token = "0x4001CCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _upgradeCountersCount;

		// Token: 0x04001CCB RID: 7371
		[Token(Token = "0x4001CCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int _newRecipesInInventory;

		// Token: 0x04001CCC RID: 7372
		[Token(Token = "0x4001CCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Action<bool> OnRightHandItemLit;

		// Token: 0x04001CCD RID: 7373
		[Token(Token = "0x4001CCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Action<int, EquipmentSlot, EquipmentSlot> OnItemTransferredToSlot;

		// Token: 0x04001CCE RID: 7374
		[Token(Token = "0x4001CCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ItemInstance _hoveredItem;

		// Token: 0x04001CDA RID: 7386
		[Token(Token = "0x4001CDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[ItemIdPicker(true)]
		private int _lastLeftHandLightItemUsed;

		// Token: 0x04001CDB RID: 7387
		[Token(Token = "0x4001CDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[ItemIdPicker(Types.Equippable, false)]
		[SerializeField]
		public int _defaultWeaponItemId;

		// Token: 0x04001CDC RID: 7388
		[Token(Token = "0x4001CDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public UnityEvent AttackEnded;

		// Token: 0x04001CDD RID: 7389
		[Token(Token = "0x4001CDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private ItemInstance[] _equipmentSlots;

		// Token: 0x04001CDE RID: 7390
		[Token(Token = "0x4001CDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int[] _equipmentSlotsIds;

		// Token: 0x04001CDF RID: 7391
		[Token(Token = "0x4001CDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private ItemInstance[] _equipmentSlotsNext;

		// Token: 0x04001CE0 RID: 7392
		[Token(Token = "0x4001CE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private ItemInstance[] _equipmentSlotsPrevious;

		// Token: 0x04001CE1 RID: 7393
		[Token(Token = "0x4001CE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Dictionary<int, ItemInstance> _projectileItemInstances;

		// Token: 0x04001CE2 RID: 7394
		[Token(Token = "0x4001CE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private bool _suppressFirstLookAts;

		// Token: 0x04001CE3 RID: 7395
		[Token(Token = "0x4001CE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private float _timeUntilNextAllowedToggleLeftHand;

		// Token: 0x04001CE4 RID: 7396
		[Token(Token = "0x4001CE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private float _timeUntilNextAllowedToggleRightHand;

		// Token: 0x04001CE5 RID: 7397
		[Token(Token = "0x4001CE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private float _timeToWaitBetweenLeftHandToggle;

		// Token: 0x04001CE6 RID: 7398
		[Token(Token = "0x4001CE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private float _timeToWaitBetweenRightHandToggle;

		// Token: 0x04001CE7 RID: 7399
		[Token(Token = "0x4001CE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private PlayerStructurePlaceAction _playerStructurePlaceAction;

		// Token: 0x04001CE8 RID: 7400
		[Token(Token = "0x4001CE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Coroutine _equipSequenceRight;

		// Token: 0x04001CEC RID: 7404
		[Token(Token = "0x4001CEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private PlayerInventory.HandEquipState _currentEquipState;

		// Token: 0x04001CED RID: 7405
		[Token(Token = "0x4001CED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private string ScrewBookLastUsedKey;

		// Token: 0x04001CEE RID: 7406
		[Token(Token = "0x4001CEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[SerializeField]
		private List<PlayerInventory.QuickSlot> _quickSlots;

		// Token: 0x020004A9 RID: 1193
		[Token(Token = "0x20004A9")]
		public enum PlayerViews
		{
			// Token: 0x04001CF1 RID: 7409
			[Token(Token = "0x4001CF1")]
			PlaneCrash = -1,
			// Token: 0x04001CF2 RID: 7410
			[Token(Token = "0x4001CF2")]
			Loading,
			// Token: 0x04001CF3 RID: 7411
			[Token(Token = "0x4001CF3")]
			WakingUp,
			// Token: 0x04001CF4 RID: 7412
			[Token(Token = "0x4001CF4")]
			World,
			// Token: 0x04001CF5 RID: 7413
			[Token(Token = "0x4001CF5")]
			Inventory,
			// Token: 0x04001CF6 RID: 7414
			[Token(Token = "0x4001CF6")]
			ClosingInventory,
			// Token: 0x04001CF7 RID: 7415
			[Token(Token = "0x4001CF7")]
			GrabBag,
			// Token: 0x04001CF8 RID: 7416
			[Token(Token = "0x4001CF8")]
			Pause,
			// Token: 0x04001CF9 RID: 7417
			[Token(Token = "0x4001CF9")]
			Death,
			// Token: 0x04001CFA RID: 7418
			[Token(Token = "0x4001CFA")]
			Loot,
			// Token: 0x04001CFB RID: 7419
			[Token(Token = "0x4001CFB")]
			Sleep,
			// Token: 0x04001CFC RID: 7420
			[Token(Token = "0x4001CFC")]
			Hidden,
			// Token: 0x04001CFD RID: 7421
			[Token(Token = "0x4001CFD")]
			PlayerList,
			// Token: 0x04001CFE RID: 7422
			[Token(Token = "0x4001CFE")]
			EndDeactivate
		}

		// Token: 0x020004AA RID: 1194
		[Token(Token = "0x20004AA")]
		private enum HandEquipState
		{
			// Token: 0x04001D00 RID: 7424
			[Token(Token = "0x4001D00")]
			Equipping,
			// Token: 0x04001D01 RID: 7425
			[Token(Token = "0x4001D01")]
			StashCancelEquip,
			// Token: 0x04001D02 RID: 7426
			[Token(Token = "0x4001D02")]
			Idle
		}

		// Token: 0x020004AB RID: 1195
		[Token(Token = "0x20004AB")]
		[Serializable]
		public class QuickSlot
		{
			// Token: 0x1700046A RID: 1130
			// (get) Token: 0x06001F9A RID: 8090 RVA: 0x00009270 File Offset: 0x00007470
			[Token(Token = "0x1700046A")]
			public float Age
			{
				[Token(Token = "0x6001F9A")]
				[Address(RVA = "0x9FA1C0", Offset = "0x9F87C0", VA = "0x1809FA1C0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700046B RID: 1131
			// (get) Token: 0x06001F9B RID: 8091 RVA: 0x00009288 File Offset: 0x00007488
			[Token(Token = "0x1700046B")]
			public ItemData.QuickSelectSlotTypes Type
			{
				[Token(Token = "0x6001F9B")]
				[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
				get
				{
					return ItemData.QuickSelectSlotTypes.Small;
				}
			}

			// Token: 0x1700046C RID: 1132
			// (get) Token: 0x06001F9C RID: 8092 RVA: 0x000092A0 File Offset: 0x000074A0
			[Token(Token = "0x1700046C")]
			public int ItemId
			{
				[Token(Token = "0x6001F9C")]
				[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700046D RID: 1133
			// (get) Token: 0x06001F9D RID: 8093 RVA: 0x000092B8 File Offset: 0x000074B8
			[Token(Token = "0x1700046D")]
			public bool IsEmpty
			{
				[Token(Token = "0x6001F9D")]
				[Address(RVA = "0x218C660", Offset = "0x218AC60", VA = "0x18218C660")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06001F9E RID: 8094 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F9E")]
			[Address(RVA = "0x3309CA0", Offset = "0x33082A0", VA = "0x183309CA0")]
			public void SetItemId(int itemId, float age = -1f)
			{
			}

			// Token: 0x06001F9F RID: 8095 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F9F")]
			[Address(RVA = "0x3309D10", Offset = "0x3308310", VA = "0x183309D10")]
			public QuickSlot()
			{
			}

			// Token: 0x04001D03 RID: 7427
			[Token(Token = "0x4001D03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private ItemData.QuickSelectSlotTypes _type;

			// Token: 0x04001D04 RID: 7428
			[Token(Token = "0x4001D04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[ItemIdPicker(true)]
			[SerializeField]
			private int _itemId;

			// Token: 0x04001D05 RID: 7429
			[Token(Token = "0x4001D05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private float _age;
		}

		// Token: 0x020004AC RID: 1196
		[Token(Token = "0x20004AC")]
		[Serializable]
		internal class QuickSelectSaveData
		{
			// Token: 0x06001FA0 RID: 8096 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001FA0")]
			[Address(RVA = "0x3309D20", Offset = "0x3308320", VA = "0x183309D20")]
			public QuickSelectSaveData()
			{
			}

			// Token: 0x04001D06 RID: 7430
			[Token(Token = "0x4001D06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Version;

			// Token: 0x04001D07 RID: 7431
			[Token(Token = "0x4001D07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<PlayerInventory.QuickSelectSaveData.QuickSlotSaveData> Slots;

			// Token: 0x020004AD RID: 1197
			[Token(Token = "0x20004AD")]
			public class QuickSlotSaveData
			{
				// Token: 0x06001FA1 RID: 8097 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6001FA1")]
				[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
				public QuickSlotSaveData()
				{
				}

				// Token: 0x04001D08 RID: 7432
				[Token(Token = "0x4001D08")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public int ItemId;

				// Token: 0x04001D09 RID: 7433
				[Token(Token = "0x4001D09")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public float Age;
			}
		}

		// Token: 0x020004AE RID: 1198
		[Token(Token = "0x20004AE")]
		[Serializable]
		internal class PlayerInventorySaveData
		{
			// Token: 0x06001FA2 RID: 8098 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001FA2")]
			[Address(RVA = "0x3309E50", Offset = "0x3308450", VA = "0x183309E50")]
			public PlayerInventorySaveData()
			{
			}

			// Token: 0x04001D0A RID: 7434
			[Token(Token = "0x4001D0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Version;

			// Token: 0x04001D0B RID: 7435
			[Token(Token = "0x4001D0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PlayerInventory.QuickSelectSaveData QuickSelect;

			// Token: 0x04001D0C RID: 7436
			[Token(Token = "0x4001D0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<PlayerInventory.PlayerInventorySaveData.EquippedItem> EquippedItems;

			// Token: 0x04001D0D RID: 7437
			[Token(Token = "0x4001D0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ItemInstanceManager.ItemInstanceManagerSaveData ItemInstanceManagerData;

			// Token: 0x020004AF RID: 1199
			[Token(Token = "0x20004AF")]
			[Serializable]
			public class EquippedItem
			{
				// Token: 0x06001FA3 RID: 8099 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6001FA3")]
				[Address(RVA = "0x3309F80", Offset = "0x3308580", VA = "0x183309F80")]
				public EquippedItem()
				{
				}

				// Token: 0x04001D0E RID: 7438
				[Token(Token = "0x4001D0E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public int ItemId;

				// Token: 0x04001D0F RID: 7439
				[Token(Token = "0x4001D0F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public List<ItemInstanceModule.SaveData> Modules;
			}
		}
	}
}
