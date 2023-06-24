using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.Common.Input
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public class InputUtils
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x26F2F90", Offset = "0x26F1590", VA = "0x1826F2F90")]
		public static bool TryGetButton(string buttonName, KeyCode altKey, bool showWarning = true)
		{
			return default(bool);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x26F30A0", Offset = "0x26F16A0", VA = "0x1826F30A0")]
		public static bool TryGetButtonDown(string buttonName, KeyCode altKey, bool showWarning = true)
		{
			return default(bool);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x26F31B0", Offset = "0x26F17B0", VA = "0x1826F31B0")]
		public static float TryGetAxis(string axisName, bool showWarning = true)
		{
			return 0f;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x26F32B0", Offset = "0x26F18B0", VA = "0x1826F32B0")]
		public static float TryGetAxisRaw(string axisName, bool showWarning = true)
		{
			return 0f;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public InputUtils()
		{
		}

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x0")]
		private static int _warningCount;
	}
}
