using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	[AddComponentMenu("Physics/Obi/Obi Skinned Cloth Renderer", 905)]
	[ExecuteInEditMode]
	[RequireComponent(typeof(ObiSkinnedCloth))]
	public class ObiSkinnedClothRenderer : ObiClothRendererBase
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0000281C File Offset: 0x00000A1C
		[Token(Token = "0x17000057")]
		public override Matrix4x4 renderMatrix
		{
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x2757340", Offset = "0x2755940", VA = "0x182757340", Slot = "5")]
			get
			{
				return default(Matrix4x4);
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2757600", Offset = "0x2755C00", VA = "0x182757600", Slot = "6")]
		protected override void Awake()
		{
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x27576A0", Offset = "0x2755CA0", VA = "0x1827576A0", Slot = "12")]
		protected override void OnBlueprintLoaded(ObiActor actor, ObiActorBlueprint blueprint)
		{
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x27578B0", Offset = "0x2755EB0", VA = "0x1827578B0", Slot = "14")]
		protected override void SetupUpdate()
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x2757BC0", Offset = "0x27561C0", VA = "0x182757BC0", Slot = "16")]
		protected override void UpdateInactiveVertex(ObiSolver solver, int actorIndex, int meshVertexIndex)
		{
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x2758000", Offset = "0x2756600", VA = "0x182758000", Slot = "17")]
		public override void UpdateRenderer(ObiActor actor)
		{
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x2758430", Offset = "0x2756A30", VA = "0x182758430")]
		public ObiSkinnedClothRenderer()
		{
		}

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0xB0")]
		private SkinnedMeshRenderer skin;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0xB8")]
		private Matrix4x4 local2Root;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0xF8")]
		private List<Material> rendererMaterials;
	}
}
