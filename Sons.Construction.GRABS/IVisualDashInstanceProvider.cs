using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	public interface IVisualDashInstanceProvider
	{
		// Token: 0x0600028D RID: 653
		[Token(Token = "0x600028D")]
		float GetDashLength();

		// Token: 0x0600028E RID: 654
		[Token(Token = "0x600028E")]
		Material GetDashMaterial(VisualModes mode);

		// Token: 0x0600028F RID: 655
		[Token(Token = "0x600028F")]
		DashVisual SpawnDash(VisualModes mode, Vector3 pos, Quaternion rotation, Transform parent);

		// Token: 0x06000290 RID: 656
		[Token(Token = "0x6000290")]
		void Despawn(DashVisual instance);
	}
}
