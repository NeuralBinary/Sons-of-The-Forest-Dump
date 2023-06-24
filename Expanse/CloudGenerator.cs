using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

namespace Expanse
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	public class CloudGenerator : IRenderer
	{
		// Token: 0x060002CC RID: 716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xAD49F0", Offset = "0xAD2FF0", VA = "0x180AD49F0")]
		public void setLayerIndex(int layerIndex)
		{
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xAD4A00", Offset = "0xAD3000", VA = "0x180AD4A00")]
		public CloudGenerator(int layerIndex)
		{
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xAD4C40", Offset = "0xAD3240", VA = "0x180AD4C40", Slot = "5")]
		public override void build()
		{
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xAD4E10", Offset = "0xAD3410", VA = "0x180AD4E10", Slot = "6")]
		public override void cleanup()
		{
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xAD5010", Offset = "0xAD3610", VA = "0x180AD5010", Slot = "4")]
		public override void render(BuiltinSkyParameters builtinParams, [Optional] IRenderer[] dependencies)
		{
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xAD5440", Offset = "0xAD3A40", VA = "0x180AD5440")]
		private void regenerateLayer(CommandBuffer cmd, UniversalCloudLayer.UniversalCloudNoiseLayer noiseLayer, int i, string name, Datatypes.NoiseDimension dimension)
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xAD5AB0", Offset = "0xAD40B0", VA = "0x180AD5AB0")]
		private void checkAndResizeTextures(Datatypes.Quality quality, Datatypes.NoiseDimension dimension)
		{
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xAD5BE0", Offset = "0xAD41E0", VA = "0x180AD5BE0")]
		private void reallocateTextures()
		{
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xAD6540", Offset = "0xAD4B40", VA = "0x180AD6540", Slot = "7")]
		public override IReadOnlyCollection<string> getTextureNames()
		{
			return null;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xAD6590", Offset = "0xAD4B90", VA = "0x180AD6590", Slot = "8")]
		public override void setTexture(string texture, string shaderVariable, MaterialPropertyBlock propertyBlock)
		{
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xAD6620", Offset = "0xAD4C20", VA = "0x180AD6620", Slot = "9")]
		public override void setTexture(string texture, string shaderVariable, ComputeShader computeShader, int kernelHandle)
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xAD66C0", Offset = "0xAD4CC0", VA = "0x180AD66C0", Slot = "10")]
		public override void setTexture(string texture, string shaderVariable, CommandBuffer cmd)
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xAD6780", Offset = "0xAD4D80", VA = "0x180AD6780", Slot = "11")]
		public override void setTexture(string texture, int shaderVariable, CommandBuffer cmd)
		{
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xAC8E30", Offset = "0xAC7430", VA = "0x180AC8E30", Slot = "12")]
		public override void setTextureResolution(string texture, string shaderVariable, MaterialPropertyBlock propertyBlock)
		{
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xAC8ED0", Offset = "0xAC74D0", VA = "0x180AC8ED0", Slot = "13")]
		public override void setTextureResolution(string texture, string shaderVariable, ComputeShader computeShader)
		{
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xAC8F70", Offset = "0xAC7570", VA = "0x180AC8F70", Slot = "14")]
		public override void setTextureResolution(string texture, string shaderVariable, CommandBuffer cmd)
		{
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00004FF8 File Offset: 0x000031F8
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xAD6880", Offset = "0xAD4E80", VA = "0x180AD6880", Slot = "15")]
		public override Vector3 getTextureResolution(string texture)
		{
			return default(Vector3);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xAD6A00", Offset = "0xAD5000", VA = "0x180AD6A00")]
		private void setShaderVariables(ComputeShader cs, UniversalCloudLayer.UniversalCloudNoiseLayer noiseLayer, Vector3 res)
		{
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00005010 File Offset: 0x00003210
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xAD6B80", Offset = "0xAD5180", VA = "0x180AD6B80")]
		private static CloudGenerator.CloudGeneratorResolution qualityToResolution(Datatypes.Quality quality, Datatypes.NoiseDimension dimension)
		{
			return default(CloudGenerator.CloudGeneratorResolution);
		}

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, RTHandle> m_textures;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CloudGenerator.CloudGeneratorResolution m_resolution;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Datatypes.NoiseDimension m_dimension;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ProfilingSampler m_profilingSampler;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ComputeShader[] m_CS;

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string kCoverageID;

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string kBaseID;

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string kStructureID;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string kDetailID;

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static string kBaseWarpID;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static string kDetailWarpID;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static string[] kLayerNames;

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int m_previousHashCode;

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int[] m_previousLayerHashCodes;

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int m_layerIndex;

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Dictionary<Datatypes.Quality, CloudGenerator.CloudGeneratorResolution> kQualityToResolutionTable2D;

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Dictionary<Datatypes.Quality, CloudGenerator.CloudGeneratorResolution> kQualityToResolutionTable3D;

		// Token: 0x0200003D RID: 61
		[Token(Token = "0x200003D")]
		private struct CloudGeneratorResolution
		{
			// Token: 0x060002E0 RID: 736 RVA: 0x00005028 File Offset: 0x00003228
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0xAD7A50", Offset = "0xAD6050", VA = "0x180AD7A50")]
			public static bool areEqual(CloudGenerator.CloudGeneratorResolution r1, CloudGenerator.CloudGeneratorResolution r2)
			{
				return default(bool);
			}

			// Token: 0x040002DF RID: 735
			[Token(Token = "0x40002DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector2 resCoverage;

			// Token: 0x040002E0 RID: 736
			[Token(Token = "0x40002E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 resBase;

			// Token: 0x040002E1 RID: 737
			[Token(Token = "0x40002E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 resStructure;

			// Token: 0x040002E2 RID: 738
			[Token(Token = "0x40002E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 resDetail;

			// Token: 0x040002E3 RID: 739
			[Token(Token = "0x40002E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 resBaseWarp;

			// Token: 0x040002E4 RID: 740
			[Token(Token = "0x40002E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 resDetailWarp;
		}
	}
}
