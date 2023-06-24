using System;
using Bolt;
using Il2CppDummyDll;

namespace Endnight.Extensions
{
	// Token: 0x020000A6 RID: 166
	[Token(Token = "0x20000A6")]
	public static class BoltExtensions
	{
		// Token: 0x060003A8 RID: 936 RVA: 0x000039F0 File Offset: 0x00001BF0
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xAA34F0", Offset = "0xAA1AF0", VA = "0x180AA34F0")]
		public static bool IsOwnerSafe(this BoltEntity entity)
		{
			return default(bool);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00003A08 File Offset: 0x00001C08
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xAA35F0", Offset = "0xAA1BF0", VA = "0x180AA35F0")]
		public static bool IsAttachedSafe(this BoltEntity entity)
		{
			return default(bool);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00003A20 File Offset: 0x00001C20
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xAA36E0", Offset = "0xAA1CE0", VA = "0x180AA36E0")]
		public static bool IsFrozenSafe(this BoltEntity entity)
		{
			return default(bool);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00003A38 File Offset: 0x00001C38
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xAA37F0", Offset = "0xAA1DF0", VA = "0x180AA37F0")]
		public static bool HasControlSafe(this BoltEntity entity)
		{
			return default(bool);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00003A50 File Offset: 0x00001C50
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xAA3980", Offset = "0xAA1F80", VA = "0x180AA3980")]
		public static bool TryGetSenderPlayerEntity(this Event evnt, out BoltEntity playerEntity)
		{
			return default(bool);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00003A68 File Offset: 0x00001C68
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xAA3B60", Offset = "0xAA2160", VA = "0x180AA3B60")]
		public static bool IsFromServer(this Event eventSource)
		{
			return default(bool);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00003A80 File Offset: 0x00001C80
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xAA3CA0", Offset = "0xAA22A0", VA = "0x180AA3CA0")]
		public static bool IsFromClient(this Event eventSource)
		{
			return default(bool);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00003A98 File Offset: 0x00001C98
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xAA3DE0", Offset = "0xAA23E0", VA = "0x180AA3DE0")]
		public static bool IsServer(this BoltConnection connection)
		{
			return default(bool);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xAA3EF0", Offset = "0xAA24F0", VA = "0x180AA3EF0")]
		public static bool IsClient(this BoltConnection connection)
		{
			return default(bool);
		}
	}
}
