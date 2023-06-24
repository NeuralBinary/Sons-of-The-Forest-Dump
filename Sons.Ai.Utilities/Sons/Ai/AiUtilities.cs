using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Sons.Ai
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public static class AiUtilities
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002140 File Offset: 0x00000340
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2A8D710", Offset = "0x2A8BD10", VA = "0x182A8D710")]
		public static NNInfo GetNearestNode(Vector3 pos, int graphMask = -1, bool avoidBases = false)
		{
			return default(NNInfo);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002158 File Offset: 0x00000358
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2A8D8D0", Offset = "0x2A8BED0", VA = "0x182A8D8D0")]
		public static Vector3 GetClosestNavMeshPoint(Vector3 position, int graphMask, out bool success)
		{
			return default(Vector3);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002170 File Offset: 0x00000370
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2A8D9B0", Offset = "0x2A8BFB0", VA = "0x182A8D9B0")]
		public static bool IsNearNavMesh(Vector3 position, float maxDist, int graphMask, float maxDiffY = 3.4028235E+38f)
		{
			return default(bool);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002188 File Offset: 0x00000388
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2A8DB60", Offset = "0x2A8C160", VA = "0x182A8DB60")]
		private static NNInfo GetAStarNode(bool useTerrainHeight, Vector3 testPoint)
		{
			return default(NNInfo);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000021A0 File Offset: 0x000003A0
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2A8DC30", Offset = "0x2A8C230", VA = "0x182A8DC30")]
		public static uint FindLargestArea(RecastGraph rg, bool logging = false)
		{
			return 0U;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2A8E160", Offset = "0x2A8C760", VA = "0x182A8E160")]
		public static void MarkUnWalkableNodes(bool logging = false)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2A8E290", Offset = "0x2A8C890", VA = "0x182A8E290")]
		public static void TagIsolatedNodes(uint tag, bool logging = false)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2A8E3D0", Offset = "0x2A8C9D0", VA = "0x182A8E3D0")]
		public static void MarkAllAsWalkable()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000021B8 File Offset: 0x000003B8
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2A8E580", Offset = "0x2A8CB80", VA = "0x182A8E580")]
		public static Vector3 FindRandomWaypoint(Vector3 position, Quaternion rotation, float minAngle, float maxAngle, float minDistance, float maxDistance)
		{
			return default(Vector3);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000021D0 File Offset: 0x000003D0
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2A8E7C0", Offset = "0x2A8CDC0", VA = "0x182A8E7C0")]
		public static Vector3 ValidateSpawnPosition(Vector3 position, bool keepAboveTerrain, int graphMask = -1, bool avoidBases = false)
		{
			return default(Vector3);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000021E8 File Offset: 0x000003E8
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2A8E920", Offset = "0x2A8CF20", VA = "0x182A8E920")]
		public static bool TryGetCollisionTags(Transform tr, out VailCollisionTags collisionTags)
		{
			return default(bool);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002200 File Offset: 0x00000400
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2A8EA90", Offset = "0x2A8D090", VA = "0x182A8EA90")]
		public static Vector3 SnapToGround(Vector3 position, int standableLayerMask, bool startTerrainHeight, float verticalOffset = 1.8f)
		{
			return default(Vector3);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002218 File Offset: 0x00000418
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2A8EE10", Offset = "0x2A8D410", VA = "0x182A8EE10")]
		public static bool TestLocalAvoidancePoint(Vector3 curPosition, Vector3 newPoint, out Vector3 navMeshPoint, GraphMask graphMask, LayerMask layerMask)
		{
			return default(bool);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002230 File Offset: 0x00000430
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2A8F1A0", Offset = "0x2A8D7A0", VA = "0x182A8F1A0")]
		public static bool IsAboveNavMesh(Vector3 position, GraphMask graphMask, out Vector3 navMeshPoint, float minDist = 0.05f)
		{
			return default(bool);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002248 File Offset: 0x00000448
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2A8F320", Offset = "0x2A8D920", VA = "0x182A8F320")]
		public static bool RayCastNavMesh(Vector3 start, Vector3 end, GraphMask graphMask)
		{
			return default(bool);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002260 File Offset: 0x00000460
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2A8F570", Offset = "0x2A8DB70", VA = "0x182A8F570")]
		public static bool RandomPointOnNavMeshRing(Vector3 centerPoint, Vector2 distanceRange, out Vector3 returnPoint)
		{
			return default(bool);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002278 File Offset: 0x00000478
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2A8F8F0", Offset = "0x2A8DEF0", VA = "0x182A8F8F0")]
		public static bool IsPositionInView(Vector3 pos, Vector3 viewPos, Vector3 viewDir, float alwaysTrueDist, float maxViewDist)
		{
			return default(bool);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002290 File Offset: 0x00000490
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2A8FA10", Offset = "0x2A8E010", VA = "0x182A8FA10")]
		public static Vector3 DirectionXZ(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000022A8 File Offset: 0x000004A8
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2A8FAE0", Offset = "0x2A8E0E0", VA = "0x182A8FAE0")]
		public static Vector3 DirectionXZ(Vector3 dir)
		{
			return default(Vector3);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000022C0 File Offset: 0x000004C0
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2A8FB20", Offset = "0x2A8E120", VA = "0x182A8FB20")]
		public static float GetTargetDirection(Vector3 dir, Vector3 goalDir)
		{
			return 0f;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000022D8 File Offset: 0x000004D8
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2A8FBD0", Offset = "0x2A8E1D0", VA = "0x182A8FBD0")]
		public static Vector3 FindCoverPositionFromEnemy(Vector3 coverPos, Vector3 enemyPos, Vector2 minMaxDistance)
		{
			return default(Vector3);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000022F0 File Offset: 0x000004F0
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2A900E0", Offset = "0x2A8E6E0", VA = "0x182A900E0")]
		public static Vector3 FindFlankPointToTarget(Vector3 sourcePosition, Vector3 targetPosition, Vector2 minMaxDegrees, Vector2 minMaxDistance, bool useTerrainHeight)
		{
			return default(Vector3);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2A90470", Offset = "0x2A8EA70", VA = "0x182A90470")]
		private static void DebugDrawFlank(Vector3 sourcePosition, Vector3 rotated, float duration, int steps = 2)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002308 File Offset: 0x00000508
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x28F43A0", Offset = "0x28F29A0", VA = "0x1828F43A0")]
		public static float AngleToPlusMinus180(float angle)
		{
			return 0f;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002320 File Offset: 0x00000520
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2A907C0", Offset = "0x2A8EDC0", VA = "0x182A907C0")]
		public static float RemapRange01(float value, float start, float end)
		{
			return 0f;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002338 File Offset: 0x00000538
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2A908A0", Offset = "0x2A8EEA0", VA = "0x182A908A0")]
		public static Vector3 DirectionVector(float yaw, float pitch)
		{
			return default(Vector3);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002350 File Offset: 0x00000550
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2A90BA0", Offset = "0x2A8F1A0", VA = "0x182A90BA0")]
		public static bool IsPointInCone(Vector3 checkPos, Vector3 coneOrigin, Vector3 coneForwards, float coneAngle, float coneLength)
		{
			return default(bool);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002368 File Offset: 0x00000568
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2A90D30", Offset = "0x2A8F330", VA = "0x182A90D30")]
		public static Vector2 RandomPointInCone(float minAngle, float maxAngle, float minRadius, float maxRadius)
		{
			return default(Vector2);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002380 File Offset: 0x00000580
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2A90E20", Offset = "0x2A8F420", VA = "0x182A90E20")]
		public static float DistancePointToLine(Vector3 point, Vector3 l1, Vector3 l2)
		{
			return 0f;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002398 File Offset: 0x00000598
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2A91040", Offset = "0x2A8F640", VA = "0x182A91040")]
		private static Vector2 RandomPointOnCone(float minAngle, float maxAngle, float radius)
		{
			return default(Vector2);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000023B0 File Offset: 0x000005B0
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2A910C0", Offset = "0x2A8F6C0", VA = "0x182A910C0")]
		public static float PathDistance(List<Vector3> pathPoints)
		{
			return 0f;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000023C8 File Offset: 0x000005C8
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2A91280", Offset = "0x2A8F880", VA = "0x182A91280")]
		public static Vector3 GetPathEndWithStopDistance(List<Vector3> pathPoints, Vector3 target, float stopDistance)
		{
			return default(Vector3);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000023E0 File Offset: 0x000005E0
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2A91580", Offset = "0x2A8FB80", VA = "0x182A91580")]
		public static float GetJumpVelYForHeight(float height, float gravity)
		{
			return 0f;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000023F8 File Offset: 0x000005F8
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2A915B0", Offset = "0x2A8FBB0", VA = "0x182A915B0")]
		public static float GetJumpHeight(float velY, float gravity)
		{
			return 0f;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002410 File Offset: 0x00000610
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2A915D0", Offset = "0x2A8FBD0", VA = "0x182A915D0")]
		public static float GetJumpVelYForApexTime(float time, float gravity)
		{
			return 0f;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002428 File Offset: 0x00000628
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2A915E0", Offset = "0x2A8FBE0", VA = "0x182A915E0")]
		public static float GetGravityForApexTime(float time, float velY)
		{
			return 0f;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002440 File Offset: 0x00000640
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2A915F0", Offset = "0x2A8FBF0", VA = "0x182A915F0")]
		public static Vector3 GetJumpVelocity(Vector3 posDelta, float time, float gravity)
		{
			return default(Vector3);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002458 File Offset: 0x00000658
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2A91690", Offset = "0x2A8FC90", VA = "0x182A91690")]
		public static Vector3 GetPositionOnArc(Vector3 start, Vector3 vel, float t, float gravity)
		{
			return default(Vector3);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000035")]
		public static void IncDictionary<T>(Dictionary<T, int> dict, T key, int countDelta)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000246E File Offset: 0x0000066E
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2A91740", Offset = "0x2A8FD40", VA = "0x182A91740")]
		public static ValueDropdownList<string> GetNavGraphLabels()
		{
			return null;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2A91A70", Offset = "0x2A90070", VA = "0x182A91A70")]
		public static bool AreNavGraphsLoaded()
		{
			return default(bool);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2A91B50", Offset = "0x2A90150", VA = "0x182A91B50")]
		public static void LoadNavGraphCache()
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2A91BC0", Offset = "0x2A901C0", VA = "0x182A91BC0")]
		public static void DestroyUnWalkableNodes()
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2A91F70", Offset = "0x2A90570", VA = "0x182A91F70")]
		public static void ToggleShowNavGraphs(int graphMask = -1)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public static void EditorSnapToTerrain(Transform tr, float yOffset = 0.1f)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public static void EditorPositionToCameraTrace(Transform tr)
		{
		}

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly NNConstraint AboveNavConstraint;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x8")]
		private static readonly NNConstraint NearestConstraint;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		public const int TerrainNavGraphMask = 1;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		public const float SnapHeightAboveTerrain = 12f;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x10")]
		private static ValueDropdownList<string> _graphLabels;
	}
}
