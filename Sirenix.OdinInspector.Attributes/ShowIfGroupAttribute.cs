using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	[Conditional("UNITY_EDITOR")]
	public class ShowIfGroupAttribute : PropertyGroupAttribute
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00002310 File Offset: 0x00000510
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000034")]
		public bool Animate
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x620AD0", Offset = "0x61F0D0", VA = "0x180620AD0")]
			set
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000035")]
		[Obsolete("Use the Condition member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string MemberName
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x2A887B0", Offset = "0x2A86DB0", VA = "0x182A887B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			set
			{
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000036")]
		public string Condition
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x2A887B0", Offset = "0x2A86DB0", VA = "0x182A887B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			set
			{
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2A887D0", Offset = "0x2A86DD0", VA = "0x182A887D0")]
		public ShowIfGroupAttribute(string path, bool animate = true)
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2A88800", Offset = "0x2A86E00", VA = "0x182A88800")]
		public ShowIfGroupAttribute(string path, object value, bool animate = true)
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2A89BF0", Offset = "0x2A881F0", VA = "0x182A89BF0", Slot = "7")]
		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x38")]
		public object Value;
	}
}
