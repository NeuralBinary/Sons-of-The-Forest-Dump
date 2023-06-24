using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Obsolete("Use [RequiredIn(PrefabKind.PrefabInstance)] instead.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Conditional("UNITY_EDITOR")]
	public sealed class RequiredInPrefabInstancesAttribute : Attribute
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2A89AA0", Offset = "0x2A880A0", VA = "0x182A89AA0")]
		public RequiredInPrefabInstancesAttribute()
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x753680", Offset = "0x751C80", VA = "0x180753680")]
		public RequiredInPrefabInstancesAttribute(string errorMessage, InfoMessageType messageType)
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2A89AB0", Offset = "0x2A880B0", VA = "0x182A89AB0")]
		public RequiredInPrefabInstancesAttribute(string errorMessage)
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
		public RequiredInPrefabInstancesAttribute(InfoMessageType messageType)
		{
		}

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x10")]
		public string ErrorMessage;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x18")]
		public InfoMessageType MessageType;
	}
}
