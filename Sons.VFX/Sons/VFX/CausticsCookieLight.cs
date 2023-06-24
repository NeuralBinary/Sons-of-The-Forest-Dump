using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Sons.VFX
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	[ExecuteAlways]
	[RequireComponent(typeof(Light))]
	public class CausticsCookieLight : MonoBehaviour
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x316BED0", Offset = "0x316A4D0", VA = "0x18316BED0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x316BF30", Offset = "0x316A530", VA = "0x18316BF30")]
		private void Initialize()
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x316C040", Offset = "0x316A640", VA = "0x18316C040")]
		public void SetCookieTexture(RenderTexture cookieTexture)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x316C0C0", Offset = "0x316A6C0", VA = "0x18316C0C0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public CausticsCookieLight()
		{
		}

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x20")]
		private Light _light;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x28")]
		private HDAdditionalLightData _lightData;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x30")]
		private bool _initialized;
	}
}
