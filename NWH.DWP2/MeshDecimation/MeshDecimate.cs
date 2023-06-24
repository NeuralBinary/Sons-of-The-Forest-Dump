using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.MeshDecimation
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	public class MeshDecimate
	{
		// Token: 0x0600023D RID: 573 RVA: 0x000030BC File Offset: 0x000012BC
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x2722B60", Offset = "0x2721160", VA = "0x182722B60")]
		private float ComputeEdgeCollapseCosts(Vert u, Vert v)
		{
			return 0f;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x2723130", Offset = "0x2721730", VA = "0x182723130")]
		private void ComputeEdgeCostAtVertex(Vert v)
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x2723320", Offset = "0x2721920", VA = "0x182723320")]
		private void ComputeAllEdgeCollapseCosts()
		{
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x27233D0", Offset = "0x27219D0", VA = "0x1827233D0")]
		private void UnCollapse(History his)
		{
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x2723970", Offset = "0x2721F70", VA = "0x182723970")]
		private void Collapse(History his)
		{
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x2723F10", Offset = "0x2722510", VA = "0x182723F10")]
		private void CollapseTest()
		{
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2724740", Offset = "0x2722D40", VA = "0x182724740")]
		private void SortRight(Vert v)
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x2724970", Offset = "0x2722F70", VA = "0x182724970")]
		private void SortLeft(Vert v)
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x2724B90", Offset = "0x2723190", VA = "0x182724B90")]
		public void PreCalculate(Mesh tmpMesh)
		{
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x27254D0", Offset = "0x2723AD0", VA = "0x1827254D0")]
		public void Calculate(Mesh tmpMesh)
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x27263D0", Offset = "0x27249D0", VA = "0x1827263D0")]
		private void ComputeProgressiveMesh()
		{
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x2726F60", Offset = "0x2725560", VA = "0x182726F60")]
		private void ProgressiveMesh(float ratio)
		{
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x2727030", Offset = "0x2725630", VA = "0x182727030")]
		private void RecalculateNormal()
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x27270B0", Offset = "0x27256B0", VA = "0x1827270B0")]
		public MeshDecimate()
		{
		}

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x10")]
		public float ratio;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x14")]
		public float smoothAngle;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x18")]
		public bool lockSelPoint;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x20")]
		public List<Vector3> selectedVertices;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x28")]
		public bool bRecalculateNormals;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x2C")]
		public float lodDataSize;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x30")]
		public Vector3[] finalVertices;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x38")]
		public Vector3[] finalNormals;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x40")]
		public Vector2[] finalUVs;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x48")]
		public int[] finalTriangles;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x50")]
		public bool preCalculateDone;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x54")]
		public int lastTarget;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x58")]
		private float smoothAngleDot;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x60")]
		private Tri[] myTriangles;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x68")]
		private Vert[] myLODVertices;

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x70")]
		private History[] collapseHistory;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x78")]
		private List<Vert> cache;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x80")]
		private int cacheSize;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x88")]
		private int[] triOrder;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x90")]
		private int[] originalTriangles;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x98")]
		private Vector3[] originalVertices;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0xA0")]
		private Vector2[] originalUVs;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3[] originalNormals;

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0xB0")]
		private int[] sharedTriangles;

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0xB8")]
		private Vector3[] sharedVertices;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0xC0")]
		private int currentcnt;

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0xC4")]
		private int searchIndex;
	}
}
