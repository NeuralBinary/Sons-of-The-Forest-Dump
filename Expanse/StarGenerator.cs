using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

namespace Expanse
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	public class StarGenerator : IRenderer
	{
		// Token: 0x0600037C RID: 892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037C")]
		[Address(RVA = "0xAED6D0", Offset = "0xAEBCD0", VA = "0x180AED6D0", Slot = "5")]
		public override void build()
		{
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037D")]
		[Address(RVA = "0xAED820", Offset = "0xAEBE20", VA = "0x180AED820")]
		private void cleanupTextures()
		{
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037E")]
		[Address(RVA = "0xAEDA70", Offset = "0xAEC070", VA = "0x180AEDA70", Slot = "6")]
		public override void cleanup()
		{
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037F")]
		[Address(RVA = "0xAEDA80", Offset = "0xAEC080", VA = "0x180AEDA80", Slot = "4")]
		public override void render(BuiltinSkyParameters builtinParams, [Optional] IRenderer[] dependencies)
		{
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000380")]
		[Address(RVA = "0xAEDE20", Offset = "0xAEC420", VA = "0x180AEDE20")]
		private void checkAndResizeTextures(ExpanseSettings settings)
		{
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00005268 File Offset: 0x00003468
		[Token(Token = "0x6000381")]
		[Address(RVA = "0xAEDF90", Offset = "0xAEC590", VA = "0x180AEDF90")]
		private static Vector2Int qualityToResolution(Datatypes.Quality quality)
		{
			return default(Vector2Int);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x6000382")]
		[Address(RVA = "0xAEE000", Offset = "0xAEC600", VA = "0x180AEE000", Slot = "7")]
		public override IReadOnlyCollection<string> getTextureNames()
		{
			return null;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000383")]
		[Address(RVA = "0xAEE050", Offset = "0xAEC650", VA = "0x180AEE050", Slot = "8")]
		public override void setTexture(string texture, string shaderVariable, MaterialPropertyBlock propertyBlock)
		{
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000384")]
		[Address(RVA = "0xAEE0E0", Offset = "0xAEC6E0", VA = "0x180AEE0E0", Slot = "9")]
		public override void setTexture(string texture, string shaderVariable, ComputeShader computeShader, int kernelHandle)
		{
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000385")]
		[Address(RVA = "0xAEE180", Offset = "0xAEC780", VA = "0x180AEE180", Slot = "11")]
		public override void setTexture(string texture, int shaderVariable, CommandBuffer cmd)
		{
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000386")]
		[Address(RVA = "0xAEE280", Offset = "0xAEC880", VA = "0x180AEE280", Slot = "10")]
		public override void setTexture(string texture, string shaderVariable, CommandBuffer cmd)
		{
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000387")]
		[Address(RVA = "0xAC8E30", Offset = "0xAC7430", VA = "0x180AC8E30", Slot = "12")]
		public override void setTextureResolution(string texture, string shaderVariable, MaterialPropertyBlock propertyBlock)
		{
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000388")]
		[Address(RVA = "0xAC8ED0", Offset = "0xAC74D0", VA = "0x180AC8ED0", Slot = "13")]
		public override void setTextureResolution(string texture, string shaderVariable, ComputeShader computeShader)
		{
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000389")]
		[Address(RVA = "0xAC8F70", Offset = "0xAC7570", VA = "0x180AC8F70", Slot = "14")]
		public override void setTextureResolution(string texture, string shaderVariable, CommandBuffer cmd)
		{
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00005280 File Offset: 0x00003480
		[Token(Token = "0x600038A")]
		[Address(RVA = "0xAE91D0", Offset = "0xAE77D0", VA = "0x180AE91D0", Slot = "15")]
		public override Vector3 getTextureResolution(string texture)
		{
			return default(Vector3);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038B")]
		[Address(RVA = "0xAEE340", Offset = "0xAEC940", VA = "0x180AEE340")]
		public StarGenerator()
		{
		}

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, RTHandle> m_textures;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector2Int m_resolution;

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ProfilingSampler m_profilingSampler;

		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ComputeShader m_CS;

		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		private const string kStarKernel = "STAR";

		// Token: 0x0400043F RID: 1087
		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_starHandle;

		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		private const string kStarRW = "_Star_RW";

		// Token: 0x04000441 RID: 1089
		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Datatypes.Quality, Vector2Int> kQualityToResolutionTable;
	}
}
