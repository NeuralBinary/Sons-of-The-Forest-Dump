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
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

namespace TheForest.Items.Inventory
{
	// Token: 0x020004B2 RID: 1202
	[Token(Token = "0x20004B2")]
	[AddComponentMenu("Items/Inventory/PlayerInventory")]
	public class PlayerInventory : MonoBehaviour, IReceiveItems, ISaveGameSerializer<PlayerInventory.PlayerInventorySaveData>
	{
		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001E9B RID: 7835 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E9C RID: 7836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043E")]
		public InventoryProps InventoryProps
		{
			[Token(Token = "0x6001E9B")]
			[Address(RVA = "0x8C25D0", Offset = "0x8C15D0", VA = "0x1808C25D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E9C")]
			[Address(RVA = "0x1157B80", Offset = "0x1156B80", VA = "0x181157B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001E9D RID: 7837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700043F")]
		public InventoryCameraController CameraController
		{
			[Token(Token = "0x6001E9D")]
			[Address(RVA = "0x2D20940", Offset = "0x2D1F940", VA = "0x182D20940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001E9E RID: 7838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000440")]
		public PlayerState PlayerState
		{
			[Token(Token = "0x6001E9E")]
			[Address(RVA = "0x582960", Offset = "0x581960", VA = "0x180582960")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06001E9F RID: 7839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000441")]
		public GameObject SpecialActions
		{
			[Token(Token = "0x6001E9F")]
			[Address(RVA = "0x52F1A0", Offset = "0x52E1A0", VA = "0x18052F1A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06001EA0 RID: 7840 RVA: 0x00008A90 File Offset: 0x00006C90
		// (set) Token: 0x06001EA1 RID: 7841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000442")]
		public bool BlockTogglingInventory
		{
			[Token(Token = "0x6001EA0")]
			[Address(RVA = "0x22E9840", Offset = "0x22E8840", VA = "0x1822E9840")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EA1")]
			[Address(RVA = "0x2D20B90", Offset = "0x2D1FB90", VA = "0x182D20B90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06001EA2 RID: 7842 RVA: 0x00008AA8 File Offset: 0x00006CA8
		// (set) Token: 0x06001EA3 RID: 7843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000443")]
		public bool IsWeaponBurning
		{
			[Token(Token = "0x6001EA2")]
			[Address(RVA = "0x2560470", Offset = "0x255F470", VA = "0x182560470")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EA3")]
			[Address(RVA = "0x2D20BC0", Offset = "0x2D1FBC0", VA = "0x182D20BC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06001EA4 RID: 7844 RVA: 0x00008AC0 File Offset: 0x00006CC0
		// (set) Token: 0x06001EA5 RID: 7845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000444")]
		public bool CancelNextChargedAttack
		{
			[Token(Token = "0x6001EA4")]
			[Address(RVA = "0x2D20960", Offset = "0x2D1F960", VA = "0x182D20960")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EA5")]
			[Address(RVA = "0x2D20BA0", Offset = "0x2D1FBA0", VA = "0x182D20BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06001EA6 RID: 7846 RVA: 0x00008AD8 File Offset: 0x00006CD8
		// (set) Token: 0x06001EA7 RID: 7847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000445")]
		public bool SkipNextAddItemWoosh
		{
			[Token(Token = "0x6001EA6")]
			[Address(RVA = "0x2D20AC0", Offset = "0x2D1FAC0", VA = "0x182D20AC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EA7")]
			[Address(RVA = "0x2D20D20", Offset = "0x2D1FD20", VA = "0x182D20D20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06001EA8 RID: 7848 RVA: 0x00008AF0 File Offset: 0x00006CF0
		// (set) Token: 0x06001EA9 RID: 7849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000446")]
		public bool DontShowDrop
		{
			[Token(Token = "0x6001EA8")]
			[Address(RVA = "0x255EC60", Offset = "0x255DC60", VA = "0x18255EC60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EA9")]
			[Address(RVA = "0x2D20BB0", Offset = "0x2D1FBB0", VA = "0x182D20BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001EAA RID: 7850 RVA: 0x00008B08 File Offset: 0x00006D08
		// (set) Token: 0x06001EAB RID: 7851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000447")]
		public bool BlockDrop
		{
			[Token(Token = "0x6001EAA")]
			[Address(RVA = "0x255EB50", Offset = "0x255DB50", VA = "0x18255EB50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EAB")]
			[Address(RVA = "0x2D20B80", Offset = "0x2D1FB80", VA = "0x182D20B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001EAC RID: 7852 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EAD RID: 7853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000448")]
		public string PendingSendMessage
		{
			[Token(Token = "0x6001EAC")]
			[Address(RVA = "0x7CCBE0", Offset = "0x7CBBE0", VA = "0x1807CCBE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EAD")]
			[Address(RVA = "0x7CCBF0", Offset = "0x7CBBF0", VA = "0x1807CCBF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001EAE RID: 7854 RVA: 0x00008B20 File Offset: 0x00006D20
		[Token(Token = "0x17000449")]
		public float WeaponChargeStartTime
		{
			[Token(Token = "0x6001EAE")]
			[Address(RVA = "0x22E9880", Offset = "0x22E8880", VA = "0x1822E9880")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06001EAF RID: 7855 RVA: 0x00008B38 File Offset: 0x00006D38
		[Token(Token = "0x1700044A")]
		public bool IsThrowing
		{
			[Token(Token = "0x6001EAF")]
			[Address(RVA = "0x22E9820", Offset = "0x22E8820", VA = "0x1822E9820")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x00008B50 File Offset: 0x00006D50
		// (set) Token: 0x06001EB1 RID: 7857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044B")]
		public bool blockRangedAttack
		{
			[Token(Token = "0x6001EB0")]
			[Address(RVA = "0x2558720", Offset = "0x2557720", VA = "0x182558720")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EB1")]
			[Address(RVA = "0x29AD2F0", Offset = "0x29AC2F0", VA = "0x1829AD2F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x00008B68 File Offset: 0x00006D68
		[Token(Token = "0x1700044C")]
		public PlayerInventory.PlayerViews CurrentView
		{
			[Token(Token = "0x6001EB2")]
			[Address(RVA = "0x986680", Offset = "0x985680", VA = "0x180986680")]
			get
			{
				return PlayerInventory.PlayerViews.Loading;
			}
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EB3")]
		[Address(RVA = "0x2D1CE70", Offset = "0x2D1BE70", VA = "0x182D1CE70")]
		public void SetCurrentView(PlayerInventory.PlayerViews value)
		{
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EB4")]
		[Address(RVA = "0x2D20170", Offset = "0x2D1F170", VA = "0x182D20170")]
		private void UpdatePlayerStimuli(PlayerInventory.PlayerViews currentView)
		{
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EB5")]
		[Address(RVA = "0x2D1FFF0", Offset = "0x2D1EFF0", VA = "0x182D1FFF0")]
		private static void UpdateCoopPlayerState(PlayerInventory.PlayerViews value)
		{
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EB6")]
		[Address(RVA = "0x2D16810", Offset = "0x2D15810", VA = "0x182D16810")]
		private void Awake()
		{
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EB7")]
		[Address(RVA = "0x2D1A070", Offset = "0x2D19070", VA = "0x182D1A070")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EB8")]
		[Address(RVA = "0x2D1DD70", Offset = "0x2D1CD70", VA = "0x182D1DD70")]
		public void Start()
		{
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EB9")]
		[Address(RVA = "0x2D20470", Offset = "0x2D1F470", VA = "0x182D20470")]
		private void Update()
		{
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EBA")]
		[Address(RVA = "0x2D18E80", Offset = "0x2D17E80", VA = "0x182D18E80")]
		public PlayerState GetPlayerState()
		{
			return null;
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBB")]
		[Address(RVA = "0x2D1AF40", Offset = "0x2D19F40", VA = "0x182D1AF40")]
		private void OnEnable()
		{
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBC")]
		[Address(RVA = "0x2D1A0D0", Offset = "0x2D190D0", VA = "0x182D1A0D0")]
		private void OnDisable()
		{
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBD")]
		[Address(RVA = "0x2D1C200", Offset = "0x2D1B200", VA = "0x182D1C200", Slot = "4")]
		public void ReceiveItems(IEnumerable<ItemAndRange> itemsAndRanges)
		{
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBE")]
		[Address(RVA = "0x2D1BE10", Offset = "0x2D1AE10", VA = "0x182D1BE10")]
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x00008B80 File Offset: 0x00006D80
		[Token(Token = "0x6001EBF")]
		[Address(RVA = "0x2D19780", Offset = "0x2D18780", VA = "0x182D19780")]
		public bool IsInventoryToggleBlocked()
		{
			return default(bool);
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC0")]
		[Address(RVA = "0x2D1BEA0", Offset = "0x2D1AEA0", VA = "0x182D1BEA0")]
		private void OpenQuickSelectCallback(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC1")]
		[Address(RVA = "0x2D1E1F0", Offset = "0x2D1D1F0", VA = "0x182D1E1F0")]
		private void ToggleInventoryCallback(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC2")]
		[Address(RVA = "0x2D1C100", Offset = "0x2D1B100", VA = "0x182D1C100")]
		public void Open()
		{
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC3")]
		[Address(RVA = "0x2D17420", Offset = "0x2D16420", VA = "0x182D17420")]
		public void Close(bool forceClose = false)
		{
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x00008B98 File Offset: 0x00006D98
		[Token(Token = "0x6001EC4")]
		[Address(RVA = "0x2D15B30", Offset = "0x2D14B30", VA = "0x182D15B30")]
		public bool AddItem(int itemId, int amount = 1, bool preventAutoEquip = false, bool wasCrafted = false, [Optional] ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x00008BB0 File Offset: 0x00006DB0
		[Token(Token = "0x6001EC5")]
		[Address(RVA = "0x2D19240", Offset = "0x2D18240", VA = "0x182D19240")]
		public bool HasFirstEquippedItemBefore(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC6")]
		[Address(RVA = "0x2D1C910", Offset = "0x2D1B910", VA = "0x182D1C910")]
		public void RemoveAllItems()
		{
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x00008BC8 File Offset: 0x00006DC8
		[Token(Token = "0x6001EC7")]
		[Address(RVA = "0x2D1CAD0", Offset = "0x2D1BAD0", VA = "0x182D1CAD0")]
		public bool RemoveItem(int itemId, int amount = 1, bool allowAmountOverflow = false, bool shouldEquipPrevious = true, bool removeFromQuickSelect = true, [Optional] ItemInstance itemInstance, bool instantDestroy = false)
		{
			return default(bool);
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC8")]
		[Address(RVA = "0x2D18D20", Offset = "0x2D17D20", VA = "0x182D18D20")]
		private string GetIsNewItemInInventoryKey(int itemId)
		{
			return null;
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x00008BE0 File Offset: 0x00006DE0
		[Token(Token = "0x6001EC9")]
		[Address(RVA = "0x2D18D80", Offset = "0x2D17D80", VA = "0x182D18D80")]
		public bool GetIsNewItemInInventory(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ECA")]
		[Address(RVA = "0x2D1D0F0", Offset = "0x2D1C0F0", VA = "0x182D1D0F0")]
		public void SetIsNewItemInInventory(int itemId, bool isNew)
		{
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x00008BF8 File Offset: 0x00006DF8
		[Token(Token = "0x6001ECB")]
		[Address(RVA = "0x2D1C1B0", Offset = "0x2D1B1B0", VA = "0x182D1C1B0")]
		public bool Owns(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ECC")]
		[Address(RVA = "0x2D18E10", Offset = "0x2D17E10", VA = "0x182D18E10")]
		public ItemInstance GetItemInstanceOfType(int itemId)
		{
			return null;
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ECD")]
		[Address(RVA = "0x2D18E30", Offset = "0x2D17E30", VA = "0x182D18E30")]
		public List<ItemInstance> GetItemInstancesOfType(int itemId)
		{
			return null;
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x00008C10 File Offset: 0x00006E10
		[Token(Token = "0x6001ECE")]
		[Address(RVA = "0x2D16450", Offset = "0x2D15450", VA = "0x182D16450")]
		public int AmountOf(int itemId, bool includeEquipped = true)
		{
			return default(int);
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x00008C28 File Offset: 0x00006E28
		[Token(Token = "0x6001ECF")]
		[Address(RVA = "0x2D19720", Offset = "0x2D18720", VA = "0x182D19720")]
		public bool HasRoomFor(int itemId, int amount = 1)
		{
			return default(bool);
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x00008C40 File Offset: 0x00006E40
		[Token(Token = "0x6001ED0")]
		[Address(RVA = "0x2D18E50", Offset = "0x2D17E50", VA = "0x182D18E50")]
		public int GetMaxAmountOf(int itemId)
		{
			return default(int);
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x00008C58 File Offset: 0x00006E58
		[Token(Token = "0x6001ED1")]
		[Address(RVA = "0x2D18CC0", Offset = "0x2D17CC0", VA = "0x182D18CC0")]
		public int GetAvailableSpaceForItem(int itemId)
		{
			return default(int);
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED2")]
		[Address(RVA = "0x2D191B0", Offset = "0x2D181B0", VA = "0x182D191B0")]
		public void GotClay([Optional] int? amount)
		{
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED3")]
		[Address(RVA = "0x2D17A30", Offset = "0x2D16A30", VA = "0x182D17A30")]
		public void DropFakeItem(int itemId)
		{
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED4")]
		[Address(RVA = "0x2D182B0", Offset = "0x2D172B0", VA = "0x182D182B0")]
		public void DropItem(ItemInstance item, bool fakeDrop = false)
		{
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED5")]
		[Address(RVA = "0x2D17B60", Offset = "0x2D16B60", VA = "0x182D17B60")]
		public void DropItemFromInventory(int itemId, out GameObject outResultingItem)
		{
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED6")]
		[Address(RVA = "0x2D17A60", Offset = "0x2D16A60", VA = "0x182D17A60")]
		public void DropHeldOnlyItem(ItemInstance itemInstance, GameObject preSpawned)
		{
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED7")]
		[Address(RVA = "0x2D17BF0", Offset = "0x2D16BF0", VA = "0x182D17BF0")]
		private static void DropItemInternal(int itemId, ItemInstance item, bool fakeDrop, out GameObject resultingItem)
		{
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED8")]
		[Address(RVA = "0x2D1C400", Offset = "0x2D1B400", VA = "0x182D1C400")]
		public void RefreshItemCache()
		{
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED9")]
		[Address(RVA = "0x2D18F30", Offset = "0x2D17F30", VA = "0x182D18F30")]
		public InventoryProps.PropDefinition GetPropDefinitionForItem(int itemId)
		{
			return null;
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EDA")]
		[Address(RVA = "0x2D16A50", Offset = "0x2D15A50", VA = "0x182D16A50")]
		public void CheckForNewCraftingRecipeNotification()
		{
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EDB")]
		[Address(RVA = "0x2D17200", Offset = "0x2D16200", VA = "0x182D17200")]
		public void ClearNewCraftingRecipeTutorials()
		{
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001EDC RID: 7900 RVA: 0x00008C70 File Offset: 0x00006E70
		[Token(Token = "0x1700044D")]
		public bool SuppressFirstLookAts
		{
			[Token(Token = "0x6001EDC")]
			[Address(RVA = "0x2D20AD0", Offset = "0x2D1FAD0", VA = "0x182D20AD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EDD")]
		[Address(RVA = "0x2D1D1D0", Offset = "0x2D1C1D0", VA = "0x182D1D1D0")]
		public void SetSuppressFirstLookAts(bool value)
		{
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06001EDE RID: 7902 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EDF RID: 7903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044E")]
		private ItemInstance PreviousLeftHandItem
		{
			[Token(Token = "0x6001EDE")]
			[Address(RVA = "0x2D20A00", Offset = "0x2D1FA00", VA = "0x182D20A00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EDF")]
			[Address(RVA = "0x2D20C40", Offset = "0x2D1FC40", VA = "0x182D20C40")]
			set
			{
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06001EE0 RID: 7904 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EE1 RID: 7905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044F")]
		private ItemInstance PreviousRightHandItem
		{
			[Token(Token = "0x6001EE0")]
			[Address(RVA = "0x2D20A30", Offset = "0x2D1FA30", VA = "0x182D20A30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EE1")]
			[Address(RVA = "0x2D20CB0", Offset = "0x2D1FCB0", VA = "0x182D20CB0")]
			set
			{
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06001EE2 RID: 7906 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EE3 RID: 7907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000450")]
		private ItemInstance PreviousChestItem
		{
			[Token(Token = "0x6001EE2")]
			[Address(RVA = "0x2D209D0", Offset = "0x2D1F9D0", VA = "0x182D209D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EE3")]
			[Address(RVA = "0x2D20BD0", Offset = "0x2D1FBD0", VA = "0x182D20BD0")]
			set
			{
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06001EE4 RID: 7908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000451")]
		public ItemInstance LeftHandItem
		{
			[Token(Token = "0x6001EE4")]
			[Address(RVA = "0x2D209A0", Offset = "0x2D1F9A0", VA = "0x182D209A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06001EE5 RID: 7909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000452")]
		public ItemInstance RightHandItem
		{
			[Token(Token = "0x6001EE5")]
			[Address(RVA = "0x2D20A60", Offset = "0x2D1FA60", VA = "0x182D20A60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06001EE6 RID: 7910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000453")]
		public ItemInstance EquippedChestItem
		{
			[Token(Token = "0x6001EE6")]
			[Address(RVA = "0x2D20970", Offset = "0x2D1F970", VA = "0x182D20970")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001EE7 RID: 7911 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EE8 RID: 7912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000454")]
		public LogController Logs
		{
			[Token(Token = "0x6001EE7")]
			[Address(RVA = "0x217F670", Offset = "0x217E670", VA = "0x18217F670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EE8")]
			[Address(RVA = "0x2284D10", Offset = "0x2283D10", VA = "0x182284D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001EE9 RID: 7913 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EEA RID: 7914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000455")]
		public IHeldOnlyItemController HeldOnlyItemController
		{
			[Token(Token = "0x6001EE9")]
			[Address(RVA = "0x59F640", Offset = "0x59E640", VA = "0x18059F640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EEA")]
			[Address(RVA = "0x59F9F0", Offset = "0x59E9F0", VA = "0x18059F9F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06001EEB RID: 7915 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001EEC RID: 7916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000010")]
		public event Action OnStashHeldItems
		{
			[Token(Token = "0x6001EEB")]
			[Address(RVA = "0x2D208A0", Offset = "0x2D1F8A0", VA = "0x182D208A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001EEC")]
			[Address(RVA = "0x2D20AE0", Offset = "0x2D1FAE0", VA = "0x182D20AE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EED")]
		[Address(RVA = "0x2D16640", Offset = "0x2D15640", VA = "0x182D16640")]
		private void AwakeEquipment()
		{
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EEE")]
		[Address(RVA = "0x2D18BE0", Offset = "0x2D17BE0", VA = "0x182D18BE0")]
		public void ForgetAllStashedItems()
		{
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EEF")]
		[Address(RVA = "0x2D20220", Offset = "0x2D1F220", VA = "0x182D20220")]
		private void Update_Equipment()
		{
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x00008C88 File Offset: 0x00006E88
		[Token(Token = "0x6001EF0")]
		[Address(RVA = "0x2D1F050", Offset = "0x2D1E050", VA = "0x182D1F050")]
		public bool TryEquip(int itemId, bool pickedUpFromWorld, bool memorizePrevious = true)
		{
			return default(bool);
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x00008CA0 File Offset: 0x00006EA0
		[Token(Token = "0x6001EF1")]
		[Address(RVA = "0x2D1F150", Offset = "0x2D1E150", VA = "0x182D1F150")]
		public bool TryEquip(ItemInstance itemInstance, bool pickedUpFromWorld, bool memorizePrevious = true)
		{
			return default(bool);
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EF2")]
		[Address(RVA = "0x2D18B20", Offset = "0x2D17B20", VA = "0x182D18B20")]
		private IEnumerator EquipSequence(EquipmentSlot slot, bool memorizePrevious, ItemInstance itemInstance, InventoryProps.PropDefinition propDefinition)
		{
			return null;
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF3")]
		[Address(RVA = "0x2D1FA70", Offset = "0x2D1EA70", VA = "0x182D1FA70")]
		public void UnequipItemAtSlot(EquipmentSlot slot, bool drop, bool stash, bool equipPrevious, bool instantDestroy = false)
		{
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF4")]
		[Address(RVA = "0x2D1E0B0", Offset = "0x2D1D0B0", VA = "0x182D1E0B0")]
		public void ThrowRightHandItem(int itemId)
		{
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EF5")]
		[Address(RVA = "0x2D18780", Offset = "0x2D17780", VA = "0x182D18780")]
		private IEnumerator EquipPreviousHeld(EquipmentSlot equipmentSlot)
		{
			return null;
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF6")]
		[Address(RVA = "0x2D19F50", Offset = "0x2D18F50", VA = "0x182D19F50")]
		public void MemorizeHeldItems()
		{
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF7")]
		[Address(RVA = "0x2D19E20", Offset = "0x2D18E20", VA = "0x182D19E20")]
		public void MemorizeEquippedSlot(EquipmentSlot slot)
		{
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF8")]
		[Address(RVA = "0x2D18A80", Offset = "0x2D17A80", VA = "0x182D18A80")]
		public void EquipPreviouslyHeldItems()
		{
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF9")]
		[Address(RVA = "0x2D18800", Offset = "0x2D17800", VA = "0x182D18800")]
		public void EquipPreviousLeftHandItem(bool keepPrevious = false)
		{
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFA")]
		[Address(RVA = "0x2D188A0", Offset = "0x2D178A0", VA = "0x182D188A0")]
		public void EquipPreviousRightHandItem(bool allowInInventory = false)
		{
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFB")]
		[Address(RVA = "0x2D186E0", Offset = "0x2D176E0", VA = "0x182D186E0")]
		public void EquipPreviousChestItem(bool keepPrevious = false)
		{
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFC")]
		[Address(RVA = "0x2D18310", Offset = "0x2D17310", VA = "0x182D18310")]
		public void DropRightHandItem(bool equipPrevious)
		{
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFD")]
		[Address(RVA = "0x2D1DF20", Offset = "0x2D1CF20", VA = "0x182D1DF20")]
		public void StashRightHandItem(bool equipPrevious, bool memorizeItem = false, bool instantaneous = false)
		{
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFE")]
		[Address(RVA = "0x2D1DEA0", Offset = "0x2D1CEA0", VA = "0x182D1DEA0")]
		public void StashLeftHandItem(bool memorizeItem = false, bool instantaneous = false)
		{
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFF")]
		[Address(RVA = "0x2D1DDE0", Offset = "0x2D1CDE0", VA = "0x182D1DDE0")]
		public void StashHeldItems(bool memorize = true, bool instantaneous = false)
		{
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x00008CB8 File Offset: 0x00006EB8
		[Token(Token = "0x6001F00")]
		[Address(RVA = "0x2D1F560", Offset = "0x2D1E560", VA = "0x182D1F560")]
		public bool TryGetEquipped(int itemId, out ItemInstance outItemInstance)
		{
			return default(bool);
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x00008CD0 File Offset: 0x00006ED0
		[Token(Token = "0x6001F01")]
		[Address(RVA = "0x2D19D90", Offset = "0x2D18D90", VA = "0x182D19D90")]
		public bool IsSlotEmpty(EquipmentSlot slot)
		{
			return default(bool);
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x00008CE8 File Offset: 0x00006EE8
		[Token(Token = "0x6001F02")]
		[Address(RVA = "0x2D19DD0", Offset = "0x2D18DD0", VA = "0x182D19DD0")]
		public bool IsSlotNextEmpty(EquipmentSlot slot)
		{
			return default(bool);
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x00008D00 File Offset: 0x00006F00
		[Token(Token = "0x6001F03")]
		[Address(RVA = "0x2D19D20", Offset = "0x2D18D20", VA = "0x182D19D20")]
		public bool IsSlotAndNextSlotEmpty(EquipmentSlot slot)
		{
			return default(bool);
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x00008D18 File Offset: 0x00006F18
		[Token(Token = "0x6001F04")]
		[Address(RVA = "0x2D19C50", Offset = "0x2D18C50", VA = "0x182D19C50")]
		public bool IsRightHandEmpty()
		{
			return default(bool);
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x00008D30 File Offset: 0x00006F30
		[Token(Token = "0x6001F05")]
		[Address(RVA = "0x2D19CD0", Offset = "0x2D18CD0", VA = "0x182D19CD0")]
		public bool IsRightHandHolding(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x00008D48 File Offset: 0x00006F48
		[Token(Token = "0x6001F06")]
		[Address(RVA = "0x2D19BD0", Offset = "0x2D18BD0", VA = "0x182D19BD0")]
		public bool IsLeftHandEmpty()
		{
			return default(bool);
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x00008D60 File Offset: 0x00006F60
		[Token(Token = "0x6001F07")]
		[Address(RVA = "0x2D19C00", Offset = "0x2D18C00", VA = "0x182D19C00")]
		public bool IsLeftHandHolding(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x00008D78 File Offset: 0x00006F78
		[Token(Token = "0x6001F08")]
		[Address(RVA = "0x2D19620", Offset = "0x2D18620", VA = "0x182D19620")]
		public bool HasInSlot(EquipmentSlot slot, int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x00008D90 File Offset: 0x00006F90
		[Token(Token = "0x6001F09")]
		[Address(RVA = "0x2D193D0", Offset = "0x2D183D0", VA = "0x182D193D0")]
		public bool HasInPreviousSlot(EquipmentSlot slot, int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x00008DA8 File Offset: 0x00006FA8
		[Token(Token = "0x6001F0A")]
		[Address(RVA = "0x2D192D0", Offset = "0x2D182D0", VA = "0x182D192D0")]
		public bool HasInNextSlot(EquipmentSlot slot, int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x00008DC0 File Offset: 0x00006FC0
		[Token(Token = "0x6001F0B")]
		[Address(RVA = "0x2D194D0", Offset = "0x2D184D0", VA = "0x182D194D0")]
		public bool HasInSlotOrNextSlot(EquipmentSlot slot, int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001F0C RID: 7948 RVA: 0x00008DD8 File Offset: 0x00006FD8
		[Token(Token = "0x6001F0C")]
		[Address(RVA = "0x2D1F730", Offset = "0x2D1E730", VA = "0x182D1F730")]
		public bool TryGetItemInSlot(EquipmentSlot slot, out ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F0D")]
		[Address(RVA = "0x2D17660", Offset = "0x2D16660", VA = "0x182D17660")]
		private void CycleUtility(InputAction.CallbackContext c)
		{
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F0E")]
		[Address(RVA = "0x2D1E1E0", Offset = "0x2D1D1E0", VA = "0x182D1E1E0")]
		private void ToggleGpsTracker(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F0F")]
		[Address(RVA = "0x2D1E140", Offset = "0x2D1D140", VA = "0x182D1E140")]
		public void ToggleBook(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F10")]
		[Address(RVA = "0x2D17290", Offset = "0x2D16290", VA = "0x182D17290")]
		public void CloseBook(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F11")]
		[Address(RVA = "0x2D1EB80", Offset = "0x2D1DB80", VA = "0x182D1EB80")]
		private void ToggleVoiceChat(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F12")]
		[Address(RVA = "0x2D1E920", Offset = "0x2D1D920", VA = "0x182D1E920")]
		private void ToggleLeftHandLight(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x00008DF0 File Offset: 0x00006FF0
		[Token(Token = "0x6001F13")]
		[Address(RVA = "0x2D1E510", Offset = "0x2D1D510", VA = "0x182D1E510")]
		private bool ToggleLeftHandItem(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F14")]
		[Address(RVA = "0x2D1E9A0", Offset = "0x2D1D9A0", VA = "0x182D1E9A0")]
		private void ToggleRightHandItem(int itemId)
		{
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F15")]
		[Address(RVA = "0x2D16900", Offset = "0x2D15900", VA = "0x182D16900")]
		public void BloodyWeapon()
		{
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F16")]
		[Address(RVA = "0x2D17000", Offset = "0x2D16000", VA = "0x182D17000")]
		public void CleanWeapon()
		{
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F17")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void LockEquipmentSlot(EquipmentSlot slot)
		{
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F18")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void UnlockEquipmentSlot(EquipmentSlot slot)
		{
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x00008E08 File Offset: 0x00007008
		[Token(Token = "0x6001F19")]
		[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0")]
		public bool IsSlotLocked(EquipmentSlot slot)
		{
			return default(bool);
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F1A")]
		[Address(RVA = "0x2D17860", Offset = "0x2D16860", VA = "0x182D17860")]
		public void DelayAttackReset()
		{
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F1B")]
		[Address(RVA = "0x2D19FC0", Offset = "0x2D18FC0", VA = "0x182D19FC0")]
		private void OnArmourEquipped(ArmourPiece armourPiece, WearableSlots slot)
		{
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F1C")]
		[Address(RVA = "0x2D1A000", Offset = "0x2D19000", VA = "0x182D1A000")]
		private void OnArmourUnequipped(ArmourPiece armourPiece, WearableSlots slot)
		{
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F1D")]
		[Address(RVA = "0x2D19F80", Offset = "0x2D18F80", VA = "0x182D19F80")]
		private void OnArmourBroken(ArmourPiece armourPiece, WearableSlots slot)
		{
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F1E")]
		[Address(RVA = "0x2D18CA0", Offset = "0x2D17CA0", VA = "0x182D18CA0")]
		public IReadOnlyDictionary<int, ItemInstanceManager.Items> GetAllItems()
		{
			return null;
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F1F")]
		[Address(RVA = "0x2D1C690", Offset = "0x2D1B690", VA = "0x182D1C690")]
		public void RemoveAllItemsOnDeath()
		{
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F20")]
		[Address(RVA = "0x2D169E0", Offset = "0x2D159E0", VA = "0x182D169E0")]
		public void CacheProjectileItemInstance(int id, ItemInstance itemInstance)
		{
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x00008E20 File Offset: 0x00007020
		[Token(Token = "0x6001F21")]
		[Address(RVA = "0x2D1FA00", Offset = "0x2D1EA00", VA = "0x182D1FA00")]
		public bool TryRetrieveProjectileItemInstance(int id, out ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F22")]
		[Address(RVA = "0x2D18520", Offset = "0x2D17520", VA = "0x182D18520")]
		public void EquipItemAsProp(int itemId, out ItemInstance itemInstance, out GameObject heldInstance, out Animator heldAnimator, [Optional] EquipmentSlot? forceSlot, bool dummyProp = false)
		{
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F23")]
		[Address(RVA = "0x2D183B0", Offset = "0x2D173B0", VA = "0x182D183B0")]
		public void EquipItemAsProp(ItemInstance itemInstance, out GameObject heldInstance, out Animator heldAnimator, [Optional] EquipmentSlot? forceSlot, bool dummyProp = false)
		{
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06001F24 RID: 7972 RVA: 0x00008E38 File Offset: 0x00007038
		// (set) Token: 0x06001F25 RID: 7973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000456")]
		public bool IsInQuickSelect
		{
			[Token(Token = "0x6001F24")]
			[Address(RVA = "0x2CBDBC0", Offset = "0x2CBCBC0", VA = "0x182CBDBC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001F25")]
			[Address(RVA = "0x2CBDCF0", Offset = "0x2CBCCF0", VA = "0x182CBDCF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F26")]
		[Address(RVA = "0x2D1D190", Offset = "0x2D1C190", VA = "0x182D1D190")]
		public void SetQuickSelectContext(bool enable)
		{
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x00008E50 File Offset: 0x00007050
		[Token(Token = "0x6001F27")]
		[Address(RVA = "0x2D19A10", Offset = "0x2D18A10", VA = "0x182D19A10")]
		public bool IsItemInAQuickSlot(ItemData itemData)
		{
			return default(bool);
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F28")]
		[Address(RVA = "0x2D19010", Offset = "0x2D18010", VA = "0x182D19010")]
		public void GetQuickSlotItems(out List<int> ids)
		{
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x00008E68 File Offset: 0x00007068
		[Token(Token = "0x6001F29")]
		[Address(RVA = "0x2D19B00", Offset = "0x2D18B00", VA = "0x182D19B00")]
		public bool IsItemInAQuickSlot(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x00008E80 File Offset: 0x00007080
		[Token(Token = "0x6001F2A")]
		[Address(RVA = "0x2D1EBE0", Offset = "0x2D1DBE0", VA = "0x182D1EBE0")]
		public bool TryAddItemToQuickSlot(ItemData itemData, bool replaceIfSlotsFull)
		{
			return default(bool);
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F2B")]
		[Address(RVA = "0x2D170E0", Offset = "0x2D160E0", VA = "0x182D170E0")]
		private void ClearItemFromQuickSlotList(int itemId)
		{
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x00008E98 File Offset: 0x00007098
		[Token(Token = "0x6001F2C")]
		[Address(RVA = "0x2D1F780", Offset = "0x2D1E780", VA = "0x182D1F780")]
		public bool TryRemoveItemFromQuickSlot(ItemData itemData)
		{
			return default(bool);
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001F2D RID: 7981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000457")]
		public string SerializedName
		{
			[Token(Token = "0x6001F2D")]
			[Address(RVA = "0x2D20A90", Offset = "0x2D1FA90", VA = "0x182D20A90", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06001F2E RID: 7982 RVA: 0x00008EB0 File Offset: 0x000070B0
		[Token(Token = "0x17000458")]
		private bool UniqueFile
		{
			[Token(Token = "0x6001F2E")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06001F2F RID: 7983 RVA: 0x00008EC8 File Offset: 0x000070C8
		[Token(Token = "0x17000459")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x6001F2F")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06001F30 RID: 7984 RVA: 0x00008EE0 File Offset: 0x000070E0
		[Token(Token = "0x1700045A")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6001F30")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F31")]
		[Address(RVA = "0x2D1D9E0", Offset = "0x2D1C9E0", VA = "0x182D1D9E0", Slot = "6")]
		private PlayerInventory.PlayerInventorySaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F32")]
		[Address(RVA = "0x2D1D1E0", Offset = "0x2D1C1E0", VA = "0x182D1D1E0", Slot = "7")]
		private void OnDeserialize(PlayerInventory.PlayerInventorySaveData data)
		{
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F33")]
		[Address(RVA = "0x2D20650", Offset = "0x2D1F650", VA = "0x182D20650")]
		public PlayerInventory()
		{
		}

		// Token: 0x04001C84 RID: 7300
		[Token(Token = "0x4001C84")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InventoryCutscene _inventoryCutscene;

		// Token: 0x04001C85 RID: 7301
		[Token(Token = "0x4001C85")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<InventoryItem> _possessedItems;

		// Token: 0x04001C86 RID: 7302
		[Token(Token = "0x4001C86")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<InventoryItem> _multiplayerPossessedItems;

		// Token: 0x04001C87 RID: 7303
		[Token(Token = "0x4001C87")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CraftingRecipeDatabase _craftingRecipeDatabase;

		// Token: 0x04001C88 RID: 7304
		[Token(Token = "0x4001C88")]
		[FieldOffset(Offset = "0x40")]
		public GameObject _specialActions;

		// Token: 0x04001C89 RID: 7305
		[Token(Token = "0x4001C89")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[ItemIdPicker]
		public int _clayItemId;

		// Token: 0x04001C8A RID: 7306
		[Token(Token = "0x4001C8A")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		private ItemInstanceManager _itemInstanceManager;

		// Token: 0x04001C8B RID: 7307
		[Token(Token = "0x4001C8B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		private List<int> _itemsThatHaveBeenInspected;

		// Token: 0x04001C8C RID: 7308
		[Token(Token = "0x4001C8C")]
		[FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public UnityEvent<ItemInstance, int> OnItemAddedEvent;

		// Token: 0x04001C8D RID: 7309
		[Token(Token = "0x4001C8D")]
		[FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public UnityEvent<ItemInstance, int> OnItemRemovedEvent;

		// Token: 0x04001C8E RID: 7310
		[Token(Token = "0x4001C8E")]
		[FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public UnityEvent<ItemInstance, int> OnItemEquippedEvent;

		// Token: 0x04001C8F RID: 7311
		[Token(Token = "0x4001C8F")]
		[FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public UnityEvent<ItemInstance, int> OnItemUnequippedEvent;

		// Token: 0x04001C90 RID: 7312
		[Token(Token = "0x4001C90")]
		[FieldOffset(Offset = "0x80")]
		private PlayerInventory.PlayerViews _currentView;

		// Token: 0x04001C91 RID: 7313
		[Token(Token = "0x4001C91")]
		[FieldOffset(Offset = "0x88")]
		private EventInstance _pauseSnapshot;

		// Token: 0x04001C92 RID: 7314
		[Token(Token = "0x4001C92")]
		[FieldOffset(Offset = "0x90")]
		private PlayerState _playerState;

		// Token: 0x04001C93 RID: 7315
		[Token(Token = "0x4001C93")]
		[FieldOffset(Offset = "0x98")]
		private int _upgradeCountersCount;

		// Token: 0x04001C94 RID: 7316
		[Token(Token = "0x4001C94")]
		[FieldOffset(Offset = "0x9C")]
		private int _newRecipesInInventory;

		// Token: 0x04001C95 RID: 7317
		[Token(Token = "0x4001C95")]
		[FieldOffset(Offset = "0xA0")]
		public Action<bool> OnRightHandItemLit;

		// Token: 0x04001C96 RID: 7318
		[Token(Token = "0x4001C96")]
		[FieldOffset(Offset = "0xA8")]
		private ItemInstance _hoveredItem;

		// Token: 0x04001CA2 RID: 7330
		[Token(Token = "0x4001CA2")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[ItemIdPicker(true)]
		private int _lastLeftHandLightItemUsed;

		// Token: 0x04001CA3 RID: 7331
		[Token(Token = "0x4001CA3")]
		[FieldOffset(Offset = "0xD4")]
		[ItemIdPicker(1, false)]
		[SerializeField]
		public int _defaultWeaponItemId;

		// Token: 0x04001CA4 RID: 7332
		[Token(Token = "0x4001CA4")]
		[FieldOffset(Offset = "0xD8")]
		public UnityEvent AttackEnded;

		// Token: 0x04001CA5 RID: 7333
		[Token(Token = "0x4001CA5")]
		[FieldOffset(Offset = "0xE0")]
		private ItemInstance[] _equipmentSlots;

		// Token: 0x04001CA6 RID: 7334
		[Token(Token = "0x4001CA6")]
		[FieldOffset(Offset = "0xE8")]
		private int[] _equipmentSlotsIds;

		// Token: 0x04001CA7 RID: 7335
		[Token(Token = "0x4001CA7")]
		[FieldOffset(Offset = "0xF0")]
		private ItemInstance[] _equipmentSlotsNext;

		// Token: 0x04001CA8 RID: 7336
		[Token(Token = "0x4001CA8")]
		[FieldOffset(Offset = "0xF8")]
		private ItemInstance[] _equipmentSlotsPrevious;

		// Token: 0x04001CA9 RID: 7337
		[Token(Token = "0x4001CA9")]
		[FieldOffset(Offset = "0x100")]
		private Dictionary<int, ItemInstance> _projectileItemInstances;

		// Token: 0x04001CAA RID: 7338
		[Token(Token = "0x4001CAA")]
		[FieldOffset(Offset = "0x108")]
		private bool _suppressFirstLookAts;

		// Token: 0x04001CAB RID: 7339
		[Token(Token = "0x4001CAB")]
		[FieldOffset(Offset = "0x10C")]
		private float _timeUntilNextAllowedToggleLeftHand;

		// Token: 0x04001CAC RID: 7340
		[Token(Token = "0x4001CAC")]
		[FieldOffset(Offset = "0x110")]
		private float _timeToWaitBetweenLeftHandToggle;

		// Token: 0x04001CAD RID: 7341
		[Token(Token = "0x4001CAD")]
		[FieldOffset(Offset = "0x118")]
		private Coroutine _equipSequenceRight;

		// Token: 0x04001CB1 RID: 7345
		[Token(Token = "0x4001CB1")]
		[FieldOffset(Offset = "0x138")]
		private PlayerInventory.HandEquipState _rightHandEquipState;

		// Token: 0x04001CB2 RID: 7346
		[Token(Token = "0x4001CB2")]
		[FieldOffset(Offset = "0x140")]
		private string ScrewBookLastUsedKey;

		// Token: 0x04001CB3 RID: 7347
		[Token(Token = "0x4001CB3")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private List<PlayerInventory.QuickSlot> _quickSlots;

		// Token: 0x020004B3 RID: 1203
		[Token(Token = "0x20004B3")]
		public enum PlayerViews
		{
			// Token: 0x04001CB6 RID: 7350
			[Token(Token = "0x4001CB6")]
			PlaneCrash = -1,
			// Token: 0x04001CB7 RID: 7351
			[Token(Token = "0x4001CB7")]
			Loading,
			// Token: 0x04001CB8 RID: 7352
			[Token(Token = "0x4001CB8")]
			WakingUp,
			// Token: 0x04001CB9 RID: 7353
			[Token(Token = "0x4001CB9")]
			World,
			// Token: 0x04001CBA RID: 7354
			[Token(Token = "0x4001CBA")]
			Inventory,
			// Token: 0x04001CBB RID: 7355
			[Token(Token = "0x4001CBB")]
			ClosingInventory,
			// Token: 0x04001CBC RID: 7356
			[Token(Token = "0x4001CBC")]
			GrabBag,
			// Token: 0x04001CBD RID: 7357
			[Token(Token = "0x4001CBD")]
			Pause,
			// Token: 0x04001CBE RID: 7358
			[Token(Token = "0x4001CBE")]
			Death,
			// Token: 0x04001CBF RID: 7359
			[Token(Token = "0x4001CBF")]
			Loot,
			// Token: 0x04001CC0 RID: 7360
			[Token(Token = "0x4001CC0")]
			Sleep,
			// Token: 0x04001CC1 RID: 7361
			[Token(Token = "0x4001CC1")]
			Hidden,
			// Token: 0x04001CC2 RID: 7362
			[Token(Token = "0x4001CC2")]
			PlayerList,
			// Token: 0x04001CC3 RID: 7363
			[Token(Token = "0x4001CC3")]
			EndDeactivate
		}

		// Token: 0x020004B4 RID: 1204
		[Token(Token = "0x20004B4")]
		private enum HandEquipState
		{
			// Token: 0x04001CC5 RID: 7365
			[Token(Token = "0x4001CC5")]
			Equipping,
			// Token: 0x04001CC6 RID: 7366
			[Token(Token = "0x4001CC6")]
			StashCancelEquip,
			// Token: 0x04001CC7 RID: 7367
			[Token(Token = "0x4001CC7")]
			Idle
		}

		// Token: 0x020004B5 RID: 1205
		[Token(Token = "0x20004B5")]
		[Serializable]
		public class QuickSlot
		{
			// Token: 0x1700045B RID: 1115
			// (get) Token: 0x06001F34 RID: 7988 RVA: 0x00008EF8 File Offset: 0x000070F8
			[Token(Token = "0x1700045B")]
			public float Age
			{
				[Token(Token = "0x6001F34")]
				[Address(RVA = "0x8CDC30", Offset = "0x8CCC30", VA = "0x1808CDC30")]
				get
				{
					return default(float);
				}
			}

			// Token: 0x1700045C RID: 1116
			// (get) Token: 0x06001F35 RID: 7989 RVA: 0x00008F10 File Offset: 0x00007110
			[Token(Token = "0x1700045C")]
			public ItemData.QuickSelectSlotTypes Type
			{
				[Token(Token = "0x6001F35")]
				[Address(RVA = "0x55E9A0", Offset = "0x55D9A0", VA = "0x18055E9A0")]
				get
				{
					return default(ItemData.QuickSelectSlotTypes);
				}
			}

			// Token: 0x1700045D RID: 1117
			// (get) Token: 0x06001F36 RID: 7990 RVA: 0x00008F28 File Offset: 0x00007128
			[Token(Token = "0x1700045D")]
			public int ItemId
			{
				[Token(Token = "0x6001F36")]
				[Address(RVA = "0x5D9490", Offset = "0x5D8490", VA = "0x1805D9490")]
				get
				{
					return default(int);
				}
			}

			// Token: 0x1700045E RID: 1118
			// (get) Token: 0x06001F37 RID: 7991 RVA: 0x00008F40 File Offset: 0x00007140
			[Token(Token = "0x1700045E")]
			public bool IsEmpty
			{
				[Token(Token = "0x6001F37")]
				[Address(RVA = "0x1E335B0", Offset = "0x1E325B0", VA = "0x181E335B0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06001F38 RID: 7992 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F38")]
			[Address(RVA = "0x2D2ED30", Offset = "0x2D2DD30", VA = "0x182D2ED30")]
			public void SetItemId(int itemId, float age = -1f)
			{
			}

			// Token: 0x06001F39 RID: 7993 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F39")]
			[Address(RVA = "0x2D2ED70", Offset = "0x2D2DD70", VA = "0x182D2ED70")]
			public QuickSlot()
			{
			}

			// Token: 0x04001CC8 RID: 7368
			[Token(Token = "0x4001CC8")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private ItemData.QuickSelectSlotTypes _type;

			// Token: 0x04001CC9 RID: 7369
			[Token(Token = "0x4001CC9")]
			[FieldOffset(Offset = "0x14")]
			[ItemIdPicker(true)]
			[SerializeField]
			private int _itemId;

			// Token: 0x04001CCA RID: 7370
			[Token(Token = "0x4001CCA")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private float _age;
		}

		// Token: 0x020004B6 RID: 1206
		[Token(Token = "0x20004B6")]
		[Serializable]
		internal class QuickSelectSaveData
		{
			// Token: 0x06001F3A RID: 7994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F3A")]
			[Address(RVA = "0x2D2EC90", Offset = "0x2D2DC90", VA = "0x182D2EC90")]
			public QuickSelectSaveData()
			{
			}

			// Token: 0x04001CCB RID: 7371
			[Token(Token = "0x4001CCB")]
			[FieldOffset(Offset = "0x10")]
			public string Version;

			// Token: 0x04001CCC RID: 7372
			[Token(Token = "0x4001CCC")]
			[FieldOffset(Offset = "0x18")]
			public List<PlayerInventory.QuickSelectSaveData.QuickSlotSaveData> Slots;

			// Token: 0x020004B7 RID: 1207
			[Token(Token = "0x20004B7")]
			public class QuickSlotSaveData
			{
				// Token: 0x06001F3B RID: 7995 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6001F3B")]
				[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
				public QuickSlotSaveData()
				{
				}

				// Token: 0x04001CCD RID: 7373
				[Token(Token = "0x4001CCD")]
				[FieldOffset(Offset = "0x10")]
				public int ItemId;

				// Token: 0x04001CCE RID: 7374
				[Token(Token = "0x4001CCE")]
				[FieldOffset(Offset = "0x14")]
				public float Age;
			}
		}

		// Token: 0x020004B8 RID: 1208
		[Token(Token = "0x20004B8")]
		[Serializable]
		internal class PlayerInventorySaveData
		{
			// Token: 0x06001F3C RID: 7996 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F3C")]
			[Address(RVA = "0x2D2C480", Offset = "0x2D2B480", VA = "0x182D2C480")]
			public PlayerInventorySaveData()
			{
			}

			// Token: 0x04001CCF RID: 7375
			[Token(Token = "0x4001CCF")]
			[FieldOffset(Offset = "0x10")]
			public string Version;

			// Token: 0x04001CD0 RID: 7376
			[Token(Token = "0x4001CD0")]
			[FieldOffset(Offset = "0x18")]
			public PlayerInventory.QuickSelectSaveData QuickSelect;

			// Token: 0x04001CD1 RID: 7377
			[Token(Token = "0x4001CD1")]
			[FieldOffset(Offset = "0x20")]
			public List<PlayerInventory.PlayerInventorySaveData.EquippedItem> EquippedItems;

			// Token: 0x04001CD2 RID: 7378
			[Token(Token = "0x4001CD2")]
			[FieldOffset(Offset = "0x28")]
			public ItemInstanceManager.ItemInstanceManagerSaveData ItemInstanceManagerData;

			// Token: 0x020004B9 RID: 1209
			[Token(Token = "0x20004B9")]
			[Serializable]
			public class EquippedItem
			{
				// Token: 0x06001F3D RID: 7997 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6001F3D")]
				[Address(RVA = "0x2D289B0", Offset = "0x2D279B0", VA = "0x182D289B0")]
				public EquippedItem()
				{
				}

				// Token: 0x04001CD3 RID: 7379
				[Token(Token = "0x4001CD3")]
				[FieldOffset(Offset = "0x10")]
				public int ItemId;

				// Token: 0x04001CD4 RID: 7380
				[Token(Token = "0x4001CD4")]
				[FieldOffset(Offset = "0x18")]
				public List<ItemInstanceModule.SaveData> Modules;
			}
		}
	}
}
