using System;
using Il2CppDummyDll;

namespace Pathfinding.Serialization
{
	// Token: 0x02000126 RID: 294
	[Token(Token = "0x2000126")]
	public class SerializeSettings
	{
		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000147")]
		public static SerializeSettings Settings
		{
			[Token(Token = "0x6000977")]
			[Address(RVA = "0x704EC0", Offset = "0x7034C0", VA = "0x180704EC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000978")]
		[Address(RVA = "0x704F00", Offset = "0x703500", VA = "0x180704F00")]
		public SerializeSettings()
		{
		}

		// Token: 0x0400068A RID: 1674
		[Token(Token = "0x400068A")]
		[FieldOffset(Offset = "0x10")]
		public bool nodes;

		// Token: 0x0400068B RID: 1675
		[Token(Token = "0x400068B")]
		[FieldOffset(Offset = "0x11")]
		[Obsolete("There is no support for pretty printing the json anymore")]
		public bool prettyPrint;

		// Token: 0x0400068C RID: 1676
		[Token(Token = "0x400068C")]
		[FieldOffset(Offset = "0x12")]
		public bool editorSettings;
	}
}
