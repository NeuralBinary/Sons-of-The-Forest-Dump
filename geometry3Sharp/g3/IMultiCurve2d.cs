using System;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200010F RID: 271
	[Token(Token = "0x200010F")]
	public interface IMultiCurve2d
	{
		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000733 RID: 1843
		[Token(Token = "0x1700012E")]
		ReadOnlyCollection<IParametricCurve2d> Curves { [Token(Token = "0x6000733")] get; }
	}
}
