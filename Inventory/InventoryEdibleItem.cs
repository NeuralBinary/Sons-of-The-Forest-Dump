using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005F5 RID: 1525
	[Token(Token = "0x20005F5")]
	[AddComponentMenu("Sons/Inventory/InventoryEdibleItem")]
	public class InventoryEdibleItem : MonoBehaviour, ICustomInventoryItemInteraction
	{
		// Token: 0x060026F2 RID: 9970 RVA: 0x0000B628 File Offset: 0x00009828
		[Token(Token = "0x60026F2")]
		[Address(RVA = "0x2D9A110", Offset = "0x2D99110", VA = "0x182D9A110", Slot = "4")]
		public bool TryPerformAction(ItemInstance itemInstance, bool isUnique)
		{
			return default(bool);
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F3")]
		[Address(RVA = "0x2D9A070", Offset = "0x2D99070", VA = "0x182D9A070")]
		private void OnConsumeComplete()
		{
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F4")]
		[Address(RVA = "0x2D9A430", Offset = "0x2D99430", VA = "0x182D9A430")]
		public InventoryEdibleItem()
		{
		}

		// Token: 0x04002355 RID: 9045
		[Token(Token = "0x4002355")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _isReusable;

		// Token: 0x04002356 RID: 9046
		[Token(Token = "0x4002356")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _numberOfUses;

		// Token: 0x04002357 RID: 9047
		[Token(Token = "0x4002357")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _shouldAnimate;
	}
}
