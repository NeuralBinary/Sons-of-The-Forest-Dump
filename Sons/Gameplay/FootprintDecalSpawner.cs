using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000763 RID: 1891
	[Token(Token = "0x2000763")]
	public class FootprintDecalSpawner : MonoBehaviour
	{
		// Token: 0x06003323 RID: 13091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003323")]
		[Address(RVA = "0x34B1170", Offset = "0x34AF770", VA = "0x1834B1170")]
		private void Awake()
		{
		}

		// Token: 0x06003324 RID: 13092 RVA: 0x0000F5A0 File Offset: 0x0000D7A0
		[Token(Token = "0x6003324")]
		[Address(RVA = "0x998F00", Offset = "0x997500", VA = "0x180998F00")]
		public bool OnCorrectTerrain()
		{
			return default(bool);
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003325")]
		[Address(RVA = "0x34B1240", Offset = "0x34AF840", VA = "0x1834B1240")]
		private void Update()
		{
		}

		// Token: 0x06003326 RID: 13094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003326")]
		[Address(RVA = "0x34B13C0", Offset = "0x34AF9C0", VA = "0x1834B13C0")]
		private void UpdateAtPosition(Vector3 targetPosition)
		{
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x0000F5B8 File Offset: 0x0000D7B8
		[Token(Token = "0x6003327")]
		[Address(RVA = "0x34B2080", Offset = "0x34B0680", VA = "0x1834B2080")]
		private bool IsOnCorrectTerrain(Terrain activeTerrain, Vector3 position)
		{
			return default(bool);
		}

		// Token: 0x06003328 RID: 13096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003328")]
		[Address(RVA = "0x34B20F0", Offset = "0x34B06F0", VA = "0x1834B20F0")]
		private void SpawnDecalPrefab(Terrain activeTerrain, Vector3 position, Vector3 trForward)
		{
		}

		// Token: 0x06003329 RID: 13097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003329")]
		[Address(RVA = "0x34B2670", Offset = "0x34B0C70", VA = "0x1834B2670")]
		public FootprintDecalSpawner()
		{
		}

		// Token: 0x04002C13 RID: 11283
		[Token(Token = "0x4002C13")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _speedThreshold;

		// Token: 0x04002C14 RID: 11284
		[Token(Token = "0x4002C14")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _timeLatch;

		// Token: 0x04002C15 RID: 11285
		[Token(Token = "0x4002C15")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _prefabLifespan;

		// Token: 0x04002C16 RID: 11286
		[Token(Token = "0x4002C16")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _heightOffset;

		// Token: 0x04002C17 RID: 11287
		[Token(Token = "0x4002C17")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _maxEmissionHeight;

		// Token: 0x04002C18 RID: 11288
		[Token(Token = "0x4002C18")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _forwardOffset;

		// Token: 0x04002C19 RID: 11289
		[Token(Token = "0x4002C19")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject[] _prefabs;

		// Token: 0x04002C1A RID: 11290
		[Token(Token = "0x4002C1A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int[] _textureIndexes;

		// Token: 0x04002C1B RID: 11291
		[Token(Token = "0x4002C1B")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 _previousPosition;

		// Token: 0x04002C1C RID: 11292
		[Token(Token = "0x4002C1C")]
		[FieldOffset(Offset = "0x54")]
		private bool _triggered;

		// Token: 0x04002C1D RID: 11293
		[Token(Token = "0x4002C1D")]
		[FieldOffset(Offset = "0x58")]
		private float _latch;

		// Token: 0x04002C1E RID: 11294
		[Token(Token = "0x4002C1E")]
		[FieldOffset(Offset = "0x5C")]
		private bool _onCorrectTerrain;
	}
}
