using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Splines;

namespace Sons.Gameplay
{
	// Token: 0x02000691 RID: 1681
	[Token(Token = "0x2000691")]
	public class PlayerSlideTrigger : MonoBehaviour
	{
		// Token: 0x06002B0B RID: 11019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B0B")]
		[Address(RVA = "0x2DDD480", Offset = "0x2DDC480", VA = "0x182DDD480")]
		public void GetForce(Vector3 worldPos, out Vector3 aim, out Vector3 force)
		{
		}

		// Token: 0x06002B0C RID: 11020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B0C")]
		[Address(RVA = "0x2DDD8F0", Offset = "0x2DDC8F0", VA = "0x182DDD8F0")]
		private void ReturnSplineForce(Vector3 referenceWorldPos, out Vector3 aim, out Vector3 force)
		{
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B0D")]
		[Address(RVA = "0x2DDD750", Offset = "0x2DDC750", VA = "0x182DDD750")]
		private void Initialize()
		{
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x0000C648 File Offset: 0x0000A848
		[Token(Token = "0x6002B0E")]
		[Address(RVA = "0x2DDD310", Offset = "0x2DDC310", VA = "0x182DDD310")]
		private Vector3 CalculateForceDirection()
		{
			return default(Vector3);
		}

		// Token: 0x06002B0F RID: 11023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B0F")]
		[Address(RVA = "0x208A170", Offset = "0x2089170", VA = "0x18208A170")]
		public PlayerSlideTrigger()
		{
		}

		// Token: 0x04002696 RID: 9878
		[Token(Token = "0x4002696")]
		private const float GizmoForceScale = 0.002f;

		// Token: 0x04002697 RID: 9879
		[Token(Token = "0x4002697")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _speedMultiplier;

		// Token: 0x04002698 RID: 9880
		[Token(Token = "0x4002698")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _splineMagnetMultiplier;

		// Token: 0x04002699 RID: 9881
		[Token(Token = "0x4002699")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SplineContainer _splineContainer;

		// Token: 0x0400269A RID: 9882
		[Token(Token = "0x400269A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector3 _forceDirection;

		// Token: 0x0400269B RID: 9883
		[Token(Token = "0x400269B")]
		[FieldOffset(Offset = "0x3C")]
		private bool _initialized;
	}
}
