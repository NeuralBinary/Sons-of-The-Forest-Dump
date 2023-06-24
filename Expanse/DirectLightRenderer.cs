using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

namespace Expanse
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	public class DirectLightRenderer : IRenderer
	{
		// Token: 0x0600033D RID: 829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033D")]
		[Address(RVA = "0xAE6510", Offset = "0xAE4B10", VA = "0x180AE6510", Slot = "5")]
		public override void build()
		{
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033E")]
		[Address(RVA = "0xAE6690", Offset = "0xAE4C90", VA = "0x180AE6690")]
		public void cleanupFramebuffers()
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033F")]
		[Address(RVA = "0xAE6860", Offset = "0xAE4E60", VA = "0x180AE6860", Slot = "6")]
		public override void cleanup()
		{
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000340")]
		[Address(RVA = "0xAE69F0", Offset = "0xAE4FF0", VA = "0x180AE69F0", Slot = "4")]
		public override void render(BuiltinSkyParameters builtinParams, IRenderer[] dependencies)
		{
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000341")]
		[Address(RVA = "0xAE7010", Offset = "0xAE5610", VA = "0x180AE7010")]
		private void checkAndResizeFramebuffer(Vector2Int newResolution)
		{
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x6000342")]
		[Address(RVA = "0xAE70F0", Offset = "0xAE56F0", VA = "0x180AE70F0", Slot = "7")]
		public override IReadOnlyCollection<string> getTextureNames()
		{
			return null;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000343")]
		[Address(RVA = "0xAE7140", Offset = "0xAE5740", VA = "0x180AE7140", Slot = "8")]
		public override void setTexture(string texture, string shaderVariable, MaterialPropertyBlock propertyBlock)
		{
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000344")]
		[Address(RVA = "0xAE71D0", Offset = "0xAE57D0", VA = "0x180AE71D0", Slot = "9")]
		public override void setTexture(string texture, string shaderVariable, ComputeShader computeShader, int kernelHandle)
		{
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000345")]
		[Address(RVA = "0xAE7270", Offset = "0xAE5870", VA = "0x180AE7270", Slot = "11")]
		public override void setTexture(string texture, int shaderVariable, CommandBuffer cmd)
		{
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000346")]
		[Address(RVA = "0xAE7370", Offset = "0xAE5970", VA = "0x180AE7370", Slot = "10")]
		public override void setTexture(string texture, string shaderVariable, CommandBuffer cmd)
		{
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000347")]
		[Address(RVA = "0xAC8E30", Offset = "0xAC7430", VA = "0x180AC8E30", Slot = "12")]
		public override void setTextureResolution(string texture, string shaderVariable, MaterialPropertyBlock propertyBlock)
		{
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000348")]
		[Address(RVA = "0xAC8ED0", Offset = "0xAC74D0", VA = "0x180AC8ED0", Slot = "13")]
		public override void setTextureResolution(string texture, string shaderVariable, ComputeShader computeShader)
		{
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000349")]
		[Address(RVA = "0xAC8F70", Offset = "0xAC7570", VA = "0x180AC8F70", Slot = "14")]
		public override void setTextureResolution(string texture, string shaderVariable, CommandBuffer cmd)
		{
		}

		// Token: 0x0600034A RID: 842 RVA: 0x000051C0 File Offset: 0x000033C0
		[Token(Token = "0x600034A")]
		[Address(RVA = "0xAE7430", Offset = "0xAE5A30", VA = "0x180AE7430", Slot = "15")]
		public override Vector3 getTextureResolution(string texture)
		{
			return default(Vector3);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034B")]
		[Address(RVA = "0xAE7460", Offset = "0xAE5A60", VA = "0x180AE7460")]
		private void setShaderVariables(BuiltinSkyParameters builtinParams)
		{
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034C")]
		[Address(RVA = "0xAE7560", Offset = "0xAE5B60", VA = "0x180AE7560")]
		private void setProceduralTextures(StarGenerator starGenerator, NebulaGenerator nebulaGenerator)
		{
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034D")]
		[Address(RVA = "0xAE76E0", Offset = "0xAE5CE0", VA = "0x180AE76E0")]
		private void setSettingsBuffers(ExpanseSettings settings, int handle)
		{
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034E")]
		[Address(RVA = "0xAE76E0", Offset = "0xAE5CE0", VA = "0x180AE76E0")]
		private void setGeneralSettings(ExpanseSettings settings, int handle)
		{
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034F")]
		[Address(RVA = "0xAE7790", Offset = "0xAE5D90", VA = "0x180AE7790")]
		public DirectLightRenderer()
		{
		}

		// Token: 0x040003DF RID: 991
		[Token(Token = "0x40003DF")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, RTHandle> m_framebuffers;

		// Token: 0x040003E0 RID: 992
		[Token(Token = "0x40003E0")]
		[FieldOffset(Offset = "0x18")]
		private RTHandle m_defaultTextureCube;

		// Token: 0x040003E1 RID: 993
		[Token(Token = "0x40003E1")]
		[FieldOffset(Offset = "0x20")]
		private ComputeBuffer m_settingsBuffer;

		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x40003E2")]
		private const string kSettingsBuffer = "_settingsBuffer";

		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		private const string kBodySettingsBuffer = "_bodySettingsBuffer";

		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0x28")]
		private DirectLightRenderer.DirectLightSettings[] m_directLightSettings;

		// Token: 0x040003E5 RID: 997
		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0x30")]
		private ProfilingSampler m_profilingSampler;

		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0x38")]
		private ComputeShader m_CS;

		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x40003E7")]
		private const string kDirectLightKernel = "DIRECTLIGHT";

		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0x40")]
		private int m_directLightHandle;

		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		private const string kFramebufferRW = "_Framebuffer_RW";

		// Token: 0x040003EA RID: 1002
		[Token(Token = "0x40003EA")]
		private const string kBodyAlbedoTexture = "_bodyAlbedoTex";

		// Token: 0x040003EB RID: 1003
		[Token(Token = "0x40003EB")]
		private const string kBodyEmissionTexture = "_bodyEmissionTex";

		// Token: 0x040003EC RID: 1004
		[Token(Token = "0x40003EC")]
		private const string kAuthoredStarTexture = "_authoredStarTexture";

		// Token: 0x040003ED RID: 1005
		[Token(Token = "0x40003ED")]
		private const string kAuthoredNebulaeTexture = "_authoredNebulaeTexture";

		// Token: 0x040003EE RID: 1006
		[Token(Token = "0x40003EE")]
		private const string kPlanetAlbedoTexture = "_planetAlbedoTex";

		// Token: 0x040003EF RID: 1007
		[Token(Token = "0x40003EF")]
		private const string kPlanetEmissionTexture = "_planetEmissionTex";

		// Token: 0x040003F0 RID: 1008
		[Token(Token = "0x40003F0")]
		[FieldOffset(Offset = "0x44")]
		private Vector2Int m_resolution;

		// Token: 0x0200004D RID: 77
		[Token(Token = "0x200004D")]
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\directLight\\general\\DirectLightRenderer.cs", needAccessors = false)]
		private struct DirectLightSettings
		{
			// Token: 0x040003F1 RID: 1009
			[Token(Token = "0x40003F1")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 resolution;
		}
	}
}
