using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Wearable
{
	// Token: 0x020005AD RID: 1453
	[Token(Token = "0x20005AD")]
	[CreateAssetMenu(fileName = "WearablePiece", menuName = "Sons/Data/Wearable/WearablePiece", order = 0)]
	public class WearablePiece : ScriptableObject
	{
		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06002569 RID: 9577 RVA: 0x0000AF50 File Offset: 0x00009150
		[Token(Token = "0x17000505")]
		public int ItemId
		{
			[Token(Token = "0x6002569")]
			[Address(RVA = "0x5D9500", Offset = "0x5D8500", VA = "0x1805D9500")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x0600256A RID: 9578 RVA: 0x0000AF68 File Offset: 0x00009168
		[Token(Token = "0x17000506")]
		public Color UiColor
		{
			[Token(Token = "0x600256A")]
			[Address(RVA = "0xDBE440", Offset = "0xDBD440", VA = "0x180DBE440")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x0600256B RID: 9579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000507")]
		public IEnumerable<WearablePiece.SlotAndRenderable> AllowedInSlots
		{
			[Token(Token = "0x600256B")]
			[Address(RVA = "0x5E65C0", Offset = "0x5E55C0", VA = "0x1805E65C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600256C RID: 9580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600256C")]
		[Address(RVA = "0x2D92AC0", Offset = "0x2D91AC0", VA = "0x182D92AC0")]
		public WearablePiece()
		{
		}

		// Token: 0x040021C8 RID: 8648
		[Token(Token = "0x40021C8")]
		[FieldOffset(Offset = "0x18")]
		[ItemIdPicker(16384, false)]
		[SerializeField]
		private int _itemId;

		// Token: 0x040021C9 RID: 8649
		[Token(Token = "0x40021C9")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		private GameObject _renderable;

		// Token: 0x040021CA RID: 8650
		[Token(Token = "0x40021CA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected Color _uiColor;

		// Token: 0x040021CB RID: 8651
		[Token(Token = "0x40021CB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		protected string _description;

		// Token: 0x040021CC RID: 8652
		[Token(Token = "0x40021CC")]
		[FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		protected float _thermalProtectionRating;

		// Token: 0x040021CD RID: 8653
		[Token(Token = "0x40021CD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected List<WearablePiece.SlotAndRenderable> _allowedInSlots;

		// Token: 0x040021CE RID: 8654
		[Token(Token = "0x40021CE")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		protected List<WearableSlots> _additionalRequiredSlots;

		// Token: 0x020005AE RID: 1454
		[Token(Token = "0x20005AE")]
		[Serializable]
		public struct SlotAndRenderable
		{
			// Token: 0x040021CF RID: 8655
			[Token(Token = "0x40021CF")]
			[FieldOffset(Offset = "0x0")]
			public WearableSlots Slot;

			// Token: 0x040021D0 RID: 8656
			[Token(Token = "0x40021D0")]
			[FieldOffset(Offset = "0x8")]
			public GameObject Renderable;
		}
	}
}
