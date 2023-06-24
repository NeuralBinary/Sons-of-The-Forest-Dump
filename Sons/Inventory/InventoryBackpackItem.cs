using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x02000602 RID: 1538
	[Token(Token = "0x2000602")]
	[AddComponentMenu("Sons/Inventory/InventoryBackpackItem")]
	public class InventoryBackpackItem : MonoBehaviour, ICustomInventoryItemInteraction
	{
		// Token: 0x060027ED RID: 10221 RVA: 0x0000BCB8 File Offset: 0x00009EB8
		[Token(Token = "0x60027ED")]
		[Address(RVA = "0x33CFF80", Offset = "0x33CE580", VA = "0x1833CFF80", Slot = "4")]
		public bool TryPerformAction(ItemInstance itemInstance, bool isUnique)
		{
			return default(bool);
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027EE")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public InventoryBackpackItem()
		{
		}
	}
}
