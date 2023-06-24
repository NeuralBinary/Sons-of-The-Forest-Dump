using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.VFX
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	[ExecuteAlways]
	public class CausticsCookieManager : MonoBehaviour
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x316C300", Offset = "0x316A900", VA = "0x18316C300")]
		private void Setup()
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x316C670", Offset = "0x316AC70", VA = "0x18316C670")]
		private void SetCookies()
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x316C820", Offset = "0x316AE20", VA = "0x18316C820")]
		private void SetupRT()
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x316C9A0", Offset = "0x316AFA0", VA = "0x18316C9A0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x316C9B0", Offset = "0x316AFB0", VA = "0x18316C9B0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x316CB90", Offset = "0x316B190", VA = "0x18316CB90")]
		private void Update()
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x316CD70", Offset = "0x316B370", VA = "0x18316CD70")]
		private void UpdateRegistered()
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x316CFB0", Offset = "0x316B5B0", VA = "0x18316CFB0")]
		private void UpdateSequence()
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x316D120", Offset = "0x316B720", VA = "0x18316D120")]
		public static void Register(CausticsCookieLight causticsCookieLight)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x316D320", Offset = "0x316B920", VA = "0x18316D320")]
		public static void Unregister(CausticsCookieLight causticsCookieLight)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x316D4D0", Offset = "0x316BAD0", VA = "0x18316D4D0")]
		public CausticsCookieManager()
		{
		}

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x20")]
		[Space(4f)]
		[SerializeField]
		private bool _updateInEditMode;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Header("Required Settings")]
		[Space(4f)]
		private CausticsCookieSize _causticsCookieSize;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x28")]
		private Shader _causticsShader;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Texture2D _causticsMask;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _causticsTiling;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Header("Animation")]
		[Space(4f)]
		private float _fps;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Texture[] _sequence;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x48")]
		private float _timer;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x4C")]
		private int _currentIndex;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x50")]
		private int _lastCookieLightsCount;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x54")]
		private bool _initialized;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x58")]
		private Material _causticsMat;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x60")]
		private RenderTexture _causticsRenderTexture;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int _CausticCookieMaskPID;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int _CausticCookieTilingPID;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x8")]
		private static List<CausticsCookieLight> _causticsCookieLights;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x10")]
		private static bool _cookieLightsDirty;
	}
}
