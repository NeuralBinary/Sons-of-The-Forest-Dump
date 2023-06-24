using System;
using Il2CppDummyDll;
using Steamworks;
using TheForest.Commons.Enums;
using UdpKit;

namespace Sons.Multiplayer
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	[Obsolete]
	public static class SteamClientDSConfig_DEPRECATED
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00002E38 File Offset: 0x00001038
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004E")]
		public static bool IsClientAtWorld
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x30F1AD0", Offset = "0x30F00D0", VA = "0x1830F1AD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x30F1B20", Offset = "0x30F0120", VA = "0x1830F1B20")]
			set
			{
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x30F1B80", Offset = "0x30F0180", VA = "0x1830F1B80")]
		public static void Clear()
		{
		}

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x0")]
		public static bool IsDedicatedClient;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x1")]
		public static bool IsDSFirstClient;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x8")]
		public static string password;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x10")]
		public static string adminPassword;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x18")]
		public static string serverAddress;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x20")]
		public static InitTypes gameType;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x24")]
		public static UdpEndPoint EndPoint;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x30")]
		public static string Guid;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x38")]
		public static gameserveritem_t Server;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x40")]
		public static int playerCount;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		public const int steamBlobSize = 2048;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x48")]
		public static byte[] steamClientBlob;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x50")]
		private static bool isClientAtWorld;
	}
}
