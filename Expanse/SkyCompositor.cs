using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

namespace Expanse
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	public class SkyCompositor : IRenderer
	{
		// Token: 0x060003D5 RID: 981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xAFAB80", Offset = "0xAF9180", VA = "0x180AFAB80", Slot = "5")]
		public override void build()
		{
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xAFAC40", Offset = "0xAF9240", VA = "0x180AFAC40", Slot = "4")]
		public override void render(BuiltinSkyParameters builtinParams, IRenderer[] dependencies)
		{
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xAFB4A0", Offset = "0xAF9AA0", VA = "0x180AFB4A0")]
		public void renderForCubemap(BuiltinSkyParameters builtinParams, IRenderer[] dependencies)
		{
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xAFB860", Offset = "0xAF9E60", VA = "0x180AFB860")]
		private void checkAndResizeFramebuffers(Vector2 newResolution)
		{
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xAFBA50", Offset = "0xAFA050", VA = "0x180AFBA50")]
		private void cleanupFramebuffers()
		{
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xAFBB50", Offset = "0xAFA150", VA = "0x180AFBB50", Slot = "6")]
		public override void cleanup()
		{
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xAFBB60", Offset = "0xAFA160", VA = "0x180AFBB60", Slot = "7")]
		public override IReadOnlyCollection<string> getTextureNames()
		{
			return null;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		public override void setTexture(string texture, string shaderVariable, MaterialPropertyBlock propertyBlock)
		{
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "9")]
		public override void setTexture(string texture, string shaderVariable, ComputeShader computeShader, int kernelHandle)
		{
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "10")]
		public override void setTexture(string texture, string shaderVariable, CommandBuffer cmd)
		{
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "11")]
		public override void setTexture(string texture, int shaderVariable, CommandBuffer cmd)
		{
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "12")]
		public override void setTextureResolution(string texture, string shaderVariable, MaterialPropertyBlock propertyBlock)
		{
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "13")]
		public override void setTextureResolution(string texture, string shaderVariable, ComputeShader computeShader)
		{
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "14")]
		public override void setTextureResolution(string texture, string shaderVariable, CommandBuffer cmd)
		{
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00005358 File Offset: 0x00003558
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xAFBBC0", Offset = "0xAFA1C0", VA = "0x180AFBBC0", Slot = "15")]
		public override Vector3 getTextureResolution(string texture)
		{
			return default(Vector3);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xAFBBE0", Offset = "0xAFA1E0", VA = "0x180AFBBE0")]
		public SkyCompositor()
		{
		}

		// Token: 0x040004D2 RID: 1234
		[Token(Token = "0x40004D2")]
		[FieldOffset(Offset = "0x10")]
		private ProfilingSampler m_profilingSampler;

		// Token: 0x040004D3 RID: 1235
		[Token(Token = "0x40004D3")]
		[FieldOffset(Offset = "0x18")]
		private Material m_material;

		// Token: 0x040004D4 RID: 1236
		[Token(Token = "0x40004D4")]
		[FieldOffset(Offset = "0x20")]
		private MaterialPropertyBlock m_PropertyBlock;

		// Token: 0x040004D5 RID: 1237
		[Token(Token = "0x40004D5")]
		[FieldOffset(Offset = "0x28")]
		private RTHandle m_fullscreenNoGeometryBuffer;

		// Token: 0x040004D6 RID: 1238
		[Token(Token = "0x40004D6")]
		private const string kShaderPath = "Hidden/HDRP/Sky/Composite Sky";

		// Token: 0x040004D7 RID: 1239
		[Token(Token = "0x40004D7")]
		private const string kBlueNoisePath = "blue-noise";

		// Token: 0x040004D8 RID: 1240
		[Token(Token = "0x40004D8")]
		private const int kNoGeometryPass = 0;

		// Token: 0x040004D9 RID: 1241
		[Token(Token = "0x40004D9")]
		private const int kFullScreenPass = 1;

		// Token: 0x040004DA RID: 1242
		[Token(Token = "0x40004DA")]
		private const int kCubemapPass = 2;
	}
}
