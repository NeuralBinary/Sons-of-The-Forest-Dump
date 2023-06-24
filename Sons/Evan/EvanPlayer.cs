using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding;
using UnityEngine;

namespace Sons.Evan
{
	// Token: 0x02000651 RID: 1617
	[Token(Token = "0x2000651")]
	public class EvanPlayer : MonoBehaviour
	{
		// Token: 0x060029CF RID: 10703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029CF")]
		[Address(RVA = "0x5F2110", Offset = "0x5F0710", VA = "0x1805F2110")]
		public void SetRunActive(bool runActive)
		{
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029D0")]
		[Address(RVA = "0x33F24E0", Offset = "0x33F0AE0", VA = "0x1833F24E0")]
		private IEnumerator FollowTarget(GameObject target, float updateDelay = 1f)
		{
			return null;
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
		[Token(Token = "0x60029D1")]
		[Address(RVA = "0x33F25E0", Offset = "0x33F0BE0", VA = "0x1833F25E0")]
		private static Vector3 ConvertToMovementInput(Vector3 localOffset)
		{
			return default(Vector3);
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D2")]
		[Address(RVA = "0x33F2700", Offset = "0x33F0D00", VA = "0x1833F2700")]
		private void DoStuckDetection(Vector3 playerPosition)
		{
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x0000C510 File Offset: 0x0000A710
		[Token(Token = "0x60029D3")]
		[Address(RVA = "0x33F2940", Offset = "0x33F0F40", VA = "0x1833F2940")]
		private static Vector3 GetResolvedPosition(Vector3 position, int layerMask)
		{
			return default(Vector3);
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x0000C528 File Offset: 0x0000A728
		[Token(Token = "0x60029D4")]
		[Address(RVA = "0x33F2B40", Offset = "0x33F1140", VA = "0x1833F2B40")]
		private Vector3 GetPathNodePosition(Vector3 playerPosition)
		{
			return default(Vector3);
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D5")]
		[Address(RVA = "0x33F2D90", Offset = "0x33F1390", VA = "0x1833F2D90")]
		private void EvaluateCurrentNode(Vector3 playerPosition, int followTargetPathIndex, List<Vector3> pathNodes, out Vector3 currentNode, out float distanceToNode)
		{
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D6")]
		[Address(RVA = "0x33F2E90", Offset = "0x33F1490", VA = "0x1833F2E90")]
		private void OnFollowTargetPathFound(Path result)
		{
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D7")]
		[Address(RVA = "0x33F2FB0", Offset = "0x33F15B0", VA = "0x1833F2FB0")]
		public void StartFollow(GameObject target)
		{
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D8")]
		[Address(RVA = "0x33F3130", Offset = "0x33F1730", VA = "0x1833F3130")]
		private void UpdateOffset(GameObject target)
		{
		}

		// Token: 0x060029D9 RID: 10713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D9")]
		[Address(RVA = "0x33F3320", Offset = "0x33F1920", VA = "0x1833F3320")]
		public void StopFollow()
		{
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029DA")]
		[Address(RVA = "0x33F3390", Offset = "0x33F1990", VA = "0x1833F3390")]
		public void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x0000C540 File Offset: 0x0000A740
		[Token(Token = "0x60029DB")]
		[Address(RVA = "0x33F3410", Offset = "0x33F1A10", VA = "0x1833F3410")]
		public float Get2DDistanceToTarget()
		{
			return 0f;
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029DC")]
		[Address(RVA = "0x33F3450", Offset = "0x33F1A50", VA = "0x1833F3450")]
		public EvanPlayer()
		{
		}

		// Token: 0x04002530 RID: 9520
		[Token(Token = "0x4002530")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _turnSpeed;

		// Token: 0x04002531 RID: 9521
		[Token(Token = "0x4002531")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _pathRefreshTimer;

		// Token: 0x04002532 RID: 9522
		[Token(Token = "0x4002532")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _minNodeDist;

		// Token: 0x04002533 RID: 9523
		[Token(Token = "0x4002533")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private LayerMask _layerMask;

		// Token: 0x04002534 RID: 9524
		[Token(Token = "0x4002534")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 _lastPosition;

		// Token: 0x04002535 RID: 9525
		[Token(Token = "0x4002535")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 _movementDelta;

		// Token: 0x04002536 RID: 9526
		[Token(Token = "0x4002536")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _stuckDetectionThreshold;

		// Token: 0x04002537 RID: 9527
		[Token(Token = "0x4002537")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _stuckDetectionTimer;

		// Token: 0x04002538 RID: 9528
		[Token(Token = "0x4002538")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _runActive;

		// Token: 0x04002539 RID: 9529
		[Token(Token = "0x4002539")]
		[FieldOffset(Offset = "0x58")]
		private Path _followTargetPath;

		// Token: 0x0400253A RID: 9530
		[Token(Token = "0x400253A")]
		[FieldOffset(Offset = "0x60")]
		private List<Vector3> _pathNodes;

		// Token: 0x0400253B RID: 9531
		[Token(Token = "0x400253B")]
		[FieldOffset(Offset = "0x68")]
		private bool _waitingForPath;

		// Token: 0x0400253C RID: 9532
		[Token(Token = "0x400253C")]
		[FieldOffset(Offset = "0x6C")]
		private int _followTargetPathIndex;

		// Token: 0x0400253D RID: 9533
		[Token(Token = "0x400253D")]
		[FieldOffset(Offset = "0x70")]
		private Coroutine _followCoroutine;

		// Token: 0x0400253E RID: 9534
		[Token(Token = "0x400253E")]
		[FieldOffset(Offset = "0x78")]
		private float _pathAge;

		// Token: 0x0400253F RID: 9535
		[Token(Token = "0x400253F")]
		[FieldOffset(Offset = "0x7C")]
		private Vector3 _targetTrackedPosition;

		// Token: 0x04002540 RID: 9536
		[Token(Token = "0x4002540")]
		[FieldOffset(Offset = "0x88")]
		private float _movementDeltaTimer;

		// Token: 0x04002541 RID: 9537
		[Token(Token = "0x4002541")]
		[FieldOffset(Offset = "0x8C")]
		private Vector3 _offset;
	}
}
