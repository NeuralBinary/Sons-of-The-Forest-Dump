using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TheForest.UI;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005E1 RID: 1505
	[Token(Token = "0x20005E1")]
	public class LayoutItemCursorSnapping : MonoBehaviour
	{
		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06002699 RID: 9881 RVA: 0x0000B508 File Offset: 0x00009708
		[Token(Token = "0x17000528")]
		public bool IsCursorOverItem
		{
			[Token(Token = "0x6002699")]
			[Address(RVA = "0x5F0C80", Offset = "0x5EFC80", VA = "0x1805F0C80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269A")]
		[Address(RVA = "0x2DA41D0", Offset = "0x2DA31D0", VA = "0x182DA41D0")]
		private void Awake()
		{
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269B")]
		[Address(RVA = "0x2DA4230", Offset = "0x2DA3230", VA = "0x182DA4230")]
		public void TrySnapToNearestPoint(Vector3 movementDirection)
		{
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269C")]
		[Address(RVA = "0x2DA4DA0", Offset = "0x2DA3DA0", VA = "0x182DA4DA0")]
		public LayoutItemCursorSnapping()
		{
		}

		// Token: 0x04002308 RID: 8968
		[Token(Token = "0x4002308")]
		[FieldOffset(Offset = "0x0")]
		private static int _inventoryLayerMask;

		// Token: 0x04002309 RID: 8969
		[Token(Token = "0x4002309")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _layoutItemsRoot;

		// Token: 0x0400230A RID: 8970
		[Token(Token = "0x400230A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _ingredientLayoutItemsRoot;

		// Token: 0x0400230B RID: 8971
		[Token(Token = "0x400230B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _resultingLayoutItemsRoot;

		// Token: 0x0400230C RID: 8972
		[Token(Token = "0x400230C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> _otherSnapPoints;

		// Token: 0x0400230D RID: 8973
		[Token(Token = "0x400230D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _snapLerpSpeed;

		// Token: 0x0400230E RID: 8974
		[Token(Token = "0x400230E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<VirtualCursorSnapAnchor> _snapAnchors;

		// Token: 0x0400230F RID: 8975
		[Token(Token = "0x400230F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _snapDirectionThreshold;

		// Token: 0x04002310 RID: 8976
		[Token(Token = "0x4002310")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _maxSnapRange;

		// Token: 0x04002311 RID: 8977
		[Token(Token = "0x4002311")]
		[FieldOffset(Offset = "0x58")]
		private Camera _currentCamera;

		// Token: 0x04002312 RID: 8978
		[Token(Token = "0x4002312")]
		[FieldOffset(Offset = "0x60")]
		private LayoutItem _currentlySnappedLayoutItem;

		// Token: 0x04002313 RID: 8979
		[Token(Token = "0x4002313")]
		[FieldOffset(Offset = "0x68")]
		private VirtualCursorSnapAnchor _currentSnapPoint;

		// Token: 0x04002314 RID: 8980
		[Token(Token = "0x4002314")]
		[FieldOffset(Offset = "0x70")]
		private bool _cursorIsOverItem;
	}
}
