using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200067C RID: 1660
	[Token(Token = "0x200067C")]
	[AddComponentMenu("Sons/Pickup/DroppedInventoryItemsPickup")]
	public class DroppedInventoryItemsPickup : PickUp
	{
		// Token: 0x06002A6E RID: 10862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A6E")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "25")]
		protected override void Collect()
		{
		}

		// Token: 0x06002A6F RID: 10863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A6F")]
		[Address(RVA = "0x2DC7730", Offset = "0x2DC6730", VA = "0x182DC7730", Slot = "19")]
		protected override void OnSecondaryHoldInputMethodActive()
		{
		}

		// Token: 0x06002A70 RID: 10864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A70")]
		[Address(RVA = "0x2DC7910", Offset = "0x2DC6910", VA = "0x182DC7910")]
		private void RetrieveInventory()
		{
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A71")]
		[Address(RVA = "0x2DC76C0", Offset = "0x2DC66C0", VA = "0x182DC76C0")]
		private void OnRetrievalCompleteCallback()
		{
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A72")]
		[Address(RVA = "0x2DC6290", Offset = "0x2DC5290", VA = "0x182DC6290")]
		public DroppedInventoryItemsPickup()
		{
		}

		// Token: 0x040025DE RID: 9694
		[Token(Token = "0x40025DE")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Transform _attachLocation;

		// Token: 0x040025DF RID: 9695
		[Token(Token = "0x40025DF")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private DroppedBagUiMarker _pickupMarker;

		// Token: 0x040025E0 RID: 9696
		[Token(Token = "0x40025E0")]
		[FieldOffset(Offset = "0x108")]
		private bool _secondaryHoldInputMethodIsActive;
	}
}
