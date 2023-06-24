using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace g3
{
	// Token: 0x020003AF RID: 943
	[Token(Token = "0x20003AF")]
	public static class UnityUtils
	{
		// Token: 0x06001E36 RID: 7734 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001E36")]
		[Address(RVA = "0x1F8E830", Offset = "0x1F8CE30", VA = "0x181F8E830")]
		public static GameObject CreateMeshGO(string name, DMesh3 mesh, [Optional] Material setMaterial, bool bCollider = true)
		{
			return null;
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001E37")]
		[Address(RVA = "0x1F8EB70", Offset = "0x1F8D170", VA = "0x181F8EB70")]
		public static GameObject CreateMeshGO(string name, DMesh3 mesh, Colorf color, bool bCollider = true)
		{
			return null;
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E38")]
		[Address(RVA = "0x1F8EBD0", Offset = "0x1F8D1D0", VA = "0x181F8EBD0")]
		public static void SetGOMesh(GameObject go, DMesh3 mesh)
		{
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001E39")]
		[Address(RVA = "0x1F8EE10", Offset = "0x1F8D410", VA = "0x181F8EE10")]
		public static Mesh DMeshToUnityMesh(DMesh3 m, bool bLimitTo64k = false)
		{
			return null;
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001E3A")]
		[Address(RVA = "0x1F8F370", Offset = "0x1F8D970", VA = "0x181F8F370")]
		public static DMesh3 UnityMeshToDMesh(Mesh mesh)
		{
			return null;
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001E3B")]
		[Address(RVA = "0x1F8F6B0", Offset = "0x1F8DCB0", VA = "0x181F8F6B0")]
		public static Material StandardMaterial(Colorf color)
		{
			return null;
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001E3C")]
		[Address(RVA = "0x1F8F780", Offset = "0x1F8DD80", VA = "0x181F8F780")]
		public static Material SafeLoadMaterial(string sPath)
		{
			return null;
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001E3D")]
		[Address(RVA = "0x1F8F8D0", Offset = "0x1F8DED0", VA = "0x181F8F8D0")]
		public static Vector3[] dvector_to_vector3(DVector<double> vec)
		{
			return null;
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001E3E")]
		[Address(RVA = "0x1F8FAF0", Offset = "0x1F8E0F0", VA = "0x181F8FAF0")]
		public static Vector3[] dvector_to_vector3(DVector<float> vec)
		{
			return null;
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001E3F")]
		[Address(RVA = "0x1F8FD00", Offset = "0x1F8E300", VA = "0x181F8FD00")]
		public static Vector2[] dvector_to_vector2(DVector<float> vec)
		{
			return null;
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001E40")]
		[Address(RVA = "0x1F8FE80", Offset = "0x1F8E480", VA = "0x181F8FE80")]
		public static Color[] dvector_to_color(DVector<float> vec)
		{
			return null;
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001E41")]
		[Address(RVA = "0x1F90090", Offset = "0x1F8E690", VA = "0x181F90090")]
		public static int[] dvector_to_int(DVector<int> vec)
		{
			return null;
		}
	}
}
