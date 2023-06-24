using System;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CommandLine.Text
{
	// Token: 0x02000088 RID: 136
	[Token(Token = "0x2000088")]
	public class HeadingInfo
	{
		// Token: 0x060002FC RID: 764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x997B70", Offset = "0x996170", VA = "0x180997B70")]
		public HeadingInfo(string programName, [Optional] string version)
		{
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060002FD RID: 765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000094")]
		public static HeadingInfo Empty
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x997CD0", Offset = "0x9962D0", VA = "0x180997CD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060002FE RID: 766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000095")]
		public static HeadingInfo Default
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x997D30", Offset = "0x996330", VA = "0x180997D30")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x996D30", Offset = "0x995330", VA = "0x180996D30")]
		public static implicit operator string(HeadingInfo info)
		{
			return null;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x9981F0", Offset = "0x9967F0", VA = "0x1809981F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x998340", Offset = "0x996940", VA = "0x180998340")]
		public void WriteMessage(string message, TextWriter writer)
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x998530", Offset = "0x996B30", VA = "0x180998530")]
		public void WriteMessage(string message)
		{
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x9985D0", Offset = "0x996BD0", VA = "0x1809985D0")]
		public void WriteError(string message)
		{
		}

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string programName;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly string version;
	}
}
