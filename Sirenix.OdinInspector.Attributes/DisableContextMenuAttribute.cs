using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[Conditional("UNITY_EDITOR")]
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class DisableContextMenuAttribute : Attribute
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x20DC7F0", Offset = "0x20DADF0", VA = "0x1820DC7F0")]
		public DisableContextMenuAttribute(bool disableForMember = true, bool disableCollectionElements = false)
		{
		}

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x10")]
		public bool DisableForMember;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x11")]
		public bool DisableForCollectionElements;
	}
}
