using System;
using Il2CppDummyDll;

namespace Construction.Tutorials
{
	// Token: 0x0200027E RID: 638
	[Token(Token = "0x200027E")]
	[Serializable]
	public class ConstructionTutorial
	{
		// Token: 0x06001387 RID: 4999 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001387")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ConstructionTutorial()
		{
		}

		// Token: 0x04000980 RID: 2432
		[Token(Token = "0x4000980")]
		[FieldOffset(Offset = "0x10")]
		protected bool _displayingTutorial;

		// Token: 0x04000981 RID: 2433
		[Token(Token = "0x4000981")]
		[FieldOffset(Offset = "0x11")]
		protected bool _completed;
	}
}
