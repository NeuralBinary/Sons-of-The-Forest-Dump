using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	public sealed class TypeInfo
	{
		// Token: 0x06000231 RID: 561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x992FC0", Offset = "0x9915C0", VA = "0x180992FC0")]
		private TypeInfo(Type current, IEnumerable<Type> choices)
		{
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006C")]
		public Type Current
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006D")]
		public IEnumerable<Type> Choices
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x993070", Offset = "0x991670", VA = "0x180993070")]
		internal static TypeInfo Create(Type current)
		{
			return null;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x9930F0", Offset = "0x9916F0", VA = "0x1809930F0")]
		internal static TypeInfo Create(Type current, IEnumerable<Type> choices)
		{
			return null;
		}

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x10")]
		private readonly Type current;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x18")]
		private readonly IEnumerable<Type> choices;
	}
}
