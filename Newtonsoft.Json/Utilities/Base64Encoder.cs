using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000096 RID: 150
	[Token(Token = "0x2000096")]
	[Nullable(0)]
	[NullableContext(1)]
	internal class Base64Encoder
	{
		// Token: 0x060004ED RID: 1261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x254E110", Offset = "0x254C710", VA = "0x18254E110")]
		public Base64Encoder(TextWriter writer)
		{
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x254E270", Offset = "0x254C870", VA = "0x18254E270")]
		private void ValidateEncode(byte[] buffer, int index, int count)
		{
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x254E3D0", Offset = "0x254C9D0", VA = "0x18254E3D0")]
		public void Encode(byte[] buffer, int index, int count)
		{
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x254E5E0", Offset = "0x254CBE0", VA = "0x18254E5E0")]
		private void StoreLeftOverBytes(byte[] buffer, int index, ref int count)
		{
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00003288 File Offset: 0x00001488
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x254E700", Offset = "0x254CD00", VA = "0x18254E700")]
		private bool FulfillFromLeftover(byte[] buffer, int index, ref int count)
		{
			return default(bool);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x254E7B0", Offset = "0x254CDB0", VA = "0x18254E7B0")]
		public void Flush()
		{
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x254E880", Offset = "0x254CE80", VA = "0x18254E880")]
		private void WriteChars(char[] chars, int index, int count)
		{
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x254E8B0", Offset = "0x254CEB0", VA = "0x18254E8B0")]
		public Task EncodeAsync(byte[] buffer, int index, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x254EB10", Offset = "0x254D110", VA = "0x18254EB10")]
		private Task WriteCharsAsync(char[] chars, int index, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x254EBA0", Offset = "0x254D1A0", VA = "0x18254EBA0")]
		public Task FlushAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0400036E RID: 878
		[Token(Token = "0x400036E")]
		private const int Base64LineSize = 76;

		// Token: 0x0400036F RID: 879
		[Token(Token = "0x400036F")]
		private const int LineSizeInBytes = 57;

		// Token: 0x04000370 RID: 880
		[Token(Token = "0x4000370")]
		[FieldOffset(Offset = "0x10")]
		private readonly char[] _charsLine;

		// Token: 0x04000371 RID: 881
		[Token(Token = "0x4000371")]
		[FieldOffset(Offset = "0x18")]
		private readonly TextWriter _writer;

		// Token: 0x04000372 RID: 882
		[Token(Token = "0x4000372")]
		[FieldOffset(Offset = "0x20")]
		[Nullable(2)]
		private byte[] _leftOverBytes;

		// Token: 0x04000373 RID: 883
		[Token(Token = "0x4000373")]
		[FieldOffset(Offset = "0x28")]
		private int _leftOverBytesCount;
	}
}
