using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Crest
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	internal static class UnderwaterPostProcessUtils
	{
		// Token: 0x060002F9 RID: 761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xA21680", Offset = "0xA1FC80", VA = "0x180A21680")]
		internal static void InitialiseMaskTextures(RenderTextureDescriptor desc, ref RenderTexture textureMask, ref RenderTexture depthBuffer)
		{
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xA21C30", Offset = "0xA20230", VA = "0x180A21C30")]
		internal static void PopulateOceanMask(CommandBuffer commandBuffer, Camera camera, List<OceanChunkRenderer> chunksToRender, Plane[] frustumPlanes, RTHandle colorBuffer, RTHandle depthBuffer, Material oceanMaskMaterial, bool debugDisableOceanMask)
		{
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xA22080", Offset = "0xA20680", VA = "0x180A22080")]
		internal static void UpdatePostProcessMaterial(RenderTexture source, Camera camera, PropertyWrapperMaterial underwaterPostProcessMaterialWrapper, UnderwaterPostProcessUtils.UnderwaterSphericalHarmonicsData sphericalHarmonicsData, bool copyParamsFromOceanMaterial, bool debugViewPostProcessMask, float horizonSafetyMarginMultiplier, int dataSliceOffset)
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xA23D40", Offset = "0xA22340", VA = "0x180A23D40")]
		private static void GetHorizonPosNormal(Camera camera, Camera.MonoOrStereoscopicEye eye, float seaLevel, float horizonSafetyMarginMultiplier, out Vector2 resultPos, out Vector2 resultNormal)
		{
		}

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int sp_CrestOceanMaskTexture;

		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int sp_CrestOceanMaskDepthTexture;

		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int sp_OceanHeight;

		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int sp_MainTex;

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int sp_InvViewProjection;

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int sp_InvViewProjectionRight;

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int sp_InstanceData;

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly int sp_AmbientLighting;

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int sp_HorizonPosNormal;

		// Token: 0x0400031E RID: 798
		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x24")]
		private static readonly int sp_HorizonPosNormalRight;

		// Token: 0x0400031F RID: 799
		[Token(Token = "0x400031F")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int sp_DataSliceOffset;

		// Token: 0x04000320 RID: 800
		[Token(Token = "0x4000320")]
		internal const string tooltipHorizonSafetyMarginMultiplier = "A safety margin multiplier to adjust horizon line based on camera position to avoid minor artifacts caused by floating point precision issues, the default value has been chosen based on careful experimentation.";

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		internal const string tooltipFilterOceanData = "How much to smooth ocean data such as water depth, light scattering, shadowing. Helps to smooth flickering that can occur under camera motion.";

		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000322")]
		internal const float DefaultHorizonSafetyMarginMultiplier = 0.01f;

		// Token: 0x04000323 RID: 803
		[Token(Token = "0x4000323")]
		internal const int DefaultFilterOceanDataValue = 13;

		// Token: 0x04000324 RID: 804
		[Token(Token = "0x4000324")]
		internal const int MinFilterOceanDataValue = 0;

		// Token: 0x04000325 RID: 805
		[Token(Token = "0x4000325")]
		internal const int MaxFilterOceanDataValue = 13;

		// Token: 0x04000326 RID: 806
		[Token(Token = "0x4000326")]
		internal const float UNDERWATER_MASK_NO_MASK = 1f;

		// Token: 0x04000327 RID: 807
		[Token(Token = "0x4000327")]
		internal const string FULL_SCREEN_EFFECT = "_FULL_SCREEN_EFFECT";

		// Token: 0x04000328 RID: 808
		[Token(Token = "0x4000328")]
		internal const string DEBUG_VIEW_OCEAN_MASK = "_DEBUG_VIEW_OCEAN_MASK";

		// Token: 0x0200007A RID: 122
		[Token(Token = "0x200007A")]
		internal class UnderwaterSphericalHarmonicsData
		{
			// Token: 0x060002FE RID: 766 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0xA250F0", Offset = "0xA236F0", VA = "0x180A250F0")]
			public UnderwaterSphericalHarmonicsData()
			{
			}

			// Token: 0x04000329 RID: 809
			[Token(Token = "0x4000329")]
			[FieldOffset(Offset = "0x10")]
			internal Color[] _ambientLighting;

			// Token: 0x0400032A RID: 810
			[Token(Token = "0x400032A")]
			[FieldOffset(Offset = "0x18")]
			internal Vector3[] _shDirections;
		}
	}
}
