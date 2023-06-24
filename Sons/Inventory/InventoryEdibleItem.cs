using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x02000607 RID: 1543
	[Token(Token = "0x2000607")]
	[AddComponentMenu("Sons/Inventory/InventoryEdibleItem")]
	public class InventoryEdibleItem : MonoBehaviour, ICustomInventoryItemInteraction
	{
		// Token: 0x060027FC RID: 10236 RVA: 0x0000BD18 File Offset: 0x00009F18
		[Token(Token = "0x60027FC")]
		[Address(RVA = "0x33D0970", Offset = "0x33CEF70", VA = "0x1833D0970", Slot = "4")]
		public bool TryPerformAction(ItemInstance itemInstance, bool isUnique)
		{
			return default(bool);
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027FD")]
		[Address(RVA = "0x33D0C40", Offset = "0x33CF240", VA = "0x1833D0C40")]
		private void OnConsumeComplete()
		{
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027FE")]
		[Address(RVA = "0x33D0D30", Offset = "0x33CF330", VA = "0x1833D0D30")]
		public InventoryEdibleItem()
		{
		}

		// Token: 0x04002438 RID: 9272
		[Token(Token = "0x4002438")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _isReusable;

		// Token: 0x04002439 RID: 9273
		[Token(Token = "0x4002439")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _numberOfUses;

		// Token: 0x0400243A RID: 9274
		[Token(Token = "0x400243A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _shouldAnimate;

		// Token: 0x0400243B RID: 9275
		[Token(Token = "0x400243B")]
		[FieldOffset(Offset = "0x30")]
		private VolumeContainerItemInstanceModule _volumeModule;
	}
}
