using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace Crest
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	public class LodDataMgrSeaFloorDepth : LodDataMgr
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600017B RID: 379 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x17000047")]
		public override string SimName
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x9E61E0", Offset = "0x9E47E0", VA = "0x1809E61E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x17000048")]
		protected override GraphicsFormat RequestedTextureFormat
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x9E6210", Offset = "0x9E4810", VA = "0x1809E6210", Slot = "5")]
			get
			{
				return GraphicsFormat.None;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x17000049")]
		protected override bool NeedToReadWriteTextureData
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x9E6220", Offset = "0x9E4820", VA = "0x1809E6220")]
		public LodDataMgrSeaFloorDepth(OceanRenderer ocean)
		{
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x9E62E0", Offset = "0x9E48E0", VA = "0x1809E62E0", Slot = "11")]
		public override void BuildCommandBuffer(OceanRenderer ocean, CommandBuffer buf)
		{
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x9E6660", Offset = "0x9E4C60", VA = "0x1809E6660")]
		public static int ParamIdSampler(bool sourceLod = false)
		{
			return 0;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x9E66D0", Offset = "0x9E4CD0", VA = "0x1809E66D0", Slot = "6")]
		protected override int GetParamIdSampler(bool sourceLod = false)
		{
			return 0;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x9E6760", Offset = "0x9E4D60", VA = "0x1809E6760")]
		public static void Bind(IPropertyWrapper properties)
		{
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x9E6B20", Offset = "0x9E5120", VA = "0x1809E6B20")]
		private static void InitNullTexture()
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x9E6C60", Offset = "0x9E5260", VA = "0x1809E6C60")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void InitStatics()
		{
		}

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x38")]
		private bool _targetsClear;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		public const string ShaderName = "Crest/Inputs/Depth/Cached Depths";

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color s_nullColor;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x10")]
		private static Texture2DArray s_nullTexture2DArray;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x18")]
		private static readonly string s_textureArrayName;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x20")]
		private static LodDataMgr.TextureArrayParamIds s_textureArrayParamIds;
	}
}
