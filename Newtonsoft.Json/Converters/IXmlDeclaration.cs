using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001C5 RID: 453
	[Token(Token = "0x20001C5")]
	[NullableContext(2)]
	internal interface IXmlDeclaration : IXmlNode
	{
		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000F3A RID: 3898
		[Token(Token = "0x17000269")]
		string Version { [Token(Token = "0x6000F3A")] get; }

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000F3B RID: 3899
		// (set) Token: 0x06000F3C RID: 3900
		[Token(Token = "0x1700026A")]
		string Encoding { [Token(Token = "0x6000F3B")] get; [Token(Token = "0x6000F3C")] set; }

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000F3D RID: 3901
		// (set) Token: 0x06000F3E RID: 3902
		[Token(Token = "0x1700026B")]
		string Standalone { [Token(Token = "0x6000F3D")] get; [Token(Token = "0x6000F3E")] set; }
	}
}
