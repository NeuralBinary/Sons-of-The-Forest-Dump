using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Inventory
{
	// Token: 0x020005EE RID: 1518
	[Token(Token = "0x20005EE")]
	[AddComponentMenu("Sons/Inventory/InventoryModalMessageBox")]
	public class InventoryModalMessageBox : MonoBehaviour
	{
		// Token: 0x06002784 RID: 10116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002784")]
		[Address(RVA = "0x33C89C0", Offset = "0x33C6FC0", VA = "0x1833C89C0")]
		private void OnEnable()
		{
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002785")]
		[Address(RVA = "0x33C8B90", Offset = "0x33C7190", VA = "0x1833C8B90")]
		private void OnDisable()
		{
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002786")]
		[Address(RVA = "0xA71C70", Offset = "0xA70270", VA = "0x180A71C70")]
		private void OnCloseModal(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002787")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public InventoryModalMessageBox()
		{
		}

		// Token: 0x040023CF RID: 9167
		[Token(Token = "0x40023CF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InventoryCursorController _cursorController;
	}
}
