using System;
using Il2CppDummyDll;
using UnityEngine;

namespace OrbCreationExtensions
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public static class TransformExtensions
	{
		// Token: 0x060000AC RID: 172 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2A85DA0", Offset = "0x2A843A0", VA = "0x182A85DA0")]
		public static bool IsPartOf(this Transform trans, Transform aTransform)
		{
			return default(bool);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2A860B0", Offset = "0x2A846B0", VA = "0x182A860B0")]
		public static Transform FindFirstChildWithName(this Transform trans, string childName)
		{
			return null;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2A863C0", Offset = "0x2A849C0", VA = "0x182A863C0")]
		public static Transform FindFirstChildWhereNameContains(this Transform trans, string childName)
		{
			return null;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AF")]
		public static T GetFirstComponentInParents<T>(this Transform trans) where T : MonoBehaviour
		{
			return null;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2A866E0", Offset = "0x2A84CE0", VA = "0x182A866E0")]
		public static Vector3 PointToWorldSpace(this Transform trans, Vector3 p)
		{
			return default(Vector3);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2A86790", Offset = "0x2A84D90", VA = "0x182A86790")]
		public static Vector3 PointToLocalSpace(this Transform trans, Vector3 p)
		{
			return default(Vector3);
		}
	}
}
