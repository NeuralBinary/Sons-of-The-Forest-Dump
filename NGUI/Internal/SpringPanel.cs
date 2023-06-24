using System;
using Il2CppDummyDll;
using NGUI.Interaction;
using NGUI.UI;
using UnityEngine;

namespace NGUI.Internal
{
	// Token: 0x0200007A RID: 122
	[Token(Token = "0x200007A")]
	[AddComponentMenu("NGUI/Internal/Spring Panel")]
	[RequireComponent(typeof(UIPanel))]
	public class SpringPanel : MonoBehaviour
	{
		// Token: 0x060004CA RID: 1226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x268E2E0", Offset = "0x268C8E0", VA = "0x18268E2E0")]
		private void Start()
		{
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x268E470", Offset = "0x268CA70", VA = "0x18268E470")]
		private void Update()
		{
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x268E490", Offset = "0x268CA90", VA = "0x18268E490", Slot = "4")]
		protected virtual void AdvanceTowardsPosition()
		{
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x268E9B0", Offset = "0x268CFB0", VA = "0x18268E9B0")]
		public static SpringPanel Begin(GameObject go, Vector3 pos, float strength)
		{
			return null;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x2657040", Offset = "0x2655640", VA = "0x182657040")]
		public SpringPanel()
		{
		}

		// Token: 0x0400032D RID: 813
		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x0")]
		public static SpringPanel current;

		// Token: 0x0400032E RID: 814
		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 target;

		// Token: 0x0400032F RID: 815
		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x2C")]
		public float strength;

		// Token: 0x04000330 RID: 816
		[Token(Token = "0x4000330")]
		[FieldOffset(Offset = "0x30")]
		public SpringPanel.OnFinished onFinished;

		// Token: 0x04000331 RID: 817
		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x38")]
		private UIPanel mPanel;

		// Token: 0x04000332 RID: 818
		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x40")]
		private Transform mTrans;

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x48")]
		private UIScrollView mDrag;

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x060004D0 RID: 1232
		[Token(Token = "0x200007B")]
		public delegate void OnFinished();
	}
}
