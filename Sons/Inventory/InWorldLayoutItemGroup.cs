using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail.Inventory;
using Sons.Gui.Input;
using Sons.Utilities;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Inventory
{
	// Token: 0x02000611 RID: 1553
	[Token(Token = "0x2000611")]
	[AddComponentMenu("Sons/Inventory/InWorldLayoutItemGroup")]
	public class InWorldLayoutItemGroup : LayoutItemGroup<InWorldLayoutItem>, IVailDropTarget
	{
		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06002850 RID: 10320 RVA: 0x0000BDF0 File Offset: 0x00009FF0
		[Token(Token = "0x17000546")]
		public bool AllowRandomSpawnRotation
		{
			[Token(Token = "0x6002850")]
			[Address(RVA = "0x33DA130", Offset = "0x33D8730", VA = "0x1833DA130")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002851 RID: 10321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002851")]
		[Address(RVA = "0x33DA140", Offset = "0x33D8740", VA = "0x1833DA140")]
		private void Awake()
		{
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002852")]
		[Address(RVA = "0x33DA650", Offset = "0x33D8C50", VA = "0x1833DA650")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002853")]
		[Address(RVA = "0x33DA930", Offset = "0x33D8F30", VA = "0x1833DA930", Slot = "6")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06002854 RID: 10324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002854")]
		[Address(RVA = "0x33DAD20", Offset = "0x33D9320", VA = "0x1833DAD20", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002855")]
		[Address(RVA = "0x33DB100", Offset = "0x33D9700", VA = "0x1833DB100", Slot = "5")]
		protected override void Update()
		{
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002856")]
		[Address(RVA = "0x33DB170", Offset = "0x33D9770", VA = "0x1833DB170")]
		public void SetStorage(StructureStorage storage)
		{
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x0000BE08 File Offset: 0x0000A008
		[Token(Token = "0x6002857")]
		[Address(RVA = "0x33DB720", Offset = "0x33D9D20", VA = "0x1833DB720")]
		public int GetAvailableSpace()
		{
			return 0;
		}

		// Token: 0x06002858 RID: 10328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002858")]
		[Address(RVA = "0x33DB760", Offset = "0x33D9D60", VA = "0x1833DB760")]
		public void Clear()
		{
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002859")]
		[Address(RVA = "0x33DB7B0", Offset = "0x33D9DB0", VA = "0x1833DB7B0")]
		public void AddItem(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285A")]
		[Address(RVA = "0x33DB940", Offset = "0x33D9F40", VA = "0x1833DB940")]
		public void RemoveItem(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x0000BE20 File Offset: 0x0000A020
		[Token(Token = "0x600285B")]
		[Address(RVA = "0x33DBA10", Offset = "0x33DA010", VA = "0x1833DBA10")]
		public bool TryGetLastAddedItem(out GameObject layoutGo)
		{
			return default(bool);
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x0000BE38 File Offset: 0x0000A038
		[Token(Token = "0x600285C")]
		[Address(RVA = "0x33DBBF0", Offset = "0x33DA1F0", VA = "0x1833DBBF0", Slot = "9")]
		public override bool TryAddItem(ItemInstance itemInstance, int itemId)
		{
			return default(bool);
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285D")]
		[Address(RVA = "0x33DC240", Offset = "0x33DA840", VA = "0x1833DC240")]
		private void RefreshToggledObjects()
		{
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285E")]
		[Address(RVA = "0x33DC620", Offset = "0x33DAC20", VA = "0x1833DC620")]
		private void RefreshInteractions(bool enable)
		{
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285F")]
		[Address(RVA = "0x33DCC90", Offset = "0x33DB290", VA = "0x1833DCC90", Slot = "10")]
		public override void TryRemoveItem(ItemInstance itemInstance, int itemId)
		{
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002860")]
		[Address(RVA = "0xFAB1C0", Offset = "0xFA97C0", VA = "0x180FAB1C0")]
		public void RefreshLayout()
		{
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002861")]
		[Address(RVA = "0xFAB1C0", Offset = "0xFA97C0", VA = "0x180FAB1C0")]
		private void RefreshItems(int itemId)
		{
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002862")]
		[Address(RVA = "0x33DD520", Offset = "0x33DBB20", VA = "0x1833DD520", Slot = "8")]
		protected override void RefreshItems()
		{
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x0000BE50 File Offset: 0x0000A050
		[Token(Token = "0x6002863")]
		[Address(RVA = "0x33DE260", Offset = "0x33DC860", VA = "0x1833DE260")]
		private bool WouldEnableVisualLayoutItem()
		{
			return default(bool);
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x0000BE68 File Offset: 0x0000A068
		[Token(Token = "0x6002864")]
		[Address(RVA = "0x33DE2A0", Offset = "0x33DC8A0", VA = "0x1833DE2A0")]
		private bool WouldDisableVisualLayoutItem()
		{
			return default(bool);
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002865")]
		[Address(RVA = "0x33DE2E0", Offset = "0x33DC8E0", VA = "0x1833DE2E0")]
		private void GetNonUniqueCollectionValues(out int outCurrentVisualCount, out int outFinalVisualCount)
		{
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x0000BE80 File Offset: 0x0000A080
		[Token(Token = "0x6002866")]
		[Address(RVA = "0x33DE530", Offset = "0x33DCB30", VA = "0x1833DE530", Slot = "12")]
		private int TryAddItem(int itemId, int itemCount)
		{
			return 0;
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x0000BE98 File Offset: 0x0000A098
		[Token(Token = "0x6002867")]
		[Address(RVA = "0x33DE680", Offset = "0x33DCC80", VA = "0x1833DE680", Slot = "13")]
		private bool IsFull()
		{
			return default(bool);
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		[Token(Token = "0x6002868")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "14")]
		private bool IsHolder()
		{
			return default(bool);
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002869")]
		[Address(RVA = "0x33DE6C0", Offset = "0x33DCCC0", VA = "0x1833DE6C0", Slot = "11")]
		private string GetItemType()
		{
			return null;
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
		[Token(Token = "0x600286A")]
		[Address(RVA = "0x33DE6D0", Offset = "0x33DCCD0", VA = "0x1833DE6D0")]
		public float GetFullFactor()
		{
			return 0f;
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600286B")]
		[Address(RVA = "0x33DE740", Offset = "0x33DCD40", VA = "0x1833DE740")]
		public InWorldLayoutItemGroup()
		{
		}

		// Token: 0x04002467 RID: 9319
		[Token(Token = "0x4002467")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private int _maxAmount;

		// Token: 0x04002468 RID: 9320
		[Token(Token = "0x4002468")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private OnGrabberProxy _onGrabberProxy;

		// Token: 0x04002469 RID: 9321
		[Token(Token = "0x4002469")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private LinkUiElement _linkUiElement;

		// Token: 0x0400246A RID: 9322
		[Token(Token = "0x400246A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private StructureStorage _storage;

		// Token: 0x0400246B RID: 9323
		[Token(Token = "0x400246B")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private bool _blockAddItemInteraction;

		// Token: 0x0400246C RID: 9324
		[Token(Token = "0x400246C")]
		[FieldOffset(Offset = "0x99")]
		[SerializeField]
		private bool _allowRandomSpawnRotation;

		// Token: 0x0400246D RID: 9325
		[Token(Token = "0x400246D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private List<GameObject> _objectsToDisableWhenLayoutIsActive;

		// Token: 0x0400246E RID: 9326
		[Token(Token = "0x400246E")]
		[FieldOffset(Offset = "0xA8")]
		private bool _uiIsActive;

		// Token: 0x0400246F RID: 9327
		[Token(Token = "0x400246F")]
		[FieldOffset(Offset = "0xB0")]
		public Action OnGroupCleared;

		// Token: 0x04002470 RID: 9328
		[Token(Token = "0x4002470")]
		[FieldOffset(Offset = "0xB8")]
		public Action<GameObject> OnItemAdded;
	}
}
