using System;
using Il2CppDummyDll;
using Sons.Inventory;
using Sons.Wearable.Clothing;
using TheForest.Items.Inventory;
using UnityEngine;

namespace Sons.Items
{
	// Token: 0x0200073E RID: 1854
	[Token(Token = "0x200073E")]
	public class BackpackVisuals : MonoBehaviour
	{
		// Token: 0x06003183 RID: 12675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003183")]
		[Address(RVA = "0x348C2D0", Offset = "0x348A8D0", VA = "0x18348C2D0")]
		private void OnEnable()
		{
		}

		// Token: 0x06003184 RID: 12676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003184")]
		[Address(RVA = "0x348C580", Offset = "0x348AB80", VA = "0x18348C580")]
		private void OnItemUnequipped(ItemInstance _, int itemId)
		{
		}

		// Token: 0x06003185 RID: 12677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003185")]
		[Address(RVA = "0x348C5D0", Offset = "0x348ABD0", VA = "0x18348C5D0")]
		private void OnItemEquipped(ItemInstance _, int itemId)
		{
		}

		// Token: 0x06003186 RID: 12678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003186")]
		[Address(RVA = "0x348C620", Offset = "0x348AC20", VA = "0x18348C620")]
		private void OnItemAdded(ItemInstance _, int itemId)
		{
		}

		// Token: 0x06003187 RID: 12679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003187")]
		[Address(RVA = "0x348C690", Offset = "0x348AC90", VA = "0x18348C690")]
		private void OnItemRemoved(ItemInstance _, int itemId)
		{
		}

		// Token: 0x06003188 RID: 12680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003188")]
		[Address(RVA = "0x348C6E0", Offset = "0x348ACE0", VA = "0x18348C6E0")]
		private void ShowBackpack(bool show)
		{
		}

		// Token: 0x06003189 RID: 12681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003189")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public BackpackVisuals()
		{
		}

		// Token: 0x04002AB9 RID: 10937
		[Token(Token = "0x4002AB9")]
		[FieldOffset(Offset = "0x20")]
		private PlayerInventory _inventory;

		// Token: 0x04002ABA RID: 10938
		[Token(Token = "0x4002ABA")]
		[FieldOffset(Offset = "0x28")]
		private PlayerClothingSystem _clothing;
	}
}
