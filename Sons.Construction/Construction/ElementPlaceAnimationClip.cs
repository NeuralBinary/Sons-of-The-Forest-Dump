using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	[CreateAssetMenu(menuName = "Sons/Construction/Element Place Animation (Clip)")]
	public class ElementPlaceAnimationClip : ElementPlaceAnimation
	{
		// Token: 0x06000079 RID: 121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2D60350", Offset = "0x2D5E950", VA = "0x182D60350", Slot = "4")]
		public override void OnPlaced(Transform renderableTr, [Optional] Action onFinished, [Optional] Transform fromTr, bool useCopyOfRenderable = false)
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2D603E0", Offset = "0x2D5E9E0", VA = "0x182D603E0", Slot = "5")]
		public override void OnPlaced(StructureElement element, [Optional] Action onFinished, [Optional] Transform fromTr, bool useCopyOfRenderable = false)
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2D60530", Offset = "0x2D5EB30", VA = "0x182D60530")]
		private Animation GetAnimationObject()
		{
			return null;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2D60B60", Offset = "0x2D5F160", VA = "0x182D60B60")]
		private void ReturnAnimationObject(Animation animation)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2D60E20", Offset = "0x2D5F420", VA = "0x182D60E20")]
		private IEnumerator PlaceAnimationRoutine(Transform renderable, Vector3 size, Action onFinished)
		{
			return null;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2D60F80", Offset = "0x2D5F580", VA = "0x182D60F80")]
		private void ShowRenderer(Transform renderable)
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2D61010", Offset = "0x2D5F610", VA = "0x182D61010")]
		public ElementPlaceAnimationClip()
		{
		}

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _objectName;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _yRotOnly;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationClip _animatorClip;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<AnimationClip, Queue<Animation>> _pools;
	}
}
