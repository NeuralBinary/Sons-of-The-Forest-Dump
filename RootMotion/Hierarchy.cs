using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	public class Hierarchy
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x000025AC File Offset: 0x000007AC
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x28EF8C0", Offset = "0x28EDEC0", VA = "0x1828EF8C0")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x28EF940", Offset = "0x28EDF40", VA = "0x1828EF940")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000025C4 File Offset: 0x000007C4
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x28EFAE0", Offset = "0x28EE0E0", VA = "0x1828EFAE0")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000025DC File Offset: 0x000007DC
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x28EFDF0", Offset = "0x28EE3F0", VA = "0x1828EFDF0")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x28F0060", Offset = "0x28EE660", VA = "0x1828F0060")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x28F05C0", Offset = "0x28EEBC0", VA = "0x1828F05C0")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x28F0850", Offset = "0x28EEE50", VA = "0x1828F0850")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x28F0B70", Offset = "0x28EF170", VA = "0x1828F0B70")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x28F0D50", Offset = "0x28EF350", VA = "0x1828F0D50")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000025F4 File Offset: 0x000007F4
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x28F0FD0", Offset = "0x28EF5D0", VA = "0x1828F0FD0")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Hierarchy()
		{
		}
	}
}
