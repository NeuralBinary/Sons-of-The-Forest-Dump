using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.WaterObjects
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public static class MeshUtility
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x26FE8F0", Offset = "0x26FCEF0", VA = "0x1826FE8F0")]
		public static void GenerateSimMesh(ref Mesh originalMesh, ref Mesh simMesh, bool simplifyMesh = false, bool convexifyMesh = false, bool weldColocatedVertices = true, float simplificationRatio = 1f)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x26FEB30", Offset = "0x26FD130", VA = "0x1826FEB30")]
		public static Mesh GenerateMesh(Vector3[] vertices, int[] triangles)
		{
			return null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x26FEC50", Offset = "0x26FD250", VA = "0x1826FEC50")]
		public static void WeldVertices(ref Mesh aMesh, float aMaxDelta = 0.001f)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x26FF070", Offset = "0x26FD670", VA = "0x1826FF070")]
		private static Mesh GenerateSimplifiedMesh(ref Mesh om, ref Mesh dummyMesh, float ratio)
		{
			return null;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x26F8BB0", Offset = "0x26F71B0", VA = "0x1826F8BB0")]
		public static float SignedVolumeOfTriangle(Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return 0f;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x26FF360", Offset = "0x26FD960", VA = "0x1826FF360")]
		public static float VolumeOfMesh(Mesh mesh, Transform transform)
		{
			return 0f;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x26FF8C0", Offset = "0x26FDEC0", VA = "0x1826FF8C0")]
		public static Mesh GenerateConvexMesh(Mesh mesh)
		{
			return null;
		}
	}
}
