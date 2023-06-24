using System;
using Il2CppDummyDll;
using UnityEngine.Rendering.HighDefinition;

namespace Expanse
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	internal class ExpanseRenderer : SkyRenderer
	{
		// Token: 0x060003B9 RID: 953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xAF6520", Offset = "0xAF4B20", VA = "0x180AF6520", Slot = "4")]
		public override void Build()
		{
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xAF7460", Offset = "0xAF5A60", VA = "0x180AF7460", Slot = "5")]
		public override void Cleanup()
		{
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00005310 File Offset: 0x00003510
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xAF7E50", Offset = "0xAF6450", VA = "0x180AF7E50", Slot = "6")]
		protected override bool Update(BuiltinSkyParameters builtinParams)
		{
			return default(bool);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00005328 File Offset: 0x00003528
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xAF8100", Offset = "0xAF6700", VA = "0x180AF8100")]
		protected bool updateProceduralTextures(BuiltinSkyParameters builtinParams)
		{
			return default(bool);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xAF8480", Offset = "0xAF6A80", VA = "0x180AF8480")]
		private void updateCloudLayerGenerators(ExpanseSettings settings)
		{
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xAF8720", Offset = "0xAF6D20", VA = "0x180AF8720", Slot = "11")]
		public override void RenderSky(BuiltinSkyParameters builtinParams, bool renderForCubemap, bool renderSunDisk)
		{
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xAF8B80", Offset = "0xAF7180", VA = "0x180AF8B80")]
		public ExpanseRenderer()
		{
		}

		// Token: 0x040004A0 RID: 1184
		[Token(Token = "0x40004A0")]
		[FieldOffset(Offset = "0x18")]
		private int m_starHashCode;

		// Token: 0x040004A1 RID: 1185
		[Token(Token = "0x40004A1")]
		[FieldOffset(Offset = "0x1C")]
		private int m_nebulaHashCode;

		// Token: 0x040004A2 RID: 1186
		[Token(Token = "0x40004A2")]
		[FieldOffset(Offset = "0x20")]
		private StarGenerator m_starGenerator;

		// Token: 0x040004A3 RID: 1187
		[Token(Token = "0x40004A3")]
		[FieldOffset(Offset = "0x28")]
		private NebulaGenerator m_nebulaGenerator;

		// Token: 0x040004A4 RID: 1188
		[Token(Token = "0x40004A4")]
		[FieldOffset(Offset = "0x30")]
		private CloudGenerator[] m_cloudGenerators;

		// Token: 0x040004A5 RID: 1189
		[Token(Token = "0x40004A5")]
		[FieldOffset(Offset = "0x38")]
		private AtmosphereRenderer m_atmosphereRenderer;

		// Token: 0x040004A6 RID: 1190
		[Token(Token = "0x40004A6")]
		[FieldOffset(Offset = "0x40")]
		private CloudRenderer m_cloudRenderer;

		// Token: 0x040004A7 RID: 1191
		[Token(Token = "0x40004A7")]
		[FieldOffset(Offset = "0x48")]
		private DirectLightRenderer m_directLightRenderer;

		// Token: 0x040004A8 RID: 1192
		[Token(Token = "0x40004A8")]
		[FieldOffset(Offset = "0x50")]
		private CloudCompositor m_cloudCompositor;

		// Token: 0x040004A9 RID: 1193
		[Token(Token = "0x40004A9")]
		[FieldOffset(Offset = "0x58")]
		private SkyCompositor m_skyCompositor;

		// Token: 0x040004AA RID: 1194
		[Token(Token = "0x40004AA")]
		[FieldOffset(Offset = "0x60")]
		private IRenderer[] m_atmosphereArgs;

		// Token: 0x040004AB RID: 1195
		[Token(Token = "0x40004AB")]
		[FieldOffset(Offset = "0x68")]
		private IRenderer[] m_cloudCompositorArgs;

		// Token: 0x040004AC RID: 1196
		[Token(Token = "0x40004AC")]
		[FieldOffset(Offset = "0x70")]
		private IRenderer[] m_screenspaceArgs;

		// Token: 0x040004AD RID: 1197
		[Token(Token = "0x40004AD")]
		[FieldOffset(Offset = "0x78")]
		private IRenderer[] m_directLightArgs;

		// Token: 0x040004AE RID: 1198
		[Token(Token = "0x40004AE")]
		[FieldOffset(Offset = "0x80")]
		private IRenderer[] m_skyCompositorArgs;

		// Token: 0x040004AF RID: 1199
		[Token(Token = "0x40004AF")]
		[FieldOffset(Offset = "0x88")]
		private IRenderer[] m_skyCompositorCubemapArgs;

		// Token: 0x040004B0 RID: 1200
		[Token(Token = "0x40004B0")]
		[FieldOffset(Offset = "0x90")]
		private CameraSettingsBlock _cameraSettings;
	}
}
