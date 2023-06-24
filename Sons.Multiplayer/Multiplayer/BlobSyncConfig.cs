using System;
using Endnight.Utilities.Configurations;
using Il2CppDummyDll;

namespace Sons.Multiplayer
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	public class BlobSyncConfig : JsonConfigurationFile<BlobSyncConfig>
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000002")]
		public override string RootName
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x30D43A0", Offset = "0x30D29A0", VA = "0x1830D43A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x30D43D0", Offset = "0x30D29D0", VA = "0x1830D43D0")]
		public BlobSyncConfig()
		{
		}

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x10")]
		public bool TestMode;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x14")]
		public int TestModeBlobSize;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x18")]
		public byte TestModeBlobChannel;
	}
}
