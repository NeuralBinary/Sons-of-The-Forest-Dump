using System;
using Il2CppDummyDll;

namespace Sons.Save
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public interface ISaveGameRegistration
	{
		// Token: 0x0600000F RID: 15
		[Token(Token = "0x600000F")]
		void RegisterSaveGameSerializer();

		// Token: 0x06000010 RID: 16
		[Token(Token = "0x6000010")]
		bool HasRegistered();
	}
}
