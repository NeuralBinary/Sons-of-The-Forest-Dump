using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001A7 RID: 423
	[Token(Token = "0x20001A7")]
	public class StandardMeshReader
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000B6D RID: 2925 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000B6E RID: 2926 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000003")]
		public event ParsingMessagesHandler warningEvent
		{
			[Token(Token = "0x6000B6D")]
			[Address(RVA = "0x20161F0", Offset = "0x20147F0", VA = "0x1820161F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000B6E")]
			[Address(RVA = "0x20162E0", Offset = "0x20148E0", VA = "0x1820162E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x06000B70 RID: 2928 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000204")]
		public IMeshBuilder MeshBuilder
		{
			[Token(Token = "0x6000B6F")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B70")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x20163D0", Offset = "0x20149D0", VA = "0x1820163D0")]
		public StandardMeshReader(bool bIncludeDefaultReaders = true)
		{
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0000857C File Offset: 0x0000677C
		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x2016670", Offset = "0x2014C70", VA = "0x182016670")]
		public bool SupportsFormat(string sExtension)
		{
			return default(bool);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x20169F0", Offset = "0x2014FF0", VA = "0x1820169F0")]
		public void AddFormatHandler(MeshFormatReader reader)
		{
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00008594 File Offset: 0x00006794
		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x2016C10", Offset = "0x2015210", VA = "0x182016C10")]
		public IOReadResult Read(string sFilename, ReadOptions options)
		{
			return default(IOReadResult);
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x000085AC File Offset: 0x000067AC
		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x20173A0", Offset = "0x20159A0", VA = "0x1820173A0")]
		public IOReadResult Read(Stream stream, string sExtension, ReadOptions options)
		{
			return default(IOReadResult);
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x000085C4 File Offset: 0x000067C4
		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x2017AA0", Offset = "0x20160A0", VA = "0x182017AA0")]
		public static IOReadResult ReadFile(string sFilename, ReadOptions options, IMeshBuilder builder)
		{
			return default(IOReadResult);
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x000085DC File Offset: 0x000067DC
		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x2017BA0", Offset = "0x20161A0", VA = "0x182017BA0")]
		public static IOReadResult ReadFile(Stream stream, string sExtension, ReadOptions options, IMeshBuilder builder)
		{
			return default(IOReadResult);
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x2017CA0", Offset = "0x20162A0", VA = "0x182017CA0")]
		public static DMesh3 ReadMesh(string sFilename)
		{
			return null;
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x2017E30", Offset = "0x2016430", VA = "0x182017E30")]
		public static DMesh3 ReadMesh(Stream stream, string sExtension)
		{
			return null;
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x2017FE0", Offset = "0x20165E0", VA = "0x182017FE0")]
		private void on_warning(string message, object extra_data)
		{
		}

		// Token: 0x040006A3 RID: 1699
		[Token(Token = "0x40006A3")]
		[FieldOffset(Offset = "0x10")]
		public bool ReadInvariantCulture;

		// Token: 0x040006A6 RID: 1702
		[Token(Token = "0x40006A6")]
		[FieldOffset(Offset = "0x28")]
		private List<MeshFormatReader> Readers;
	}
}
