using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001A4 RID: 420
	[Token(Token = "0x20001A4")]
	public class OFFWriter : IMeshWriter
	{
		// Token: 0x06000B63 RID: 2915 RVA: 0x0000854C File Offset: 0x0000674C
		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x2015690", Offset = "0x2013C90", VA = "0x182015690", Slot = "5")]
		public IOWriteResult Write(BinaryWriter writer, List<WriteMesh> vMeshes, WriteOptions options)
		{
			return default(IOWriteResult);
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00008564 File Offset: 0x00006764
		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x20156E0", Offset = "0x2013CE0", VA = "0x1820156E0", Slot = "4")]
		public IOWriteResult Write(TextWriter writer, List<WriteMesh> vMeshes, WriteOptions options)
		{
			return default(IOWriteResult);
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public OFFWriter()
		{
		}
	}
}
