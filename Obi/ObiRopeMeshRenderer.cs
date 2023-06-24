using System;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000201 RID: 513
	[Token(Token = "0x2000201")]
	[RequireComponent(typeof(ObiPathSmoother))]
	[RequireComponent(typeof(MeshFilter))]
	[RequireComponent(typeof(MeshRenderer))]
	[ExecuteInEditMode]
	[AddComponentMenu("Physics/Obi/Obi Rope Mesh Renderer", 886)]
	public class ObiRopeMeshRenderer : MonoBehaviour
	{
		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x00002186 File Offset: 0x00000386
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x170001AC")]
		public Mesh SourceMesh
		{
			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x2821DA0", Offset = "0x28203A0", VA = "0x182821DA0")]
			set
			{
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x00005684 File Offset: 0x00003884
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x170001AD")]
		public ObiPathFrame.Axis SweepAxis
		{
			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
			get
			{
				return ObiPathFrame.Axis.X;
			}
			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x2821E00", Offset = "0x2820400", VA = "0x182821E00")]
			set
			{
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x0000569C File Offset: 0x0000389C
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x170001AE")]
		public int Instances
		{
			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0x716CD0", Offset = "0x7152D0", VA = "0x180716CD0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x2821E10", Offset = "0x2820410", VA = "0x182821E10")]
			set
			{
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x000056B4 File Offset: 0x000038B4
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x170001AF")]
		public float InstanceSpacing
		{
			[Token(Token = "0x6000A91")]
			[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x2821E20", Offset = "0x2820420", VA = "0x182821E20")]
			set
			{
			}
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x2821E30", Offset = "0x2820430", VA = "0x182821E30")]
		private void OnEnable()
		{
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x2821F30", Offset = "0x2820530", VA = "0x182821F30")]
		private void OnDisable()
		{
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x2821FF0", Offset = "0x28205F0", VA = "0x182821FF0")]
		private void PreprocessInputMesh()
		{
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x2823200", Offset = "0x2821800", VA = "0x182823200")]
		public void UpdateRenderer(ObiActor actor)
		{
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x28242F0", Offset = "0x28228F0", VA = "0x1828242F0")]
		private void CommitMeshData()
		{
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x2824490", Offset = "0x2822A90", VA = "0x182824490")]
		public ObiRopeMeshRenderer()
		{
		}

		// Token: 0x0400086E RID: 2158
		[Token(Token = "0x400086E")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker m_UpdateMeshRopeRendererChunksPerfMarker;

		// Token: 0x0400086F RID: 2159
		[Token(Token = "0x400086F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeProperty("SourceMesh")]
		[SerializeField]
		private Mesh mesh;

		// Token: 0x04000870 RID: 2160
		[Token(Token = "0x4000870")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[SerializeProperty("SweepAxis")]
		private ObiPathFrame.Axis axis;

		// Token: 0x04000871 RID: 2161
		[Token(Token = "0x4000871")]
		[FieldOffset(Offset = "0x2C")]
		public float volumeScaling;

		// Token: 0x04000872 RID: 2162
		[Token(Token = "0x4000872")]
		[FieldOffset(Offset = "0x30")]
		public bool stretchWithRope;

		// Token: 0x04000873 RID: 2163
		[Token(Token = "0x4000873")]
		[FieldOffset(Offset = "0x31")]
		public bool spanEntireLength;

		// Token: 0x04000874 RID: 2164
		[Token(Token = "0x4000874")]
		[FieldOffset(Offset = "0x34")]
		[SerializeProperty("Instances")]
		[SerializeField]
		private int instances;

		// Token: 0x04000875 RID: 2165
		[Token(Token = "0x4000875")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[SerializeProperty("InstanceSpacing")]
		private float instanceSpacing;

		// Token: 0x04000876 RID: 2166
		[Token(Token = "0x4000876")]
		[FieldOffset(Offset = "0x3C")]
		public float offset;

		// Token: 0x04000877 RID: 2167
		[Token(Token = "0x4000877")]
		[FieldOffset(Offset = "0x40")]
		public Vector3 scale;

		// Token: 0x04000878 RID: 2168
		[Token(Token = "0x4000878")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[HideInInspector]
		private float meshSizeAlongAxis;

		// Token: 0x04000879 RID: 2169
		[Token(Token = "0x4000879")]
		[FieldOffset(Offset = "0x50")]
		private Vector3[] inputVertices;

		// Token: 0x0400087A RID: 2170
		[Token(Token = "0x400087A")]
		[FieldOffset(Offset = "0x58")]
		private Vector3[] inputNormals;

		// Token: 0x0400087B RID: 2171
		[Token(Token = "0x400087B")]
		[FieldOffset(Offset = "0x60")]
		private Vector4[] inputTangents;

		// Token: 0x0400087C RID: 2172
		[Token(Token = "0x400087C")]
		[FieldOffset(Offset = "0x68")]
		private Vector3[] vertices;

		// Token: 0x0400087D RID: 2173
		[Token(Token = "0x400087D")]
		[FieldOffset(Offset = "0x70")]
		private Vector3[] normals;

		// Token: 0x0400087E RID: 2174
		[Token(Token = "0x400087E")]
		[FieldOffset(Offset = "0x78")]
		private Vector4[] tangents;

		// Token: 0x0400087F RID: 2175
		[Token(Token = "0x400087F")]
		[FieldOffset(Offset = "0x80")]
		private int[] orderedVertices;

		// Token: 0x04000880 RID: 2176
		[Token(Token = "0x4000880")]
		[FieldOffset(Offset = "0x88")]
		private ObiPathSmoother smoother;

		// Token: 0x04000881 RID: 2177
		[Token(Token = "0x4000881")]
		[FieldOffset(Offset = "0x90")]
		[HideInInspector]
		[NonSerialized]
		public Mesh deformedMesh;
	}
}
