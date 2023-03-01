using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005D8 RID: 1496
	[Token(Token = "0x20005D8")]
	public class InventoryEnableLayoutGroups : MonoBehaviour
	{
		// Token: 0x0600264E RID: 9806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600264E")]
		[Address(RVA = "0x921FE0", Offset = "0x920FE0", VA = "0x180921FE0")]
		private void Awake()
		{
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600264F")]
		[Address(RVA = "0x2D9A600", Offset = "0x2D99600", VA = "0x182D9A600")]
		private void OnEnable()
		{
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002650")]
		[Address(RVA = "0x2D9A5F0", Offset = "0x2D995F0", VA = "0x182D9A5F0")]
		private void OnDisable()
		{
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002651")]
		[Address(RVA = "0x2D9A450", Offset = "0x2D99450", VA = "0x182D9A450")]
		private void EnableGroups(bool enable)
		{
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002652")]
		[Address(RVA = "0x2D9A610", Offset = "0x2D99610", VA = "0x182D9A610")]
		public InventoryEnableLayoutGroups()
		{
		}

		// Token: 0x040022B6 RID: 8886
		[Token(Token = "0x40022B6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<InventoryLayoutItemGroup> _layoutGroups;
	}
}
