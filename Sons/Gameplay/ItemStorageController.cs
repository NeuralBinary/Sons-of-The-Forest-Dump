using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Crafting.Structures;
using Sons.Gameplay.GrabBag;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000781 RID: 1921
	[Token(Token = "0x2000781")]
	[AddComponentMenu("Sons/Gameplay/ItemStorageController")]
	public class ItemStorageController : MonoBehaviour, IGrabBagInteractionReceiver
	{
		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x060033C9 RID: 13257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069B")]
		public List<ItemStorageHookPoint> HookPoints
		{
			[Token(Token = "0x60033C9")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x060033CA RID: 13258 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
		[Token(Token = "0x60033CA")]
		[Address(RVA = "0x34BEB40", Offset = "0x34BD140", VA = "0x1834BEB40")]
		public bool HasStructureAndIsBusy()
		{
			return default(bool);
		}

		// Token: 0x060033CB RID: 13259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033CB")]
		[Address(RVA = "0x34BEC20", Offset = "0x34BD220", VA = "0x1834BEC20")]
		private void OnValidate()
		{
		}

		// Token: 0x060033CC RID: 13260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033CC")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "9")]
		public List<GrabBagCategory> GetValidGrabBagCategories()
		{
			return null;
		}

		// Token: 0x060033CD RID: 13261 RVA: 0x0000F7F8 File Offset: 0x0000D9F8
		[Token(Token = "0x60033CD")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x060033CE RID: 13262 RVA: 0x0000F810 File Offset: 0x0000DA10
		[Token(Token = "0x60033CE")]
		[Address(RVA = "0x34BED70", Offset = "0x34BD370", VA = "0x1834BED70", Slot = "7")]
		public bool TryAddItem(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x060033CF RID: 13263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033CF")]
		[Address(RVA = "0x34BF010", Offset = "0x34BD610", VA = "0x1834BF010", Slot = "4")]
		public void OpenInteractionReceiver(GrabBagController grabBagController)
		{
		}

		// Token: 0x060033D0 RID: 13264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D0")]
		[Address(RVA = "0x34BF300", Offset = "0x34BD900", VA = "0x1834BF300", Slot = "5")]
		public void UpdateInteractionReceiver()
		{
		}

		// Token: 0x060033D1 RID: 13265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D1")]
		[Address(RVA = "0x34BF320", Offset = "0x34BD920", VA = "0x1834BF320", Slot = "6")]
		public void CloseInteractionReceiver()
		{
		}

		// Token: 0x060033D2 RID: 13266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D2")]
		[Address(RVA = "0x34BF5F0", Offset = "0x34BDBF0", VA = "0x1834BF5F0")]
		public void InteractWithItemStorage(ItemStorageHookPoint hookPoint)
		{
		}

		// Token: 0x060033D3 RID: 13267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D3")]
		[Address(RVA = "0x34BF990", Offset = "0x34BDF90", VA = "0x1834BF990")]
		private void OnItemUnequipped(ItemInstance itemInstance, int itemId)
		{
		}

		// Token: 0x060033D4 RID: 13268 RVA: 0x0000F828 File Offset: 0x0000DA28
		[Token(Token = "0x60033D4")]
		[Address(RVA = "0x34BFCC0", Offset = "0x34BE2C0", VA = "0x1834BFCC0")]
		public bool HasAnyEmptyHooks()
		{
			return default(bool);
		}

		// Token: 0x060033D5 RID: 13269 RVA: 0x0000F840 File Offset: 0x0000DA40
		[Token(Token = "0x60033D5")]
		[Address(RVA = "0x34BFE20", Offset = "0x34BE420", VA = "0x1834BFE20")]
		public bool HasAnyBusyHooks()
		{
			return default(bool);
		}

		// Token: 0x060033D6 RID: 13270 RVA: 0x0000F858 File Offset: 0x0000DA58
		[Token(Token = "0x60033D6")]
		[Address(RVA = "0x34BFF80", Offset = "0x34BE580", VA = "0x1834BFF80")]
		public bool TryGetAvailableHook(int itemId, out ItemStorageHookPoint hook)
		{
			return default(bool);
		}

		// Token: 0x060033D7 RID: 13271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D7")]
		[Address(RVA = "0x34C0600", Offset = "0x34BEC00", VA = "0x1834C0600")]
		public ItemStorageController()
		{
		}

		// Token: 0x04002CCC RID: 11468
		[Token(Token = "0x4002CCC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GrabBagCategory> _grabBagCategories;

		// Token: 0x04002CCD RID: 11469
		[Token(Token = "0x4002CCD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<ItemStorageHookPoint> _hookPoints;

		// Token: 0x04002CCE RID: 11470
		[Token(Token = "0x4002CCE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ScrewStructure _screwStructure;

		// Token: 0x04002CCF RID: 11471
		[Token(Token = "0x4002CCF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private List<InWorldLayoutItemGroup> _itemLayoutGroups;

		// Token: 0x04002CD0 RID: 11472
		[Token(Token = "0x4002CD0")]
		[FieldOffset(Offset = "0x40")]
		private GrabBagController _grabBagController;

		// Token: 0x04002CD1 RID: 11473
		[Token(Token = "0x4002CD1")]
		[FieldOffset(Offset = "0x48")]
		private ItemStorageHookPoint _selectedHookPoint;

		// Token: 0x04002CD2 RID: 11474
		[Token(Token = "0x4002CD2")]
		[FieldOffset(Offset = "0x50")]
		private bool _isBusy;
	}
}
