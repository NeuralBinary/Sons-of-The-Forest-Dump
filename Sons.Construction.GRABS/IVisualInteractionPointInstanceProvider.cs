using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	public interface IVisualInteractionPointInstanceProvider
	{
		// Token: 0x06000291 RID: 657
		[Token(Token = "0x6000291")]
		VisualFader SpawnInteractionDot(Vector3 pos, Quaternion rotation, Transform parent);

		// Token: 0x06000292 RID: 658
		[Token(Token = "0x6000292")]
		void Despawn(VisualFader instance);
	}
}
