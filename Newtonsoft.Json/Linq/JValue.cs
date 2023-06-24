using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200018C RID: 396
	[Token(Token = "0x200018C")]
	[NullableContext(2)]
	[Nullable(0)]
	public class JValue : JToken, IEquatable<JValue>, IFormattable, IComparable, IComparable<JValue>, IConvertible
	{
		// Token: 0x06000DAF RID: 3503 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000DAF")]
		[Address(RVA = "0x25DD760", Offset = "0x25DBD60", VA = "0x1825DD760", Slot = "12")]
		[NullableContext(1)]
		public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB0")]
		[Address(RVA = "0x25DE1B0", Offset = "0x25DC7B0", VA = "0x1825DE1B0")]
		internal JValue(object value, JTokenType type)
		{
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB1")]
		[Address(RVA = "0x25CA2E0", Offset = "0x25C88E0", VA = "0x1825CA2E0")]
		[NullableContext(1)]
		internal JValue(JValue other, [Nullable(2)] JsonCloneSettings settings)
		{
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB2")]
		[Address(RVA = "0x25DE260", Offset = "0x25DC860", VA = "0x1825DE260")]
		[NullableContext(1)]
		public JValue(JValue other)
		{
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB3")]
		[Address(RVA = "0x25DE2F0", Offset = "0x25DC8F0", VA = "0x1825DE2F0")]
		public JValue(long value)
		{
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB4")]
		[Address(RVA = "0x25DE360", Offset = "0x25DC960", VA = "0x1825DE360")]
		public JValue(decimal value)
		{
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB5")]
		[Address(RVA = "0x25DE3E0", Offset = "0x25DC9E0", VA = "0x1825DE3E0")]
		public JValue(char value)
		{
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB6")]
		[Address(RVA = "0x25DE440", Offset = "0x25DCA40", VA = "0x1825DE440")]
		[CLSCompliant(false)]
		public JValue(ulong value)
		{
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB7")]
		[Address(RVA = "0x25DE4A0", Offset = "0x25DCAA0", VA = "0x1825DE4A0")]
		public JValue(double value)
		{
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB8")]
		[Address(RVA = "0x25DE510", Offset = "0x25DCB10", VA = "0x1825DE510")]
		public JValue(float value)
		{
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB9")]
		[Address(RVA = "0x25DE570", Offset = "0x25DCB70", VA = "0x1825DE570")]
		public JValue(DateTime value)
		{
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBA")]
		[Address(RVA = "0x25DE5D0", Offset = "0x25DCBD0", VA = "0x1825DE5D0")]
		public JValue(DateTimeOffset value)
		{
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBB")]
		[Address(RVA = "0x25DE640", Offset = "0x25DCC40", VA = "0x1825DE640")]
		public JValue(bool value)
		{
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBC")]
		[Address(RVA = "0x25DE6B0", Offset = "0x25DCCB0", VA = "0x1825DE6B0")]
		public JValue(string value)
		{
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBD")]
		[Address(RVA = "0x25DE6C0", Offset = "0x25DCCC0", VA = "0x1825DE6C0")]
		public JValue(Guid value)
		{
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBE")]
		[Address(RVA = "0x25DE730", Offset = "0x25DCD30", VA = "0x1825DE730")]
		public JValue(Uri value)
		{
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBF")]
		[Address(RVA = "0x25DE7A0", Offset = "0x25DCDA0", VA = "0x1825DE7A0")]
		public JValue(TimeSpan value)
		{
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DC0")]
		[Address(RVA = "0x25DE800", Offset = "0x25DCE00", VA = "0x1825DE800")]
		public JValue(object value)
		{
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00006708 File Offset: 0x00004908
		[Token(Token = "0x6000DC1")]
		[Address(RVA = "0x25DE840", Offset = "0x25DCE40", VA = "0x1825DE840", Slot = "14")]
		[NullableContext(1)]
		internal override bool DeepEquals(JToken node)
		{
			return default(bool);
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x00006720 File Offset: 0x00004920
		[Token(Token = "0x17000230")]
		public override bool HasValues
		{
			[Token(Token = "0x6000DC2")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00006738 File Offset: 0x00004938
		[Token(Token = "0x6000DC3")]
		[Address(RVA = "0x25DE8F0", Offset = "0x25DCEF0", VA = "0x1825DE8F0")]
		[NullableContext(1)]
		private static int CompareBigInteger(BigInteger i1, object i2)
		{
			return 0;
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00006750 File Offset: 0x00004950
		[Token(Token = "0x6000DC4")]
		[Address(RVA = "0x25DEDB0", Offset = "0x25DD3B0", VA = "0x1825DEDB0")]
		internal static int Compare(JTokenType valueType, object objA, object objB)
		{
			return 0;
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00006768 File Offset: 0x00004968
		[Token(Token = "0x6000DC5")]
		[Address(RVA = "0x25DFCB0", Offset = "0x25DE2B0", VA = "0x1825DFCB0")]
		[NullableContext(1)]
		private static int CompareFloat(object objA, object objB)
		{
			return 0;
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00006780 File Offset: 0x00004980
		[Token(Token = "0x6000DC6")]
		[Address(RVA = "0x25DFE70", Offset = "0x25DE470", VA = "0x1825DFE70")]
		private static bool Operation(ExpressionType operation, object objA, object objB, out object result)
		{
			return default(bool);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000DC7")]
		[Address(RVA = "0x25E0A00", Offset = "0x25DF000", VA = "0x1825E0A00", Slot = "13")]
		[NullableContext(1)]
		internal override JToken CloneToken([Nullable(2)] JsonCloneSettings settings)
		{
			return null;
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000DC8")]
		[Address(RVA = "0x25E0B00", Offset = "0x25DF100", VA = "0x1825E0B00")]
		[NullableContext(1)]
		public static JValue CreateComment([Nullable(2)] string value)
		{
			return null;
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000DC9")]
		[Address(RVA = "0x25E0B60", Offset = "0x25DF160", VA = "0x1825E0B60")]
		[NullableContext(1)]
		public static JValue CreateString([Nullable(2)] string value)
		{
			return null;
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000DCA")]
		[Address(RVA = "0x25E0BC0", Offset = "0x25DF1C0", VA = "0x1825E0BC0")]
		[NullableContext(1)]
		public static JValue CreateNull()
		{
			return null;
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000DCB")]
		[Address(RVA = "0x25E0C10", Offset = "0x25DF210", VA = "0x1825E0C10")]
		[NullableContext(1)]
		public static JValue CreateUndefined()
		{
			return null;
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00006798 File Offset: 0x00004998
		[Token(Token = "0x6000DCC")]
		[Address(RVA = "0x25E0C60", Offset = "0x25DF260", VA = "0x1825E0C60")]
		private static JTokenType GetValueType(JTokenType? current, object value)
		{
			return JTokenType.None;
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x000067B0 File Offset: 0x000049B0
		[Token(Token = "0x6000DCD")]
		[Address(RVA = "0x25E1180", Offset = "0x25DF780", VA = "0x1825E1180")]
		private static JTokenType GetStringValueType(JTokenType? current)
		{
			return JTokenType.None;
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x000067C8 File Offset: 0x000049C8
		[Token(Token = "0x17000231")]
		public override JTokenType Type
		{
			[Token(Token = "0x6000DCE")]
			[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0", Slot = "15")]
			get
			{
				return JTokenType.None;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000DD0 RID: 3536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000232")]
		public new object Value
		{
			[Token(Token = "0x6000DCF")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DD0")]
			[Address(RVA = "0x25E11E0", Offset = "0x25DF7E0", VA = "0x1825E11E0")]
			set
			{
			}
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD1")]
		[Address(RVA = "0x25E1300", Offset = "0x25DF900", VA = "0x1825E1300", Slot = "24")]
		[NullableContext(1)]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x000067E0 File Offset: 0x000049E0
		[Token(Token = "0x6000DD2")]
		[Address(RVA = "0x25E1CE0", Offset = "0x25E02E0", VA = "0x1825E1CE0", Slot = "25")]
		internal override int GetDeepHashCode()
		{
			return 0;
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x000067F8 File Offset: 0x000049F8
		[Token(Token = "0x6000DD3")]
		[Address(RVA = "0x25E1D20", Offset = "0x25E0320", VA = "0x1825E1D20")]
		[NullableContext(1)]
		private static bool ValuesEquals(JValue v1, JValue v2)
		{
			return default(bool);
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00006810 File Offset: 0x00004A10
		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0x25E1D70", Offset = "0x25E0370", VA = "0x1825E1D70", Slot = "27")]
		public bool Equals(JValue other)
		{
			return default(bool);
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00006828 File Offset: 0x00004A28
		[Token(Token = "0x6000DD5")]
		[Address(RVA = "0x25E1DC0", Offset = "0x25E03C0", VA = "0x1825E1DC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00006840 File Offset: 0x00004A40
		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0x25E1E70", Offset = "0x25E0470", VA = "0x1825E1E70", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000DD7")]
		[Address(RVA = "0x25E1E90", Offset = "0x25E0490", VA = "0x1825E1E90", Slot = "3")]
		[NullableContext(1)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000DD8")]
		[Address(RVA = "0x25E1EF0", Offset = "0x25E04F0", VA = "0x1825E1EF0")]
		[NullableContext(1)]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0x25E1FA0", Offset = "0x25E05A0", VA = "0x1825E1FA0", Slot = "46")]
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0x25E1FB0", Offset = "0x25E05B0", VA = "0x1825E1FB0", Slot = "28")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000DDB")]
		[Address(RVA = "0x25E2090", Offset = "0x25E0690", VA = "0x1825E2090", Slot = "26")]
		[NullableContext(1)]
		protected override DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return null;
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00006858 File Offset: 0x00004A58
		[Token(Token = "0x6000DDC")]
		[Address(RVA = "0x25E2150", Offset = "0x25E0750", VA = "0x1825E2150", Slot = "29")]
		private int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x00006870 File Offset: 0x00004A70
		[Token(Token = "0x6000DDD")]
		[Address(RVA = "0x25E2200", Offset = "0x25E0800", VA = "0x1825E2200", Slot = "30")]
		public int CompareTo(JValue obj)
		{
			return 0;
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00006888 File Offset: 0x00004A88
		[Token(Token = "0x6000DDE")]
		[Address(RVA = "0x25E2230", Offset = "0x25E0830", VA = "0x1825E2230", Slot = "31")]
		private TypeCode GetTypeCode()
		{
			return TypeCode.Empty;
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x000068A0 File Offset: 0x00004AA0
		[Token(Token = "0x6000DDF")]
		[Address(RVA = "0x25E22A0", Offset = "0x25E08A0", VA = "0x1825E22A0", Slot = "32")]
		private bool ToBoolean(IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x000068B8 File Offset: 0x00004AB8
		[Token(Token = "0x6000DE0")]
		[Address(RVA = "0x25E22F0", Offset = "0x25E08F0", VA = "0x1825E22F0", Slot = "33")]
		private char ToChar(IFormatProvider provider)
		{
			return '\0';
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x000068D0 File Offset: 0x00004AD0
		[Token(Token = "0x6000DE1")]
		[Address(RVA = "0x25E2340", Offset = "0x25E0940", VA = "0x1825E2340", Slot = "34")]
		private sbyte ToSByte(IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x000068E8 File Offset: 0x00004AE8
		[Token(Token = "0x6000DE2")]
		[Address(RVA = "0x25E2390", Offset = "0x25E0990", VA = "0x1825E2390", Slot = "35")]
		private byte ToByte(IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00006900 File Offset: 0x00004B00
		[Token(Token = "0x6000DE3")]
		[Address(RVA = "0x25E23E0", Offset = "0x25E09E0", VA = "0x1825E23E0", Slot = "36")]
		private short ToInt16(IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x00006918 File Offset: 0x00004B18
		[Token(Token = "0x6000DE4")]
		[Address(RVA = "0x25E2430", Offset = "0x25E0A30", VA = "0x1825E2430", Slot = "37")]
		private ushort ToUInt16(IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x00006930 File Offset: 0x00004B30
		[Token(Token = "0x6000DE5")]
		[Address(RVA = "0x25E2480", Offset = "0x25E0A80", VA = "0x1825E2480", Slot = "38")]
		private int ToInt32(IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x00006948 File Offset: 0x00004B48
		[Token(Token = "0x6000DE6")]
		[Address(RVA = "0x25E24D0", Offset = "0x25E0AD0", VA = "0x1825E24D0", Slot = "39")]
		private uint ToUInt32(IFormatProvider provider)
		{
			return 0U;
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x00006960 File Offset: 0x00004B60
		[Token(Token = "0x6000DE7")]
		[Address(RVA = "0x25E2520", Offset = "0x25E0B20", VA = "0x1825E2520", Slot = "40")]
		private long ToInt64(IFormatProvider provider)
		{
			return 0L;
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00006978 File Offset: 0x00004B78
		[Token(Token = "0x6000DE8")]
		[Address(RVA = "0x25E2570", Offset = "0x25E0B70", VA = "0x1825E2570", Slot = "41")]
		private ulong ToUInt64(IFormatProvider provider)
		{
			return 0UL;
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00006990 File Offset: 0x00004B90
		[Token(Token = "0x6000DE9")]
		[Address(RVA = "0x25E25C0", Offset = "0x25E0BC0", VA = "0x1825E25C0", Slot = "42")]
		private float ToSingle(IFormatProvider provider)
		{
			return 0f;
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x000069A8 File Offset: 0x00004BA8
		[Token(Token = "0x6000DEA")]
		[Address(RVA = "0x25E2610", Offset = "0x25E0C10", VA = "0x1825E2610", Slot = "43")]
		private double ToDouble(IFormatProvider provider)
		{
			return 0.0;
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x000069C0 File Offset: 0x00004BC0
		[Token(Token = "0x6000DEB")]
		[Address(RVA = "0x25E2660", Offset = "0x25E0C60", VA = "0x1825E2660", Slot = "44")]
		private decimal ToDecimal(IFormatProvider provider)
		{
			return 0m;
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x000069D8 File Offset: 0x00004BD8
		[Token(Token = "0x6000DEC")]
		[Address(RVA = "0x25E26D0", Offset = "0x25E0CD0", VA = "0x1825E26D0", Slot = "45")]
		private DateTime ToDateTime(IFormatProvider provider)
		{
			return default(DateTime);
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000DED")]
		[Address(RVA = "0x25E2720", Offset = "0x25E0D20", VA = "0x1825E2720", Slot = "47")]
		[NullableContext(1)]
		private object ToType(Type conversionType, [Nullable(2)] IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x04000758 RID: 1880
		[Token(Token = "0x4000758")]
		[FieldOffset(Offset = "0x30")]
		private JTokenType _valueType;

		// Token: 0x04000759 RID: 1881
		[Token(Token = "0x4000759")]
		[FieldOffset(Offset = "0x38")]
		private object _value;

		// Token: 0x0200018D RID: 397
		[Token(Token = "0x200018D")]
		[NullableContext(1)]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		private class JValueDynamicProxy : DynamicProxy<JValue>
		{
			// Token: 0x06000DEE RID: 3566 RVA: 0x000069F0 File Offset: 0x00004BF0
			[Token(Token = "0x6000DEE")]
			[Address(RVA = "0x25E2730", Offset = "0x25E0D30", VA = "0x1825E2730", Slot = "6")]
			public override bool TryConvert(JValue instance, ConvertBinder binder, [Nullable(2)] [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out object result)
			{
				return default(bool);
			}

			// Token: 0x06000DEF RID: 3567 RVA: 0x00006A08 File Offset: 0x00004C08
			[Token(Token = "0x6000DEF")]
			[Address(RVA = "0x25E2960", Offset = "0x25E0F60", VA = "0x1825E2960", Slot = "5")]
			public override bool TryBinaryOperation(JValue instance, BinaryOperationBinder binder, object arg, [Nullable(2)] [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out object result)
			{
				return default(bool);
			}

			// Token: 0x06000DF0 RID: 3568 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DF0")]
			[Address(RVA = "0x25E2D00", Offset = "0x25E1300", VA = "0x1825E2D00")]
			public JValueDynamicProxy()
			{
			}
		}
	}
}
