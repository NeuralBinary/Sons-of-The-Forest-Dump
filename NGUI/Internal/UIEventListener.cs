using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Internal
{
	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	[AddComponentMenu("NGUI/Internal/Event Listener")]
	public class UIEventListener : MonoBehaviour
	{
		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x000040C8 File Offset: 0x000022C8
		[Token(Token = "0x17000116")]
		private bool isColliderEnabled
		{
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x2699D90", Offset = "0x2698390", VA = "0x182699D90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x2699FB0", Offset = "0x26985B0", VA = "0x182699FB0")]
		private void OnSubmit()
		{
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x269A030", Offset = "0x2698630", VA = "0x18269A030")]
		private void OnClick()
		{
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x269A0B0", Offset = "0x26986B0", VA = "0x18269A0B0")]
		private void OnDoubleClick()
		{
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x269A130", Offset = "0x2698730", VA = "0x18269A130")]
		private void OnHover(bool isOver)
		{
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x269A1C0", Offset = "0x26987C0", VA = "0x18269A1C0")]
		private void OnPress(bool isPressed)
		{
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x269A250", Offset = "0x2698850", VA = "0x18269A250")]
		private void OnSelect(bool selected)
		{
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x269A2E0", Offset = "0x26988E0", VA = "0x18269A2E0")]
		private void OnScroll(float delta)
		{
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x269A370", Offset = "0x2698970", VA = "0x18269A370")]
		private void OnDragStart()
		{
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x269A3E0", Offset = "0x26989E0", VA = "0x18269A3E0")]
		private void OnDrag(Vector2 delta)
		{
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x269A470", Offset = "0x2698A70", VA = "0x18269A470")]
		private void OnDragOver()
		{
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x269A4F0", Offset = "0x2698AF0", VA = "0x18269A4F0")]
		private void OnDragOut()
		{
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x269A570", Offset = "0x2698B70", VA = "0x18269A570")]
		private void OnDragEnd()
		{
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x269A5F0", Offset = "0x2698BF0", VA = "0x18269A5F0")]
		private void OnDrop(GameObject go)
		{
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x269A680", Offset = "0x2698C80", VA = "0x18269A680")]
		private void OnKey(KeyCode key)
		{
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x269A710", Offset = "0x2698D10", VA = "0x18269A710")]
		private void OnTooltip(bool show)
		{
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x269A7A0", Offset = "0x2698DA0", VA = "0x18269A7A0")]
		public static UIEventListener Get(GameObject go)
		{
			return null;
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UIEventListener()
		{
		}

		// Token: 0x0400037F RID: 895
		[Token(Token = "0x400037F")]
		[FieldOffset(Offset = "0x20")]
		public object parameter;

		// Token: 0x04000380 RID: 896
		[Token(Token = "0x4000380")]
		[FieldOffset(Offset = "0x28")]
		public UIEventListener.VoidDelegate onSubmit;

		// Token: 0x04000381 RID: 897
		[Token(Token = "0x4000381")]
		[FieldOffset(Offset = "0x30")]
		public UIEventListener.VoidDelegate onClick;

		// Token: 0x04000382 RID: 898
		[Token(Token = "0x4000382")]
		[FieldOffset(Offset = "0x38")]
		public UIEventListener.VoidDelegate onDoubleClick;

		// Token: 0x04000383 RID: 899
		[Token(Token = "0x4000383")]
		[FieldOffset(Offset = "0x40")]
		public UIEventListener.BoolDelegate onHover;

		// Token: 0x04000384 RID: 900
		[Token(Token = "0x4000384")]
		[FieldOffset(Offset = "0x48")]
		public UIEventListener.BoolDelegate onPress;

		// Token: 0x04000385 RID: 901
		[Token(Token = "0x4000385")]
		[FieldOffset(Offset = "0x50")]
		public UIEventListener.BoolDelegate onSelect;

		// Token: 0x04000386 RID: 902
		[Token(Token = "0x4000386")]
		[FieldOffset(Offset = "0x58")]
		public UIEventListener.FloatDelegate onScroll;

		// Token: 0x04000387 RID: 903
		[Token(Token = "0x4000387")]
		[FieldOffset(Offset = "0x60")]
		public UIEventListener.VoidDelegate onDragStart;

		// Token: 0x04000388 RID: 904
		[Token(Token = "0x4000388")]
		[FieldOffset(Offset = "0x68")]
		public UIEventListener.VectorDelegate onDrag;

		// Token: 0x04000389 RID: 905
		[Token(Token = "0x4000389")]
		[FieldOffset(Offset = "0x70")]
		public UIEventListener.VoidDelegate onDragOver;

		// Token: 0x0400038A RID: 906
		[Token(Token = "0x400038A")]
		[FieldOffset(Offset = "0x78")]
		public UIEventListener.VoidDelegate onDragOut;

		// Token: 0x0400038B RID: 907
		[Token(Token = "0x400038B")]
		[FieldOffset(Offset = "0x80")]
		public UIEventListener.VoidDelegate onDragEnd;

		// Token: 0x0400038C RID: 908
		[Token(Token = "0x400038C")]
		[FieldOffset(Offset = "0x88")]
		public UIEventListener.ObjectDelegate onDrop;

		// Token: 0x0400038D RID: 909
		[Token(Token = "0x400038D")]
		[FieldOffset(Offset = "0x90")]
		public UIEventListener.KeyCodeDelegate onKey;

		// Token: 0x0400038E RID: 910
		[Token(Token = "0x400038E")]
		[FieldOffset(Offset = "0x98")]
		public UIEventListener.BoolDelegate onTooltip;

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x0600052D RID: 1325
		[Token(Token = "0x2000085")]
		public delegate void VoidDelegate(GameObject go);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x06000531 RID: 1329
		[Token(Token = "0x2000086")]
		public delegate void BoolDelegate(GameObject go, bool state);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x06000535 RID: 1333
		[Token(Token = "0x2000087")]
		public delegate void FloatDelegate(GameObject go, float delta);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x06000539 RID: 1337
		[Token(Token = "0x2000088")]
		public delegate void VectorDelegate(GameObject go, Vector2 delta);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x0600053D RID: 1341
		[Token(Token = "0x2000089")]
		public delegate void ObjectDelegate(GameObject go, GameObject obj);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x06000541 RID: 1345
		[Token(Token = "0x200008A")]
		public delegate void KeyCodeDelegate(GameObject go, KeyCode key);
	}
}
