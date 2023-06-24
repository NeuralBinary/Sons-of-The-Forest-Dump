using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x020006FF RID: 1791
	[Token(Token = "0x20006FF")]
	[AddComponentMenu("Sons/Characters/FrogSpawner")]
	public class FrogSpawner : MonoBehaviour
	{
		// Token: 0x06002F5B RID: 12123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F5B")]
		[Address(RVA = "0x345E7B0", Offset = "0x345CDB0", VA = "0x18345E7B0")]
		private void OnEnable()
		{
		}

		// Token: 0x06002F5C RID: 12124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F5C")]
		[Address(RVA = "0x345E8F0", Offset = "0x345CEF0", VA = "0x18345E8F0")]
		private void OnDisable()
		{
		}

		// Token: 0x06002F5D RID: 12125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F5D")]
		[Address(RVA = "0x345E7B0", Offset = "0x345CDB0", VA = "0x18345E7B0")]
		private void CheckSpawn()
		{
		}

		// Token: 0x06002F5E RID: 12126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F5E")]
		[Address(RVA = "0x345EA20", Offset = "0x345D020", VA = "0x18345EA20")]
		private void SpawnFrog()
		{
		}

		// Token: 0x06002F5F RID: 12127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F5F")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public FrogSpawner()
		{
		}

		// Token: 0x040028FA RID: 10490
		[Token(Token = "0x40028FA")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _spawnChance;

		// Token: 0x040028FB RID: 10491
		[Token(Token = "0x40028FB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleFrog _frogPrefab;

		// Token: 0x040028FC RID: 10492
		[Token(Token = "0x40028FC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform[] _spawnPoints;

		// Token: 0x040028FD RID: 10493
		[Token(Token = "0x40028FD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _spawnRadius;

		// Token: 0x040028FE RID: 10494
		[Token(Token = "0x40028FE")]
		[FieldOffset(Offset = "0x40")]
		private SimpleFrog _frogInstance;
	}
}
