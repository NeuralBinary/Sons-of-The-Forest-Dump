using System;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Items.Core;
using Sons.Wearable.Armour;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005EF RID: 1519
	[Token(Token = "0x20005EF")]
	[AddComponentMenu("Sons/Inventory/InventoryArmourItem")]
	public class InventoryArmourItem : MonoBehaviour, ICustomInventoryItemInteraction
	{
		// Token: 0x060026E0 RID: 9952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E0")]
		[Address(RVA = "0x2D94730", Offset = "0x2D93730", VA = "0x182D94730")]
		private void OnEnable()
		{
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x0000B5B0 File Offset: 0x000097B0
		[Token(Token = "0x60026E1")]
		[Address(RVA = "0x2D947D0", Offset = "0x2D937D0", VA = "0x182D947D0", Slot = "4")]
		public bool TryPerformAction(ItemInstance itemInstance, bool isUnique)
		{
			return default(bool);
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E2")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public InventoryArmourItem()
		{
		}

		// Token: 0x0400233C RID: 9020
		[Token(Token = "0x400233C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArmourPiece _armourPiece;

		// Token: 0x0400233D RID: 9021
		[Token(Token = "0x400233D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[ItemIdPicker(16384, true)]
		private int _itemId;

		// Token: 0x0400233E RID: 9022
		[Token(Token = "0x400233E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[EventRef]
		private string _putOnAudioEvent;

		// Token: 0x0400233F RID: 9023
		[Token(Token = "0x400233F")]
		[FieldOffset(Offset = "0x38")]
		private PlayerArmourSystem _armourSystem;

		// Token: 0x04002340 RID: 9024
		[Token(Token = "0x4002340")]
		[FieldOffset(Offset = "0x40")]
		private Animator _playerAnimator;
	}
}
