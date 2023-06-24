using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace Sons.Ai.Vail
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	[Serializable]
	public abstract class Enumeration : IComparable, IEquatable<Enumeration>
	{
		// Token: 0x060004E4 RID: 1252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x2B20A50", Offset = "0x2B1F050", VA = "0x182B20A50")]
		protected Enumeration(int id, string name)
		{
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60004E6")]
		public static IEnumerable<T> GetAll<T>() where T : Enumeration
		{
			return null;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x2B20AB0", Offset = "0x2B1F0B0", VA = "0x182B20AB0")]
		private static object Selector(FieldInfo f)
		{
			return null;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x000044B8 File Offset: 0x000026B8
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x2B20AE0", Offset = "0x2B1F0E0", VA = "0x182B20AE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x000044D0 File Offset: 0x000026D0
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x2B20BE0", Offset = "0x2B1F1E0", VA = "0x182B20BE0", Slot = "4")]
		public int CompareTo(object other)
		{
			return 0;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x000044E8 File Offset: 0x000026E8
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x2B20C80", Offset = "0x2B1F280", VA = "0x182B20C80", Slot = "5")]
		public bool Equals(Enumeration other)
		{
			return default(bool);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00004500 File Offset: 0x00002700
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x10")]
		private readonly string _name;

		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x18")]
		internal readonly int _id;
	}
}
