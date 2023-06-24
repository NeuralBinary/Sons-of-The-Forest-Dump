using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Extensions
{
	// Token: 0x020000A8 RID: 168
	[Token(Token = "0x20000A8")]
	public static class GameObjectExtensions
	{
		// Token: 0x060003B3 RID: 947 RVA: 0x00003AE0 File Offset: 0x00001CE0
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590")]
		public static bool IsRuntimeInstance(this GameObject obj)
		{
			return default(bool);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00003AF8 File Offset: 0x00001CF8
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70")]
		public static bool IsPrefabStageOrPreview(this GameObject gameObject)
		{
			return default(bool);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xAA41F0", Offset = "0xAA27F0", VA = "0x180AA41F0")]
		public static string GetFullPath(this Component objectTarget)
		{
			return null;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xAA4330", Offset = "0xAA2930", VA = "0x180AA4330")]
		public static string GetFullPath(this GameObject objectTarget)
		{
			return null;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xAA43D0", Offset = "0xAA29D0", VA = "0x180AA43D0")]
		public static string GetFullPath(this Transform objectTarget)
		{
			return null;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xAA4480", Offset = "0xAA2A80", VA = "0x180AA4480")]
		private static void GetFullPathInternal(this Transform objectTarget, ref StringBuilder sb)
		{
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00003B10 File Offset: 0x00001D10
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xAA4730", Offset = "0xAA2D30", VA = "0x180AA4730")]
		public static bool PassesLayerAndTag(this Component other, LayerMask layerMask, List<string> tagWhiteList)
		{
			return default(bool);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00003B28 File Offset: 0x00001D28
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xAA48B0", Offset = "0xAA2EB0", VA = "0x180AA48B0")]
		public static bool PassesLayer(this Component other, LayerMask layerMask)
		{
			return default(bool);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00003B40 File Offset: 0x00001D40
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xAA49A0", Offset = "0xAA2FA0", VA = "0x180AA49A0")]
		public static bool PassesTag(this Component other, string tagWhiteList)
		{
			return default(bool);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00003B58 File Offset: 0x00001D58
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xAA4A50", Offset = "0xAA3050", VA = "0x180AA4A50")]
		public static bool PassesTag(this Component other, List<string> tagWhiteList)
		{
			return default(bool);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00003B70 File Offset: 0x00001D70
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xAA4B00", Offset = "0xAA3100", VA = "0x180AA4B00")]
		public static bool PassesTagBlackList(this Component other, List<string> tagBlackList)
		{
			return default(bool);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00003B88 File Offset: 0x00001D88
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xAA4C10", Offset = "0xAA3210", VA = "0x180AA4C10")]
		public static bool PassesTagBlackList(this Component other, string tagBlackList)
		{
			return default(bool);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00003BA0 File Offset: 0x00001DA0
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xAA4D00", Offset = "0xAA3300", VA = "0x180AA4D00")]
		public static bool PassesLayerAndTag(this GameObject other, LayerMask layerMask, List<string> tagWhiteList)
		{
			return default(bool);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00003BB8 File Offset: 0x00001DB8
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xAA4DF0", Offset = "0xAA33F0", VA = "0x180AA4DF0")]
		public static bool PassesLayer(this GameObject other, LayerMask layerMask)
		{
			return default(bool);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00003BD0 File Offset: 0x00001DD0
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xAA4E70", Offset = "0xAA3470", VA = "0x180AA4E70")]
		public static bool PassesTag(this GameObject other, List<string> tagWhiteList)
		{
			return default(bool);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00003BE8 File Offset: 0x00001DE8
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xAA50C0", Offset = "0xAA36C0", VA = "0x180AA50C0")]
		public static bool PassesTagBlackList(this GameObject other, List<string> tagBlackList)
		{
			return default(bool);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00003C00 File Offset: 0x00001E00
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xAA5150", Offset = "0xAA3750", VA = "0x180AA5150")]
		public static bool PassesTagBlackList(this GameObject other, string tagBlackList)
		{
			return default(bool);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00003C18 File Offset: 0x00001E18
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xAA51B0", Offset = "0xAA37B0", VA = "0x180AA51B0")]
		public static bool PassesTag(this GameObject other, string tagWhiteList)
		{
			return default(bool);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xAA5300", Offset = "0xAA3900", VA = "0x180AA5300")]
		private static void SetActiveTrue(GameObject target)
		{
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xAA5360", Offset = "0xAA3960", VA = "0x180AA5360")]
		private static void SetActiveFalse(GameObject target)
		{
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xAA53C0", Offset = "0xAA39C0", VA = "0x180AA53C0")]
		public static void SetActive(this List<GameObject> objects, bool active)
		{
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xAA54E0", Offset = "0xAA3AE0", VA = "0x180AA54E0")]
		public static void SetActiveSafe(this IEnumerable<GameObject> objects, bool activeValue)
		{
		}

		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Action<GameObject> SetActiveTrueAction;

		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Action<GameObject> SetActiveFalseAction;
	}
}
