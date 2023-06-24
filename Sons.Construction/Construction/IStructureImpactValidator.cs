using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000093 RID: 147
	[Token(Token = "0x2000093")]
	public interface IStructureImpactValidator
	{
		// Token: 0x060003C5 RID: 965
		[Token(Token = "0x60003C5")]
		void OnDestroy();

		// Token: 0x060003C6 RID: 966
		[Token(Token = "0x60003C6")]
		bool Validate(Structure structure, Transform attackSourceTr, IImpactData impactData);
	}
}
