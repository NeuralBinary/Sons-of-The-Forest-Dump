using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	public static class MultiplayerUtilities
	{
		// Token: 0x060001E9 RID: 489 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x30ECF10", Offset = "0x30EB510", VA = "0x1830ECF10")]
		public static string GetDefaultServerName()
		{
			return null;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x30ECF50", Offset = "0x30EB550", VA = "0x1830ECF50")]
		public static string GetServerName()
		{
			return null;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x30ED020", Offset = "0x30EB620", VA = "0x1830ED020")]
		public static string Truncate(this string value, int maxLength)
		{
			return null;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x30ED050", Offset = "0x30EB650", VA = "0x1830ED050")]
		public static void SetServerName(string serverName)
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x30ED0E0", Offset = "0x30EB6E0", VA = "0x1830ED0E0")]
		public static string SanitizeServerName(string serverName, bool trim)
		{
			return null;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x30ED210", Offset = "0x30EB810", VA = "0x1830ED210")]
		public static string GeneratePasswordHash(string serverPassword)
		{
			return null;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x30ED450", Offset = "0x30EBA50", VA = "0x1830ED450")]
		public static void SetServerPassword(string inputPassword, string generatedHash)
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x30ED510", Offset = "0x30EBB10", VA = "0x1830ED510")]
		public static void ClearServerPassword()
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x30ED5B0", Offset = "0x30EBBB0", VA = "0x1830ED5B0")]
		public static string ToHexString(byte[] bytes, bool upperCase = false)
		{
			return null;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x30ED6C0", Offset = "0x30EBCC0", VA = "0x1830ED6C0")]
		public static ulong GetSteamId(BoltEntity playerEntity)
		{
			return 0UL;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x30ED7B0", Offset = "0x30EBDB0", VA = "0x1830ED7B0")]
		public static ulong GetSteamId(BoltConnection connection)
		{
			return 0UL;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x30ED960", Offset = "0x30EBF60", VA = "0x1830ED960")]
		public static int GetServerClientCount()
		{
			return 0;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x30ED9F0", Offset = "0x30EBFF0", VA = "0x1830ED9F0")]
		public static int SanitizeServerClientCount(int clientCount)
		{
			return 0;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x30EDA10", Offset = "0x30EC010", VA = "0x1830EDA10")]
		public static void SetServerClientCount(int clientCount)
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x30EDAA0", Offset = "0x30EC0A0", VA = "0x1830EDAA0")]
		public static bool GetServerIsPrivate()
		{
			return default(bool);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x30EDB20", Offset = "0x30EC120", VA = "0x1830EDB20")]
		public static void SetServerIsPrivate(bool isPrivate)
		{
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x30EDBB0", Offset = "0x30EC1B0", VA = "0x1830EDBB0")]
		public static void GetConnectionAndEntity(ulong steamId, out BoltConnection foundConnection, out BoltEntity foundEntity)
		{
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x30EDCD0", Offset = "0x30EC2D0", VA = "0x1830EDCD0")]
		public static BoltConnection GetConnectionFromConnectionId(int connectionId)
		{
			return null;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x30EDDB0", Offset = "0x30EC3B0", VA = "0x1830EDDB0")]
		public static BoltConnection GetConnectionFromSteamId(ulong steamId)
		{
			return null;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x30EDF80", Offset = "0x30EC580", VA = "0x1830EDF80")]
		public static BoltEntity GetEntityFromSteamId(ulong steamId)
		{
			return null;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x30EE180", Offset = "0x30EC780", VA = "0x1830EE180")]
		public static BoltEntity GetEntityFromBoltConnection(BoltConnection connection)
		{
			return null;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x30EE2C0", Offset = "0x30EC8C0", VA = "0x1830EE2C0")]
		public static void RegisterAttachedPlayerEntity(BoltEntity entity)
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x30EE390", Offset = "0x30EC990", VA = "0x1830EE390")]
		public static void RegisterDetachedPlayerEntity(BoltEntity entity)
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x30EE460", Offset = "0x30ECA60", VA = "0x1830EE460")]
		private static void CleanRegisteredPlayerEntities()
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x6000201")]
		public static bool TryGetComponentOnEntity<T>(BoltEntity target, out T comp, bool logError = false) where T : MonoBehaviour
		{
			return default(bool);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x6000202")]
		public static bool TryGetComponentInEntityChildren<T>(BoltEntity target, out T comp, bool logError = true) where T : MonoBehaviour
		{
			return default(bool);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x30EE720", Offset = "0x30ECD20", VA = "0x1830EE720")]
		public static GameObject BoltInstantiateIfNeeded(GameObject prefab, Vector3 spawnPos, Quaternion spawnRot)
		{
			return null;
		}

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		public const int MaxClientCount = 8;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		public const int MinClientCount = 2;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string ServerNameSettingKey;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string ServerPasswordSettingKey;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string ServerClientCountSettingKey;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string ServerPasswordHashSettingKey;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string ServerFilterNameSettingKey;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string ServerPrivateSettingKey;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x30")]
		private static List<BoltEntity> _playerEntities;
	}
}
