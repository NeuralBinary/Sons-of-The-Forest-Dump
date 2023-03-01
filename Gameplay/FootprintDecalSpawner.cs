using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000645 RID: 1605
	[Token(Token = "0x2000645")]
	public class FootprintDecalSpawner : MonoBehaviour
	{
		// Token: 0x06002940 RID: 10560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002940")]
		[Address(RVA = "0x2DC8FF0", Offset = "0x2DC7FF0", VA = "0x182DC8FF0")]
		private void Awake()
		{
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		[Token(Token = "0x6002941")]
		[Address(RVA = "0x86F2D0", Offset = "0x86E2D0", VA = "0x18086F2D0")]
		public bool OnCorrectTerrain()
		{
			return default(bool);
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002942")]
		[Address(RVA = "0x2DC97E0", Offset = "0x2DC87E0", VA = "0x182DC97E0")]
		private void Update()
		{
		}

		// Token: 0x06002943 RID: 10563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002943")]
		[Address(RVA = "0x2DC94A0", Offset = "0x2DC84A0", VA = "0x182DC94A0")]
		private void UpdateAtPosition(Vector3 targetPosition)
		{
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
		[Token(Token = "0x6002944")]
		[Address(RVA = "0x2DC9030", Offset = "0x2DC8030", VA = "0x182DC9030")]
		private bool IsOnCorrectTerrain(Terrain activeTerrain, Vector3 position)
		{
			return default(bool);
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002945")]
		[Address(RVA = "0x2DC90B0", Offset = "0x2DC80B0", VA = "0x182DC90B0")]
		private void SpawnDecalPrefab(Terrain activeTerrain, Vector3 position, Vector3 trForward)
		{
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002946")]
		[Address(RVA = "0x2DC9890", Offset = "0x2DC8890", VA = "0x182DC9890")]
		public FootprintDecalSpawner()
		{
		}

		// Token: 0x040024CE RID: 9422
		[Token(Token = "0x40024CE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _speedThreshold;

		// Token: 0x040024CF RID: 9423
		[Token(Token = "0x40024CF")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _timeLatch;

		// Token: 0x040024D0 RID: 9424
		[Token(Token = "0x40024D0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _prefabLifespan;

		// Token: 0x040024D1 RID: 9425
		[Token(Token = "0x40024D1")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _heightOffset;

		// Token: 0x040024D2 RID: 9426
		[Token(Token = "0x40024D2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _forwardOffset;

		// Token: 0x040024D3 RID: 9427
		[Token(Token = "0x40024D3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject[] _prefabs;

		// Token: 0x040024D4 RID: 9428
		[Token(Token = "0x40024D4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int[] _textureIndexes;

		// Token: 0x040024D5 RID: 9429
		[Token(Token = "0x40024D5")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 _previousPosition;

		// Token: 0x040024D6 RID: 9430
		[Token(Token = "0x40024D6")]
		[FieldOffset(Offset = "0x54")]
		private bool _triggered;

		// Token: 0x040024D7 RID: 9431
		[Token(Token = "0x40024D7")]
		[FieldOffset(Offset = "0x58")]
		private float _latch;

		// Token: 0x040024D8 RID: 9432
		[Token(Token = "0x40024D8")]
		[FieldOffset(Offset = "0x5C")]
		private bool _onCorrectTerrain;
	}
}
