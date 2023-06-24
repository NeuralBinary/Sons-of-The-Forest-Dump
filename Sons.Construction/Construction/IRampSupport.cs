using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x020001B9 RID: 441
	[Token(Token = "0x20001B9")]
	public interface IRampSupport : ITileSupport, IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x06000D08 RID: 3336
		[Token(Token = "0x6000D08")]
		void SetRampAtDir(Directions direction, RampStructure ramp);

		// Token: 0x06000D09 RID: 3337
		[Token(Token = "0x6000D09")]
		bool HasRampAtDir(Directions direction);

		// Token: 0x06000D0A RID: 3338
		[Token(Token = "0x6000D0A")]
		bool TryGetRampAtDir(Directions direction, out RampStructure floor);

		// Token: 0x06000D0B RID: 3339
		[Token(Token = "0x6000D0B")]
		bool CanHostNewRamp();

		// Token: 0x06000D0C RID: 3340
		[Token(Token = "0x6000D0C")]
		Directions[] GetRampDirs();
	}
}
