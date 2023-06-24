using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001CF RID: 463
	[Token(Token = "0x20001CF")]
	public static class ObiUtils
	{
		// Token: 0x06000903 RID: 2307 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000903")]
		[Address(RVA = "0x2800E50", Offset = "0x27FF450", VA = "0x182800E50")]
		public static void DrawArrowGizmo(float bodyLenght, float bodyWidth, float headLenght, float headWidth)
		{
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000904")]
		[Address(RVA = "0x2801250", Offset = "0x27FF850", VA = "0x182801250")]
		public static void DebugDrawCross(Vector3 pos, float size, Color color)
		{
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000905")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Swap<T>(ref T lhs, ref T rhs)
		{
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000906")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Swap<T>(this T[] source, int index1, int index2)
		{
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000907")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Swap<T>(this IList<T> list, int index1, int index2)
		{
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000908")]
		public static void ShiftLeft<T>(this T[] source, int index, int count, int positions)
		{
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000909")]
		public static void ShiftRight<T>(this T[] source, int index, int count, int positions)
		{
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00004BBC File Offset: 0x00002DBC
		[Token(Token = "0x600090A")]
		[Address(RVA = "0x28018B0", Offset = "0x27FFEB0", VA = "0x1828018B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AreValid(this Bounds bounds)
		{
			return default(bool);
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00004BD4 File Offset: 0x00002DD4
		[Token(Token = "0x600090B")]
		[Address(RVA = "0x2801990", Offset = "0x27FFF90", VA = "0x182801990")]
		public static Bounds Transform(this Bounds b, Matrix4x4 m)
		{
			return default(Bounds);
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600090C")]
		[Address(RVA = "0x2801CC0", Offset = "0x28002C0", VA = "0x182801CC0")]
		public static void Add(Vector3 a, Vector3 b, ref Vector3 result)
		{
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00004BEC File Offset: 0x00002DEC
		[Token(Token = "0x600090D")]
		[Address(RVA = "0x2801CF0", Offset = "0x28002F0", VA = "0x182801CF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Remap(this float value, float from1, float to1, float from2, float to2)
		{
			return 0f;
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00004C04 File Offset: 0x00002E04
		[Token(Token = "0x600090E")]
		[Address(RVA = "0x2801D10", Offset = "0x2800310", VA = "0x182801D10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Mod(float a, float b)
		{
			return 0f;
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00004C1C File Offset: 0x00002E1C
		[Token(Token = "0x600090F")]
		[Address(RVA = "0x2801D50", Offset = "0x2800350", VA = "0x182801D50")]
		public static Matrix4x4 Add(this Matrix4x4 a, Matrix4x4 other)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00004C34 File Offset: 0x00002E34
		[Token(Token = "0x6000910")]
		[Address(RVA = "0x2801E00", Offset = "0x2800400", VA = "0x182801E00")]
		public static Matrix4x4 ScalarMultiply(this Matrix4x4 a, float s)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00004C4C File Offset: 0x00002E4C
		[Token(Token = "0x6000911")]
		[Address(RVA = "0x2801E80", Offset = "0x2800480", VA = "0x182801E80")]
		public static Vector3 ProjectPointLine(Vector3 point, Vector3 lineStart, Vector3 lineEnd, out float mu, bool clampToSegment = true)
		{
			return default(Vector3);
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00004C64 File Offset: 0x00002E64
		[Token(Token = "0x6000912")]
		[Address(RVA = "0x2801FF0", Offset = "0x28005F0", VA = "0x182801FF0")]
		public static bool LinePlaneIntersection(Vector3 planePoint, Vector3 planeNormal, Vector3 linePoint, Vector3 lineDirection, out Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00004C7C File Offset: 0x00002E7C
		[Token(Token = "0x6000913")]
		[Address(RVA = "0x2802190", Offset = "0x2800790", VA = "0x182802190")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float InvMassToMass(float invMass)
		{
			return 0f;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00004C94 File Offset: 0x00002E94
		[Token(Token = "0x6000914")]
		[Address(RVA = "0x28021A0", Offset = "0x28007A0", VA = "0x1828021A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float MassToInvMass(float mass)
		{
			return 0f;
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00004CAC File Offset: 0x00002EAC
		[Token(Token = "0x6000915")]
		[Address(RVA = "0x28021C0", Offset = "0x28007C0", VA = "0x1828021C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int PureSign(this float val)
		{
			return 0;
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000916")]
		[Address(RVA = "0x28021E0", Offset = "0x28007E0", VA = "0x1828021E0")]
		public static void NearestPointOnTri(in Vector3 p1, in Vector3 p2, in Vector3 p3, in Vector3 p, out Vector3 result)
		{
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00004CC4 File Offset: 0x00002EC4
		[Token(Token = "0x6000917")]
		[Address(RVA = "0x28025A0", Offset = "0x2800BA0", VA = "0x1828025A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float TriangleArea(Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return 0f;
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00004CDC File Offset: 0x00002EDC
		[Token(Token = "0x6000918")]
		[Address(RVA = "0x28026B0", Offset = "0x2800CB0", VA = "0x1828026B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float EllipsoidVolume(Vector3 principalRadii)
		{
			return 0f;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00004CF4 File Offset: 0x00002EF4
		[Token(Token = "0x6000919")]
		[Address(RVA = "0x28026D0", Offset = "0x2800CD0", VA = "0x1828026D0")]
		public static Quaternion RestDarboux(Quaternion q1, Quaternion q2)
		{
			return default(Quaternion);
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00004D0C File Offset: 0x00002F0C
		[Token(Token = "0x600091A")]
		[Address(RVA = "0x27515F0", Offset = "0x274FBF0", VA = "0x1827515F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float RestBendingConstraint(Vector3 positionA, Vector3 positionB, Vector3 positionC)
		{
			return 0f;
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600091B")]
		[Address(RVA = "0x28029A0", Offset = "0x2800FA0", VA = "0x1828029A0")]
		public static IEnumerable BilateralInterleaved(int count)
		{
			return null;
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600091C")]
		[Address(RVA = "0x2802A00", Offset = "0x2801000", VA = "0x182802A00")]
		public static void BarycentricCoordinates(in Vector3 A, in Vector3 B, in Vector3 C, in Vector3 P, ref Vector3 bary)
		{
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600091D")]
		[Address(RVA = "0x2802C90", Offset = "0x2801290", VA = "0x182802C90")]
		public static void BarycentricInterpolation(in Vector3 p1, in Vector3 p2, in Vector3 p3, in Vector3 coords, out Vector3 result)
		{
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00004D24 File Offset: 0x00002F24
		[Token(Token = "0x600091E")]
		[Address(RVA = "0x2802D20", Offset = "0x2801320", VA = "0x182802D20")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float BarycentricInterpolation(float p1, float p2, float p3, Vector3 coords)
		{
			return 0f;
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00004D3C File Offset: 0x00002F3C
		[Token(Token = "0x600091F")]
		[Address(RVA = "0x2802D40", Offset = "0x2801340", VA = "0x182802D40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float BarycentricExtrapolationScale(Vector3 coords)
		{
			return 0f;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000920")]
		[Address(RVA = "0x2802D80", Offset = "0x2801380", VA = "0x182802D80")]
		public static Vector3[] CalculateAngleWeightedNormals(Vector3[] vertices, int[] triangles)
		{
			return null;
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00004D54 File Offset: 0x00002F54
		[Token(Token = "0x6000921")]
		[Address(RVA = "0x2803B10", Offset = "0x2802110", VA = "0x182803B10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int MakePhase(int group, Oni.ParticleFlags flags)
		{
			return 0;
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00004D6C File Offset: 0x00002F6C
		[Token(Token = "0x6000922")]
		[Address(RVA = "0x2803B20", Offset = "0x2802120", VA = "0x182803B20")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int GetGroupFromPhase(int phase)
		{
			return 0;
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00004D84 File Offset: 0x00002F84
		[Token(Token = "0x6000923")]
		[Address(RVA = "0x2803B30", Offset = "0x2802130", VA = "0x182803B30")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Oni.ParticleFlags GetFlagsFromPhase(int phase)
		{
			return (Oni.ParticleFlags)0;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000924")]
		[Address(RVA = "0x2803B40", Offset = "0x2802140", VA = "0x182803B40")]
		public static void EigenSolve(Matrix4x4 D, out Vector3 S, out Matrix4x4 V)
		{
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00004D9C File Offset: 0x00002F9C
		[Token(Token = "0x6000925")]
		[Address(RVA = "0x2804260", Offset = "0x2802860", VA = "0x182804260")]
		private static Vector3 unitOrthogonal(this Vector3 input)
		{
			return default(Vector3);
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00004DB4 File Offset: 0x00002FB4
		[Token(Token = "0x6000926")]
		[Address(RVA = "0x2804370", Offset = "0x2802970", VA = "0x182804370")]
		private static Vector3 EigenVector(Matrix4x4 D, float S)
		{
			return default(Vector3);
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00004DCC File Offset: 0x00002FCC
		[Token(Token = "0x6000927")]
		[Address(RVA = "0x2804700", Offset = "0x2802D00", VA = "0x182804700")]
		private static Vector3 EigenValues(Matrix4x4 D)
		{
			return default(Vector3);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00004DE4 File Offset: 0x00002FE4
		[Token(Token = "0x6000928")]
		[Address(RVA = "0x2804940", Offset = "0x2802F40", VA = "0x182804940")]
		public static Vector3 GetPointCloudCentroid(List<Vector3> points)
		{
			return default(Vector3);
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000929")]
		[Address(RVA = "0x2804AB0", Offset = "0x28030B0", VA = "0x182804AB0")]
		public static void GetPointCloudAnisotropy(List<Vector3> points, float max_anisotropy, float radius, ref Vector3 hint_normal, ref Vector3 centroid, ref Quaternion orientation, ref Vector3 principal_radii)
		{
		}

		// Token: 0x04000793 RID: 1939
		[Token(Token = "0x4000793")]
		public const float epsilon = 1E-07f;

		// Token: 0x04000794 RID: 1940
		[Token(Token = "0x4000794")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Color32[] colorAlphabet;
	}
}
