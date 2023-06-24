using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001CD RID: 461
	[Token(Token = "0x20001CD")]
	[NullableContext(2)]
	[Nullable(0)]
	internal class XCommentWrapper : XObjectWrapper
	{
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000F75 RID: 3957 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700028A")]
		[Nullable(1)]
		private XComment Text
		{
			[Token(Token = "0x6000F75")]
			[Address(RVA = "0x25FE100", Offset = "0x25FC700", VA = "0x1825FE100")]
			[NullableContext(1)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F76")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		[NullableContext(1)]
		public XCommentWrapper(XComment text)
		{
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000F77 RID: 3959 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000F78 RID: 3960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028B")]
		public override string Value
		{
			[Token(Token = "0x6000F77")]
			[Address(RVA = "0x25FE170", Offset = "0x25FC770", VA = "0x1825FE170", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F78")]
			[Address(RVA = "0x25FE190", Offset = "0x25FC790", VA = "0x1825FE190", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700028C")]
		public override IXmlNode ParentNode
		{
			[Token(Token = "0x6000F79")]
			[Address(RVA = "0x25FE330", Offset = "0x25FC930", VA = "0x1825FE330", Slot = "18")]
			get
			{
				return null;
			}
		}
	}
}
