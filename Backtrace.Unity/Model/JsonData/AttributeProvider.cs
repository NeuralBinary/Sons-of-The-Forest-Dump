using System;
using System.Collections.Generic;
using Backtrace.Unity.Model.Attributes;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.JsonData
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	public sealed class AttributeProvider
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000065")]
		public string ApplicationVersion
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x758910", Offset = "0x756F10", VA = "0x180758910")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000066")]
		public string ApplicationSessionKey
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x758990", Offset = "0x756F90", VA = "0x180758990")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000067")]
		public string ApplicationGuid
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x758A90", Offset = "0x757090", VA = "0x180758A90")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x758B10", Offset = "0x757110", VA = "0x180758B10")]
		internal AttributeProvider()
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x758EE0", Offset = "0x7574E0", VA = "0x180758EE0")]
		internal AttributeProvider(IEnumerable<IScopeAttributeProvider> scopeAttributeProvider, IList<IDynamicAttributeProvider> dynamicAttributeProvider)
		{
		}

		// Token: 0x17000068 RID: 104
		[Token(Token = "0x17000068")]
		public string this[string index]
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x7592D0", Offset = "0x7578D0", VA = "0x1807592D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x759330", Offset = "0x757930", VA = "0x180759330")]
			set
			{
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002A14 File Offset: 0x00000C14
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x7593A0", Offset = "0x7579A0", VA = "0x1807593A0")]
		public int Count()
		{
			return 0;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x7593F0", Offset = "0x7579F0", VA = "0x1807593F0")]
		public void AddDynamicAttributeProvider(IDynamicAttributeProvider attributeProvider)
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x759450", Offset = "0x757A50", VA = "0x180759450")]
		internal void AddScopedAttributeProvider(IScopeAttributeProvider attributeProvider)
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x7594B0", Offset = "0x757AB0", VA = "0x1807594B0")]
		internal void AddAttributes(IDictionary<string, string> source, bool includeDynamic = true)
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x7599A0", Offset = "0x757FA0", VA = "0x1807599A0")]
		internal IDictionary<string, string> GenerateAttributes(bool includeDynamic = true)
		{
			return null;
		}

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x10")]
		private readonly IDictionary<string, string> _attributes;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x18")]
		private readonly IList<IDynamicAttributeProvider> _dynamicAttributeProvider;
	}
}
