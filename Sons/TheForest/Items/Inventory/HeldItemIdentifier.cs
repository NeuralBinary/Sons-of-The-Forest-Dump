using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace TheForest.Items.Inventory
{
	// Token: 0x020004A3 RID: 1187
	[Token(Token = "0x20004A3")]
	[AddComponentMenu("Items/Inventory/HeldItemIdentifier")]
	public class HeldItemIdentifier : MonoBehaviour
	{
		// Token: 0x06001EC3 RID: 7875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC3")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public HeldItemIdentifier()
		{
		}

		// Token: 0x04001CAE RID: 7342
		[Token(Token = "0x4001CAE")]
		[FieldOffset(Offset = "0x20")]
		[ItemIdPicker(true)]
		public int _itemId;
	}
}
