using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Inventory;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Gameplay
{
	// Token: 0x02000784 RID: 1924
	[Token(Token = "0x2000784")]
	[AddComponentMenu("Sons/Gameplay/ItemStorageHookPoint")]
	public class ItemStorageHookPoint : ItemHookPoint
	{
		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x060033DF RID: 13279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069C")]
		public StructureStorage Storage
		{
			[Token(Token = "0x60033DF")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033E0")]
		[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
		public InWorldLayoutItemGroup GetLayoutItemGroup()
		{
			return null;
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033E1")]
		[Address(RVA = "0x34C09D0", Offset = "0x34BEFD0", VA = "0x1834C09D0")]
		public void PopulateItemLayoutGroups(List<InWorldLayoutItemGroup> itemLayoutGroups)
		{
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033E2")]
		[Address(RVA = "0x34C0BA0", Offset = "0x34BF1A0", VA = "0x1834C0BA0")]
		private void OnValidate()
		{
		}

		// Token: 0x060033E3 RID: 13283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033E3")]
		[Address(RVA = "0x34C0C30", Offset = "0x34BF230", VA = "0x1834C0C30")]
		private void Awake()
		{
		}

		// Token: 0x060033E4 RID: 13284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033E4")]
		[Address(RVA = "0x34C0F10", Offset = "0x34BF510", VA = "0x1834C0F10")]
		private void RefreshHookPoint(int itemId)
		{
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033E5")]
		[Address(RVA = "0x34C1500", Offset = "0x34BFB00", VA = "0x1834C1500", Slot = "7")]
		protected override void SetInteractionState(bool enable)
		{
		}

		// Token: 0x060033E6 RID: 13286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033E6")]
		[Address(RVA = "0x34C1610", Offset = "0x34BFC10", VA = "0x1834C1610", Slot = "9")]
		protected override void OnPerformedAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x060033E7 RID: 13287 RVA: 0x0000F8D0 File Offset: 0x0000DAD0
		[Token(Token = "0x60033E7")]
		[Address(RVA = "0x34C1640", Offset = "0x34BFC40", VA = "0x1834C1640", Slot = "4")]
		public override bool IsAvailable()
		{
			return default(bool);
		}

		// Token: 0x060033E8 RID: 13288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033E8")]
		[Address(RVA = "0x34C1700", Offset = "0x34BFD00", VA = "0x1834C1700")]
		public void Clear()
		{
		}

		// Token: 0x060033E9 RID: 13289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033E9")]
		[Address(RVA = "0x34C1980", Offset = "0x34BFF80", VA = "0x1834C1980")]
		public void Set(InWorldLayoutItemGroup layoutItemGroup)
		{
		}

		// Token: 0x060033EA RID: 13290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033EA")]
		[Address(RVA = "0x34C2120", Offset = "0x34C0720", VA = "0x1834C2120")]
		public InWorldLayoutItemGroup GetLayoutGroupForItem(int itemId)
		{
			return null;
		}

		// Token: 0x060033EB RID: 13291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033EB")]
		[Address(RVA = "0x34C22C0", Offset = "0x34C08C0", VA = "0x1834C22C0")]
		public ItemStorageHookPoint()
		{
		}

		// Token: 0x04002CD8 RID: 11480
		[Token(Token = "0x4002CD8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ItemStorageController _itemStorageController;

		// Token: 0x04002CD9 RID: 11481
		[Token(Token = "0x4002CD9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private StructureStorage _storage;

		// Token: 0x04002CDA RID: 11482
		[Token(Token = "0x4002CDA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Collider _interactionCollider;

		// Token: 0x04002CDB RID: 11483
		[Token(Token = "0x4002CDB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<InWorldLayoutItemGroup> _itemLayoutGroups;

		// Token: 0x04002CDC RID: 11484
		[Token(Token = "0x4002CDC")]
		[FieldOffset(Offset = "0x70")]
		private InWorldLayoutItemGroup _layoutItemGroup;
	}
}
