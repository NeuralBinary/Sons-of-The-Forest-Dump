using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001A0 RID: 416
	[Token(Token = "0x20001A0")]
	[AddComponentMenu("Physics/Obi/Obi Instanced Particle Renderer", 1001)]
	[ExecuteInEditMode]
	[RequireComponent(typeof(ObiActor))]
	public class ObiInstancedParticleRenderer : MonoBehaviour
	{
		// Token: 0x060007CA RID: 1994 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x27E2770", Offset = "0x27E0D70", VA = "0x1827E2770")]
		public void OnEnable()
		{
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x27E2820", Offset = "0x27E0E20", VA = "0x1827E2820")]
		public void OnDisable()
		{
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x27E28D0", Offset = "0x27E0ED0", VA = "0x1827E28D0")]
		private void DrawParticles(ObiActor actor)
		{
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x27E3170", Offset = "0x27E1770", VA = "0x1827E3170")]
		public ObiInstancedParticleRenderer()
		{
		}

		// Token: 0x0400068B RID: 1675
		[Token(Token = "0x400068B")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker m_DrawParticlesPerfMarker;

		// Token: 0x0400068C RID: 1676
		[Token(Token = "0x400068C")]
		[FieldOffset(Offset = "0x20")]
		public bool render;

		// Token: 0x0400068D RID: 1677
		[Token(Token = "0x400068D")]
		[FieldOffset(Offset = "0x28")]
		public Mesh mesh;

		// Token: 0x0400068E RID: 1678
		[Token(Token = "0x400068E")]
		[FieldOffset(Offset = "0x30")]
		public Material material;

		// Token: 0x0400068F RID: 1679
		[Token(Token = "0x400068F")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 instanceScale;

		// Token: 0x04000690 RID: 1680
		[Token(Token = "0x4000690")]
		[FieldOffset(Offset = "0x48")]
		private List<Matrix4x4> matrices;

		// Token: 0x04000691 RID: 1681
		[Token(Token = "0x4000691")]
		[FieldOffset(Offset = "0x50")]
		private List<Vector4> colors;

		// Token: 0x04000692 RID: 1682
		[Token(Token = "0x4000692")]
		[FieldOffset(Offset = "0x58")]
		private MaterialPropertyBlock mpb;

		// Token: 0x04000693 RID: 1683
		[Token(Token = "0x4000693")]
		[FieldOffset(Offset = "0x60")]
		private int meshesPerBatch;

		// Token: 0x04000694 RID: 1684
		[Token(Token = "0x4000694")]
		[FieldOffset(Offset = "0x64")]
		private int batchCount;
	}
}
