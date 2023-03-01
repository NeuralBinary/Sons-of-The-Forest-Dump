using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x02000594 RID: 1428
	[Token(Token = "0x2000594")]
	public class VirtualCamera
	{
		// Token: 0x0600250C RID: 9484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600250C")]
		[Address(RVA = "0x2D929E0", Offset = "0x2D919E0", VA = "0x182D929E0")]
		public VirtualCamera()
		{
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x0000AE60 File Offset: 0x00009060
		[Token(Token = "0x600250D")]
		[Address(RVA = "0x2D92990", Offset = "0x2D91990", VA = "0x182D92990")]
		public bool PlatformCompatibility()
		{
			return default(bool);
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600250E")]
		[Address(RVA = "0x2D927B0", Offset = "0x2D917B0", VA = "0x182D927B0")]
		private RenderTexture DownsampleTexture(RenderTexture renderTex, float energyNormalizer)
		{
			return null;
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600250F")]
		[Address(RVA = "0x2D91F70", Offset = "0x2D90F70", VA = "0x182D91F70")]
		public void BindExposureTexture(Material mat)
		{
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002510")]
		[Address(RVA = "0x2D921F0", Offset = "0x2D911F0", VA = "0x182D921F0")]
		public void BindVirtualCameraTextures(Material mat)
		{
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x0000AE78 File Offset: 0x00009078
		[Token(Token = "0x6002511")]
		[Address(RVA = "0x2D92270", Offset = "0x2D91270", VA = "0x182D92270")]
		public float CalculateManualExposure(CameraParameters cameraParams, float middleGrey = 0.18f)
		{
			return default(float);
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002512")]
		[Address(RVA = "0x2D91FD0", Offset = "0x2D90FD0", VA = "0x182D91FD0")]
		public void BindVirtualCameraParams(Material mat, CameraParameters cameraParams, float focalDistance, float halfResWidth, bool isFirstRender)
		{
		}

		// Token: 0x06002513 RID: 9491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002513")]
		[Address(RVA = "0x2D92320", Offset = "0x2D91320", VA = "0x182D92320")]
		public void CalculateVirtualCamera(CameraParameters cameraParams, RenderTexture textureToDownsample, float halfResWidth, float tanHalfFoV, float energyNormalizer, float focalDistance, bool isFirstRender)
		{
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002514")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void EndOfFrameCleanup()
		{
		}

		// Token: 0x04002160 RID: 8544
		[Token(Token = "0x4002160")]
		public const float FilmWidth = 70f;

		// Token: 0x04002161 RID: 8545
		[Token(Token = "0x4002161")]
		private const float BuiltinExposureCompensation = 1.8f;

		// Token: 0x04002162 RID: 8546
		[Token(Token = "0x4002162")]
		[FieldOffset(Offset = "0x10")]
		private Material m_virtualCameraMat;

		// Token: 0x04002163 RID: 8547
		[Token(Token = "0x4002163")]
		[FieldOffset(Offset = "0x18")]
		private RenderTexture m_previousExposureTexture;

		// Token: 0x04002164 RID: 8548
		[Token(Token = "0x4002164")]
		private const RenderTextureFormat VCTextureFormat = 11;

		// Token: 0x04002165 RID: 8549
		[Token(Token = "0x4002165")]
		[FieldOffset(Offset = "0x20")]
		private RenderTexture m_currentResult1;

		// Token: 0x04002166 RID: 8550
		[Token(Token = "0x4002166")]
		[FieldOffset(Offset = "0x28")]
		private RenderTexture m_currentResult2;

		// Token: 0x04002167 RID: 8551
		[Token(Token = "0x4002167")]
		[FieldOffset(Offset = "0x30")]
		private RenderBuffer[] renderBuffers;

		// Token: 0x04002168 RID: 8552
		[Token(Token = "0x4002168")]
		public const float LIGHT_INTENSITY_MULT = 3000f;

		// Token: 0x04002169 RID: 8553
		[Token(Token = "0x4002169")]
		[FieldOffset(Offset = "0x38")]
		private ComputeBuffer readBfr;

		// Token: 0x0400216A RID: 8554
		[Token(Token = "0x400216A")]
		[FieldOffset(Offset = "0x40")]
		private Vector4[] readVec;
	}
}
