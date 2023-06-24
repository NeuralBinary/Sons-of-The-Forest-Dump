using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	public class AxisTools
	{
		// Token: 0x06000060 RID: 96 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x28E3DC0", Offset = "0x28E23C0", VA = "0x1828E3DC0")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x28E3EA0", Offset = "0x28E24A0", VA = "0x1828E3EA0")]
		public static Axis ToAxis(Vector3 v)
		{
			return Axis.X;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x28E3EF0", Offset = "0x28E24F0", VA = "0x1828E3EF0")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return Axis.X;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x28E4150", Offset = "0x28E2750", VA = "0x1828E4150")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return Axis.X;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x28E4320", Offset = "0x28E2920", VA = "0x1828E4320")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x28E4490", Offset = "0x28E2A90", VA = "0x1828E4490")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x28E4560", Offset = "0x28E2B60", VA = "0x1828E4560")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public AxisTools()
		{
		}
	}
}
