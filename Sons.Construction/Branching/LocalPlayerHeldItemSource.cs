using System;
using Il2CppDummyDll;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Construction.Branching
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	[AddComponentMenu("Sons/Construction/Presets/LocalPlayerHeldItemSource")]
	public class LocalPlayerHeldItemSource : MonoBehaviour, IItemSource
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2D5EF70", Offset = "0x2D5D570", VA = "0x182D5EF70", Slot = "4")]
		public ItemInstance GetCurrentItem()
		{
			return null;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2D5F0F0", Offset = "0x2D5D6F0", VA = "0x182D5F0F0", Slot = "5")]
		public bool TryRemove(ItemInstance item)
		{
			return default(bool);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000251C File Offset: 0x0000071C
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2D5F190", Offset = "0x2D5D790", VA = "0x182D5F190", Slot = "6")]
		public bool TryEquip(ItemInstance item)
		{
			return default(bool);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public LocalPlayerHeldItemSource()
		{
		}
	}
}
