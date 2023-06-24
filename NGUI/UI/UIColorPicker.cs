using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.UI
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	[RequireComponent(typeof(UITexture))]
	public class UIColorPicker : MonoBehaviour
	{
		// Token: 0x060000CD RID: 205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x262A5E0", Offset = "0x2628BE0", VA = "0x18262A5E0")]
		private void Start()
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x262AB80", Offset = "0x2629180", VA = "0x18262AB80")]
		private void OnDestroy()
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x262AC20", Offset = "0x2629220", VA = "0x18262AC20")]
		private void OnPress(bool pressed)
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x262ACD0", Offset = "0x26292D0", VA = "0x18262ACD0")]
		private void OnDrag(Vector2 delta)
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x262AD40", Offset = "0x2629340", VA = "0x18262AD40")]
		private void OnPan(Vector2 delta)
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x262AE10", Offset = "0x2629410", VA = "0x18262AE10")]
		private void Sample()
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x262B400", Offset = "0x2629A00", VA = "0x18262B400")]
		public void Select(Vector2 v)
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x262B860", Offset = "0x2629E60", VA = "0x18262B860")]
		public Vector2 Select(Color c)
		{
			return default(Vector2);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x262BDF0", Offset = "0x262A3F0", VA = "0x18262BDF0")]
		public static Color Sample(float x, float y)
		{
			return default(Color);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x262C890", Offset = "0x262AE90", VA = "0x18262C890")]
		public UIColorPicker()
		{
		}

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x0")]
		public static UIColorPicker current;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x20")]
		public Color value;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget selectionWidget;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x38")]
		public List<EventDelegate> onChange;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		private Transform mTrans;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		private UITexture mUITex;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		private Texture2D mTex;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		private UICamera mCam;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private Vector2 mPos;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private int mWidth;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x6C")]
		[NonSerialized]
		private int mHeight;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x8")]
		private static AnimationCurve mRed;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x10")]
		private static AnimationCurve mGreen;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x18")]
		private static AnimationCurve mBlue;
	}
}
