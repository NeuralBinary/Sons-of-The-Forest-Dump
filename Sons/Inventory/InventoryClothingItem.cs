using System;
using System.Collections;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Items.Core;
using Sons.Wearable.Armour.Clothing;
using Sons.Wearable.Clothing;
using TheForest.Items.Inventory;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x02000605 RID: 1541
	[Token(Token = "0x2000605")]
	[AddComponentMenu("Sons/Inventory/Inventory Clothing Item")]
	public class InventoryClothingItem : MonoBehaviour, ICustomInventoryItemInteraction
	{
		// Token: 0x060027F2 RID: 10226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F2")]
		[Address(RVA = "0x33D0170", Offset = "0x33CE770", VA = "0x1833D0170")]
		private void OnEnable()
		{
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		[Token(Token = "0x60027F3")]
		[Address(RVA = "0x33D0320", Offset = "0x33CE920", VA = "0x1833D0320", Slot = "4")]
		public bool TryPerformAction(ItemInstance itemInstance, bool isUnique)
		{
			return default(bool);
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F4")]
		[Address(RVA = "0x33D03C0", Offset = "0x33CE9C0", VA = "0x1833D03C0")]
		private IEnumerator WearClothingAnimationComplete()
		{
			return null;
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F5")]
		[Address(RVA = "0x33D0450", Offset = "0x33CEA50", VA = "0x1833D0450")]
		public InventoryClothingItem()
		{
		}

		// Token: 0x0400242B RID: 9259
		[Token(Token = "0x400242B")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		private ClothingPiece _clothingPiece;

		// Token: 0x0400242C RID: 9260
		[Token(Token = "0x400242C")]
		[FieldOffset(Offset = "0x28")]
		[ItemIdPicker(Types.Clothing, true)]
		[SerializeField]
		private int _clothingId;

		// Token: 0x0400242D RID: 9261
		[Token(Token = "0x400242D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _useUpperBodyAnimations;

		// Token: 0x0400242E RID: 9262
		[Token(Token = "0x400242E")]
		[FieldOffset(Offset = "0x2D")]
		[SerializeField]
		private bool _useLowerBodyAnimations;

		// Token: 0x0400242F RID: 9263
		[Token(Token = "0x400242F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[EventRef]
		private string _putOnAudioEvent;

		// Token: 0x04002430 RID: 9264
		[Token(Token = "0x4002430")]
		[FieldOffset(Offset = "0x38")]
		private Animator _playerAnimator;

		// Token: 0x04002431 RID: 9265
		[Token(Token = "0x4002431")]
		[FieldOffset(Offset = "0x40")]
		private PlayerClothingSystem _playerClothingSystem;

		// Token: 0x04002432 RID: 9266
		[Token(Token = "0x4002432")]
		[FieldOffset(Offset = "0x48")]
		private PlayerInventory _playerInventory;

		// Token: 0x04002433 RID: 9267
		[Token(Token = "0x4002433")]
		[FieldOffset(Offset = "0x50")]
		private bool _success;
	}
}
