using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Splines;

namespace Sons.Gameplay
{
	// Token: 0x020007BE RID: 1982
	[Token(Token = "0x20007BE")]
	public class PlayerSlideTrigger : MonoBehaviour
	{
		// Token: 0x0600358A RID: 13706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600358A")]
		[Address(RVA = "0x34E28E0", Offset = "0x34E0EE0", VA = "0x1834E28E0")]
		public void GetForce(Vector3 worldPos, out Vector3 aim, out Vector3 force)
		{
		}

		// Token: 0x0600358B RID: 13707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600358B")]
		[Address(RVA = "0x34E2CA0", Offset = "0x34E12A0", VA = "0x1834E2CA0")]
		private void ReturnSplineForce(Vector3 referenceWorldPos, out Vector3 aim, out Vector3 force)
		{
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600358C")]
		[Address(RVA = "0x34E31B0", Offset = "0x34E17B0", VA = "0x1834E31B0")]
		private void Initialize()
		{
		}

		// Token: 0x0600358D RID: 13709 RVA: 0x00010080 File Offset: 0x0000E280
		[Token(Token = "0x600358D")]
		[Address(RVA = "0x34E3300", Offset = "0x34E1900", VA = "0x1834E3300")]
		private Vector3 CalculateForceDirection()
		{
			return default(Vector3);
		}

		// Token: 0x0600358E RID: 13710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600358E")]
		[Address(RVA = "0x2436D10", Offset = "0x2435310", VA = "0x182436D10")]
		public PlayerSlideTrigger()
		{
		}

		// Token: 0x04002E3D RID: 11837
		[Token(Token = "0x4002E3D")]
		private const float GizmoForceScale = 0.002f;

		// Token: 0x04002E3E RID: 11838
		[Token(Token = "0x4002E3E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _speedMultiplier;

		// Token: 0x04002E3F RID: 11839
		[Token(Token = "0x4002E3F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _splineMagnetMultiplier;

		// Token: 0x04002E40 RID: 11840
		[Token(Token = "0x4002E40")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SplineContainer _splineContainer;

		// Token: 0x04002E41 RID: 11841
		[Token(Token = "0x4002E41")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector3 _forceDirection;

		// Token: 0x04002E42 RID: 11842
		[Token(Token = "0x4002E42")]
		[FieldOffset(Offset = "0x3C")]
		private bool _initialized;
	}
}
