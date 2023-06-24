using System;
using Il2CppDummyDll;
using TheForest.UI;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Inventory
{
	// Token: 0x020005E8 RID: 1512
	[Token(Token = "0x20005E8")]
	[AddComponentMenu("Sons/Inventory/InventoryCursorController")]
	public class InventoryCursorController : MonoBehaviour
	{
		// Token: 0x06002751 RID: 10065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002751")]
		[Address(RVA = "0x33C2650", Offset = "0x33C0C50", VA = "0x1833C2650")]
		private void OnEnable()
		{
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002752")]
		[Address(RVA = "0x33C2870", Offset = "0x33C0E70", VA = "0x1833C2870")]
		private void OnDisable()
		{
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002753")]
		[Address(RVA = "0x33C2A30", Offset = "0x33C1030", VA = "0x1833C2A30")]
		private void OnCursorMoved(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002754")]
		[Address(RVA = "0x33C2B70", Offset = "0x33C1170", VA = "0x1833C2B70")]
		private void LateUpdate()
		{
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002755")]
		[Address(RVA = "0x33C3920", Offset = "0x33C1F20", VA = "0x1833C3920")]
		public void ResetCursorPosition()
		{
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002756")]
		[Address(RVA = "0x33C3A50", Offset = "0x33C2050", VA = "0x1833C3A50")]
		public InventoryCursorController()
		{
		}

		// Token: 0x04002386 RID: 9094
		[Token(Token = "0x4002386")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _cursorTransform;

		// Token: 0x04002387 RID: 9095
		[Token(Token = "0x4002387")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InventoryCameraController _inventoryCameraController;

		// Token: 0x04002388 RID: 9096
		[Token(Token = "0x4002388")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _layer;

		// Token: 0x04002389 RID: 9097
		[Token(Token = "0x4002389")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _cursorMouseSpeed;

		// Token: 0x0400238A RID: 9098
		[Token(Token = "0x400238A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _cursorGamepadSpeed;

		// Token: 0x0400238B RID: 9099
		[Token(Token = "0x400238B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _cursorState;

		// Token: 0x0400238C RID: 9100
		[Token(Token = "0x400238C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private LayoutItemCursorSnapping _cursorSnapping;

		// Token: 0x0400238D RID: 9101
		[Token(Token = "0x400238D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _cursorThrottleSpeedWhenOverItem;

		// Token: 0x0400238E RID: 9102
		[Token(Token = "0x400238E")]
		[FieldOffset(Offset = "0x54")]
		private bool _cursorMovedThisFrame;

		// Token: 0x0400238F RID: 9103
		[Token(Token = "0x400238F")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 _movementDirection;

		// Token: 0x04002390 RID: 9104
		[Token(Token = "0x4002390")]
		[FieldOffset(Offset = "0x64")]
		private Vector2 _cursorDelta;

		// Token: 0x04002391 RID: 9105
		[Token(Token = "0x4002391")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 _cursorPositionLastUpdate;

		// Token: 0x04002392 RID: 9106
		[Token(Token = "0x4002392")]
		[FieldOffset(Offset = "0x78")]
		private LayoutItem _currentlySnappedLayoutItem;

		// Token: 0x04002393 RID: 9107
		[Token(Token = "0x4002393")]
		[FieldOffset(Offset = "0x80")]
		private VirtualCursorSnapAnchor _currentSnapPoint;
	}
}
