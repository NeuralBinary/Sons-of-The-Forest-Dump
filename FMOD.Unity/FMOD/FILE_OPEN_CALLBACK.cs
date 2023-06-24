using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000031 RID: 49
	// (Invoke) Token: 0x0600007D RID: 125
	[Token(Token = "0x2000031")]
	public delegate RESULT FILE_OPEN_CALLBACK(StringWrapper name, ref uint filesize, ref IntPtr handle, IntPtr userdata);
}
