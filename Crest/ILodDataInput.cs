using System;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace Crest
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	public interface ILodDataInput
	{
		// Token: 0x060000FB RID: 251
		[Token(Token = "0x60000FB")]
		void Draw(CommandBuffer buf, float weight, int isTransition, int lodIdx);

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000FC RID: 252
		[Token(Token = "0x17000026")]
		float Wavelength { [Token(Token = "0x60000FC")] get; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000FD RID: 253
		[Token(Token = "0x17000027")]
		bool Enabled { [Token(Token = "0x60000FD")] get; }
	}
}
