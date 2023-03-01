using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005F0 RID: 1520
	[Token(Token = "0x20005F0")]
	[AddComponentMenu("Sons/Inventory/InventoryBackpackItem")]
	public class InventoryBackpackItem : MonoBehaviour, ICustomInventoryItemInteraction
	{
		// Token: 0x060026E3 RID: 9955 RVA: 0x0000B5C8 File Offset: 0x000097C8
		[Token(Token = "0x60026E3")]
		[Address(RVA = "0x2D94970", Offset = "0x2D93970", VA = "0x182D94970", Slot = "4")]
		public bool TryPerformAction(ItemInstance itemInstance, bool isUnique)
		{
			return default(bool);
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E4")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public InventoryBackpackItem()
		{
		}
	}
}
