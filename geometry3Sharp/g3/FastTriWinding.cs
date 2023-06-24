using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001CF RID: 463
	[Token(Token = "0x20001CF")]
	public static class FastTriWinding
	{
		// Token: 0x06000D92 RID: 3474 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D92")]
		[Address(RVA = "0x203C720", Offset = "0x203AD20", VA = "0x18203C720")]
		public static void ComputeCoeffs(DMesh3 mesh, IEnumerable<int> triangles, ref Vector3d p, ref double r, ref Vector3d order1, ref Matrix3d order2, [Optional] MeshTriInfoCache triCache)
		{
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00009C14 File Offset: 0x00007E14
		[Token(Token = "0x6000D93")]
		[Address(RVA = "0x203D6B0", Offset = "0x203BCB0", VA = "0x18203D6B0")]
		public static double EvaluateOrder1Approx(ref Vector3d center, ref Vector3d order1Coeff, ref Vector3d q)
		{
			return 0.0;
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00009C2C File Offset: 0x00007E2C
		[Token(Token = "0x6000D94")]
		[Address(RVA = "0x203D830", Offset = "0x203BE30", VA = "0x18203D830")]
		public static double EvaluateOrder2Approx(ref Vector3d center, ref Vector3d order1Coeff, ref Matrix3d order2Coeff, ref Vector3d q)
		{
			return 0.0;
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00009C44 File Offset: 0x00007E44
		[Token(Token = "0x6000D95")]
		[Address(RVA = "0x203DAD0", Offset = "0x203C0D0", VA = "0x18203DAD0")]
		public static double Order1Approx(ref Triangle3d t, ref Vector3d p, ref Vector3d xn, ref double xA, ref Vector3d q)
		{
			return 0.0;
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00009C5C File Offset: 0x00007E5C
		[Token(Token = "0x6000D96")]
		[Address(RVA = "0x203DC90", Offset = "0x203C290", VA = "0x18203DC90")]
		public static double Order2Approx(ref Triangle3d t, ref Vector3d p, ref Vector3d xn, ref double xA, ref Vector3d q)
		{
			return 0.0;
		}
	}
}
