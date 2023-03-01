using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Inventory
{
	// Token: 0x020005DD RID: 1501
	[Token(Token = "0x20005DD")]
	[AddComponentMenu("Sons/Inventory/InventoryModalMessageBox")]
	public class InventoryModalMessageBox : MonoBehaviour
	{
		// Token: 0x0600267B RID: 9851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267B")]
		[Address(RVA = "0x2DA2FC0", Offset = "0x2DA1FC0", VA = "0x182DA2FC0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267C")]
		[Address(RVA = "0x2DA2E80", Offset = "0x2DA1E80", VA = "0x182DA2E80")]
		private void OnDisable()
		{
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267D")]
		[Address(RVA = "0x921FE0", Offset = "0x920FE0", VA = "0x180921FE0")]
		private void OnCloseModal(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267E")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public InventoryModalMessageBox()
		{
		}

		// Token: 0x040022F1 RID: 8945
		[Token(Token = "0x40022F1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InventoryCursorController _cursorController;
	}
}
