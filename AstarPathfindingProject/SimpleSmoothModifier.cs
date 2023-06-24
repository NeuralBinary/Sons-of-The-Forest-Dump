using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000DA RID: 218
	[Token(Token = "0x20000DA")]
	[AddComponentMenu("Pathfinding/Modifiers/Simple Smooth")]
	[RequireComponent(typeof(Seeker))]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_simple_smooth_modifier.php")]
	[Serializable]
	public class SimpleSmoothModifier : MonoModifier
	{
		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x000059E4 File Offset: 0x00003BE4
		[Token(Token = "0x17000133")]
		public override int Order
		{
			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x6C7320", Offset = "0x6C5920", VA = "0x1806C7320", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x6C7330", Offset = "0x6C5930", VA = "0x1806C7330", Slot = "17")]
		public override void Apply(Path p)
		{
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x6C74A0", Offset = "0x6C5AA0", VA = "0x1806C74A0")]
		public List<Vector3> CurvedNonuniform(List<Vector3> path)
		{
			return null;
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x000059FC File Offset: 0x00003BFC
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x6C7ED0", Offset = "0x6C64D0", VA = "0x1806C7ED0")]
		public static Vector3 GetPointOnCubic(Vector3 a, Vector3 b, Vector3 tan1, Vector3 tan2, float t)
		{
			return default(Vector3);
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x6C8060", Offset = "0x6C6660", VA = "0x1806C8060")]
		public List<Vector3> SmoothOffsetSimple(List<Vector3> path)
		{
			return null;
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x6C8BF0", Offset = "0x6C71F0", VA = "0x1806C8BF0")]
		public List<Vector3> SmoothSimple(List<Vector3> path)
		{
			return null;
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x6C94B0", Offset = "0x6C7AB0", VA = "0x1806C94B0")]
		public List<Vector3> SmoothBezier(List<Vector3> path)
		{
			return null;
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x6C9BB0", Offset = "0x6C81B0", VA = "0x1806C9BB0")]
		public SimpleSmoothModifier()
		{
		}

		// Token: 0x04000526 RID: 1318
		[Token(Token = "0x4000526")]
		[FieldOffset(Offset = "0x30")]
		public SimpleSmoothModifier.SmoothType smoothType;

		// Token: 0x04000527 RID: 1319
		[Token(Token = "0x4000527")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("The number of times to subdivide (divide in half) the path segments. [0...inf] (recommended [1...10])")]
		public int subdivisions;

		// Token: 0x04000528 RID: 1320
		[Token(Token = "0x4000528")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Number of times to apply smoothing")]
		public int iterations;

		// Token: 0x04000529 RID: 1321
		[Token(Token = "0x4000529")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("Determines how much smoothing to apply in each smooth iteration. 0.5 usually produces the nicest looking curves")]
		[Range(0f, 1f)]
		public float strength;

		// Token: 0x0400052A RID: 1322
		[Token(Token = "0x400052A")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Toggle to divide all lines in equal length segments")]
		public bool uniformLength;

		// Token: 0x0400052B RID: 1323
		[Token(Token = "0x400052B")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("The length of each segment in the smoothed path. A high value yields rough paths and low value yields very smooth paths, but is slower")]
		public float maxSegmentLength;

		// Token: 0x0400052C RID: 1324
		[Token(Token = "0x400052C")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Length factor of the bezier curves' tangents")]
		public float bezierTangentLength;

		// Token: 0x0400052D RID: 1325
		[Token(Token = "0x400052D")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("Offset to apply in each smoothing iteration when using Offset Simple")]
		public float offset;

		// Token: 0x0400052E RID: 1326
		[Token(Token = "0x400052E")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("How much to smooth the path. A higher value will give a smoother path, but might take the character far off the optimal path.")]
		public float factor;

		// Token: 0x020000DB RID: 219
		[Token(Token = "0x20000DB")]
		public enum SmoothType
		{
			// Token: 0x04000530 RID: 1328
			[Token(Token = "0x4000530")]
			Simple,
			// Token: 0x04000531 RID: 1329
			[Token(Token = "0x4000531")]
			Bezier,
			// Token: 0x04000532 RID: 1330
			[Token(Token = "0x4000532")]
			OffsetSimple,
			// Token: 0x04000533 RID: 1331
			[Token(Token = "0x4000533")]
			CurvedNonuniform
		}
	}
}
