using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class JsonData : IJsonWrapper, IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary, IEquatable<JsonData>
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000008")]
		public int Count
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x2085240", Offset = "0x2083840", VA = "0x182085240")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x17000009")]
		public bool IsArray
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x1EBCFE0", Offset = "0x1EBB5E0", VA = "0x181EBCFE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x1700000A")]
		public bool IsBoolean
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x20852A0", Offset = "0x20838A0", VA = "0x1820852A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000020B0 File Offset: 0x000002B0
		[Token(Token = "0x1700000B")]
		public bool IsDouble
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x20852B0", Offset = "0x20838B0", VA = "0x1820852B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000020C8 File Offset: 0x000002C8
		[Token(Token = "0x1700000C")]
		public bool IsInt
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x20852C0", Offset = "0x20838C0", VA = "0x1820852C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000020E0 File Offset: 0x000002E0
		[Token(Token = "0x1700000D")]
		public bool IsLong
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x20852D0", Offset = "0x20838D0", VA = "0x1820852D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000020F8 File Offset: 0x000002F8
		[Token(Token = "0x1700000E")]
		public bool IsObject
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x20852E0", Offset = "0x20838E0", VA = "0x1820852E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002110 File Offset: 0x00000310
		[Token(Token = "0x1700000F")]
		public bool IsString
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x20852F0", Offset = "0x20838F0", VA = "0x1820852F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002128 File Offset: 0x00000328
		[Token(Token = "0x17000010")]
		private int Count
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x2085240", Offset = "0x2083840", VA = "0x182085240", Slot = "37")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002140 File Offset: 0x00000340
		[Token(Token = "0x17000011")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x2085300", Offset = "0x2083900", VA = "0x182085300", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x17000012")]
		private object SyncRoot
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x2085360", Offset = "0x2083960", VA = "0x182085360", Slot = "38")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000023 RID: 35 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x17000013")]
		private bool IsFixedSize
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x20853C0", Offset = "0x20839C0", VA = "0x1820853C0", Slot = "54")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x17000014")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x2085420", Offset = "0x2083A20", VA = "0x182085420", Slot = "53")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x17000015")]
		private ICollection Keys
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x2085480", Offset = "0x2083A80", VA = "0x182085480", Slot = "48")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x17000016")]
		private ICollection Values
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x2085770", Offset = "0x2083D70", VA = "0x182085770", Slot = "49")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000027 RID: 39 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x17000017")]
		private bool IsArray
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x1EBCFE0", Offset = "0x1EBB5E0", VA = "0x181EBCFE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x17000018")]
		private bool IsBoolean
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x20852A0", Offset = "0x20838A0", VA = "0x1820852A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x17000019")]
		private bool IsDouble
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x20852B0", Offset = "0x20838B0", VA = "0x1820852B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x1700001A")]
		private bool IsInt
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x20852C0", Offset = "0x20838C0", VA = "0x1820852C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x1700001B")]
		private bool IsLong
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x20852D0", Offset = "0x20838D0", VA = "0x1820852D0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x1700001C")]
		private bool IsObject
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x20852E0", Offset = "0x20838E0", VA = "0x1820852E0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600002D RID: 45 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x1700001D")]
		private bool IsString
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x20852F0", Offset = "0x20838F0", VA = "0x1820852F0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x1700001E")]
		private bool IsFixedSize
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x2085A60", Offset = "0x2084060", VA = "0x182085A60", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600002F RID: 47 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x1700001F")]
		private bool IsReadOnly
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x2085AC0", Offset = "0x20840C0", VA = "0x182085AC0", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002156 File Offset: 0x00000356
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000020")]
		private object Item
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x2085B20", Offset = "0x2084120", VA = "0x182085B20", Slot = "46")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x2085B80", Offset = "0x2084180", VA = "0x182085B80", Slot = "47")]
			set
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002156 File Offset: 0x00000356
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000021")]
		private object Item
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x2085C70", Offset = "0x2084270", VA = "0x182085C70", Slot = "41")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x2085D50", Offset = "0x2084350", VA = "0x182085D50", Slot = "42")]
			set
			{
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002156 File Offset: 0x00000356
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000022")]
		private object Item
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x2085F60", Offset = "0x2084560", VA = "0x182085F60", Slot = "25")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x2085FC0", Offset = "0x20845C0", VA = "0x182085FC0", Slot = "26")]
			set
			{
			}
		}

		// Token: 0x17000023 RID: 35
		[Token(Token = "0x17000023")]
		public JsonData this[string prop_name]
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x2086010", Offset = "0x2084610", VA = "0x182086010")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x20860D0", Offset = "0x20846D0", VA = "0x1820860D0")]
			set
			{
			}
		}

		// Token: 0x17000024 RID: 36
		[Token(Token = "0x17000024")]
		public JsonData this[int index]
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x20863A0", Offset = "0x20849A0", VA = "0x1820863A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x20864B0", Offset = "0x2084AB0", VA = "0x1820864B0")]
			set
			{
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public JsonData()
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x20866D0", Offset = "0x2084CD0", VA = "0x1820866D0")]
		public JsonData(bool boolean)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x20866E0", Offset = "0x2084CE0", VA = "0x1820866E0")]
		public JsonData(double number)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x20866F0", Offset = "0x2084CF0", VA = "0x1820866F0")]
		public JsonData(int number)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2086700", Offset = "0x2084D00", VA = "0x182086700")]
		public JsonData(long number)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2086710", Offset = "0x2084D10", VA = "0x182086710")]
		public JsonData(object obj)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2086980", Offset = "0x2084F80", VA = "0x182086980")]
		public JsonData(string str)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x20869E0", Offset = "0x2084FE0", VA = "0x1820869E0")]
		public static implicit operator JsonData(bool data)
		{
			return null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2086A30", Offset = "0x2085030", VA = "0x182086A30")]
		public static implicit operator JsonData(double data)
		{
			return null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2086A80", Offset = "0x2085080", VA = "0x182086A80")]
		public static implicit operator JsonData(int data)
		{
			return null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2086AC0", Offset = "0x20850C0", VA = "0x182086AC0")]
		public static implicit operator JsonData(long data)
		{
			return null;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2086B10", Offset = "0x2085110", VA = "0x182086B10")]
		public static implicit operator JsonData(string data)
		{
			return null;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2086BA0", Offset = "0x20851A0", VA = "0x182086BA0")]
		public static explicit operator bool(JsonData data)
		{
			return default(bool);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2086C10", Offset = "0x2085210", VA = "0x182086C10")]
		public static explicit operator double(JsonData data)
		{
			return 0.0;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2086C90", Offset = "0x2085290", VA = "0x182086C90")]
		public static explicit operator int(JsonData data)
		{
			return 0;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2086D00", Offset = "0x2085300", VA = "0x182086D00")]
		public static explicit operator long(JsonData data)
		{
			return 0L;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2086D70", Offset = "0x2085370", VA = "0x182086D70")]
		public static explicit operator string(JsonData data)
		{
			return null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2086DE0", Offset = "0x20853E0", VA = "0x182086DE0", Slot = "36")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2086E50", Offset = "0x2085450", VA = "0x182086E50", Slot = "51")]
		private void Add(object key, object value)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2086FC0", Offset = "0x20855C0", VA = "0x182086FC0", Slot = "52")]
		private void Clear()
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2087090", Offset = "0x2085690", VA = "0x182087090", Slot = "50")]
		private bool Contains(object key)
		{
			return default(bool);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2087100", Offset = "0x2085700", VA = "0x182087100", Slot = "55")]
		private IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2087140", Offset = "0x2085740", VA = "0x182087140", Slot = "56")]
		private void Remove(object key)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x20873B0", Offset = "0x20859B0", VA = "0x1820873B0", Slot = "40")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2087400", Offset = "0x2085A00", VA = "0x182087400", Slot = "11")]
		private bool GetBoolean()
		{
			return default(bool);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2087470", Offset = "0x2085A70", VA = "0x182087470", Slot = "12")]
		private double GetDouble()
		{
			return 0.0;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x20874E0", Offset = "0x2085AE0", VA = "0x1820874E0", Slot = "13")]
		private int GetInt()
		{
			return 0;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2087550", Offset = "0x2085B50", VA = "0x182087550", Slot = "15")]
		private long GetLong()
		{
			return 0L;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x20875C0", Offset = "0x2085BC0", VA = "0x1820875C0", Slot = "16")]
		private string GetString()
		{
			return null;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2087630", Offset = "0x2085C30", VA = "0x182087630", Slot = "17")]
		private void SetBoolean(bool val)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x20876A0", Offset = "0x2085CA0", VA = "0x1820876A0", Slot = "18")]
		private void SetDouble(double val)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2087700", Offset = "0x2085D00", VA = "0x182087700", Slot = "19")]
		private void SetInt(int val)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2087770", Offset = "0x2085D70", VA = "0x182087770", Slot = "21")]
		private void SetLong(long val)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x20877E0", Offset = "0x2085DE0", VA = "0x1820877E0", Slot = "22")]
		private void SetString(string val)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x20878A0", Offset = "0x2085EA0", VA = "0x1820878A0", Slot = "23")]
		private string ToJson()
		{
			return null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x20878B0", Offset = "0x2085EB0", VA = "0x1820878B0", Slot = "24")]
		private void ToJson(JsonWriter writer)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x20878F0", Offset = "0x2085EF0", VA = "0x1820878F0", Slot = "27")]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x20879C0", Offset = "0x2085FC0", VA = "0x1820879C0", Slot = "29")]
		private void Clear()
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2087A60", Offset = "0x2086060", VA = "0x182087A60", Slot = "28")]
		private bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2087AD0", Offset = "0x20860D0", VA = "0x182087AD0", Slot = "32")]
		private int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2087B40", Offset = "0x2086140", VA = "0x182087B40", Slot = "33")]
		private void Insert(int index, object value)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2087C10", Offset = "0x2086210", VA = "0x182087C10", Slot = "34")]
		private void Remove(object value)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2087CD0", Offset = "0x20862D0", VA = "0x182087CD0", Slot = "35")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2087D90", Offset = "0x2086390", VA = "0x182087D90", Slot = "43")]
		private IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2087E50", Offset = "0x2086450", VA = "0x182087E50", Slot = "44")]
		private void Insert(int idx, object key, object value)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2087FD0", Offset = "0x20865D0", VA = "0x182087FD0", Slot = "45")]
		private void RemoveAt(int idx)
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2088120", Offset = "0x2086720", VA = "0x182088120")]
		private ICollection EnsureCollection()
		{
			return null;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2088210", Offset = "0x2086810", VA = "0x182088210")]
		private IDictionary EnsureDictionary()
		{
			return null;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2088440", Offset = "0x2086A40", VA = "0x182088440")]
		private IList EnsureList()
		{
			return null;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x20885C0", Offset = "0x2086BC0", VA = "0x1820885C0")]
		private JsonData ToJsonData(object obj)
		{
			return null;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2088680", Offset = "0x2086C80", VA = "0x182088680")]
		private static void WriteJson(IJsonWrapper obj, JsonWriter writer)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x20878F0", Offset = "0x2085EF0", VA = "0x1820878F0")]
		public int Add(object value)
		{
			return 0;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2088C70", Offset = "0x2087270", VA = "0x182088C70")]
		public void Clear()
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2088CF0", Offset = "0x20872F0", VA = "0x182088CF0", Slot = "57")]
		public bool Equals(JsonData x)
		{
			return default(bool);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x9AF280", Offset = "0x9AD880", VA = "0x1809AF280", Slot = "14")]
		public JsonType GetJsonType()
		{
			return JsonType.None;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2088E30", Offset = "0x2087430", VA = "0x182088E30", Slot = "20")]
		public void SetJsonType(JsonType type)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2089010", Offset = "0x2087610", VA = "0x182089010")]
		public string ToJson()
		{
			return null;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x20878B0", Offset = "0x2085EB0", VA = "0x1820878B0")]
		public void ToJson(JsonWriter writer)
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2089290", Offset = "0x2087890", VA = "0x182089290", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x10")]
		private IList<JsonData> inst_array;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x18")]
		private bool inst_boolean;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x20")]
		private double inst_double;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x28")]
		private int inst_int;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x30")]
		private long inst_long;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x38")]
		private IDictionary<string, JsonData> inst_object;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x40")]
		private string inst_string;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x48")]
		private string json;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x50")]
		private JsonType type;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x58")]
		private IList<KeyValuePair<string, JsonData>> object_list;
	}
}
