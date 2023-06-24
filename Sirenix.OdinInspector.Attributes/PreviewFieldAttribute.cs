using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class PreviewFieldAttribute : Attribute
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00002268 File Offset: 0x00000468
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000025")]
		public ObjectFieldAlignment Alignment
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return ObjectFieldAlignment.Left;
			}
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x2A89240", Offset = "0x2A87840", VA = "0x182A89240")]
			set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x17000026")]
		public bool AlignmentHasValue
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x5FD560", Offset = "0x5FBB60", VA = "0x1805FD560")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x72C280", Offset = "0x72A880", VA = "0x18072C280")]
		public PreviewFieldAttribute()
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xA308C0", Offset = "0xA2EEC0", VA = "0x180A308C0")]
		public PreviewFieldAttribute(float height)
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2A89250", Offset = "0x2A87850", VA = "0x182A89250")]
		public PreviewFieldAttribute(float height, ObjectFieldAlignment alignment)
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2A89240", Offset = "0x2A87840", VA = "0x182A89240")]
		public PreviewFieldAttribute(ObjectFieldAlignment alignment)
		{
		}

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x10")]
		private ObjectFieldAlignment alignment;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x14")]
		private bool alignmentHasValue;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x18")]
		public float Height;
	}
}
