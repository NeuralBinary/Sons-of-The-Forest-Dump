using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000265 RID: 613
	[Token(Token = "0x2000265")]
	public static class PseudoRandom
	{
		// Token: 0x060012AD RID: 4781 RVA: 0x0000B564 File Offset: 0x00009764
		[Token(Token = "0x60012AD")]
		[Address(RVA = "0x2F3F510", Offset = "0x2F3DB10", VA = "0x182F3F510")]
		public static int GetInt(Vector3 pos, int from, int to)
		{
			return 0;
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x0000B57C File Offset: 0x0000977C
		[Token(Token = "0x60012AE")]
		[Address(RVA = "0x2F3F5E0", Offset = "0x2F3DBE0", VA = "0x182F3F5E0")]
		public static float GetFloat(Vector3 pos, float from, float to, int granularity = 100)
		{
			return 0f;
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x0000B594 File Offset: 0x00009794
		[Token(Token = "0x60012AF")]
		[Address(RVA = "0x2F3F660", Offset = "0x2F3DC60", VA = "0x182F3F660")]
		public static Quaternion GetRotation(Vector3 position)
		{
			return default(Quaternion);
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x0000B5AC File Offset: 0x000097AC
		[Token(Token = "0x60012B0")]
		[Address(RVA = "0x2F3F940", Offset = "0x2F3DF40", VA = "0x182F3F940")]
		public static Quaternion GetRotation(Vector3 position, float xBounds, float yBounds, float zBounds)
		{
			return default(Quaternion);
		}
	}
}
