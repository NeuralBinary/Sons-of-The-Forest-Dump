using System;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.UI
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[AddComponentMenu("NGUI/UI/Anchor")]
	[ExecuteInEditMode]
	public class UIAnchor : MonoBehaviour
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2612FD0", Offset = "0x26115D0", VA = "0x182612FD0")]
		private void Awake()
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2613280", Offset = "0x2611880", VA = "0x182613280")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2613400", Offset = "0x2611A00", VA = "0x182613400")]
		private void ScreenSizeChanged()
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2613420", Offset = "0x2611A20", VA = "0x182613420")]
		private void Start()
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2613900", Offset = "0x2611F00", VA = "0x182613900")]
		private void Update()
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2614910", Offset = "0x2612F10", VA = "0x182614910")]
		public UIAnchor()
		{
		}

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x20")]
		public Camera uiCamera;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x28")]
		public GameObject container;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x30")]
		public UIAnchor.Side side;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x34")]
		public bool runOnlyOnce;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x38")]
		public Vector2 relativeOffset;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x40")]
		public Vector2 pixelOffset;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		private UIWidget widgetContainer;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x50")]
		private Transform mTrans;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x58")]
		private Animation mAnim;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x60")]
		private Rect mRect;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x70")]
		private UIRoot mRoot;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x78")]
		private bool mStarted;

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x2000009")]
		public enum Side
		{
			// Token: 0x0400002B RID: 43
			[Token(Token = "0x400002B")]
			BottomLeft,
			// Token: 0x0400002C RID: 44
			[Token(Token = "0x400002C")]
			Left,
			// Token: 0x0400002D RID: 45
			[Token(Token = "0x400002D")]
			TopLeft,
			// Token: 0x0400002E RID: 46
			[Token(Token = "0x400002E")]
			Top,
			// Token: 0x0400002F RID: 47
			[Token(Token = "0x400002F")]
			TopRight,
			// Token: 0x04000030 RID: 48
			[Token(Token = "0x4000030")]
			Right,
			// Token: 0x04000031 RID: 49
			[Token(Token = "0x4000031")]
			BottomRight,
			// Token: 0x04000032 RID: 50
			[Token(Token = "0x4000032")]
			Bottom,
			// Token: 0x04000033 RID: 51
			[Token(Token = "0x4000033")]
			Center
		}
	}
}
