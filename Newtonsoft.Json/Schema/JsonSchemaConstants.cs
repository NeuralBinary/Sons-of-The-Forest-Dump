using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000143 RID: 323
	[Token(Token = "0x2000143")]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	internal static class JsonSchemaConstants
	{
		// Token: 0x040005F2 RID: 1522
		[Token(Token = "0x40005F2")]
		public const string TypePropertyName = "type";

		// Token: 0x040005F3 RID: 1523
		[Token(Token = "0x40005F3")]
		public const string PropertiesPropertyName = "properties";

		// Token: 0x040005F4 RID: 1524
		[Token(Token = "0x40005F4")]
		public const string ItemsPropertyName = "items";

		// Token: 0x040005F5 RID: 1525
		[Token(Token = "0x40005F5")]
		public const string AdditionalItemsPropertyName = "additionalItems";

		// Token: 0x040005F6 RID: 1526
		[Token(Token = "0x40005F6")]
		public const string RequiredPropertyName = "required";

		// Token: 0x040005F7 RID: 1527
		[Token(Token = "0x40005F7")]
		public const string PatternPropertiesPropertyName = "patternProperties";

		// Token: 0x040005F8 RID: 1528
		[Token(Token = "0x40005F8")]
		public const string AdditionalPropertiesPropertyName = "additionalProperties";

		// Token: 0x040005F9 RID: 1529
		[Token(Token = "0x40005F9")]
		public const string RequiresPropertyName = "requires";

		// Token: 0x040005FA RID: 1530
		[Token(Token = "0x40005FA")]
		public const string MinimumPropertyName = "minimum";

		// Token: 0x040005FB RID: 1531
		[Token(Token = "0x40005FB")]
		public const string MaximumPropertyName = "maximum";

		// Token: 0x040005FC RID: 1532
		[Token(Token = "0x40005FC")]
		public const string ExclusiveMinimumPropertyName = "exclusiveMinimum";

		// Token: 0x040005FD RID: 1533
		[Token(Token = "0x40005FD")]
		public const string ExclusiveMaximumPropertyName = "exclusiveMaximum";

		// Token: 0x040005FE RID: 1534
		[Token(Token = "0x40005FE")]
		public const string MinimumItemsPropertyName = "minItems";

		// Token: 0x040005FF RID: 1535
		[Token(Token = "0x40005FF")]
		public const string MaximumItemsPropertyName = "maxItems";

		// Token: 0x04000600 RID: 1536
		[Token(Token = "0x4000600")]
		public const string PatternPropertyName = "pattern";

		// Token: 0x04000601 RID: 1537
		[Token(Token = "0x4000601")]
		public const string MaximumLengthPropertyName = "maxLength";

		// Token: 0x04000602 RID: 1538
		[Token(Token = "0x4000602")]
		public const string MinimumLengthPropertyName = "minLength";

		// Token: 0x04000603 RID: 1539
		[Token(Token = "0x4000603")]
		public const string EnumPropertyName = "enum";

		// Token: 0x04000604 RID: 1540
		[Token(Token = "0x4000604")]
		public const string ReadOnlyPropertyName = "readonly";

		// Token: 0x04000605 RID: 1541
		[Token(Token = "0x4000605")]
		public const string TitlePropertyName = "title";

		// Token: 0x04000606 RID: 1542
		[Token(Token = "0x4000606")]
		public const string DescriptionPropertyName = "description";

		// Token: 0x04000607 RID: 1543
		[Token(Token = "0x4000607")]
		public const string FormatPropertyName = "format";

		// Token: 0x04000608 RID: 1544
		[Token(Token = "0x4000608")]
		public const string DefaultPropertyName = "default";

		// Token: 0x04000609 RID: 1545
		[Token(Token = "0x4000609")]
		public const string TransientPropertyName = "transient";

		// Token: 0x0400060A RID: 1546
		[Token(Token = "0x400060A")]
		public const string DivisibleByPropertyName = "divisibleBy";

		// Token: 0x0400060B RID: 1547
		[Token(Token = "0x400060B")]
		public const string HiddenPropertyName = "hidden";

		// Token: 0x0400060C RID: 1548
		[Token(Token = "0x400060C")]
		public const string DisallowPropertyName = "disallow";

		// Token: 0x0400060D RID: 1549
		[Token(Token = "0x400060D")]
		public const string ExtendsPropertyName = "extends";

		// Token: 0x0400060E RID: 1550
		[Token(Token = "0x400060E")]
		public const string IdPropertyName = "id";

		// Token: 0x0400060F RID: 1551
		[Token(Token = "0x400060F")]
		public const string UniqueItemsPropertyName = "uniqueItems";

		// Token: 0x04000610 RID: 1552
		[Token(Token = "0x4000610")]
		public const string OptionValuePropertyName = "value";

		// Token: 0x04000611 RID: 1553
		[Token(Token = "0x4000611")]
		public const string OptionLabelPropertyName = "label";

		// Token: 0x04000612 RID: 1554
		[Token(Token = "0x4000612")]
		[FieldOffset(Offset = "0x0")]
		public static readonly IDictionary<string, JsonSchemaType> JsonSchemaTypeMapping;
	}
}
