using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Utils
{
	// Token: 0x020003C3 RID: 963
	[Token(Token = "0x20003C3")]
	public class GlobalDataSaver : MonoBehaviour
	{
		// Token: 0x06001963 RID: 6499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001963")]
		[Address(RVA = "0x2CC7470", Offset = "0x2CC6470", VA = "0x182CC7470")]
		private void Awake()
		{
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001964")]
		[Address(RVA = "0x2CC8120", Offset = "0x2CC7120", VA = "0x182CC8120")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001965")]
		[Address(RVA = "0x2CC81D0", Offset = "0x2CC71D0", VA = "0x182CC81D0")]
		private void OnSerializing()
		{
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001966")]
		[Address(RVA = "0x2CC7F70", Offset = "0x2CC6F70", VA = "0x182CC7F70")]
		private void OnDeserialized()
		{
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001967")]
		[Address(RVA = "0x2CC84E0", Offset = "0x2CC74E0", VA = "0x182CC84E0")]
		public static void SetInt(string name, int value)
		{
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001968")]
		[Address(RVA = "0x2CC8410", Offset = "0x2CC7410", VA = "0x182CC8410")]
		public static void SetFloat(string name, float value)
		{
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001969")]
		[Address(RVA = "0x2CC8820", Offset = "0x2CC7820", VA = "0x182CC8820")]
		public static void SetString(string name, string value)
		{
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600196A")]
		[Address(RVA = "0x2CC8750", Offset = "0x2CC7750", VA = "0x182CC8750")]
		public static void SetLong(string name, long value)
		{
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600196B")]
		[Address(RVA = "0x2CC85B0", Offset = "0x2CC75B0", VA = "0x182CC85B0")]
		public static void SetInt(long key, int value)
		{
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600196C")]
		[Address(RVA = "0x2CC8340", Offset = "0x2CC7340", VA = "0x182CC8340")]
		public static void SetFloat(long key, float value)
		{
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600196D")]
		[Address(RVA = "0x2CC88F0", Offset = "0x2CC78F0", VA = "0x182CC88F0")]
		public static void SetString(long key, string value)
		{
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600196E")]
		[Address(RVA = "0x2CC8680", Offset = "0x2CC7680", VA = "0x182CC8680")]
		public static void SetLong(long key, long value)
		{
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x00007BD8 File Offset: 0x00005DD8
		[Token(Token = "0x600196F")]
		[Address(RVA = "0x2CC7BD0", Offset = "0x2CC6BD0", VA = "0x182CC7BD0")]
		public static int GetInt(string name, int defaultValue = 0)
		{
			return default(int);
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x00007BF0 File Offset: 0x00005DF0
		[Token(Token = "0x6001970")]
		[Address(RVA = "0x2CC7A90", Offset = "0x2CC6A90", VA = "0x182CC7A90")]
		public static float GetFloat(string name, float defaultValue = 0f)
		{
			return default(float);
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001971")]
		[Address(RVA = "0x2CC7ED0", Offset = "0x2CC6ED0", VA = "0x182CC7ED0")]
		public static string GetString(string name, string defaultValue = "")
		{
			return null;
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x00007C08 File Offset: 0x00005E08
		[Token(Token = "0x6001972")]
		[Address(RVA = "0x2CC7CF0", Offset = "0x2CC6CF0", VA = "0x182CC7CF0")]
		public static long GetLong(string name, long defaultValue = 0L)
		{
			return default(long);
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x00007C20 File Offset: 0x00005E20
		[Token(Token = "0x6001973")]
		[Address(RVA = "0x2CC7C60", Offset = "0x2CC6C60", VA = "0x182CC7C60")]
		public static int GetInt(long key, int defaultValue = 0)
		{
			return default(int);
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x00007C38 File Offset: 0x00005E38
		[Token(Token = "0x6001974")]
		[Address(RVA = "0x2CC7B30", Offset = "0x2CC6B30", VA = "0x182CC7B30")]
		public static float GetFloat(long key, float defaultValue = 0f)
		{
			return default(float);
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001975")]
		[Address(RVA = "0x2CC7E30", Offset = "0x2CC6E30", VA = "0x182CC7E30")]
		public static string GetString(long key, string defaultValue = "")
		{
			return null;
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x00007C50 File Offset: 0x00005E50
		[Token(Token = "0x6001976")]
		[Address(RVA = "0x2CC7D90", Offset = "0x2CC6D90", VA = "0x182CC7D90")]
		public static long GetLong(long key, long defaultValue = 0L)
		{
			return default(long);
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001977")]
		[Address(RVA = "0x2CC7780", Offset = "0x2CC6780", VA = "0x182CC7780")]
		public static void ClearInt(string name)
		{
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001978")]
		[Address(RVA = "0x2CC7710", Offset = "0x2CC6710", VA = "0x182CC7710")]
		public static void ClearFloat(string name)
		{
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001979")]
		[Address(RVA = "0x2CC7A20", Offset = "0x2CC6A20", VA = "0x182CC7A20")]
		public static void ClearString(string name)
		{
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600197A")]
		[Address(RVA = "0x2CC79B0", Offset = "0x2CC69B0", VA = "0x182CC79B0")]
		public static void ClearLong(string name)
		{
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600197B")]
		[Address(RVA = "0x2CC7860", Offset = "0x2CC6860", VA = "0x182CC7860")]
		public static void ClearLongInt(long key)
		{
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600197C")]
		[Address(RVA = "0x2CC77F0", Offset = "0x2CC67F0", VA = "0x182CC77F0")]
		public static void ClearLongFloat(long key)
		{
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600197D")]
		[Address(RVA = "0x2CC7940", Offset = "0x2CC6940", VA = "0x182CC7940")]
		public static void ClearLongString(long key)
		{
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600197E")]
		[Address(RVA = "0x2CC78D0", Offset = "0x2CC68D0", VA = "0x182CC78D0")]
		public static void ClearLongLong(long key)
		{
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x0600197F RID: 6527 RVA: 0x00007C68 File Offset: 0x00005E68
		[Token(Token = "0x17000372")]
		public static bool Ready
		{
			[Token(Token = "0x600197F")]
			[Address(RVA = "0x2CC89C0", Offset = "0x2CC79C0", VA = "0x182CC89C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001980")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public GlobalDataSaver()
		{
		}

		// Token: 0x040018CE RID: 6350
		[Token(Token = "0x40018CE")]
		[FieldOffset(Offset = "0x20")]
		private bool _ready;

		// Token: 0x040018CF RID: 6351
		[Token(Token = "0x40018CF")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, int> _intData;

		// Token: 0x040018D0 RID: 6352
		[Token(Token = "0x40018D0")]
		[FieldOffset(Offset = "0x30")]
		private int _intDataCount;

		// Token: 0x040018D1 RID: 6353
		[Token(Token = "0x40018D1")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, float> _floatData;

		// Token: 0x040018D2 RID: 6354
		[Token(Token = "0x40018D2")]
		[FieldOffset(Offset = "0x40")]
		private int _floatDataCount;

		// Token: 0x040018D3 RID: 6355
		[Token(Token = "0x40018D3")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, string> _stringData;

		// Token: 0x040018D4 RID: 6356
		[Token(Token = "0x40018D4")]
		[FieldOffset(Offset = "0x50")]
		private int _stringDataCount;

		// Token: 0x040018D5 RID: 6357
		[Token(Token = "0x40018D5")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<string, long> _longData;

		// Token: 0x040018D6 RID: 6358
		[Token(Token = "0x40018D6")]
		[FieldOffset(Offset = "0x60")]
		private int _longDataCount;

		// Token: 0x040018D7 RID: 6359
		[Token(Token = "0x40018D7")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<long, int> _longIntData;

		// Token: 0x040018D8 RID: 6360
		[Token(Token = "0x40018D8")]
		[FieldOffset(Offset = "0x70")]
		private int _longIntDataCount;

		// Token: 0x040018D9 RID: 6361
		[Token(Token = "0x40018D9")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<long, float> _longFloatData;

		// Token: 0x040018DA RID: 6362
		[Token(Token = "0x40018DA")]
		[FieldOffset(Offset = "0x80")]
		private int _longFloatDataCount;

		// Token: 0x040018DB RID: 6363
		[Token(Token = "0x40018DB")]
		[FieldOffset(Offset = "0x88")]
		private Dictionary<long, string> _longStringData;

		// Token: 0x040018DC RID: 6364
		[Token(Token = "0x40018DC")]
		[FieldOffset(Offset = "0x90")]
		private int _longStringDataCount;

		// Token: 0x040018DD RID: 6365
		[Token(Token = "0x40018DD")]
		[FieldOffset(Offset = "0x98")]
		private Dictionary<long, long> _longLongData;

		// Token: 0x040018DE RID: 6366
		[Token(Token = "0x40018DE")]
		[FieldOffset(Offset = "0xA0")]
		private int _longLongDataCount;

		// Token: 0x040018DF RID: 6367
		[Token(Token = "0x40018DF")]
		[FieldOffset(Offset = "0x0")]
		private static GlobalDataSaver Instance;

		// Token: 0x020003C4 RID: 964
		[Token(Token = "0x20003C4")]
		public enum DataTypes
		{
			// Token: 0x040018E1 RID: 6369
			[Token(Token = "0x40018E1")]
			Int,
			// Token: 0x040018E2 RID: 6370
			[Token(Token = "0x40018E2")]
			Float,
			// Token: 0x040018E3 RID: 6371
			[Token(Token = "0x40018E3")]
			String,
			// Token: 0x040018E4 RID: 6372
			[Token(Token = "0x40018E4")]
			Long
		}
	}
}
