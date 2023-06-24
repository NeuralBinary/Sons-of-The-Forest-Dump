using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	internal interface IFillableMpb
	{
		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000AB1 RID: 2737
		[Token(Token = "0x17000162")]
		List<float> fillType { [Token(Token = "0x6000AB1")] get; }

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000AB2 RID: 2738
		[Token(Token = "0x17000163")]
		List<float> fillSpace { [Token(Token = "0x6000AB2")] get; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000AB3 RID: 2739
		[Token(Token = "0x17000164")]
		List<Vector4> fillStart { [Token(Token = "0x6000AB3")] get; }

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000AB4 RID: 2740
		[Token(Token = "0x17000165")]
		List<Vector4> fillEnd { [Token(Token = "0x6000AB4")] get; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000AB5 RID: 2741
		[Token(Token = "0x17000166")]
		List<Vector4> fillColorEnd { [Token(Token = "0x6000AB5")] get; }
	}
}
