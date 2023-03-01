using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x0200057F RID: 1407
	[Token(Token = "0x200057F")]
	public class DepthOfField
	{
		// Token: 0x060024E4 RID: 9444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E4")]
		[Address(RVA = "0x2D828D0", Offset = "0x2D818D0", VA = "0x182D828D0")]
		public DepthOfField()
		{
		}

		// Token: 0x060024E5 RID: 9445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E5")]
		[Address(RVA = "0x2D80E70", Offset = "0x2D7FE70", VA = "0x182D80E70")]
		private void CreateDX11Mat()
		{
		}

		// Token: 0x060024E6 RID: 9446 RVA: 0x0000AD58 File Offset: 0x00008F58
		[Token(Token = "0x60024E6")]
		[Address(RVA = "0x2D81660", Offset = "0x2D80660", VA = "0x182D81660")]
		public bool PlatformCompatibility()
		{
			return default(bool);
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E7")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void EndOfFrameCleanup()
		{
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x0000AD70 File Offset: 0x00008F70
		[Token(Token = "0x60024E8")]
		[Address(RVA = "0x2D81650", Offset = "0x2D80650", VA = "0x182D81650")]
		private float Min(float val1, float val2)
		{
			return default(float);
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x0000AD88 File Offset: 0x00008F88
		[Token(Token = "0x60024E9")]
		[Address(RVA = "0x2D81500", Offset = "0x2D80500", VA = "0x182D81500")]
		private float Max(float val1, float val2)
		{
			return default(float);
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		[Token(Token = "0x60024EA")]
		[Address(RVA = "0x2D81640", Offset = "0x2D80640", VA = "0x182D81640")]
		private int Min(int val1, int val2)
		{
			return default(int);
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		[Token(Token = "0x60024EB")]
		[Address(RVA = "0x2D81510", Offset = "0x2D80510", VA = "0x182D81510")]
		private int Max(int val1, int val2)
		{
			return default(int);
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024EC")]
		[Address(RVA = "0x2D81860", Offset = "0x2D80860", VA = "0x182D81860")]
		private RenderTexture PrepatePointAverage(PostProcessParameters postProcessParams, RenderTexture dest)
		{
			return null;
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024ED")]
		[Address(RVA = "0x2D81DC0", Offset = "0x2D80DC0", VA = "0x182D81DC0")]
		public RenderTexture RenderDepthOfField(PostProcessParameters postProcessParams, RenderTexture source, RenderTexture dest, VirtualCamera virtualCamera)
		{
			return null;
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024EE")]
		[Address(RVA = "0x2D80F60", Offset = "0x2D7FF60", VA = "0x182D80F60")]
		private RenderTexture CreateTiledData(RenderTexture halfResDepth, float tanHalfFoV, float fNumber, float focalDistance, float focalRange, float apertureDiameter, float focalLength, float maxCoCRadius, float nearPlane, float farPlane)
		{
			return null;
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024EF")]
		[Address(RVA = "0x2D82590", Offset = "0x2D81590", VA = "0x182D82590")]
		private RenderTexture TileNeighbourhoodDataGathering(RenderTexture tiledData)
		{
			return null;
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F0")]
		[Address(RVA = "0x2D81740", Offset = "0x2D80740", VA = "0x182D81740")]
		private RenderTexture PrefilterSource(RenderTexture halfResSource)
		{
			return null;
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F1")]
		[Address(RVA = "0x2D80C80", Offset = "0x2D7FC80", VA = "0x182D80C80")]
		private RenderTexture BlurTapPass(RenderTexture halfResSource, RenderTexture tiledData, RenderTexture neighbourhoodData, RenderTexture depthCenterAverage, DepthOfFieldQuality qualityLevel)
		{
			return null;
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F2")]
		[Address(RVA = "0x2D81520", Offset = "0x2D80520", VA = "0x182D81520")]
		private RenderTexture MedianFilterPass(RenderTexture inputTexture)
		{
			return null;
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F3")]
		[Address(RVA = "0x2D82750", Offset = "0x2D81750", VA = "0x182D82750")]
		private RenderTexture UpsampleDepthOfField(RenderTexture source, RenderTexture depthOfFieldTexture, RenderTexture neighbourhoodData)
		{
			return null;
		}

		// Token: 0x040020F9 RID: 8441
		[Token(Token = "0x40020F9")]
		[FieldOffset(Offset = "0x10")]
		private Material m_DoFMat;

		// Token: 0x040020FA RID: 8442
		[Token(Token = "0x40020FA")]
		[FieldOffset(Offset = "0x18")]
		private Material m_DoFMatDX11;

		// Token: 0x040020FB RID: 8443
		[Token(Token = "0x40020FB")]
		[FieldOffset(Offset = "0x20")]
		private RenderTexture previousPointAverage;
	}
}
