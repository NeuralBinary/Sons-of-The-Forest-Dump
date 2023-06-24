using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001D5 RID: 469
	[Token(Token = "0x20001D5")]
	internal class BsonBinaryWriter
	{
		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x000070B0 File Offset: 0x000052B0
		// (set) Token: 0x06000FCD RID: 4045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AB")]
		public DateTimeKind DateTimeKindHandling
		{
			[Token(Token = "0x6000FCC")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			[CompilerGenerated]
			get
			{
				return DateTimeKind.Unspecified;
			}
			[Token(Token = "0x6000FCD")]
			[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCE")]
		[Address(RVA = "0x2607850", Offset = "0x2605E50", VA = "0x182607850")]
		public BsonBinaryWriter(BinaryWriter writer)
		{
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCF")]
		[Address(RVA = "0x1FDD110", Offset = "0x1FDB710", VA = "0x181FDD110")]
		public void Flush()
		{
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD0")]
		[Address(RVA = "0x26078B0", Offset = "0x2605EB0", VA = "0x1826078B0")]
		public void Close()
		{
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD1")]
		[Address(RVA = "0x26078E0", Offset = "0x2605EE0", VA = "0x1826078E0")]
		public void WriteToken(BsonToken t)
		{
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD2")]
		[Address(RVA = "0x2607910", Offset = "0x2605F10", VA = "0x182607910")]
		private void WriteTokenInternal(BsonToken t)
		{
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD3")]
		[Address(RVA = "0x2608770", Offset = "0x2606D70", VA = "0x182608770")]
		private void WriteString(string s, int byteCount, int? calculatedlengthPrefix)
		{
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD4")]
		[Address(RVA = "0x2608970", Offset = "0x2606F70", VA = "0x182608970")]
		public void WriteUtf8Bytes(string s, int byteCount)
		{
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x000070C8 File Offset: 0x000052C8
		[Token(Token = "0x6000FD5")]
		[Address(RVA = "0x2608B00", Offset = "0x2607100", VA = "0x182608B00")]
		private int CalculateSize(int stringByteCount)
		{
			return 0;
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x000070E0 File Offset: 0x000052E0
		[Token(Token = "0x6000FD6")]
		[Address(RVA = "0x2608B10", Offset = "0x2607110", VA = "0x182608B10")]
		private int CalculateSizeWithLength(int stringByteCount, bool includeSize)
		{
			return 0;
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x000070F8 File Offset: 0x000052F8
		[Token(Token = "0x6000FD7")]
		[Address(RVA = "0x2608B20", Offset = "0x2607120", VA = "0x182608B20")]
		private int CalculateSize(BsonToken t)
		{
			return 0;
		}

		// Token: 0x04000831 RID: 2097
		[Token(Token = "0x4000831")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Encoding Encoding;

		// Token: 0x04000832 RID: 2098
		[Token(Token = "0x4000832")]
		[FieldOffset(Offset = "0x10")]
		private readonly BinaryWriter _writer;

		// Token: 0x04000833 RID: 2099
		[Token(Token = "0x4000833")]
		[FieldOffset(Offset = "0x18")]
		private byte[] _largeByteBuffer;
	}
}
