using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai
{
	// Token: 0x02000969 RID: 2409
	[Token(Token = "0x2000969")]
	public class ButterflyController : MonoBehaviour
	{
		// Token: 0x14000051 RID: 81
		// (add) Token: 0x060045BF RID: 17855 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060045C0 RID: 17856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000051")]
		private event Action<ButterflyController, Transform> _finishedCallback
		{
			[Token(Token = "0x60045BF")]
			[Address(RVA = "0x3669E50", Offset = "0x3668450", VA = "0x183669E50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60045C0")]
			[Address(RVA = "0x3669FC0", Offset = "0x36685C0", VA = "0x183669FC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060045C1 RID: 17857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C1")]
		[Address(RVA = "0x366A130", Offset = "0x3668730", VA = "0x18366A130")]
		private void OnEnable()
		{
		}

		// Token: 0x060045C2 RID: 17858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C2")]
		[Address(RVA = "0x366A1B0", Offset = "0x36687B0", VA = "0x18366A1B0")]
		private void OnDisable()
		{
		}

		// Token: 0x060045C3 RID: 17859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C3")]
		[Address(RVA = "0x366A1D0", Offset = "0x36687D0", VA = "0x18366A1D0")]
		public void ActivateTarget()
		{
		}

		// Token: 0x060045C4 RID: 17860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C4")]
		[Address(RVA = "0x366A1B0", Offset = "0x36687B0", VA = "0x18366A1B0")]
		private void Deactivate()
		{
		}

		// Token: 0x060045C5 RID: 17861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C5")]
		[Address(RVA = "0x366A230", Offset = "0x3668830", VA = "0x18366A230")]
		private void Update()
		{
		}

		// Token: 0x060045C6 RID: 17862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C6")]
		[Address(RVA = "0x366A240", Offset = "0x3668840", VA = "0x18366A240")]
		private void UpdateButterfly()
		{
		}

		// Token: 0x060045C7 RID: 17863 RVA: 0x00015540 File Offset: 0x00013740
		[Token(Token = "0x60045C7")]
		[Address(RVA = "0x366AF10", Offset = "0x3669510", VA = "0x18366AF10")]
		private bool IsDisturbed()
		{
			return default(bool);
		}

		// Token: 0x060045C8 RID: 17864 RVA: 0x00015558 File Offset: 0x00013758
		[Token(Token = "0x60045C8")]
		[Address(RVA = "0x366B150", Offset = "0x3669750", VA = "0x18366B150")]
		private bool UpdateFlyAway(float lifetime)
		{
			return default(bool);
		}

		// Token: 0x060045C9 RID: 17865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C9")]
		[Address(RVA = "0x366B420", Offset = "0x3669A20", VA = "0x18366B420")]
		private void DoDestroy()
		{
		}

		// Token: 0x060045CA RID: 17866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045CA")]
		[Address(RVA = "0x366B5E0", Offset = "0x3669BE0", VA = "0x18366B5E0")]
		public void SetTarget(Transform newTarget, bool link)
		{
		}

		// Token: 0x060045CB RID: 17867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045CB")]
		[Address(RVA = "0x3669E50", Offset = "0x3668450", VA = "0x183669E50")]
		public void AddFinishedCallback(Action<ButterflyController, Transform> finishedAction)
		{
		}

		// Token: 0x060045CC RID: 17868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045CC")]
		[Address(RVA = "0x3669FC0", Offset = "0x36685C0", VA = "0x183669FC0")]
		public void RemoveFinishedCallback(Action<ButterflyController, Transform> finishedAction)
		{
		}

		// Token: 0x060045CD RID: 17869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045CD")]
		[Address(RVA = "0x366B6D0", Offset = "0x3669CD0", VA = "0x18366B6D0")]
		public void SetVelocityRoot(Transform velocityRoot)
		{
		}

		// Token: 0x060045CE RID: 17870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045CE")]
		[Address(RVA = "0x366B8D0", Offset = "0x3669ED0", VA = "0x18366B8D0")]
		public void CleanUp()
		{
		}

		// Token: 0x060045CF RID: 17871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045CF")]
		[Address(RVA = "0x366B8F0", Offset = "0x3669EF0", VA = "0x18366B8F0")]
		public ButterflyController()
		{
		}

		// Token: 0x0400484D RID: 18509
		[Token(Token = "0x400484D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _targetTransform;

		// Token: 0x0400484E RID: 18510
		[Token(Token = "0x400484E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x0400484F RID: 18511
		[Token(Token = "0x400484F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _speed;

		// Token: 0x04004850 RID: 18512
		[Token(Token = "0x4004850")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _turnSpeed;

		// Token: 0x04004851 RID: 18513
		[Token(Token = "0x4004851")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _randomSpeed;

		// Token: 0x04004852 RID: 18514
		[Token(Token = "0x4004852")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _maxLifetime;

		// Token: 0x04004853 RID: 18515
		[Token(Token = "0x4004853")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector3 _randomScale;

		// Token: 0x04004854 RID: 18516
		[Token(Token = "0x4004854")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _randomScaleMultiplier;

		// Token: 0x04004855 RID: 18517
		[Token(Token = "0x4004855")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _linkTarget;

		// Token: 0x04004856 RID: 18518
		[Token(Token = "0x4004856")]
		[FieldOffset(Offset = "0x51")]
		[SerializeField]
		private bool _autoActivate;

		// Token: 0x04004857 RID: 18519
		[Token(Token = "0x4004857")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _disturbSpeed;

		// Token: 0x04004858 RID: 18520
		[Token(Token = "0x4004858")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _movementDisturbSpeed;

		// Token: 0x04004859 RID: 18521
		[Token(Token = "0x4004859")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _disturbedVerticalStartOffset;

		// Token: 0x0400485A RID: 18522
		[Token(Token = "0x400485A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int Fly;

		// Token: 0x0400485B RID: 18523
		[Token(Token = "0x400485B")]
		[FieldOffset(Offset = "0x60")]
		private bool _flyBoolSet;

		// Token: 0x0400485C RID: 18524
		[Token(Token = "0x400485C")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 _lastRanOffset;

		// Token: 0x0400485D RID: 18525
		[Token(Token = "0x400485D")]
		[FieldOffset(Offset = "0x70")]
		private float _startTime;

		// Token: 0x0400485E RID: 18526
		[Token(Token = "0x400485E")]
		[FieldOffset(Offset = "0x74")]
		private bool _doingFlyAway;

		// Token: 0x0400485F RID: 18527
		[Token(Token = "0x400485F")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 _flyAwayOffset;

		// Token: 0x04004860 RID: 18528
		[Token(Token = "0x4004860")]
		[FieldOffset(Offset = "0x84")]
		private bool _activated;

		// Token: 0x04004861 RID: 18529
		[Token(Token = "0x4004861")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 _targetTransformPosition;

		// Token: 0x04004862 RID: 18530
		[Token(Token = "0x4004862")]
		[FieldOffset(Offset = "0x94")]
		private Vector3 _previousTargetPosition;

		// Token: 0x04004863 RID: 18531
		[Token(Token = "0x4004863")]
		[FieldOffset(Offset = "0xA0")]
		private Quaternion _previousTargetRotation;

		// Token: 0x04004864 RID: 18532
		[Token(Token = "0x4004864")]
		[FieldOffset(Offset = "0xB0")]
		private Quaternion _targetTransformRotation;

		// Token: 0x04004865 RID: 18533
		[Token(Token = "0x4004865")]
		[FieldOffset(Offset = "0xC0")]
		private bool _wasDisturbed;

		// Token: 0x04004866 RID: 18534
		[Token(Token = "0x4004866")]
		[FieldOffset(Offset = "0xC8")]
		private Transform _velocityRoot;

		// Token: 0x04004867 RID: 18535
		[Token(Token = "0x4004867")]
		[FieldOffset(Offset = "0xD0")]
		private Vector3 _previousTargetPositionRelative;

		// Token: 0x04004868 RID: 18536
		[Token(Token = "0x4004868")]
		[FieldOffset(Offset = "0xDC")]
		private Vector3 _previousVelocityRootPos;
	}
}
