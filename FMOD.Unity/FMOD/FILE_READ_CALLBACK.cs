using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000033 RID: 51
	// (Invoke) Token: 0x06000085 RID: 133
	[Token(Token = "0x2000033")]
	public delegate RESULT FILE_READ_CALLBACK(IntPtr handle, IntPtr buffer, uint sizebytes, ref uint bytesread, IntPtr userdata);
}
