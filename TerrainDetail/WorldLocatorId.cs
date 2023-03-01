using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Sons.TerrainDetail
{
	// Token: 0x02000507 RID: 1287
	[Token(Token = "0x2000507")]
	[JsonConverter(typeof(WorldLocatorIdJsonConverter))]
	[Serializable]
	public class WorldLocatorId
	{
		// Token: 0x060020DF RID: 8415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DF")]
		[Address(RVA = "0x2D3B960", Offset = "0x2D3A960", VA = "0x182D3B960")]
		public WorldLocatorId(Guid guid)
		{
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E0")]
		[Address(RVA = "0x2D3B120", Offset = "0x2D3A120", VA = "0x182D3B120", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E1")]
		[Address(RVA = "0x2D3B8D0", Offset = "0x2D3A8D0", VA = "0x182D3B8D0")]
		public WorldLocatorId(byte[] sourceBytes)
		{
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E2")]
		[Address(RVA = "0x5430A0", Offset = "0x5420A0", VA = "0x1805430A0")]
		public byte[] GetBytes()
		{
			return null;
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E3")]
		[Address(RVA = "0x2D3A8C0", Offset = "0x2D398C0", VA = "0x182D3A8C0")]
		public static WorldLocatorId CalculateUniqueId(Vector3 position)
		{
			return null;
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x000097F8 File Offset: 0x000079F8
		[Token(Token = "0x60020E4")]
		[Address(RVA = "0x2D3AC70", Offset = "0x2D39C70", VA = "0x182D3AC70")]
		protected bool Equals(WorldLocatorId other)
		{
			return default(bool);
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x00009810 File Offset: 0x00007A10
		[Token(Token = "0x60020E5")]
		[Address(RVA = "0x2D3AB40", Offset = "0x2D39B40", VA = "0x182D3AB40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x00009828 File Offset: 0x00007A28
		[Token(Token = "0x60020E6")]
		[Address(RVA = "0x2D3AE90", Offset = "0x2D39E90", VA = "0x182D3AE90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x00009840 File Offset: 0x00007A40
		[Token(Token = "0x60020E7")]
		[Address(RVA = "0x2D3B9F0", Offset = "0x2D3A9F0", VA = "0x182D3B9F0")]
		public static bool operator ==(WorldLocatorId left, WorldLocatorId right)
		{
			return default(bool);
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x00009858 File Offset: 0x00007A58
		[Token(Token = "0x60020E8")]
		[Address(RVA = "0x2D3BA00", Offset = "0x2D3AA00", VA = "0x182D3BA00")]
		public static bool operator !=(WorldLocatorId left, WorldLocatorId right)
		{
			return default(bool);
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x00009870 File Offset: 0x00007A70
		[Token(Token = "0x60020E9")]
		[Address(RVA = "0xC91E00", Offset = "0xC90E00", VA = "0x180C91E00")]
		public static int GetByteCount()
		{
			return default(int);
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020EA")]
		[Address(RVA = "0x2D3ACD0", Offset = "0x2D39CD0", VA = "0x182D3ACD0")]
		public static WorldLocatorId FromHexString(string sourceString)
		{
			return null;
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x00009888 File Offset: 0x00007A88
		[Token(Token = "0x60020EB")]
		[Address(RVA = "0x2D3AA10", Offset = "0x2D39A10", VA = "0x182D3AA10")]
		public static Guid ConvertToGuid(WorldLocatorId id)
		{
			return default(Guid);
		}

		// Token: 0x04001E81 RID: 7809
		[Token(Token = "0x4001E81")]
		private const int ByteCount = 12;

		// Token: 0x04001E82 RID: 7810
		[Token(Token = "0x4001E82")]
		private const int ExpectedStringLength = 24;

		// Token: 0x04001E83 RID: 7811
		[Token(Token = "0x4001E83")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private byte[] _bytes;

		// Token: 0x04001E84 RID: 7812
		[Token(Token = "0x4001E84")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private static IEqualityComparer<byte[]> _worldObjectLocatorIdComparer;

		// Token: 0x04001E85 RID: 7813
		[Token(Token = "0x4001E85")]
		[FieldOffset(Offset = "0x8")]
		private static byte[] _guidBytesBufferCache;

		// Token: 0x04001E86 RID: 7814
		[Token(Token = "0x4001E86")]
		[FieldOffset(Offset = "0x10")]
		private static byte[] _clearedGuidBytesBufferCache;
	}
}
