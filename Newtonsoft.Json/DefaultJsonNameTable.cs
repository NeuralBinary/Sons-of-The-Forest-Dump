using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[NullableContext(1)]
	[Nullable(0)]
	public class DefaultJsonNameTable : JsonNameTable
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x24EB0E0", Offset = "0x24E96E0", VA = "0x1824EB0E0")]
		public DefaultJsonNameTable()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x24EB170", Offset = "0x24E9770", VA = "0x1824EB170", Slot = "4")]
		public override string Get(char[] key, int start, int length)
		{
			return null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x24EB350", Offset = "0x24E9950", VA = "0x1824EB350")]
		public string Add(string key)
		{
			return null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x24EB580", Offset = "0x24E9B80", VA = "0x1824EB580")]
		private string AddEntry(string str, int hashCode)
		{
			return null;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x24EB890", Offset = "0x24E9E90", VA = "0x1824EB890")]
		private void Grow()
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x24EBA30", Offset = "0x24EA030", VA = "0x1824EBA30")]
		private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length)
		{
			return default(bool);
		}

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int HashCodeRandomizer;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x10")]
		private int _count;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x18")]
		private DefaultJsonNameTable.Entry[] _entries;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x20")]
		private int _mask;

		// Token: 0x02000010 RID: 16
		[Token(Token = "0x2000010")]
		[Nullable(0)]
		private class Entry
		{
			// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x24EBAB0", Offset = "0x24EA0B0", VA = "0x1824EBAB0")]
			internal Entry(string value, int hashCode, DefaultJsonNameTable.Entry next)
			{
			}

			// Token: 0x04000018 RID: 24
			[Token(Token = "0x4000018")]
			[FieldOffset(Offset = "0x10")]
			internal readonly string Value;

			// Token: 0x04000019 RID: 25
			[Token(Token = "0x4000019")]
			[FieldOffset(Offset = "0x18")]
			internal readonly int HashCode;

			// Token: 0x0400001A RID: 26
			[Token(Token = "0x400001A")]
			[FieldOffset(Offset = "0x20")]
			internal DefaultJsonNameTable.Entry Next;
		}
	}
}
