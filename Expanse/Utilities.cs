using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	public class Utilities
	{
		// Token: 0x06000336 RID: 822 RVA: 0x00005148 File Offset: 0x00003348
		[Token(Token = "0x6000336")]
		[Address(RVA = "0xAE5F50", Offset = "0xAE4550", VA = "0x180AE5F50")]
		public static Matrix4x4 quaternionVectorToRotationMatrix(Vector3 v)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00005160 File Offset: 0x00003360
		[Token(Token = "0x6000337")]
		[Address(RVA = "0xAE6030", Offset = "0xAE4630", VA = "0x180AE6030")]
		public static Vector2Int ToInt2(Vector2 v)
		{
			return default(Vector2Int);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00005178 File Offset: 0x00003378
		[Token(Token = "0x6000338")]
		[Address(RVA = "0xAE6050", Offset = "0xAE4650", VA = "0x180AE6050")]
		public static Vector3Int ToInt3(Vector3 v)
		{
			return default(Vector3Int);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00005190 File Offset: 0x00003390
		[Token(Token = "0x6000339")]
		[Address(RVA = "0xAE6070", Offset = "0xAE4670", VA = "0x180AE6070")]
		public static float toTwoByteFloat(byte HO, byte LO)
		{
			return 0f;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000051A8 File Offset: 0x000033A8
		[Token(Token = "0x600033A")]
		[Address(RVA = "0xAE6240", Offset = "0xAE4840", VA = "0x180AE6240")]
		public static float toTwoByteFloatMemoryOptimized(byte[] HO_LO_zero_zero)
		{
			return 0f;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Utilities()
		{
		}

		// Token: 0x040003DE RID: 990
		[Token(Token = "0x40003DE")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] sTwoByteFloatTempBuffer;
	}
}
