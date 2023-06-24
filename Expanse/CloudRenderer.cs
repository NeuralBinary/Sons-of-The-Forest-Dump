using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

namespace Expanse
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	public class CloudRenderer : IRenderer
	{
		// Token: 0x060002EF RID: 751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xADBC40", Offset = "0xADA240", VA = "0x180ADBC40", Slot = "5")]
		public override void build()
		{
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xADCA30", Offset = "0xADB030", VA = "0x180ADCA30", Slot = "6")]
		public override void cleanup()
		{
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xADCC70", Offset = "0xADB270", VA = "0x180ADCC70")]
		private void allocateFullscreenFramebuffers(Vector2Int res, Vector2Int fullRes, int numLayers)
		{
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xADD0A0", Offset = "0xADB6A0", VA = "0x180ADD0A0")]
		private void allocateReflectionFramebuffers(Vector2Int res, int numLayers)
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xADD300", Offset = "0xADB900", VA = "0x180ADD300")]
		private void allocateShadowMapFramebuffers(int shadowBodies, int numLayers, Vector2Int resolution)
		{
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xADD660", Offset = "0xADBC60", VA = "0x180ADD660")]
		private void cleanupFullscreenFramebuffers()
		{
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xADD9F0", Offset = "0xADBFF0", VA = "0x180ADD9F0")]
		private void cleanupReflectionFramebuffers()
		{
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xADDB80", Offset = "0xADC180", VA = "0x180ADDB80")]
		private void cleanupShadowMapFramebuffers()
		{
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xADDD50", Offset = "0xADC350", VA = "0x180ADDD50")]
		private void buildComputeShaders()
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xADDEB0", Offset = "0xADC4B0", VA = "0x180ADDEB0", Slot = "4")]
		public override void render(BuiltinSkyParameters builtinParams, IRenderer[] dependencies)
		{
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xADECB0", Offset = "0xADD2B0", VA = "0x180ADECB0")]
		private void renderLayer(BuiltinSkyParameters builtinParams, int index, CloudGenerator generator, ComputeShader cs)
		{
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xADFC40", Offset = "0xADE240", VA = "0x180ADFC40")]
		private void renderLayerShadowMap(CommandBuffer cmd, int layerIndex, int layerShadowIndex, int bodyShadowIndex, CloudGenerator generator, ComputeShader cs)
		{
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xAE0010", Offset = "0xADE610", VA = "0x180AE0010")]
		private void checkAndResizeFullscreenFramebuffers(Vector2 screenSize, float subres)
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xAE02C0", Offset = "0xADE8C0", VA = "0x180AE02C0")]
		private void checkAndResizeShadowFramebuffers()
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xAE04B0", Offset = "0xADEAB0", VA = "0x180AE04B0")]
		private void writeGameplayQueriesNullResult()
		{
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xAE0740", Offset = "0xADED40", VA = "0x180AE0740")]
		private void copyGameplayQueriesToBuffer()
		{
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xAE09B0", Offset = "0xADEFB0", VA = "0x180AE09B0")]
		private void onGameplayBufferReadback(AsyncGPUReadbackRequest r)
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x6000300")]
		[Address(RVA = "0xAE0C60", Offset = "0xADF260", VA = "0x180AE0C60", Slot = "7")]
		public override IReadOnlyCollection<string> getTextureNames()
		{
			return null;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000301")]
		[Address(RVA = "0xAE0CB0", Offset = "0xADF2B0", VA = "0x180AE0CB0", Slot = "8")]
		public override void setTexture(string texture, string shaderVariable, MaterialPropertyBlock propertyBlock)
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000302")]
		[Address(RVA = "0xAE0D50", Offset = "0xADF350", VA = "0x180AE0D50", Slot = "9")]
		public override void setTexture(string texture, string shaderVariable, ComputeShader computeShader, int kernelHandle)
		{
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000303")]
		[Address(RVA = "0xAE0E00", Offset = "0xADF400", VA = "0x180AE0E00", Slot = "10")]
		public override void setTexture(string texture, string shaderVariable, CommandBuffer cmd)
		{
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000304")]
		[Address(RVA = "0xAE0EE0", Offset = "0xADF4E0", VA = "0x180AE0EE0", Slot = "11")]
		public override void setTexture(string texture, int shaderVariable, CommandBuffer cmd)
		{
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000305")]
		[Address(RVA = "0xAC8E30", Offset = "0xAC7430", VA = "0x180AC8E30", Slot = "12")]
		public override void setTextureResolution(string texture, string shaderVariable, MaterialPropertyBlock propertyBlock)
		{
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000306")]
		[Address(RVA = "0xAC8ED0", Offset = "0xAC74D0", VA = "0x180AC8ED0", Slot = "13")]
		public override void setTextureResolution(string texture, string shaderVariable, ComputeShader computeShader)
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000307")]
		[Address(RVA = "0xAC8F70", Offset = "0xAC7570", VA = "0x180AC8F70", Slot = "14")]
		public override void setTextureResolution(string texture, string shaderVariable, CommandBuffer cmd)
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x000050B8 File Offset: 0x000032B8
		[Token(Token = "0x6000308")]
		[Address(RVA = "0xAE1000", Offset = "0xADF600", VA = "0x180AE1000", Slot = "15")]
		public override Vector3 getTextureResolution(string texture)
		{
			return default(Vector3);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x000050D0 File Offset: 0x000032D0
		[Token(Token = "0x6000309")]
		[Address(RVA = "0xAE11D0", Offset = "0xADF7D0", VA = "0x180AE11D0")]
		public Vector2Int getShadowmapResolution()
		{
			return default(Vector2Int);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030A")]
		[Address(RVA = "0xAE11E0", Offset = "0xADF7E0", VA = "0x180AE11E0")]
		private void setFullscreenShaderVariables(ComputeShader cs, BuiltinSkyParameters builtinParams, int index)
		{
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030B")]
		[Address(RVA = "0xAE1570", Offset = "0xADFB70", VA = "0x180AE1570")]
		private void setShadowMapShaderVariables(ComputeShader cs, int handleShadowMap, int layerIndex, int layerShadowIndex, int bodyIndex)
		{
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030C")]
		[Address(RVA = "0xAE16E0", Offset = "0xADFCE0", VA = "0x180AE16E0")]
		private void setNoiseTextures(CommandBuffer cmd, CloudGenerator generator, UniversalCloudLayer layer)
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030D")]
		[Address(RVA = "0xAE18B0", Offset = "0xADFEB0", VA = "0x180AE18B0")]
		private void setNoiseTexture(CommandBuffer cmd, CloudGenerator generator, UniversalCloudLayer layer, int noiseLayerIndex, string layerName, CloudDatatypes.CloudNoiseLayer layerType)
		{
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030E")]
		[Address(RVA = "0xAE23F0", Offset = "0xAE09F0", VA = "0x180AE23F0")]
		public CloudRenderer()
		{
		}

		// Token: 0x0400033D RID: 829
		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, RTHandle[]> m_framebuffers;

		// Token: 0x0400033E RID: 830
		[Token(Token = "0x400033E")]
		private const string kLightingFramebuffer = "cloudLighting";

		// Token: 0x0400033F RID: 831
		[Token(Token = "0x400033F")]
		private const string kTransmittanceHitFramebuffer = "cloudTransmittanceAndHit";

		// Token: 0x04000340 RID: 832
		[Token(Token = "0x4000340")]
		private const string kGBuffer = "cloudGeometry";

		// Token: 0x04000341 RID: 833
		[Token(Token = "0x4000341")]
		private const string kMotionVectorsBuffer = "motionVectors";

		// Token: 0x04000342 RID: 834
		[Token(Token = "0x4000342")]
		[FieldOffset(Offset = "0x18")]
		private string[] kShadowFramebuffer;

		// Token: 0x04000343 RID: 835
		[Token(Token = "0x4000343")]
		private const string kReflectionFramebuffer = "cloudReflection";

		// Token: 0x04000344 RID: 836
		[Token(Token = "0x4000344")]
		private const string kReflectionTFramebuffer = "cloudReflectionT";

		// Token: 0x04000345 RID: 837
		[Token(Token = "0x4000345")]
		private const int kFinalFramebuffer = 0;

		// Token: 0x04000346 RID: 838
		[Token(Token = "0x4000346")]
		private const int kTempFramebuffer = 1;

		// Token: 0x04000347 RID: 839
		[Token(Token = "0x4000347")]
		[FieldOffset(Offset = "0x20")]
		private ProfilingSampler[] m_gbufferProfilingSamplers;

		// Token: 0x04000348 RID: 840
		[Token(Token = "0x4000348")]
		[FieldOffset(Offset = "0x28")]
		private ProfilingSampler[] m_fullScreenProfilingSamplers;

		// Token: 0x04000349 RID: 841
		[Token(Token = "0x4000349")]
		[FieldOffset(Offset = "0x30")]
		private ProfilingSampler[] m_reprojectionProfilingSamplers;

		// Token: 0x0400034A RID: 842
		[Token(Token = "0x400034A")]
		[FieldOffset(Offset = "0x38")]
		private ProfilingSampler[] m_reflectionProfilingSamplers;

		// Token: 0x0400034B RID: 843
		[Token(Token = "0x400034B")]
		[FieldOffset(Offset = "0x40")]
		private ProfilingSampler[] m_shadowProfilingSamplers;

		// Token: 0x0400034C RID: 844
		[Token(Token = "0x400034C")]
		[FieldOffset(Offset = "0x48")]
		private ProfilingSampler m_motionVectorsProfilingSampler;

		// Token: 0x0400034D RID: 845
		[Token(Token = "0x400034D")]
		[FieldOffset(Offset = "0x50")]
		private ComputeShader[,] m_CS;

		// Token: 0x0400034E RID: 846
		[Token(Token = "0x400034E")]
		private const string kFullscreenKernel = "FULLSCREEN";

		// Token: 0x0400034F RID: 847
		[Token(Token = "0x400034F")]
		private const string kReprojectKernel = "REPROJECT";

		// Token: 0x04000350 RID: 848
		[Token(Token = "0x4000350")]
		private const string kShadowMapKernel = "SHADOWMAP";

		// Token: 0x04000351 RID: 849
		[Token(Token = "0x4000351")]
		private const string kReflectionKernel = "REFLECTION";

		// Token: 0x04000352 RID: 850
		[Token(Token = "0x4000352")]
		private const string kLightingFramebufferTexture = "_LightingFramebuffers";

		// Token: 0x04000353 RID: 851
		[Token(Token = "0x4000353")]
		private const string kTransmittanceHitFramebufferTexture = "_TransmittanceHitFramebuffers";

		// Token: 0x04000354 RID: 852
		[Token(Token = "0x4000354")]
		private const string kGBufferTexture = "_GBuffer";

		// Token: 0x04000355 RID: 853
		[Token(Token = "0x4000355")]
		private const string kReflectionTFramebufferTexture = "_ReflectionT";

		// Token: 0x04000356 RID: 854
		[Token(Token = "0x4000356")]
		private const string kMotionVectorTextureCopy = "_CameraMotionVectorsTexture_Copy";

		// Token: 0x04000357 RID: 855
		[Token(Token = "0x4000357")]
		private const string kPrevLightingFramebufferTexture = "_PrevLightingFramebuffers";

		// Token: 0x04000358 RID: 856
		[Token(Token = "0x4000358")]
		private const string kPrevTransmittanceHitFramebufferTexture = "_PrevTransmittanceHitFramebuffers";

		// Token: 0x04000359 RID: 857
		[Token(Token = "0x4000359")]
		private const string kShadowMapFramebufferTexture = "_ShadowMapFramebuffers";

		// Token: 0x0400035A RID: 858
		[Token(Token = "0x400035A")]
		[FieldOffset(Offset = "0x58")]
		private int m_enabledLayers;

		// Token: 0x0400035B RID: 859
		[Token(Token = "0x400035B")]
		[FieldOffset(Offset = "0x5C")]
		private int m_shadowLayers;

		// Token: 0x0400035C RID: 860
		[Token(Token = "0x400035C")]
		[FieldOffset(Offset = "0x60")]
		private int m_shadowBodies;

		// Token: 0x0400035D RID: 861
		[Token(Token = "0x400035D")]
		[FieldOffset(Offset = "0x64")]
		private Vector2Int m_shadowMapResolution;

		// Token: 0x0400035E RID: 862
		[Token(Token = "0x400035E")]
		[FieldOffset(Offset = "0x6C")]
		private Matrix4x4 m_previousViewMatrix;

		// Token: 0x0400035F RID: 863
		[Token(Token = "0x400035F")]
		[FieldOffset(Offset = "0xAC")]
		private Matrix4x4 m_previousProjMatrix;

		// Token: 0x04000360 RID: 864
		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0xEC")]
		private Vector2 m_subresolution;

		// Token: 0x04000361 RID: 865
		[Token(Token = "0x4000361")]
		[FieldOffset(Offset = "0xF8")]
		private Material m_motionVectorsMaterial;

		// Token: 0x04000362 RID: 866
		[Token(Token = "0x4000362")]
		[FieldOffset(Offset = "0x100")]
		private MaterialPropertyBlock m_motionVectorsPropertyBlock;

		// Token: 0x04000363 RID: 867
		[Token(Token = "0x4000363")]
		[FieldOffset(Offset = "0x108")]
		private string kMotionVectorShaderPath;

		// Token: 0x04000364 RID: 868
		[Token(Token = "0x4000364")]
		[FieldOffset(Offset = "0x110")]
		private ComputeBuffer m_gameplayQueryBuffer;

		// Token: 0x04000365 RID: 869
		[Token(Token = "0x4000365")]
		private const string kGameplayQueriesKernel = "GAMEPLAY";

		// Token: 0x04000366 RID: 870
		[Token(Token = "0x4000366")]
		private const string kGameplayQueryBuffer = "_GameplayQueryBuffer";

		// Token: 0x04000367 RID: 871
		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x118")]
		private ProfilingSampler m_gameplayProfilingSampler;

		// Token: 0x04000368 RID: 872
		[Token(Token = "0x4000368")]
		[FieldOffset(Offset = "0x120")]
		private Vector2Int kReflectionProbeResolution;

		// Token: 0x04000369 RID: 873
		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0x128")]
		private int kReflectionReprojectionFrames;

		// Token: 0x0400036A RID: 874
		[Token(Token = "0x400036A")]
		[FieldOffset(Offset = "0x12C")]
		private int kReflectionDenoisingFrames;
	}
}
