using System;
using Il2CppDummyDll;

namespace CommandLine.Core
{
	// Token: 0x020000F7 RID: 247
	[Token(Token = "0x20000F7")]
	internal class Value : Token, IEquatable<Value>
	{
		// Token: 0x060005A2 RID: 1442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x9BB280", Offset = "0x9B9880", VA = "0x1809BB280")]
		public Value(string text)
		{
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x9BB2E0", Offset = "0x9B98E0", VA = "0x1809BB2E0")]
		public Value(string text, bool explicitlyAssigned)
		{
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x9BB340", Offset = "0x9B9940", VA = "0x1809BB340")]
		public Value(string text, bool explicitlyAssigned, bool forced, bool fromSeparator)
		{
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00003C48 File Offset: 0x00001E48
		[Token(Token = "0x170000DD")]
		public bool ExplicitlyAssigned
		{
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x00003C60 File Offset: 0x00001E60
		[Token(Token = "0x170000DE")]
		public bool FromSeparator
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x993970", Offset = "0x991F70", VA = "0x180993970")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00003C78 File Offset: 0x00001E78
		[Token(Token = "0x170000DF")]
		public bool Forced
		{
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x9938E0", Offset = "0x991EE0", VA = "0x1809938E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00003C90 File Offset: 0x00001E90
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x9BB3B0", Offset = "0x9B99B0", VA = "0x1809BB3B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00003CA8 File Offset: 0x00001EA8
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x9BB500", Offset = "0x9B9B00", VA = "0x1809BB500", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00003CC0 File Offset: 0x00001EC0
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x9BB5D0", Offset = "0x9B9BD0", VA = "0x1809BB5D0", Slot = "4")]
		public bool Equals(Value other)
		{
			return default(bool);
		}

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x20")]
		private readonly bool explicitlyAssigned;

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x21")]
		private readonly bool forced;

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x22")]
		private readonly bool fromSeparator;
	}
}
