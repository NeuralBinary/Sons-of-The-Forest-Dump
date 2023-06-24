using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace Crest
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	public static class SharedUnderwaterResources
	{
		// Token: 0x060002D8 RID: 728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xA1B090", Offset = "0xA19690", VA = "0x180A1B090")]
		public static void SetupBlur(out ComputeShader ibloomBlurCS, out int iblurKernel, out Shader iColorPyramidPS, out Material iColorPyramidPSMat, out MaterialPropertyBlock iPropertyBlock)
		{
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xA1B7B0", Offset = "0xA19DB0", VA = "0x180A1B7B0")]
		public static RTHandle Get_ColorBufferCopy(TextureDimension textureDimension, GraphicsFormat format, int slices)
		{
			return null;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xA1B9D0", Offset = "0xA19FD0", VA = "0x180A1B9D0")]
		public static RTHandle Get_Underwater(TextureDimension textureDimension, GraphicsFormat format, int slices)
		{
			return null;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xA1BBF0", Offset = "0xA1A1F0", VA = "0x180A1BBF0")]
		public static RTHandle Get_Copy(Vector2 size, TextureDimension textureDimension, GraphicsFormat format, int slices)
		{
			return null;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xA1BDD0", Offset = "0xA1A3D0", VA = "0x180A1BDD0")]
		public static RTHandle Get_Blur(Vector2 size, TextureDimension textureDimension, GraphicsFormat format, int slices)
		{
			return null;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xA1BFB0", Offset = "0xA1A5B0", VA = "0x180A1BFB0")]
		public static void ReleaseUnderwater()
		{
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xA1C4C0", Offset = "0xA1AAC0", VA = "0x180A1C4C0")]
		public static void ReleaseStreamsUnderwater()
		{
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xA1C520", Offset = "0xA1AB20", VA = "0x180A1C520")]
		public static void ReleaseOceanUnderwater()
		{
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xA1C580", Offset = "0xA1AB80", VA = "0x180A1C580")]
		public static void StreamsNeedUnderwater()
		{
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xA1C5D0", Offset = "0xA1ABD0", VA = "0x180A1C5D0")]
		public static void OceanNeedsUnderwater()
		{
		}

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x0")]
		private static RTHandle _ColorBufferCopy;

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x8")]
		private static RTHandle _Underwater;

		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x10")]
		private static RTHandle _Copy;

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x18")]
		private static RTHandle _Blur;

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x20")]
		private static bool _StreamsNeedUnderwater;

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x21")]
		private static bool _OceanNeedsUnderwater;

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x24")]
		private static readonly int InputTexPID;

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int OutputTexPID;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x2C")]
		private static readonly int TexelSizePID;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x30")]
		private static ComputeShader bloomBlurCS;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x38")]
		private static int blurKernel;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x40")]
		private static MaterialPropertyBlock m_PropertyBlock;

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x48")]
		private static Shader m_ColorPyramidPS;

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x50")]
		private static Material m_ColorPyramidPSMat;
	}
}
