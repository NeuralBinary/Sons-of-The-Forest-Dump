using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Environment
{
	// Token: 0x020000BE RID: 190
	[Token(Token = "0x20000BE")]
	public static class TerrainUtilities
	{
		// Token: 0x06000477 RID: 1143 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000477")]
		[Address(RVA = "0xAA91F0", Offset = "0xAA77F0", VA = "0x180AA91F0")]
		private static Terrain[] ActiveTerrains()
		{
			return null;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00004608 File Offset: 0x00002808
		[Token(Token = "0x6000478")]
		[Address(RVA = "0xAA9390", Offset = "0xAA7990", VA = "0x180AA9390")]
		public static bool TryGetClosestActive(Vector3 transformPosition, out Terrain result)
		{
			return default(bool);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000479")]
		[Address(RVA = "0xAA95E0", Offset = "0xAA7BE0", VA = "0x180AA95E0")]
		public static Terrain GetClosestActive(Vector3 transformPosition)
		{
			return null;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00004620 File Offset: 0x00002820
		[Token(Token = "0x600047A")]
		[Address(RVA = "0xAA9620", Offset = "0xAA7C20", VA = "0x180AA9620")]
		public static bool IsInsideBounds(Vector3 transformPosition)
		{
			return default(bool);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00004638 File Offset: 0x00002838
		[Token(Token = "0x600047B")]
		[Address(RVA = "0xAA9870", Offset = "0xAA7E70", VA = "0x180AA9870")]
		public static bool IsInsideBounds(Terrain terrain, Vector3 transformPosition)
		{
			return default(bool);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00004650 File Offset: 0x00002850
		[Token(Token = "0x600047C")]
		[Address(RVA = "0xAA9A80", Offset = "0xAA8080", VA = "0x180AA9A80")]
		public static bool IsOnSand(Vector3 pos)
		{
			return default(bool);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00004668 File Offset: 0x00002868
		[Token(Token = "0x600047D")]
		[Address(RVA = "0xAA9AC0", Offset = "0xAA80C0", VA = "0x180AA9AC0")]
		public static int GetProminentTextureIndex(Vector3 transformPosition)
		{
			return 0;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00004680 File Offset: 0x00002880
		[Token(Token = "0x600047E")]
		[Address(RVA = "0xAA9E80", Offset = "0xAA8480", VA = "0x180AA9E80")]
		public static int GetProminentTextureIndex(Terrain terrain, Vector3 transformPosition)
		{
			return 0;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00004698 File Offset: 0x00002898
		[Token(Token = "0x600047F")]
		[Address(RVA = "0xAAA210", Offset = "0xAA8810", VA = "0x180AAA210")]
		public static Vector3 GetTerrainNormal(Vector3 transformPosition)
		{
			return default(Vector3);
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x000046B0 File Offset: 0x000028B0
		[Token(Token = "0x6000480")]
		[Address(RVA = "0xAAA590", Offset = "0xAA8B90", VA = "0x180AAA590")]
		public static Vector3 GetTerrainNormal(Terrain targetTerrain, Vector3 transformPosition)
		{
			return default(Vector3);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x000046C8 File Offset: 0x000028C8
		[Token(Token = "0x6000481")]
		[Address(RVA = "0xAAA6A0", Offset = "0xAA8CA0", VA = "0x180AAA6A0")]
		public static Vector2 GetTerrainCoordinates(Vector3 transformPosition)
		{
			return default(Vector2);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x000046E0 File Offset: 0x000028E0
		[Token(Token = "0x6000482")]
		[Address(RVA = "0xAAA900", Offset = "0xAA8F00", VA = "0x180AAA900")]
		public static Vector2 GetTerrainCoordinates(Terrain targetTerrain, Vector3 transformPosition)
		{
			return default(Vector2);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x000046F8 File Offset: 0x000028F8
		[Token(Token = "0x6000483")]
		[Address(RVA = "0xAAAB20", Offset = "0xAA9120", VA = "0x180AAAB20")]
		public static Vector3 GetTerrainPosition(Vector3 transformPosition)
		{
			return default(Vector3);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00004710 File Offset: 0x00002910
		[Token(Token = "0x6000484")]
		[Address(RVA = "0xAAADA0", Offset = "0xAA93A0", VA = "0x180AAADA0")]
		public static Vector3 GetTerrainPosition(Terrain targetTerrain, Vector3 transformPosition)
		{
			return default(Vector3);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00004728 File Offset: 0x00002928
		[Token(Token = "0x6000485")]
		[Address(RVA = "0xAAAFA0", Offset = "0xAA95A0", VA = "0x180AAAFA0")]
		public static float GetTerrainHeight(Vector3 transformPosition)
		{
			return 0f;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00004740 File Offset: 0x00002940
		[Token(Token = "0x6000486")]
		[Address(RVA = "0xAAAFE0", Offset = "0xAA95E0", VA = "0x180AAAFE0")]
		public static float GetTerrainHeight(Terrain targetTerrain, Vector3 transformPosition)
		{
			return 0f;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00004758 File Offset: 0x00002958
		[Token(Token = "0x6000487")]
		[Address(RVA = "0xAAB020", Offset = "0xAA9620", VA = "0x180AAB020")]
		public static bool TryGetTerrainPositionAndNormal(Vector3 transformPosition, out Vector3 position, out Vector3 normal)
		{
			return default(bool);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000488")]
		[Address(RVA = "0xAAB5A0", Offset = "0xAA9BA0", VA = "0x180AAB5A0")]
		public static void GetTerrainPositionAndNormal(Terrain targetTerrain, Vector3 transformPosition, out Vector3 position, out Vector3 normal)
		{
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00004770 File Offset: 0x00002970
		[Token(Token = "0x6000489")]
		[Address(RVA = "0xAAB700", Offset = "0xAA9D00", VA = "0x180AAB700")]
		public static bool IsPositionAboveTerrain(Vector3 position, float margin = 0f)
		{
			return default(bool);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600048A")]
		[Address(RVA = "0xAAB750", Offset = "0xAA9D50", VA = "0x180AAB750")]
		public static List<Collider> GetAllColliders()
		{
			return null;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00004788 File Offset: 0x00002988
		[Token(Token = "0x600048B")]
		[Address(RVA = "0xAAB8E0", Offset = "0xAA9EE0", VA = "0x180AAB8E0")]
		public static bool PassTerrainMask(Terrain terrain, Vector3 hitPoint, int[] terrainTextureMask)
		{
			return default(bool);
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x000047A0 File Offset: 0x000029A0
		[Token(Token = "0x600048C")]
		[Address(RVA = "0xAAB920", Offset = "0xAA9F20", VA = "0x180AAB920")]
		public static bool PassTerrainMask(Terrain terrain, Vector3 hitPoint, int[] terrainTextureMask, out int prominentLayer)
		{
			return default(bool);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048D")]
		[Address(RVA = "0xAABEA0", Offset = "0xAAA4A0", VA = "0x180AABEA0")]
		public static void OnSceneLoaded()
		{
		}

		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x0")]
		private static Terrain[] _activeTerrains;

		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x8")]
		private static int _lastActiveTerrainsFrame;
	}
}
