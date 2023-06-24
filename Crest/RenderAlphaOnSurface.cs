using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	public class RenderAlphaOnSurface : MonoBehaviour
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x9D2BA0", Offset = "0x9D11A0", VA = "0x1809D2BA0")]
		private void Start()
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x9D2E90", Offset = "0x9D1490", VA = "0x1809D2E90")]
		private void LateUpdate()
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x9D3290", Offset = "0x9D1890", VA = "0x1809D3290")]
		private void LateUpdateBounds()
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public RenderAlphaOnSurface()
		{
		}

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x20")]
		public bool _drawBounds;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x28")]
		private PropertyWrapperMPB _mpb;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x30")]
		private Renderer _rend;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x38")]
		private Mesh _mesh;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x40")]
		private Bounds _boundsLocal;
	}
}
