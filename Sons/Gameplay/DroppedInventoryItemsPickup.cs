using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200079D RID: 1949
	[Token(Token = "0x200079D")]
	[AddComponentMenu("Sons/Pickup/DroppedInventoryItemsPickup")]
	public class DroppedInventoryItemsPickup : PickUp
	{
		// Token: 0x06003476 RID: 13430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003476")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "27")]
		protected override void Collect()
		{
		}

		// Token: 0x06003477 RID: 13431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003477")]
		[Address(RVA = "0x34CAF60", Offset = "0x34C9560", VA = "0x1834CAF60", Slot = "21")]
		protected override void OnSecondaryHoldInputMethodActive()
		{
		}

		// Token: 0x06003478 RID: 13432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003478")]
		[Address(RVA = "0x34CB030", Offset = "0x34C9630", VA = "0x1834CB030")]
		private void RetrieveInventory()
		{
		}

		// Token: 0x06003479 RID: 13433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003479")]
		[Address(RVA = "0x34CB3D0", Offset = "0x34C99D0", VA = "0x1834CB3D0")]
		private void OnRetrievalCompleteCallback()
		{
		}

		// Token: 0x0600347A RID: 13434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600347A")]
		[Address(RVA = "0x34C7ED0", Offset = "0x34C64D0", VA = "0x1834C7ED0")]
		public DroppedInventoryItemsPickup()
		{
		}

		// Token: 0x04002D3E RID: 11582
		[Token(Token = "0x4002D3E")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Transform _attachLocation;

		// Token: 0x04002D3F RID: 11583
		[Token(Token = "0x4002D3F")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private DroppedBagUiMarker _pickupMarker;

		// Token: 0x04002D40 RID: 11584
		[Token(Token = "0x4002D40")]
		[FieldOffset(Offset = "0x118")]
		private bool _secondaryHoldInputMethodIsActive;
	}
}
