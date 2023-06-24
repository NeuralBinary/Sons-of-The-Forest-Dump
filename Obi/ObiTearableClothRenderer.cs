using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	[AddComponentMenu("Physics/Obi/Obi Tearable Cloth Renderer", 904)]
	[ExecuteInEditMode]
	[RequireComponent(typeof(ObiTearableCloth))]
	public class ObiTearableClothRenderer : ObiClothRendererMeshFilter
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000058")]
		public override HalfEdgeMesh topology
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x2758510", Offset = "0x2756B10", VA = "0x182758510", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x2758690", Offset = "0x2756C90", VA = "0x182758690", Slot = "8")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x2758880", Offset = "0x2756E80", VA = "0x182758880", Slot = "9")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2758A70", Offset = "0x2757070", VA = "0x182758A70", Slot = "10")]
		protected override void GetClothMeshData()
		{
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2758BF0", Offset = "0x27571F0", VA = "0x182758BF0", Slot = "11")]
		protected override void SetClothMeshData()
		{
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x2758EE0", Offset = "0x27574E0", VA = "0x182758EE0")]
		public void UpdateMesh(object sender, ObiTearableCloth.ObiClothTornEventArgs args)
		{
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x2758F40", Offset = "0x2757540", VA = "0x182758F40")]
		private HashSet<int> GetTornMeshVertices(int vertexIndex, List<HalfEdgeMesh.Face> updatedFaces)
		{
			return null;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x27593F0", Offset = "0x27579F0", VA = "0x1827593F0")]
		private void UpdateTornMeshVertices(HashSet<int> meshVertices, List<HalfEdgeMesh.Face> updatedFaces)
		{
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x2759DB0", Offset = "0x27583B0", VA = "0x182759DB0")]
		public ObiTearableClothRenderer()
		{
		}

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0xB8")]
		private List<int> clothTriangles;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0xC0")]
		private List<Vector2> clothUV1;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0xC8")]
		private List<Vector2> clothUV2;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0xD0")]
		private List<Vector2> clothUV3;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0xD8")]
		private List<Vector2> clothUV4;
	}
}
