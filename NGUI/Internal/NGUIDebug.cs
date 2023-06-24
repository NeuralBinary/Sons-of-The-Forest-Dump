using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Internal
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	[AddComponentMenu("NGUI/Internal/Debug")]
	public class NGUIDebug : MonoBehaviour
	{
		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00003768 File Offset: 0x00001968
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F2")]
		public static bool debugRaycast
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x266F310", Offset = "0x266D910", VA = "0x18266F310")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x266F360", Offset = "0x266D960", VA = "0x18266F360")]
			set
			{
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x266F440", Offset = "0x266DA40", VA = "0x18266F440")]
		public static void CreateInstance()
		{
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x266F670", Offset = "0x266DC70", VA = "0x18266F670")]
		private static void LogString(string text)
		{
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x266F8B0", Offset = "0x266DEB0", VA = "0x18266F8B0")]
		public static void Log(params object[] objs)
		{
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x266F9E0", Offset = "0x266DFE0", VA = "0x18266F9E0")]
		public static void Clear()
		{
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x266FA70", Offset = "0x266E070", VA = "0x18266FA70")]
		public static void DrawBounds(Bounds b)
		{
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x266FFA0", Offset = "0x266E5A0", VA = "0x18266FFA0")]
		private void OnGUI()
		{
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public NGUIDebug()
		{
		}

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x0")]
		private static bool mRayDebug;

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x8")]
		private static List<string> mLines;

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x10")]
		private static NGUIDebug mInstance;
	}
}
