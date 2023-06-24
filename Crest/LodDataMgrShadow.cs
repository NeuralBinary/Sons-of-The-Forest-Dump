using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace Crest
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	public class LodDataMgrShadow : LodDataMgr
	{
		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x17000073")]
		public override string SimName
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x9FA5C0", Offset = "0x9F8BC0", VA = "0x1809FA5C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x17000074")]
		protected override GraphicsFormat RequestedTextureFormat
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x9FA5F0", Offset = "0x9F8BF0", VA = "0x1809FA5F0", Slot = "5")]
			get
			{
				return GraphicsFormat.None;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x17000075")]
		protected override bool NeedToReadWriteTextureData
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000076")]
		public CommandBuffer BufCopyShadowMap
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x17000077")]
		public SimSettingsShadow Settings
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x9FA600", Offset = "0x9F8C00", VA = "0x1809FA600")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x9FA840", Offset = "0x9F8E40", VA = "0x1809FA840")]
		public LodDataMgrShadow(OceanRenderer ocean)
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x9FAB80", Offset = "0x9F9180", VA = "0x1809FAB80", Slot = "8")]
		public override void Start()
		{
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x9FAFA0", Offset = "0x9F95A0", VA = "0x1809FAFA0", Slot = "9")]
		protected override void InitData()
		{
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x9FB260", Offset = "0x9F9860", VA = "0x1809FB260")]
		private bool StartInitLight()
		{
			return default(bool);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x9FB5E0", Offset = "0x9F9BE0", VA = "0x1809FB5E0")]
		private void ClearBufferIfLightChanged()
		{
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x9FB890", Offset = "0x9F9E90", VA = "0x1809FB890", Slot = "10")]
		public override void UpdateLodData()
		{
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x9FCA80", Offset = "0x9FB080", VA = "0x1809FCA80")]
		public void ValidateSourceData()
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x9FCC80", Offset = "0x9FB280", VA = "0x1809FCC80", Slot = "12")]
		internal override void OnEnable()
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x9FCCD0", Offset = "0x9FB2D0", VA = "0x1809FCCD0", Slot = "13")]
		internal override void OnDisable()
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x9FCED0", Offset = "0x9FB4D0", VA = "0x1809FCED0")]
		private void RemoveCommandBuffers()
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x9FD010", Offset = "0x9FB610", VA = "0x1809FD010")]
		public static int ParamIdSampler(bool sourceLod = false)
		{
			return 0;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x9FD080", Offset = "0x9FB680", VA = "0x1809FD080", Slot = "6")]
		protected override int GetParamIdSampler(bool sourceLod = false)
		{
			return 0;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x9FD110", Offset = "0x9FB710", VA = "0x1809FD110")]
		public static void Bind(IPropertyWrapper properties)
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x9FD2D0", Offset = "0x9FB8D0", VA = "0x1809FD2D0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void InitStatics()
		{
		}

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x0")]
		public static bool s_processData;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x38")]
		private Light _mainLight;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x48")]
		private RenderTexture _sources;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x50")]
		private PropertyWrapperMaterial[] _renderMaterial;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x58")]
		private readonly int sp_CenterPos;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x5C")]
		private readonly int sp_Scale;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x60")]
		private readonly int sp_JitterDiameters_CurrentFrameWeights;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x64")]
		private readonly int sp_MainCameraProjectionMatrix;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x68")]
		private readonly int sp_SimDeltaTime;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x6C")]
		private readonly int sp_LD_SliceIndex_Source;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x70")]
		private readonly int sp_cascadeDataSrc;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x78")]
		private SimSettingsShadow _defaultSettings;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string s_textureArrayName;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x10")]
		private static LodDataMgr.TextureArrayParamIds s_textureArrayParamIds;
	}
}
