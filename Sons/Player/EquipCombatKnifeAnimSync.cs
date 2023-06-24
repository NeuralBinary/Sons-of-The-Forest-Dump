using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Player
{
	// Token: 0x02000657 RID: 1623
	[Token(Token = "0x2000657")]
	[AddComponentMenu("Sons/Player/EquipCombatKnifeAnimSync")]
	public class EquipCombatKnifeAnimSync : MonoBehaviour
	{
		// Token: 0x06002A19 RID: 10777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A19")]
		[Address(RVA = "0x33F6610", Offset = "0x33F4C10", VA = "0x1833F6610")]
		private void OnEnable()
		{
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A1A")]
		[Address(RVA = "0x33F66F0", Offset = "0x33F4CF0", VA = "0x1833F66F0")]
		private void OnDisable()
		{
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A1B")]
		[Address(RVA = "0x33F67D0", Offset = "0x33F4DD0", VA = "0x1833F67D0")]
		private void OnActivateKnife()
		{
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A1C")]
		[Address(RVA = "0x33F6AD0", Offset = "0x33F50D0", VA = "0x1833F6AD0")]
		private void OnDeactivateKnife()
		{
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A1D")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public EquipCombatKnifeAnimSync()
		{
		}

		// Token: 0x04002570 RID: 9584
		[Token(Token = "0x4002570")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationEventReceiver _playerAnimEventReceiver;

		// Token: 0x04002571 RID: 9585
		[Token(Token = "0x4002571")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InventoryProps _inventoryProps;

		// Token: 0x04002572 RID: 9586
		[Token(Token = "0x4002572")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[ItemIdPicker(true)]
		private int _itemId;

		// Token: 0x04002573 RID: 9587
		[Token(Token = "0x4002573")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private EquipmentSlot _slot;

		// Token: 0x04002574 RID: 9588
		[Token(Token = "0x4002574")]
		[FieldOffset(Offset = "0x38")]
		private GameObject _objectInstance;
	}
}
