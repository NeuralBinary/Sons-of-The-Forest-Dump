using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TheForest.UI;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005F2 RID: 1522
	[Token(Token = "0x20005F2")]
	public class LayoutItemCursorSnapping : MonoBehaviour
	{
		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060027A2 RID: 10146 RVA: 0x0000BBF8 File Offset: 0x00009DF8
		[Token(Token = "0x1700053D")]
		public bool IsCursorOverItem
		{
			[Token(Token = "0x60027A2")]
			[Address(RVA = "0x671150", Offset = "0x66F750", VA = "0x180671150")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A3")]
		[Address(RVA = "0x33CA870", Offset = "0x33C8E70", VA = "0x1833CA870")]
		private void Awake()
		{
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A4")]
		[Address(RVA = "0x33CA910", Offset = "0x33C8F10", VA = "0x1833CA910")]
		public void TrySnapToNearestPoint(Vector3 movementDirection)
		{
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A5")]
		[Address(RVA = "0x33CBC00", Offset = "0x33CA200", VA = "0x1833CBC00")]
		public LayoutItemCursorSnapping()
		{
		}

		// Token: 0x040023E6 RID: 9190
		[Token(Token = "0x40023E6")]
		[FieldOffset(Offset = "0x0")]
		private static int _inventoryLayerMask;

		// Token: 0x040023E7 RID: 9191
		[Token(Token = "0x40023E7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _layoutItemsRoot;

		// Token: 0x040023E8 RID: 9192
		[Token(Token = "0x40023E8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _ingredientLayoutItemsRoot;

		// Token: 0x040023E9 RID: 9193
		[Token(Token = "0x40023E9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _resultingLayoutItemsRoot;

		// Token: 0x040023EA RID: 9194
		[Token(Token = "0x40023EA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> _otherSnapPoints;

		// Token: 0x040023EB RID: 9195
		[Token(Token = "0x40023EB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _snapLerpSpeed;

		// Token: 0x040023EC RID: 9196
		[Token(Token = "0x40023EC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<VirtualCursorSnapAnchor> _snapAnchors;

		// Token: 0x040023ED RID: 9197
		[Token(Token = "0x40023ED")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _snapDirectionThreshold;

		// Token: 0x040023EE RID: 9198
		[Token(Token = "0x40023EE")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _maxSnapRange;

		// Token: 0x040023EF RID: 9199
		[Token(Token = "0x40023EF")]
		[FieldOffset(Offset = "0x58")]
		private Camera _currentCamera;

		// Token: 0x040023F0 RID: 9200
		[Token(Token = "0x40023F0")]
		[FieldOffset(Offset = "0x60")]
		private LayoutItem _currentlySnappedLayoutItem;

		// Token: 0x040023F1 RID: 9201
		[Token(Token = "0x40023F1")]
		[FieldOffset(Offset = "0x68")]
		private VirtualCursorSnapAnchor _currentSnapPoint;

		// Token: 0x040023F2 RID: 9202
		[Token(Token = "0x40023F2")]
		[FieldOffset(Offset = "0x70")]
		private bool _cursorIsOverItem;
	}
}
