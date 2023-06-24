using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace CommandLine.Core
{
	// Token: 0x02000117 RID: 279
	[Token(Token = "0x2000117")]
	internal sealed class Verb
	{
		// Token: 0x06000632 RID: 1586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x9C5600", Offset = "0x9C3C00", VA = "0x1809C5600")]
		public Verb(string name, string helpText, bool hidden, bool isDefault, string[] aliases)
		{
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000634 RID: 1588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000EB")]
		public string Name
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000636 RID: 1590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000EC")]
		public string HelpText
		{
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x00004008 File Offset: 0x00002208
		// (set) Token: 0x06000638 RID: 1592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000ED")]
		public bool Hidden
		{
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000638")]
			[Address(RVA = "0x7AAFD0", Offset = "0x7A95D0", VA = "0x1807AAFD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x00004020 File Offset: 0x00002220
		// (set) Token: 0x0600063A RID: 1594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000EE")]
		public bool IsDefault
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x9938E0", Offset = "0x991EE0", VA = "0x1809938E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x9C5820", Offset = "0x9C3E20", VA = "0x1809C5820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600063C RID: 1596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000EF")]
		public string[] Aliases
		{
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x9C5830", Offset = "0x9C3E30", VA = "0x1809C5830")]
		public static Verb FromAttribute(VerbAttribute attribute)
		{
			return null;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x9C5930", Offset = "0x9C3F30", VA = "0x1809C5930")]
		public static IEnumerable<Tuple<Verb, Type>> SelectFromTypes(IEnumerable<Type> types)
		{
			return null;
		}
	}
}
