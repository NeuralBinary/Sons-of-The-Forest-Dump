using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding;
using UnityEngine;

namespace Sons.Evan
{
	// Token: 0x02000747 RID: 1863
	[Token(Token = "0x2000747")]
	public class EvanPlayer : MonoBehaviour
	{
		// Token: 0x06003074 RID: 12404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003074")]
		[Address(RVA = "0x580620", Offset = "0x57F620", VA = "0x180580620")]
		public void SetRunActive(bool runActive)
		{
		}

		// Token: 0x06003075 RID: 12405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003075")]
		[Address(RVA = "0x2E2A8C0", Offset = "0x2E298C0", VA = "0x182E2A8C0")]
		private IEnumerator FollowTarget(GameObject target, float updateDelay = 1f)
		{
			return null;
		}

		// Token: 0x06003076 RID: 12406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003076")]
		[Address(RVA = "0x2E2A5F0", Offset = "0x2E295F0", VA = "0x182E2A5F0")]
		private void DoStuckDetection(Vector3 playerPosition)
		{
		}

		// Token: 0x06003077 RID: 12407 RVA: 0x0000DCC8 File Offset: 0x0000BEC8
		[Token(Token = "0x6003077")]
		[Address(RVA = "0x2E2AC00", Offset = "0x2E29C00", VA = "0x182E2AC00")]
		private static Vector3 GetResolvedPosition(Vector3 position, int layerMask)
		{
			return default(Vector3);
		}

		// Token: 0x06003078 RID: 12408 RVA: 0x0000DCE0 File Offset: 0x0000BEE0
		[Token(Token = "0x6003078")]
		[Address(RVA = "0x2E2A9F0", Offset = "0x2E299F0", VA = "0x182E2A9F0")]
		private Vector3 GetPathNodePosition(Vector3 playerPosition)
		{
			return default(Vector3);
		}

		// Token: 0x06003079 RID: 12409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003079")]
		[Address(RVA = "0x2E2A7E0", Offset = "0x2E297E0", VA = "0x182E2A7E0")]
		private void EvaluateCurrentNode(Vector3 playerPosition, int followTargetPathIndex, List<Vector3> pathNodes, out Vector3 currentNode, out float distanceToNode)
		{
		}

		// Token: 0x0600307A RID: 12410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600307A")]
		[Address(RVA = "0x2E2AE30", Offset = "0x2E29E30", VA = "0x182E2AE30")]
		private void OnFollowTargetPathFound(Path result)
		{
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
		[Token(Token = "0x600307B")]
		[Address(RVA = "0x2E2A500", Offset = "0x2E29500", VA = "0x182E2A500")]
		private static Vector3 ConditionLookRotation(Vector3 lookRotation)
		{
			return default(Vector3);
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600307C")]
		[Address(RVA = "0x2E2AEC0", Offset = "0x2E29EC0", VA = "0x182E2AEC0")]
		public void StartFollow(GameObject target)
		{
		}

		// Token: 0x0600307D RID: 12413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600307D")]
		[Address(RVA = "0x2E2AFE0", Offset = "0x2E29FE0", VA = "0x182E2AFE0")]
		private void UpdateOffset(GameObject target)
		{
		}

		// Token: 0x0600307E RID: 12414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600307E")]
		[Address(RVA = "0x2E2AFA0", Offset = "0x2E29FA0", VA = "0x182E2AFA0")]
		public void StopFollow()
		{
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600307F")]
		[Address(RVA = "0x2E2ADE0", Offset = "0x2E29DE0", VA = "0x182E2ADE0")]
		public void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06003080 RID: 12416 RVA: 0x0000DD10 File Offset: 0x0000BF10
		[Token(Token = "0x6003080")]
		[Address(RVA = "0x2E2A950", Offset = "0x2E29950", VA = "0x182E2A950")]
		public float Get2DDistanceToTarget()
		{
			return default(float);
		}

		// Token: 0x06003081 RID: 12417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003081")]
		[Address(RVA = "0x2E2B120", Offset = "0x2E2A120", VA = "0x182E2B120")]
		public EvanPlayer()
		{
		}

		// Token: 0x04002A6A RID: 10858
		[Token(Token = "0x4002A6A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _turnSpeed;

		// Token: 0x04002A6B RID: 10859
		[Token(Token = "0x4002A6B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _pathRefreshTimer;

		// Token: 0x04002A6C RID: 10860
		[Token(Token = "0x4002A6C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _minNodeDist;

		// Token: 0x04002A6D RID: 10861
		[Token(Token = "0x4002A6D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private LayerMask _layerMask;

		// Token: 0x04002A6E RID: 10862
		[Token(Token = "0x4002A6E")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 _lastPosition;

		// Token: 0x04002A6F RID: 10863
		[Token(Token = "0x4002A6F")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 _movementDelta;

		// Token: 0x04002A70 RID: 10864
		[Token(Token = "0x4002A70")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _stuckDetectionThreshold;

		// Token: 0x04002A71 RID: 10865
		[Token(Token = "0x4002A71")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _stuckDetectionTimer;

		// Token: 0x04002A72 RID: 10866
		[Token(Token = "0x4002A72")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _runActive;

		// Token: 0x04002A73 RID: 10867
		[Token(Token = "0x4002A73")]
		[FieldOffset(Offset = "0x58")]
		private Path _followTargetPath;

		// Token: 0x04002A74 RID: 10868
		[Token(Token = "0x4002A74")]
		[FieldOffset(Offset = "0x60")]
		private List<Vector3> _pathNodes;

		// Token: 0x04002A75 RID: 10869
		[Token(Token = "0x4002A75")]
		[FieldOffset(Offset = "0x68")]
		private bool _waitingForPath;

		// Token: 0x04002A76 RID: 10870
		[Token(Token = "0x4002A76")]
		[FieldOffset(Offset = "0x6C")]
		private int _followTargetPathIndex;

		// Token: 0x04002A77 RID: 10871
		[Token(Token = "0x4002A77")]
		[FieldOffset(Offset = "0x70")]
		private Coroutine _followCoroutine;

		// Token: 0x04002A78 RID: 10872
		[Token(Token = "0x4002A78")]
		[FieldOffset(Offset = "0x78")]
		private float _pathAge;

		// Token: 0x04002A79 RID: 10873
		[Token(Token = "0x4002A79")]
		[FieldOffset(Offset = "0x7C")]
		private Vector3 _targetTrackedPosition;

		// Token: 0x04002A7A RID: 10874
		[Token(Token = "0x4002A7A")]
		[FieldOffset(Offset = "0x88")]
		private float _movementDeltaTimer;

		// Token: 0x04002A7B RID: 10875
		[Token(Token = "0x4002A7B")]
		[FieldOffset(Offset = "0x8C")]
		private Vector3 _offset;
	}
}
