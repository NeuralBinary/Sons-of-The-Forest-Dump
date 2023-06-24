using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utilities
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	public static class MathEx
	{
		// Token: 0x06000143 RID: 323 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x6000143")]
		[Address(RVA = "0xA76780", Offset = "0xA74D80", VA = "0x180A76780")]
		public static Vector3 AddVectorLength(Vector3 vector, float size)
		{
			return default(Vector3);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x6000144")]
		[Address(RVA = "0xA76810", Offset = "0xA74E10", VA = "0x180A76810")]
		public static Vector3 SetVectorLength(Vector3 vector, float size)
		{
			return default(Vector3);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x6000145")]
		[Address(RVA = "0xA76920", Offset = "0xA74F20", VA = "0x180A76920")]
		public static Quaternion SubtractRotation(Quaternion B, Quaternion A)
		{
			return default(Quaternion);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x6000146")]
		[Address(RVA = "0xA76B10", Offset = "0xA75110", VA = "0x180A76B10")]
		public static bool PlanePlaneIntersection(out Vector3 linePoint, out Vector3 lineVec, Vector3 plane1Normal, Vector3 plane1Position, Vector3 plane2Normal, Vector3 plane2Position)
		{
			return default(bool);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x6000147")]
		[Address(RVA = "0xA76DB0", Offset = "0xA753B0", VA = "0x180A76DB0")]
		public static bool LinePlaneIntersection(out Vector3 intersection, Vector3 linePoint, Vector3 lineVec, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(bool);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x6000148")]
		[Address(RVA = "0xA76F70", Offset = "0xA75570", VA = "0x180A76F70")]
		public static bool LineLineIntersection(out Vector3 intersection, Vector3 linePoint1, Vector3 lineVec1, Vector3 linePoint2, Vector3 lineVec2)
		{
			return default(bool);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x6000149")]
		[Address(RVA = "0xA77220", Offset = "0xA75820", VA = "0x180A77220")]
		public static bool LineLineIntersection(out Vector2 intersection, Vector2 pointA, Vector2 directionA, Vector2 pointB, Vector2 directionB)
		{
			return default(bool);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x600014A")]
		[Address(RVA = "0xA77400", Offset = "0xA75A00", VA = "0x180A77400")]
		public static bool ClosestPointsOnTwoLines(out Vector3 closestPointLine1, out Vector3 closestPointLine2, Vector3 linePoint1, Vector3 lineVec1, Vector3 linePoint2, Vector3 lineVec2)
		{
			return default(bool);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x600014B")]
		[Address(RVA = "0xA77720", Offset = "0xA75D20", VA = "0x180A77720")]
		public static Vector3 ProjectPointOnLine(Vector3 linePoint, Vector3 lineVec, Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x600014C")]
		[Address(RVA = "0xA777F0", Offset = "0xA75DF0", VA = "0x180A777F0")]
		public static Vector3 ProjectPointOnLineSegment(Vector3 linePoint1, Vector3 linePoint2, Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x600014D")]
		[Address(RVA = "0xA77A80", Offset = "0xA76080", VA = "0x180A77A80")]
		public static bool AreLineSegmentsCrossing(Vector3 pointA1, Vector3 pointA2, Vector3 pointB1, Vector3 pointB2)
		{
			return default(bool);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x600014E")]
		[Address(RVA = "0xA77DA0", Offset = "0xA763A0", VA = "0x180A77DA0")]
		public static bool IsLineSegmentCrossingMultipointList(Vector3 pointA1, Vector3 pointA2, List<Vector3> multipointList)
		{
			return default(bool);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x600014F")]
		[Address(RVA = "0xA77F00", Offset = "0xA76500", VA = "0x180A77F00")]
		public static Vector3 ProjectPointOnPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x6000150")]
		[Address(RVA = "0xA78020", Offset = "0xA76620", VA = "0x180A78020")]
		public static Vector3 ProjectVectorOnPlane(Vector3 planeNormal, Vector3 vector)
		{
			return default(Vector3);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x6000151")]
		[Address(RVA = "0xA780D0", Offset = "0xA766D0", VA = "0x180A780D0")]
		public static float SignedDistancePlanePoint(Vector3 planeNormal, Vector3 planePoint, Vector3 point)
		{
			return 0f;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x6000152")]
		[Address(RVA = "0xA78140", Offset = "0xA76740", VA = "0x180A78140")]
		public static float SignedDotProduct(Vector3 vectorA, Vector3 vectorB, Vector3 normal)
		{
			return 0f;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x6000153")]
		[Address(RVA = "0xA78200", Offset = "0xA76800", VA = "0x180A78200")]
		public static float SignedVectorAngle(Vector3 referenceVector, Vector3 otherVector, Vector3 normal)
		{
			return 0f;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x6000154")]
		[Address(RVA = "0xA78320", Offset = "0xA76920", VA = "0x180A78320")]
		public static float AngleVectorPlane(Vector3 vector, Vector3 normal)
		{
			return 0f;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x6000155")]
		[Address(RVA = "0xA78380", Offset = "0xA76980", VA = "0x180A78380")]
		public static float DotProductAngle(Vector3 vec1, Vector3 vec2)
		{
			return 0f;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000156")]
		[Address(RVA = "0xA783F0", Offset = "0xA769F0", VA = "0x180A783F0")]
		public static void PlaneFrom3Points(out Vector3 planeNormal, out Vector3 planePoint, Vector3 pointA, Vector3 pointB, Vector3 pointC)
		{
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x6000157")]
		[Address(RVA = "0xA78810", Offset = "0xA76E10", VA = "0x180A78810")]
		public static Vector3 GetForwardVector(Quaternion q)
		{
			return default(Vector3);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x6000158")]
		[Address(RVA = "0xA788A0", Offset = "0xA76EA0", VA = "0x180A788A0")]
		public static Vector3 GetUpVector(Quaternion q)
		{
			return default(Vector3);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x6000159")]
		[Address(RVA = "0xA78930", Offset = "0xA76F30", VA = "0x180A78930")]
		public static Vector3 GetRightVector(Quaternion q)
		{
			return default(Vector3);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x600015A")]
		[Address(RVA = "0xA789C0", Offset = "0xA76FC0", VA = "0x180A789C0")]
		public static Quaternion QuaternionFromMatrix(Matrix4x4 m)
		{
			return default(Quaternion);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x600015B")]
		[Address(RVA = "0xA78A80", Offset = "0xA77080", VA = "0x180A78A80")]
		public static Vector3 PositionFromMatrix(Matrix4x4 m)
		{
			return default(Vector3);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015C")]
		[Address(RVA = "0xA78AB0", Offset = "0xA770B0", VA = "0x180A78AB0")]
		public static void LookRotationExtended(ref GameObject gameObjectInOut, Vector3 alignWithVector, Vector3 alignWithNormal, Vector3 customForward, Vector3 customUp)
		{
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015D")]
		[Address(RVA = "0xA78E30", Offset = "0xA77430", VA = "0x180A78E30")]
		public static void PreciseAlign(ref GameObject gameObjectInOut, Vector3 alignWithVector, Vector3 alignWithNormal, Vector3 alignWithPosition, Vector3 triangleForward, Vector3 triangleNormal, Vector3 trianglePosition)
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015E")]
		[Address(RVA = "0xA79050", Offset = "0xA77650", VA = "0x180A79050")]
		public static void VectorsToTransform(ref GameObject gameObjectInOut, Vector3 positionVector, Vector3 directionVector, Vector3 normalVector)
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x600015F")]
		[Address(RVA = "0xA79280", Offset = "0xA77880", VA = "0x180A79280")]
		public static int PointOnWhichSideOfLineSegment(Vector3 linePoint1, Vector3 linePoint2, Vector3 point)
		{
			return 0;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x6000160")]
		[Address(RVA = "0xA79480", Offset = "0xA77A80", VA = "0x180A79480")]
		public static float GetDistPointToLine(Vector3 origin, Vector3 direction, Vector3 point)
		{
			return 0f;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x6000161")]
		[Address(RVA = "0xA79560", Offset = "0xA77B60", VA = "0x180A79560")]
		public static float GetDistPointToLine(Vector2 origin, Vector2 direction, Vector2 point)
		{
			return 0f;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x6000162")]
		[Address(RVA = "0xA79640", Offset = "0xA77C40", VA = "0x180A79640")]
		public static float GetDistPointToLineSegment(Vector2 lineStart, Vector2 lineEnd, Vector2 point)
		{
			return 0f;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x6000163")]
		[Address(RVA = "0xA79840", Offset = "0xA77E40", VA = "0x180A79840")]
		public static float GetDistPointToPolyLine(IList<Vector2> polyLine, int start, int end, Vector2 point)
		{
			return 0f;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x6000164")]
		[Address(RVA = "0xA79A90", Offset = "0xA78090", VA = "0x180A79A90")]
		public static float GetDistPointToPolyLine(IList<Vector2> polyLine, Vector2 point)
		{
			return 0f;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x6000165")]
		[Address(RVA = "0xA79B10", Offset = "0xA78110", VA = "0x180A79B10")]
		public static bool ProjectPointOnLineSegment(Vector3 linePoint1, Vector3 linePoint2, Vector3 point, out Vector3 projectedPoint)
		{
			return default(bool);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x6000166")]
		[Address(RVA = "0xA79D30", Offset = "0xA78330", VA = "0x180A79D30")]
		public static Vector3 RotateX(this Vector3 v, float angle)
		{
			return default(Vector3);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x6000167")]
		[Address(RVA = "0xA79DD0", Offset = "0xA783D0", VA = "0x180A79DD0")]
		public static Vector2 RotateY(this Vector2 v, float angle)
		{
			return default(Vector2);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x6000168")]
		[Address(RVA = "0xA79E50", Offset = "0xA78450", VA = "0x180A79E50")]
		public static Vector3 RotateY(this Vector3 v, float angle)
		{
			return default(Vector3);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x6000169")]
		[Address(RVA = "0xA79EF0", Offset = "0xA784F0", VA = "0x180A79EF0")]
		public static Vector3 RotateZ(this Vector3 v, float angle)
		{
			return default(Vector3);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x600016A")]
		[Address(RVA = "0xA79F90", Offset = "0xA78590", VA = "0x180A79F90")]
		public static bool IsPointInTriangleXY(Vector2 p, Vector2 p0, Vector2 p1, Vector2 p2)
		{
			return default(bool);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x600016B")]
		[Address(RVA = "0xA7A130", Offset = "0xA78730", VA = "0x180A7A130")]
		public static bool IsPointInTriangleXZ(Vector3 p, Vector3 p0, Vector3 p1, Vector3 p2)
		{
			return default(bool);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x600016C")]
		[Address(RVA = "0xA7A2B0", Offset = "0xA788B0", VA = "0x180A7A2B0")]
		public static Vector3 TryAngleSnap(Vector3 point, Vector3 center, Vector3 edgePoint, float snapAngle, float snapRange, bool flattenYAxis = true)
		{
			return default(Vector3);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x600016D")]
		[Address(RVA = "0xA7A590", Offset = "0xA78B90", VA = "0x180A7A590")]
		public static bool IsPointInPolygon(Vector3 point, IList<Vector2> polygon)
		{
			return default(bool);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x600016E")]
		[Address(RVA = "0xA7A8A0", Offset = "0xA78EA0", VA = "0x180A7A8A0")]
		private static bool LineIntersectHorizontalLine(Vector2 start, Vector2 end, float xStart, float xEnd, float y)
		{
			return default(bool);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x600016F")]
		[Address(RVA = "0xA7A950", Offset = "0xA78F50", VA = "0x180A7A950")]
		public static bool IsPointInPolygon(Vector2 point, List<Vector2> polygon, Rect bounds)
		{
			return default(bool);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x6000170")]
		[Address(RVA = "0xA7AB30", Offset = "0xA79130", VA = "0x180A7AB30")]
		public static bool IsPointInPolygon(Vector2 point, List<Vector2> polygon)
		{
			return default(bool);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x6000171")]
		[Address(RVA = "0xA7ACE0", Offset = "0xA792E0", VA = "0x180A7ACE0")]
		public static bool IsPointInPolygon(Vector3 point, IList<Vector3> polygon)
		{
			return default(bool);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x6000172")]
		[Address(RVA = "0xA7B070", Offset = "0xA79670", VA = "0x180A7B070")]
		public static Vector3 ClosestPointOnPolygon(Vector3 point, List<Vector3> polygon)
		{
			return default(Vector3);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x6000173")]
		[Address(RVA = "0xA7B330", Offset = "0xA79930", VA = "0x180A7B330")]
		public static float ClosestDistanceToPolygon(Vector3 point, List<Vector3> polygon)
		{
			return 0f;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000174")]
		[Address(RVA = "0xA7B570", Offset = "0xA79B70", VA = "0x180A7B570")]
		public static List<Vector3> CalculateMeshPerimeter(Mesh mesh)
		{
			return null;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000175")]
		[Address(RVA = "0xA7BF10", Offset = "0xA7A510", VA = "0x180A7BF10")]
		public static List<List<Vector2>> CalculateContours(float threshold, int cellGridSize, List<Vector2> perimeter, Func<Vector2, float> sampleFunction)
		{
			return null;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x6000176")]
		[Address(RVA = "0xA7BFB0", Offset = "0xA7A5B0", VA = "0x180A7BFB0")]
		public static bool IsPolygonClockwise(IList<Vector2> polygon)
		{
			return default(bool);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x6000177")]
		[Address(RVA = "0xA7BFD0", Offset = "0xA7A5D0", VA = "0x180A7BFD0")]
		private static float SignedArea(IList<Vector2> polygon)
		{
			return 0f;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x6000178")]
		[Address(RVA = "0xA7C300", Offset = "0xA7A900", VA = "0x180A7C300")]
		public static bool IsPointLeftOfLine(Vector2 lineStart, Vector2 lineEnd, Vector2 point)
		{
			return default(bool);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000179")]
		[Address(RVA = "0xA7C360", Offset = "0xA7A960", VA = "0x180A7C360")]
		private static List<Vector2> EraseLeftTurns(IList<Vector2> polygon, float maximumError, out List<int> originalIndices)
		{
			return null;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600017A")]
		[Address(RVA = "0xA7CA50", Offset = "0xA7B050", VA = "0x180A7CA50")]
		private static List<Vector2> MergeRightTurns(List<Vector2> polygon, float maximumError, IList<Vector2> originalPolygon, List<int> originalIndices)
		{
			return null;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600017B")]
		[Address(RVA = "0xA7D140", Offset = "0xA7B740", VA = "0x180A7D140")]
		public static List<Vector2> SimplifyPolygon(IList<Vector2> polygon, float maximumError)
		{
			return null;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017C")]
		[Address(RVA = "0xA7D190", Offset = "0xA7B790", VA = "0x180A7D190")]
		public static void FindCircleFromPoints(Vector2 p1, Vector2 p2, Vector2 p3, out Vector2 center, out float radius)
		{
		}

		// Token: 0x0200003C RID: 60
		[Token(Token = "0x200003C")]
		private struct Edge
		{
			// Token: 0x0600017D RID: 381 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600017D")]
			[Address(RVA = "0xA7D4A0", Offset = "0xA7BAA0", VA = "0x180A7D4A0")]
			public Edge(int v1, int v2)
			{
			}

			// Token: 0x040000D8 RID: 216
			[Token(Token = "0x40000D8")]
			[FieldOffset(Offset = "0x0")]
			public int v1;

			// Token: 0x040000D9 RID: 217
			[Token(Token = "0x40000D9")]
			[FieldOffset(Offset = "0x4")]
			public int v2;
		}

		// Token: 0x0200003D RID: 61
		[Token(Token = "0x200003D")]
		private class EdgeTable
		{
			// Token: 0x0600017E RID: 382 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600017E")]
			[Address(RVA = "0xA7D4C0", Offset = "0xA7BAC0", VA = "0x180A7D4C0")]
			public EdgeTable()
			{
			}

			// Token: 0x0600017F RID: 383 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600017F")]
			[Address(RVA = "0xA7D5F0", Offset = "0xA7BBF0", VA = "0x180A7D5F0")]
			public void AddFaceToEdge(int v1, int v2)
			{
			}

			// Token: 0x040000DA RID: 218
			[Token(Token = "0x40000DA")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<MathEx.Edge, int> faceCounts;
		}

		// Token: 0x0200003E RID: 62
		[Token(Token = "0x200003E")]
		private struct IntPair
		{
			// Token: 0x040000DB RID: 219
			[Token(Token = "0x40000DB")]
			[FieldOffset(Offset = "0x0")]
			public int a;

			// Token: 0x040000DC RID: 220
			[Token(Token = "0x40000DC")]
			[FieldOffset(Offset = "0x4")]
			public int b;
		}

		// Token: 0x0200003F RID: 63
		[Token(Token = "0x200003F")]
		private class VertexTable
		{
			// Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000180")]
			[Address(RVA = "0xA7D790", Offset = "0xA7BD90", VA = "0x180A7D790")]
			public VertexTable()
			{
			}

			// Token: 0x06000181 RID: 385 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000181")]
			[Address(RVA = "0xA7D8C0", Offset = "0xA7BEC0", VA = "0x180A7D8C0")]
			public void AddEdge(MathEx.Edge edge)
			{
			}

			// Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000182")]
			[Address(RVA = "0xA7D900", Offset = "0xA7BF00", VA = "0x180A7D900")]
			private void AddVertexNeighbour(int v1, int v2)
			{
			}

			// Token: 0x040000DD RID: 221
			[Token(Token = "0x40000DD")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<int, MathEx.IntPair> neighbours;
		}

		// Token: 0x02000040 RID: 64
		[Token(Token = "0x2000040")]
		private class ContourState
		{
			// Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000183")]
			[Address(RVA = "0xA7DAE0", Offset = "0xA7C0E0", VA = "0x180A7DAE0")]
			public ContourState(int cellGridSize, List<Vector2> perimeter, float threshold, Func<Vector2, float> sampleFunction)
			{
			}

			// Token: 0x06000184 RID: 388 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6000184")]
			[Address(RVA = "0xA7E130", Offset = "0xA7C730", VA = "0x180A7E130")]
			public List<List<Vector2>> CalculateContours()
			{
				return null;
			}

			// Token: 0x06000185 RID: 389 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6000185")]
			[Address(RVA = "0xA7E710", Offset = "0xA7CD10", VA = "0x180A7E710")]
			private List<Vector2> ExtractNextContour()
			{
				return null;
			}

			// Token: 0x06000186 RID: 390 RVA: 0x00002A30 File Offset: 0x00000C30
			[Token(Token = "0x6000186")]
			[Address(RVA = "0xA7E9E0", Offset = "0xA7CFE0", VA = "0x180A7E9E0")]
			private bool FindStartCell(out int startColumn, out int startRow, out int lastColumn, out int lastRow)
			{
				return default(bool);
			}

			// Token: 0x06000187 RID: 391 RVA: 0x00002A48 File Offset: 0x00000C48
			[Token(Token = "0x6000187")]
			[Address(RVA = "0xA7ECD0", Offset = "0xA7D2D0", VA = "0x180A7ECD0")]
			private bool CalculateNextCell(int lastColumn, int lastRow, int column, int row, out int nextColumn, out int nextRow, out int vertex)
			{
				return default(bool);
			}

			// Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000188")]
			[Address(RVA = "0xA7F1B0", Offset = "0xA7D7B0", VA = "0x180A7F1B0")]
			private void GoLeft(int column, int row, out int nextColumn, out int nextRow, out int vertex)
			{
			}

			// Token: 0x06000189 RID: 393 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000189")]
			[Address(RVA = "0xA7F210", Offset = "0xA7D810", VA = "0x180A7F210")]
			private void GoRight(int column, int row, out int nextColumn, out int nextRow, out int vertex)
			{
			}

			// Token: 0x0600018A RID: 394 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600018A")]
			[Address(RVA = "0xA7F270", Offset = "0xA7D870", VA = "0x180A7F270")]
			private void GoUp(int column, int row, out int nextColumn, out int nextRow, out int vertex)
			{
			}

			// Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600018B")]
			[Address(RVA = "0xA7F2D0", Offset = "0xA7D8D0", VA = "0x180A7F2D0")]
			private void GoDown(int column, int row, out int nextColumn, out int nextRow, out int vertex)
			{
			}

			// Token: 0x0600018C RID: 396 RVA: 0x00002A60 File Offset: 0x00000C60
			[Token(Token = "0x600018C")]
			[Address(RVA = "0xA7F330", Offset = "0xA7D930", VA = "0x180A7F330")]
			private Vector2 CalculateGridPoint(float column, float row)
			{
				return default(Vector2);
			}

			// Token: 0x0600018D RID: 397 RVA: 0x00002A78 File Offset: 0x00000C78
			[Token(Token = "0x600018D")]
			[Address(RVA = "0xA7F370", Offset = "0xA7D970", VA = "0x180A7F370")]
			private int AddVertex(float x, float y)
			{
				return 0;
			}

			// Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600018E")]
			[Address(RVA = "0xA7F400", Offset = "0xA7DA00", VA = "0x180A7F400")]
			private void AddVertexRight(int column, int row)
			{
			}

			// Token: 0x0600018F RID: 399 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600018F")]
			[Address(RVA = "0xA7F620", Offset = "0xA7DC20", VA = "0x180A7F620")]
			private void AddVertexUp(int column, int row)
			{
			}

			// Token: 0x06000190 RID: 400 RVA: 0x00002A90 File Offset: 0x00000C90
			[Token(Token = "0x6000190")]
			[Address(RVA = "0xA7F840", Offset = "0xA7DE40", VA = "0x180A7F840")]
			private int GetVertexLeft(int column, int row)
			{
				return 0;
			}

			// Token: 0x06000191 RID: 401 RVA: 0x00002AA8 File Offset: 0x00000CA8
			[Token(Token = "0x6000191")]
			[Address(RVA = "0xA7F890", Offset = "0xA7DE90", VA = "0x180A7F890")]
			private int GetVertexRight(int column, int row)
			{
				return 0;
			}

			// Token: 0x06000192 RID: 402 RVA: 0x00002AC0 File Offset: 0x00000CC0
			[Token(Token = "0x6000192")]
			[Address(RVA = "0xA7F8E0", Offset = "0xA7DEE0", VA = "0x180A7F8E0")]
			private int GetVertexUp(int column, int row)
			{
				return 0;
			}

			// Token: 0x06000193 RID: 403 RVA: 0x00002AD8 File Offset: 0x00000CD8
			[Token(Token = "0x6000193")]
			[Address(RVA = "0xA7F930", Offset = "0xA7DF30", VA = "0x180A7F930")]
			private int GetVertexDown(int column, int row)
			{
				return 0;
			}

			// Token: 0x040000DE RID: 222
			[Token(Token = "0x40000DE")]
			[FieldOffset(Offset = "0x10")]
			private MathEx.ContourState.PointStatus[,] points;

			// Token: 0x040000DF RID: 223
			[Token(Token = "0x40000DF")]
			[FieldOffset(Offset = "0x18")]
			private MathEx.ContourState.CellType[,] cells;

			// Token: 0x040000E0 RID: 224
			[Token(Token = "0x40000E0")]
			[FieldOffset(Offset = "0x20")]
			private byte[,] visited;

			// Token: 0x040000E1 RID: 225
			[Token(Token = "0x40000E1")]
			[FieldOffset(Offset = "0x28")]
			private int[,] verticesRight;

			// Token: 0x040000E2 RID: 226
			[Token(Token = "0x40000E2")]
			[FieldOffset(Offset = "0x30")]
			private int[,] verticesUp;

			// Token: 0x040000E3 RID: 227
			[Token(Token = "0x40000E3")]
			[FieldOffset(Offset = "0x38")]
			private List<Vector2> vertices;

			// Token: 0x040000E4 RID: 228
			[Token(Token = "0x40000E4")]
			[FieldOffset(Offset = "0x40")]
			private List<Vector2> perimeter;

			// Token: 0x040000E5 RID: 229
			[Token(Token = "0x40000E5")]
			[FieldOffset(Offset = "0x48")]
			private Rect bounds;

			// Token: 0x040000E6 RID: 230
			[Token(Token = "0x40000E6")]
			[FieldOffset(Offset = "0x58")]
			private int pointGridSize;

			// Token: 0x040000E7 RID: 231
			[Token(Token = "0x40000E7")]
			[FieldOffset(Offset = "0x5C")]
			private int cellGridSize;

			// Token: 0x040000E8 RID: 232
			[Token(Token = "0x40000E8")]
			[FieldOffset(Offset = "0x60")]
			private float threshold;

			// Token: 0x040000E9 RID: 233
			[Token(Token = "0x40000E9")]
			[FieldOffset(Offset = "0x68")]
			private Func<Vector2, float> Sample;

			// Token: 0x02000041 RID: 65
			[Token(Token = "0x2000041")]
			private enum PointStatus : byte
			{
				// Token: 0x040000EB RID: 235
				[Token(Token = "0x40000EB")]
				Above,
				// Token: 0x040000EC RID: 236
				[Token(Token = "0x40000EC")]
				Below,
				// Token: 0x040000ED RID: 237
				[Token(Token = "0x40000ED")]
				Outside
			}

			// Token: 0x02000042 RID: 66
			[Token(Token = "0x2000042")]
			[Flags]
			private enum CellType : byte
			{
				// Token: 0x040000EF RID: 239
				[Token(Token = "0x40000EF")]
				None = 0,
				// Token: 0x040000F0 RID: 240
				[Token(Token = "0x40000F0")]
				BottomLeft = 1,
				// Token: 0x040000F1 RID: 241
				[Token(Token = "0x40000F1")]
				BottomRight = 2,
				// Token: 0x040000F2 RID: 242
				[Token(Token = "0x40000F2")]
				TopRight = 4,
				// Token: 0x040000F3 RID: 243
				[Token(Token = "0x40000F3")]
				TopLeft = 8,
				// Token: 0x040000F4 RID: 244
				[Token(Token = "0x40000F4")]
				InverseBottomLeft = 14,
				// Token: 0x040000F5 RID: 245
				[Token(Token = "0x40000F5")]
				InverseBottomRight = 13,
				// Token: 0x040000F6 RID: 246
				[Token(Token = "0x40000F6")]
				InverseTopRight = 11,
				// Token: 0x040000F7 RID: 247
				[Token(Token = "0x40000F7")]
				InverseTopLeft = 7,
				// Token: 0x040000F8 RID: 248
				[Token(Token = "0x40000F8")]
				Left = 9,
				// Token: 0x040000F9 RID: 249
				[Token(Token = "0x40000F9")]
				Right = 6,
				// Token: 0x040000FA RID: 250
				[Token(Token = "0x40000FA")]
				Top = 12,
				// Token: 0x040000FB RID: 251
				[Token(Token = "0x40000FB")]
				Bottom = 3,
				// Token: 0x040000FC RID: 252
				[Token(Token = "0x40000FC")]
				SaddleUpRight = 5,
				// Token: 0x040000FD RID: 253
				[Token(Token = "0x40000FD")]
				SaddleUpLeft = 10,
				// Token: 0x040000FE RID: 254
				[Token(Token = "0x40000FE")]
				All = 15
			}
		}

		// Token: 0x02000043 RID: 67
		[Token(Token = "0x2000043")]
		private class ErasureSpan
		{
			// Token: 0x06000194 RID: 404 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000194")]
			[Address(RVA = "0xA7F980", Offset = "0xA7DF80", VA = "0x180A7F980")]
			public ErasureSpan(int start, IList<Vector2> polygon)
			{
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000195 RID: 405 RVA: 0x00002AF0 File Offset: 0x00000CF0
			// (set) Token: 0x06000196 RID: 406 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700000D")]
			public int start
			{
				[Token(Token = "0x6000195")]
				[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000196")]
				[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000197 RID: 407 RVA: 0x00002B08 File Offset: 0x00000D08
			// (set) Token: 0x06000198 RID: 408 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700000E")]
			public int end
			{
				[Token(Token = "0x6000197")]
				[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000198")]
				[Address(RVA = "0x66F510", Offset = "0x66DB10", VA = "0x18066F510")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000199 RID: 409 RVA: 0x00002B20 File Offset: 0x00000D20
			// (set) Token: 0x0600019A RID: 410 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700000F")]
			public float maximumError
			{
				[Token(Token = "0x6000199")]
				[Address(RVA = "0x9FA1C0", Offset = "0x9F87C0", VA = "0x1809FA1C0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x600019A")]
				[Address(RVA = "0xA308C0", Offset = "0xA2EEC0", VA = "0x180A308C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600019B RID: 411 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600019B")]
			[Address(RVA = "0xA7FA00", Offset = "0xA7E000", VA = "0x180A7FA00")]
			public void SetStart(int start, IList<Vector2> polygon)
			{
			}

			// Token: 0x0600019C RID: 412 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600019C")]
			[Address(RVA = "0xA7FA20", Offset = "0xA7E020", VA = "0x180A7FA20")]
			public void SetEnd(int end, IList<Vector2> polygon)
			{
			}

			// Token: 0x0600019D RID: 413 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600019D")]
			[Address(RVA = "0xA7FA40", Offset = "0xA7E040", VA = "0x180A7FA40")]
			private void CalculateMaximumError(IList<Vector2> polygon)
			{
			}
		}

		// Token: 0x02000044 RID: 68
		[Token(Token = "0x2000044")]
		private class MergeSpan
		{
			// Token: 0x0600019E RID: 414 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x600019E")]
			[Address(RVA = "0xA7FC70", Offset = "0xA7E270", VA = "0x180A7FC70")]
			public static MathEx.MergeSpan Create(int start, int end, List<Vector2> polygon, IList<Vector2> originalPolygon, List<int> originalIndices, float maximumError)
			{
				return null;
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x0600019F RID: 415 RVA: 0x00002B38 File Offset: 0x00000D38
			// (set) Token: 0x060001A0 RID: 416 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000010")]
			public int start
			{
				[Token(Token = "0x600019F")]
				[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60001A0")]
				[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x060001A1 RID: 417 RVA: 0x00002B50 File Offset: 0x00000D50
			// (set) Token: 0x060001A2 RID: 418 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000011")]
			public int mergeStart
			{
				[Token(Token = "0x60001A1")]
				[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60001A2")]
				[Address(RVA = "0x66F510", Offset = "0x66DB10", VA = "0x18066F510")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x060001A3 RID: 419 RVA: 0x00002B68 File Offset: 0x00000D68
			// (set) Token: 0x060001A4 RID: 420 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000012")]
			public int mergeEnd
			{
				[Token(Token = "0x60001A3")]
				[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60001A4")]
				[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x060001A5 RID: 421 RVA: 0x00002B80 File Offset: 0x00000D80
			// (set) Token: 0x060001A6 RID: 422 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000013")]
			public int end
			{
				[Token(Token = "0x60001A5")]
				[Address(RVA = "0x9FA1D0", Offset = "0x9F87D0", VA = "0x1809FA1D0")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60001A6")]
				[Address(RVA = "0xA7FDD0", Offset = "0xA7E3D0", VA = "0x180A7FDD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x060001A7 RID: 423 RVA: 0x00002B98 File Offset: 0x00000D98
			// (set) Token: 0x060001A8 RID: 424 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000014")]
			public Vector2 mergePoint
			{
				[Token(Token = "0x60001A7")]
				[Address(RVA = "0xA7FDE0", Offset = "0xA7E3E0", VA = "0x180A7FDE0")]
				[CompilerGenerated]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x60001A8")]
				[Address(RVA = "0xA7FE00", Offset = "0xA7E400", VA = "0x180A7FE00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x060001A9 RID: 425 RVA: 0x00002BB0 File Offset: 0x00000DB0
			// (set) Token: 0x060001AA RID: 426 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000015")]
			public float error
			{
				[Token(Token = "0x60001A9")]
				[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60001AA")]
				[Address(RVA = "0x623B90", Offset = "0x622190", VA = "0x180623B90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060001AB RID: 427 RVA: 0x00002BC8 File Offset: 0x00000DC8
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0xA7FE10", Offset = "0xA7E410", VA = "0x180A7FE10")]
			public bool MergeRegionContains(int index)
			{
				return default(bool);
			}

			// Token: 0x060001AC RID: 428 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0xA7FE40", Offset = "0xA7E440", VA = "0x180A7FE40")]
			public void HandleRemovedPoints(int removeStart, int removeCount)
			{
			}

			// Token: 0x060001AD RID: 429 RVA: 0x00002BE0 File Offset: 0x00000DE0
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0xA7FE80", Offset = "0xA7E480", VA = "0x180A7FE80")]
			private static bool CalculateMergePoint(int start, int mergeStart, int mergeEnd, int end, List<Vector2> polygon, out Vector2 mergePoint)
			{
				return default(bool);
			}

			// Token: 0x060001AE RID: 430 RVA: 0x00002BF8 File Offset: 0x00000DF8
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0xA80150", Offset = "0xA7E750", VA = "0x180A80150")]
			private static float CalculateError(int mergeStart, int mergeEnd, Vector2 mergePoint, List<Vector2> polygon, IList<Vector2> originalPolygon, List<int> originalIndices)
			{
				return 0f;
			}

			// Token: 0x060001AF RID: 431 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public MergeSpan()
			{
			}
		}

		// Token: 0x02000045 RID: 69
		[Token(Token = "0x2000045")]
		public class Easing
		{
			// Token: 0x060001B0 RID: 432 RVA: 0x00002C10 File Offset: 0x00000E10
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0xA87450", Offset = "0xA85A50", VA = "0x180A87450")]
			public static float EaseInQuad(float time, float offset = 0f, float range = 1f, float duration = 1f)
			{
				return 0f;
			}

			// Token: 0x060001B1 RID: 433 RVA: 0x00002C28 File Offset: 0x00000E28
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0xA87490", Offset = "0xA85A90", VA = "0x180A87490")]
			public static float EaseInOutQuad(float time, float offset = 0f, float range = 1f, float duration = 1f)
			{
				return 0f;
			}

			// Token: 0x060001B2 RID: 434 RVA: 0x00002C40 File Offset: 0x00000E40
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0xA87530", Offset = "0xA85B30", VA = "0x180A87530")]
			public static float EaseInQuart(float time, float offset = 0f, float range = 1f, float duration = 1f)
			{
				return 0f;
			}

			// Token: 0x060001B3 RID: 435 RVA: 0x00002C58 File Offset: 0x00000E58
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0xA87550", Offset = "0xA85B50", VA = "0x180A87550")]
			public static float EaseOutQuart(float time, float offset = 0f, float range = 1f, float duration = 1f)
			{
				return 0f;
			}

			// Token: 0x060001B4 RID: 436 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Easing()
			{
			}
		}
	}
}
