using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class OnInspectorGUIAttribute : ShowInInspectorAttribute
	{
		// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public OnInspectorGUIAttribute()
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2A89120", Offset = "0x2A87720", VA = "0x182A89120")]
		public OnInspectorGUIAttribute(string action, bool append = true)
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x992FC0", Offset = "0x9915C0", VA = "0x180992FC0")]
		public OnInspectorGUIAttribute(string prepend, string append)
		{
		}

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x10")]
		public string Prepend;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x18")]
		public string Append;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x20")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use the Prepend member instead.", false)]
		public string PrependMethodName;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x28")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use the Append member instead.", false)]
		public string AppendMethodName;
	}
}
