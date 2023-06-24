using System;
using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Internal
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	[Serializable]
	public class PropertyReference
	{
		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F7")]
		public Component target
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x268C720", Offset = "0x268AD20", VA = "0x18268C720")]
			set
			{
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F8")]
		public string name
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x268C820", Offset = "0x268AE20", VA = "0x18268C820")]
			set
			{
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00003DE0 File Offset: 0x00001FE0
		[Token(Token = "0x170000F9")]
		public bool isValid
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x268C920", Offset = "0x268AF20", VA = "0x18268C920")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00003DF8 File Offset: 0x00001FF8
		[Token(Token = "0x170000FA")]
		public bool isEnabled
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x268CA00", Offset = "0x268B000", VA = "0x18268CA00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public PropertyReference()
		{
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x992FC0", Offset = "0x9915C0", VA = "0x180992FC0")]
		public PropertyReference(Component target, string fieldName)
		{
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x268CBF0", Offset = "0x268B1F0", VA = "0x18268CBF0")]
		public Type GetPropertyType()
		{
			return null;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00003E10 File Offset: 0x00002010
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x268CCC0", Offset = "0x268B2C0", VA = "0x18268CCC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00003E28 File Offset: 0x00002028
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x268CE90", Offset = "0x268B490", VA = "0x18268CE90", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x992FC0", Offset = "0x9915C0", VA = "0x180992FC0")]
		public void Set(Component target, string methodName)
		{
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x268CEE0", Offset = "0x268B4E0", VA = "0x18268CEE0")]
		public void Clear()
		{
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x268CF90", Offset = "0x268B590", VA = "0x18268CF90")]
		public void Reset()
		{
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x268D040", Offset = "0x268B640", VA = "0x18268D040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x268D0A0", Offset = "0x268B6A0", VA = "0x18268D0A0")]
		public static string ToString(Component comp, string property)
		{
			return null;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x268D240", Offset = "0x268B840", VA = "0x18268D240")]
		[DebuggerHidden]
		[DebuggerStepThrough]
		public object Get()
		{
			return null;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00003E40 File Offset: 0x00002040
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x268D2F0", Offset = "0x268B8F0", VA = "0x18268D2F0")]
		[DebuggerHidden]
		[DebuggerStepThrough]
		public bool Set(object value)
		{
			return default(bool);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00003E58 File Offset: 0x00002058
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x268D720", Offset = "0x268BD20", VA = "0x18268D720")]
		[DebuggerStepThrough]
		[DebuggerHidden]
		private bool Cache()
		{
			return default(bool);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00003E70 File Offset: 0x00002070
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x268DA80", Offset = "0x268C080", VA = "0x18268DA80")]
		private bool Convert(ref object value)
		{
			return default(bool);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00003E88 File Offset: 0x00002088
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x268DC00", Offset = "0x268C200", VA = "0x18268DC00")]
		public static bool Convert(Type from, Type to)
		{
			return default(bool);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00003EA0 File Offset: 0x000020A0
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x268DC70", Offset = "0x268C270", VA = "0x18268DC70")]
		public static bool Convert(object value, Type to)
		{
			return default(bool);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00003EB8 File Offset: 0x000020B8
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x268DD30", Offset = "0x268C330", VA = "0x18268DD30")]
		public static bool Convert(ref object value, Type from, Type to)
		{
			return default(bool);
		}

		// Token: 0x04000328 RID: 808
		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Component mTarget;

		// Token: 0x04000329 RID: 809
		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string mName;

		// Token: 0x0400032A RID: 810
		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x20")]
		private FieldInfo mField;

		// Token: 0x0400032B RID: 811
		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x28")]
		private PropertyInfo mProperty;

		// Token: 0x0400032C RID: 812
		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x0")]
		private static int s_Hash;
	}
}
