using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

namespace Crest
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	[VolumeComponentMenu("Crest/Underwater")]
	[Serializable]
	public sealed class UnderwaterPostProcessHDRP : CustomPostProcessVolumeComponent, IPostProcessComponent
	{
		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x000033A8 File Offset: 0x000015A8
		[Token(Token = "0x170000B3")]
		public override CustomPostProcessInjectionPoint injectionPoint
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x6A2B30", Offset = "0x6A1130", VA = "0x1806A2B30", Slot = "8")]
			get
			{
				return CustomPostProcessInjectionPoint.AfterOpaqueAndSky;
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xA1C7B0", Offset = "0xA1ADB0", VA = "0x180A1C7B0")]
		private void DispatchWithGuardBands(CommandBuffer cmd, ComputeShader shader, int kernelId, in Vector2Int size, in int viewCount, in RTHandle sourceRT)
		{
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x000033C0 File Offset: 0x000015C0
		[Token(Token = "0x170000B4")]
		private int tmpTargetCount
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0xA1C8F0", Offset = "0xA1AEF0", VA = "0x180A1C8F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xA1C940", Offset = "0xA1AF40", VA = "0x180A1C940")]
		public static void SetSkipUnderwaterPost(bool value)
		{
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B5")]
		public static UnderwaterPostProcessHDRP Instance
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0xA1C9A0", Offset = "0xA1AFA0", VA = "0x180A1C9A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0xA1C9F0", Offset = "0xA1AFF0", VA = "0x180A1C9F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x000033D8 File Offset: 0x000015D8
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xA1CAA0", Offset = "0xA1B0A0", VA = "0x180A1CAA0", Slot = "13")]
		public bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xA1CC60", Offset = "0xA1B260", VA = "0x180A1CC60", Slot = "10")]
		public override void Setup()
		{
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xA1D130", Offset = "0xA1B730", VA = "0x180A1D130", Slot = "12")]
		public override void Cleanup()
		{
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xA1D490", Offset = "0xA1BA90", VA = "0x180A1D490", Slot = "11")]
		public override void Render(CommandBuffer cmd, HDCamera camera, RTHandle source, RTHandle destination)
		{
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xA1E8C0", Offset = "0xA1CEC0", VA = "0x180A1E8C0")]
		public UnderwaterPostProcessHDRP()
		{
		}

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x40")]
		private Material _underwaterPostProcessMaterial;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x48")]
		private PropertyWrapperMaterial _underwaterPostProcessMaterialWrapper;

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		private const string SHADER = "Hidden/Crest/Underwater/Post Process HDRP";

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		private const string ValidCameraTag = "MainCamera";

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		private const string SceneCameraName = "SceneCamera";

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x50")]
		private bool _firstRender;

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x58")]
		public BoolParameter _enable;

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x60")]
		public BoolParameter _copyOceanMaterialParamsEachFrame;

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("How much to smooth ocean data such as water depth, light scattering, shadowing. Helps to smooth flickering that can occur under camera motion.")]
		public ClampedIntParameter _filterOceanData;

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x70")]
		[Header("Debug Options")]
		public BoolParameter _viewOceanMask;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x78")]
		public BoolParameter _disableOceanMask;

		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x80")]
		[Tooltip("A safety margin multiplier to adjust horizon line based on camera position to avoid minor artifacts caused by floating point precision issues, the default value has been chosen based on careful experimentation.")]
		public ClampedFloatParameter _horizonSafetyMarginMultiplier;

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x88")]
		public BoolParameter _scaleSafetyMarginWithDynamicResolution;

		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x90")]
		private UnderwaterPostProcessUtils.UnderwaterSphericalHarmonicsData _sphericalHarmonicsData;

		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x98")]
		private Camera _camera;

		// Token: 0x040002E4 RID: 740
		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0xA0")]
		private RTHandle[] m_Underwater;

		// Token: 0x040002E5 RID: 741
		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0xA8")]
		private RTHandle[] m_Copy;

		// Token: 0x040002E6 RID: 742
		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0xB0")]
		private RTHandle[] m_Blur;

		// Token: 0x040002E7 RID: 743
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0xB8")]
		private MaterialPropertyBlock m_PropertyBlock;

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0xC0")]
		private Shader m_ColorPyramidPS;

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0xC8")]
		private Material m_ColorPyramidPSMat;

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int SourcePID;

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int SrcScaleBiasPID;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int SourceMipPID;

		// Token: 0x040002ED RID: 749
		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int SrcUvLimitsPID;

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int BlurredInputTexturePID;

		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int BlurredInputTextureScalePID;

		// Token: 0x040002F0 RID: 752
		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int InputTexturePID;

		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		private const int k_RTGuardBandSize = 4;

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly int InputTexPID;

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int OutputTexPID;

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x24")]
		private static readonly int TexelSizePID;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int _OceanHeight;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0xD0")]
		public ComputeShader bloomBlurCS;

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0xD8")]
		private int blurKernel;

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0xE0")]
		private ProfilingSampler OceanUnderWaterProfile;

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0xE8")]
		private Shader m_FinalBlitShader;

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0xF0")]
		private Material m_BlitMaterial;

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x2C")]
		private static bool _skipUnderwaterPost;
	}
}
