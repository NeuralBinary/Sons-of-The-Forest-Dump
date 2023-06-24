using System;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x02000927 RID: 2343
	[Token(Token = "0x2000927")]
	public class MeleeAttackAction : MonoBehaviour
	{
		// Token: 0x06004345 RID: 17221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004345")]
		[Address(RVA = "0x36434D0", Offset = "0x3641AD0", VA = "0x1836434D0")]
		private void Update()
		{
		}

		// Token: 0x06004346 RID: 17222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004346")]
		[Address(RVA = "0x36434E0", Offset = "0x3641AE0", VA = "0x1836434E0")]
		private void UpdateLifeTime()
		{
		}

		// Token: 0x06004347 RID: 17223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004347")]
		[Address(RVA = "0x36436B0", Offset = "0x3641CB0", VA = "0x1836436B0")]
		internal void OnEnable()
		{
		}

		// Token: 0x06004348 RID: 17224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004348")]
		[Address(RVA = "0x3643950", Offset = "0x3641F50", VA = "0x183643950")]
		private void OnDisable()
		{
		}

		// Token: 0x06004349 RID: 17225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004349")]
		[Address(RVA = "0x3643B80", Offset = "0x3642180", VA = "0x183643B80")]
		private void OnMeleeAttackEvent()
		{
		}

		// Token: 0x0600434A RID: 17226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600434A")]
		[Address(RVA = "0x3643B90", Offset = "0x3642190", VA = "0x183643B90")]
		private void OnHeavyMeleeAttackEvent()
		{
		}

		// Token: 0x0600434B RID: 17227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600434B")]
		[Address(RVA = "0x3643BA0", Offset = "0x36421A0", VA = "0x183643BA0")]
		private void EnableMeleeAttackEvent(bool isHeavy)
		{
		}

		// Token: 0x0600434C RID: 17228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600434C")]
		[Address(RVA = "0x3643D60", Offset = "0x3642360", VA = "0x183643D60")]
		private void OnMeleeAttackEnd()
		{
		}

		// Token: 0x0600434D RID: 17229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600434D")]
		[Address(RVA = "0x3643EC0", Offset = "0x36424C0", VA = "0x183643EC0")]
		public MeleeAttackAction()
		{
		}

		// Token: 0x04004686 RID: 18054
		[Token(Token = "0x4004686")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationEventReceiver _animationEventReceiver;

		// Token: 0x04004687 RID: 18055
		[Token(Token = "0x4004687")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeleeAttack _meleeAttackObject;

		// Token: 0x04004688 RID: 18056
		[Token(Token = "0x4004688")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _lifeTime;

		// Token: 0x04004689 RID: 18057
		[Token(Token = "0x4004689")]
		[FieldOffset(Offset = "0x34")]
		private float _fireTime;
	}
}
