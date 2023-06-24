using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sons
{
	// Token: 0x020004D5 RID: 1237
	[Token(Token = "0x20004D5")]
	[AddComponentMenu("Sons/Gameplay/LowHealthEffect")]
	public class LowHealthEffect : MonoBehaviour
	{
		// Token: 0x06002060 RID: 8288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002060")]
		[Address(RVA = "0x3313EF0", Offset = "0x33124F0", VA = "0x183313EF0")]
		private void Update()
		{
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002061")]
		[Address(RVA = "0x3313EF0", Offset = "0x33124F0", VA = "0x183313EF0")]
		private void RefreshGui()
		{
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002062")]
		[Address(RVA = "0x3313FB0", Offset = "0x33125B0", VA = "0x183313FB0")]
		private void ApplyWeight()
		{
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x00009810 File Offset: 0x00007A10
		[Token(Token = "0x6002063")]
		[Address(RVA = "0x3314170", Offset = "0x3312770", VA = "0x183314170")]
		private bool VerifyVitalsObject()
		{
			return default(bool);
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002064")]
		[Address(RVA = "0x3314350", Offset = "0x3312950", VA = "0x183314350")]
		public LowHealthEffect()
		{
		}

		// Token: 0x04001DC8 RID: 7624
		[Token(Token = "0x4001DC8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Volume _targetVolume;

		// Token: 0x04001DC9 RID: 7625
		[Token(Token = "0x4001DC9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _minFactor;

		// Token: 0x04001DCA RID: 7626
		[Token(Token = "0x4001DCA")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _lowHealthEnd;

		// Token: 0x04001DCB RID: 7627
		[Token(Token = "0x4001DCB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _lowHealthThresholdOffset;

		// Token: 0x04001DCC RID: 7628
		[Token(Token = "0x4001DCC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationCurve _animationCurve;

		// Token: 0x04001DCD RID: 7629
		[Token(Token = "0x4001DCD")]
		[FieldOffset(Offset = "0x40")]
		private float _currentGoal;

		// Token: 0x04001DCE RID: 7630
		[Token(Token = "0x4001DCE")]
		[FieldOffset(Offset = "0x48")]
		private Vitals _vitals;

		// Token: 0x04001DCF RID: 7631
		[Token(Token = "0x4001DCF")]
		[FieldOffset(Offset = "0x50")]
		private float _currentGoalVelocity;
	}
}
