using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace Crest
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	public class LodDataMgrClipSurface : LodDataMgr
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000133 RID: 307 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x17000033")]
		public override string SimName
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x9E1DD0", Offset = "0x9E03D0", VA = "0x1809E1DD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x17000034")]
		protected override GraphicsFormat RequestedTextureFormat
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00", Slot = "5")]
			get
			{
				return GraphicsFormat.None;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x17000035")]
		protected override bool NeedToReadWriteTextureData
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x9E1E10", Offset = "0x9E0410", VA = "0x1809E1E10")]
		public LodDataMgrClipSurface(OceanRenderer ocean)
		{
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x9DD290", Offset = "0x9DB890", VA = "0x1809DD290", Slot = "8")]
		public override void Start()
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x9E1ED0", Offset = "0x9E04D0", VA = "0x1809E1ED0", Slot = "11")]
		public override void BuildCommandBuffer(OceanRenderer ocean, CommandBuffer buf)
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x9E21B0", Offset = "0x9E07B0", VA = "0x1809E21B0")]
		public static int ParamIdSampler(bool sourceLod = false)
		{
			return 0;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x9E2220", Offset = "0x9E0820", VA = "0x1809E2220", Slot = "6")]
		protected override int GetParamIdSampler(bool sourceLod = false)
		{
			return 0;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x9E22B0", Offset = "0x9E08B0", VA = "0x1809E22B0")]
		public static void BindNull(IPropertyWrapper properties)
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x9E2390", Offset = "0x9E0990", VA = "0x1809E2390")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void InitStatics()
		{
		}

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x38")]
		private bool _targetsClear;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string s_textureArrayName;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x8")]
		private static LodDataMgr.TextureArrayParamIds s_textureArrayParamIds;
	}
}
