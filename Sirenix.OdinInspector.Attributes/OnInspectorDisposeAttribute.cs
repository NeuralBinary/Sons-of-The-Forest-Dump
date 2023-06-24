using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
	[DontApplyToListElements]
	[Conditional("UNITY_EDITOR")]
	[IncludeMyAttributes]
	[HideInTables]
	public class OnInspectorDisposeAttribute : ShowInInspectorAttribute
	{
		// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public OnInspectorDisposeAttribute()
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public OnInspectorDisposeAttribute(string action)
		{
		}

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x10")]
		public string Action;
	}
}
