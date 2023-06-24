using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sons
{
	// Token: 0x020004D4 RID: 1236
	[Token(Token = "0x20004D4")]
	public class DrowningEffect : MonoBehaviour
	{
		// Token: 0x0600205A RID: 8282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600205A")]
		[Address(RVA = "0x3313810", Offset = "0x3311E10", VA = "0x183313810")]
		private void Update()
		{
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600205B")]
		[Address(RVA = "0x3313810", Offset = "0x3311E10", VA = "0x183313810")]
		private void RefreshGui()
		{
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600205C")]
		[Address(RVA = "0x33138E0", Offset = "0x3311EE0", VA = "0x1833138E0")]
		private void UpdateGoal()
		{
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600205D")]
		[Address(RVA = "0x3313990", Offset = "0x3311F90", VA = "0x183313990")]
		private void ApplyWeight()
		{
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x000097F8 File Offset: 0x000079F8
		[Token(Token = "0x600205E")]
		[Address(RVA = "0x3313B50", Offset = "0x3312150", VA = "0x183313B50")]
		private bool VerifyVitalsObject()
		{
			return default(bool);
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600205F")]
		[Address(RVA = "0x3313D30", Offset = "0x3312330", VA = "0x183313D30")]
		public DrowningEffect()
		{
		}

		// Token: 0x04001DBF RID: 7615
		[Token(Token = "0x4001DBF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Volume _targetVolume;

		// Token: 0x04001DC0 RID: 7616
		[Token(Token = "0x4001DC0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _highAirPercent;

		// Token: 0x04001DC1 RID: 7617
		[Token(Token = "0x4001DC1")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _lowAirPercent;

		// Token: 0x04001DC2 RID: 7618
		[Token(Token = "0x4001DC2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve _animationCurve;

		// Token: 0x04001DC3 RID: 7619
		[Token(Token = "0x4001DC3")]
		[FieldOffset(Offset = "0x38")]
		private Vitals _vitals;

		// Token: 0x04001DC4 RID: 7620
		[Token(Token = "0x4001DC4")]
		[FieldOffset(Offset = "0x40")]
		private float _currentGoal;

		// Token: 0x04001DC5 RID: 7621
		[Token(Token = "0x4001DC5")]
		[FieldOffset(Offset = "0x44")]
		private float _currentGoalVelocity;

		// Token: 0x04001DC6 RID: 7622
		[Token(Token = "0x4001DC6")]
		[FieldOffset(Offset = "0x48")]
		private float _factor;

		// Token: 0x04001DC7 RID: 7623
		[Token(Token = "0x4001DC7")]
		[FieldOffset(Offset = "0x4C")]
		private float _airPercent;
	}
}
