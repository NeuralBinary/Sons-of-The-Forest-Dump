using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200030F RID: 783
	[Token(Token = "0x200030F")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Stretch")]
	public class ContrastStretch : MonoBehaviour
	{
		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C7")]
		protected Material materialLum
		{
			[Token(Token = "0x6001433")]
			[Address(RVA = "0x2C61B00", Offset = "0x2C60B00", VA = "0x182C61B00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C8")]
		protected Material materialReduce
		{
			[Token(Token = "0x6001434")]
			[Address(RVA = "0x2C61BD0", Offset = "0x2C60BD0", VA = "0x182C61BD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C9")]
		protected Material materialAdapt
		{
			[Token(Token = "0x6001435")]
			[Address(RVA = "0x2C61960", Offset = "0x2C60960", VA = "0x182C61960")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002CA")]
		protected Material materialApply
		{
			[Token(Token = "0x6001436")]
			[Address(RVA = "0x2C61A30", Offset = "0x2C60A30", VA = "0x182C61A30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001437")]
		[Address(RVA = "0x2C61860", Offset = "0x2C60860", VA = "0x182C61860")]
		private void Start()
		{
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001438")]
		[Address(RVA = "0x2C61400", Offset = "0x2C60400", VA = "0x182C61400")]
		private void OnEnable()
		{
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001439")]
		[Address(RVA = "0x2C61200", Offset = "0x2C60200", VA = "0x182C61200")]
		private void OnDisable()
		{
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600143A")]
		[Address(RVA = "0x2C61560", Offset = "0x2C60560", VA = "0x182C61560")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600143B")]
		[Address(RVA = "0x2C61010", Offset = "0x2C60010", VA = "0x182C61010")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600143C")]
		[Address(RVA = "0x2C618F0", Offset = "0x2C608F0", VA = "0x182C618F0")]
		public ContrastStretch()
		{
		}

		// Token: 0x040013F1 RID: 5105
		[Token(Token = "0x40013F1")]
		[FieldOffset(Offset = "0x20")]
		public float adaptationSpeed;

		// Token: 0x040013F2 RID: 5106
		[Token(Token = "0x40013F2")]
		[FieldOffset(Offset = "0x24")]
		public float limitMinimum;

		// Token: 0x040013F3 RID: 5107
		[Token(Token = "0x40013F3")]
		[FieldOffset(Offset = "0x28")]
		public float limitMaximum;

		// Token: 0x040013F4 RID: 5108
		[Token(Token = "0x40013F4")]
		[FieldOffset(Offset = "0x30")]
		private RenderTexture[] adaptRenderTex;

		// Token: 0x040013F5 RID: 5109
		[Token(Token = "0x40013F5")]
		[FieldOffset(Offset = "0x38")]
		private int curAdaptIndex;

		// Token: 0x040013F6 RID: 5110
		[Token(Token = "0x40013F6")]
		[FieldOffset(Offset = "0x40")]
		public Shader shaderLum;

		// Token: 0x040013F7 RID: 5111
		[Token(Token = "0x40013F7")]
		[FieldOffset(Offset = "0x48")]
		private Material m_materialLum;

		// Token: 0x040013F8 RID: 5112
		[Token(Token = "0x40013F8")]
		[FieldOffset(Offset = "0x50")]
		public Shader shaderReduce;

		// Token: 0x040013F9 RID: 5113
		[Token(Token = "0x40013F9")]
		[FieldOffset(Offset = "0x58")]
		private Material m_materialReduce;

		// Token: 0x040013FA RID: 5114
		[Token(Token = "0x40013FA")]
		[FieldOffset(Offset = "0x60")]
		public Shader shaderAdapt;

		// Token: 0x040013FB RID: 5115
		[Token(Token = "0x40013FB")]
		[FieldOffset(Offset = "0x68")]
		private Material m_materialAdapt;

		// Token: 0x040013FC RID: 5116
		[Token(Token = "0x40013FC")]
		[FieldOffset(Offset = "0x70")]
		public Shader shaderApply;

		// Token: 0x040013FD RID: 5117
		[Token(Token = "0x40013FD")]
		[FieldOffset(Offset = "0x78")]
		private Material m_materialApply;
	}
}
