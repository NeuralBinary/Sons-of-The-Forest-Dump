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
	// Token: 0x020005F3 RID: 1523
	[Token(Token = "0x20005F3")]
	[AddComponentMenu("Sons/Inventory/Inventory Clothing Item")]
	public class InventoryClothingItem : MonoBehaviour, ICustomInventoryItemInteraction
	{
		// Token: 0x060026E8 RID: 9960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E8")]
		[Address(RVA = "0x2D990A0", Offset = "0x2D980A0", VA = "0x182D990A0")]
		private void OnEnable()
		{
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x0000B5F8 File Offset: 0x000097F8
		[Token(Token = "0x60026E9")]
		[Address(RVA = "0x2D99160", Offset = "0x2D98160", VA = "0x182D99160", Slot = "4")]
		public bool TryPerformAction(ItemInstance itemInstance, bool isUnique)
		{
			return default(bool);
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026EA")]
		[Address(RVA = "0x2D991E0", Offset = "0x2D981E0", VA = "0x182D991E0")]
		private IEnumerator WearClothingAnimationComplete()
		{
			return null;
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026EB")]
		[Address(RVA = "0x2D99250", Offset = "0x2D98250", VA = "0x182D99250")]
		public InventoryClothingItem()
		{
		}

		// Token: 0x04002348 RID: 9032
		[Token(Token = "0x4002348")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private ClothingPiece _clothingPiece;

		// Token: 0x04002349 RID: 9033
		[Token(Token = "0x4002349")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[ItemIdPicker(2, true)]
		private int _clothingId;

		// Token: 0x0400234A RID: 9034
		[Token(Token = "0x400234A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _useUpperBodyAnimations;

		// Token: 0x0400234B RID: 9035
		[Token(Token = "0x400234B")]
		[FieldOffset(Offset = "0x2D")]
		[SerializeField]
		private bool _useLowerBodyAnimations;

		// Token: 0x0400234C RID: 9036
		[Token(Token = "0x400234C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[EventRef]
		private string _putOnAudioEvent;

		// Token: 0x0400234D RID: 9037
		[Token(Token = "0x400234D")]
		[FieldOffset(Offset = "0x38")]
		private Animator _playerAnimator;

		// Token: 0x0400234E RID: 9038
		[Token(Token = "0x400234E")]
		[FieldOffset(Offset = "0x40")]
		private PlayerClothingSystem _playerClothingSystem;

		// Token: 0x0400234F RID: 9039
		[Token(Token = "0x400234F")]
		[FieldOffset(Offset = "0x48")]
		private PlayerInventory _playerInventory;

		// Token: 0x04002350 RID: 9040
		[Token(Token = "0x4002350")]
		[FieldOffset(Offset = "0x50")]
		private bool _success;
	}
}
