using System;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Inventory;
using Sons.Player;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x020008FB RID: 2299
	[Token(Token = "0x20008FB")]
	[AddComponentMenu("Sons/Animation/ConsumingAnimationEventsProxy")]
	public class ConsumingAnimationEventsProxy : MonoBehaviour
	{
		// Token: 0x06004241 RID: 16961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004241")]
		[Address(RVA = "0x36333F0", Offset = "0x36319F0", VA = "0x1836333F0")]
		private void OnEnable()
		{
		}

		// Token: 0x06004242 RID: 16962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004242")]
		[Address(RVA = "0x3633480", Offset = "0x3631A80", VA = "0x183633480")]
		private void OnHeldItemInitialized(GameObject newInstance, InventoryProps.PropDefinition propDefinition, ItemInstance itemInstance)
		{
		}

		// Token: 0x06004243 RID: 16963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004243")]
		[Address(RVA = "0x36334E0", Offset = "0x3631AE0", VA = "0x1836334E0")]
		public void CheckForBadFoodIngested()
		{
		}

		// Token: 0x06004244 RID: 16964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004244")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ConsumingAnimationEventsProxy()
		{
		}

		// Token: 0x0400459E RID: 17822
		[Token(Token = "0x400459E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[EventRef]
		private string _badFoodEaten;

		// Token: 0x0400459F RID: 17823
		[Token(Token = "0x400459F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InventoryProps _inventoryProps;

		// Token: 0x040045A0 RID: 17824
		[Token(Token = "0x40045A0")]
		[FieldOffset(Offset = "0x30")]
		private ItemInstance _itemInstance;
	}
}
