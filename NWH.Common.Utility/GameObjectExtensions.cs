using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.Common.Utility
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public static class GameObjectExtensions
	{
		// Token: 0x06000008 RID: 8 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x26F6A10", Offset = "0x26F5010", VA = "0x1826F6A10")]
		public static Bounds FindBoundsIncludeChildren(this GameObject gameObject)
		{
			return default(Bounds);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000009")]
		public static T GetComponentInParent<T>(this Transform transform, bool includeInactive = true) where T : Component
		{
			return null;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600000A")]
		public static T GetComponentInParentsOrChildren<T>(this Transform transform, bool includeInactive = true) where T : Component
		{
			return null;
		}
	}
}
