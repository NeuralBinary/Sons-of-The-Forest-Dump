using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000153 RID: 339
	[Token(Token = "0x2000153")]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public class ValidationEventArgs : EventArgs
	{
		// Token: 0x06000AD9 RID: 2777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x25B4210", Offset = "0x25B2810", VA = "0x1825B4210")]
		internal ValidationEventArgs(JsonSchemaException ex)
		{
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170001C8")]
		public JsonSchemaException Exception
		{
			[Token(Token = "0x6000ADA")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170001C9")]
		public string Path
		{
			[Token(Token = "0x6000ADB")]
			[Address(RVA = "0x25B4310", Offset = "0x25B2910", VA = "0x1825B4310")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170001CA")]
		public string Message
		{
			[Token(Token = "0x6000ADC")]
			[Address(RVA = "0x25B4330", Offset = "0x25B2930", VA = "0x1825B4330")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000656 RID: 1622
		[Token(Token = "0x4000656")]
		[FieldOffset(Offset = "0x10")]
		private readonly JsonSchemaException _ex;
	}
}
