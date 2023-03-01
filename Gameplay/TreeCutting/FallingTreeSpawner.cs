using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.TerrainDetail;
using UnityEngine;

namespace Sons.Gameplay.TreeCutting
{
	// Token: 0x020006DE RID: 1758
	[Token(Token = "0x20006DE")]
	public class FallingTreeSpawner : SingletonBehaviour<FallingTreeSpawner>
	{
		// Token: 0x06002CFA RID: 11514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CFA")]
		[Address(RVA = "0x2E05780", Offset = "0x2E04780", VA = "0x182E05780")]
		private void SpawnRandomInternal()
		{
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CFB")]
		[Address(RVA = "0x2E05490", Offset = "0x2E04490", VA = "0x182E05490")]
		private static void SpawnPrefabInternal(GameObject prefab)
		{
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CFC")]
		[Address(RVA = "0x2E051B0", Offset = "0x2E041B0", VA = "0x182E051B0")]
		public static void SpawnFromString(string filterString)
		{
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CFD")]
		[Address(RVA = "0x2E058E0", Offset = "0x2E048E0", VA = "0x182E058E0")]
		public static void SpawnRandom()
		{
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CFE")]
		[Address(RVA = "0x2E04EC0", Offset = "0x2E03EC0", VA = "0x182E04EC0")]
		public static void SpawnFallingTree(Vector3 position, Quaternion rotation, Vector3 finalTippingForce, WorldLocatorId id)
		{
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CFF")]
		[Address(RVA = "0x2E05B10", Offset = "0x2E04B10", VA = "0x182E05B10")]
		public FallingTreeSpawner()
		{
		}

		// Token: 0x04002841 RID: 10305
		[Token(Token = "0x4002841")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> _fallingTreePrefabs;

		// Token: 0x04002842 RID: 10306
		[Token(Token = "0x4002842")]
		[FieldOffset(Offset = "0x0")]
		private static float _forceAmount;
	}
}
