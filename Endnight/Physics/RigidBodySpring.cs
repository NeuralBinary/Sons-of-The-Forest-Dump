using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Physics
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x2000098")]
	public class RigidBodySpring : MonoBehaviour
	{
		// Token: 0x06000339 RID: 825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000339")]
		[Address(RVA = "0xA9C430", Offset = "0xA9AA30", VA = "0x180A9C430")]
		[ContextMenu("Collect From Transform")]
		private void CollectTargetFromTransform()
		{
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033A")]
		[Address(RVA = "0xA9C4F0", Offset = "0xA9AAF0", VA = "0x180A9C4F0")]
		private void Start()
		{
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033B")]
		[Address(RVA = "0xA9C4F0", Offset = "0xA9AAF0", VA = "0x180A9C4F0")]
		private void Reset()
		{
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033C")]
		[Address(RVA = "0xA9C6C0", Offset = "0xA9ACC0", VA = "0x180A9C6C0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033D")]
		[Address(RVA = "0xA9C6D0", Offset = "0xA9ACD0", VA = "0x180A9C6D0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033E")]
		[Address(RVA = "0xA9C870", Offset = "0xA9AE70", VA = "0x180A9C870")]
		private void OnCollisionEnter(Collision other)
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033F")]
		[Address(RVA = "0xA9C9D0", Offset = "0xA9AFD0", VA = "0x180A9C9D0")]
		private void OnCollisionExit(Collision other)
		{
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000340")]
		[Address(RVA = "0xA9CBA0", Offset = "0xA9B1A0", VA = "0x180A9CBA0")]
		private void LerpTowards()
		{
		}

		// Token: 0x06000341 RID: 833 RVA: 0x000037B0 File Offset: 0x000019B0
		[Token(Token = "0x6000341")]
		[Address(RVA = "0xA9D4D0", Offset = "0xA9BAD0", VA = "0x180A9D4D0")]
		private static Vector3 FixEulerAngles(Vector3 eulerAngles)
		{
			return default(Vector3);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000342")]
		[Address(RVA = "0xA9D560", Offset = "0xA9BB60", VA = "0x180A9D560")]
		public RigidBodySpring()
		{
		}

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Quaternion _target;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _speed;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x38")]
		private Rigidbody _rigidbody;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Quaternion _inertia;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _smooth;

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Vector3 _offsetEuler;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _currentOffset;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _snapDifference;

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _maxDifference;

		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _maxDifferenceStrength;

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x70")]
		private bool _kinematicLock;

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AnimationCurve _bounceCurve;

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _bounceDuration;

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x88")]
		private List<Collider> _activeCollisions;

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x90")]
		private List<Collider> _ignoredCollisions;

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x98")]
		private bool _restart;

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x9C")]
		private Quaternion _startRotation;

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0xAC")]
		private float _startTime;

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0xB0")]
		private bool _completedBounce;

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0xB4")]
		private int _collisionFinishedFrame;
	}
}
