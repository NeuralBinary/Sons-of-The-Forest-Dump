using System;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace SonsLOD
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	internal static class CullingExtensions
	{
		// Token: 0x060000E5 RID: 229 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x60000E5")]
		internal static NativeArray<T> AsNativeArray<T>(this UnsafeList<T> list) where T : struct
		{
			return default(NativeArray<T>);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x60000E6")]
		internal static NativeArray<T> GetSubNativeArray<T>(this UnsafeList<T> list, int start, int length) where T : struct
		{
			return default(NativeArray<T>);
		}
	}
}
