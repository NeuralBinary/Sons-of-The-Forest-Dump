using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

namespace Crest
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	internal class UnderwaterPostProcessMaskRenderer : CustomPass
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002EF RID: 751 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B6")]
		public static UnderwaterPostProcessMaskRenderer Instance
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0xA1F3A0", Offset = "0xA1D9A0", VA = "0x180A1F3A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0xA1F3F0", Offset = "0xA1D9F0", VA = "0x180A1F3F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xA1F4A0", Offset = "0xA1DAA0", VA = "0x180A1F4A0", Slot = "10")]
		protected override void Setup(ScriptableRenderContext renderContext, CommandBuffer cmd)
		{
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xA1FAF0", Offset = "0xA1E0F0", VA = "0x180A1FAF0", Slot = "9")]
		protected override void Execute(CustomPassContext ctx)
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xA20700", Offset = "0xA1ED00", VA = "0x180A20700", Slot = "11")]
		protected override void Cleanup()
		{
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xA207B0", Offset = "0xA1EDB0", VA = "0x180A207B0")]
		private void ReCreateBuffers(Vector2 rtScale)
		{
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xA20B80", Offset = "0xA1F180", VA = "0x180A20B80")]
		public static void Enable()
		{
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xA21250", Offset = "0xA1F850", VA = "0x180A21250")]
		public static void Disable()
		{
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xA213B0", Offset = "0xA1F9B0", VA = "0x180A213B0")]
		public UnderwaterPostProcessMaskRenderer()
		{
		}

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x0")]
		private static GameObject _gameObject;

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string _gameObjectName;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string _customPassName;

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x90")]
		public BoolParameter CustomPassAdded;

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x18")]
		private static bool CustomPassAddedBool;

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		private const string k_ComputeShaderFillMaskArtefacts = "CrestFillMaskArtefacts";

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		private const string k_ComputeShaderKernelFillMaskArtefacts = "FillMaskArtefacts";

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly int sp_CrestOceanMaskTexture;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x98")]
		private ComputeShader _fixMaskComputeShader;

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0xA0")]
		private int _fixMaskKernel;

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0xA4")]
		private uint _fixMaskThreadGroupSizeX;

		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0xA8")]
		private uint _fixMaskThreadGroupSizeY;

		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0xAC")]
		[Tooltip("Adjusts the far plane for horizon line calculation. Helps with horizon line issue.")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _farPlaneMultiplier;

		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int sp_FarPlaneOffset;

		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		internal const int k_ShaderPassOceanHorizonMask = 1;

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		private const string SHADER_OCEAN_MASK = "Crest/Underwater/Ocean Mask";

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0xB0")]
		private Shader _oceanMaskShader;

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0xB8")]
		private Material _oceanMaskMaterial;

		// Token: 0x0400030F RID: 783
		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0xC0")]
		private RTHandle _colorBuffer;

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0xC8")]
		private RTHandle _depthBuffer;

		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0xD0")]
		private Plane[] _cameraFrustumPlanes;

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0xD8")]
		private bool dynResEnabled;

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0xDC")]
		private float dynResSize;
	}
}
