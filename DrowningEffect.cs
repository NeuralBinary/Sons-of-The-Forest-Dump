using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sons
{
	// Token: 0x020004DE RID: 1246
	[Token(Token = "0x20004DE")]
	public class DrowningEffect : MonoBehaviour
	{
		// Token: 0x06001FF5 RID: 8181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF5")]
		[Address(RVA = "0x2D286A0", Offset = "0x2D276A0", VA = "0x182D286A0")]
		private void Update()
		{
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF6")]
		[Address(RVA = "0x2D283D0", Offset = "0x2D273D0", VA = "0x182D283D0")]
		private void RefreshGui()
		{
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF7")]
		[Address(RVA = "0x2D28620", Offset = "0x2D27620", VA = "0x182D28620")]
		private void UpdateGoal()
		{
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF8")]
		[Address(RVA = "0x2D282A0", Offset = "0x2D272A0", VA = "0x182D282A0")]
		private void ApplyWeight()
		{
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x00009498 File Offset: 0x00007698
		[Token(Token = "0x6001FF9")]
		[Address(RVA = "0x2D286B0", Offset = "0x2D276B0", VA = "0x182D286B0")]
		private bool VerifyVitalsObject()
		{
			return default(bool);
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FFA")]
		[Address(RVA = "0x2D28780", Offset = "0x2D27780", VA = "0x182D28780")]
		public DrowningEffect()
		{
		}

		// Token: 0x04001D82 RID: 7554
		[Token(Token = "0x4001D82")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Volume _targetVolume;

		// Token: 0x04001D83 RID: 7555
		[Token(Token = "0x4001D83")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _highAirPercent;

		// Token: 0x04001D84 RID: 7556
		[Token(Token = "0x4001D84")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _lowAirPercent;

		// Token: 0x04001D85 RID: 7557
		[Token(Token = "0x4001D85")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve _animationCurve;

		// Token: 0x04001D86 RID: 7558
		[Token(Token = "0x4001D86")]
		[FieldOffset(Offset = "0x38")]
		private Vitals _vitals;

		// Token: 0x04001D87 RID: 7559
		[Token(Token = "0x4001D87")]
		[FieldOffset(Offset = "0x40")]
		private float _currentGoal;

		// Token: 0x04001D88 RID: 7560
		[Token(Token = "0x4001D88")]
		[FieldOffset(Offset = "0x44")]
		private float _currentGoalVelocity;

		// Token: 0x04001D89 RID: 7561
		[Token(Token = "0x4001D89")]
		[FieldOffset(Offset = "0x48")]
		private float _factor;

		// Token: 0x04001D8A RID: 7562
		[Token(Token = "0x4001D8A")]
		[FieldOffset(Offset = "0x4C")]
		private float _airPercent;
	}
}
