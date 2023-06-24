using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Rendering;

namespace Obi
{
	// Token: 0x02000200 RID: 512
	[Token(Token = "0x2000200")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(MeshFilter))]
	[RequireComponent(typeof(ObiPathSmoother))]
	[AddComponentMenu("Physics/Obi/Obi Rope Line Renderer", 884)]
	[RequireComponent(typeof(MeshRenderer))]
	public class ObiRopeLineRenderer : MonoBehaviour
	{
		// Token: 0x06000A81 RID: 2689 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x281FCF0", Offset = "0x281E2F0", VA = "0x18281FCF0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x2820020", Offset = "0x281E620", VA = "0x182820020")]
		private void OnDisable()
		{
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x28201E0", Offset = "0x281E7E0", VA = "0x1828201E0")]
		private void CreateMeshIfNeeded()
		{
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x28203C0", Offset = "0x281E9C0", VA = "0x1828203C0")]
		public void UpdateRenderer(Camera camera)
		{
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x2821600", Offset = "0x281FC00", VA = "0x182821600")]
		private void ClearMeshData()
		{
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x2821720", Offset = "0x281FD20", VA = "0x182821720")]
		private void CommitMeshData()
		{
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x2821920", Offset = "0x281FF20", VA = "0x182821920")]
		public ObiRopeLineRenderer()
		{
		}

		// Token: 0x0400085F RID: 2143
		[Token(Token = "0x400085F")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker m_UpdateLineRopeRendererChunksPerfMarker;

		// Token: 0x04000860 RID: 2144
		[Token(Token = "0x4000860")]
		[FieldOffset(Offset = "0x20")]
		private List<Vector3> vertices;

		// Token: 0x04000861 RID: 2145
		[Token(Token = "0x4000861")]
		[FieldOffset(Offset = "0x28")]
		private List<Vector3> normals;

		// Token: 0x04000862 RID: 2146
		[Token(Token = "0x4000862")]
		[FieldOffset(Offset = "0x30")]
		private List<Vector4> tangents;

		// Token: 0x04000863 RID: 2147
		[Token(Token = "0x4000863")]
		[FieldOffset(Offset = "0x38")]
		private List<Vector2> uvs;

		// Token: 0x04000864 RID: 2148
		[Token(Token = "0x4000864")]
		[FieldOffset(Offset = "0x40")]
		private List<Color> vertColors;

		// Token: 0x04000865 RID: 2149
		[Token(Token = "0x4000865")]
		[FieldOffset(Offset = "0x48")]
		private List<int> tris;

		// Token: 0x04000866 RID: 2150
		[Token(Token = "0x4000866")]
		[FieldOffset(Offset = "0x50")]
		private ObiRopeBase rope;

		// Token: 0x04000867 RID: 2151
		[Token(Token = "0x4000867")]
		[FieldOffset(Offset = "0x58")]
		private ObiPathSmoother smoother;

		// Token: 0x04000868 RID: 2152
		[Token(Token = "0x4000868")]
		[FieldOffset(Offset = "0x60")]
		private Action<ScriptableRenderContext, Camera> renderCallback;

		// Token: 0x04000869 RID: 2153
		[Token(Token = "0x4000869")]
		[FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[NonSerialized]
		public Mesh lineMesh;

		// Token: 0x0400086A RID: 2154
		[Token(Token = "0x400086A")]
		[FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		public float uvAnchor;

		// Token: 0x0400086B RID: 2155
		[Token(Token = "0x400086B")]
		[FieldOffset(Offset = "0x74")]
		public Vector2 uvScale;

		// Token: 0x0400086C RID: 2156
		[Token(Token = "0x400086C")]
		[FieldOffset(Offset = "0x7C")]
		public bool normalizeV;

		// Token: 0x0400086D RID: 2157
		[Token(Token = "0x400086D")]
		[FieldOffset(Offset = "0x80")]
		public float thicknessScale;
	}
}
