using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200026A RID: 618
	[Token(Token = "0x200026A")]
	public static class MeshMeasurements
	{
		// Token: 0x060015D9 RID: 5593 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015D9")]
		[Address(RVA = "0x1E9CC00", Offset = "0x1E9B200", VA = "0x181E9CC00")]
		public static void MassProperties(IEnumerable<Index3i> triangle_indices, Func<int, Vector3d> getVertexF, out double mass, out Vector3d center, out double[,] inertia3x3, bool bodyCoords = false)
		{
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015DA")]
		[Address(RVA = "0x1E9DA70", Offset = "0x1E9C070", VA = "0x181E9DA70")]
		public static void MassProperties(DMesh3 mesh, out double mass, out Vector3d center, out double[,] inertia3x3, bool bodyCoords = false)
		{
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00010934 File Offset: 0x0000EB34
		[Token(Token = "0x60015DB")]
		[Address(RVA = "0x1E9DBA0", Offset = "0x1E9C1A0", VA = "0x181E9DBA0")]
		public static Vector2d VolumeArea(DMesh3 mesh, IEnumerable<int> triangles, Func<int, Vector3d> getVertexF)
		{
			return default(Vector2d);
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x0001094C File Offset: 0x0000EB4C
		[Token(Token = "0x60015DC")]
		[Address(RVA = "0x1E9E050", Offset = "0x1E9C650", VA = "0x181E9E050")]
		public static double VertexOneRingArea(DMesh3 mesh, int vid, bool bDisjoint = true)
		{
			return 0.0;
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00010964 File Offset: 0x0000EB64
		[Token(Token = "0x60015DD")]
		[Address(RVA = "0x1E9E270", Offset = "0x1E9C870", VA = "0x181E9E270")]
		public static Vector3d Centroid(IEnumerable<Vector3d> vertices)
		{
			return default(Vector3d);
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x0001097C File Offset: 0x0000EB7C
		[Token(Token = "0x60015DE")]
		public static Vector3d Centroid<T>(IEnumerable<T> values, Func<T, Vector3d> PositionF)
		{
			return default(Vector3d);
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00010994 File Offset: 0x0000EB94
		[Token(Token = "0x60015DF")]
		[Address(RVA = "0x1E9E540", Offset = "0x1E9CB40", VA = "0x181E9E540")]
		public static Vector3d Centroid(DMesh3 mesh, bool bOnlyTriVertices = true)
		{
			return default(Vector3d);
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x000109AC File Offset: 0x0000EBAC
		[Token(Token = "0x60015E0")]
		[Address(RVA = "0x1E9E8D0", Offset = "0x1E9CED0", VA = "0x181E9E8D0")]
		public static AxisAlignedBox3d Bounds(DMesh3 mesh, Func<Vector3d, Vector3d> TransformF)
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x000109C4 File Offset: 0x0000EBC4
		[Token(Token = "0x60015E1")]
		[Address(RVA = "0x1E9ED00", Offset = "0x1E9D300", VA = "0x181E9ED00")]
		public static AxisAlignedBox3d Bounds(IMesh mesh, Func<Vector3d, Vector3d> TransformF)
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x000109DC File Offset: 0x0000EBDC
		[Token(Token = "0x60015E2")]
		[Address(RVA = "0x1E9F290", Offset = "0x1E9D890", VA = "0x181E9F290")]
		public static AxisAlignedBox3d BoundsV(IMesh mesh, IEnumerable<int> vertexIndices, [Optional] Func<Vector3d, Vector3d> TransformF)
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x000109F4 File Offset: 0x0000EBF4
		[Token(Token = "0x60015E3")]
		[Address(RVA = "0x1E9F7F0", Offset = "0x1E9DDF0", VA = "0x181E9F7F0")]
		public static AxisAlignedBox3d BoundsT(IMesh mesh, IEnumerable<int> triangleIndices, [Optional] Func<Vector3d, Vector3d> TransformF)
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x00010A0C File Offset: 0x0000EC0C
		[Token(Token = "0x60015E4")]
		[Address(RVA = "0x1E9FC30", Offset = "0x1E9E230", VA = "0x181E9FC30")]
		public static double AreaT(DMesh3 mesh, IEnumerable<int> triangleIndices)
		{
			return 0.0;
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x00010A24 File Offset: 0x0000EC24
		[Token(Token = "0x60015E5")]
		[Address(RVA = "0x1E9FE20", Offset = "0x1E9E420", VA = "0x181E9FE20")]
		public static AxisAlignedBox3d BoundsInFrame(DMesh3 mesh, Frame3f frame, [Optional] Func<Vector3d, Vector3d> TransformF)
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00010A3C File Offset: 0x0000EC3C
		[Token(Token = "0x60015E6")]
		[Address(RVA = "0x1EA0360", Offset = "0x1E9E960", VA = "0x181EA0360")]
		public static Interval1d ExtentsOnAxis(DMesh3 mesh, Vector3d axis, [Optional] Func<Vector3d, Vector3d> TransformF)
		{
			return default(Interval1d);
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00010A54 File Offset: 0x0000EC54
		[Token(Token = "0x60015E7")]
		[Address(RVA = "0x1EA07E0", Offset = "0x1E9EDE0", VA = "0x181EA07E0")]
		public static Interval1d ExtentsOnAxis(IMesh mesh, Vector3d axis, [Optional] Func<Vector3d, Vector3d> TransformF)
		{
			return default(Interval1d);
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00010A6C File Offset: 0x0000EC6C
		[Token(Token = "0x60015E8")]
		[Address(RVA = "0x1EA0DA0", Offset = "0x1E9F3A0", VA = "0x181EA0DA0")]
		public static Interval1i ExtremeVertices(DMesh3 mesh, Vector3d axis, [Optional] Func<Vector3d, Vector3d> TransformF)
		{
			return default(Interval1i);
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00010A84 File Offset: 0x0000EC84
		[Token(Token = "0x60015E9")]
		[Address(RVA = "0x1EA12A0", Offset = "0x1E9F8A0", VA = "0x181EA12A0")]
		public static MeshMeasurements.GenusResult Genus(DMesh3 mesh)
		{
			return default(MeshMeasurements.GenusResult);
		}

		// Token: 0x0200026B RID: 619
		[Token(Token = "0x200026B")]
		public struct GenusResult
		{
			// Token: 0x04000A51 RID: 2641
			[Token(Token = "0x4000A51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool Valid;

			// Token: 0x04000A52 RID: 2642
			[Token(Token = "0x4000A52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int Genus;

			// Token: 0x04000A53 RID: 2643
			[Token(Token = "0x4000A53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool HasBoundary;

			// Token: 0x04000A54 RID: 2644
			[Token(Token = "0x4000A54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			public bool MultipleConnectedComponents;

			// Token: 0x04000A55 RID: 2645
			[Token(Token = "0x4000A55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public bool HasBowtieVertices;
		}
	}
}
