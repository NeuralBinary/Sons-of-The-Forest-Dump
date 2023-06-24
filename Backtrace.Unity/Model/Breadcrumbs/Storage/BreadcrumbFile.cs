using System;
using System.IO;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.Breadcrumbs.Storage
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	internal sealed class BreadcrumbFile : IBreadcrumbFile
	{
		// Token: 0x060002D7 RID: 727 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public BreadcrumbFile(string path)
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x761100", Offset = "0x75F700", VA = "0x180761100", Slot = "5")]
		public void Delete()
		{
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00002EF4 File Offset: 0x000010F4
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x7611E0", Offset = "0x75F7E0", VA = "0x1807611E0", Slot = "4")]
		public bool Exists()
		{
			return default(bool);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x7611F0", Offset = "0x75F7F0", VA = "0x1807611F0", Slot = "6")]
		public Stream GetCreateStream()
		{
			return null;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x761270", Offset = "0x75F870", VA = "0x180761270", Slot = "7")]
		public Stream GetIOStream()
		{
			return null;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x7612F0", Offset = "0x75F8F0", VA = "0x1807612F0", Slot = "8")]
		public Stream GetWriteStream()
		{
			return null;
		}

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x10")]
		private readonly string _path;
	}
}
