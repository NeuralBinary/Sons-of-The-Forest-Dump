using System;
using Il2CppDummyDll;
using Pathfinding.Serialization;

namespace Pathfinding
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	[JsonOptIn]
	public class GraphEditorBase
	{
		// Token: 0x06000307 RID: 775 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public GraphEditorBase()
		{
		}

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x10")]
		public NavGraph target;
	}
}
