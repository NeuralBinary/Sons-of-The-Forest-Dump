using System;
using Il2CppDummyDll;
using UnityEngine;

namespace g3
{
	// Token: 0x020002B8 RID: 696
	[Token(Token = "0x20002B8")]
	public abstract class MeshGenerator
	{
		// Token: 0x060018B5 RID: 6325
		[Token(Token = "0x60018B5")]
		public abstract MeshGenerator Generate();

		// Token: 0x060018B6 RID: 6326 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018B6")]
		[Address(RVA = "0x1EE0BB0", Offset = "0x1EDF1B0", VA = "0x181EE0BB0", Slot = "5")]
		public virtual void MakeMesh(SimpleMesh m)
		{
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60018B7")]
		[Address(RVA = "0x1EE0CC0", Offset = "0x1EDF2C0", VA = "0x181EE0CC0", Slot = "6")]
		public virtual SimpleMesh MakeSimpleMesh()
		{
			return null;
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018B8")]
		[Address(RVA = "0x1EE0D40", Offset = "0x1EDF340", VA = "0x181EE0D40", Slot = "7")]
		public virtual void MakeMesh(DMesh3 m)
		{
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60018B9")]
		[Address(RVA = "0x1EE1310", Offset = "0x1EDF910", VA = "0x181EE1310", Slot = "8")]
		public virtual DMesh3 MakeDMesh()
		{
			return null;
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018BA")]
		[Address(RVA = "0x1EE1390", Offset = "0x1EDF990", VA = "0x181EE1390", Slot = "9")]
		public virtual void MakeMesh(NTMesh3 m)
		{
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60018BB")]
		[Address(RVA = "0x1EE16C0", Offset = "0x1EDFCC0", VA = "0x181EE16C0", Slot = "10")]
		public virtual NTMesh3 MakeNTMesh()
		{
			return null;
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018BC")]
		[Address(RVA = "0x1EE1750", Offset = "0x1EDFD50", VA = "0x181EE1750")]
		protected void duplicate_vertex_span(int nStart, int nCount)
		{
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018BD")]
		[Address(RVA = "0x1EE1A60", Offset = "0x1EE0060", VA = "0x181EE1A60")]
		protected void append_disc(int Slices, int nCenterV, int nRingStart, bool bClosed, bool bCycle, ref int tri_counter, int groupid = -1)
		{
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018BE")]
		[Address(RVA = "0x1EE1C00", Offset = "0x1EE0200", VA = "0x181EE1C00")]
		protected void append_rectangle(int v0, int v1, int v2, int v3, bool bCycle, ref int tri_counter, int groupid = -1)
		{
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018BF")]
		[Address(RVA = "0x1EE1D00", Offset = "0x1EE0300", VA = "0x181EE1D00")]
		protected void append_2d_disc_segment(int iCenter, int iEnd1, int iEnd2, int nSteps, bool bCycle, ref int vtx_counter, ref int tri_counter, int groupid = -1, double force_r = 0.0)
		{
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x0001241C File Offset: 0x0001061C
		[Token(Token = "0x60018C0")]
		[Address(RVA = "0x1EE2410", Offset = "0x1EE0A10", VA = "0x181EE2410")]
		protected Vector3f estimate_normal(int v0, int v1, int v2)
		{
			return default(Vector3f);
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00012434 File Offset: 0x00010634
		[Token(Token = "0x60018C1")]
		[Address(RVA = "0x1EE2870", Offset = "0x1EE0E70", VA = "0x181EE2870")]
		protected Vector3d bilerp(ref Vector3d v00, ref Vector3d v10, ref Vector3d v11, ref Vector3d v01, double tx, double ty)
		{
			return default(Vector3d);
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x0001244C File Offset: 0x0001064C
		[Token(Token = "0x60018C2")]
		[Address(RVA = "0x1EE29E0", Offset = "0x1EE0FE0", VA = "0x181EE29E0")]
		protected Vector2d bilerp(ref Vector2d v00, ref Vector2d v10, ref Vector2d v11, ref Vector2d v01, double tx, double ty)
		{
			return default(Vector2d);
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x00012464 File Offset: 0x00010664
		[Token(Token = "0x60018C3")]
		[Address(RVA = "0x1EE2AE0", Offset = "0x1EE10E0", VA = "0x181EE2AE0")]
		protected Vector2f bilerp(ref Vector2f v00, ref Vector2f v10, ref Vector2f v11, ref Vector2f v01, float tx, float ty)
		{
			return default(Vector2f);
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x0001247C File Offset: 0x0001067C
		[Token(Token = "0x60018C4")]
		[Address(RVA = "0x1EE2BD0", Offset = "0x1EE11D0", VA = "0x181EE2BD0")]
		protected Vector3i bilerp(ref Vector3i v00, ref Vector3i v10, ref Vector3i v11, ref Vector3i v01, double tx, double ty)
		{
			return default(Vector3i);
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00012494 File Offset: 0x00010694
		[Token(Token = "0x60018C5")]
		[Address(RVA = "0x1EE2EA0", Offset = "0x1EE14A0", VA = "0x181EE2EA0")]
		protected Vector3i lerp(ref Vector3i a, ref Vector3i b, double t)
		{
			return default(Vector3i);
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60018C6")]
		[Address(RVA = "0x1EE3090", Offset = "0x1EE1690", VA = "0x181EE3090")]
		private static Vector3[] ToUnityVector3(VectorArray3f a, bool bFlipLR = false)
		{
			return null;
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60018C7")]
		[Address(RVA = "0x1EE31F0", Offset = "0x1EE17F0", VA = "0x181EE31F0")]
		private static Vector3[] ToUnityVector3(VectorArray3d a, bool bFlipLR = false)
		{
			return null;
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60018C8")]
		[Address(RVA = "0x1EE3360", Offset = "0x1EE1960", VA = "0x181EE3360")]
		private static Vector2[] ToUnityVector2(VectorArray2f a)
		{
			return null;
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018C9")]
		[Address(RVA = "0x1EE3450", Offset = "0x1EE1A50", VA = "0x181EE3450")]
		public void MakeMesh(Mesh m, bool bRecalcNormals = false, bool bFlipLR = false)
		{
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018CA")]
		[Address(RVA = "0x1EE3A80", Offset = "0x1EE2080", VA = "0x181EE3A80")]
		protected MeshGenerator()
		{
		}

		// Token: 0x04000C06 RID: 3078
		[Token(Token = "0x4000C06")]
		[FieldOffset(Offset = "0x10")]
		public VectorArray3d vertices;

		// Token: 0x04000C07 RID: 3079
		[Token(Token = "0x4000C07")]
		[FieldOffset(Offset = "0x18")]
		public VectorArray2f uv;

		// Token: 0x04000C08 RID: 3080
		[Token(Token = "0x4000C08")]
		[FieldOffset(Offset = "0x20")]
		public VectorArray3f normals;

		// Token: 0x04000C09 RID: 3081
		[Token(Token = "0x4000C09")]
		[FieldOffset(Offset = "0x28")]
		public IndexArray3i triangles;

		// Token: 0x04000C0A RID: 3082
		[Token(Token = "0x4000C0A")]
		[FieldOffset(Offset = "0x30")]
		public int[] groups;

		// Token: 0x04000C0B RID: 3083
		[Token(Token = "0x4000C0B")]
		[FieldOffset(Offset = "0x38")]
		public bool WantUVs;

		// Token: 0x04000C0C RID: 3084
		[Token(Token = "0x4000C0C")]
		[FieldOffset(Offset = "0x39")]
		public bool WantNormals;

		// Token: 0x04000C0D RID: 3085
		[Token(Token = "0x4000C0D")]
		[FieldOffset(Offset = "0x3A")]
		public bool WantGroups;

		// Token: 0x04000C0E RID: 3086
		[Token(Token = "0x4000C0E")]
		[FieldOffset(Offset = "0x3B")]
		public bool Clockwise;

		// Token: 0x020002B9 RID: 697
		[Token(Token = "0x20002B9")]
		public struct CircularSection
		{
			// Token: 0x060018CB RID: 6347 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60018CB")]
			[Address(RVA = "0x5B25C0", Offset = "0x5B0BC0", VA = "0x1805B25C0")]
			public CircularSection(float r, float y)
			{
			}

			// Token: 0x04000C0F RID: 3087
			[Token(Token = "0x4000C0F")]
			[FieldOffset(Offset = "0x0")]
			public float Radius;

			// Token: 0x04000C10 RID: 3088
			[Token(Token = "0x4000C10")]
			[FieldOffset(Offset = "0x4")]
			public float SectionY;
		}
	}
}
