using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x0200002B RID: 43
	// (Invoke) Token: 0x06000065 RID: 101
	[Token(Token = "0x200002B")]
	public delegate RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, StringWrapper file, int line, StringWrapper func, StringWrapper message);
}
