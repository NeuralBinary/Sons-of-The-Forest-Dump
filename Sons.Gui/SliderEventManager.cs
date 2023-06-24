using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Sons.Gui
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	[AddComponentMenu("Sons/Gui/SliderEventManager")]
	public class SliderEventManager : MonoBehaviour
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x17000011")]
		private static float CurrentTime
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x268E240", Offset = "0x268C840", VA = "0x18268E240")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x17000012")]
		private static float TimeDelta
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x268E290", Offset = "0x268C890", VA = "0x18268E290")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x30183A0", Offset = "0x30169A0", VA = "0x1830183A0")]
		private void OnValidate()
		{
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x30184E0", Offset = "0x3016AE0", VA = "0x1830184E0")]
		private static void SanitizeSpeedCurve(ref AnimationCurve targetCurve)
		{
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x3018660", Offset = "0x3016C60", VA = "0x183018660")]
		private void Update()
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x3018770", Offset = "0x3016D70", VA = "0x183018770")]
		private void EvaluateHeldTime(AnimationCurve speedCurve, float heldStartTime, float timeDelta)
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x30188C0", Offset = "0x3016EC0", VA = "0x1830188C0")]
		public void OnIncreaseHeldEnd()
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x30188D0", Offset = "0x3016ED0", VA = "0x1830188D0")]
		public void OnIncreaseHeldStart()
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x3018930", Offset = "0x3016F30", VA = "0x183018930")]
		public void OnDecreaseHeldEnd()
		{
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x3018940", Offset = "0x3016F40", VA = "0x183018940")]
		public void OnDecreaseHeldStart()
		{
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x30189A0", Offset = "0x3016FA0", VA = "0x1830189A0")]
		private void AdjustValueInternal(float offsetValue)
		{
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x3018A20", Offset = "0x3017020", VA = "0x183018A20")]
		public SliderEventManager()
		{
		}

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Slider _target;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationCurve _increaseHeldSpeedCurve;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve _decreaseHeldSpeedCurve;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _globalMultiplier;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x40")]
		private EventTrigger _increaseEventTrigger;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x48")]
		private EventTrigger _decreaseEventTrigger;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x50")]
		private float _increasePointerHeldTime;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x54")]
		private float _decreasePointerHeldTime;
	}
}
