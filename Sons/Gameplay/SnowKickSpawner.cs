using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000773 RID: 1907
	[Token(Token = "0x2000773")]
	public class SnowKickSpawner : MonoBehaviour
	{
		// Token: 0x06003376 RID: 13174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003376")]
		[Address(RVA = "0x34B8DE0", Offset = "0x34B73E0", VA = "0x1834B8DE0")]
		private void Awake()
		{
		}

		// Token: 0x06003377 RID: 13175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003377")]
		[Address(RVA = "0x34B9C90", Offset = "0x34B8290", VA = "0x1834B9C90")]
		private void Update()
		{
		}

		// Token: 0x06003378 RID: 13176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003378")]
		[Address(RVA = "0x34B9DE0", Offset = "0x34B83E0", VA = "0x1834B9DE0")]
		private void Trigger()
		{
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003379")]
		[Address(RVA = "0x34BA350", Offset = "0x34B8950", VA = "0x1834BA350")]
		private void SpawnSnowKickPrefab(Vector3 position, Vector3 trForward)
		{
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600337A")]
		[Address(RVA = "0x34BAB80", Offset = "0x34B9180", VA = "0x1834BAB80")]
		public SnowKickSpawner()
		{
		}

		// Token: 0x04002C8D RID: 11405
		[Token(Token = "0x4002C8D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float MaxViewerDistance;

		// Token: 0x04002C8E RID: 11406
		[Token(Token = "0x4002C8E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float MinWaterHeight;

		// Token: 0x04002C8F RID: 11407
		[Token(Token = "0x4002C8F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _speedThreshold;

		// Token: 0x04002C90 RID: 11408
		[Token(Token = "0x4002C90")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _maxHeightThreshold;

		// Token: 0x04002C91 RID: 11409
		[Token(Token = "0x4002C91")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _minDotProduct;

		// Token: 0x04002C92 RID: 11410
		[Token(Token = "0x4002C92")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _timeLatch;

		// Token: 0x04002C93 RID: 11411
		[Token(Token = "0x4002C93")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _prefabLifespan;

		// Token: 0x04002C94 RID: 11412
		[Token(Token = "0x4002C94")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _heightOffset;

		// Token: 0x04002C95 RID: 11413
		[Token(Token = "0x4002C95")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _forwardOffset;

		// Token: 0x04002C96 RID: 11414
		[Token(Token = "0x4002C96")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject[] _snowKickPrefab;

		// Token: 0x04002C97 RID: 11415
		[Token(Token = "0x4002C97")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _requiredSnowDepth;

		// Token: 0x04002C98 RID: 11416
		[Token(Token = "0x4002C98")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 _previousPosition;

		// Token: 0x04002C99 RID: 11417
		[Token(Token = "0x4002C99")]
		[FieldOffset(Offset = "0x60")]
		private bool _triggered;

		// Token: 0x04002C9A RID: 11418
		[Token(Token = "0x4002C9A")]
		[FieldOffset(Offset = "0x64")]
		private float _latch;
	}
}
