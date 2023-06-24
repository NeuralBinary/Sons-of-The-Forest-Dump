using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001FF RID: 511
	[Token(Token = "0x20001FF")]
	[RequireComponent(typeof(ObiPathSmoother))]
	[RequireComponent(typeof(MeshRenderer))]
	[AddComponentMenu("Physics/Obi/Obi Rope Extruded Renderer", 883)]
	[ExecuteInEditMode]
	[RequireComponent(typeof(MeshFilter))]
	public class ObiRopeExtrudedRenderer : MonoBehaviour
	{
		// Token: 0x06000A79 RID: 2681 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x281E3A0", Offset = "0x281C9A0", VA = "0x18281E3A0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x281E4A0", Offset = "0x281CAA0", VA = "0x18281E4A0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x281E560", Offset = "0x281CB60", VA = "0x18281E560")]
		private void CreateMeshIfNeeded()
		{
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x281E740", Offset = "0x281CD40", VA = "0x18281E740")]
		public void UpdateRenderer(ObiActor actor)
		{
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x281F490", Offset = "0x281DA90", VA = "0x18281F490")]
		private void ClearMeshData()
		{
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x281F5B0", Offset = "0x281DBB0", VA = "0x18281F5B0")]
		private void CommitMeshData()
		{
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x281F7B0", Offset = "0x281DDB0", VA = "0x18281F7B0")]
		public ObiRopeExtrudedRenderer()
		{
		}

		// Token: 0x04000851 RID: 2129
		[Token(Token = "0x4000851")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker m_UpdateExtrudedRopeRendererChunksPerfMarker;

		// Token: 0x04000852 RID: 2130
		[Token(Token = "0x4000852")]
		[FieldOffset(Offset = "0x20")]
		private List<Vector3> vertices;

		// Token: 0x04000853 RID: 2131
		[Token(Token = "0x4000853")]
		[FieldOffset(Offset = "0x28")]
		private List<Vector3> normals;

		// Token: 0x04000854 RID: 2132
		[Token(Token = "0x4000854")]
		[FieldOffset(Offset = "0x30")]
		private List<Vector4> tangents;

		// Token: 0x04000855 RID: 2133
		[Token(Token = "0x4000855")]
		[FieldOffset(Offset = "0x38")]
		private List<Vector2> uvs;

		// Token: 0x04000856 RID: 2134
		[Token(Token = "0x4000856")]
		[FieldOffset(Offset = "0x40")]
		private List<Color> vertColors;

		// Token: 0x04000857 RID: 2135
		[Token(Token = "0x4000857")]
		[FieldOffset(Offset = "0x48")]
		private List<int> tris;

		// Token: 0x04000858 RID: 2136
		[Token(Token = "0x4000858")]
		[FieldOffset(Offset = "0x50")]
		private ObiPathSmoother smoother;

		// Token: 0x04000859 RID: 2137
		[Token(Token = "0x4000859")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		[NonSerialized]
		public Mesh extrudedMesh;

		// Token: 0x0400085A RID: 2138
		[Token(Token = "0x400085A")]
		[FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		public float uvAnchor;

		// Token: 0x0400085B RID: 2139
		[Token(Token = "0x400085B")]
		[FieldOffset(Offset = "0x64")]
		public Vector2 uvScale;

		// Token: 0x0400085C RID: 2140
		[Token(Token = "0x400085C")]
		[FieldOffset(Offset = "0x6C")]
		public bool normalizeV;

		// Token: 0x0400085D RID: 2141
		[Token(Token = "0x400085D")]
		[FieldOffset(Offset = "0x70")]
		public ObiRopeSection section;

		// Token: 0x0400085E RID: 2142
		[Token(Token = "0x400085E")]
		[FieldOffset(Offset = "0x78")]
		public float thicknessScale;
	}
}
