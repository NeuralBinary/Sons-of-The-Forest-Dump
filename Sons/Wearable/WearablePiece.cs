using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Wearable
{
	// Token: 0x020005BD RID: 1469
	[Token(Token = "0x20005BD")]
	[CreateAssetMenu(fileName = "WearablePiece", menuName = "Sons/Data/Wearable/WearablePiece", order = 0)]
	public class WearablePiece : ScriptableObject
	{
		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06002668 RID: 9832 RVA: 0x0000B610 File Offset: 0x00009810
		[Token(Token = "0x17000519")]
		public int ItemId
		{
			[Token(Token = "0x6002668")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06002669 RID: 9833 RVA: 0x0000B628 File Offset: 0x00009828
		[Token(Token = "0x1700051A")]
		public Color UiColor
		{
			[Token(Token = "0x6002669")]
			[Address(RVA = "0xFAFF70", Offset = "0xFAE570", VA = "0x180FAFF70")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600266A RID: 9834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700051B")]
		public IEnumerable<WearablePiece.SlotAndRenderable> AllowedInSlots
		{
			[Token(Token = "0x600266A")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266B")]
		[Address(RVA = "0x33AC020", Offset = "0x33AA620", VA = "0x1833AC020")]
		public WearablePiece()
		{
		}

		// Token: 0x0400229C RID: 8860
		[Token(Token = "0x400229C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[ItemIdPicker(Types.Armor, false)]
		private int _itemId;

		// Token: 0x0400229D RID: 8861
		[Token(Token = "0x400229D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private GameObject _renderable;

		// Token: 0x0400229E RID: 8862
		[Token(Token = "0x400229E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected Color _uiColor;

		// Token: 0x0400229F RID: 8863
		[Token(Token = "0x400229F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		protected string _description;

		// Token: 0x040022A0 RID: 8864
		[Token(Token = "0x40022A0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		protected float _thermalProtectionRating;

		// Token: 0x040022A1 RID: 8865
		[Token(Token = "0x40022A1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected List<WearablePiece.SlotAndRenderable> _allowedInSlots;

		// Token: 0x040022A2 RID: 8866
		[Token(Token = "0x40022A2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected List<WearableSlots> _additionalRequiredSlots;

		// Token: 0x020005BE RID: 1470
		[Token(Token = "0x20005BE")]
		[Serializable]
		public struct SlotAndRenderable
		{
			// Token: 0x040022A3 RID: 8867
			[Token(Token = "0x40022A3")]
			[FieldOffset(Offset = "0x0")]
			public WearableSlots Slot;

			// Token: 0x040022A4 RID: 8868
			[Token(Token = "0x40022A4")]
			[FieldOffset(Offset = "0x8")]
			public GameObject Renderable;
		}
	}
}
