using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200018E RID: 398
	[Token(Token = "0x200018E")]
	public class BinaryG3Writer : IMeshWriter
	{
		// Token: 0x06000AC9 RID: 2761 RVA: 0x00008234 File Offset: 0x00006434
		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x2003DA0", Offset = "0x20023A0", VA = "0x182003DA0", Slot = "5")]
		public IOWriteResult Write(BinaryWriter writer, List<WriteMesh> vMeshes, WriteOptions options)
		{
			return default(IOWriteResult);
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0000824C File Offset: 0x0000644C
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x2003F80", Offset = "0x2002580", VA = "0x182003F80", Slot = "4")]
		public IOWriteResult Write(TextWriter writer, List<WriteMesh> vMeshes, WriteOptions options)
		{
			return default(IOWriteResult);
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public BinaryG3Writer()
		{
		}
	}
}
