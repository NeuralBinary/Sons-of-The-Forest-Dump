using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Utils
{
	// Token: 0x020003B5 RID: 949
	[Token(Token = "0x20003B5")]
	public class GlobalDataSaver : MonoBehaviour
	{
		// Token: 0x0600199E RID: 6558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600199E")]
		[Address(RVA = "0x32958F0", Offset = "0x3293EF0", VA = "0x1832958F0")]
		private void Awake()
		{
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600199F")]
		[Address(RVA = "0x32960A0", Offset = "0x32946A0", VA = "0x1832960A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019A0")]
		[Address(RVA = "0x3296230", Offset = "0x3294830", VA = "0x183296230")]
		private void OnSerializing()
		{
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019A1")]
		[Address(RVA = "0x3296360", Offset = "0x3294960", VA = "0x183296360")]
		private void OnDeserialized()
		{
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019A2")]
		[Address(RVA = "0x3296550", Offset = "0x3294B50", VA = "0x183296550")]
		public static void SetInt(string name, int value)
		{
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019A3")]
		[Address(RVA = "0x3296690", Offset = "0x3294C90", VA = "0x183296690")]
		public static void SetFloat(string name, float value)
		{
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019A4")]
		[Address(RVA = "0x32967D0", Offset = "0x3294DD0", VA = "0x1832967D0")]
		public static void SetString(string name, string value)
		{
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019A5")]
		[Address(RVA = "0x3296910", Offset = "0x3294F10", VA = "0x183296910")]
		public static void SetLong(string name, long value)
		{
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019A6")]
		[Address(RVA = "0x3296A50", Offset = "0x3295050", VA = "0x183296A50")]
		public static void SetInt(long key, int value)
		{
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019A7")]
		[Address(RVA = "0x3296B90", Offset = "0x3295190", VA = "0x183296B90")]
		public static void SetFloat(long key, float value)
		{
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019A8")]
		[Address(RVA = "0x3296CD0", Offset = "0x32952D0", VA = "0x183296CD0")]
		public static void SetString(long key, string value)
		{
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019A9")]
		[Address(RVA = "0x3296E20", Offset = "0x3295420", VA = "0x183296E20")]
		public static void SetLong(long key, long value)
		{
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x00007E48 File Offset: 0x00006048
		[Token(Token = "0x60019AA")]
		[Address(RVA = "0x3296F70", Offset = "0x3295570", VA = "0x183296F70")]
		public static int GetInt(string name, int defaultValue = 0)
		{
			return 0;
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x00007E60 File Offset: 0x00006060
		[Token(Token = "0x60019AB")]
		[Address(RVA = "0x3297040", Offset = "0x3295640", VA = "0x183297040")]
		public static float GetFloat(string name, float defaultValue = 0f)
		{
			return 0f;
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019AC")]
		[Address(RVA = "0x3297110", Offset = "0x3295710", VA = "0x183297110")]
		public static string GetString(string name, string defaultValue = "")
		{
			return null;
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x00007E78 File Offset: 0x00006078
		[Token(Token = "0x60019AD")]
		[Address(RVA = "0x32971B0", Offset = "0x32957B0", VA = "0x1832971B0")]
		public static long GetLong(string name, long defaultValue = 0L)
		{
			return 0L;
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x00007E90 File Offset: 0x00006090
		[Token(Token = "0x60019AE")]
		[Address(RVA = "0x3297280", Offset = "0x3295880", VA = "0x183297280")]
		public static int GetInt(long key, int defaultValue = 0)
		{
			return 0;
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x00007EA8 File Offset: 0x000060A8
		[Token(Token = "0x60019AF")]
		[Address(RVA = "0x3297350", Offset = "0x3295950", VA = "0x183297350")]
		public static float GetFloat(long key, float defaultValue = 0f)
		{
			return 0f;
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019B0")]
		[Address(RVA = "0x3297420", Offset = "0x3295A20", VA = "0x183297420")]
		public static string GetString(long key, string defaultValue = "")
		{
			return null;
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x00007EC0 File Offset: 0x000060C0
		[Token(Token = "0x60019B1")]
		[Address(RVA = "0x32974C0", Offset = "0x3295AC0", VA = "0x1832974C0")]
		public static long GetLong(long key, long defaultValue = 0L)
		{
			return 0L;
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019B2")]
		[Address(RVA = "0x3297590", Offset = "0x3295B90", VA = "0x183297590")]
		public static void ClearInt(string name)
		{
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019B3")]
		[Address(RVA = "0x3297600", Offset = "0x3295C00", VA = "0x183297600")]
		public static void ClearFloat(string name)
		{
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019B4")]
		[Address(RVA = "0x3297670", Offset = "0x3295C70", VA = "0x183297670")]
		public static void ClearString(string name)
		{
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019B5")]
		[Address(RVA = "0x32976E0", Offset = "0x3295CE0", VA = "0x1832976E0")]
		public static void ClearLong(string name)
		{
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019B6")]
		[Address(RVA = "0x3297750", Offset = "0x3295D50", VA = "0x183297750")]
		public static void ClearLongInt(long key)
		{
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019B7")]
		[Address(RVA = "0x32977C0", Offset = "0x3295DC0", VA = "0x1832977C0")]
		public static void ClearLongFloat(long key)
		{
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019B8")]
		[Address(RVA = "0x3297830", Offset = "0x3295E30", VA = "0x183297830")]
		public static void ClearLongString(long key)
		{
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019B9")]
		[Address(RVA = "0x32978A0", Offset = "0x3295EA0", VA = "0x1832978A0")]
		public static void ClearLongLong(long key)
		{
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x060019BA RID: 6586 RVA: 0x00007ED8 File Offset: 0x000060D8
		[Token(Token = "0x1700037A")]
		public static bool Ready
		{
			[Token(Token = "0x60019BA")]
			[Address(RVA = "0x3297910", Offset = "0x3295F10", VA = "0x183297910")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019BB")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public GlobalDataSaver()
		{
		}

		// Token: 0x040018ED RID: 6381
		[Token(Token = "0x40018ED")]
		[FieldOffset(Offset = "0x20")]
		private bool _ready;

		// Token: 0x040018EE RID: 6382
		[Token(Token = "0x40018EE")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, int> _intData;

		// Token: 0x040018EF RID: 6383
		[Token(Token = "0x40018EF")]
		[FieldOffset(Offset = "0x30")]
		private int _intDataCount;

		// Token: 0x040018F0 RID: 6384
		[Token(Token = "0x40018F0")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, float> _floatData;

		// Token: 0x040018F1 RID: 6385
		[Token(Token = "0x40018F1")]
		[FieldOffset(Offset = "0x40")]
		private int _floatDataCount;

		// Token: 0x040018F2 RID: 6386
		[Token(Token = "0x40018F2")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, string> _stringData;

		// Token: 0x040018F3 RID: 6387
		[Token(Token = "0x40018F3")]
		[FieldOffset(Offset = "0x50")]
		private int _stringDataCount;

		// Token: 0x040018F4 RID: 6388
		[Token(Token = "0x40018F4")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<string, long> _longData;

		// Token: 0x040018F5 RID: 6389
		[Token(Token = "0x40018F5")]
		[FieldOffset(Offset = "0x60")]
		private int _longDataCount;

		// Token: 0x040018F6 RID: 6390
		[Token(Token = "0x40018F6")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<long, int> _longIntData;

		// Token: 0x040018F7 RID: 6391
		[Token(Token = "0x40018F7")]
		[FieldOffset(Offset = "0x70")]
		private int _longIntDataCount;

		// Token: 0x040018F8 RID: 6392
		[Token(Token = "0x40018F8")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<long, float> _longFloatData;

		// Token: 0x040018F9 RID: 6393
		[Token(Token = "0x40018F9")]
		[FieldOffset(Offset = "0x80")]
		private int _longFloatDataCount;

		// Token: 0x040018FA RID: 6394
		[Token(Token = "0x40018FA")]
		[FieldOffset(Offset = "0x88")]
		private Dictionary<long, string> _longStringData;

		// Token: 0x040018FB RID: 6395
		[Token(Token = "0x40018FB")]
		[FieldOffset(Offset = "0x90")]
		private int _longStringDataCount;

		// Token: 0x040018FC RID: 6396
		[Token(Token = "0x40018FC")]
		[FieldOffset(Offset = "0x98")]
		private Dictionary<long, long> _longLongData;

		// Token: 0x040018FD RID: 6397
		[Token(Token = "0x40018FD")]
		[FieldOffset(Offset = "0xA0")]
		private int _longLongDataCount;

		// Token: 0x040018FE RID: 6398
		[Token(Token = "0x40018FE")]
		[FieldOffset(Offset = "0x0")]
		private static GlobalDataSaver Instance;

		// Token: 0x020003B6 RID: 950
		[Token(Token = "0x20003B6")]
		public enum DataTypes
		{
			// Token: 0x04001900 RID: 6400
			[Token(Token = "0x4001900")]
			Int,
			// Token: 0x04001901 RID: 6401
			[Token(Token = "0x4001901")]
			Float,
			// Token: 0x04001902 RID: 6402
			[Token(Token = "0x4001902")]
			String,
			// Token: 0x04001903 RID: 6403
			[Token(Token = "0x4001903")]
			Long
		}
	}
}
