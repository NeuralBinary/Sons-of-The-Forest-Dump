using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x020005A4 RID: 1444
	[Token(Token = "0x20005A4")]
	public class VirtualCamera
	{
		// Token: 0x0600260B RID: 9739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260B")]
		[Address(RVA = "0x33A53E0", Offset = "0x33A39E0", VA = "0x1833A53E0")]
		public VirtualCamera()
		{
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x0000B520 File Offset: 0x00009720
		[Token(Token = "0x600260C")]
		[Address(RVA = "0x33A5590", Offset = "0x33A3B90", VA = "0x1833A5590")]
		public bool PlatformCompatibility()
		{
			return default(bool);
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600260D")]
		[Address(RVA = "0x33A5620", Offset = "0x33A3C20", VA = "0x1833A5620")]
		private RenderTexture DownsampleTexture(RenderTexture renderTex, float energyNormalizer)
		{
			return null;
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260E")]
		[Address(RVA = "0x33A58E0", Offset = "0x33A3EE0", VA = "0x1833A58E0")]
		public void BindExposureTexture(Material mat)
		{
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260F")]
		[Address(RVA = "0x33A5940", Offset = "0x33A3F40", VA = "0x1833A5940")]
		public void BindVirtualCameraTextures(Material mat)
		{
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x0000B538 File Offset: 0x00009738
		[Token(Token = "0x6002610")]
		[Address(RVA = "0x33A59C0", Offset = "0x33A3FC0", VA = "0x1833A59C0")]
		public float CalculateManualExposure(CameraParameters cameraParams, float middleGrey = 0.18f)
		{
			return 0f;
		}

		// Token: 0x06002611 RID: 9745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002611")]
		[Address(RVA = "0x33A5A70", Offset = "0x33A4070", VA = "0x1833A5A70")]
		public void BindVirtualCameraParams(Material mat, CameraParameters cameraParams, float focalDistance, float halfResWidth, bool isFirstRender)
		{
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002612")]
		[Address(RVA = "0x33A5CD0", Offset = "0x33A42D0", VA = "0x1833A5CD0")]
		public void CalculateVirtualCamera(CameraParameters cameraParams, RenderTexture textureToDownsample, float halfResWidth, float tanHalfFoV, float energyNormalizer, float focalDistance, bool isFirstRender)
		{
		}

		// Token: 0x06002613 RID: 9747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002613")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void EndOfFrameCleanup()
		{
		}

		// Token: 0x04002234 RID: 8756
		[Token(Token = "0x4002234")]
		public const float FilmWidth = 70f;

		// Token: 0x04002235 RID: 8757
		[Token(Token = "0x4002235")]
		private const float BuiltinExposureCompensation = 1.8f;

		// Token: 0x04002236 RID: 8758
		[Token(Token = "0x4002236")]
		[FieldOffset(Offset = "0x10")]
		private Material m_virtualCameraMat;

		// Token: 0x04002237 RID: 8759
		[Token(Token = "0x4002237")]
		[FieldOffset(Offset = "0x18")]
		private RenderTexture m_previousExposureTexture;

		// Token: 0x04002238 RID: 8760
		[Token(Token = "0x4002238")]
		private const RenderTextureFormat VCTextureFormat = RenderTextureFormat.ARGBFloat;

		// Token: 0x04002239 RID: 8761
		[Token(Token = "0x4002239")]
		[FieldOffset(Offset = "0x20")]
		private RenderTexture m_currentResult1;

		// Token: 0x0400223A RID: 8762
		[Token(Token = "0x400223A")]
		[FieldOffset(Offset = "0x28")]
		private RenderTexture m_currentResult2;

		// Token: 0x0400223B RID: 8763
		[Token(Token = "0x400223B")]
		[FieldOffset(Offset = "0x30")]
		private RenderBuffer[] renderBuffers;

		// Token: 0x0400223C RID: 8764
		[Token(Token = "0x400223C")]
		public const float LIGHT_INTENSITY_MULT = 3000f;

		// Token: 0x0400223D RID: 8765
		[Token(Token = "0x400223D")]
		[FieldOffset(Offset = "0x38")]
		private ComputeBuffer readBfr;

		// Token: 0x0400223E RID: 8766
		[Token(Token = "0x400223E")]
		[FieldOffset(Offset = "0x40")]
		private Vector4[] readVec;
	}
}
