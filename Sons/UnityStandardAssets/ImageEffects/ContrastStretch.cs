using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000301 RID: 769
	[Token(Token = "0x2000301")]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Stretch")]
	[ExecuteInEditMode]
	public class ContrastStretch : MonoBehaviour
	{
		// Token: 0x170002CF RID: 719
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002CF")]
		protected Material materialLum
		{
			[Token(Token = "0x600145E")]
			[Address(RVA = "0x32079D0", Offset = "0x3205FD0", VA = "0x1832079D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D0")]
		protected Material materialReduce
		{
			[Token(Token = "0x600145F")]
			[Address(RVA = "0x3207B70", Offset = "0x3206170", VA = "0x183207B70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D1")]
		protected Material materialAdapt
		{
			[Token(Token = "0x6001460")]
			[Address(RVA = "0x3207D10", Offset = "0x3206310", VA = "0x183207D10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D2")]
		protected Material materialApply
		{
			[Token(Token = "0x6001461")]
			[Address(RVA = "0x3207EB0", Offset = "0x32064B0", VA = "0x183207EB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001462")]
		[Address(RVA = "0x3208050", Offset = "0x3206650", VA = "0x183208050")]
		private void Start()
		{
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001463")]
		[Address(RVA = "0x3208190", Offset = "0x3206790", VA = "0x183208190")]
		private void OnEnable()
		{
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001464")]
		[Address(RVA = "0x3208350", Offset = "0x3206950", VA = "0x183208350")]
		private void OnDisable()
		{
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001465")]
		[Address(RVA = "0x3208940", Offset = "0x3206F40", VA = "0x183208940")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001466")]
		[Address(RVA = "0x3208E40", Offset = "0x3207440", VA = "0x183208E40")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001467")]
		[Address(RVA = "0x32090C0", Offset = "0x32076C0", VA = "0x1832090C0")]
		public ContrastStretch()
		{
		}

		// Token: 0x0400140F RID: 5135
		[Token(Token = "0x400140F")]
		[FieldOffset(Offset = "0x20")]
		public float adaptationSpeed;

		// Token: 0x04001410 RID: 5136
		[Token(Token = "0x4001410")]
		[FieldOffset(Offset = "0x24")]
		public float limitMinimum;

		// Token: 0x04001411 RID: 5137
		[Token(Token = "0x4001411")]
		[FieldOffset(Offset = "0x28")]
		public float limitMaximum;

		// Token: 0x04001412 RID: 5138
		[Token(Token = "0x4001412")]
		[FieldOffset(Offset = "0x30")]
		private RenderTexture[] adaptRenderTex;

		// Token: 0x04001413 RID: 5139
		[Token(Token = "0x4001413")]
		[FieldOffset(Offset = "0x38")]
		private int curAdaptIndex;

		// Token: 0x04001414 RID: 5140
		[Token(Token = "0x4001414")]
		[FieldOffset(Offset = "0x40")]
		public Shader shaderLum;

		// Token: 0x04001415 RID: 5141
		[Token(Token = "0x4001415")]
		[FieldOffset(Offset = "0x48")]
		private Material m_materialLum;

		// Token: 0x04001416 RID: 5142
		[Token(Token = "0x4001416")]
		[FieldOffset(Offset = "0x50")]
		public Shader shaderReduce;

		// Token: 0x04001417 RID: 5143
		[Token(Token = "0x4001417")]
		[FieldOffset(Offset = "0x58")]
		private Material m_materialReduce;

		// Token: 0x04001418 RID: 5144
		[Token(Token = "0x4001418")]
		[FieldOffset(Offset = "0x60")]
		public Shader shaderAdapt;

		// Token: 0x04001419 RID: 5145
		[Token(Token = "0x4001419")]
		[FieldOffset(Offset = "0x68")]
		private Material m_materialAdapt;

		// Token: 0x0400141A RID: 5146
		[Token(Token = "0x400141A")]
		[FieldOffset(Offset = "0x70")]
		public Shader shaderApply;

		// Token: 0x0400141B RID: 5147
		[Token(Token = "0x400141B")]
		[FieldOffset(Offset = "0x78")]
		private Material m_materialApply;
	}
}
