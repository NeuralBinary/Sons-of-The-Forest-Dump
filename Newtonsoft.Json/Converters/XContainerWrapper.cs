using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001CF RID: 463
	[Token(Token = "0x20001CF")]
	[Nullable(0)]
	[NullableContext(1)]
	internal class XContainerWrapper : XObjectWrapper
	{
		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000F7F RID: 3967 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000290")]
		private XContainer Container
		{
			[Token(Token = "0x6000F7F")]
			[Address(RVA = "0x25FE5E0", Offset = "0x25FCBE0", VA = "0x1825FE5E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F80")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public XContainerWrapper(XContainer container)
		{
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000291")]
		public override List<IXmlNode> ChildNodes
		{
			[Token(Token = "0x6000F81")]
			[Address(RVA = "0x25FE650", Offset = "0x25FCC50", VA = "0x1825FE650", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x00006F48 File Offset: 0x00005148
		[Token(Token = "0x17000292")]
		protected virtual bool HasChildNodes
		{
			[Token(Token = "0x6000F82")]
			[Address(RVA = "0x25FEA60", Offset = "0x25FD060", VA = "0x1825FEA60", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000F83 RID: 3971 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000293")]
		[Nullable(2)]
		public override IXmlNode ParentNode
		{
			[Token(Token = "0x6000F83")]
			[Address(RVA = "0x25FEA90", Offset = "0x25FD090", VA = "0x1825FEA90", Slot = "18")]
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F84")]
		[Address(RVA = "0x25FEAF0", Offset = "0x25FD0F0", VA = "0x1825FEAF0")]
		internal static IXmlNode WrapNode(XObject node)
		{
			return null;
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F85")]
		[Address(RVA = "0x25FEF90", Offset = "0x25FD590", VA = "0x1825FEF90", Slot = "21")]
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}

		// Token: 0x0400081A RID: 2074
		[Token(Token = "0x400081A")]
		[FieldOffset(Offset = "0x18")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IXmlNode> _childNodes;
	}
}
