using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	[CreateAssetMenu(menuName = "Sons/Construction/Element Place Animation (Tween)")]
	public class ElementPlaceAnimationTween : ElementPlaceAnimation
	{
		// Token: 0x06000093 RID: 147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2D626C0", Offset = "0x2D60CC0", VA = "0x182D626C0", Slot = "4")]
		public override void OnPlaced(Transform renderableTr, [Optional] Action onFinished, [Optional] Transform fromTr, bool useCopyOfRenderable = false)
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2D62730", Offset = "0x2D60D30", VA = "0x182D62730", Slot = "5")]
		public override void OnPlaced(StructureElement element, [Optional] Action onFinished, [Optional] Transform fromTr, bool useCopyOfRenderable = false)
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2D62880", Offset = "0x2D60E80", VA = "0x182D62880")]
		private IEnumerator PlaceAnimationRoutine(Transform renderable, Action onFinished, [Optional] Transform fromTr, bool useCopyOfRenderable = false)
		{
			return null;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2D62A40", Offset = "0x2D61040", VA = "0x182D62A40")]
		public ElementPlaceAnimationTween()
		{
		}

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Tweener _tweener;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationCurve _easing;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _offsetRelativeToParent;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector3 _worldOffset;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _durationMaxRandExpand;
	}
}
