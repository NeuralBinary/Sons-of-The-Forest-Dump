using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Sons.TerrainDetail
{
	// Token: 0x0200050C RID: 1292
	[Token(Token = "0x200050C")]
	[JsonConverter(typeof(WorldLocatorIdJsonConverter))]
	[Serializable]
	public class WorldLocatorId
	{
		// Token: 0x060021AA RID: 8618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021AA")]
		[Address(RVA = "0x332D0E0", Offset = "0x332B6E0", VA = "0x18332D0E0")]
		public WorldLocatorId(Guid guid)
		{
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021AB")]
		[Address(RVA = "0x332D1B0", Offset = "0x332B7B0", VA = "0x18332D1B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021AC")]
		[Address(RVA = "0x332D7F0", Offset = "0x332BDF0", VA = "0x18332D7F0")]
		public WorldLocatorId(byte[] sourceBytes)
		{
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021AD")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
		public byte[] GetBytes()
		{
			return null;
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x00009DB0 File Offset: 0x00007FB0
		[Token(Token = "0x60021AE")]
		[Address(RVA = "0x332D8B0", Offset = "0x332BEB0", VA = "0x18332D8B0")]
		public Vector3 GetLossyPosition()
		{
			return default(Vector3);
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021AF")]
		[Address(RVA = "0x332D9C0", Offset = "0x332BFC0", VA = "0x18332D9C0")]
		public static WorldLocatorId CalculateUniqueId(Vector3 position)
		{
			return null;
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x00009DC8 File Offset: 0x00007FC8
		[Token(Token = "0x60021B0")]
		[Address(RVA = "0x332DD70", Offset = "0x332C370", VA = "0x18332DD70")]
		protected bool Equals(WorldLocatorId other)
		{
			return default(bool);
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x00009DE0 File Offset: 0x00007FE0
		[Token(Token = "0x60021B1")]
		[Address(RVA = "0x332DDF0", Offset = "0x332C3F0", VA = "0x18332DDF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x00009DF8 File Offset: 0x00007FF8
		[Token(Token = "0x60021B2")]
		[Address(RVA = "0x332DF40", Offset = "0x332C540", VA = "0x18332DF40", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x00009E10 File Offset: 0x00008010
		[Token(Token = "0x60021B3")]
		[Address(RVA = "0x21F6260", Offset = "0x21F4860", VA = "0x1821F6260")]
		public static bool operator ==(WorldLocatorId left, WorldLocatorId right)
		{
			return default(bool);
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x00009E28 File Offset: 0x00008028
		[Token(Token = "0x60021B4")]
		[Address(RVA = "0x21F6680", Offset = "0x21F4C80", VA = "0x1821F6680")]
		public static bool operator !=(WorldLocatorId left, WorldLocatorId right)
		{
			return default(bool);
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x00009E40 File Offset: 0x00008040
		[Token(Token = "0x60021B5")]
		[Address(RVA = "0xE51990", Offset = "0xE4FF90", VA = "0x180E51990")]
		public static int GetByteCount()
		{
			return 0;
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021B6")]
		[Address(RVA = "0x332E0A0", Offset = "0x332C6A0", VA = "0x18332E0A0")]
		public static WorldLocatorId FromHexString(string sourceString)
		{
			return null;
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x00009E58 File Offset: 0x00008058
		[Token(Token = "0x60021B7")]
		[Address(RVA = "0x332E1F0", Offset = "0x332C7F0", VA = "0x18332E1F0")]
		public static Guid ConvertToGuid(WorldLocatorId id)
		{
			return default(Guid);
		}

		// Token: 0x04001F1F RID: 7967
		[Token(Token = "0x4001F1F")]
		private const int ByteCount = 12;

		// Token: 0x04001F20 RID: 7968
		[Token(Token = "0x4001F20")]
		private const int ExpectedStringLength = 24;

		// Token: 0x04001F21 RID: 7969
		[Token(Token = "0x4001F21")]
		private const int PosXByteIndex = 0;

		// Token: 0x04001F22 RID: 7970
		[Token(Token = "0x4001F22")]
		private const int PosYByteIndex = 4;

		// Token: 0x04001F23 RID: 7971
		[Token(Token = "0x4001F23")]
		private const int PosZByteIndex = 8;

		// Token: 0x04001F24 RID: 7972
		[Token(Token = "0x4001F24")]
		private const float WorldScaleFactor = 4000f;

		// Token: 0x04001F25 RID: 7973
		[Token(Token = "0x4001F25")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private byte[] _bytes;

		// Token: 0x04001F26 RID: 7974
		[Token(Token = "0x4001F26")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private static IEqualityComparer<byte[]> _worldObjectLocatorIdComparer;

		// Token: 0x04001F27 RID: 7975
		[Token(Token = "0x4001F27")]
		[FieldOffset(Offset = "0x8")]
		private static byte[] _guidBytesBufferCache;

		// Token: 0x04001F28 RID: 7976
		[Token(Token = "0x4001F28")]
		[FieldOffset(Offset = "0x10")]
		private static byte[] _clearedGuidBytesBufferCache;
	}
}
