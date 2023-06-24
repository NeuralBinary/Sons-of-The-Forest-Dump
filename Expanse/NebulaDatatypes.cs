using System;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace Expanse
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\directLight\\nebulae\\NebulaDatatypes.cs")]
	public class NebulaDatatypes
	{
		// Token: 0x06000356 RID: 854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NebulaDatatypes()
		{
		}

		// Token: 0x040003FA RID: 1018
		[Token(Token = "0x40003FA")]
		public const uint kMaxNebulaLayers = 4U;

		// Token: 0x02000050 RID: 80
		[Token(Token = "0x2000050")]
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\directLight\\nebulae\\NebulaDatatypes.cs")]
		public enum NebulaLayer
		{
			// Token: 0x040003FC RID: 1020
			[Token(Token = "0x40003FC")]
			Layer0,
			// Token: 0x040003FD RID: 1021
			[Token(Token = "0x40003FD")]
			Layer1,
			// Token: 0x040003FE RID: 1022
			[Token(Token = "0x40003FE")]
			Layer2,
			// Token: 0x040003FF RID: 1023
			[Token(Token = "0x40003FF")]
			Layer3
		}
	}
}
