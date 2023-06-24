using System;
using System.Collections.Generic;
using Bolt;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Multiplayer.Client
{
	// Token: 0x02000574 RID: 1396
	[Token(Token = "0x2000574")]
	public class CoopHeldOnlyItemsController : EntityEventListener<IPlayerState>
	{
		// Token: 0x060024EA RID: 9450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024EA")]
		[Address(RVA = "0x3392410", Offset = "0x3390A10", VA = "0x183392410", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024EB")]
		[Address(RVA = "0x3392580", Offset = "0x3390B80", VA = "0x183392580")]
		private void OnHeldItemChanged()
		{
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x0000AC50 File Offset: 0x00008E50
		[Token(Token = "0x60024EC")]
		[Address(RVA = "0x3392840", Offset = "0x3390E40", VA = "0x183392840")]
		private bool TryGetHeldOnlyItemData(int itemId, out CoopHeldOnlyItemsController.HeldOnlyItemData heldOnlyItemData)
		{
			return default(bool);
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024ED")]
		[Address(RVA = "0x3392A30", Offset = "0x3391030", VA = "0x183392A30")]
		private void SetActiveItem(CoopHeldOnlyItemsController.HeldOnlyItemData newActiveItem)
		{
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024EE")]
		[Address(RVA = "0x3392AB0", Offset = "0x33910B0", VA = "0x183392AB0")]
		public CoopHeldOnlyItemsController()
		{
		}

		// Token: 0x04002122 RID: 8482
		[Token(Token = "0x4002122")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<CoopHeldOnlyItemsController.HeldOnlyItemData> _heldOnlyItems;

		// Token: 0x04002123 RID: 8483
		[Token(Token = "0x4002123")]
		[FieldOffset(Offset = "0x30")]
		private CoopHeldOnlyItemsController.HeldOnlyItemData _activeItem;

		// Token: 0x02000575 RID: 1397
		[Token(Token = "0x2000575")]
		[Serializable]
		public class HeldOnlyItemData
		{
			// Token: 0x170004E1 RID: 1249
			// (get) Token: 0x060024EF RID: 9455 RVA: 0x0000AC68 File Offset: 0x00008E68
			[Token(Token = "0x170004E1")]
			public int ItemId
			{
				[Token(Token = "0x60024EF")]
				[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060024F0 RID: 9456 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60024F0")]
			[Address(RVA = "0x3392BA0", Offset = "0x33911A0", VA = "0x183392BA0")]
			public void Show(int count)
			{
			}

			// Token: 0x060024F1 RID: 9457 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60024F1")]
			[Address(RVA = "0x3392C90", Offset = "0x3391290", VA = "0x183392C90")]
			public void Hide()
			{
			}

			// Token: 0x060024F2 RID: 9458 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60024F2")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public HeldOnlyItemData()
			{
			}

			// Token: 0x04002124 RID: 8484
			[Token(Token = "0x4002124")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject[] _visuals;

			// Token: 0x04002125 RID: 8485
			[Token(Token = "0x4002125")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			[ItemIdPicker]
			private int _itemId;
		}
	}
}
