using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	public class MeshHelper
	{
		// Token: 0x06000169 RID: 361 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000169")]
		[Address(RVA = "0xA4AF60", Offset = "0xA49560", VA = "0x180A4AF60")]
		public MeshHelper(Mesh mesh)
		{
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600016A")]
		[Address(RVA = "0xA4B1D0", Offset = "0xA497D0", VA = "0x180A4B1D0")]
		public void GenerateRandomPoint(ref RaycastHit hit, out int triangleIndex)
		{
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600016B")]
		[Address(RVA = "0xA4B2A0", Offset = "0xA498A0", VA = "0x180A4B2A0")]
		public void GetRaycastFromTriangleIndex(int triangleIndex, ref RaycastHit hit)
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600016C RID: 364 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000031")]
		public Mesh Mesh
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600016D RID: 365 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000032")]
		public int[] Triangles
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600016E RID: 366 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000033")]
		public Vector3[] Vertices
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600016F RID: 367 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000034")]
		public Vector3[] Normals
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000170")]
		[Address(RVA = "0xA4B810", Offset = "0xA49E10", VA = "0x180A4B810")]
		private float[] CalculateSurfaceAreas(out float totalSurfaceArea)
		{
			return null;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000171")]
		[Address(RVA = "0xA4BB50", Offset = "0xA4A150", VA = "0x180A4BB50")]
		private void CalculateNormalizedAreaWeights()
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x6000172")]
		[Address(RVA = "0xA4BC30", Offset = "0xA4A230", VA = "0x180A4BC30")]
		private int SelectRandomTriangle()
		{
			return 0;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000024EC File Offset: 0x000006EC
		[Token(Token = "0x6000173")]
		[Address(RVA = "0xA4BCE0", Offset = "0xA4A2E0", VA = "0x180A4BCE0")]
		private Vector3 GenerateRandomBarycentricCoordinates()
		{
			return default(Vector3);
		}

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x10")]
		private Mesh mesh;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x18")]
		private int[] triangles;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x20")]
		private Vector3[] vertices;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x28")]
		private Vector3[] normals;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x30")]
		private float[] normalizedAreaWeights;
	}
}
