using System;
using Il2CppDummyDll;
using UnityEngine;

namespace AmplifyImpostors
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[Serializable]
	public class TextureOutput
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x5B8370", Offset = "0x5B6970", VA = "0x1805B8370")]
		public TextureOutput()
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x5B8420", Offset = "0x5B6A20", VA = "0x1805B8420")]
		public TextureOutput(bool a, string n, TextureScale s, bool sr, TextureChannels c, TextureCompression nc, ImageFormat i)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x5B8570", Offset = "0x5B6B70", VA = "0x1805B8570")]
		public TextureOutput Clone()
		{
			return null;
		}

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public int Index;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		public OverrideMask OverrideMask;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x18")]
		public bool Active;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x20")]
		public string Name;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x28")]
		public TextureScale Scale;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x2C")]
		public bool SRGB;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x30")]
		public TextureChannels Channels;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x34")]
		public TextureCompression Compression;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x38")]
		public ImageFormat ImageFormat;
	}
}
