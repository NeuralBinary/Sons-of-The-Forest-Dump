using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	internal static class StringHelper
	{
		// Token: 0x0600041E RID: 1054 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x600041E")]
		[Address(RVA = "0xB388E0", Offset = "0xB36EE0", VA = "0x180B388E0")]
		public static StringHelper.ThreadSafeEncoding GetFreeHelper()
		{
			return null;
		}

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<StringHelper.ThreadSafeEncoding> encoders;

		// Token: 0x02000057 RID: 87
		[Token(Token = "0x2000057")]
		public class ThreadSafeEncoding : IDisposable
		{
			// Token: 0x06000420 RID: 1056 RVA: 0x00004AE4 File Offset: 0x00002CE4
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
			public bool InUse()
			{
				return default(bool);
			}

			// Token: 0x06000421 RID: 1057 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x66E8E0", Offset = "0x66CEE0", VA = "0x18066E8E0")]
			public void SetInUse()
			{
			}

			// Token: 0x06000422 RID: 1058 RVA: 0x00004AFC File Offset: 0x00002CFC
			[Token(Token = "0x6000422")]
			[Address(RVA = "0xB38F70", Offset = "0xB37570", VA = "0x180B38F70")]
			private int roundUpPowerTwo(int number)
			{
				return 0;
			}

			// Token: 0x06000423 RID: 1059 RVA: 0x0000210E File Offset: 0x0000030E
			[Token(Token = "0x6000423")]
			[Address(RVA = "0xB38F90", Offset = "0xB37590", VA = "0x180B38F90")]
			public byte[] byteFromStringUTF8(string s)
			{
				return null;
			}

			// Token: 0x06000424 RID: 1060 RVA: 0x00004B14 File Offset: 0x00002D14
			[Token(Token = "0x6000424")]
			[Address(RVA = "0xB390F0", Offset = "0xB376F0", VA = "0x180B390F0")]
			public IntPtr intptrFromStringUTF8(string s)
			{
				return 0;
			}

			// Token: 0x06000425 RID: 1061 RVA: 0x0000210E File Offset: 0x0000030E
			[Token(Token = "0x6000425")]
			[Address(RVA = "0xB39140", Offset = "0xB37740", VA = "0x180B39140")]
			public string stringFromNative(IntPtr nativePtr)
			{
				return null;
			}

			// Token: 0x06000426 RID: 1062 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000426")]
			[Address(RVA = "0xB394C0", Offset = "0xB37AC0", VA = "0x180B394C0", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x06000427 RID: 1063 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000427")]
			[Address(RVA = "0xB396D0", Offset = "0xB37CD0", VA = "0x180B396D0")]
			public ThreadSafeEncoding()
			{
			}

			// Token: 0x04000230 RID: 560
			[Token(Token = "0x4000230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private UTF8Encoding encoding;

			// Token: 0x04000231 RID: 561
			[Token(Token = "0x4000231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private byte[] encodedBuffer;

			// Token: 0x04000232 RID: 562
			[Token(Token = "0x4000232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private char[] decodedBuffer;

			// Token: 0x04000233 RID: 563
			[Token(Token = "0x4000233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool inUse;

			// Token: 0x04000234 RID: 564
			[Token(Token = "0x4000234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private GCHandle gcHandle;
		}
	}
}
