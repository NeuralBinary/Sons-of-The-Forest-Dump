using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000655 RID: 1621
	[Token(Token = "0x2000655")]
	public class SnowKickSpawner : MonoBehaviour
	{
		// Token: 0x06002995 RID: 10645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002995")]
		[Address(RVA = "0x2DD08A0", Offset = "0x2DCF8A0", VA = "0x182DD08A0")]
		private void Awake()
		{
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002996")]
		[Address(RVA = "0x2DDFC10", Offset = "0x2DDEC10", VA = "0x182DDFC10")]
		private void Update()
		{
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002997")]
		[Address(RVA = "0x2DDF840", Offset = "0x2DDE840", VA = "0x182DDF840")]
		private void Trigger()
		{
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002998")]
		[Address(RVA = "0x2DDF2F0", Offset = "0x2DDE2F0", VA = "0x182DDF2F0")]
		private void SpawnSnowKickPrefab(Vector3 position, Vector3 trForward)
		{
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002999")]
		[Address(RVA = "0x2DDFCA0", Offset = "0x2DDECA0", VA = "0x182DDFCA0")]
		public SnowKickSpawner()
		{
		}

		// Token: 0x04002544 RID: 9540
		[Token(Token = "0x4002544")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float MaxViewerDistance;

		// Token: 0x04002545 RID: 9541
		[Token(Token = "0x4002545")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float MinWaterHeight;

		// Token: 0x04002546 RID: 9542
		[Token(Token = "0x4002546")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _speedThreshold;

		// Token: 0x04002547 RID: 9543
		[Token(Token = "0x4002547")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _maxHeightThreshold;

		// Token: 0x04002548 RID: 9544
		[Token(Token = "0x4002548")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _minDotProduct;

		// Token: 0x04002549 RID: 9545
		[Token(Token = "0x4002549")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _timeLatch;

		// Token: 0x0400254A RID: 9546
		[Token(Token = "0x400254A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _prefabLifespan;

		// Token: 0x0400254B RID: 9547
		[Token(Token = "0x400254B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _heightOffset;

		// Token: 0x0400254C RID: 9548
		[Token(Token = "0x400254C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _forwardOffset;

		// Token: 0x0400254D RID: 9549
		[Token(Token = "0x400254D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject[] _snowKickPrefab;

		// Token: 0x0400254E RID: 9550
		[Token(Token = "0x400254E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _requiredSnowDepth;

		// Token: 0x0400254F RID: 9551
		[Token(Token = "0x400254F")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 _previousPosition;

		// Token: 0x04002550 RID: 9552
		[Token(Token = "0x4002550")]
		[FieldOffset(Offset = "0x60")]
		private bool _triggered;

		// Token: 0x04002551 RID: 9553
		[Token(Token = "0x4002551")]
		[FieldOffset(Offset = "0x64")]
		private float _latch;

		// Token: 0x04002552 RID: 9554
		[Token(Token = "0x4002552")]
		[FieldOffset(Offset = "0x68")]
		private bool _isInSnow;
	}
}
