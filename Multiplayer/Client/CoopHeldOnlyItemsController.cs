using System;
using System.Collections.Generic;
using Bolt;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Multiplayer.Client
{
	// Token: 0x02000564 RID: 1380
	[Token(Token = "0x2000564")]
	public class CoopHeldOnlyItemsController : EntityEventListener<IPlayerState>
	{
		// Token: 0x060023EC RID: 9196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EC")]
		[Address(RVA = "0x2D7D840", Offset = "0x2D7C840", VA = "0x182D7D840", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023ED")]
		[Address(RVA = "0x2D7D980", Offset = "0x2D7C980", VA = "0x182D7D980")]
		private void OnHeldItemChanged()
		{
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x0000A590 File Offset: 0x00008790
		[Token(Token = "0x60023EE")]
		[Address(RVA = "0x2D7DB70", Offset = "0x2D7CB70", VA = "0x182D7DB70")]
		private bool TryGetHeldOnlyItemData(int itemId, out CoopHeldOnlyItemsController.HeldOnlyItemData heldOnlyItemData)
		{
			return default(bool);
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EF")]
		[Address(RVA = "0x2D7DB30", Offset = "0x2D7CB30", VA = "0x182D7DB30")]
		private void SetActiveItem(CoopHeldOnlyItemsController.HeldOnlyItemData newActiveItem)
		{
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F0")]
		[Address(RVA = "0x2D7DCE0", Offset = "0x2D7CCE0", VA = "0x182D7DCE0")]
		public CoopHeldOnlyItemsController()
		{
		}

		// Token: 0x0400204F RID: 8271
		[Token(Token = "0x400204F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<CoopHeldOnlyItemsController.HeldOnlyItemData> _heldOnlyItems;

		// Token: 0x04002050 RID: 8272
		[Token(Token = "0x4002050")]
		[FieldOffset(Offset = "0x30")]
		private CoopHeldOnlyItemsController.HeldOnlyItemData _activeItem;

		// Token: 0x02000565 RID: 1381
		[Token(Token = "0x2000565")]
		[Serializable]
		public class HeldOnlyItemData
		{
			// Token: 0x170004CD RID: 1229
			// (get) Token: 0x060023F1 RID: 9201 RVA: 0x0000A5A8 File Offset: 0x000087A8
			[Token(Token = "0x170004CD")]
			public int ItemId
			{
				[Token(Token = "0x60023F1")]
				[Address(RVA = "0x5D9500", Offset = "0x5D8500", VA = "0x1805D9500")]
				get
				{
					return default(int);
				}
			}

			// Token: 0x060023F2 RID: 9202 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60023F2")]
			[Address(RVA = "0x2D83830", Offset = "0x2D82830", VA = "0x182D83830")]
			public void Show(int count)
			{
			}

			// Token: 0x060023F3 RID: 9203 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60023F3")]
			[Address(RVA = "0x2D837B0", Offset = "0x2D827B0", VA = "0x182D837B0")]
			public void Hide()
			{
			}

			// Token: 0x060023F4 RID: 9204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60023F4")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public HeldOnlyItemData()
			{
			}

			// Token: 0x04002051 RID: 8273
			[Token(Token = "0x4002051")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject[] _visuals;

			// Token: 0x04002052 RID: 8274
			[Token(Token = "0x4002052")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			[ItemIdPicker]
			private int _itemId;
		}
	}
}
