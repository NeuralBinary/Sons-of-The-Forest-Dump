using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001BB RID: 443
	[Token(Token = "0x20001BB")]
	public interface ISingleStepSupport : IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x06000D0D RID: 3341
		[Token(Token = "0x6000D0D")]
		bool CanHostSingleStep();

		// Token: 0x06000D0E RID: 3342
		[Token(Token = "0x6000D0E")]
		void SetSingleStep(Directions dir, SingleStepStructure singleStep);

		// Token: 0x06000D0F RID: 3343
		[Token(Token = "0x6000D0F")]
		bool HasSingleStep(Directions dir);

		// Token: 0x06000D10 RID: 3344
		[Token(Token = "0x6000D10")]
		Vector3 GetSingleStepPos(Directions dir);

		// Token: 0x06000D11 RID: 3345
		[Token(Token = "0x6000D11")]
		Vector3 CalcRampUpAxis(Directions dir);
	}
}
