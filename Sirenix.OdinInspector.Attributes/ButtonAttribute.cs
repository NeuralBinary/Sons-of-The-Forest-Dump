using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
	[Conditional("UNITY_EDITOR")]
	public class ButtonAttribute : ShowInInspectorAttribute
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002058 File Offset: 0x00000258
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public bool DrawResult
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x2572A00", Offset = "0x2571000", VA = "0x182572A00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x2A87FA0", Offset = "0x2A865A0", VA = "0x182A87FA0")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002070 File Offset: 0x00000270
		[Token(Token = "0x17000003")]
		public bool DrawResultIsSet
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2A87FB0", Offset = "0x2A865B0", VA = "0x182A87FB0")]
		public ButtonAttribute()
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2A88010", Offset = "0x2A86610", VA = "0x182A88010")]
		public ButtonAttribute(ButtonSizes size)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2A88080", Offset = "0x2A86680", VA = "0x182A88080")]
		public ButtonAttribute(int buttonSize)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2A880E0", Offset = "0x2A866E0", VA = "0x182A880E0")]
		public ButtonAttribute(string name)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2A88150", Offset = "0x2A86750", VA = "0x182A88150")]
		public ButtonAttribute(string name, ButtonSizes buttonSize)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2A88150", Offset = "0x2A86750", VA = "0x182A88150")]
		public ButtonAttribute(string name, int buttonSize)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2A881B0", Offset = "0x2A867B0", VA = "0x182A881B0")]
		public ButtonAttribute(ButtonStyle parameterBtnStyle)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2A88230", Offset = "0x2A86830", VA = "0x182A88230")]
		public ButtonAttribute(int buttonSize, ButtonStyle parameterBtnStyle)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2A88230", Offset = "0x2A86830", VA = "0x182A88230")]
		public ButtonAttribute(ButtonSizes size, ButtonStyle parameterBtnStyle)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2A882A0", Offset = "0x2A868A0", VA = "0x182A882A0")]
		public ButtonAttribute(string name, ButtonStyle parameterBtnStyle)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2A88310", Offset = "0x2A86910", VA = "0x182A88310")]
		public ButtonAttribute(string name, ButtonSizes buttonSize, ButtonStyle parameterBtnStyle)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2A88310", Offset = "0x2A86910", VA = "0x182A88310")]
		public ButtonAttribute(string name, int buttonSize, ButtonStyle parameterBtnStyle)
		{
		}

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x10")]
		public int ButtonHeight;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x20")]
		public ButtonStyle Style;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x24")]
		public bool Expanded;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x25")]
		public bool DisplayParameters;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x26")]
		public bool DirtyOnClick;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x27")]
		private bool drawResult;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x28")]
		private bool drawResultIsSet;
	}
}
