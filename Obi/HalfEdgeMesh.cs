using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	[Serializable]
	public class HalfEdgeMesh
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000166 RID: 358 RVA: 0x000025F4 File Offset: 0x000007F4
		[Token(Token = "0x17000043")]
		public bool ContainsData
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x9DD210", Offset = "0x9DB810", VA = "0x1809DD210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0000260C File Offset: 0x0000080C
		[Token(Token = "0x17000044")]
		public bool closed
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x274B3E0", Offset = "0x27499E0", VA = "0x18274B3E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00002624 File Offset: 0x00000824
		[Token(Token = "0x17000045")]
		public float area
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x5EA840", Offset = "0x5E8E40", VA = "0x1805EA840")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0000263C File Offset: 0x0000083C
		[Token(Token = "0x17000046")]
		public float volume
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x274B430", Offset = "0x2749A30", VA = "0x18274B430")]
		public HalfEdgeMesh()
		{
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x274B850", Offset = "0x2749E50", VA = "0x18274B850")]
		public HalfEdgeMesh(HalfEdgeMesh halfEdge)
		{
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x274C0A0", Offset = "0x274A6A0", VA = "0x18274C0A0")]
		public void Generate()
		{
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x274D9B0", Offset = "0x274BFB0", VA = "0x18274D9B0")]
		private void CalculateRestNormals()
		{
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x274E100", Offset = "0x274C700", VA = "0x18274E100")]
		private void CalculateRestOrientations()
		{
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x274E460", Offset = "0x274CA60", VA = "0x18274E460")]
		public void SwapVertices(int index1, int index2)
		{
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002654 File Offset: 0x00000854
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x274E7C0", Offset = "0x274CDC0", VA = "0x18274E7C0")]
		public int GetHalfEdgeStartVertex(HalfEdgeMesh.HalfEdge edge)
		{
			return 0;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000266C File Offset: 0x0000086C
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x274E8F0", Offset = "0x274CEF0", VA = "0x18274E8F0")]
		public float GetFaceArea(HalfEdgeMesh.Face face)
		{
			return 0f;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x274EC40", Offset = "0x274D240", VA = "0x18274EC40")]
		public IEnumerable<HalfEdgeMesh.Vertex> GetNeighbourVerticesEnumerator(HalfEdgeMesh.Vertex vertex)
		{
			return null;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x274ED10", Offset = "0x274D310", VA = "0x18274ED10")]
		public IEnumerable<HalfEdgeMesh.HalfEdge> GetNeighbourEdgesEnumerator(HalfEdgeMesh.Vertex vertex)
		{
			return null;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x274EDE0", Offset = "0x274D3E0", VA = "0x18274EDE0")]
		public IEnumerable<HalfEdgeMesh.Face> GetNeighbourFacesEnumerator(HalfEdgeMesh.Vertex vertex)
		{
			return null;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x274EEB0", Offset = "0x274D4B0", VA = "0x18274EEB0")]
		public List<int> GetEdgeList()
		{
			return null;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002684 File Offset: 0x00000884
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x274F0A0", Offset = "0x274D6A0", VA = "0x18274F0A0")]
		public bool IsSplit(int halfEdgeIndex)
		{
			return default(bool);
		}

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x10")]
		public Mesh inputMesh;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 scale;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x24")]
		private float _area;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x28")]
		private float _volume;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[HideInInspector]
		public bool containsData;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[SerializeField]
		public List<HalfEdgeMesh.Vertex> vertices;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		[SerializeField]
		public List<HalfEdgeMesh.HalfEdge> halfEdges;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		public List<HalfEdgeMesh.HalfEdge> borderEdges;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		[SerializeField]
		public List<HalfEdgeMesh.Face> faces;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		public List<Vector3> restNormals;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		[SerializeField]
		public List<Quaternion> restOrientations;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		public List<int> rawToWelded;

		// Token: 0x02000031 RID: 49
		[Token(Token = "0x2000031")]
		[Serializable]
		public struct HalfEdge
		{
			// Token: 0x0400010C RID: 268
			[Token(Token = "0x400010C")]
			[FieldOffset(Offset = "0x0")]
			public int index;

			// Token: 0x0400010D RID: 269
			[Token(Token = "0x400010D")]
			[FieldOffset(Offset = "0x4")]
			public int indexInFace;

			// Token: 0x0400010E RID: 270
			[Token(Token = "0x400010E")]
			[FieldOffset(Offset = "0x8")]
			public int face;

			// Token: 0x0400010F RID: 271
			[Token(Token = "0x400010F")]
			[FieldOffset(Offset = "0xC")]
			public int nextHalfEdge;

			// Token: 0x04000110 RID: 272
			[Token(Token = "0x4000110")]
			[FieldOffset(Offset = "0x10")]
			public int pair;

			// Token: 0x04000111 RID: 273
			[Token(Token = "0x4000111")]
			[FieldOffset(Offset = "0x14")]
			public int endVertex;
		}

		// Token: 0x02000032 RID: 50
		[Token(Token = "0x2000032")]
		[Serializable]
		public struct Vertex
		{
			// Token: 0x04000112 RID: 274
			[Token(Token = "0x4000112")]
			[FieldOffset(Offset = "0x0")]
			public int index;

			// Token: 0x04000113 RID: 275
			[Token(Token = "0x4000113")]
			[FieldOffset(Offset = "0x4")]
			public int halfEdge;

			// Token: 0x04000114 RID: 276
			[Token(Token = "0x4000114")]
			[FieldOffset(Offset = "0x8")]
			public Vector3 position;
		}

		// Token: 0x02000033 RID: 51
		[Token(Token = "0x2000033")]
		[Serializable]
		public struct Face
		{
			// Token: 0x04000115 RID: 277
			[Token(Token = "0x4000115")]
			[FieldOffset(Offset = "0x0")]
			public int index;

			// Token: 0x04000116 RID: 278
			[Token(Token = "0x4000116")]
			[FieldOffset(Offset = "0x4")]
			public int halfEdge;
		}
	}
}
