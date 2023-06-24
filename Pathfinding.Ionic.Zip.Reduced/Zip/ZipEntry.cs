using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using Pathfinding.Ionic.Crc;
using Pathfinding.Ionic.Zlib;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d00004")]
	public class ZipEntry
	{
		// Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x285A280", Offset = "0x2858880", VA = "0x18285A280")]
		public ZipEntry()
		{
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x17000027")]
		internal bool AttributesIndicateDirectory
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x285A540", Offset = "0x2858B40", VA = "0x18285A540")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x285A560", Offset = "0x2858B60", VA = "0x18285A560")]
		internal void ResetDirEntry()
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000028")]
		public string Info
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x285A580", Offset = "0x2858B80", VA = "0x18285A580")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x285ABB0", Offset = "0x28591B0", VA = "0x18285ABB0")]
		internal static ZipEntry ReadDirEntry(ZipFile zf, Dictionary<string, object> previouslySeen)
		{
			return null;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x285B790", Offset = "0x2859D90", VA = "0x18285B790")]
		internal static bool IsNotValidZipDirEntrySig(int signature)
		{
			return default(bool);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x285B7A0", Offset = "0x2859DA0", VA = "0x18285B7A0")]
		public void Extract()
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x285B7F0", Offset = "0x2859DF0", VA = "0x18285B7F0")]
		public void Extract(ExtractExistingFileAction extractExistingFile)
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x285B850", Offset = "0x2859E50", VA = "0x18285B850")]
		public void Extract(Stream stream)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x285B870", Offset = "0x2859E70", VA = "0x18285B870")]
		public void Extract(string baseDirectory)
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x285B890", Offset = "0x2859E90", VA = "0x18285B890")]
		public void Extract(string baseDirectory, ExtractExistingFileAction extractExistingFile)
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x285B8C0", Offset = "0x2859EC0", VA = "0x18285B8C0")]
		public void ExtractWithPassword(string password)
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x285B920", Offset = "0x2859F20", VA = "0x18285B920")]
		public void ExtractWithPassword(string baseDirectory, string password)
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x285B940", Offset = "0x2859F40", VA = "0x18285B940")]
		public void ExtractWithPassword(ExtractExistingFileAction extractExistingFile, string password)
		{
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x285B9B0", Offset = "0x2859FB0", VA = "0x18285B9B0")]
		public void ExtractWithPassword(string baseDirectory, ExtractExistingFileAction extractExistingFile, string password)
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x285B9D0", Offset = "0x2859FD0", VA = "0x18285B9D0")]
		public void ExtractWithPassword(Stream stream, string password)
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x285B9F0", Offset = "0x2859FF0", VA = "0x18285B9F0")]
		public CrcCalculatorStream OpenReader()
		{
			return null;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x285BA80", Offset = "0x285A080", VA = "0x18285BA80")]
		public CrcCalculatorStream OpenReader(string password)
		{
			return null;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x285BB00", Offset = "0x285A100", VA = "0x18285BB00")]
		internal CrcCalculatorStream InternalOpenReader(string password)
		{
			return null;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x285BD30", Offset = "0x285A330", VA = "0x18285BD30")]
		private void OnExtractProgress(long bytesWritten, long totalBytesToWrite)
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x285BF00", Offset = "0x285A500", VA = "0x18285BF00")]
		private void OnBeforeExtract(string path)
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x285BF60", Offset = "0x285A560", VA = "0x18285BF60")]
		private void OnAfterExtract(string path)
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x285BFB0", Offset = "0x285A5B0", VA = "0x18285BFB0")]
		private void OnExtractExisting(string path)
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x22B0C50", Offset = "0x22AF250", VA = "0x1822B0C50")]
		private static void ReallyDelete(string fileName)
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x285BFF0", Offset = "0x285A5F0", VA = "0x18285BFF0")]
		private void WriteStatus(string format, params object[] args)
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x285C040", Offset = "0x285A640", VA = "0x18285C040")]
		private void InternalExtract(string baseDir, Stream outstream, string password)
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x285CA30", Offset = "0x285B030", VA = "0x18285CA30")]
		internal void VerifyCrcAfterExtract(int actualCrc32)
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x285CB10", Offset = "0x285B110", VA = "0x18285CB10")]
		private int CheckExtractExistingFile(string baseDir, string targetFileName)
		{
			return 0;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x285CE30", Offset = "0x285B430", VA = "0x18285CE30")]
		private void _CheckRead(int nbytes)
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x285CEC0", Offset = "0x285B4C0", VA = "0x18285CEC0")]
		private int ExtractOne(Stream output)
		{
			return 0;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x285D330", Offset = "0x285B930", VA = "0x18285D330")]
		internal Stream GetExtractDecompressor(Stream input2)
		{
			return null;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x285D3D0", Offset = "0x285B9D0", VA = "0x18285D3D0")]
		internal Stream GetExtractDecryptor(Stream input)
		{
			return null;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		internal void _SetTimes(string fileOrDirectory, bool isFile)
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000FE RID: 254 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000029")]
		private string UnsupportedAlgorithm
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x285D460", Offset = "0x285BA60", VA = "0x18285D460")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000FF RID: 255 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x1700002A")]
		private string UnsupportedCompressionMethod
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x285D670", Offset = "0x285BC70", VA = "0x18285D670")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x285D810", Offset = "0x285BE10", VA = "0x18285D810")]
		internal void ValidateEncryption()
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x285D930", Offset = "0x285BF30", VA = "0x18285D930")]
		private void ValidateCompression()
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x285DA00", Offset = "0x285C000", VA = "0x18285DA00")]
		private void SetupCryptoForExtract(string password)
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x285DAF0", Offset = "0x285C0F0", VA = "0x18285DAF0")]
		private bool ValidateOutput(string basedir, Stream outstream, out string outFileName)
		{
			return default(bool);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x285DF00", Offset = "0x285C500", VA = "0x18285DF00")]
		private void ReadExtraField()
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x285E0F0", Offset = "0x285C6F0", VA = "0x18285E0F0")]
		private static bool ReadHeader(ZipEntry ze, Encoding defaultEncoding)
		{
			return default(bool);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x285EB30", Offset = "0x285D130", VA = "0x18285EB30")]
		internal static int ReadWeakEncryptionHeader(Stream s, byte[] buffer)
		{
			return 0;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x285EC10", Offset = "0x285D210", VA = "0x18285EC10")]
		private static bool IsNotValidSig(int signature)
		{
			return default(bool);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x285EC20", Offset = "0x285D220", VA = "0x18285EC20")]
		internal static ZipEntry ReadEntry(ZipContainer zc, bool first)
		{
			return null;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x285EF70", Offset = "0x285D570", VA = "0x18285EF70")]
		internal static void HandlePK00Prefix(Stream s)
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x285F040", Offset = "0x285D640", VA = "0x18285F040")]
		private static void HandleUnexpectedDataDescriptor(ZipEntry entry)
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x285F210", Offset = "0x285D810", VA = "0x18285F210")]
		internal static int FindExtraFieldSegment(byte[] extra, int offx, ushort targetHeaderId)
		{
			return 0;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x285F2E0", Offset = "0x285D8E0", VA = "0x18285F2E0")]
		internal int ProcessExtraField(Stream s, short extraFieldLength)
		{
			return 0;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x285F5C0", Offset = "0x285DBC0", VA = "0x18285F5C0")]
		private int ProcessExtraFieldPkwareStrongEncryption(byte[] Buffer, int j)
		{
			return 0;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x285F630", Offset = "0x285DC30", VA = "0x18285F630")]
		private int ProcessExtraFieldZip64(byte[] buffer, int j, short dataSize, long posn)
		{
			return 0;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x285F710", Offset = "0x285DD10", VA = "0x18285F710")]
		private int ProcessExtraFieldInfoZipTimes(byte[] buffer, int j, short dataSize, long posn)
		{
			return 0;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x285F940", Offset = "0x285DF40", VA = "0x18285F940")]
		private int ProcessExtraFieldUnixTimes(byte[] buffer, int j, short dataSize, long posn)
		{
			return 0;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x285FA20", Offset = "0x285E020", VA = "0x18285FA20")]
		private int ProcessExtraFieldWindowsTimes(byte[] buffer, int j, short dataSize, long posn)
		{
			return 0;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x285FCA0", Offset = "0x285E2A0", VA = "0x18285FCA0")]
		internal void WriteCentralDirectoryEntry(Stream s)
		{
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2860410", Offset = "0x285EA10", VA = "0x182860410")]
		private byte[] ConstructExtraField(bool forCentralDirectory)
		{
			return null;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2860C30", Offset = "0x285F230", VA = "0x182860C30")]
		private string NormalizeFileName()
		{
			return null;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2860E00", Offset = "0x285F400", VA = "0x182860E00")]
		private byte[] GetEncodedFileNameBytes()
		{
			return null;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2861450", Offset = "0x285FA50", VA = "0x182861450")]
		private bool WantReadAgain()
		{
			return default(bool);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x28614E0", Offset = "0x285FAE0", VA = "0x1828614E0")]
		private void MaybeUnsetCompressionMethodForWriting(int cycle)
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2861610", Offset = "0x285FC10", VA = "0x182861610")]
		internal void WriteHeader(Stream s, int cycle)
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2862060", Offset = "0x2860660", VA = "0x182862060")]
		private int FigureCrc32()
		{
			return 0;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2862260", Offset = "0x2860860", VA = "0x182862260")]
		private void PrepSourceStream()
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2862410", Offset = "0x2860A10", VA = "0x182862410")]
		internal void CopyMetaData(ZipEntry source)
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x28624D0", Offset = "0x2860AD0", VA = "0x1828624D0")]
		private void OnWriteBlock(long bytesXferred, long totalBytesToXfer)
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x28626A0", Offset = "0x2860CA0", VA = "0x1828626A0")]
		private void _WriteEntryData(Stream s)
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2862AA0", Offset = "0x28610A0", VA = "0x182862AA0")]
		private long SetInputAndFigureFileLength(ref Stream input)
		{
			return 0L;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2862D90", Offset = "0x2861390", VA = "0x182862D90")]
		internal void FinishOutputStream(Stream s, CountingStream entryCounter, Stream encryptor, Stream compressor, CrcCalculatorStream output)
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2862F10", Offset = "0x2861510", VA = "0x182862F10")]
		internal void PostProcessOutput(Stream s)
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2863D20", Offset = "0x2862320", VA = "0x182863D20")]
		private void SetZip64Flags()
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2863E70", Offset = "0x2862470", VA = "0x182863E70")]
		internal void PrepOutputStream(Stream s, long streamLength, out CountingStream outputCounter, out Stream encryptor, out Stream compressor, out CrcCalculatorStream output)
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2864140", Offset = "0x2862740", VA = "0x182864140")]
		private Stream MaybeApplyCompression(Stream s, long streamLength)
		{
			return null;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x28647F0", Offset = "0x2862DF0", VA = "0x1828647F0")]
		private Stream MaybeApplyEncryption(Stream s)
		{
			return null;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2864880", Offset = "0x2862E80", VA = "0x182864880")]
		private void OnZipErrorWhileSaving(Exception e)
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x28648C0", Offset = "0x2862EC0", VA = "0x1828648C0")]
		internal void Write(Stream s)
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2864F40", Offset = "0x2863540", VA = "0x182864F40")]
		internal void StoreRelativeOffset()
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2864F50", Offset = "0x2863550", VA = "0x182864F50")]
		internal void NotifySaveComplete()
		{
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2864F80", Offset = "0x2863580", VA = "0x182864F80")]
		internal void WriteSecurityMetadata(Stream outstream)
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x28652A0", Offset = "0x28638A0", VA = "0x1828652A0")]
		private void CopyThroughOneEntry(Stream outStream)
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x28654F0", Offset = "0x2863AF0", VA = "0x1828654F0")]
		private void CopyThroughWithRecompute(Stream outstream)
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2865A10", Offset = "0x2864010", VA = "0x182865A10")]
		private void CopyThroughWithNoChange(Stream outstream)
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2865BE0", Offset = "0x28641E0", VA = "0x182865BE0")]
		[Conditional("Trace")]
		private void TraceWriteLine(string format, params object[] varParams)
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00002808 File Offset: 0x00000A08
		// (set) Token: 0x0600012F RID: 303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002B")]
		public DateTime LastModified
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x2865E10", Offset = "0x2864410", VA = "0x182865E10")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x2865E20", Offset = "0x2864420", VA = "0x182865E20")]
			set
			{
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x1700002C")]
		private int BufferSize
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x2865F20", Offset = "0x2864520", VA = "0x182865F20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00002838 File Offset: 0x00000A38
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002D")]
		public DateTime ModifiedTime
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x2865FA0", Offset = "0x28645A0", VA = "0x182865FA0")]
			set
			{
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00002850 File Offset: 0x00000A50
		// (set) Token: 0x06000134 RID: 308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002E")]
		public DateTime AccessedTime
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x2865FD0", Offset = "0x28645D0", VA = "0x182865FD0")]
			set
			{
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00002868 File Offset: 0x00000A68
		// (set) Token: 0x06000136 RID: 310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002F")]
		public DateTime CreationTime
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x2866000", Offset = "0x2864600", VA = "0x182866000")]
			set
			{
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2866020", Offset = "0x2864620", VA = "0x182866020")]
		public void SetEntryTimes(DateTime created, DateTime accessed, DateTime modified)
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00002880 File Offset: 0x00000A80
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000030")]
		public bool EmitTimesInWindowsFormatWhenSaving
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x2866320", Offset = "0x2864920", VA = "0x182866320")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x2866330", Offset = "0x2864930", VA = "0x182866330")]
			set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00002898 File Offset: 0x00000A98
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000031")]
		public bool EmitTimesInUnixFormatWhenSaving
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x2866340", Offset = "0x2864940", VA = "0x182866340")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x2866350", Offset = "0x2864950", VA = "0x182866350")]
			set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600013C RID: 316 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x17000032")]
		public ZipEntryTimestamp Timestamp
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x2866360", Offset = "0x2864960", VA = "0x182866360")]
			get
			{
				return ZipEntryTimestamp.None;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600013D RID: 317 RVA: 0x000028C8 File Offset: 0x00000AC8
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000033")]
		public FileAttributes Attributes
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
			get
			{
				return (FileAttributes)0;
			}
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x2866370", Offset = "0x2864970", VA = "0x182866370")]
			set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600013F RID: 319 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000034")]
		internal string LocalFileName
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000140 RID: 320 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000035")]
		public string FileName
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x2866390", Offset = "0x2864990", VA = "0x182866390")]
			set
			{
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000142 RID: 322 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000036")]
		public Stream InputStream
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x28665B0", Offset = "0x2864BB0", VA = "0x1828665B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x28665C0", Offset = "0x2864BC0", VA = "0x1828665C0")]
			set
			{
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000144 RID: 324 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x17000037")]
		public bool InputStreamWasJitProvided
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x27E78E0", Offset = "0x27E5EE0", VA = "0x1827E78E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000145 RID: 325 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x17000038")]
		public ZipEntrySource Source
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x27E7B40", Offset = "0x27E6140", VA = "0x1827E7B40")]
			get
			{
				return ZipEntrySource.None;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x17000039")]
		public short VersionNeeded
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x252E4C0", Offset = "0x252CAC0", VA = "0x18252E4C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000147 RID: 327 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003A")]
		public string Comment
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x5EE390", Offset = "0x5EC990", VA = "0x1805EE390")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x2866680", Offset = "0x2864C80", VA = "0x182866680")]
			set
			{
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x1700003B")]
		public bool? RequiresZip64
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x28666F0", Offset = "0x2864CF0", VA = "0x1828666F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x1700003C")]
		public bool? OutputUsedZip64
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x2866700", Offset = "0x2864D00", VA = "0x182866700")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x1700003D")]
		public short BitField
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x25A7250", Offset = "0x25A5850", VA = "0x1825A7250")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00002970 File Offset: 0x00000B70
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003E")]
		public CompressionMethod CompressionMethod
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x2866710", Offset = "0x2864D10", VA = "0x182866710")]
			get
			{
				return CompressionMethod.None;
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x2866720", Offset = "0x2864D20", VA = "0x182866720")]
			set
			{
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00002988 File Offset: 0x00000B88
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003F")]
		public CompressionLevel CompressionLevel
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0xAFF2D0", Offset = "0xAFD8D0", VA = "0x180AFF2D0")]
			get
			{
				return CompressionLevel.None;
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x28667F0", Offset = "0x2864DF0", VA = "0x1828667F0")]
			set
			{
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000150 RID: 336 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x17000040")]
		public long CompressedSize
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x751010", Offset = "0x74F610", VA = "0x180751010")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000151 RID: 337 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x17000041")]
		public long UncompressedSize
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x671190", Offset = "0x66F790", VA = "0x180671190")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000152 RID: 338 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x17000042")]
		public double CompressionRatio
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x2866870", Offset = "0x2864E70", VA = "0x182866870")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000153 RID: 339 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x17000043")]
		public int Crc
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0xAFF420", Offset = "0xAFDA20", VA = "0x180AFF420")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x17000044")]
		public bool IsDirectory
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0xA53170", Offset = "0xA51770", VA = "0x180A53170")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x17000045")]
		public bool UsesEncryption
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x28668B0", Offset = "0x2864EB0", VA = "0x1828668B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00002A30 File Offset: 0x00000C30
		// (set) Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000046")]
		public EncryptionAlgorithm Encryption
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x27E7B50", Offset = "0x27E6150", VA = "0x1827E7B50")]
			get
			{
				return EncryptionAlgorithm.None;
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x28668C0", Offset = "0x2864EC0", VA = "0x1828668C0")]
			set
			{
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000047")]
		public string Password
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x61C550", Offset = "0x61AB50", VA = "0x18061C550")]
			private get
			{
				return null;
			}
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x2866960", Offset = "0x2864F60", VA = "0x182866960")]
			set
			{
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x17000048")]
		internal bool IsChanged
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x2866A00", Offset = "0x2865000", VA = "0x182866A00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00002A60 File Offset: 0x00000C60
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000049")]
		public ExtractExistingFileAction ExtractExistingFile
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x68A5C0", Offset = "0x688BC0", VA = "0x18068A5C0")]
			[CompilerGenerated]
			get
			{
				return ExtractExistingFileAction.Throw;
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x2866A20", Offset = "0x2865020", VA = "0x182866A20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00002A78 File Offset: 0x00000C78
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004A")]
		public ZipErrorAction ZipErrorAction
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x268EBD0", Offset = "0x268D1D0", VA = "0x18268EBD0")]
			[CompilerGenerated]
			get
			{
				return ZipErrorAction.Throw;
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x2866A30", Offset = "0x2865030", VA = "0x182866A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x1700004B")]
		public bool IncludedInMostRecentSave
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x2866A40", Offset = "0x2865040", VA = "0x182866A40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000160 RID: 352 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004C")]
		public SetCompressionCallback SetCompression
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x2866A50", Offset = "0x2865050", VA = "0x182866A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x2866A60", Offset = "0x2865060", VA = "0x182866A60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00002AA8 File Offset: 0x00000CA8
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004D")]
		[Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete.  It will be removed in a future version of the library. Your applications should  use AlternateEncoding and AlternateEncodingUsage instead.")]
		public bool UseUnicodeAsNecessary
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x2866AC0", Offset = "0x28650C0", VA = "0x182866AC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x2866B30", Offset = "0x2865130", VA = "0x182866B30")]
			set
			{
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000164 RID: 356 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004E")]
		[Obsolete("This property is obsolete since v1.9.1.6. Use AlternateEncoding and AlternateEncodingUsage instead.", true)]
		public Encoding ProvisionalAlternateEncoding
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x2638550", Offset = "0x2636B50", VA = "0x182638550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x2866CB0", Offset = "0x28652B0", VA = "0x182866CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000166 RID: 358 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004F")]
		public Encoding AlternateEncoding
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0xA04070", Offset = "0xA02670", VA = "0x180A04070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x2866D10", Offset = "0x2865310", VA = "0x182866D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00002AC0 File Offset: 0x00000CC0
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000050")]
		public ZipOption AlternateEncodingUsage
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x2638FB0", Offset = "0x26375B0", VA = "0x182638FB0")]
			[CompilerGenerated]
			get
			{
				return ZipOption.Default;
			}
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x2866D70", Offset = "0x2865370", VA = "0x182866D70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2866D80", Offset = "0x2865380", VA = "0x182866D80")]
		internal static string NameInArchive(string filename, string directoryPathInArchive)
		{
			return null;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2866E40", Offset = "0x2865440", VA = "0x182866E40")]
		internal static ZipEntry CreateFromNothing(string nameInArchive)
		{
			return null;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2866EA0", Offset = "0x28654A0", VA = "0x182866EA0")]
		internal static ZipEntry CreateFromFile(string filename, string nameInArchive)
		{
			return null;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x2866F10", Offset = "0x2865510", VA = "0x182866F10")]
		internal static ZipEntry CreateForStream(string entryName, Stream s)
		{
			return null;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2866F80", Offset = "0x2865580", VA = "0x182866F80")]
		internal static ZipEntry CreateForWriter(string entryName, WriteDelegate d)
		{
			return null;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x2866FF0", Offset = "0x28655F0", VA = "0x182866FF0")]
		internal static ZipEntry CreateForJitStreamProvider(string nameInArchive, OpenDelegate opener, CloseDelegate closer)
		{
			return null;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x2867070", Offset = "0x2865670", VA = "0x182867070")]
		internal static ZipEntry CreateForZipOutputStream(string nameInArchive)
		{
			return null;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x28670D0", Offset = "0x28656D0", VA = "0x1828670D0")]
		private static ZipEntry Create(string nameInArchive, ZipEntrySource source, object arg1, object arg2)
		{
			return null;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x2867560", Offset = "0x2865B60", VA = "0x182867560")]
		internal void MarkAsDirectory()
		{
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00002AD8 File Offset: 0x00000CD8
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000051")]
		public bool IsText
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x2867610", Offset = "0x2865C10", VA = "0x182867610")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x2867620", Offset = "0x2865C20", VA = "0x182867620")]
			set
			{
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2867630", Offset = "0x2865C30", VA = "0x182867630", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000176 RID: 374 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000052")]
		internal Stream ArchiveStream
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x2867670", Offset = "0x2865C70", VA = "0x182867670")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2867920", Offset = "0x2865F20", VA = "0x182867920")]
		private void SetFdpLoh()
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2867C40", Offset = "0x2866240", VA = "0x182867C40")]
		internal static int GetLengthOfCryptoHeaderBytes(EncryptionAlgorithm a)
		{
			return 0;
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x17000053")]
		internal long FileDataPosition
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x2867CB0", Offset = "0x28662B0", VA = "0x182867CB0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x17000054")]
		private int LengthOfHeader
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x2867CF0", Offset = "0x28662F0", VA = "0x182867CF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private short _VersionMadeBy;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		private short _InternalFileAttrs;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int _ExternalFileAttrs;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private short _filenameLength;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		private short _extraFieldLength;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private short _commentLength;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Stream _inputDecryptorStream;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _readExtraDepth;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private object _outputLock;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ZipCrypto _zipCrypto_forExtract;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ZipCrypto _zipCrypto_forWrite;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal DateTime _LastModified;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private DateTime _Mtime;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private DateTime _Atime;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private DateTime _Ctime;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _ntfsTimesAreSet;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool _emitNtfsTimes;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool _emitUnixTimes;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool _TrimVolumeFromFullyQualifiedPaths;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal string _LocalFileName;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string _FileNameInArchive;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal short _VersionNeeded;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
		internal short _BitField;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		internal short _CompressionMethod;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x86")]
		private short _CompressionMethod_FromZipFile;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private CompressionLevel _CompressionLevel;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal string _Comment;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool _IsDirectory;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private byte[] _CommentBytes;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		internal long _CompressedSize;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		internal long _CompressedFileDataSize;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		internal long _UncompressedSize;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal int _TimeBlob;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool _crcCalculated;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		internal int _Crc32;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		internal byte[] _Extra;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool _metadataChanged;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		private bool _restreamRequiredOnSave;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDA")]
		private bool _sourceIsEncrypted;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDB")]
		private bool _skippedDuringSave;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private uint _diskNumber;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Encoding ibm437;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Encoding _actualEncoding;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		internal ZipContainer _container;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private long __FileDataPosition;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private byte[] _EntryHeader;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		internal long _RelativeOffsetOfLocalHeader;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private long _future_ROLH;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private long _TotalEntrySize;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private int _LengthOfHeader;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private int _LengthOfTrailer;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		internal bool _InputUsesZip64;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private uint _UnsupportedAlgorithmId;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		internal string _Password;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		internal ZipEntrySource _Source;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		internal EncryptionAlgorithm _Encryption;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		internal EncryptionAlgorithm _Encryption_FromZipFile;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		internal byte[] _WeakEncryptionHeader;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		internal Stream _archiveStream;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Stream _sourceStream;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private long? _sourceStreamOriginalPosition;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private bool _sourceWasJitProvided;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x169")]
		private bool _ioOperationCanceled;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16A")]
		private bool _presumeZip64;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16B")]
		private bool? _entryRequiresZip64;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16D")]
		private bool? _OutputUsesZip64;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16F")]
		private bool _IsText;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private ZipEntryTimestamp _timestamp;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DateTime _unixEpoch;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DateTime _win32Epoch;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DateTime _zeroHour;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private WriteDelegate _WriteDelegate;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private OpenDelegate _OpenDelegate;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private CloseDelegate _CloseDelegate;

		// Token: 0x0200002B RID: 43
		[Token(Token = "0x200002B")]
		private class CopyHelper
		{
			// Token: 0x0600017B RID: 379 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public CopyHelper()
			{
			}

			// Token: 0x0600017D RID: 381 RVA: 0x000020B2 File Offset: 0x000002B2
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x2867E60", Offset = "0x2866460", VA = "0x182867E60")]
			internal static string AppendCopyToFileName(string f)
			{
				return null;
			}

			// Token: 0x040000C8 RID: 200
			[Token(Token = "0x40000C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static Regex re;

			// Token: 0x040000C9 RID: 201
			[Token(Token = "0x40000C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static int callCount;
		}

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x0600017F RID: 383
		[Token(Token = "0x200002C")]
		private delegate T Func<T>();
	}
}
