using System;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Items.Core;
using Sons.Wearable.Armour;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x02000601 RID: 1537
	[Token(Token = "0x2000601")]
	[AddComponentMenu("Sons/Inventory/InventoryArmourItem")]
	public class InventoryArmourItem : MonoBehaviour, ICustomInventoryItemInteraction
	{
		// Token: 0x060027EA RID: 10218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027EA")]
		[Address(RVA = "0x33CFC50", Offset = "0x33CE250", VA = "0x1833CFC50")]
		private void OnEnable()
		{
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x0000BCA0 File Offset: 0x00009EA0
		[Token(Token = "0x60027EB")]
		[Address(RVA = "0x33CFD90", Offset = "0x33CE390", VA = "0x1833CFD90", Slot = "4")]
		public bool TryPerformAction(ItemInstance itemInstance, bool isUnique)
		{
			return default(bool);
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027EC")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public InventoryArmourItem()
		{
		}

		// Token: 0x0400241F RID: 9247
		[Token(Token = "0x400241F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArmourPiece _armourPiece;

		// Token: 0x04002420 RID: 9248
		[Token(Token = "0x4002420")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[ItemIdPicker(Types.Armor, true)]
		private int _itemId;

		// Token: 0x04002421 RID: 9249
		[Token(Token = "0x4002421")]
		[FieldOffset(Offset = "0x30")]
		[EventRef]
		[SerializeField]
		private string _putOnAudioEvent;

		// Token: 0x04002422 RID: 9250
		[Token(Token = "0x4002422")]
		[FieldOffset(Offset = "0x38")]
		private PlayerArmourSystem _armourSystem;

		// Token: 0x04002423 RID: 9251
		[Token(Token = "0x4002423")]
		[FieldOffset(Offset = "0x40")]
		private Animator _playerAnimator;
	}
}
