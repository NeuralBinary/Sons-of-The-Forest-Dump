using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Gameplay.GrabBag;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000662 RID: 1634
	[Token(Token = "0x2000662")]
	[AddComponentMenu("Sons/Gameplay/ItemStorageController")]
	public class ItemStorageController : MonoBehaviour, IGrabBagInteractionReceiver
	{
		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x060029D1 RID: 10705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700056E")]
		public List<ItemStorageHookPoint> HookPoints
		{
			[Token(Token = "0x60029D1")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
			get
			{
				return null;
			}
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029D2")]
		[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200", Slot = "9")]
		public List<GrabBagCategory> GetValidGrabBagCategories()
		{
			return null;
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		[Token(Token = "0x60029D3")]
		[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "8")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		[Token(Token = "0x60029D4")]
		[Address(RVA = "0x2DCF260", Offset = "0x2DCE260", VA = "0x182DCF260", Slot = "7")]
		public bool TryAddItem(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029D5")]
		[Address(RVA = "0x2DCEC80", Offset = "0x2DCDC80", VA = "0x182DCEC80")]
		public InWorldLayoutItemGroup GetLayoutGroupForItem(int itemId)
		{
			return null;
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D6")]
		[Address(RVA = "0x2DCF230", Offset = "0x2DCE230", VA = "0x182DCF230", Slot = "4")]
		public void OpenInteractionReceiver(GrabBagController grabBagController)
		{
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D7")]
		[Address(RVA = "0x2DCF870", Offset = "0x2DCE870", VA = "0x182DCF870", Slot = "5")]
		public void UpdateInteractionReceiver()
		{
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D8")]
		[Address(RVA = "0x2DCEC60", Offset = "0x2DCDC60", VA = "0x182DCEC60", Slot = "6")]
		public void CloseInteractionReceiver()
		{
		}

		// Token: 0x060029D9 RID: 10713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D9")]
		[Address(RVA = "0x2DCF010", Offset = "0x2DCE010", VA = "0x182DCF010")]
		public void InteractWithItemStorage()
		{
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x0000C0D8 File Offset: 0x0000A2D8
		[Token(Token = "0x60029DA")]
		[Address(RVA = "0x2DCEEF0", Offset = "0x2DCDEF0", VA = "0x182DCEEF0")]
		public bool HasAnyEmptyHooks()
		{
			return default(bool);
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		[Token(Token = "0x60029DB")]
		[Address(RVA = "0x2DCEDD0", Offset = "0x2DCDDD0", VA = "0x182DCEDD0")]
		public bool HasAnyBusyHooks()
		{
			return default(bool);
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x0000C108 File Offset: 0x0000A308
		[Token(Token = "0x60029DC")]
		[Address(RVA = "0x2DCF3E0", Offset = "0x2DCE3E0", VA = "0x182DCF3E0")]
		public bool TryGetAvailableHook(int itemId, out ItemStorageHookPoint hook)
		{
			return default(bool);
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029DD")]
		[Address(RVA = "0x2DCF890", Offset = "0x2DCE890", VA = "0x182DCF890")]
		public ItemStorageController()
		{
		}

		// Token: 0x04002573 RID: 9587
		[Token(Token = "0x4002573")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GrabBagCategory> _grabBagCategories;

		// Token: 0x04002574 RID: 9588
		[Token(Token = "0x4002574")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<ItemStorageHookPoint> _hookPoints;

		// Token: 0x04002575 RID: 9589
		[Token(Token = "0x4002575")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<InWorldLayoutItemGroup> _itemLayoutGroups;

		// Token: 0x04002576 RID: 9590
		[Token(Token = "0x4002576")]
		[FieldOffset(Offset = "0x38")]
		private GrabBagController _grabBagController;
	}
}
