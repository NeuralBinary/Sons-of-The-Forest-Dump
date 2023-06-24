using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020006E9 RID: 1769
	[Token(Token = "0x20006E9")]
	public class StructureFootprintPreview : MonoBehaviour
	{
		// Token: 0x06002ED1 RID: 11985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ED1")]
		[Address(RVA = "0x34564B0", Offset = "0x3454AB0", VA = "0x1834564B0")]
		private void Awake()
		{
		}

		// Token: 0x06002ED2 RID: 11986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ED2")]
		[Address(RVA = "0x34564E0", Offset = "0x3454AE0", VA = "0x1834564E0")]
		public void Initialize(Vector3 size)
		{
		}

		// Token: 0x06002ED3 RID: 11987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ED3")]
		[Address(RVA = "0x34566B0", Offset = "0x3454CB0", VA = "0x1834566B0")]
		private void InitProjector(Renderer decalRenderer, Vector3 size, Vector3 offset)
		{
		}

		// Token: 0x06002ED4 RID: 11988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ED4")]
		[Address(RVA = "0x3456A30", Offset = "0x3455030", VA = "0x183456A30")]
		public void SetSize(Vector3 size)
		{
		}

		// Token: 0x06002ED5 RID: 11989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ED5")]
		[Address(RVA = "0x3456A60", Offset = "0x3455060", VA = "0x183456A60")]
		public StructureFootprintPreview()
		{
		}

		// Token: 0x04002899 RID: 10393
		[Token(Token = "0x4002899")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _size;

		// Token: 0x0400289A RID: 10394
		[Token(Token = "0x400289A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _textureLength;

		// Token: 0x0400289B RID: 10395
		[Token(Token = "0x400289B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Renderer _topDecal;

		// Token: 0x0400289C RID: 10396
		[Token(Token = "0x400289C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Renderer _bottomDecal;

		// Token: 0x0400289D RID: 10397
		[Token(Token = "0x400289D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Renderer _leftDecal;

		// Token: 0x0400289E RID: 10398
		[Token(Token = "0x400289E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Renderer _rightDecal;

		// Token: 0x0400289F RID: 10399
		[Token(Token = "0x400289F")]
		[FieldOffset(Offset = "0x50")]
		private MaterialPropertyBlock _materialPropertyBlock;
	}
}
