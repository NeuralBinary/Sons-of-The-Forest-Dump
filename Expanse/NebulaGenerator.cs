using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

namespace Expanse
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	public class NebulaGenerator : IRenderer
	{
		// Token: 0x06000357 RID: 855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000357")]
		[Address(RVA = "0xAE8630", Offset = "0xAE6C30", VA = "0x180AE8630", Slot = "5")]
		public override void build()
		{
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000358")]
		[Address(RVA = "0xAE8780", Offset = "0xAE6D80", VA = "0x180AE8780")]
		private void cleanupTextures()
		{
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000359")]
		[Address(RVA = "0xAE8950", Offset = "0xAE6F50", VA = "0x180AE8950", Slot = "6")]
		public override void cleanup()
		{
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035A")]
		[Address(RVA = "0xAE8960", Offset = "0xAE6F60", VA = "0x180AE8960", Slot = "4")]
		public override void render(BuiltinSkyParameters builtinParams, [Optional] IRenderer[] dependencies)
		{
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035B")]
		[Address(RVA = "0xAE8CB0", Offset = "0xAE72B0", VA = "0x180AE8CB0")]
		private void checkAndResizeTextures()
		{
		}

		// Token: 0x0600035C RID: 860 RVA: 0x000051D8 File Offset: 0x000033D8
		[Token(Token = "0x600035C")]
		[Address(RVA = "0xAE8E20", Offset = "0xAE7420", VA = "0x180AE8E20")]
		private static Vector2Int qualityToResolution(Datatypes.Quality quality)
		{
			return default(Vector2Int);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x600035D")]
		[Address(RVA = "0xAE8E90", Offset = "0xAE7490", VA = "0x180AE8E90", Slot = "7")]
		public override IReadOnlyCollection<string> getTextureNames()
		{
			return null;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035E")]
		[Address(RVA = "0xAE8EE0", Offset = "0xAE74E0", VA = "0x180AE8EE0", Slot = "8")]
		public override void setTexture(string texture, string shaderVariable, MaterialPropertyBlock propertyBlock)
		{
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035F")]
		[Address(RVA = "0xAE8F70", Offset = "0xAE7570", VA = "0x180AE8F70", Slot = "9")]
		public override void setTexture(string texture, string shaderVariable, ComputeShader computeShader, int kernelHandle)
		{
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000360")]
		[Address(RVA = "0xAE9010", Offset = "0xAE7610", VA = "0x180AE9010", Slot = "10")]
		public override void setTexture(string texture, string shaderVariable, CommandBuffer cmd)
		{
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000361")]
		[Address(RVA = "0xAE90D0", Offset = "0xAE76D0", VA = "0x180AE90D0", Slot = "11")]
		public override void setTexture(string texture, int shaderVariable, CommandBuffer cmd)
		{
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000362")]
		[Address(RVA = "0xAC8E30", Offset = "0xAC7430", VA = "0x180AC8E30", Slot = "12")]
		public override void setTextureResolution(string texture, string shaderVariable, MaterialPropertyBlock propertyBlock)
		{
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000363")]
		[Address(RVA = "0xAC8ED0", Offset = "0xAC74D0", VA = "0x180AC8ED0", Slot = "13")]
		public override void setTextureResolution(string texture, string shaderVariable, ComputeShader computeShader)
		{
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000364")]
		[Address(RVA = "0xAC8F70", Offset = "0xAC7570", VA = "0x180AC8F70", Slot = "14")]
		public override void setTextureResolution(string texture, string shaderVariable, CommandBuffer cmd)
		{
		}

		// Token: 0x06000365 RID: 869 RVA: 0x000051F0 File Offset: 0x000033F0
		[Token(Token = "0x6000365")]
		[Address(RVA = "0xAE91D0", Offset = "0xAE77D0", VA = "0x180AE91D0", Slot = "15")]
		public override Vector3 getTextureResolution(string texture)
		{
			return default(Vector3);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000366")]
		[Address(RVA = "0xAE9200", Offset = "0xAE7800", VA = "0x180AE9200")]
		public NebulaGenerator()
		{
		}

		// Token: 0x04000400 RID: 1024
		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, RTHandle> m_textures;

		// Token: 0x04000401 RID: 1025
		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector2Int m_resolution;

		// Token: 0x04000402 RID: 1026
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ProfilingSampler m_profilingSampler;

		// Token: 0x04000403 RID: 1027
		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ComputeShader m_CS;

		// Token: 0x04000404 RID: 1028
		[Token(Token = "0x4000404")]
		private const string kNebulaKernel = "NEBULA";

		// Token: 0x04000405 RID: 1029
		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_nebulaHandle;

		// Token: 0x04000406 RID: 1030
		[Token(Token = "0x4000406")]
		private const string kNebulaRW = "_Nebula_RW";

		// Token: 0x04000407 RID: 1031
		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Datatypes.Quality, Vector2Int> kQualityToResolutionTable;
	}
}
