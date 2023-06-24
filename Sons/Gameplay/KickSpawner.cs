using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000772 RID: 1906
	[Token(Token = "0x2000772")]
	public class KickSpawner : MonoBehaviour
	{
		// Token: 0x06003371 RID: 13169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003371")]
		[Address(RVA = "0x34B8DE0", Offset = "0x34B73E0", VA = "0x1834B8DE0")]
		private void Awake()
		{
		}

		// Token: 0x06003372 RID: 13170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003372")]
		[Address(RVA = "0x34B8EB0", Offset = "0x34B74B0", VA = "0x1834B8EB0")]
		private void Update()
		{
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003373")]
		[Address(RVA = "0x34B9000", Offset = "0x34B7600", VA = "0x1834B9000")]
		private void Trigger()
		{
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003374")]
		[Address(RVA = "0x34B96A0", Offset = "0x34B7CA0", VA = "0x1834B96A0")]
		private void SpawnKickPrefab(Vector3 position, Vector3 trForward, GameObject[] prefab)
		{
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003375")]
		[Address(RVA = "0x34B9C20", Offset = "0x34B8220", VA = "0x1834B9C20")]
		public KickSpawner()
		{
		}

		// Token: 0x04002C7B RID: 11387
		[Token(Token = "0x4002C7B")]
		private const float MaxViewerDistance = 60f;

		// Token: 0x04002C7C RID: 11388
		[Token(Token = "0x4002C7C")]
		private const float MinWaterHeight = 0.1f;

		// Token: 0x04002C7D RID: 11389
		[Token(Token = "0x4002C7D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _speedThreshold;

		// Token: 0x04002C7E RID: 11390
		[Token(Token = "0x4002C7E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _timeLatch;

		// Token: 0x04002C7F RID: 11391
		[Token(Token = "0x4002C7F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _prefabLifespan;

		// Token: 0x04002C80 RID: 11392
		[Token(Token = "0x4002C80")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _heightOffset;

		// Token: 0x04002C81 RID: 11393
		[Token(Token = "0x4002C81")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _forwardOffset;

		// Token: 0x04002C82 RID: 11394
		[Token(Token = "0x4002C82")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject[] _snowKickPrefab;

		// Token: 0x04002C83 RID: 11395
		[Token(Token = "0x4002C83")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject[] _KickPrefab;

		// Token: 0x04002C84 RID: 11396
		[Token(Token = "0x4002C84")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject[] _KickLeavesPrefab;

		// Token: 0x04002C85 RID: 11397
		[Token(Token = "0x4002C85")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _requiredSnowDepth;

		// Token: 0x04002C86 RID: 11398
		[Token(Token = "0x4002C86")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 _previousPosition;

		// Token: 0x04002C87 RID: 11399
		[Token(Token = "0x4002C87")]
		[FieldOffset(Offset = "0x60")]
		private bool _triggered;

		// Token: 0x04002C88 RID: 11400
		[Token(Token = "0x4002C88")]
		[FieldOffset(Offset = "0x61")]
		private bool _groundTriggered;

		// Token: 0x04002C89 RID: 11401
		[Token(Token = "0x4002C89")]
		[FieldOffset(Offset = "0x62")]
		private bool _leavesTriggered;

		// Token: 0x04002C8A RID: 11402
		[Token(Token = "0x4002C8A")]
		[FieldOffset(Offset = "0x63")]
		private bool _snowTriggered;

		// Token: 0x04002C8B RID: 11403
		[Token(Token = "0x4002C8B")]
		[FieldOffset(Offset = "0x64")]
		private float _latch;

		// Token: 0x04002C8C RID: 11404
		[Token(Token = "0x4002C8C")]
		[FieldOffset(Offset = "0x68")]
		private bool _isInValidTerrain;
	}
}
