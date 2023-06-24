using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

namespace Expanse
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	public abstract class IRenderer
	{
		// Token: 0x06000319 RID: 793
		[Token(Token = "0x6000319")]
		public abstract void render(BuiltinSkyParameters builtinParams, [Optional] IRenderer[] dependencies);

		// Token: 0x0600031A RID: 794
		[Token(Token = "0x600031A")]
		public abstract void build();

		// Token: 0x0600031B RID: 795
		[Token(Token = "0x600031B")]
		public abstract void cleanup();

		// Token: 0x0600031C RID: 796
		[Token(Token = "0x600031C")]
		public abstract IReadOnlyCollection<string> getTextureNames();

		// Token: 0x0600031D RID: 797
		[Token(Token = "0x600031D")]
		public abstract void setTexture(string texture, string shaderVariable, MaterialPropertyBlock propertyBlock);

		// Token: 0x0600031E RID: 798
		[Token(Token = "0x600031E")]
		public abstract void setTexture(string texture, string shaderVariable, ComputeShader computeShader, int kernelHandle);

		// Token: 0x0600031F RID: 799
		[Token(Token = "0x600031F")]
		public abstract void setTexture(string texture, string shaderVariable, CommandBuffer cmd);

		// Token: 0x06000320 RID: 800
		[Token(Token = "0x6000320")]
		public abstract void setTexture(string texture, int shaderVariable, CommandBuffer cmd);

		// Token: 0x06000321 RID: 801
		[Token(Token = "0x6000321")]
		public abstract void setTextureResolution(string texture, string shaderVariable, MaterialPropertyBlock propertyBlock);

		// Token: 0x06000322 RID: 802
		[Token(Token = "0x6000322")]
		public abstract void setTextureResolution(string texture, string shaderVariable, ComputeShader computeShader);

		// Token: 0x06000323 RID: 803
		[Token(Token = "0x6000323")]
		public abstract void setTextureResolution(string texture, string shaderVariable, CommandBuffer cmd);

		// Token: 0x06000324 RID: 804
		[Token(Token = "0x6000324")]
		public abstract Vector3 getTextureResolution(string texture);

		// Token: 0x06000325 RID: 805 RVA: 0x00005130 File Offset: 0x00003330
		[Token(Token = "0x6000325")]
		[Address(RVA = "0xAE4960", Offset = "0xAE2F60", VA = "0x180AE4960")]
		public static int computeGroups(int res, int threads)
		{
			return 0;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x6000326")]
		[Address(RVA = "0xAE4990", Offset = "0xAE2F90", VA = "0x180AE4990")]
		public static RTHandle allocateMonochromeTexture2D(string name, Vector2Int resolution, bool useMipMap = false, GraphicsFormat format = GraphicsFormat.R16_SFloat)
		{
			return null;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x6000327")]
		[Address(RVA = "0xAE4A90", Offset = "0xAE3090", VA = "0x180AE4A90")]
		public static RTHandle allocateRGBATexture2D(string name, Vector2Int resolution, bool useMipMap = false, GraphicsFormat format = GraphicsFormat.R16G16B16A16_SFloat)
		{
			return null;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x6000328")]
		[Address(RVA = "0xAE4B90", Offset = "0xAE3190", VA = "0x180AE4B90")]
		public static RTHandle allocateMonochromeTexture3D(string name, Vector3Int resolution, bool useMipMap = false, GraphicsFormat format = GraphicsFormat.R16_SFloat)
		{
			return null;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x6000329")]
		[Address(RVA = "0xAE4C80", Offset = "0xAE3280", VA = "0x180AE4C80")]
		public static RTHandle allocateRGBATexture3D(string name, Vector3Int resolution, bool useMipMap = false, GraphicsFormat format = GraphicsFormat.R16G16B16A16_SFloat)
		{
			return null;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x600032A")]
		[Address(RVA = "0xAE4D70", Offset = "0xAE3370", VA = "0x180AE4D70")]
		public static RTHandle allocateMonochromeTexture2DArray(string name, Vector2Int resolution, int slices, bool useMipMap = false, GraphicsFormat format = GraphicsFormat.R16_SFloat)
		{
			return null;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x600032B")]
		[Address(RVA = "0xAE4E70", Offset = "0xAE3470", VA = "0x180AE4E70")]
		public static RTHandle allocateRGBATexture2DArray(string name, Vector2Int resolution, int slices, bool useMipMap = false, GraphicsFormat format = GraphicsFormat.R16G16B16A16_SFloat)
		{
			return null;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x600032C")]
		[Address(RVA = "0xAE4F70", Offset = "0xAE3570", VA = "0x180AE4F70")]
		public static RTHandle allocateEmulatedMonochromeCubemapTexture(string name, Vector2Int resolution, bool useMipMap = false, GraphicsFormat format = GraphicsFormat.R16_SFloat)
		{
			return null;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x600032D")]
		[Address(RVA = "0xAE5060", Offset = "0xAE3660", VA = "0x180AE5060")]
		public static RTHandle allocateEmulatedRGBACubemapTexture(string name, Vector2Int resolution, bool useMipMap = false, GraphicsFormat format = GraphicsFormat.R16G16B16A16_SFloat)
		{
			return null;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x600032E")]
		[Address(RVA = "0xAE5150", Offset = "0xAE3750", VA = "0x180AE5150")]
		public static RTHandle allocateDefaultTexture2D()
		{
			return null;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x600032F")]
		[Address(RVA = "0xAE5290", Offset = "0xAE3890", VA = "0x180AE5290")]
		public static RTHandle allocateDefaultTexture3D()
		{
			return null;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x6000330")]
		[Address(RVA = "0xAE53D0", Offset = "0xAE39D0", VA = "0x180AE53D0")]
		public static RTHandle allocateDefaultTextureCube()
		{
			return null;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000331")]
		[Address(RVA = "0xAE5510", Offset = "0xAE3B10", VA = "0x180AE5510")]
		public static void clearToWhite(RenderTexture toClear)
		{
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000332")]
		[Address(RVA = "0xAE5650", Offset = "0xAE3C50", VA = "0x180AE5650")]
		public static void clearToBlack(RenderTexture toClear)
		{
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000333")]
		[Address(RVA = "0xAE5790", Offset = "0xAE3D90", VA = "0x180AE5790")]
		public static void cleanupStaticMembers()
		{
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000334")]
		[Address(RVA = "0xAE5B60", Offset = "0xAE4160", VA = "0x180AE5B60")]
		public static void buildStaticMembers()
		{
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected IRenderer()
		{
		}

		// Token: 0x040003D9 RID: 985
		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static RTHandle kDefaultTextureCube;

		// Token: 0x040003DA RID: 986
		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static RTHandle kDefaultTexture2D;

		// Token: 0x040003DB RID: 987
		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static RTHandle kDefaultTexture3D;

		// Token: 0x040003DC RID: 988
		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static ComputeBuffer kDefaultComputeBuffer;

		// Token: 0x040003DD RID: 989
		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static int kDefaultResourcesRefCount;
	}
}
