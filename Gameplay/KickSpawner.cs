using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000654 RID: 1620
	[Token(Token = "0x2000654")]
	public class KickSpawner : MonoBehaviour
	{
		// Token: 0x06002990 RID: 10640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002990")]
		[Address(RVA = "0x2DD08A0", Offset = "0x2DCF8A0", VA = "0x182DD08A0")]
		private void Awake()
		{
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002991")]
		[Address(RVA = "0x2DD1240", Offset = "0x2DD0240", VA = "0x182DD1240")]
		private void Update()
		{
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002992")]
		[Address(RVA = "0x2DD0D20", Offset = "0x2DCFD20", VA = "0x182DD0D20")]
		private void Trigger()
		{
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002993")]
		[Address(RVA = "0x2DD08E0", Offset = "0x2DCF8E0", VA = "0x182DD08E0")]
		private void SpawnKickPrefab(Vector3 position, Vector3 trForward, GameObject[] prefab)
		{
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002994")]
		[Address(RVA = "0x2DD12D0", Offset = "0x2DD02D0", VA = "0x182DD12D0")]
		public KickSpawner()
		{
		}

		// Token: 0x04002532 RID: 9522
		[Token(Token = "0x4002532")]
		private const float MaxViewerDistance = 60f;

		// Token: 0x04002533 RID: 9523
		[Token(Token = "0x4002533")]
		private const float MinWaterHeight = 0.1f;

		// Token: 0x04002534 RID: 9524
		[Token(Token = "0x4002534")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _speedThreshold;

		// Token: 0x04002535 RID: 9525
		[Token(Token = "0x4002535")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _timeLatch;

		// Token: 0x04002536 RID: 9526
		[Token(Token = "0x4002536")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _prefabLifespan;

		// Token: 0x04002537 RID: 9527
		[Token(Token = "0x4002537")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _heightOffset;

		// Token: 0x04002538 RID: 9528
		[Token(Token = "0x4002538")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _forwardOffset;

		// Token: 0x04002539 RID: 9529
		[Token(Token = "0x4002539")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject[] _snowKickPrefab;

		// Token: 0x0400253A RID: 9530
		[Token(Token = "0x400253A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject[] _KickPrefab;

		// Token: 0x0400253B RID: 9531
		[Token(Token = "0x400253B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject[] _KickLeavesPrefab;

		// Token: 0x0400253C RID: 9532
		[Token(Token = "0x400253C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _requiredSnowDepth;

		// Token: 0x0400253D RID: 9533
		[Token(Token = "0x400253D")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 _previousPosition;

		// Token: 0x0400253E RID: 9534
		[Token(Token = "0x400253E")]
		[FieldOffset(Offset = "0x60")]
		private bool _triggered;

		// Token: 0x0400253F RID: 9535
		[Token(Token = "0x400253F")]
		[FieldOffset(Offset = "0x61")]
		private bool _groundTriggered;

		// Token: 0x04002540 RID: 9536
		[Token(Token = "0x4002540")]
		[FieldOffset(Offset = "0x62")]
		private bool _leavesTriggered;

		// Token: 0x04002541 RID: 9537
		[Token(Token = "0x4002541")]
		[FieldOffset(Offset = "0x63")]
		private bool _snowTriggered;

		// Token: 0x04002542 RID: 9538
		[Token(Token = "0x4002542")]
		[FieldOffset(Offset = "0x64")]
		private float _latch;

		// Token: 0x04002543 RID: 9539
		[Token(Token = "0x4002543")]
		[FieldOffset(Offset = "0x68")]
		private bool _isInValidTerrain;
	}
}
