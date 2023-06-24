using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020002FB RID: 763
	[Token(Token = "0x20002FB")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Other/Antialiasing")]
	[RequireComponent(typeof(Camera))]
	public class Antialiasing : PostEffectsBase
	{
		// Token: 0x06001446 RID: 5190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001446")]
		[Address(RVA = "0x3203590", Offset = "0x3201B90", VA = "0x183203590")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x00006AC8 File Offset: 0x00004CC8
		[Token(Token = "0x6001447")]
		[Address(RVA = "0x3203600", Offset = "0x3201C00", VA = "0x183203600", Slot = "8")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001448")]
		[Address(RVA = "0x32039D0", Offset = "0x3201FD0", VA = "0x1832039D0")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001449")]
		[Address(RVA = "0x3204150", Offset = "0x3202750", VA = "0x183204150")]
		public Antialiasing()
		{
		}

		// Token: 0x040013D2 RID: 5074
		[Token(Token = "0x40013D2")]
		[FieldOffset(Offset = "0x28")]
		public AAMode mode;

		// Token: 0x040013D3 RID: 5075
		[Token(Token = "0x40013D3")]
		[FieldOffset(Offset = "0x2C")]
		public bool showGeneratedNormals;

		// Token: 0x040013D4 RID: 5076
		[Token(Token = "0x40013D4")]
		[FieldOffset(Offset = "0x30")]
		public float offsetScale;

		// Token: 0x040013D5 RID: 5077
		[Token(Token = "0x40013D5")]
		[FieldOffset(Offset = "0x34")]
		public float blurRadius;

		// Token: 0x040013D6 RID: 5078
		[Token(Token = "0x40013D6")]
		[FieldOffset(Offset = "0x38")]
		public float edgeThresholdMin;

		// Token: 0x040013D7 RID: 5079
		[Token(Token = "0x40013D7")]
		[FieldOffset(Offset = "0x3C")]
		public float edgeThreshold;

		// Token: 0x040013D8 RID: 5080
		[Token(Token = "0x40013D8")]
		[FieldOffset(Offset = "0x40")]
		public float edgeSharpness;

		// Token: 0x040013D9 RID: 5081
		[Token(Token = "0x40013D9")]
		[FieldOffset(Offset = "0x44")]
		public bool dlaaSharp;

		// Token: 0x040013DA RID: 5082
		[Token(Token = "0x40013DA")]
		[FieldOffset(Offset = "0x48")]
		public Shader ssaaShader;

		// Token: 0x040013DB RID: 5083
		[Token(Token = "0x40013DB")]
		[FieldOffset(Offset = "0x50")]
		private Material ssaa;

		// Token: 0x040013DC RID: 5084
		[Token(Token = "0x40013DC")]
		[FieldOffset(Offset = "0x58")]
		public Shader dlaaShader;

		// Token: 0x040013DD RID: 5085
		[Token(Token = "0x40013DD")]
		[FieldOffset(Offset = "0x60")]
		private Material dlaa;

		// Token: 0x040013DE RID: 5086
		[Token(Token = "0x40013DE")]
		[FieldOffset(Offset = "0x68")]
		public Shader nfaaShader;

		// Token: 0x040013DF RID: 5087
		[Token(Token = "0x40013DF")]
		[FieldOffset(Offset = "0x70")]
		private Material nfaa;

		// Token: 0x040013E0 RID: 5088
		[Token(Token = "0x40013E0")]
		[FieldOffset(Offset = "0x78")]
		public Shader shaderFXAAPreset2;

		// Token: 0x040013E1 RID: 5089
		[Token(Token = "0x40013E1")]
		[FieldOffset(Offset = "0x80")]
		private Material materialFXAAPreset2;

		// Token: 0x040013E2 RID: 5090
		[Token(Token = "0x40013E2")]
		[FieldOffset(Offset = "0x88")]
		public Shader shaderFXAAPreset3;

		// Token: 0x040013E3 RID: 5091
		[Token(Token = "0x40013E3")]
		[FieldOffset(Offset = "0x90")]
		private Material materialFXAAPreset3;

		// Token: 0x040013E4 RID: 5092
		[Token(Token = "0x40013E4")]
		[FieldOffset(Offset = "0x98")]
		public Shader shaderFXAAII;

		// Token: 0x040013E5 RID: 5093
		[Token(Token = "0x40013E5")]
		[FieldOffset(Offset = "0xA0")]
		private Material materialFXAAII;

		// Token: 0x040013E6 RID: 5094
		[Token(Token = "0x40013E6")]
		[FieldOffset(Offset = "0xA8")]
		public Shader shaderFXAAIII;

		// Token: 0x040013E7 RID: 5095
		[Token(Token = "0x40013E7")]
		[FieldOffset(Offset = "0xB0")]
		private Material materialFXAAIII;
	}
}
