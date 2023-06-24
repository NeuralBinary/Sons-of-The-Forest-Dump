using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	public interface IObiParticleCollection
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001E1 RID: 481
		[Token(Token = "0x17000059")]
		int particleCount { [Token(Token = "0x60001E1")] get; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001E2 RID: 482
		[Token(Token = "0x1700005A")]
		int activeParticleCount { [Token(Token = "0x60001E2")] get; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001E3 RID: 483
		[Token(Token = "0x1700005B")]
		bool usesOrientedParticles { [Token(Token = "0x60001E3")] get; }

		// Token: 0x060001E4 RID: 484
		[Token(Token = "0x60001E4")]
		int GetParticleRuntimeIndex(int index);

		// Token: 0x060001E5 RID: 485
		[Token(Token = "0x60001E5")]
		Vector3 GetParticlePosition(int index);

		// Token: 0x060001E6 RID: 486
		[Token(Token = "0x60001E6")]
		Quaternion GetParticleOrientation(int index);

		// Token: 0x060001E7 RID: 487
		[Token(Token = "0x60001E7")]
		void GetParticleAnisotropy(int index, ref Vector4 b1, ref Vector4 b2, ref Vector4 b3);

		// Token: 0x060001E8 RID: 488
		[Token(Token = "0x60001E8")]
		float GetParticleMaxRadius(int index);

		// Token: 0x060001E9 RID: 489
		[Token(Token = "0x60001E9")]
		Color GetParticleColor(int index);
	}
}
