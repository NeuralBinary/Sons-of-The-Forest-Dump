using System;
using Il2CppDummyDll;
using NGUI.Internal;
using NGUI.UI;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000D2")]
	[RequireComponent(typeof(UIPanel))]
	[AddComponentMenu("NGUI/Interaction/Scroll View")]
	[ExecuteInEditMode]
	public class UIScrollView : MonoBehaviour
	{
		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000173")]
		public UIPanel panel
		{
			[Token(Token = "0x600077A")]
			[Address(RVA = "0x750FA0", Offset = "0x74F5A0", VA = "0x180750FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x000048F0 File Offset: 0x00002AF0
		[Token(Token = "0x17000174")]
		public bool isDragging
		{
			[Token(Token = "0x600077B")]
			[Address(RVA = "0x26D7250", Offset = "0x26D5850", VA = "0x1826D7250")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x00004908 File Offset: 0x00002B08
		[Token(Token = "0x17000175")]
		public virtual Bounds bounds
		{
			[Token(Token = "0x600077C")]
			[Address(RVA = "0x26D7270", Offset = "0x26D5870", VA = "0x1826D7270", Slot = "4")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x00004920 File Offset: 0x00002B20
		[Token(Token = "0x17000176")]
		public bool canMoveHorizontally
		{
			[Token(Token = "0x600077D")]
			[Address(RVA = "0x26D7390", Offset = "0x26D5990", VA = "0x1826D7390")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x00004938 File Offset: 0x00002B38
		[Token(Token = "0x17000177")]
		public bool canMoveVertically
		{
			[Token(Token = "0x600077E")]
			[Address(RVA = "0x26D73C0", Offset = "0x26D59C0", VA = "0x1826D73C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x00004950 File Offset: 0x00002B50
		[Token(Token = "0x17000178")]
		public virtual bool shouldMoveHorizontally
		{
			[Token(Token = "0x600077F")]
			[Address(RVA = "0x26D73F0", Offset = "0x26D59F0", VA = "0x1826D73F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x00004968 File Offset: 0x00002B68
		[Token(Token = "0x17000179")]
		public virtual bool shouldMoveVertically
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x26D7490", Offset = "0x26D5A90", VA = "0x1826D7490", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x00004980 File Offset: 0x00002B80
		[Token(Token = "0x1700017A")]
		protected virtual bool shouldMove
		{
			[Token(Token = "0x6000781")]
			[Address(RVA = "0x26D7530", Offset = "0x26D5B30", VA = "0x1826D7530", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00004998 File Offset: 0x00002B98
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017B")]
		public Vector3 currentMomentum
		{
			[Token(Token = "0x6000782")]
			[Address(RVA = "0x26D78B0", Offset = "0x26D5EB0", VA = "0x1826D78B0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000783")]
			[Address(RVA = "0x26D78D0", Offset = "0x26D5ED0", VA = "0x1826D78D0")]
			set
			{
			}
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x26D78F0", Offset = "0x26D5EF0", VA = "0x1826D78F0")]
		private void Awake()
		{
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x26D7C20", Offset = "0x26D6220", VA = "0x1826D7C20")]
		private void OnEnable()
		{
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x26D7D20", Offset = "0x26D6320", VA = "0x1826D7D20")]
		private void Start()
		{
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x26D7DC0", Offset = "0x26D63C0", VA = "0x1826D7DC0")]
		private void CheckScrollbars()
		{
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x26D8150", Offset = "0x26D6750", VA = "0x1826D8150")]
		private void OnDisable()
		{
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x000049B0 File Offset: 0x00002BB0
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x26D81D0", Offset = "0x26D67D0", VA = "0x1826D81D0")]
		public bool RestrictWithinBounds(bool instant)
		{
			return default(bool);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x000049C8 File Offset: 0x00002BC8
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x26D81F0", Offset = "0x26D67F0", VA = "0x1826D81F0")]
		public bool RestrictWithinBounds(bool instant, bool horizontal, bool vertical)
		{
			return default(bool);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x26D8590", Offset = "0x26D6B90", VA = "0x1826D8590")]
		public void DisableSpring()
		{
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x2169380", Offset = "0x2167980", VA = "0x182169380")]
		public void UpdateScrollbars()
		{
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x26D86B0", Offset = "0x26D6CB0", VA = "0x1826D86B0", Slot = "8")]
		public virtual void UpdateScrollbars(bool recalculateBounds)
		{
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x26D8D20", Offset = "0x26D7320", VA = "0x1826D8D20")]
		protected void UpdateScrollbars(UIProgressBar slider, float contentMin, float contentMax, float contentSize, float viewSize, bool inverted)
		{
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x26D90C0", Offset = "0x26D76C0", VA = "0x1826D90C0", Slot = "9")]
		public virtual void SetDragAmount(float x, float y, bool updateScrollbars)
		{
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x26D9640", Offset = "0x26D7C40", VA = "0x1826D9640")]
		public void InvalidateBounds()
		{
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x26D9650", Offset = "0x26D7C50", VA = "0x1826D9650")]
		[ContextMenu("Reset Clipping Position")]
		public void ResetPosition()
		{
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x26D9720", Offset = "0x26D7D20", VA = "0x1826D9720")]
		public void UpdatePosition()
		{
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x26D9A90", Offset = "0x26D8090", VA = "0x1826D9A90")]
		public void OnScrollBar()
		{
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x26D9CB0", Offset = "0x26D82B0", VA = "0x1826D9CB0", Slot = "10")]
		public virtual void MoveRelative(Vector3 relative)
		{
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x26D9E30", Offset = "0x26D8430", VA = "0x1826D9E30")]
		public void MoveAbsolute(Vector3 absolute)
		{
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x26D9FD0", Offset = "0x26D85D0", VA = "0x1826D9FD0")]
		public void Press(bool pressed)
		{
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x26DA620", Offset = "0x26D8C20", VA = "0x1826DA620")]
		public void Drag()
		{
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x26DAF80", Offset = "0x26D9580", VA = "0x1826DAF80")]
		public void Scroll(float delta)
		{
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x26DB120", Offset = "0x26D9720", VA = "0x1826DB120")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x26DBB10", Offset = "0x26DA110", VA = "0x1826DBB10")]
		public void OnPan(Vector2 delta)
		{
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x26DBE00", Offset = "0x26DA400", VA = "0x1826DBE00")]
		public UIScrollView()
		{
		}

		// Token: 0x04000582 RID: 1410
		[Token(Token = "0x4000582")]
		[FieldOffset(Offset = "0x0")]
		public static BetterList<UIScrollView> list;

		// Token: 0x04000583 RID: 1411
		[Token(Token = "0x4000583")]
		[FieldOffset(Offset = "0x20")]
		public UIScrollView.Movement movement;

		// Token: 0x04000584 RID: 1412
		[Token(Token = "0x4000584")]
		[FieldOffset(Offset = "0x24")]
		public UIScrollView.DragEffect dragEffect;

		// Token: 0x04000585 RID: 1413
		[Token(Token = "0x4000585")]
		[FieldOffset(Offset = "0x28")]
		public bool restrictWithinPanel;

		// Token: 0x04000586 RID: 1414
		[Token(Token = "0x4000586")]
		[FieldOffset(Offset = "0x29")]
		public bool disableDragIfFits;

		// Token: 0x04000587 RID: 1415
		[Token(Token = "0x4000587")]
		[FieldOffset(Offset = "0x2A")]
		public bool smoothDragStart;

		// Token: 0x04000588 RID: 1416
		[Token(Token = "0x4000588")]
		[FieldOffset(Offset = "0x2B")]
		public bool iOSDragEmulation;

		// Token: 0x04000589 RID: 1417
		[Token(Token = "0x4000589")]
		[FieldOffset(Offset = "0x2C")]
		public float scrollWheelFactor;

		// Token: 0x0400058A RID: 1418
		[Token(Token = "0x400058A")]
		[FieldOffset(Offset = "0x30")]
		public float momentumAmount;

		// Token: 0x0400058B RID: 1419
		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0x34")]
		public float dampenStrength;

		// Token: 0x0400058C RID: 1420
		[Token(Token = "0x400058C")]
		[FieldOffset(Offset = "0x38")]
		public UIProgressBar horizontalScrollBar;

		// Token: 0x0400058D RID: 1421
		[Token(Token = "0x400058D")]
		[FieldOffset(Offset = "0x40")]
		public UIProgressBar verticalScrollBar;

		// Token: 0x0400058E RID: 1422
		[Token(Token = "0x400058E")]
		[FieldOffset(Offset = "0x48")]
		public UIScrollView.ShowCondition showScrollBars;

		// Token: 0x0400058F RID: 1423
		[Token(Token = "0x400058F")]
		[FieldOffset(Offset = "0x4C")]
		public Vector2 customMovement;

		// Token: 0x04000590 RID: 1424
		[Token(Token = "0x4000590")]
		[FieldOffset(Offset = "0x54")]
		public UIWidget.Pivot contentPivot;

		// Token: 0x04000591 RID: 1425
		[Token(Token = "0x4000591")]
		[FieldOffset(Offset = "0x58")]
		public UIScrollView.OnDragNotification onDragStarted;

		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x4000592")]
		[FieldOffset(Offset = "0x60")]
		public UIScrollView.OnDragNotification onDragFinished;

		// Token: 0x04000593 RID: 1427
		[Token(Token = "0x4000593")]
		[FieldOffset(Offset = "0x68")]
		public UIScrollView.OnDragNotification onMomentumMove;

		// Token: 0x04000594 RID: 1428
		[Token(Token = "0x4000594")]
		[FieldOffset(Offset = "0x70")]
		public UIScrollView.OnDragNotification onStoppedMoving;

		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000595")]
		[FieldOffset(Offset = "0x78")]
		[HideInInspector]
		[SerializeField]
		private Vector3 scale;

		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000596")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		[HideInInspector]
		private Vector2 relativePositionOnReset;

		// Token: 0x04000597 RID: 1431
		[Token(Token = "0x4000597")]
		[FieldOffset(Offset = "0x90")]
		protected Transform mTrans;

		// Token: 0x04000598 RID: 1432
		[Token(Token = "0x4000598")]
		[FieldOffset(Offset = "0x98")]
		protected UIPanel mPanel;

		// Token: 0x04000599 RID: 1433
		[Token(Token = "0x4000599")]
		[FieldOffset(Offset = "0xA0")]
		protected Plane mPlane;

		// Token: 0x0400059A RID: 1434
		[Token(Token = "0x400059A")]
		[FieldOffset(Offset = "0xB0")]
		protected Vector3 mLastPos;

		// Token: 0x0400059B RID: 1435
		[Token(Token = "0x400059B")]
		[FieldOffset(Offset = "0xBC")]
		protected bool mPressed;

		// Token: 0x0400059C RID: 1436
		[Token(Token = "0x400059C")]
		[FieldOffset(Offset = "0xC0")]
		protected Vector3 mMomentum;

		// Token: 0x0400059D RID: 1437
		[Token(Token = "0x400059D")]
		[FieldOffset(Offset = "0xCC")]
		protected float mScroll;

		// Token: 0x0400059E RID: 1438
		[Token(Token = "0x400059E")]
		[FieldOffset(Offset = "0xD0")]
		protected Bounds mBounds;

		// Token: 0x0400059F RID: 1439
		[Token(Token = "0x400059F")]
		[FieldOffset(Offset = "0xE8")]
		protected bool mCalculatedBounds;

		// Token: 0x040005A0 RID: 1440
		[Token(Token = "0x40005A0")]
		[FieldOffset(Offset = "0xE9")]
		protected bool mShouldMove;

		// Token: 0x040005A1 RID: 1441
		[Token(Token = "0x40005A1")]
		[FieldOffset(Offset = "0xEA")]
		protected bool mIgnoreCallbacks;

		// Token: 0x040005A2 RID: 1442
		[Token(Token = "0x40005A2")]
		[FieldOffset(Offset = "0xEC")]
		protected int mDragID;

		// Token: 0x040005A3 RID: 1443
		[Token(Token = "0x40005A3")]
		[FieldOffset(Offset = "0xF0")]
		protected Vector2 mDragStartOffset;

		// Token: 0x040005A4 RID: 1444
		[Token(Token = "0x40005A4")]
		[FieldOffset(Offset = "0xF8")]
		protected bool mDragStarted;

		// Token: 0x040005A5 RID: 1445
		[Token(Token = "0x40005A5")]
		[FieldOffset(Offset = "0xF9")]
		[NonSerialized]
		private bool mStarted;

		// Token: 0x040005A6 RID: 1446
		[Token(Token = "0x40005A6")]
		[FieldOffset(Offset = "0x100")]
		[HideInInspector]
		public UICenterOnChild centerOnChild;

		// Token: 0x020000D3 RID: 211
		[Token(Token = "0x20000D3")]
		public enum Movement
		{
			// Token: 0x040005A8 RID: 1448
			[Token(Token = "0x40005A8")]
			Horizontal,
			// Token: 0x040005A9 RID: 1449
			[Token(Token = "0x40005A9")]
			Vertical,
			// Token: 0x040005AA RID: 1450
			[Token(Token = "0x40005AA")]
			Unrestricted,
			// Token: 0x040005AB RID: 1451
			[Token(Token = "0x40005AB")]
			Custom
		}

		// Token: 0x020000D4 RID: 212
		[Token(Token = "0x20000D4")]
		public enum DragEffect
		{
			// Token: 0x040005AD RID: 1453
			[Token(Token = "0x40005AD")]
			None,
			// Token: 0x040005AE RID: 1454
			[Token(Token = "0x40005AE")]
			Momentum,
			// Token: 0x040005AF RID: 1455
			[Token(Token = "0x40005AF")]
			MomentumAndSpring
		}

		// Token: 0x020000D5 RID: 213
		[Token(Token = "0x20000D5")]
		public enum ShowCondition
		{
			// Token: 0x040005B1 RID: 1457
			[Token(Token = "0x40005B1")]
			Always,
			// Token: 0x040005B2 RID: 1458
			[Token(Token = "0x40005B2")]
			OnlyIfNeeded,
			// Token: 0x040005B3 RID: 1459
			[Token(Token = "0x40005B3")]
			WhenDragging
		}

		// Token: 0x020000D6 RID: 214
		// (Invoke) Token: 0x0600079E RID: 1950
		[Token(Token = "0x20000D6")]
		public delegate void OnDragNotification();
	}
}
