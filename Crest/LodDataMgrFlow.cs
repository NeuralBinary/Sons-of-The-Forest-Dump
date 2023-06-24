using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace Crest
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	public class LodDataMgrFlow : LodDataMgr
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000153 RID: 339 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x1700003B")]
		public override string SimName
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x9E3B60", Offset = "0x9E2160", VA = "0x1809E3B60", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x1700003C")]
		protected override GraphicsFormat RequestedTextureFormat
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x9E25D0", Offset = "0x9E0BD0", VA = "0x1809E25D0", Slot = "5")]
			get
			{
				return GraphicsFormat.None;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x1700003D")]
		protected override bool NeedToReadWriteTextureData
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000156 RID: 342 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x1700003E")]
		public SimSettingsFlow Settings
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x9E3B90", Offset = "0x9E2190", VA = "0x1809E3B90")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x9E3DD0", Offset = "0x9E23D0", VA = "0x1809E3DD0")]
		public LodDataMgrFlow(OceanRenderer ocean)
		{
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x9DD290", Offset = "0x9DB890", VA = "0x1809DD290", Slot = "8")]
		public override void Start()
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x9E3E90", Offset = "0x9E2490", VA = "0x1809E3E90", Slot = "12")]
		internal override void OnEnable()
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x9E3F00", Offset = "0x9E2500", VA = "0x1809E3F00", Slot = "13")]
		internal override void OnDisable()
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x9E3FD0", Offset = "0x9E25D0", VA = "0x1809E3FD0", Slot = "11")]
		public override void BuildCommandBuffer(OceanRenderer ocean, CommandBuffer buf)
		{
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x9E4330", Offset = "0x9E2930", VA = "0x1809E4330")]
		public static int ParamIdSampler(bool sourceLod = false)
		{
			return 0;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x9E43A0", Offset = "0x9E29A0", VA = "0x1809E43A0", Slot = "6")]
		protected override int GetParamIdSampler(bool sourceLod = false)
		{
			return 0;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x9E4430", Offset = "0x9E2A30", VA = "0x1809E4430")]
		public static void Bind(IPropertyWrapper properties)
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x9E45F0", Offset = "0x9E2BF0", VA = "0x1809E45F0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void InitStatics()
		{
		}

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x38")]
		private bool _targetsClear;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		public const string FLOW_KEYWORD = "CREST_FLOW_ON_INTERNAL";

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x40")]
		private SimSettingsFlow _defaultSettings;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string s_textureArrayName;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x8")]
		private static LodDataMgr.TextureArrayParamIds s_textureArrayParamIds;
	}
}
