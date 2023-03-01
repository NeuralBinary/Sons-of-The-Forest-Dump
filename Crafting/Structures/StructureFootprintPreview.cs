using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020007DD RID: 2013
	[Token(Token = "0x20007DD")]
	public class StructureFootprintPreview : MonoBehaviour
	{
		// Token: 0x0600353C RID: 13628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600353C")]
		[Address(RVA = "0x2EA4F20", Offset = "0x2EA3F20", VA = "0x182EA4F20")]
		private void Awake()
		{
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600353D")]
		[Address(RVA = "0x2EA50E0", Offset = "0x2EA40E0", VA = "0x182EA50E0")]
		public void Initialize(Vector3 size)
		{
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600353E")]
		[Address(RVA = "0x2EA4F50", Offset = "0x2EA3F50", VA = "0x182EA4F50")]
		private void InitProjector(Renderer decalRenderer, Vector3 size, Vector3 offset)
		{
		}

		// Token: 0x0600353F RID: 13631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600353F")]
		[Address(RVA = "0x2EA52B0", Offset = "0x2EA42B0", VA = "0x182EA52B0")]
		public void SetSize(Vector3 size)
		{
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003540")]
		[Address(RVA = "0x2EA52E0", Offset = "0x2EA42E0", VA = "0x182EA52E0")]
		public StructureFootprintPreview()
		{
		}

		// Token: 0x04002DB6 RID: 11702
		[Token(Token = "0x4002DB6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _size;

		// Token: 0x04002DB7 RID: 11703
		[Token(Token = "0x4002DB7")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _textureLength;

		// Token: 0x04002DB8 RID: 11704
		[Token(Token = "0x4002DB8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Renderer _topDecal;

		// Token: 0x04002DB9 RID: 11705
		[Token(Token = "0x4002DB9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Renderer _bottomDecal;

		// Token: 0x04002DBA RID: 11706
		[Token(Token = "0x4002DBA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Renderer _leftDecal;

		// Token: 0x04002DBB RID: 11707
		[Token(Token = "0x4002DBB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Renderer _rightDecal;

		// Token: 0x04002DBC RID: 11708
		[Token(Token = "0x4002DBC")]
		[FieldOffset(Offset = "0x50")]
		private MaterialPropertyBlock _materialPropertyBlock;
	}
}
