using System;
using Endnight.Animation;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Physics
{
	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000090")]
	public class PhysicsAnimatorUpdateTester : MonoBehaviour, IAnimatorMoveProxyReceiver, IAnimatorIKProxyReceiver, ILastUpdateProxyReceiver
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00003738 File Offset: 0x00001938
		[Token(Token = "0x17000029")]
		private bool IsValid
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0xA9ACA0", Offset = "0xA992A0", VA = "0x180A9ACA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000323")]
		[Address(RVA = "0xA9AF20", Offset = "0xA99520", VA = "0x180A9AF20")]
		private void OnEnable()
		{
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000324")]
		[Address(RVA = "0xA9AF30", Offset = "0xA99530", VA = "0x180A9AF30")]
		private void InitializeComponents()
		{
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000325")]
		[Address(RVA = "0xA9B390", Offset = "0xA99990", VA = "0x180A9B390")]
		private void UpdateRigidbodyPosition()
		{
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000326")]
		[Address(RVA = "0xA9B520", Offset = "0xA99B20", VA = "0x180A9B520")]
		private void UpdatePosition()
		{
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000327")]
		[Address(RVA = "0xA9B620", Offset = "0xA99C20", VA = "0x180A9B620")]
		private void Update()
		{
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000328")]
		[Address(RVA = "0xA9B670", Offset = "0xA99C70", VA = "0x180A9B670")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000329")]
		[Address(RVA = "0xA9B6B0", Offset = "0xA99CB0", VA = "0x180A9B6B0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032A")]
		[Address(RVA = "0xA9B6F0", Offset = "0xA99CF0", VA = "0x180A9B6F0", Slot = "4")]
		public void OnAnimatorMove()
		{
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032B")]
		[Address(RVA = "0xA9B730", Offset = "0xA99D30", VA = "0x180A9B730", Slot = "5")]
		public void OnAnimatorIK(int layerIndex)
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600032C RID: 812 RVA: 0x00003750 File Offset: 0x00001950
		[Token(Token = "0x1700002A")]
		public int LastUpdatePriority
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032D")]
		[Address(RVA = "0xA9B770", Offset = "0xA99D70", VA = "0x180A9B770", Slot = "6")]
		public void LastUpdate()
		{
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PhysicsAnimatorUpdateTester()
		{
		}

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _offset;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _transformTarget;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Animator _targetAnimator;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PhysicsAnimatorUpdateTester.MonoUpdateMode _rigidbodyUpdateMode;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private PhysicsAnimatorUpdateTester.MonoUpdateMode _positionUpdateMode;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private PhysicsAnimatorUpdateTester.PositionSetMode _positionSetMode;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Rigidbody _rigidbody;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 _position;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x68")]
		private AnimatorMoveProxy _animatorMoveProxy;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x70")]
		private AnimatorIKProxy _animatorIKProxy;

		// Token: 0x02000091 RID: 145
		[Token(Token = "0x2000091")]
		private enum PositionSetMode
		{
			// Token: 0x040001FB RID: 507
			[Token(Token = "0x40001FB")]
			MovePosition,
			// Token: 0x040001FC RID: 508
			[Token(Token = "0x40001FC")]
			TransformPosition
		}

		// Token: 0x02000092 RID: 146
		[Token(Token = "0x2000092")]
		private enum MonoUpdateMode
		{
			// Token: 0x040001FE RID: 510
			[Token(Token = "0x40001FE")]
			Update,
			// Token: 0x040001FF RID: 511
			[Token(Token = "0x40001FF")]
			FixedUpdate,
			// Token: 0x04000200 RID: 512
			[Token(Token = "0x4000200")]
			LateUpdate,
			// Token: 0x04000201 RID: 513
			[Token(Token = "0x4000201")]
			LastUpdate,
			// Token: 0x04000202 RID: 514
			[Token(Token = "0x4000202")]
			OnAnimatorMove,
			// Token: 0x04000203 RID: 515
			[Token(Token = "0x4000203")]
			OnAnimatorIK
		}
	}
}
