using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001A2 RID: 418
	[Token(Token = "0x20001A2")]
	public class ParticleImpostorRendering
	{
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700010A")]
		public IEnumerable<Mesh> Meshes
		{
			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x27E41F0", Offset = "0x27E27F0", VA = "0x1827E41F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x27E42B0", Offset = "0x27E28B0", VA = "0x1827E42B0")]
		private void Apply(Mesh mesh)
		{
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x27E44E0", Offset = "0x27E2AE0", VA = "0x1827E44E0")]
		public void ClearMeshes()
		{
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x27E46F0", Offset = "0x27E2CF0", VA = "0x1827E46F0")]
		public void UpdateMeshes(IObiParticleCollection collection)
		{
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x27E58B0", Offset = "0x27E3EB0", VA = "0x1827E58B0")]
		public ParticleImpostorRendering()
		{
		}

		// Token: 0x0400069C RID: 1692
		[Token(Token = "0x400069C")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker m_ParticlesToMeshPerfMarker;

		// Token: 0x0400069D RID: 1693
		[Token(Token = "0x400069D")]
		[FieldOffset(Offset = "0x10")]
		private List<Mesh> meshes;

		// Token: 0x0400069E RID: 1694
		[Token(Token = "0x400069E")]
		[FieldOffset(Offset = "0x18")]
		private List<Vector3> vertices;

		// Token: 0x0400069F RID: 1695
		[Token(Token = "0x400069F")]
		[FieldOffset(Offset = "0x20")]
		private List<Vector3> normals;

		// Token: 0x040006A0 RID: 1696
		[Token(Token = "0x40006A0")]
		[FieldOffset(Offset = "0x28")]
		private List<Color> colors;

		// Token: 0x040006A1 RID: 1697
		[Token(Token = "0x40006A1")]
		[FieldOffset(Offset = "0x30")]
		private List<int> triangles;

		// Token: 0x040006A2 RID: 1698
		[Token(Token = "0x40006A2")]
		[FieldOffset(Offset = "0x38")]
		private List<Vector4> anisotropy1;

		// Token: 0x040006A3 RID: 1699
		[Token(Token = "0x40006A3")]
		[FieldOffset(Offset = "0x40")]
		private List<Vector4> anisotropy2;

		// Token: 0x040006A4 RID: 1700
		[Token(Token = "0x40006A4")]
		[FieldOffset(Offset = "0x48")]
		private List<Vector4> anisotropy3;

		// Token: 0x040006A5 RID: 1701
		[Token(Token = "0x40006A5")]
		[FieldOffset(Offset = "0x50")]
		private int particlesPerDrawcall;

		// Token: 0x040006A6 RID: 1702
		[Token(Token = "0x40006A6")]
		[FieldOffset(Offset = "0x54")]
		private int drawcallCount;

		// Token: 0x040006A7 RID: 1703
		[Token(Token = "0x40006A7")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 particleOffset0;

		// Token: 0x040006A8 RID: 1704
		[Token(Token = "0x40006A8")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 particleOffset1;

		// Token: 0x040006A9 RID: 1705
		[Token(Token = "0x40006A9")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 particleOffset2;

		// Token: 0x040006AA RID: 1706
		[Token(Token = "0x40006AA")]
		[FieldOffset(Offset = "0x7C")]
		private Vector3 particleOffset3;
	}
}
