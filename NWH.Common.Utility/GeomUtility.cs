using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.Common.Utility
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public static class GeomUtility
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x26F6C60", Offset = "0x26F5260", VA = "0x1826F6C60")]
		public static bool NearEqual(this Vector3 a, Vector3 b, float threshold = 0.01f)
		{
			return default(bool);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x26F6CC0", Offset = "0x26F52C0", VA = "0x1826F6CC0")]
		public static bool Equal(this Quaternion a, Quaternion b)
		{
			return default(bool);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x26F6D60", Offset = "0x26F5360", VA = "0x1826F6D60")]
		public static Vector3 RoundedMax(this Vector3 v)
		{
			return default(Vector3);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x26F6EC0", Offset = "0x26F54C0", VA = "0x1826F6EC0")]
		public static Vector3 NearestPointOnLine(Vector3 linePnt, Vector3 lineDir, Vector3 pnt)
		{
			return default(Vector3);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x26F6FC0", Offset = "0x26F55C0", VA = "0x1826F6FC0")]
		public static float FindDistanceToSegment(Vector3 pt, Vector3 p1, Vector3 p2)
		{
			return 0f;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x6000010")]
		[Address(RVA = "0xA8DCB0", Offset = "0xA8C2B0", VA = "0x180A8DCB0")]
		public static float SquareDistance(Vector3 a, Vector3 b)
		{
			return 0f;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x26F7150", Offset = "0x26F5750", VA = "0x1826F7150")]
		public static Vector3 LinePlaneIntersection(Vector3 planePoint, Vector3 planeNormal, Vector3 linePoint, Vector3 lineDirection)
		{
			return default(Vector3);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x26F73C0", Offset = "0x26F59C0", VA = "0x1826F73C0")]
		public static Vector3 FindChordLine(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float chordPercent)
		{
			return default(Vector3);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x26F7500", Offset = "0x26F5B00", VA = "0x1826F7500")]
		public static Vector3 FindSpanLine(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float spanPercent)
		{
			return default(Vector3);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x26F7690", Offset = "0x26F5C90", VA = "0x1826F7690")]
		public static float FindArea(Vector3 A, Vector3 B, Vector3 C, Vector3 D)
		{
			return 0f;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x26F78B0", Offset = "0x26F5EB0", VA = "0x1826F78B0")]
		public static Vector3 FindCenter(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
		{
			return default(Vector3);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x26F7A00", Offset = "0x26F6000", VA = "0x1826F7A00")]
		public static float DistanceAlongNormal(Vector3 a, Vector3 b, Vector3 normal)
		{
			return 0f;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x26F7AB0", Offset = "0x26F60B0", VA = "0x1826F7AB0")]
		public static bool PointInTriangle(Vector3 A, Vector3 B, Vector3 C, Vector3 P, float dotThreshold = 0.001f)
		{
			return default(bool);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x26F7DF0", Offset = "0x26F63F0", VA = "0x1826F7DF0")]
		private static bool SameSide(Vector3 p1, Vector3 p2, Vector3 A, Vector3 B)
		{
			return default(bool);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x26F80E0", Offset = "0x26F66E0", VA = "0x1826F80E0")]
		public static bool PointIsInsideRect(Vector2 point)
		{
			return default(bool);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x26F81D0", Offset = "0x26F67D0", VA = "0x1826F81D0")]
		public static bool NearlyEqual(this float a, float b, double epsilon)
		{
			return default(bool);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x26F81F0", Offset = "0x26F67F0", VA = "0x1826F81F0")]
		public static float AreaFromThreePoints(Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return 0f;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x26F7690", Offset = "0x26F5C90", VA = "0x1826F7690")]
		public static float AreaFromFourPoints(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4)
		{
			return 0f;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x26F81F0", Offset = "0x26F67F0", VA = "0x1826F81F0")]
		public static float TriArea(Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return 0f;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x26F82D0", Offset = "0x26F68D0", VA = "0x1826F82D0")]
		public static float MeshArea(Mesh mesh)
		{
			return 0f;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x26F8510", Offset = "0x26F6B10", VA = "0x1826F8510")]
		public static float ProjectedMeshArea(Mesh mesh, Vector3 direction)
		{
			return 0f;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x26F7690", Offset = "0x26F5C90", VA = "0x1826F7690")]
		public static float RectArea(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4)
		{
			return 0f;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x26F87D0", Offset = "0x26F6DD0", VA = "0x1826F87D0")]
		public static Vector3 FindMeshCenter(Mesh mesh)
		{
			return default(Vector3);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x26F8A10", Offset = "0x26F7010", VA = "0x1826F8A10")]
		public static float TriArea(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 view)
		{
			return 0f;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x26F8BB0", Offset = "0x26F71B0", VA = "0x1826F8BB0")]
		public static float SignedVolumeOfTriangle(Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return 0f;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x26F8C70", Offset = "0x26F7270", VA = "0x1826F8C70")]
		public static float VolumeOfMesh(Mesh mesh)
		{
			return 0f;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x26F8EA0", Offset = "0x26F74A0", VA = "0x1826F8EA0")]
		public static Vector3 TransformPointUnscaled(this Transform transform, Vector3 position)
		{
			return default(Vector3);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x26F9120", Offset = "0x26F7720", VA = "0x1826F9120")]
		public static Vector3 InverseTransformPointUnscaled(this Transform transform, Vector3 position)
		{
			return default(Vector3);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x26F9460", Offset = "0x26F7A60", VA = "0x1826F9460")]
		public static void ChangeLayersRecursively(this Transform trans, string name)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x26F9770", Offset = "0x26F7D70", VA = "0x1826F9770")]
		public static void ChangeObjectColor(GameObject gameObject, Color color)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x26F9840", Offset = "0x26F7E40", VA = "0x1826F9840")]
		public static void ChangeObjectAlpha(GameObject gameObject, float alpha)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x600002A")]
		[Address(RVA = "0xA8D700", Offset = "0xA8BD00", VA = "0x180A8D700")]
		public static Vector3 Vector3Abs(Vector3 v)
		{
			return default(Vector3);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x26F99B0", Offset = "0x26F7FB0", VA = "0x1826F99B0")]
		public static Vector3 Vector3RoundToInt(Vector3 v)
		{
			return default(Vector3);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x26F9A30", Offset = "0x26F8030", VA = "0x1826F9A30")]
		public static Vector3 Vector3OneOver(Vector3 v)
		{
			return default(Vector3);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x26F9A60", Offset = "0x26F8060", VA = "0x1826F9A60")]
		public static float RoundToStep(float value, float step)
		{
			return 0f;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x26F9A90", Offset = "0x26F8090", VA = "0x1826F9A90")]
		public static float RoundToStep(int value, int step)
		{
			return 0f;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x26F9AD0", Offset = "0x26F80D0", VA = "0x1826F9AD0")]
		public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angles)
		{
			return default(Vector3);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x26F9C60", Offset = "0x26F8260", VA = "0x1826F9C60")]
		public static Vector3 QuadLerp(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float u, float v)
		{
			return default(Vector3);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x26F9E20", Offset = "0x26F8420", VA = "0x1826F9E20")]
		public static Vector3 Vector3Lerp(Vector3 v1, Vector3 v2, float value)
		{
			return default(Vector3);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x26F9EB0", Offset = "0x26F84B0", VA = "0x1826F9EB0")]
		public static float QuaternionMagnitude(Quaternion q)
		{
			return 0f;
		}
	}
}
