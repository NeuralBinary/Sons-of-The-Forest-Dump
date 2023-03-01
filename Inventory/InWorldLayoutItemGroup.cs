using System;
using Il2CppDummyDll;
using Sons.Ai.Vail.Inventory;
using Sons.Gui.Input;
using Sons.Utilities;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Inventory
{
	// Token: 0x020005FE RID: 1534
	[Token(Token = "0x20005FE")]
	[AddComponentMenu("Sons/Inventory/InWorldLayoutItemGroup")]
	public class InWorldLayoutItemGroup : LayoutItemGroup<InWorldLayoutItem>, IVailDropTarget
	{
		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06002740 RID: 10048 RVA: 0x0000B700 File Offset: 0x00009900
		[Token(Token = "0x17000531")]
		public bool AllowRandomSpawnRotation
		{
			[Token(Token = "0x6002740")]
			[Address(RVA = "0x2AF6C60", Offset = "0x2AF5C60", VA = "0x182AF6C60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002741")]
		[Address(RVA = "0x2DB7C30", Offset = "0x2DB6C30", VA = "0x182DB7C30")]
		private void Awake()
		{
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002742")]
		[Address(RVA = "0x2DB8290", Offset = "0x2DB7290", VA = "0x182DB8290", Slot = "6")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002743")]
		[Address(RVA = "0x2DB80B0", Offset = "0x2DB70B0", VA = "0x182DB80B0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002744")]
		[Address(RVA = "0x2DBA9F0", Offset = "0x2DB99F0", VA = "0x182DBA9F0", Slot = "5")]
		protected override void Update()
		{
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002745")]
		[Address(RVA = "0x2DB9310", Offset = "0x2DB8310", VA = "0x182DB9310")]
		public void SetStorage(StructureStorage storage)
		{
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x0000B718 File Offset: 0x00009918
		[Token(Token = "0x6002746")]
		[Address(RVA = "0x2DB7ED0", Offset = "0x2DB6ED0", VA = "0x182DB7ED0")]
		public int GetAvailableSpace()
		{
			return default(int);
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002747")]
		[Address(RVA = "0x2DB7B00", Offset = "0x2DB6B00", VA = "0x182DB7B00")]
		public void AddItem(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002748")]
		[Address(RVA = "0x2DB9180", Offset = "0x2DB8180", VA = "0x182DB9180")]
		public void RemoveItem(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x0000B730 File Offset: 0x00009930
		[Token(Token = "0x6002749")]
		[Address(RVA = "0x2DB9E60", Offset = "0x2DB8E60", VA = "0x182DB9E60")]
		public bool TryGetLastAddedItem(out GameObject layoutGo)
		{
			return default(bool);
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x0000B748 File Offset: 0x00009948
		[Token(Token = "0x600274A")]
		[Address(RVA = "0x2DB9880", Offset = "0x2DB8880", VA = "0x182DB9880", Slot = "9")]
		public override bool TryAddItem(ItemInstance itemInstance, int itemId)
		{
			return default(bool);
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600274B")]
		[Address(RVA = "0x2DB8460", Offset = "0x2DB7460", VA = "0x182DB8460")]
		private void RefreshInteractions(bool enable)
		{
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600274C")]
		[Address(RVA = "0x2DB9F40", Offset = "0x2DB8F40", VA = "0x182DB9F40", Slot = "10")]
		public override void TryRemoveItem(ItemInstance itemInstance, int itemId)
		{
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600274D")]
		[Address(RVA = "0xDB9D10", Offset = "0xDB8D10", VA = "0x180DB9D10")]
		public void RefreshLayout()
		{
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600274E")]
		[Address(RVA = "0xDB9D10", Offset = "0xDB8D10", VA = "0x180DB9D10")]
		private void RefreshItems(int itemId)
		{
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600274F")]
		[Address(RVA = "0x2DB8920", Offset = "0x2DB7920", VA = "0x182DB8920", Slot = "8")]
		protected override void RefreshItems()
		{
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x0000B760 File Offset: 0x00009960
		[Token(Token = "0x6002750")]
		[Address(RVA = "0x2DBAA90", Offset = "0x2DB9A90", VA = "0x182DBAA90")]
		private bool WouldEnableVisualLayoutItem()
		{
			return default(bool);
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x0000B778 File Offset: 0x00009978
		[Token(Token = "0x6002751")]
		[Address(RVA = "0x2DBAA50", Offset = "0x2DB9A50", VA = "0x182DBAA50")]
		private bool WouldDisableVisualLayoutItem()
		{
			return default(bool);
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002752")]
		[Address(RVA = "0x2DB7F10", Offset = "0x2DB6F10", VA = "0x182DB7F10")]
		private void GetNonUniqueCollectionValues(out int outCurrentVisualCount, out int outFinalVisualCount)
		{
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x0000B790 File Offset: 0x00009990
		[Token(Token = "0x6002753")]
		[Address(RVA = "0x2DB9720", Offset = "0x2DB8720", VA = "0x182DB9720", Slot = "12")]
		private bool TryAddItem(int itemId, int itemCount)
		{
			return default(bool);
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x0000B7A8 File Offset: 0x000099A8
		[Token(Token = "0x6002754")]
		[Address(RVA = "0x2DB96E0", Offset = "0x2DB86E0", VA = "0x182DB96E0", Slot = "13")]
		private bool IsFull()
		{
			return default(bool);
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002755")]
		[Address(RVA = "0x2DB96D0", Offset = "0x2DB86D0", VA = "0x182DB96D0", Slot = "11")]
		private string GetItemType()
		{
			return null;
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002756")]
		[Address(RVA = "0x2DBAAD0", Offset = "0x2DB9AD0", VA = "0x182DBAAD0")]
		public InWorldLayoutItemGroup()
		{
		}

		// Token: 0x0400237A RID: 9082
		[Token(Token = "0x400237A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private int _maxAmount;

		// Token: 0x0400237B RID: 9083
		[Token(Token = "0x400237B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private OnGrabberProxy _onGrabberProxy;

		// Token: 0x0400237C RID: 9084
		[Token(Token = "0x400237C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private LinkUiElement _linkUiElement;

		// Token: 0x0400237D RID: 9085
		[Token(Token = "0x400237D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private StructureStorage _storage;

		// Token: 0x0400237E RID: 9086
		[Token(Token = "0x400237E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _blockAddItemInteraction;

		// Token: 0x0400237F RID: 9087
		[Token(Token = "0x400237F")]
		[FieldOffset(Offset = "0x91")]
		[SerializeField]
		private bool _allowRandomSpawnRotation;

		// Token: 0x04002380 RID: 9088
		[Token(Token = "0x4002380")]
		[FieldOffset(Offset = "0x92")]
		private bool _uiIsActive;

		// Token: 0x04002381 RID: 9089
		[Token(Token = "0x4002381")]
		[FieldOffset(Offset = "0x98")]
		public Action OnGroupCleared;
	}
}
