using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CommandLine.Infrastructure;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x02000082 RID: 130
	[Token(Token = "0x2000082")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
	public class VerbAttribute : Attribute
	{
		// Token: 0x060002D0 RID: 720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x995EC0", Offset = "0x9944C0", VA = "0x180995EC0")]
		public VerbAttribute(string name, bool isDefault = false, [Optional] string[] aliases)
		{
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000088")]
		public string Name
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x00002E98 File Offset: 0x00001098
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000089")]
		public bool Hidden
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x734A50", Offset = "0x733050", VA = "0x180734A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700008A")]
		public string HelpText
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x996150", Offset = "0x994750", VA = "0x180996150")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x9961B0", Offset = "0x9947B0", VA = "0x1809961B0")]
			set
			{
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700008B")]
		public Type ResourceType
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x996230", Offset = "0x994830", VA = "0x180996230")]
			set
			{
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x00002EB0 File Offset: 0x000010B0
		// (set) Token: 0x060002DA RID: 730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700008C")]
		public bool IsDefault
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x9962C0", Offset = "0x9948C0", VA = "0x1809962C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x9962D0", Offset = "0x9948D0", VA = "0x1809962D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060002DB RID: 731 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060002DC RID: 732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700008D")]
		public string[] Aliases
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly LocalizableAttributeProperty helpText;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Type resourceType;
	}
}
