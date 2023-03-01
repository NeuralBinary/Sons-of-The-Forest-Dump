using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace TheForest.Items.Inventory
{
	// Token: 0x020004AD RID: 1197
	[Token(Token = "0x20004AD")]
	[AddComponentMenu("Items/Inventory/HeldItemIdentifier")]
	public class HeldItemIdentifier : MonoBehaviour
	{
		// Token: 0x06001E6F RID: 7791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E6F")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public HeldItemIdentifier()
		{
		}

		// Token: 0x04001C78 RID: 7288
		[Token(Token = "0x4001C78")]
		[FieldOffset(Offset = "0x20")]
		[ItemIdPicker(true)]
		public int _itemId;
	}
}
