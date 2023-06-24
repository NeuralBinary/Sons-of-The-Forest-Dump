using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000093 RID: 147
	[Token(Token = "0x2000093")]
	[NullableContext(1)]
	[Nullable(0)]
	internal static class AsyncUtils
	{
		// Token: 0x060004DC RID: 1244 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x254D7E0", Offset = "0x254BDE0", VA = "0x18254D7E0")]
		internal static Task<bool> ToAsync(this bool value)
		{
			return null;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x254D870", Offset = "0x254BE70", VA = "0x18254D870")]
		[NullableContext(2)]
		public static Task CancelIfRequestedAsync(this CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004DE")]
		[NullableContext(2)]
		public static Task<T> CancelIfRequestedAsync<T>(this CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x254D8E0", Offset = "0x254BEE0", VA = "0x18254D8E0")]
		public static Task FromCanceled(this CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004E0")]
		public static Task<T> FromCanceled<T>(this CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x254DAC0", Offset = "0x254C0C0", VA = "0x18254DAC0")]
		public static Task WriteAsync(this TextWriter writer, char value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x254DB70", Offset = "0x254C170", VA = "0x18254DB70")]
		public static Task WriteAsync(this TextWriter writer, [Nullable(2)] string value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x254DC20", Offset = "0x254C220", VA = "0x18254DC20")]
		public static Task WriteAsync(this TextWriter writer, char[] value, int start, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x254DCF0", Offset = "0x254C2F0", VA = "0x18254DCF0")]
		public static Task<int> ReadAsync(this TextReader reader, char[] buffer, int index, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00003270 File Offset: 0x00001470
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x254DDD0", Offset = "0x254C3D0", VA = "0x18254DDD0")]
		public static bool IsCompletedSuccessfully(this Task task)
		{
			return default(bool);
		}

		// Token: 0x04000367 RID: 871
		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Task<bool> False;

		// Token: 0x04000368 RID: 872
		[Token(Token = "0x4000368")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Task<bool> True;

		// Token: 0x04000369 RID: 873
		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly Task CompletedTask;
	}
}
