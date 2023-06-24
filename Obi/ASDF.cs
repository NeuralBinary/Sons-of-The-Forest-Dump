using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000171 RID: 369
	[Token(Token = "0x2000171")]
	public class ASDF
	{
		// Token: 0x0600072E RID: 1838 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x27D4990", Offset = "0x27D2F90", VA = "0x1827D4990")]
		public static IEnumerator Build(float maxError, int maxDepth, Vector3[] vertexPositions, int[] triangleIndices, List<DFNode> nodes, int yieldAfterNodeCount = 32)
		{
			return null;
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x000044E4 File Offset: 0x000026E4
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x27D4B00", Offset = "0x27D3100", VA = "0x1827D4B00")]
		public static float Sample(List<DFNode> nodes, Vector3 position)
		{
			return 0f;
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ASDF()
		{
		}

		// Token: 0x04000614 RID: 1556
		[Token(Token = "0x4000614")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector4[] corners;

		// Token: 0x04000615 RID: 1557
		[Token(Token = "0x4000615")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector4[] samples;

		// Token: 0x04000616 RID: 1558
		[Token(Token = "0x4000616")]
		private const float sqrt3 = 1.73205f;
	}
}
