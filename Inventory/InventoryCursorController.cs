using System;
using Il2CppDummyDll;
using TheForest.UI;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Inventory
{
	// Token: 0x020005D7 RID: 1495
	[Token(Token = "0x20005D7")]
	[AddComponentMenu("Sons/Inventory/InventoryCursorController")]
	public class InventoryCursorController : MonoBehaviour
	{
		// Token: 0x06002648 RID: 9800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002648")]
		[Address(RVA = "0x2D99E10", Offset = "0x2D98E10", VA = "0x182D99E10")]
		private void OnEnable()
		{
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002649")]
		[Address(RVA = "0x2D99CF0", Offset = "0x2D98CF0", VA = "0x182D99CF0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600264A")]
		[Address(RVA = "0x2D99C10", Offset = "0x2D98C10", VA = "0x182D99C10")]
		private void OnCursorMoved(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600264B")]
		[Address(RVA = "0x2D99260", Offset = "0x2D98260", VA = "0x182D99260")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600264C")]
		[Address(RVA = "0x2D99FA0", Offset = "0x2D98FA0", VA = "0x182D99FA0")]
		public void ResetCursorPosition()
		{
		}

		// Token: 0x0600264D RID: 9805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600264D")]
		[Address(RVA = "0x2D9A050", Offset = "0x2D99050", VA = "0x182D9A050")]
		public InventoryCursorController()
		{
		}

		// Token: 0x040022A8 RID: 8872
		[Token(Token = "0x40022A8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _cursorTransform;

		// Token: 0x040022A9 RID: 8873
		[Token(Token = "0x40022A9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InventoryCameraController _inventoryCameraController;

		// Token: 0x040022AA RID: 8874
		[Token(Token = "0x40022AA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _layer;

		// Token: 0x040022AB RID: 8875
		[Token(Token = "0x40022AB")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _cursorMouseSpeed;

		// Token: 0x040022AC RID: 8876
		[Token(Token = "0x40022AC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _cursorGamepadSpeed;

		// Token: 0x040022AD RID: 8877
		[Token(Token = "0x40022AD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _cursorState;

		// Token: 0x040022AE RID: 8878
		[Token(Token = "0x40022AE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private LayoutItemCursorSnapping _cursorSnapping;

		// Token: 0x040022AF RID: 8879
		[Token(Token = "0x40022AF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _cursorThrottleSpeedWhenOverItem;

		// Token: 0x040022B0 RID: 8880
		[Token(Token = "0x40022B0")]
		[FieldOffset(Offset = "0x54")]
		private bool _cursorMovedThisFrame;

		// Token: 0x040022B1 RID: 8881
		[Token(Token = "0x40022B1")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 _movementDirection;

		// Token: 0x040022B2 RID: 8882
		[Token(Token = "0x40022B2")]
		[FieldOffset(Offset = "0x64")]
		private Vector2 _cursorDelta;

		// Token: 0x040022B3 RID: 8883
		[Token(Token = "0x40022B3")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 _cursorPositionLastUpdate;

		// Token: 0x040022B4 RID: 8884
		[Token(Token = "0x40022B4")]
		[FieldOffset(Offset = "0x78")]
		private LayoutItem _currentlySnappedLayoutItem;

		// Token: 0x040022B5 RID: 8885
		[Token(Token = "0x40022B5")]
		[FieldOffset(Offset = "0x80")]
		private VirtualCursorSnapAnchor _currentSnapPoint;
	}
}
