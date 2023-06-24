using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x0200070C RID: 1804
	[Token(Token = "0x200070C")]
	[AddComponentMenu("Sons/Characters/SimpleFrog")]
	public class SimpleFrog : MonoBehaviour
	{
		// Token: 0x06002FEB RID: 12267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FEB")]
		[Address(RVA = "0x2AE3900", Offset = "0x2AE1F00", VA = "0x182AE3900")]
		private void Awake()
		{
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FEC")]
		[Address(RVA = "0x34698E0", Offset = "0x3467EE0", VA = "0x1834698E0")]
		private void Update()
		{
		}

		// Token: 0x06002FED RID: 12269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FED")]
		[Address(RVA = "0x3469A20", Offset = "0x3468020", VA = "0x183469A20")]
		private void UpdateVisibility()
		{
		}

		// Token: 0x06002FEE RID: 12270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FEE")]
		[Address(RVA = "0x3469CF0", Offset = "0x34682F0", VA = "0x183469CF0")]
		private void UpdateAudio()
		{
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FEF")]
		[Address(RVA = "0x3469E20", Offset = "0x3468420", VA = "0x183469E20")]
		private void SetNextSoundSwapTime(bool isPlaying)
		{
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FF0")]
		[Address(RVA = "0x3469ED0", Offset = "0x34684D0", VA = "0x183469ED0")]
		public void OnSpawned()
		{
		}

		// Token: 0x06002FF1 RID: 12273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FF1")]
		[Address(RVA = "0x346A080", Offset = "0x3468680", VA = "0x18346A080")]
		public void Hit(float damage)
		{
		}

		// Token: 0x06002FF2 RID: 12274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FF2")]
		[Address(RVA = "0x346A0A0", Offset = "0x34686A0", VA = "0x18346A0A0")]
		public void HitExplosion(float damage, Vector3 centerPoint)
		{
		}

		// Token: 0x06002FF3 RID: 12275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FF3")]
		[Address(RVA = "0x346A270", Offset = "0x3468870", VA = "0x18346A270")]
		private GameObject CreateDeadInstance()
		{
			return null;
		}

		// Token: 0x06002FF4 RID: 12276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FF4")]
		[Address(RVA = "0x346A640", Offset = "0x3468C40", VA = "0x18346A640")]
		public SimpleFrog()
		{
		}

		// Token: 0x0400297F RID: 10623
		[Token(Token = "0x400297F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _sizeVariation;

		// Token: 0x04002980 RID: 10624
		[Token(Token = "0x4002980")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _activeDistance;

		// Token: 0x04002981 RID: 10625
		[Token(Token = "0x4002981")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Renderer[] _renderers;

		// Token: 0x04002982 RID: 10626
		[Token(Token = "0x4002982")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04002983 RID: 10627
		[Token(Token = "0x4002983")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _deadFrog;

		// Token: 0x04002984 RID: 10628
		[Token(Token = "0x4002984")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _explodeForceMult;

		// Token: 0x04002985 RID: 10629
		[Token(Token = "0x4002985")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private MonoBehaviour _loopingSound;

		// Token: 0x04002986 RID: 10630
		[Token(Token = "0x4002986")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Vector2 _soundOnDuration;

		// Token: 0x04002987 RID: 10631
		[Token(Token = "0x4002987")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Vector2 _soundOffDuration;

		// Token: 0x04002988 RID: 10632
		[Token(Token = "0x4002988")]
		[FieldOffset(Offset = "0x68")]
		private Transform _transform;

		// Token: 0x04002989 RID: 10633
		[Token(Token = "0x4002989")]
		[FieldOffset(Offset = "0x70")]
		private bool _isDead;

		// Token: 0x0400298A RID: 10634
		[Token(Token = "0x400298A")]
		[FieldOffset(Offset = "0x71")]
		private bool _isActive;

		// Token: 0x0400298B RID: 10635
		[Token(Token = "0x400298B")]
		[FieldOffset(Offset = "0x74")]
		private float _nextSoundSwapTime;
	}
}
