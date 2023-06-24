using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	public class ShaderGlobals : MonoBehaviour
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x3017500", Offset = "0x3015B00", VA = "0x183017500")]
		protected void Awake()
		{
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x30177A0", Offset = "0x3015DA0", VA = "0x1830177A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x3017930", Offset = "0x3015F30", VA = "0x183017930")]
		private void Update()
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x3017930", Offset = "0x3015F30", VA = "0x183017930")]
		private void UpdateChanged()
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ShaderGlobals()
		{
		}

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x0")]
		private static ShaderGlobals _instance;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<ShaderGlobalFloat> _globalFloats;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<ShaderGlobalInt> _globalInts;

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<ShaderGlobalColor> _globalColors;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<ShaderGlobalTexture> _globalTextures;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<ShaderGlobalVector4> _globalVector4s;
	}
}
