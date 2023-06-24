using System;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.UI
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	[ExecuteInEditMode]
	[AddComponentMenu("NGUI/UI/Stretch")]
	public class UIStretch : MonoBehaviour
	{
		// Token: 0x06000246 RID: 582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x264E7D0", Offset = "0x264CDD0", VA = "0x18264E7D0")]
		private void Awake()
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x264EBD0", Offset = "0x264D1D0", VA = "0x18264EBD0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x264ED50", Offset = "0x264D350", VA = "0x18264ED50")]
		private void ScreenSizeChanged()
		{
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x264ED70", Offset = "0x264D370", VA = "0x18264ED70")]
		private void Start()
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x264F250", Offset = "0x264D850", VA = "0x18264F250")]
		private void Update()
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x2650180", Offset = "0x264E780", VA = "0x182650180")]
		public UIStretch()
		{
		}

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x20")]
		public Camera uiCamera;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x28")]
		public GameObject container;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x30")]
		public UIStretch.Style style;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x34")]
		public bool runOnlyOnce;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x38")]
		public Vector2 relativeSize;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x40")]
		public Vector2 initialSize;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x48")]
		public Vector2 borderPadding;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		private UIWidget widgetContainer;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x58")]
		private Transform mTrans;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x60")]
		private UIWidget mWidget;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x68")]
		private UISprite mSprite;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x70")]
		private UIPanel mPanel;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x78")]
		private UIRoot mRoot;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x80")]
		private Animation mAnim;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x88")]
		private Rect mRect;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x98")]
		private bool mStarted;

		// Token: 0x0200003F RID: 63
		[Token(Token = "0x200003F")]
		public enum Style
		{
			// Token: 0x040001D2 RID: 466
			[Token(Token = "0x40001D2")]
			None,
			// Token: 0x040001D3 RID: 467
			[Token(Token = "0x40001D3")]
			Horizontal,
			// Token: 0x040001D4 RID: 468
			[Token(Token = "0x40001D4")]
			Vertical,
			// Token: 0x040001D5 RID: 469
			[Token(Token = "0x40001D5")]
			Both,
			// Token: 0x040001D6 RID: 470
			[Token(Token = "0x40001D6")]
			BasedOnHeight,
			// Token: 0x040001D7 RID: 471
			[Token(Token = "0x40001D7")]
			FillKeepingRatio,
			// Token: 0x040001D8 RID: 472
			[Token(Token = "0x40001D8")]
			FitInternalKeepingRatio
		}
	}
}
