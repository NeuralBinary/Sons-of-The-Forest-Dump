using System;
using Il2CppDummyDll;

namespace Sons.Interfaces
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public interface ILightableFire : IMonoBehaviour
	{
		// Token: 0x06000009 RID: 9
		[Token(Token = "0x6000009")]
		void ToggleUiIcons(bool onOff);

		// Token: 0x0600000A RID: 10
		[Token(Token = "0x600000A")]
		void LightFire();

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000B RID: 11
		[Token(Token = "0x17000004")]
		bool ShouldLeanToLight { [Token(Token = "0x600000B")] get; }
	}
}
