using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Player
{
	// Token: 0x0200074D RID: 1869
	[Token(Token = "0x200074D")]
	[AddComponentMenu("Sons/Player/EquipCombatKnifeAnimSync")]
	public class EquipCombatKnifeAnimSync : MonoBehaviour
	{
		// Token: 0x060030AF RID: 12463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030AF")]
		[Address(RVA = "0x2E45540", Offset = "0x2E44540", VA = "0x182E45540")]
		private void OnEnable()
		{
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030B0")]
		[Address(RVA = "0x2E45460", Offset = "0x2E44460", VA = "0x182E45460")]
		private void OnDisable()
		{
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030B1")]
		[Address(RVA = "0x2E451A0", Offset = "0x2E441A0", VA = "0x182E451A0")]
		private void OnActivateKnife()
		{
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030B2")]
		[Address(RVA = "0x2E453D0", Offset = "0x2E443D0", VA = "0x182E453D0")]
		private void OnDeactivateKnife()
		{
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030B3")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public EquipCombatKnifeAnimSync()
		{
		}

		// Token: 0x04002AA3 RID: 10915
		[Token(Token = "0x4002AA3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationEventReceiver _playerAnimEventReceiver;

		// Token: 0x04002AA4 RID: 10916
		[Token(Token = "0x4002AA4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InventoryProps _inventoryProps;

		// Token: 0x04002AA5 RID: 10917
		[Token(Token = "0x4002AA5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[ItemIdPicker(true)]
		private int _itemId;

		// Token: 0x04002AA6 RID: 10918
		[Token(Token = "0x4002AA6")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private EquipmentSlot _slot;

		// Token: 0x04002AA7 RID: 10919
		[Token(Token = "0x4002AA7")]
		[FieldOffset(Offset = "0x38")]
		private GameObject _objectInstance;
	}
}
