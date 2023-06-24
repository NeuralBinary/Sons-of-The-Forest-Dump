using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.TerrainDetail;
using UnityEngine;

namespace Sons.Gameplay.TreeCutting
{
	// Token: 0x0200082A RID: 2090
	[Token(Token = "0x200082A")]
	public class FallingTreeSpawner : SingletonBehaviour<FallingTreeSpawner>
	{
		// Token: 0x06003ADE RID: 15070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ADE")]
		[Address(RVA = "0x357F580", Offset = "0x357DB80", VA = "0x18357F580")]
		private void SpawnRandomInternal()
		{
		}

		// Token: 0x06003ADF RID: 15071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ADF")]
		[Address(RVA = "0x357F800", Offset = "0x357DE00", VA = "0x18357F800")]
		private static void SpawnPrefabInternal(GameObject prefab)
		{
		}

		// Token: 0x06003AE0 RID: 15072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE0")]
		[Address(RVA = "0x357FC00", Offset = "0x357E200", VA = "0x18357FC00")]
		public static void SpawnFromString(string filterString)
		{
		}

		// Token: 0x06003AE1 RID: 15073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE1")]
		[Address(RVA = "0x357FFB0", Offset = "0x357E5B0", VA = "0x18357FFB0")]
		public static void SpawnRandom()
		{
		}

		// Token: 0x06003AE2 RID: 15074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE2")]
		[Address(RVA = "0x3580050", Offset = "0x357E650", VA = "0x183580050")]
		public static void SpawnFallingTree(Vector3 position, Quaternion rotation, Vector3 finalTippingForce, WorldLocatorId id)
		{
		}

		// Token: 0x06003AE3 RID: 15075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE3")]
		[Address(RVA = "0x35803A0", Offset = "0x357E9A0", VA = "0x1835803A0")]
		public FallingTreeSpawner()
		{
		}

		// Token: 0x0400321E RID: 12830
		[Token(Token = "0x400321E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> _fallingTreePrefabs;

		// Token: 0x0400321F RID: 12831
		[Token(Token = "0x400321F")]
		[FieldOffset(Offset = "0x0")]
		private static float _forceAmount;
	}
}
