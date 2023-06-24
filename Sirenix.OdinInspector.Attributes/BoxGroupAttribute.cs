using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	public class BoxGroupAttribute : PropertyGroupAttribute
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2A87E60", Offset = "0x2A86460", VA = "0x182A87E60")]
		public BoxGroupAttribute(string group, bool showLabel = true, bool centerLabel = false, float order = 0f)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2A87EA0", Offset = "0x2A864A0", VA = "0x182A87EA0")]
		public BoxGroupAttribute()
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2A87EF0", Offset = "0x2A864F0", VA = "0x182A87EF0", Slot = "7")]
		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x38")]
		public bool ShowLabel;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x39")]
		public bool CenterLabel;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x40")]
		public string LabelText;
	}
}
