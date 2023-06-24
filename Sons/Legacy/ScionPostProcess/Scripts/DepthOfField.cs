using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x0200058F RID: 1423
	[Token(Token = "0x200058F")]
	public class DepthOfField
	{
		// Token: 0x060025E3 RID: 9699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E3")]
		[Address(RVA = "0x33A0A80", Offset = "0x339F080", VA = "0x1833A0A80")]
		public DepthOfField()
		{
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E4")]
		[Address(RVA = "0x33A0BA0", Offset = "0x339F1A0", VA = "0x1833A0BA0")]
		private void CreateDX11Mat()
		{
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x0000B418 File Offset: 0x00009618
		[Token(Token = "0x60025E5")]
		[Address(RVA = "0x33A0D60", Offset = "0x339F360", VA = "0x1833A0D60")]
		public bool PlatformCompatibility()
		{
			return default(bool);
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void EndOfFrameCleanup()
		{
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x0000B430 File Offset: 0x00009630
		[Token(Token = "0x60025E7")]
		[Address(RVA = "0x33A0E80", Offset = "0x339F480", VA = "0x1833A0E80")]
		private float Min(float val1, float val2)
		{
			return 0f;
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x0000B448 File Offset: 0x00009648
		[Token(Token = "0x60025E8")]
		[Address(RVA = "0x33A0E90", Offset = "0x339F490", VA = "0x1833A0E90")]
		private float Max(float val1, float val2)
		{
			return 0f;
		}

		// Token: 0x060025E9 RID: 9705 RVA: 0x0000B460 File Offset: 0x00009660
		[Token(Token = "0x60025E9")]
		[Address(RVA = "0x33A0EA0", Offset = "0x339F4A0", VA = "0x1833A0EA0")]
		private int Min(int val1, int val2)
		{
			return 0;
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x0000B478 File Offset: 0x00009678
		[Token(Token = "0x60025EA")]
		[Address(RVA = "0x33A0EB0", Offset = "0x339F4B0", VA = "0x1833A0EB0")]
		private int Max(int val1, int val2)
		{
			return 0;
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025EB")]
		[Address(RVA = "0x33A0EC0", Offset = "0x339F4C0", VA = "0x1833A0EC0")]
		private RenderTexture PrepatePointAverage(PostProcessParameters postProcessParams, RenderTexture dest)
		{
			return null;
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025EC")]
		[Address(RVA = "0x33A1680", Offset = "0x339FC80", VA = "0x1833A1680")]
		public RenderTexture RenderDepthOfField(PostProcessParameters postProcessParams, RenderTexture source, RenderTexture dest, VirtualCamera virtualCamera)
		{
			return null;
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025ED")]
		[Address(RVA = "0x33A1B00", Offset = "0x33A0100", VA = "0x1833A1B00")]
		private RenderTexture CreateTiledData(RenderTexture halfResDepth, float tanHalfFoV, float fNumber, float focalDistance, float focalRange, float apertureDiameter, float focalLength, float maxCoCRadius, float nearPlane, float farPlane)
		{
			return null;
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025EE")]
		[Address(RVA = "0x33A22C0", Offset = "0x33A08C0", VA = "0x1833A22C0")]
		private RenderTexture TileNeighbourhoodDataGathering(RenderTexture tiledData)
		{
			return null;
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025EF")]
		[Address(RVA = "0x33A2530", Offset = "0x33A0B30", VA = "0x1833A2530")]
		private RenderTexture PrefilterSource(RenderTexture halfResSource)
		{
			return null;
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F0")]
		[Address(RVA = "0x33A2710", Offset = "0x33A0D10", VA = "0x1833A2710")]
		private RenderTexture BlurTapPass(RenderTexture halfResSource, RenderTexture tiledData, RenderTexture neighbourhoodData, RenderTexture depthCenterAverage, DepthOfFieldQuality qualityLevel)
		{
			return null;
		}

		// Token: 0x060025F1 RID: 9713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F1")]
		[Address(RVA = "0x33A2A30", Offset = "0x33A1030", VA = "0x1833A2A30")]
		private RenderTexture MedianFilterPass(RenderTexture inputTexture)
		{
			return null;
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F2")]
		[Address(RVA = "0x33A2C20", Offset = "0x33A1220", VA = "0x1833A2C20")]
		private RenderTexture UpsampleDepthOfField(RenderTexture source, RenderTexture depthOfFieldTexture, RenderTexture neighbourhoodData)
		{
			return null;
		}

		// Token: 0x040021CD RID: 8653
		[Token(Token = "0x40021CD")]
		[FieldOffset(Offset = "0x10")]
		private Material m_DoFMat;

		// Token: 0x040021CE RID: 8654
		[Token(Token = "0x40021CE")]
		[FieldOffset(Offset = "0x18")]
		private Material m_DoFMatDX11;

		// Token: 0x040021CF RID: 8655
		[Token(Token = "0x40021CF")]
		[FieldOffset(Offset = "0x20")]
		private RenderTexture previousPointAverage;
	}
}
