using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using LibNoise.Generator;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Environment
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	public class Poligonizator : MonoBehaviour
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00002098 File Offset: 0x00000298
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700000A")]
		public float[,,] Gdata
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x784AA0", Offset = "0x7830A0", VA = "0x180784AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x784AB0", Offset = "0x7830B0", VA = "0x180784AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00002098 File Offset: 0x00000298
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700000B")]
		public byte[,,] _cubeIndicies
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x784BA0", Offset = "0x7831A0", VA = "0x180784BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x784BB0", Offset = "0x7831B0", VA = "0x180784BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2F96C30", Offset = "0x2F95230", VA = "0x182F96C30")]
		public void SetData(float[,,] data)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2F96F90", Offset = "0x2F95590", VA = "0x182F96F90")]
		private void Awake()
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2F97180", Offset = "0x2F95780", VA = "0x182F97180")]
		public byte GetCubeIndex(int x, int y, int z)
		{
			return 0;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
		public Mesh GetMesh()
		{
			return null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2F971E0", Offset = "0x2F957E0", VA = "0x182F971E0")]
		private void InitializeData(int iSize, int jSize, int kSize, float noiseScale)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2F97690", Offset = "0x2F95C90", VA = "0x182F97690")]
		private Vector3 GetCenterOffset()
		{
			return default(Vector3);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2F97780", Offset = "0x2F95D80", VA = "0x182F97780")]
		public void Update()
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2F97820", Offset = "0x2F95E20", VA = "0x182F97820")]
		public void MeshUpdate([Optional] int[][] submeshSection, bool updateIndicies = false)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2F978D0", Offset = "0x2F95ED0", VA = "0x182F978D0")]
		public void Init(int iSize, int jSize, int kSize)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2F97F60", Offset = "0x2F96560", VA = "0x182F97F60")]
		private float GetVal(int x, int y, int z, int i)
		{
			return 0f;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2F980A0", Offset = "0x2F966A0", VA = "0x182F980A0")]
		private Vector3 GetPos(int x, int y, int z, int i)
		{
			return default(Vector3);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2F98130", Offset = "0x2F96730", VA = "0x182F98130")]
		public Mesh Process(float isolevel)
		{
			return null;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2F98210", Offset = "0x2F96810", VA = "0x182F98210")]
		public void Process(float isolevel, ref Mesh mesh, [Optional] int[][] submeshSection, bool updateIndicies = false)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2F98E30", Offset = "0x2F97430", VA = "0x182F98E30")]
		private void RecalculateNormals(int[] xMinMax, int[] yMinMax, int[] zMinMax)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2F99580", Offset = "0x2F97B80", VA = "0x182F99580")]
		private bool VertEquals(Vector3 vertA, Vector3 vertB)
		{
			return default(bool);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2F995F0", Offset = "0x2F97BF0", VA = "0x182F995F0")]
		public void UpdateCubeIndicies()
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2F99600", Offset = "0x2F97C00", VA = "0x182F99600")]
		public void UpdateCubeIndicies(float isoLevel)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2F996B0", Offset = "0x2F97CB0", VA = "0x182F996B0")]
		private Color32 GetColor(float time)
		{
			return default(Color32);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000070")]
		public static void Fill<T>(ref T[] destinationArray, params T[] value)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2F99740", Offset = "0x2F97D40", VA = "0x182F99740")]
		private int Polygonise(int x, int y, int z, float isolevel, ref int lastVertIndex, ref int[] vertIndicies, int[] prevI, int[] prevJ, int[] prevK)
		{
			return 0;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2F9B440", Offset = "0x2F99A40", VA = "0x182F9B440")]
		private void ReindexAgainstXYZ(int[] prevI, int[] prevJ, int[] prevK, int voxelVertIndex, ref int output)
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2F9B580", Offset = "0x2F99B80", VA = "0x182F9B580")]
		private int Reindex(int[] prev, int voxelVertIndex, int indexA, int indexB, int indexC, int indexD, int mirrorA, int mirrorB, int mirrorC, int mirrorD)
		{
			return 0;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2F9B5E0", Offset = "0x2F99BE0", VA = "0x182F9B5E0")]
		private int MatchPrevious(int[] prev, int matchIndex)
		{
			return 0;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2F9B6D0", Offset = "0x2F99CD0", VA = "0x182F9B6D0")]
		private void ApplyMatchingVerts(ref int[] target, int[] prev, int edgeIndexA, int edgeIndexB, int edgeIndexC, int edgeIndexD, int edgeIndexAMirror, int edgeIndexBMirror, int edgeIndexCMirror, int edgeIndexDMirror)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2F9B9A0", Offset = "0x2F99FA0", VA = "0x182F9B9A0")]
		private void UpdateCubeIndex(int x, int y, int z, float isoLevel)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2F9BE10", Offset = "0x2F9A410", VA = "0x182F9BE10")]
		private Vector3 VertexInterp(float isolevel, Vector3 p1, Vector3 p2, float valp1, float valp2)
		{
			return default(Vector3);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2F9BF50", Offset = "0x2F9A550", VA = "0x182F9BF50")]
		private void Build(int tianglesNum, Color32 color, ref List<Vector3> verts, ref List<Vector3> normals, ref List<Vector2> uvs, ref List<int> triangles, int[] vertIndicies, ref List<Color32> colors)
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x7849D0", Offset = "0x782FD0", VA = "0x1807849D0")]
		public void SetColorGradient(Gradient vertColorGradient)
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2F9CBA0", Offset = "0x2F9B1A0", VA = "0x182F9CBA0")]
		public Poligonizator()
		{
		}

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int[] _edgeTable;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int[,] _triTable;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 _offset;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 _scale;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector2 _uvScale;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Mesh _mesh;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool _centeredX;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool _centeredY;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		public bool _centeredZ;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		public bool _regenerateMesh;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Poligonizator.GridCell[,,] _grids;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Poligonizator.Triangle[] _triangles;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[FormerlySerializedAs("_size")]
		[SerializeField]
		private int _iSize;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private int _jSize;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int _kSize;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _noiseScale;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _isolevel;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private bool _randomized;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Perlin _perlinGen;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<Vector3> _cachedVerts;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<Vector3> _cachedNormals;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<Vector3> _newCachedNormals;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<Vector2> _cachedUvs;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<int> _cachedTriangles;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] _vertlistBuffer;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private OpenSimplexNoise _simplexNoise;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private bool _recalculateNormals;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<Color32> _cachedColors;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Gradient _colorGradient;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private int _cubeIndex;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[,,][] _adjacency;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private List<int[]> _adjacentIds;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int[][] _vertInts;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Vector3[] _vertListBufferDefaults;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static int[] _fillValue;

		// Token: 0x02000019 RID: 25
		[Token(Token = "0x2000019")]
		private struct GridCell
		{
			// Token: 0x040000EC RID: 236
			[Token(Token = "0x40000EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3[] P;
		}

		// Token: 0x0200001A RID: 26
		[Token(Token = "0x200001A")]
		private struct Triangle
		{
			// Token: 0x040000ED RID: 237
			[Token(Token = "0x40000ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3[] P;
		}
	}
}
