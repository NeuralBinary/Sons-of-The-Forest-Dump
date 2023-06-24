using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Crest
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	public static class CrestUnderwaterCustomPassUtils
	{
		// Token: 0x060002D2 RID: 722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xA17620", Offset = "0xA15C20", VA = "0x180A17620")]
		internal static void InitialiseMaskTextures(RenderTextureDescriptor desc, ref RenderTexture textureMask, ref RenderTexture depthBuffer)
		{
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xA17BD0", Offset = "0xA161D0", VA = "0x180A17BD0")]
		internal static void PopulateOceanMask(CommandBuffer commandBuffer, Camera camera, List<OceanChunkRenderer> chunksToRender, Plane[] frustumPlanes, RTHandle colorBuffer, RTHandle depthBuffer, Material oceanMaskMaterial, bool debugDisableOceanMask)
		{
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xA18020", Offset = "0xA16620", VA = "0x180A18020")]
		public static void UpdateCustomPassMaterial(Camera camera, PropertyWrapperMaterial underwaterPostProcessMaterialWrapper, CrestUnderwaterCustomPassUtils.UnderwaterSphericalHarmonicsData sphericalHarmonicsData, bool copyParamsFromOceanMaterial, bool debugViewPostProcessMask, float horizonSafetyMarginMultiplier, int dataSliceOffset)
		{
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xA19C50", Offset = "0xA18250", VA = "0x180A19C50")]
		private static void GetHorizonPosNormal(Camera camera, Camera.MonoOrStereoscopicEye eye, float seaLevel, float horizonSafetyMarginMultiplier, out Vector2 resultPos, out Vector2 resultNormal)
		{
		}

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int sp_CrestOceanMaskTexture;

		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int sp_CrestOceanMaskDepthTexture;

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int sp_OceanHeight;

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int sp_MainTex;

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int sp_InvViewProjection;

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int sp_InvViewProjectionRight;

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int sp_InstanceData;

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly int sp_AmbientLighting;

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int sp_HorizonPosNormal;

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x24")]
		private static readonly int sp_HorizonPosNormalRight;

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int sp_DataSliceOffset;

		// Token: 0x040002BC RID: 700
		[Token(Token = "0x40002BC")]
		internal const string tooltipHorizonSafetyMarginMultiplier = "A safety margin multiplier to adjust horizon line based on camera position to avoid minor artifacts caused by floating point precision issues, the default value has been chosen based on careful experimentation.";

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40002BD")]
		internal const string tooltipFilterOceanData = "How much to smooth ocean data such as water depth, light scattering, shadowing. Helps to smooth flickering that can occur under camera motion.";

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		public const float DefaultHorizonSafetyMarginMultiplier = 0.01f;

		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		public const int DefaultFilterOceanDataValue = 13;

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		public const int MinFilterOceanDataValue = 0;

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		public const int MaxFilterOceanDataValue = 13;

		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x40002C2")]
		internal const float UNDERWATER_MASK_NO_MASK = 1f;

		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		internal const string FULL_SCREEN_EFFECT = "_FULL_SCREEN_EFFECT";

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		internal const string DEBUG_VIEW_OCEAN_MASK = "_DEBUG_VIEW_OCEAN_MASK";

		// Token: 0x02000075 RID: 117
		[Token(Token = "0x2000075")]
		public class UnderwaterSphericalHarmonicsData
		{
			// Token: 0x060002D7 RID: 727 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0xA1AF40", Offset = "0xA19540", VA = "0x180A1AF40")]
			public UnderwaterSphericalHarmonicsData()
			{
			}

			// Token: 0x040002C5 RID: 709
			[Token(Token = "0x40002C5")]
			[FieldOffset(Offset = "0x10")]
			internal Color[] _ambientLighting;

			// Token: 0x040002C6 RID: 710
			[Token(Token = "0x40002C6")]
			[FieldOffset(Offset = "0x18")]
			internal Vector3[] _shDirections;
		}
	}
}
