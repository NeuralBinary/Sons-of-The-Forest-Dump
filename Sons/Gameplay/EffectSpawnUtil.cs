using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000762 RID: 1890
	[Token(Token = "0x2000762")]
	public static class EffectSpawnUtil
	{
		// Token: 0x06003320 RID: 13088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003320")]
		[Address(RVA = "0x34B0990", Offset = "0x34AEF90", VA = "0x1834B0990")]
		public static Transform SpawnPooledEffect(GameObject spawnPrefab, Vector3 spawnPos, Quaternion spawnRot, float lifeSpan)
		{
			return null;
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003321")]
		[Address(RVA = "0x34B0D00", Offset = "0x34AF300", VA = "0x1834B0D00")]
		public static void DespawnPooledEffect(Transform effect)
		{
		}

		// Token: 0x06003322 RID: 13090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003322")]
		[Address(RVA = "0x34B0E30", Offset = "0x34AF430", VA = "0x1834B0E30")]
		public static Transform SpawnPooledEffect(GameObject spawnPrefab, Vector3 spawnPos, Quaternion spawnRot)
		{
			return null;
		}

		// Token: 0x04002C12 RID: 11282
		[Token(Token = "0x4002C12")]
		private const string ParticlePool = "Particles";
	}
}
