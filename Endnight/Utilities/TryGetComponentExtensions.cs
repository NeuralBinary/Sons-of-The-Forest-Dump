using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utilities
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	public static class TryGetComponentExtensions
	{
		// Token: 0x0600020C RID: 524 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x600020C")]
		public static bool TryGetComponentInChildren<T>(this GameObject gameObject, out T outComponent)
		{
			return default(bool);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002E98 File Offset: 0x00001098
		[Token(Token = "0x600020D")]
		public static bool TryGetComponentInChildren<T>(this GameObject gameObject, out T outComponent, bool includeInactive)
		{
			return default(bool);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Token(Token = "0x600020E")]
		public static bool TryGetComponentsInChildren<T>(this GameObject gameObject, out T[] outComponent)
		{
			return default(bool);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x600020F")]
		public static bool TryGetComponentsInChildren<T>(this GameObject gameObject, out T[] outComponent, bool includeInactive)
		{
			return default(bool);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x6000210")]
		public static bool TryGetComponentInChildren<T>(this Transform transform, out T outComponent)
		{
			return default(bool);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x6000211")]
		public static bool TryGetComponentInChildren<T>(this Transform transform, out T outComponent, bool includeInactive)
		{
			return default(bool);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x6000212")]
		public static bool TryGetComponentsInChildren<T>(this Transform transform, out T[] outComponent)
		{
			return default(bool);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x6000213")]
		public static bool TryGetComponentsInChildren<T>(this Transform transform, out T[] outComponent, bool includeInactive)
		{
			return default(bool);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000214")]
		public static T SafeGetComponentInChildren<T>(this Transform transform)
		{
			return null;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000215")]
		public static T SafeGetComponentInChildren<T>(this Transform transform, bool includeInactive)
		{
			return null;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000216")]
		public static T SafeGetComponentInChildren<T>(this GameObject gameObject)
		{
			return null;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000217")]
		public static T SafeGetComponentInChildren<T>(this GameObject gameObject, bool includeInactive)
		{
			return null;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000218")]
		public static T SafeGetComponent<T>(this Transform transform)
		{
			return null;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000219")]
		public static T SafeGetComponent<T>(this GameObject gameObject)
		{
			return null;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x600021A")]
		public static bool TryGetComponentInParent<T>(this GameObject gameObject, out T outComponent)
		{
			return default(bool);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x600021B")]
		public static bool TryGetComponentInParent<T>(this GameObject gameObject, out T outComponent, bool includeInactive)
		{
			return default(bool);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600021C")]
		public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
		{
			return null;
		}
	}
}
