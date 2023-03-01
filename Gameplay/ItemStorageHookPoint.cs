using System;
using Il2CppDummyDll;
using Sons.Inventory;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Gameplay
{
	// Token: 0x02000666 RID: 1638
	[Token(Token = "0x2000666")]
	[AddComponentMenu("Sons/Gameplay/ItemStorageHookPoint")]
	public class ItemStorageHookPoint : ItemHookPoint
	{
		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x060029E7 RID: 10727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700056F")]
		public StructureStorage Storage
		{
			[Token(Token = "0x60029E7")]
			[Address(RVA = "0x5E9600", Offset = "0x5E8600", VA = "0x1805E9600")]
			get
			{
				return null;
			}
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029E8")]
		[Address(RVA = "0x5E4C40", Offset = "0x5E3C40", VA = "0x1805E4C40")]
		public InWorldLayoutItemGroup GetLayoutItemGroup()
		{
			return null;
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E9")]
		[Address(RVA = "0x2DCFFA0", Offset = "0x2DCEFA0", VA = "0x182DCFFA0")]
		private void OnValidate()
		{
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029EA")]
		[Address(RVA = "0x2DCFA10", Offset = "0x2DCEA10", VA = "0x182DCFA10")]
		private void Awake()
		{
		}

		// Token: 0x060029EB RID: 10731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029EB")]
		[Address(RVA = "0x2DCFFF0", Offset = "0x2DCEFF0", VA = "0x182DCFFF0")]
		private void RefreshHookPoint(int itemId)
		{
		}

		// Token: 0x060029EC RID: 10732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029EC")]
		[Address(RVA = "0x2DCFD80", Offset = "0x2DCED80", VA = "0x182DCFD80", Slot = "8")]
		protected override void OnPerformedAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x0000C198 File Offset: 0x0000A398
		[Token(Token = "0x60029ED")]
		[Address(RVA = "0x2DCFD30", Offset = "0x2DCED30", VA = "0x182DCFD30", Slot = "4")]
		public override bool IsAvailable()
		{
			return default(bool);
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029EE")]
		[Address(RVA = "0x2DCFC20", Offset = "0x2DCEC20", VA = "0x182DCFC20")]
		public void Clear()
		{
		}

		// Token: 0x060029EF RID: 10735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029EF")]
		[Address(RVA = "0x2DD0460", Offset = "0x2DCF460", VA = "0x182DD0460")]
		public void Set(InWorldLayoutItemGroup layoutItemGroup)
		{
		}

		// Token: 0x060029F0 RID: 10736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F0")]
		[Address(RVA = "0x59FF50", Offset = "0x59EF50", VA = "0x18059FF50")]
		public ItemStorageHookPoint()
		{
		}

		// Token: 0x0400257D RID: 9597
		[Token(Token = "0x400257D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ItemStorageController _itemStorageController;

		// Token: 0x0400257E RID: 9598
		[Token(Token = "0x400257E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private StructureStorage _storage;

		// Token: 0x0400257F RID: 9599
		[Token(Token = "0x400257F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Collider _interactionCollider;

		// Token: 0x04002580 RID: 9600
		[Token(Token = "0x4002580")]
		[FieldOffset(Offset = "0x68")]
		private InWorldLayoutItemGroup _layoutItemGroup;
	}
}
