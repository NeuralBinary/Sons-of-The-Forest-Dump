using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	[Obsolete("Use [RequiredIn(PrefabKind.PrefabAsset)] instead.", true)]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class RequiredInPrefabAssetsAttribute : Attribute
	{
		// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2A89AA0", Offset = "0x2A880A0", VA = "0x182A89AA0")]
		public RequiredInPrefabAssetsAttribute()
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x753680", Offset = "0x751C80", VA = "0x180753680")]
		public RequiredInPrefabAssetsAttribute(string errorMessage, InfoMessageType messageType)
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2A89AB0", Offset = "0x2A880B0", VA = "0x182A89AB0")]
		public RequiredInPrefabAssetsAttribute(string errorMessage)
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
		public RequiredInPrefabAssetsAttribute(InfoMessageType messageType)
		{
		}

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x10")]
		public string ErrorMessage;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x18")]
		public InfoMessageType MessageType;
	}
}
