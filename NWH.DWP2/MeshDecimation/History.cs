using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.MeshDecimation
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	public class History
	{
		// Token: 0x0600023A RID: 570 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x27226B0", Offset = "0x2720CB0", VA = "0x1827226B0")]
		public void RemovedTriangle(int f)
		{
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x2722750", Offset = "0x2720D50", VA = "0x182722750")]
		public void ReplaceVertex(int f, int u, int v, Vector3 normal, Vector2 uv, int newV, Vector3 newNormal, Vector2 newUv)
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x2722A10", Offset = "0x2721010", VA = "0x182722A10")]
		public History()
		{
		}

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x18")]
		public List<int> removedTriangles;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x20")]
		public List<ArrayList> replacedVertex;
	}
}
