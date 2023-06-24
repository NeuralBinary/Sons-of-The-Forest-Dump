using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	[CreateAssetMenu(menuName = "Sons/Construction/Element Place Animation (Particles)")]
	public class ElementPlaceAnimationParticles : ElementPlaceAnimation
	{
		// Token: 0x06000087 RID: 135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2D61920", Offset = "0x2D5FF20", VA = "0x182D61920", Slot = "4")]
		public override void OnPlaced(Transform renderableTr, [Optional] Action onFinished, [Optional] Transform fromTr, bool useCopyOfRenderable = false)
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2D61980", Offset = "0x2D5FF80", VA = "0x182D61980", Slot = "5")]
		public override void OnPlaced(StructureElement element, [Optional] Action onFinished, [Optional] Transform fromTr, bool useCopyOfRenderable = false)
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2D61AB0", Offset = "0x2D600B0", VA = "0x182D61AB0")]
		private IEnumerator PlaceAnimationRoutine(Transform renderable, Action onFinished)
		{
			return null;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2D61C10", Offset = "0x2D60210", VA = "0x182D61C10")]
		private ParticleSystem GetParticleSystem()
		{
			return null;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2D61D80", Offset = "0x2D60380", VA = "0x182D61D80")]
		private void ReturnParticleSystem(ParticleSystem instance)
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2D61E80", Offset = "0x2D60480", VA = "0x182D61E80")]
		public ElementPlaceAnimationParticles()
		{
		}

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ParticleSystem _particleSystem;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _worldOffset;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Queue<ParticleSystem> _pool;
	}
}
