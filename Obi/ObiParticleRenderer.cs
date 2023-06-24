using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001A1 RID: 417
	[Token(Token = "0x20001A1")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(ObiActor))]
	[AddComponentMenu("Physics/Obi/Obi Particle Renderer", 1000)]
	public class ObiParticleRenderer : MonoBehaviour
	{
		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000108")]
		public IEnumerable<Mesh> ParticleMeshes
		{
			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x27E33D0", Offset = "0x27E19D0", VA = "0x1827E33D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000109")]
		public Material ParticleMaterial
		{
			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x27E33F0", Offset = "0x27E19F0", VA = "0x1827E33F0")]
		public void OnEnable()
		{
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x27E3500", Offset = "0x27E1B00", VA = "0x1827E3500")]
		public void OnDisable()
		{
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x27E35F0", Offset = "0x27E1BF0", VA = "0x1827E35F0")]
		private void CreateMaterialIfNeeded()
		{
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x27E3A00", Offset = "0x27E2000", VA = "0x1827E3A00")]
		private void DrawParticles(ObiActor actor)
		{
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x27E3CB0", Offset = "0x27E22B0", VA = "0x1827E3CB0")]
		private void DrawParticles()
		{
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x27E40F0", Offset = "0x27E26F0", VA = "0x1827E40F0")]
		public ObiParticleRenderer()
		{
		}

		// Token: 0x04000695 RID: 1685
		[Token(Token = "0x4000695")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker m_DrawParticlesPerfMarker;

		// Token: 0x04000696 RID: 1686
		[Token(Token = "0x4000696")]
		[FieldOffset(Offset = "0x20")]
		public bool render;

		// Token: 0x04000697 RID: 1687
		[Token(Token = "0x4000697")]
		[FieldOffset(Offset = "0x28")]
		public Shader shader;

		// Token: 0x04000698 RID: 1688
		[Token(Token = "0x4000698")]
		[FieldOffset(Offset = "0x30")]
		public Color particleColor;

		// Token: 0x04000699 RID: 1689
		[Token(Token = "0x4000699")]
		[FieldOffset(Offset = "0x40")]
		public float radiusScale;

		// Token: 0x0400069A RID: 1690
		[Token(Token = "0x400069A")]
		[FieldOffset(Offset = "0x48")]
		private Material material;

		// Token: 0x0400069B RID: 1691
		[Token(Token = "0x400069B")]
		[FieldOffset(Offset = "0x50")]
		private ParticleImpostorRendering impostors;
	}
}
