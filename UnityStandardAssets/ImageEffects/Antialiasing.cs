using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000309 RID: 777
	[Token(Token = "0x2000309")]
	[AddComponentMenu("Image Effects/Other/Antialiasing")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class Antialiasing : PostEffectsBase
	{
		// Token: 0x0600141B RID: 5147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600141B")]
		[Address(RVA = "0x2C5E730", Offset = "0x2C5D730", VA = "0x182C5E730")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x00006888 File Offset: 0x00004A88
		[Token(Token = "0x600141C")]
		[Address(RVA = "0x2C5E550", Offset = "0x2C5D550", VA = "0x182C5E550", Slot = "8")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600141D")]
		[Address(RVA = "0x2C5E7A0", Offset = "0x2C5D7A0", VA = "0x182C5E7A0")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600141E")]
		[Address(RVA = "0x2C5EC70", Offset = "0x2C5DC70", VA = "0x182C5EC70")]
		public Antialiasing()
		{
		}

		// Token: 0x040013B4 RID: 5044
		[Token(Token = "0x40013B4")]
		[FieldOffset(Offset = "0x28")]
		public AAMode mode;

		// Token: 0x040013B5 RID: 5045
		[Token(Token = "0x40013B5")]
		[FieldOffset(Offset = "0x2C")]
		public bool showGeneratedNormals;

		// Token: 0x040013B6 RID: 5046
		[Token(Token = "0x40013B6")]
		[FieldOffset(Offset = "0x30")]
		public float offsetScale;

		// Token: 0x040013B7 RID: 5047
		[Token(Token = "0x40013B7")]
		[FieldOffset(Offset = "0x34")]
		public float blurRadius;

		// Token: 0x040013B8 RID: 5048
		[Token(Token = "0x40013B8")]
		[FieldOffset(Offset = "0x38")]
		public float edgeThresholdMin;

		// Token: 0x040013B9 RID: 5049
		[Token(Token = "0x40013B9")]
		[FieldOffset(Offset = "0x3C")]
		public float edgeThreshold;

		// Token: 0x040013BA RID: 5050
		[Token(Token = "0x40013BA")]
		[FieldOffset(Offset = "0x40")]
		public float edgeSharpness;

		// Token: 0x040013BB RID: 5051
		[Token(Token = "0x40013BB")]
		[FieldOffset(Offset = "0x44")]
		public bool dlaaSharp;

		// Token: 0x040013BC RID: 5052
		[Token(Token = "0x40013BC")]
		[FieldOffset(Offset = "0x48")]
		public Shader ssaaShader;

		// Token: 0x040013BD RID: 5053
		[Token(Token = "0x40013BD")]
		[FieldOffset(Offset = "0x50")]
		private Material ssaa;

		// Token: 0x040013BE RID: 5054
		[Token(Token = "0x40013BE")]
		[FieldOffset(Offset = "0x58")]
		public Shader dlaaShader;

		// Token: 0x040013BF RID: 5055
		[Token(Token = "0x40013BF")]
		[FieldOffset(Offset = "0x60")]
		private Material dlaa;

		// Token: 0x040013C0 RID: 5056
		[Token(Token = "0x40013C0")]
		[FieldOffset(Offset = "0x68")]
		public Shader nfaaShader;

		// Token: 0x040013C1 RID: 5057
		[Token(Token = "0x40013C1")]
		[FieldOffset(Offset = "0x70")]
		private Material nfaa;

		// Token: 0x040013C2 RID: 5058
		[Token(Token = "0x40013C2")]
		[FieldOffset(Offset = "0x78")]
		public Shader shaderFXAAPreset2;

		// Token: 0x040013C3 RID: 5059
		[Token(Token = "0x40013C3")]
		[FieldOffset(Offset = "0x80")]
		private Material materialFXAAPreset2;

		// Token: 0x040013C4 RID: 5060
		[Token(Token = "0x40013C4")]
		[FieldOffset(Offset = "0x88")]
		public Shader shaderFXAAPreset3;

		// Token: 0x040013C5 RID: 5061
		[Token(Token = "0x40013C5")]
		[FieldOffset(Offset = "0x90")]
		private Material materialFXAAPreset3;

		// Token: 0x040013C6 RID: 5062
		[Token(Token = "0x40013C6")]
		[FieldOffset(Offset = "0x98")]
		public Shader shaderFXAAII;

		// Token: 0x040013C7 RID: 5063
		[Token(Token = "0x40013C7")]
		[FieldOffset(Offset = "0xA0")]
		private Material materialFXAAII;

		// Token: 0x040013C8 RID: 5064
		[Token(Token = "0x40013C8")]
		[FieldOffset(Offset = "0xA8")]
		public Shader shaderFXAAIII;

		// Token: 0x040013C9 RID: 5065
		[Token(Token = "0x40013C9")]
		[FieldOffset(Offset = "0xB0")]
		private Material materialFXAAIII;
	}
}
