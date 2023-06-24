using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public static class QuaTools
	{
		// Token: 0x060000DB RID: 219 RVA: 0x0000299C File Offset: 0x00000B9C
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x28F2E60", Offset = "0x28F1460", VA = "0x1828F2E60")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000029B4 File Offset: 0x00000BB4
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x28F2F20", Offset = "0x28F1520", VA = "0x1828F2F20")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000029CC File Offset: 0x00000BCC
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x28F2FE0", Offset = "0x28F15E0", VA = "0x1828F2FE0")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000029E4 File Offset: 0x00000BE4
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x28F3110", Offset = "0x28F1710", VA = "0x1828F3110")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000029FC File Offset: 0x00000BFC
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x28F3240", Offset = "0x28F1840", VA = "0x1828F3240")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002A14 File Offset: 0x00000C14
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x28F3450", Offset = "0x28F1A50", VA = "0x1828F3450")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002A2C File Offset: 0x00000C2C
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x28F36B0", Offset = "0x28F1CB0", VA = "0x1828F36B0")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002A44 File Offset: 0x00000C44
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x28F37F0", Offset = "0x28F1DF0", VA = "0x1828F37F0")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002A5C File Offset: 0x00000C5C
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x28F3AD0", Offset = "0x28F20D0", VA = "0x1828F3AD0")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002A74 File Offset: 0x00000C74
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x28F3D90", Offset = "0x28F2390", VA = "0x1828F3D90")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return 0f;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002A8C File Offset: 0x00000C8C
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x28F3EF0", Offset = "0x28F24F0", VA = "0x1828F3EF0")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002AA4 File Offset: 0x00000CA4
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x28F42B0", Offset = "0x28F28B0", VA = "0x1828F42B0")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002ABC File Offset: 0x00000CBC
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x28F43A0", Offset = "0x28F29A0", VA = "0x1828F43A0")]
		public static float ToBiPolar(float angle)
		{
			return 0f;
		}
	}
}
