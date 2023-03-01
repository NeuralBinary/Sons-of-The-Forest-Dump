using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sons
{
	// Token: 0x020004DF RID: 1247
	[Token(Token = "0x20004DF")]
	[AddComponentMenu("Sons/Gameplay/LowHealthEffect")]
	public class LowHealthEffect : MonoBehaviour
	{
		// Token: 0x06001FFB RID: 8187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FFB")]
		[Address(RVA = "0x2D2B970", Offset = "0x2D2A970", VA = "0x182D2B970")]
		private void Update()
		{
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FFC")]
		[Address(RVA = "0x2D2B720", Offset = "0x2D2A720", VA = "0x182D2B720")]
		private void RefreshGui()
		{
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FFD")]
		[Address(RVA = "0x2D2B5F0", Offset = "0x2D2A5F0", VA = "0x182D2B5F0")]
		private void ApplyWeight()
		{
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x000094B0 File Offset: 0x000076B0
		[Token(Token = "0x6001FFE")]
		[Address(RVA = "0x2D2B980", Offset = "0x2D2A980", VA = "0x182D2B980")]
		private bool VerifyVitalsObject()
		{
			return default(bool);
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FFF")]
		[Address(RVA = "0x2D2BA50", Offset = "0x2D2AA50", VA = "0x182D2BA50")]
		public LowHealthEffect()
		{
		}

		// Token: 0x04001D8B RID: 7563
		[Token(Token = "0x4001D8B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Volume _targetVolume;

		// Token: 0x04001D8C RID: 7564
		[Token(Token = "0x4001D8C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _minFactor;

		// Token: 0x04001D8D RID: 7565
		[Token(Token = "0x4001D8D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _lowHealthEnd;

		// Token: 0x04001D8E RID: 7566
		[Token(Token = "0x4001D8E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _lowHealthThresholdOffset;

		// Token: 0x04001D8F RID: 7567
		[Token(Token = "0x4001D8F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationCurve _animationCurve;

		// Token: 0x04001D90 RID: 7568
		[Token(Token = "0x4001D90")]
		[FieldOffset(Offset = "0x40")]
		private float _currentGoal;

		// Token: 0x04001D91 RID: 7569
		[Token(Token = "0x4001D91")]
		[FieldOffset(Offset = "0x48")]
		private Vitals _vitals;

		// Token: 0x04001D92 RID: 7570
		[Token(Token = "0x4001D92")]
		[FieldOffset(Offset = "0x50")]
		private float _currentGoalVelocity;
	}
}
