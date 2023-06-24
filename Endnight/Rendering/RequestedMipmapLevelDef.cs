using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Rendering
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	[Serializable]
	internal class RequestedMipmapLevelDef
	{
		// Token: 0x060002E9 RID: 745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xA965F0", Offset = "0xA94BF0", VA = "0x180A965F0")]
		public void OnValidate()
		{
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xA96600", Offset = "0xA94C00", VA = "0x180A96600")]
		private void RefreshFromSourceMaterial()
		{
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xA968E0", Offset = "0xA94EE0", VA = "0x180A968E0")]
		public void Apply(bool value)
		{
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x704F00", Offset = "0x703500", VA = "0x180704F00")]
		public RequestedMipmapLevelDef()
		{
		}

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _automaticFromSourceMaterial;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Material _sourceMaterial;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _requestedMipmapLevel;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Texture2D> _sourceTextures;
	}
}
