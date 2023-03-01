using System;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Inventory;
using Sons.Player;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x02000889 RID: 2185
	[Token(Token = "0x2000889")]
	[AddComponentMenu("Sons/Animation/ConsumingAnimationEventsProxy")]
	public class ConsumingAnimationEventsProxy : MonoBehaviour
	{
		// Token: 0x06003B15 RID: 15125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B15")]
		[Address(RVA = "0x2EF9920", Offset = "0x2EF8920", VA = "0x182EF9920")]
		private void OnEnable()
		{
		}

		// Token: 0x06003B16 RID: 15126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B16")]
		[Address(RVA = "0x2EF99B0", Offset = "0x2EF89B0", VA = "0x182EF99B0")]
		private void OnHeldItemInitialized(GameObject newInstance, InventoryProps.PropDefinition propDefinition, ItemInstance itemInstance)
		{
		}

		// Token: 0x06003B17 RID: 15127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B17")]
		[Address(RVA = "0x2EF9830", Offset = "0x2EF8830", VA = "0x182EF9830")]
		public void CheckForBadFoodIngested()
		{
		}

		// Token: 0x06003B18 RID: 15128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B18")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public ConsumingAnimationEventsProxy()
		{
		}

		// Token: 0x04003F73 RID: 16243
		[Token(Token = "0x4003F73")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[EventRef]
		private string _badFoodEaten;

		// Token: 0x04003F74 RID: 16244
		[Token(Token = "0x4003F74")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InventoryProps _inventoryProps;

		// Token: 0x04003F75 RID: 16245
		[Token(Token = "0x4003F75")]
		[FieldOffset(Offset = "0x30")]
		private ItemInstance _itemInstance;
	}
}
