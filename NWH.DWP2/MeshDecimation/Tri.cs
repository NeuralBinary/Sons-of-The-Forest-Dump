using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.MeshDecimation
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	public class Tri
	{
		// Token: 0x0600024E RID: 590 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x27272D0", Offset = "0x27258D0", VA = "0x1827272D0")]
		public Tri(int id, Vert v0, Vert v1, Vert v2, Vector2 uv0, Vector2 uv1, Vector2 uv2)
		{
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x27274D0", Offset = "0x2725AD0", VA = "0x1827274D0")]
		public void SetDefaultIndices(int n0, int n1, int n2)
		{
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x27274E0", Offset = "0x2725AE0", VA = "0x1827274E0")]
		public void RemoveTriangle(History his)
		{
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000030EC File Offset: 0x000012EC
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x2727710", Offset = "0x2725D10", VA = "0x182727710")]
		public Vector2 uvAt(Vert v)
		{
			return default(Vector2);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00003104 File Offset: 0x00001304
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x27278B0", Offset = "0x2725EB0", VA = "0x1827278B0")]
		public Vector3 normalAt(Vert v)
		{
			return default(Vector3);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x2727A80", Offset = "0x2726080", VA = "0x182727A80")]
		public void setUV(Vert v, Vector2 newuv)
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x2727BD0", Offset = "0x27261D0", VA = "0x182727BD0")]
		public void setVN(Vert v, Vector3 newNormal)
		{
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000311C File Offset: 0x0000131C
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x2727D50", Offset = "0x2726350", VA = "0x182727D50")]
		public bool HasVertex(Vert v)
		{
			return default(bool);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x2727EA0", Offset = "0x27264A0", VA = "0x182727EA0")]
		public void RecalculateNormal()
		{
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x2727FE0", Offset = "0x27265E0", VA = "0x182727FE0")]
		public void RecalculateAvgNormals(float smoothAngleDot)
		{
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x2728570", Offset = "0x2726B70", VA = "0x182728570")]
		public void ReplaceVertex(Vert vo, Vert vnew, Vector2 newUV, Vector3 newVN, History his)
		{
		}

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x18")]
		public Vert v0;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x20")]
		public Vert v1;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x28")]
		public Vert v2;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x30")]
		public int defaultIndex0;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x34")]
		public int defaultIndex1;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x38")]
		public int defaultIndex2;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x3C")]
		public Vector2 uv0;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x44")]
		public Vector2 uv1;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x4C")]
		public Vector2 uv2;

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 vn0;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x60")]
		public Vector3 vn1;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x6C")]
		public Vector3 vn2;

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x78")]
		public Vector3 normal;

		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x84")]
		public bool deleted;
	}
}
