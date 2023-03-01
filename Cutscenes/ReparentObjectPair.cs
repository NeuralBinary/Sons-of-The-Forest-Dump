using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x0200079E RID: 1950
	[Token(Token = "0x200079E")]
	[Serializable]
	public class ReparentObjectPair
	{
		// Token: 0x060033A8 RID: 13224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A8")]
		[Address(RVA = "0x2E66E20", Offset = "0x2E65E20", VA = "0x182E66E20")]
		private void Collect()
		{
		}

		// Token: 0x060033A9 RID: 13225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A9")]
		[Address(RVA = "0x2E66BF0", Offset = "0x2E65BF0", VA = "0x182E66BF0")]
		public void Apply()
		{
		}

		// Token: 0x060033AA RID: 13226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033AA")]
		[Address(RVA = "0x2E66F60", Offset = "0x2E65F60", VA = "0x182E66F60")]
		public void Revert()
		{
		}

		// Token: 0x060033AB RID: 13227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033AB")]
		[Address(RVA = "0x2E66EB0", Offset = "0x2E65EB0", VA = "0x182E66EB0")]
		public void OnValidate()
		{
		}

		// Token: 0x060033AC RID: 13228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033AC")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public ReparentObjectPair()
		{
		}

		// Token: 0x04002CB9 RID: 11449
		[Token(Token = "0x4002CB9")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _disableChildWhenNotParented;

		// Token: 0x04002CBA RID: 11450
		[Token(Token = "0x4002CBA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _child;

		// Token: 0x04002CBB RID: 11451
		[Token(Token = "0x4002CBB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _parent;

		// Token: 0x04002CBC RID: 11452
		[Token(Token = "0x4002CBC")]
		[FieldOffset(Offset = "0x28")]
		private Transform _originalParent;

		// Token: 0x04002CBD RID: 11453
		[Token(Token = "0x4002CBD")]
		[FieldOffset(Offset = "0x30")]
		private bool _performed;
	}
}
